import requests
from django.db.models import Q
from django.http import HttpResponse
from django.shortcuts import render
from .models import ChessGameGroup, ChessGame
from .forms import GetGamesByPlayer, CreateGroup, GroupStats
from .helpers import json_to_game, chess_game_stats


# Create your views here.
def index(request):
    return render(request, "ChessApp/index.html")


def group_stats(request):
    if request.method == 'POST':
        form = GroupStats(request.POST)
        if form.is_valid():
            # grab everything from the db
            group_id = form['Group'].value()
            group_db = ChessGameGroup.Groups.get(id=group_id)
            group_games1 = group_db.game_list1.filter(
                Q(white_player=group_db.player1) | Q(black_player=group_db.player1))
            group_games2 = group_db.game_list1.filter(
                Q(white_player=group_db.player2) | Q(black_player=group_db.player2))

            # generate some stats
            player_1_stats = chess_game_stats(group_games1, group_db.player1)
            player_2_stats = chess_game_stats(group_games2, group_db.player2)

            context = {'group_db': group_db,
                       'form': form,
                       'group_games1': group_games1,
                       'group_games2': group_games2,
                       'player_1_stats': player_1_stats,
                       'player_2_stats': player_2_stats
                       }

            return render(request, "ChessApp/group_stats.html", context)
    else:
        form = GroupStats()
        context = {'form': form}
        return render(request, "ChessApp/group_stats.html", context)


def create_group(request):
    if request.method == 'POST':
        form = CreateGroup(request.POST)
        if form.is_valid():
            new_group = ChessGameGroup()
            new_group.title = form['title'].value()
            new_group.player1 = form['username1'].value()
            new_group.player2 = form['username2'].value()
            new_group.save()
            games = ChessGame.Games.all()
            for g in games:
                if g.white_player == new_group.player1 or g.black_player == new_group.player1 or g.white_player == new_group.player2 or g.black_player == new_group.player2:
                    new_group.game_list1.add(g)
            context = {'form': form, 'msg': "Successfully created group."}
            return render(request, "ChessApp/create_group.html", context)
        else:
            return render(request, "ChessApp/create_group.html", {'form': form})
    else:
        new_group = CreateGroup()
        context = {'form': new_group}
        return render(request, "ChessApp/create_group.html", context)


def load_data(request):
    # request method is POST
    if request.method == 'POST':
        form = GetGamesByPlayer(request.POST)
        context = {'form': form}
        if form.is_valid():
            username = form['username'].value().strip()
            year = form['year'].value()
            month = form['month'].value()
            lookup_string = "https://api.chess.com/pub/player/{}/games/{}/{}".format(username, year, month)
            json_request = requests.get(lookup_string)
            # if we find a user on chess.com
            if json_request.status_code == requests.codes.ok:
                json_games = json_request.json()
                for game in json_games['games']:
                    json_to_game(game).save()
                load_status = "Loaded {} games.".format(len(json_games['games']))
                context.update({"load_status": load_status})
            # if no user found on chess.com
            else:
                load_status = "Username not found."
                context.update({"load_status": load_status})
        return render(request, "ChessApp/load_data.html", context)
    # request method is GET
    else:
        form = GetGamesByPlayer
        return render(request, "ChessApp/load_data.html", {'form': form})


def get_details(request):
    return HttpResponse("Get Details for thingy")



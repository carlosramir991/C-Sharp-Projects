from datetime import datetime
from .models import ChessGame, ChessGameGroup


# map a json file from chess.com to a ChessGame object
def json_to_game(json_obj):
    game = ChessGame()
    game.id = json_obj['url'].split('/')[-1]
    game.url = json_obj['url']
    game.time_control = json_obj['time_control']
    game.end_time = datetime.fromtimestamp(json_obj['end_time'])
    game.rated = json_obj['rated']
    game.fen = json_obj['fen']
    game.time_class = json_obj['time_class']
    game.rules = json_obj['rules']
    game.white_player = json_obj['white']['username']
    game.white_player_rating = json_obj['white']['rating']
    game.white_player_result = json_obj['white']['result']
    game.black_player = json_obj['black']['username']
    game.black_player_rating = json_obj['black']['rating']
    game.black_player_result = json_obj['black']['result']
    return game


# lookup all players in db, generate list of tuples
# sorted and distinct
def get_users_from_db():
    all_games = ChessGame.Games.all()
    distinct_users = set()
    result = []
    set_count = 0
    for i in all_games:
        distinct_users.add(i.white_player)
        if set_count < len(distinct_users):
            result.append((i.white_player, i.white_player))
            set_count += 1
        distinct_users.add(i.black_player)
        if set_count < len(distinct_users):
            result.append((i.black_player, i.black_player))
            set_count += 1

    def get_key(item):
        return item[1].casefold()

    return sorted(result, key=get_key)


# lookup all groups in db, generate list of tuples
# sorted
def get_groups_from_db():
    all_groups = ChessGameGroup.Groups.all()
    result = []
    for i in all_groups:
        result.append((i.id, i.title))

    def get_key(item):
        return item[1].casefold()

    return sorted(result, key=get_key)


# used to calc average opponent rating without breaking stuff
def chess_stats_avg(opp_total, total_games):
    try:
        return int(round(opp_total / total_games))
    except ZeroDivisionError:
        return 0


# used to calc win ratio without breaking stuff
def chess_stats_ratio(win, draw, loss):
    try:
        return round(win / (draw + loss), 1)
    except ZeroDivisionError:
        if win > 0 and (draw + loss) == 0:
            return win
        return 0


# calculate some basic stats for a group of chess games
# generate dictionary
def chess_game_stats(games, player):
    total_games = len(games)
    total_win = 0
    total_loss = 0
    total_draw = 0
    opp_rating_total = 0
    avg_opp_rating = 0
    win_ratio = 0

    if total_games > 0:
        for game in games:
            # if our player won, give them a win
            if game.white_player == player and game.white_player_result == 'win':
                total_win += 1
            elif game.black_player == player and game.black_player_result == 'win':
                total_win += 1
            # if either player agreed then game is a draw
            elif game.white_player_result == 'agreed':
                total_draw += 1
            # if our player did not timeout, then we must have lost
            elif (game.white_player == player and game.white_player_result != 'timeout') \
                    or (game.black_player == player and game.black_player_result != 'timeout'):
                total_loss += 1

            if game.white_player == player:
                opp_rating_total += int(game.black_player_rating)  # TODO: change this in the model to be an integer
            else:
                opp_rating_total += int(game.white_player_rating)

        avg_opp_rating = chess_stats_avg(opp_rating_total, total_games)
        win_ratio = chess_stats_ratio(total_win, total_draw, total_loss)

    return {'total_games': total_games,
            'total_win': total_win,
            'total_loss': total_loss,
            'total_draw': total_draw,
            'win_ratio': win_ratio,
            'avg_opp_rating': avg_opp_rating,
            }

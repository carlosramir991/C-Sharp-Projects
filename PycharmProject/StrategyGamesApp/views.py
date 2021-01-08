from django.shortcuts import render
from django.http import HttpResponse


# Create your views here.

def index(request):
    return render(request, "StrategyGamesApp/home.html")

def game_create(request):
    return render(request, "StrategyGamesApp/StrategyGameAppAdd.html")
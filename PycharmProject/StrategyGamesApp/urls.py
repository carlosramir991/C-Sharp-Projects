from django.urls import path
from . import views

urlpatterns = [
    path('', views.index, name='StrategyGamesHome'),
    path('create-strategygame', views.game_create, name='add game'),
]
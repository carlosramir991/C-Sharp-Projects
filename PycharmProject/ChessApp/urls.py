from django.urls import path
from . import views

urlpatterns = [
    path('', views.index, name='chess_app_home'),
    path('load_data', views.load_data, name='load_data'),
    path('create_group', views.create_group, name='create_group'),
    path('group_stats', views.group_stats, name='group_stats'),
    path('game_details', views.get_details, name='game_details'),
]
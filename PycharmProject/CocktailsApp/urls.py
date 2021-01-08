from django.urls import path
from . import views

urlpatterns = [
    path('', views.CocktailsApp_home, name='CocktailsApp_home'),
    path('Create', views.create, name='CocktailsApp_create'),
    path('Index', views.index, name='CocktailsApp_index'),
    path('Details/<int:pk>/', views.details, name='CocktailsApp_details'),


]
from django.urls import path
from . import views

urlpatterns = [
    path('', views.home, name="find_pet_home"),
    path('applicants/', views.applicants, name="applicants"),
    path('available/', views.available_pets, name="available_pets"),
    path('confirmed/', views.confirmed, name="confirmed"),
    path('contact/', views.find_pet_contact, name="find_pet_contact"),
    path('details/<int:available_id>/', views.pet_details, name="pet_details"),
    path('edit/<int:available_id>/', views.edit_pet_listing, name="edit_pet_listing"),
    path(r'edit_confirmed/(?P<pk>\d+)/$', views.edit_confirmed, name="edit_confirmed"),
    path('delete_confirmed/<str:pet_name>/', views.delete_confirmed, name="delete_confirmed"),
    path('../', views.app_builder_home, name="app_builder_home"),
]

"""AppBuilder9000 URL Configuration

The `urlpatterns` list routes URLs to views. For more information please see:
    https://docs.djangoproject.com/en/2.2/topics/http/urls/
Examples:
Function views
    1. Add an import:  from my_app import views
    2. Add a URL to urlpatterns:  path('', views.home, name='home')
Class-based views
    1. Add an import:  from other_app.views import Home
    2. Add a URL to urlpatterns:  path('', Home.as_view(), name='home')
Including another URLconf
    1. Import the include() function: from django.urls import include, path
    2. Add a URL to urlpatterns:  path('blog/', include('blog.urls'))
"""
#from django.contrib.staticfiles.urls import staticfiles_urlpatterns
#from django.conf import settings    #FOR PILLOW LIBRARY
#from django.conf.urls.static import static     #FOR PILLOW LIBRARY
from django.contrib import admin
from django.urls import path, include
from . import views

urlpatterns = [
    path('admin/', admin.site.urls),
    path('', views.home, name='home'),
    path('RestaurantApp/', include('RestaurantApp.urls')),
    path('StockTraderApp/', include('StockTraderApp.urls')),
    path('FestivalApp/', include('FestivalApp.urls')),
    path('VegRestaurant/', include('VegRestaurant.urls')),
    path('ClassicalMusic/', include('ClassicalMusic.urls')),
    path('BasketballApp/', include('BasketballApp.urls')),
    path('MarvelComicsApp/', include('MarvelComicsApp.urls')),
    path('CodeBookApp/', include('CodeBookApp.urls')),
    path('PlantApp/', include('PlantApp.urls')),
    path('SeattleNightLife/', include('SeattleNightLife.urls')),
    path('AstronomyApp/', include('AstronomyApp.urls')),
    path('DuneApp/', include('DuneApp.urls')),
    path('ArtistsApp/', include('ArtistsApp.urls')),
    path('FindPetApp/', include('FindPetApp.urls')),
    path('account/', include('account.urls')),
    path('CocktailsApp/', include('CocktailsApp.urls')),
    # path('WorldwideRecipes/', include('WorldwideRecipes.urls')),
    path('Chess/', include('ChessApp.urls')),
    path('SeafoodApp/', include('SeafoodApp.urls')),
    path('StrategyGamesApp/', include('StrategyGamesApp.urls')),
]
#urlpatterns +=staticfiles_urlpatterns()

#if settings.DEBUG:  # FOR PILLOW LIBRARY
#    urlpatterns += static(settings.MEDIA_URL, document_root=settings.MEDIA_ROOT)
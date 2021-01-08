from django.shortcuts import render, redirect, get_object_or_404
from .forms import CocktailForm
from .models import Cocktail

from django.core.paginator import Paginator



# Render home page
def CocktailsApp_home(request):
    return render(request, 'CocktailsApp/CocktailsApp_home.html')


# Add Cocktail to database
def create(request):
    if request.method == 'POST':
        form = CocktailForm(request.POST)
        if form.is_valid():
            form.save()
            return redirect('CocktailsApp_home')
    else:
        form = CocktailForm()
    context = {'form': form}
    return render(request, 'CocktailsApp/CocktailsApp_create.html', context)

# Render Cocktails index page
def CocktailsApp_index(request):
    return render(request, 'CocktailsApp/CocktailsApp_index.html')



# Display added cocktails from db with pagination
def index(request):
    form = CocktailForm()
    cocktails = Cocktail.objects.all()
    page = Paginator(cocktails, 3)
    page_number = request.GET.get('page')
    page_obj = page.get_page(page_number)
    context = {'form': form, 'cocktails': cocktails}
    return render(request, 'CocktailsApp/CocktailsApp_index.html', {'page_obj': page_obj}, context)

# Display details (ingredients) of a single cocktail from within db
def details(request, pk):
    return render(request, 'CocktailsApp/CocktailsApp_details.html', {'cocktail': Cocktail.objects.get(pk=pk)})

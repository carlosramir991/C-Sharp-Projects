from django.shortcuts import render, get_object_or_404, redirect
from .forms import PetApplicantForm, AvailablePetForm
from .models import PetApplicant, AvailablePet


# Create your views here.


def home(request):
    return render(request, 'FindPetApp/find_pet_home.html')


def applicants(request):
    if request.method == 'POST':
        if 'Add_Applicant' in request.POST:
            applyform = PetApplicantForm(data=request.POST)
            if applyform.is_valid():
                applyform.save()
                return redirect('confirmed')
        if 'Add_Rescue' in request.POST:
            petform = AvailablePetForm(data=request.POST)
            if petform.is_valid():
                petform.save()
                return redirect('confirmed')
    else:
        applyform = PetApplicantForm()
        petform = AvailablePetForm()

    content = {'applyform': applyform, 'petform': petform}
    return render(request, 'FindPetApp/applicants.html', content)


def available_pets(request):
    available = AvailablePet.Available.all()
    applicant = PetApplicant.Applicant.all()
    content = {'available': available, 'applicant': applicant}
    return render(request, 'FindPetApp/available_pets.html', content)


def confirmed(request):
    return render(request, 'FindPetApp/confirmed.html')


def find_pet_contact(request):
    return render(request, 'FindPetApp/find_pet_contact.html')


def pet_details(request, available_id):
    pet = get_object_or_404(AvailablePet, pk=available_id)
    pet_name = pet.name
    if request.method == 'POST':
        pet.delete()
        return redirect('delete_confirmed', pet_name)
    content = {'pet': pet}
    return render(request, 'FindPetApp/pet_details.html', content)


def edit_pet_listing(request, available_id):
    pet = get_object_or_404(AvailablePet, pk=available_id)
    if request.method == 'POST':
        petform = AvailablePetForm(data=request.POST, instance=pet)
        if petform.is_valid():
            petform.save()
            return redirect('edit_confirmed', pet.id)
    else:
        petform = AvailablePetForm(instance=pet)
    content = {'pet': pet, 'petform': petform}
    return render(request, 'FindPetApp/edit_pet_listing.html', content)


def edit_confirmed(request, pk):
    pet = get_object_or_404(AvailablePet, pk=pk)
    content = {'pet': pet}
    return render(request, 'FindPetApp/edit_confirmed.html', content)


def delete_confirmed(request, pet_name):
    pet = pet_name
    content = {'pet': pet}
    return render(request, 'FindPetApp/delete_confirmed.html', content)


def app_builder_home(request):
    return render(request, '/index.html')

from django.contrib.auth import logout
from django.shortcuts import render, redirect
from django.contrib.auth.forms import UserCreationForm
from django.contrib.auth import authenticate, login
from .models import Equipo, Jugador, Tecnico    


def home(request):
    return render(request, 'home.html')

def login_view(request):
    if request.method == 'POST':
        username = request.POST['username']
        password = request.POST['password']
        user = authenticate(request, username=username, password=password)
        if user is not None:
            login(request, user)
            return redirect('home')  # Redirige al home después de iniciar sesión
        else:
            # Aquí puedes manejar el error de autenticación
            pass
    return render(request, 'login.html')

def registro(request):
    if request.method == 'POST':
        form = UserCreationForm(request.POST)
        if form.is_valid():
            form.save()
            return redirect('login')  # Redirige a la página de inicio de sesión después de registrarse
    else:
        form = UserCreationForm()
    return render(request, 'registro.html', {'form': form})

def logout_view(request):
    logout(request)
    return redirect('home')  # Redirige al home después de cerrar sesión

def equipos(request):
    equipos = Equipo.objects.all()  # Obtén todos los equipos de la base de datos
    return render(request, 'equipos.html', {'equipos': equipos})  # Pasa los equipos al template

def jugadores(request):
    jugadores = Jugador.objects.all()  # Obtén todos los jugadores de la base de datos
    return render(request, 'jugadores.html', {'jugadores': jugadores})  # Pasa los jugadores al template

def tecnicos(request):
    tecnicos = Tecnico.objects.all()  # Obtener todos los técnicos de la base de datos
    return render(request, 'tecnicos.html', {'tecnicos': tecnicos})  # Renderizar el template



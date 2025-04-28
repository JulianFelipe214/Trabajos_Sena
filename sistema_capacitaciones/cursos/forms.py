from django import forms
from django.contrib.auth.forms import UserCreationForm
from .models import UsuarioPersonalizado, Rol, Cargo

class RegistroForm(UserCreationForm):
    class Meta:
        model = UsuarioPersonalizado
        fields = ['username', 'first_name', 'last_name', 'email', 'password1', 'password2', 'cargo', 'roles']

    def __init__(self, *args, **kwargs):
        super().__init__(*args, **kwargs)
        self.fields['cargo'].queryset = Cargo.objects.all()
        self.fields['roles'].queryset = Rol.objects.all()
from django.db import models
from django.contrib.auth.models import AbstractUser
from django.conf import settings

# PRIMERO define Rol y Cargo antes de UsuarioPersonalizado
class Rol(models.Model):
    nombre = models.CharField(max_length=50, unique=True)
    
    def __str__(self):
        return self.nombre

class Cargo(models.Model):
    nombre = models.CharField(max_length=50, unique=True)
    
    def __str__(self):
        return self.nombre

# LUEGO define el modelo de usuario personalizado
class UsuarioPersonalizado(AbstractUser):
    roles = models.ManyToManyField(Rol, blank=True)
    cargo = models.ForeignKey(Cargo, on_delete=models.SET_NULL, null=True, blank=True)
    telefono = models.CharField(max_length=15, blank=True)
    
    def __str__(self):
        return f"{self.get_full_name()} ({self.username})"

    class Meta:
        verbose_name = 'Usuario'
        verbose_name_plural = 'Usuarios'

# FINALMENTE define Curso (que depende de UsuarioPersonalizado)
class Curso(models.Model):
    nombre = models.CharField("Nombre del Curso", max_length=200)
    descripcion_corta = models.TextField("Descripción Corta", max_length=300, blank=True)
    fecha_inicio = models.DateField("Fecha de Inicio")
    fecha_finalizacion = models.DateField("Fecha de Finalización")
    instructor = models.ForeignKey(
        settings.AUTH_USER_MODEL,
        on_delete=models.CASCADE,
        verbose_name="Instructor"
    )
    imagen = models.ImageField("Imagen del Curso", upload_to='cursos/', null=True, blank=True)

    def __str__(self):
        return self.nombre

    class Meta:
        verbose_name = "Curso"
        verbose_name_plural = "Cursos"
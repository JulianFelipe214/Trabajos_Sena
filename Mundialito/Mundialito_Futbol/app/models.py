from django.db import models

class Equipo(models.Model):
    nombre = models.CharField(max_length=100)
    imagen_bandera = models.ImageField(upload_to='banderas/')
    escudo = models.ImageField(upload_to='escudos/')

    def __str__(self):
        return self.nombre

class PosicionDeJuego(models.Model):
    nombre = models.CharField(max_length=50)
    descripcion = models.TextField()

    def __str__(self):
        return self.nombre

class Jugador(models.Model):
    nombre = models.CharField(max_length=50)
    apellido = models.CharField(max_length=50)
    foto = models.ImageField(upload_to='jugadores/')
    fecha_nacimiento = models.DateField()
    posicion = models.ForeignKey(PosicionDeJuego, on_delete=models.CASCADE)
    numero_camiseta = models.PositiveIntegerField()
    es_titular = models.BooleanField(default=False)
    equipo = models.ForeignKey(Equipo, on_delete=models.CASCADE)

    def __str__(self):
        return f"{self.nombre} {self.apellido}"

class Tecnico(models.Model):
    nombre = models.CharField(max_length=50)
    apellido = models.CharField(max_length=50)
    fecha_nacimiento = models.DateField()
    nacionalidad = models.CharField(max_length=50, choices=[
         ('Colombia', 'Colombia'),
        ('Argentina', 'Argentina'),
        ('Chile', 'Chile'),
        ('España', 'España'),
        ('Brazil', 'Brazil'),
        ('Mexico', 'Mexico'),
        ('Japon', 'Japon'),
        
    ])
    rol = models.CharField(max_length=30, choices=[
        ('Técnico', 'Técnico'),
        ('Asistente', 'Asistente'),
        ('Médico', 'Médico'),
        ('Preparador Físico', 'Preparador Físico'),
    ])

    def __str__(self):
        return f"{self.nombre} {self.apellido}"


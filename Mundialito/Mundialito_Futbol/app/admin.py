from django.contrib import admin
from .models import Equipo, PosicionDeJuego, Jugador, Tecnico

@admin.register(Equipo)
class EquipoAdmin(admin.ModelAdmin):
    list_display = ('nombre', 'show_bandera', 'show_escudo')
    search_fields = ('nombre',)

    def show_bandera(self, obj):
        if obj.imagen_bandera:  # Asegúrate de que el campo exista en tu modelo
            return f'<img src="{obj.imagen_bandera.url}" style="width: 50px; height: auto;" />'
        return ''
    show_bandera.allow_tags = True  # Elimina esto si estás usando Django 3.1 o posterior
    show_bandera.short_description = 'Bandera'

    def show_escudo(self, obj):
        if obj.escudo:  # Asegúrate de que el campo exista en tu modelo
            return f'<img src="{obj.escudo.url}" style="width: 50px; height: auto;" />'
        return ''
    show_escudo.allow_tags = True  # Elimina esto si estás usando Django 3.1 o posterior
    show_escudo.short_description = 'Escudo'

@admin.register(PosicionDeJuego)
class PosicionAdmin(admin.ModelAdmin):
    list_display = ('nombre', 'descripcion')
    search_fields = ('nombre',)

@admin.register(Jugador)
class JugadorAdmin(admin.ModelAdmin):
    list_display = ('nombre', 'apellido', 'equipo', 'posicion', 'numero_camiseta', 'es_titular', 'show_image')
    list_filter = ('equipo', 'posicion', 'es_titular')
    search_fields = ('nombre', 'apellido', 'numero_camiseta')

    def show_image(self, obj):
        if obj.foto:  # Asegúrate de que el campo exista en tu modelo
            return f'<img src="{obj.foto.url}" style="width: 50px; height: auto;" />'
        return ''
    show_image.allow_tags = True  # Elimina esto si estás usando Django 3.1 o posterior
    show_image.short_description = 'Foto'

@admin.register(Tecnico)
class TecnicoAdmin(admin.ModelAdmin):
    list_display = ('nombre', 'apellido', 'fecha_nacimiento', 'nacionalidad', 'rol')
    list_filter = ('rol',)
    search_fields = ('nombre', 'apellido', 'nacionalidad')

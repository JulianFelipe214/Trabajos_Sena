from django.contrib import admin
from .models import Curso

from django.contrib.auth.admin import UserAdmin
from .models import UsuarioPersonalizado, Rol, Cargo

class CursoAdmin(admin.ModelAdmin):
    list_display = ('nombre', 'fecha_inicio', 'fecha_finalizacion', 'instructor')  # Campos visibles en la lista
    list_filter = ('fecha_inicio', 'instructor')  # Filtros laterales
    search_fields = ('nombre', 'descripcion_corta')  # Búsqueda por estos campos
    fieldsets = (
        ('Información Básica', {
            'fields': ('nombre', 'descripcion_corta', 'imagen')
        }),
        ('Fechas e Instructor', {
            'fields': ('fecha_inicio', 'fecha_finalizacion', 'instructor')
        }),
    )

admin.site.register(Curso, CursoAdmin)




class UsuarioAdmin(UserAdmin):
    list_display = ('username', 'email', 'first_name', 'last_name', 'cargo', 'is_staff')
    filter_horizontal = ('roles', 'groups', 'user_permissions')
    fieldsets = UserAdmin.fieldsets + (
        ('Información Adicional', {'fields': ('cargo', 'roles', 'telefono')}),
    )

admin.site.register(UsuarioPersonalizado, UsuarioAdmin)
admin.site.register(Rol)
admin.site.register(Cargo)
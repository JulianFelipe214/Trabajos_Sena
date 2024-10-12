from django.urls import path
from .views import home, login_view, registro, logout_view, equipos, jugadores, tecnicos
from django.conf import settings
from django.conf.urls.static import static

urlpatterns = [
    path('', home, name='home'),  
    path('login/', login_view, name='login'),  
    path('logout/', logout_view, name='logout'),  
    path('registro/', registro, name='registro'),
    path('equipos/', equipos, name='equipos'),  # Vista para equipos
    path('jugadores/', jugadores, name='jugadores'),  # Vista para jugadores
    path('tecnicos/', tecnicos, name='tecnicos'),  # Ruta para técnicos
]
if settings.DEBUG:
    urlpatterns += static(settings.MEDIA_URL, document_root=settings.MEDIA_ROOT)

# ProyectoFinalSistemasIntegrados
# Turismo Local - Portal Web ASP.NET MVC

## Descripción

**Turismo Local** es un portal web desarrollado con **ASP.NET MVC** y **SQLite** como base de datos.  
El objetivo del proyecto es mostrar información turística de la ciudad, incluyendo lugares destacados, recursos culturales y testimonios de los visitantes. Todo se encuentra en una **única página**, con un diseño responsive usando **Bootstrap** y estilos personalizados en `site.css`.

---

## Características principales

- **Header y navegación**: Menú con enlaces a secciones: Inicio, Lugares, Recursos, Testimonios y Contacto.  
- **Hero / Introducción**: Banner llamativo con imagen de la ciudad y mensaje motivador.  
- **Sección Lugares**: Muestra 3 lugares destacados con imagen, descripción y botón de detalle.  
- **Sección Recursos**: Enlaces a PDF, videos y artículos culturales.  
- **Sección Testimonios**: CRUD de testimonios usando SQLite.  
- **Sección Contacto**: Formulario funcional para enviar mensajes.  
- **Footer**: Redes sociales y derechos reservados.  
- **Diseño responsive** con Bootstrap y CSS personalizado (`site.css`).  

---

## Tecnologías utilizadas

- **ASP.NET MVC 6 / .NET 6 o superior**  
- **SQLite** para la base de datos local  
- **Entity Framework Core** para el ORM  
- **Bootstrap 5** para el diseño responsive  
- **HTML, CSS y Razor Views** para la interfaz  

---


## Estructura del proyecto
ProyectoFinalSistemasIntegrados/
│
├─ Controllers/
│ └─ TestimoniosController.cs
│
├─ Models/
│ └─ Testimonio.cs
│
├─ Views/
│ └─ Home/
│ └─ Index.cshtml
│
├─ wwwroot/
│ └─ css/
│ └─ site.css
│
├─ appsettings.json
└─ ProyectoFinalSistemasIntegrados.csproj

---Proyecto educativo / portafolio p<img width="1908" height="825" alt="Captura de pantalla 2025-09-24 114302" src="https://github.com/user-attachments/assets/15f876cd-df74-4602-93a8-e4600a6278f2" />
<img width="1919" height="817" alt="Captura de pantalla 2025-09-24 114251" src="https://github.com/user-attachments/assets/97cbf8fd-3647-49ac-8652-33a956e57f1e" />
<img width="1919" height="940" alt="Captura de pantalla 2025-09-24 114206" src="https://github.com/user-attachments/assets/84f01069-0b4b-401c-8bba-a9f71f161ac2" />
<img width="1919" height="885" alt="Captura de pantalla 2025-09-24 111742" src="https://github.com/user-attachments/assets/58129e49-181b-483b-bd96-52b083006d59" />
<img width="1919" height="719" alt="Captura de pantalla 2025-09-24 114554" src="https://github.com/user-attachments/assets/3ce13e49-3c25-4754-b086-2383f7e9936b" />
<img width="1919" height="836" alt="Captura de pantalla 2025-09-24 114534" src="https://github.com/user-attachments/assets/8bd01a88-6a53-42f7-b429-c9124cde1e17" />
<img width="1918" height="733" alt="Captura de pantalla 2025-09-24 114520" src="https://github.com/user-attachments/assets/20bf903f-f7af-4b6f-8b9c-f6c51da2cdd2" />
<img width="1919" height="717" alt="Captura de pantalla 2025-09-24 114457" src="https://github.com/user-attachments/assets/3c76ff67-2581-48c5-9273-900456af0ad9" />
<img width="1919" height="543" alt="Captura de pantalla 2025-09-24 114345" src="https://github.com/user-attachments/assets/d490c6fe-d33b-4c4e-a969-91e28c36dfb8" />
<img width="1919" height="813" alt="Captura de pantalla 2025-09-24 114328" src="https://github.com/user-attachments/assets/3be93d3d-1658-427c-8bb0-bd01cebb7fca" />
ersonal


## Instalación y uso

1. Clonar el repositorio:
```bash
git clone https://github.com/tuusuario/ProyectoFinalSistemasIntegrados.git
Abrir el proyecto en Visual Studio 2022 o superior.

Restaurar los paquetes NuGet:

Microsoft.EntityFrameworkCore.Sqlite

Microsoft.EntityFrameworkCore.Tools

Ejecutar migraciones (si no se ha creado la base de datos):
Ejecutar el proyecto:

Presiona F5 o Ctrl + F5 en Visual Studio.

La aplicación abrirá https://localhost:7260/ (o el puerto asignado).

Probar funcionalidades:

Crear testimonios desde la sección correspondiente.

Navegar por las secciones: Lugares, Recursos y Contacto.
Notas

Las imágenes del banner y de lugares son placeholder; se pueden reemplazar por imágenes reales.

Los recursos (PDF, videos, artículos) se agregan en la sección Recursos.

El proyecto está pensado para ser expandible, por ejemplo agregando más lugares, CRUD completo para testimonios o contacto con correo electrónico.

Autor

Jair Neuta





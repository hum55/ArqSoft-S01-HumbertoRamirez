<br>
<div align="center">

<img src="docs/images/banner.png" alt="Leyendas del Fútbol" width="600"/>

<br><br>

# LEYENDAS DEL FÚTBOL

**Catálogo interactivo de los mejores jugadores de la historia**

<br>

[![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-MVC-512BD4?style=flat-square&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-12.0-239120?style=flat-square&logo=csharp&logoColor=white)](https://learn.microsoft.com/dotnet/csharp/)
[![HTML5](https://img.shields.io/badge/HTML5-E34F26?style=flat-square&logo=html5&logoColor=white)](https://developer.mozilla.org/docs/Web/HTML)
[![CSS3](https://img.shields.io/badge/CSS3-1572B6?style=flat-square&logo=css3&logoColor=white)](https://developer.mozilla.org/docs/Web/CSS)
[![JavaScript](https://img.shields.io/badge/JavaScript-ES6+-F7DF1E?style=flat-square&logo=javascript&logoColor=black)](https://developer.mozilla.org/docs/Web/JavaScript)
[![License](https://img.shields.io/badge/License-MIT-blue?style=flat-square)](LICENSE)

<br>

[Características](#-características) · [Capturas](#-capturas-de-pantalla) · [Instalación](#-instalación) · [Estructura](#-estructura-del-proyecto) · [Tecnologías](#-tecnologías) · [Autor](#-autor)

</div>

<br>

---

<br>

## Descripción

Aplicación web desarrollada en **ASP.NET Core MVC** que presenta un catálogo cinematográfico e interactivo de las leyendas del fútbol mundial. Inspirado en la estética de **FIFA Ultimate Team**, **EA Sports FC** y presentaciones premium de la **UEFA Champions League**, el proyecto combina diseño minimalista con animaciones fluidas para crear una experiencia visual inmersiva.

Cada jugador cuenta con una ficha detallada que incluye estadísticas históricas, clubes donde hicieron historia, biografía y datos personales, todo presentado con efectos cinematográficos y transiciones elegantes.

<br>

## ✦ Características

<br>

**Diseño Visual**
- Fondo con mosaico de fotografías de fútbol con animación de movimiento
- Partículas doradas flotantes y efectos de iluminación ambiental
- Paleta cinematográfica oscura con acentos dorados
- Tipografía premium: Josefin Sans y Raleway
- Sin emojis — estética completamente minimalista

<br>

**Carrusel 3D**
- Rotación tipo disco con perspectiva 3D real
- Carta central destacada con escala y brillo superiores
- Navegación con botones, teclado (flechas) y swipe táctil
- Indicadores de posición animados
- Transiciones fluidas con cubic-bezier

<br>

**Modo Legendario**
- Expansión cinematográfica al hacer clic en cualquier carta
- Efecto de brillo dorado diagonal animado (shine sweep)
- Glow pulsante y silueta con levitación
- Panel de información con datos, clubes y biografía
- Efecto typewriter en la biografía con cursor parpadeante
- Fondo totalmente oscurecido para enfocar al jugador

<br>

**Página de Inicio**
- Video fullscreen de fondo con parallax al scroll
- Siluetas animadas de jugadores en el hero
- Secciones con efecto de aparición al scroll (Intersection Observer)
- Contadores animados de estadísticas
- Sección "Donde Hicieron Historia" con escudos reales de clubes
- Ranuras entre secciones donde se ve el video de fondo
- Efecto typewriter en logros de cada jugador

<br>

**Jugadores Incluidos**

| Jugador | País | Club Histórico | Goles |
|:--------|:-----|:---------------|------:|
| Lionel Messi | Argentina | FC Barcelona | 838 |
| Cristiano Ronaldo | Portugal | Real Madrid | 925 |
| Neymar Jr | Brasil | Santos FC | 439 |
| Kylian Mbappé | Francia | PSG | 312 |
| Mohamed Salah | Egipto | Liverpool FC | 326 |

<br>

## ✦ Capturas de Pantalla

<br>

<div align="center">

### Catálogo — Carrusel 3D

<img src="docs/images/screenshot-catalog.png" alt="Catálogo" width="800"/>

<br><br>

### Modo Legendario — Vista Expandida

<img src="docs/images/screenshot-legend.png" alt="Modo Legendario" width="800"/>

<br><br>

### Home — Sección de Jugadores

<img src="docs/images/screenshot-home.png" alt="Home" width="800"/>

</div>

<br>

## ✦ Instalación

<br>

**Requisitos previos**
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) o superior
- Visual Studio 2022 / VS Code / Rider

<br>

**Clonar el repositorio**

```bash
git clone https://github.com/tu-usuario/catalogo-leyendas-futbol.git
cd catalogo-leyendas-futbol
```

<br>

**Ejecutar el proyecto**

```bash
dotnet restore
dotnet run
```

La aplicación estará disponible en `https://localhost:5001`

<br>

## ✦ Estructura del Proyecto

```
Catalogo/
│
├── Controllers/
│   ├── HomeController.cs           # Controlador de la página de inicio
│   └── CatalogoController.cs      # Controlador del catálogo (datos estáticos)
│
├── Models/
│   └── Item.cs                     # Modelo del jugador (18 propiedades)
│
├── Views/
│   ├── Home/
│   │   └── Index.cshtml            # Página de inicio con video y animaciones
│   └── Catalogo/
│       ├── Index.cshtml            # Catálogo con carrusel 3D y modo legendario
│       ├── Agregar.cshtml          # Formulario para agregar jugadores
│       └── Detalle.cshtml          # Vista detalle individual
│
├── wwwroot/
│   ├── css/
│   │   └── site.css                # Estilos globales del catálogo
│   ├── imagenes/                   # Banderas, escudos de clubes, fotos de fondo
│   └── videos/                     # Video de fondo para la página de inicio
│
├── Program.cs                      # Configuración mínima de la aplicación
└── README.md
```

<br>

## ✦ Tecnologías

<br>

| Categoría | Tecnología |
|:----------|:-----------|
| Backend | ASP.NET Core 8.0 MVC, C# 12 |
| Frontend | HTML5, CSS3 (animaciones, 3D transforms, backdrop-filter) |
| JavaScript | Vanilla JS, Intersection Observer API, requestAnimationFrame |
| Tipografías | Josefin Sans, Raleway, Oswald (Google Fonts) |
| Datos | Lista estática en el controlador (sin base de datos) |
| Diseño | Responsive, Mobile-first, Minimalista |

<br>

## ✦ Características Técnicas

- **Sin base de datos** — Los datos de los jugadores se almacenan como lista estática en el controlador, facilitando el despliegue sin dependencias externas
- **Sin Identity/Auth** — Proyecto enfocado exclusivamente en la experiencia visual
- **Layout = null** — Cada vista es un documento HTML completo e independiente con sus propios estilos inline
- **Carrusel 3D puro** — Implementado con CSS `transform-style: preserve-3d`, `perspective` y `translateZ` sin librerías externas
- **Animaciones nativas** — Todas las animaciones usan CSS Keyframes y JavaScript vanilla sin frameworks
- **Serialización JSON** — Los datos del modelo se pasan al frontend con `System.Text.Json.JsonSerializer` con `CamelCase` naming policy

<br>

## ✦ Autor

Desarrollado como proyecto académico de ASP.NET Core MVC.

Por: HUMBERTO RAMIREZ GRUINTAL. ING SOFTWARE. TEC DE SOFTWARE

<br>

---

<div align="center">

<br>

*"El fútbol es el deporte más hermoso del mundo"*

<br>


</div>
# C-API

Digidex es una aplicación web que permite buscar y filtrar información de Digimon usando una API creada en ASP.NET.
Incluye un buscador por nombre o ID y un menú de filtros para mostrar distintos detalles de los Digimon.

# ⚙️ Requisitos

Visual Studio Code o Visual Studio

.NET 7 SDK

Navegador moderno (Chrome, Edge, Firefox)

Conexión a la API local: http://localhost:5187/api/digimon

# 🚀 Instalación y ejecución

Clona o descarga este repositorio.

Abre la carpeta del proyecto en Visual Studio Code o Visual Studio.

Asegúrate de que tu API de ASP.NET esté corriendo en http://localhost:5187/api/digimon.

Abre index.html en tu navegador.

Ingresa un nombre o ID en el buscador y presiona Buscar.

# 🧩 Funcionalidades

Búsqueda por nombre o ID: permite encontrar cualquier Digimon de la base de datos.

Menú de filtros: muestra información detallada como:

- Fecha de lanzamiento:
  Muestra solo la fecha de lanzamiento del digimon seleccionado

- Nivel:
  Muestra solo el nivel del digimon seleccionado (child, rookie...)

- Tipos:
  Muestra el tipo que es el digimon (vacuna, datos, virus)

- Atributos:
  Muestra los atributos del digimon seleccionado (luz, oscuridad, )

- Campos

- Descripción

- Habilidades

- Imagen

# 💻 Uso

Escribe el nombre o ID de un Digimon en la caja de búsqueda.

Presiona Buscar.

El resultado aparecerá en la sección de resultados.

Para ver detalles específicos, abre el menú de filtros y selecciona la categoría deseada.

# Sistema de Gestión de Citas para Enfermería

Este proyecto es una aplicación web desarrollada con .NET 8 y ASP.NET Core MVC diseñada para 
modernizar y optimizar la administración de citas en un entorno de enfermería. La aplicación 
permite al personal administrativo gestionar la disponibilidad de horarios de atención de una 
manera visual, dinámica e intuitiva.

## Características Principales

*   Gestión de Disponibilidad por Día: Permite a la secretaria seleccionar cualquier fecha para visualizar y configurar la disponibilidad de citas.
*   Generación Automática de Horarios: Al acceder a un día por primera vez, el sistema crea automáticamente los horarios de atención (de 7:00 AM a 5:00 PM) con una cantidad de citas por defecto, agilizando la configuración inicial
*   Interfaz Interactiva y Dinámica: Utiliza JavaScript y AJAX para una experiencia de usuario fluida, permitiendo modificar la cantidad de citas disponibles para cada hora sin necesidad de recargar la página.
*   Feedback en Tiempo Real: El estado de cada franja horaria (Activo/Cancelado) se actualiza visualmente al instante según la cantidad de citas disponibles.
*	Persistencia de Datos Segura: Los cambios se guardan en la base de datos de forma eficiente mediante una llamada AJAX, utilizando transacciones de SQL para garantizar la integridad de los datos.
*	Diseño Moderno y Responsivo: La interfaz ha sido cuidadosamente diseñada con CSS personalizado para ofrecer una experiencia visual limpia, profesional y agradable, incluyendo un selector de fecha estilizado.

## Tecnologías Utilizadas

		## Backend
*   Framework: .NET 8
*	Arquitectura: ASP.NET Core MVC
*	Acceso a Datos (ORM): Entity Framework Core 8
*	Base de Datos: SQL Server Express 2022 

		## Frontend
*   Lenguajes: HTML5, CSS3, JavaScript (ES6)
*	Framework CSS: Bootstrap 5 (como base, con amplia personalización)
*	Librería JavaScript: jQuery (para manipulación del DOM y llamadas AJAX)
*	Selector de Fecha: flatpickr.js (para una experiencia de calendario mejorada)
*	Tipografía: Google Fonts (Montserrat y Playfair Display)

		## Herramientas de Desarrollo
*   IDE: Visual Studio 2022
*	Gestión de Base de Datos: SQL Server Management Studio (SSMS)
*	Control de Versiones: Git y GitHub


## Requisitos Previos
Para ejecutar este proyecto localmente, necesitarás tener instalado lo siguiente:
*   SDK de .NET 8
*	Visual Studio 2022
*	SQL Server Express 2022

	
## Cómo Ejecutar el Proyecto

		1. Clonar el Repositorio (con comandos)
cd C:\Users\TuUsuario\source\repos
git clone https://github.com/Isoza05/EnfermeriaProyecto.git
cd EnfermeriaProyecto

		2. Configurar la Base de Datos 
El proyecto está diseñado para funcionar con una base de datos local de SQL Server Express.
1.Abre SQL Server Management Studio (SSMS).
2.El script para crear la base de datos, las tablas y los triggers se encuentra en la raíz del proyecto. Ejecuta este script para crear la base de datos enfermeria y toda su estructura.	

		3.Ejecutar la Aplicación
*	En Visual Studio, asegúrate de que el proyecto de inicio esté seleccionado.
*   Presiona F5 o el botón "play" (con el nombre del proyecto) para compilar y ejecutar la aplicación.
*   Visual Studio abrirá automáticamente un navegador web con la aplicación en ejecución.
*   Navega a la URL /GestionDisponibilidad para ver y probar la pantalla principal del proyecto




	## Autores:
	Ismael Enrique Jarquin Soza y Emily Tatiana Matute Guerrero
    
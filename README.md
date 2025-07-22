# Sistema de Gesti�n de Citas para Enfermer�a

Este proyecto es una aplicaci�n web desarrollada con .NET 8 y ASP.NET Core MVC dise�ada para 
modernizar y optimizar la administraci�n de citas en un entorno de enfermer�a. La aplicaci�n 
permite al personal administrativo gestionar la disponibilidad de horarios de atenci�n de una 
manera visual, din�mica e intuitiva.

## Caracter�sticas Principales

*   Gesti�n de Disponibilidad por D�a: Permite a la secretaria seleccionar cualquier fecha para visualizar y configurar la disponibilidad de citas.
*   Generaci�n Autom�tica de Horarios: Al acceder a un d�a por primera vez, el sistema crea autom�ticamente los horarios de atenci�n (de 7:00 AM a 5:00 PM) con una cantidad de citas por defecto, agilizando la configuraci�n inicial
*   Interfaz Interactiva y Din�mica: Utiliza JavaScript y AJAX para una experiencia de usuario fluida, permitiendo modificar la cantidad de citas disponibles para cada hora sin necesidad de recargar la p�gina.
*   Feedback en Tiempo Real: El estado de cada franja horaria (Activo/Cancelado) se actualiza visualmente al instante seg�n la cantidad de citas disponibles.
*	Persistencia de Datos Segura: Los cambios se guardan en la base de datos de forma eficiente mediante una llamada AJAX, utilizando transacciones de SQL para garantizar la integridad de los datos.
*	Dise�o Moderno y Responsivo: La interfaz ha sido cuidadosamente dise�ada con CSS personalizado para ofrecer una experiencia visual limpia, profesional y agradable, incluyendo un selector de fecha estilizado.

## Tecnolog�as Utilizadas

		## Backend
*   Framework: .NET 8
*	Arquitectura: ASP.NET Core MVC
*	Acceso a Datos (ORM): Entity Framework Core 8
*	Base de Datos: SQL Server Express 2022 

		## Frontend
*   Lenguajes: HTML5, CSS3, JavaScript (ES6)
*	Framework CSS: Bootstrap 5 (como base, con amplia personalizaci�n)
*	Librer�a JavaScript: jQuery (para manipulaci�n del DOM y llamadas AJAX)
*	Selector de Fecha: flatpickr.js (para una experiencia de calendario mejorada)
*	Tipograf�a: Google Fonts (Montserrat y Playfair Display)

		## Herramientas de Desarrollo
*   IDE: Visual Studio 2022
*	Gesti�n de Base de Datos: SQL Server Management Studio (SSMS)
*	Control de Versiones: Git y GitHub


## Requisitos Previos
Para ejecutar este proyecto localmente, necesitar�s tener instalado lo siguiente:
*   SDK de .NET 8
*	Visual Studio 2022
*	SQL Server Express 2022

	
## C�mo Ejecutar el Proyecto

		1. Clonar el Repositorio (con comandos)
cd C:\Users\TuUsuario\source\repos
git clone https://github.com/Isoza05/EnfermeriaProyecto.git
cd EnfermeriaProyecto

		2. Configurar la Base de Datos 
El proyecto est� dise�ado para funcionar con una base de datos local de SQL Server Express.
1.Abre SQL Server Management Studio (SSMS).
2.El script para crear la base de datos, las tablas y los triggers se encuentra en la ra�z del proyecto. Ejecuta este script para crear la base de datos enfermeria y toda su estructura.	

		3.Ejecutar la Aplicaci�n
*	En Visual Studio, aseg�rate de que el proyecto de inicio est� seleccionado.
*   Presiona F5 o el bot�n "play" (con el nombre del proyecto) para compilar y ejecutar la aplicaci�n.
*   Visual Studio abrir� autom�ticamente un navegador web con la aplicaci�n en ejecuci�n.
*   Navega a la URL /GestionDisponibilidad para ver y probar la pantalla principal del proyecto




	## Autores:
	Ismael Enrique Jarquin Soza y Emily Tatiana Matute Guerrero
    
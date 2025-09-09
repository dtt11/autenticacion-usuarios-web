## 🔐 App Web ASP.NET Core – Autenticación y Autorización con Identity
📌 Descripción

Este proyecto implementa una aplicación web utilizando ASP.NET Core 8.0 con Razor Pages e integración de Identity para la gestión de usuarios, autenticación y autorización.

La aplicación conecta con una base de datos SQL Server para almacenar la información de usuarios, roles y reclamaciones, permitiendo un control robusto de acceso y administración segura.

🚀 Funcionalidades

Registro de usuarios con validaciones personalizadas

Inicio y cierre de sesión (autenticación con Identity)

Asignación y gestión de roles de usuario (autorización basada en roles)

Protección de páginas y recursos según permisos definidos

Validación de datos en formularios con mensajes amigables

Conexión a SQL Server para persistencia de la información

Uso de Razor Pages como motor de vistas y UI

⚙️ Requisitos de software

Visual Studio Community 2022

.NET 8.0

SQL Server (con seguridad integrada de Windows o credenciales definidas en appsettings.json)

Herramientas de migración de Entity Framework Core (dotnet ef)

🏗️ Arquitectura del sistema

El sistema se basa en una arquitectura web moderna, organizada en las siguientes capas:

Presentación (UI): Razor Pages para la interacción con el usuario

Lógica de negocio: Servicios de autenticación y autorización con Identity

Acceso a datos: Entity Framework Core para gestión de usuarios y roles en SQL Server

Persistencia: Base de datos SQL Server que almacena credenciales, roles, tokens y claims

🗄️ Entidades principales

ApplicationUser → Extiende la clase IdentityUser para personalizar atributos del usuario

IdentityRole → Define los roles de la aplicación

IdentityUserRole → Relación entre usuarios y roles

IdentityUserClaim → Reclamaciones asociadas a usuarios

IdentityUserLogin → Manejo de autenticación externa (si aplica)

▶️ Ejecución del sistema

Configurar la base de datos

Revisar el archivo appsettings.json para definir la cadena de conexión a SQL Server.

Ejecutar las migraciones con:

dotnet ef database update


Ejecutar la aplicación

Abrir el proyecto en Visual Studio 2022.

Seleccionar la opción Iniciar sin depuración (Ctrl + F5).

La aplicación se abrirá en el navegador en https://localhost:xxxx.

Probar autenticación y autorización

Registrar un nuevo usuario.

Iniciar sesión con las credenciales creadas.

Asignar roles y validar acceso a páginas protegidas.

🧑‍💻 Autor
Daniel Tapia Traña – Diplomado en Informática

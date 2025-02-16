# Proyecto .NET Core 8 con React y SQL Express

Este proyecto ha sido desarrollado utilizando las siguientes tecnologías:

- **.NET Core 8**
- **Entity Framework**
- **React**
- **SQL Express**

## Requisitos

Para poder ejecutar este proyecto, es necesario tener instaladas las siguientes tecnologías:

- .NET Core 8
- Node.js (para React)
- SQL Server Express

## Configuración Inicial

### Base de Datos

1. **Migración de la Base de Datos**: El proyecto incluye una migración con los servicios ya configurados. Para aplicar esta migración, ejecuta el siguiente comando en la terminal desde la carpeta del proyecto de backend:

Update-Database

Esto creará todas las estructuras necesarias en la base de datos.

2. **Configuración del Connection String**: Configuración del Connection String: Asegúrate de configurar el connectionString en el archivo appsettings.json del proyecto backend con los detalles de tu base de datos.

### Backend
Puerto: El servicio backend por defecto correrá en el puerto 5000. Si necesitas cambiar este puerto, modifica las configuraciones en el archivo Program.cs.

### Frontend
Puerto: El proyecto frontend está configurado para correr en el puerto 3000.
Dependencias Instaladas:
axios: Para manejar peticiones HTTP.
bootstrap: Para mejorar la apariencia del frontend.
concurrently: Útil solo para desarrollo, permite ejecutar ambos proyectos simultáneamente.
Configuración de Axios: Si cambias el puerto del backend, también deberás actualizar la configuración de Axios en app.js del proyecto frontend.

### Ejecución
Para ejecutar ambos proyectos al mismo tiempo:

Navega a la carpeta del proyecto frontend.
Ejecuta el siguiente comando:

npm run start:all

Este comando usará concurrently para iniciar tanto el servidor backend como el frontend.

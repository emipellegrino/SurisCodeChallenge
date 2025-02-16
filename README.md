Este proyecto fue creado usando .net core 8, entity framework, react y sql express
para poder correr este proyecto se necesita tener instaladas dichas tecnologias
el proyecto viene con una migracion con los servicios ya sedeados, al correr la migracion con el comando update-database se creara todo lo necesario en la base de datos
asi mismo, se denera poner en el appsettings.json del proyecto de backend el coneccion string a su base de datos
el proyecto de backend correra en el puerto 5000 para mas facilidad, si quieren que sea otro puerto deberan cambiar la configuracion en el program.cs y en el front end deberan cambiarlo en donde se encuentra la configuracion de axios en el app.js
el proyecto de front end correra en el puerto 3000
el proyecto de front se hizo instalando 3 dependencias: axios, bootstrap y concurrently(esta solo para dev)
bootstrap se uso para que quede mejor el front end, axios para manejar request y responses, y concurrently para pdoer disparar ambos proyectos al mismo tiempo
para poder disparar ambos proyectos al mismo tiempo, se debe ejectuar en la carpeta del front end el comando npm run start:all
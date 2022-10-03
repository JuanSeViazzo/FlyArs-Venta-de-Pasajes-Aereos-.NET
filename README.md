# Venta de Pasajes Aerolineas FlyArges

_Es una sistema para vender pasajes de una linea Aerea. El cliente o los clientes van a poder elegir distintos vuelos con determinadas caracteristicas.
El usuario podra ver el listado de vuelos, sus pasajeros, y estadisticas historicas_


## Sobre mi: 😎😥😍😫😖🤬🤡🛠🧐💀☠🦈🦆🦋🎸🕯🥂

- Mi nombre es Juan Sebastian Viazzo Perrone, estoy recursando la materia, y mirando lo que codee el cuatri anterior, no puedo de sentir alegria por mi avance, aun a sabiendas que falta mucho mucho por mejorar. 
- Los emoji son parte de lo que significo el codigo para mi, empezando por alguien confiado que iba a poder, a poco del comienzo ya me senti triste porque era una sensacion de un codigo inmenso para mi capacidad. Cuando empece a darle forma no senti otra cosa que amor por mi pequeño proyecto, aunque dias despues me senti frustrado, cansado, enojado! y hasta un payaso. Pero tome otra decision, manos a la obra y empece a buscar documentacion oficial, a investigar sobre los eventos, metodos, etc, sentia que moria, pero _MENTE DE TIBURON_ uno no tiene que aflojar, aunque sientas que sea un paso una caga**, y aunque el codigo viva un dia como una mariposa, guitarrear tal vez es lo que mejor me sale, y por eso prendo una velita, para poder brindar una buena nota.
- Al final de cuentas disfrute el codigo, disfrute mayormente la parte de la logica y como relacionarla con la interface, como planear las clases, como entender que uno tiene que encarar estos proyectos, tal vez si hoy fuese el 1er dia y no el ultimo, tomaria un camino totalmente distinto, en el cual le daria casi por no decir la misma importancia, a lo que es la parte de planificar y diagramar el programa, como la parte de codearlo. 

## RESUMEN 📜

_Estas instrucciones te permitirán poder navegar dentro del proyecto y disfrutar de una experiencia satisfactoria_

## Login 📋

_Informacion necesaria para logearse_

- Esta es la pantalla de inicio, donde puede visualizar la hora y el dia actual
![image](https://user-images.githubusercontent.com/86853488/193580749-2769f15c-20e9-40e7-9d4f-fd893df53208.png)

Debido a que la etapa actual del proyecto es Beta 1.0, ud posee la opcion de ingreso automatico (Auto Login), sino puede logear con cualquiera de estos usuarios.

```
  Usuario     Contraseña
"RodriguezL" "Pepepeposo*"
"SmirlianI", "Meolans*"
"PrietoE", "CuatroPilares*"
"CurcioO", "Medicina*"
"ViazzoJs", "Elciclon*"
```

## Menu principal - Pivote de la App 🏛

_Aca usted podra visualizar la ventana, en la cual donde podra ir a cada una de las opciones disponibles como usuario_

![image](https://user-images.githubusercontent.com/86853488/193585735-0d282576-8e3d-49b7-b40b-b5303b72d0ec.png)


_Puede navegar entre los distintas opciones, ver el nombre de usuario y la fecha actual_


## Menu Pasajes - Venta de Pasajes 💸

![image](https://user-images.githubusercontent.com/86853488/193590597-c9fe2582-8f2a-4152-b436-25bab5ab8cba.png)

### Nuevas caracteristicas en la proxima version
- Modificar Pasajes
- Eliminar Pasajes

## Vender Pasaje 🛫🛬

![image](https://user-images.githubusercontent.com/86853488/193591403-cee4b496-38e9-4595-bdbe-2ba5fa441ff2.png)

_Aqui ud podra realizar la venta de un pasaje o varios pasajes en simultaneo, primero deberia buscar un vuelo, posteriormente podra buscar al cliente en la base de datos o cargar un nuevo cliente, a continuacion debera cargar su equipaje y por ultimo facturarlo, finalizados estos pasos cargara el pasajero al listado, y en caso de no gestionar ninguna pasaje mas, cerrara la venta_

## Buscar Vuelo 🔍

![image](https://user-images.githubusercontent.com/86853488/193592765-8e387470-430e-4c3a-b849-132540029678.png)


_En esta pantalla ud podra visualizar los distintos vuelos disponibles con su codigo de vuelo y matricula del avion, a su vez podra corrobrar el limite disponible en bodega, servicios adicionales como servicio de comida, o wifi, el estado del vuelo, y primordialmente los lugares disponibles dependiendo si es categoria Premium o Turista_

_A su disposicion tendra filtros disponibles en los cuales se podran filtrar por Origen y Destino simultaneamente y por fecha de partida_

_Por ultimo para para seleccionar un vuelo debera hacer click sobre el boton seleccionar vuelo y posteriormente 



![image](https://user-images.githubusercontent.com/86853488/193597416-349f2d35-0bf2-4f26-bfc9-663d27aa47a3.png)



## Cargar Pasajero

- Una vez obtenido el vuelo se tendra que ingresar a la seccion cargar Pasajero, donde en el cuadro de texto izquierdo se visualizara la informacion del pasajero, y en el cuadro de texto derecho, se vera la informacion del cliente, una vez obtenido el cliente, se debera **CATEGORIA PREMIUM o CATEGORIA TURISTA**

![image](https://user-images.githubusercontent.com/86853488/193632860-a61b9be8-96e6-4b39-8de0-63012d863230.png)



**En este paso se elegira el ciente de la base de datos, o cargar un nuevo cliente**

![image](https://user-images.githubusercontent.com/86853488/193644194-7d2d6116-e6a4-4035-9c43-b86779e8cbb8.png)


**En este caso se observa que el cliente ya fue cargado, se verifica el DNI o Pasaporte en el sistema**

![image](https://user-images.githubusercontent.com/86853488/193643886-60ff915b-fcd6-4bbd-bedc-341391dbf1d1.png)


**Si coloca el DNI correcto, se podra proceder a la carga**

![image](https://user-images.githubusercontent.com/86853488/193643920-63f8e4dd-d9f5-44af-a81f-983e5f1a3c0e.png)

![image](https://user-images.githubusercontent.com/86853488/193644293-94c3a8ae-183b-4dde-9db2-b3e7026a0486.png)


**Una vez obtenido el cliente, la imagen quedara de la siguiente manera, a la izquierda los datos del cliente, a la derecha los datos del pasajero**



![image](https://user-images.githubusercontent.com/86853488/193644089-1d04b955-0796-474b-a746-656e6f5c1b65.png)



## MENU DE VENTA COMPLETADO
- Cuando el menu de venta ha sido completado, se habilitara la opcion de cargar Pasajero o _(En version Beta 1.1 el control ha cambiado su texto a "Subir Pasajero"_ 
- Cuando se haya cargado al pasajero en la lista, podra cargar uno nuevo del grupo familiar, o finalizar la venta.
- 
![image](https://user-images.githubusercontent.com/86853488/193646237-83587914-f295-4cef-b248-7e19380dd874.png)


![image](https://user-images.githubusercontent.com/86853488/193597765-930daa28-c215-406a-8dea-8ea2ff44a2b1.png)

```
Elegimos tres pasajeros del grupo familiar, dos iran en clase Premium y uno en clase turista, fuimos cargando uno por uno, y los tres fueron cargados en el mismo vuelo con sus respectivas clases
```
##



### Y las pruebas de estilo de codificación ⌨️

_Explica que verifican estas pruebas y por qué_

```
Da un ejemplo
```

## Despliegue 📦

_Agrega notas adicionales sobre como hacer deploy_

## Construido con 🛠️

_Menciona las herramientas que utilizaste para crear tu proyecto_

* [Dropwizard](http://www.dropwizard.io/1.0.2/docs/) - El framework web usado
* [Maven](https://maven.apache.org/) - Manejador de dependencias
* [ROME](https://rometools.github.io/rome/) - Usado para generar RSS

## Contribuyendo 🖇️

Por favor lee el [CONTRIBUTING.md](https://gist.github.com/villanuevand/xxxxxx) para detalles de nuestro código de conducta, y el proceso para enviarnos pull requests.

## Wiki 📖

Puedes encontrar mucho más de cómo utilizar este proyecto en nuestra [Wiki](https://github.com/tu/proyecto/wiki)

## Versionado 📌

Usamos [SemVer](http://semver.org/) para el versionado. Para todas las versiones disponibles, mira los [tags en este repositorio](https://github.com/tu/proyecto/tags).

## Autores ✒️

_Menciona a todos aquellos que ayudaron a levantar el proyecto desde sus inicios_

* **Andrés Villanueva** - *Trabajo Inicial* - [villanuevand](https://github.com/villanuevand)
* **Fulanito Detal** - *Documentación* - [fulanitodetal](#fulanito-de-tal)

También puedes mirar la lista de todos los [contribuyentes](https://github.com/your/project/contributors) quíenes han participado en este proyecto. 

## Licencia 📄

Este proyecto está bajo la Licencia (Tu Licencia) - mira el archivo [LICENSE.md](LICENSE.md) para detalles

## Expresiones de Gratitud 🎁

* Comenta a otros sobre este proyecto 📢
* Invita una cerveza 🍺 o un café ☕ a alguien del equipo. 
* Da las gracias públicamente 🤓.
* Dona con cripto a esta dirección: `0xf253fc233333078436d111175e5a76a649890000`
* etc.



---

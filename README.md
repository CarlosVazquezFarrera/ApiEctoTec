# ApiEctoTec

## endpoints del Api
```shell
/api/Direccion/ObtenerTodasLasDirecciones
/api/Usuario/RegistrarUsuario
/api/Mail/EnviarCorreo
```
### ObtenerTodasLasDirecciones
Este método retorna todas las ciudades, estados y paises que se encuentran registrados en la base de datos. 
#### verbo Http
Tipo de petición (verbo http) `Get`
#### Respuesta
```json
{
    "exito": true,
    "data": [
        {
            "pais": "México",
            "idPais": 1,
            "entidad": "Chiapas",
            "idEntidad": 1,
            "ciudad": "Tuxtla Gutierrez",
            "idCiudad": 1
        }..
    ]
}
```
___
### RegistrarUsuario
Registra un usuario en la base de datos y retorna una respuesta en la que especifica el resultado de la operación; petición exitosa o fracasada.

#### verbo Http
Tipo de petición  `Post`
#### Parámetros 
```json
{
    "nombre": "carlos",
    "mail": "carlos@gmail.com",
    "telefono": "9611234567",
    "fecha": "2021-03-19",
    "idCiudad": 1
}
```
#### Respuesta  de éxito 
```json
{
    "exito": true,
    "mensaje": "Se registró el usuario de forma correcta"
}
```
#### Respuesta  de fracaso
```json
{
    "exito": false,
    "mensaje": "Algún mensaje"
}
```
___
### EnviarCorreo
Este método envía un Email personalizado al correo que se envía como parámetro
#### verbo Http
Tipo de petición `Post`
#### Parámetros
```json
{   "mail": "carlos.vazquez.unach@gmail.com",
    "nombre": "carlos"
}
```
#### Respuesta  de éxito 
```json
{
    "exito": true,
    "mensaje": "Correo enviado con éxito"
}
```
#### Respuesta  de fracaso
```json
{
    "exito": false,
    "mensaje": "Hubo un error el enviar el correo"
}
```
___
## Requisitos previos
Para ejecutar la aplicación de necesita de la sigueinte base de datos y procedimientos almacenados

-  Base de datos llamada EctoTec
- Sp [IngresarUsuario]
- Sp [ConsultarDirecciones]

**_(Los_** archivos de creación de la base de datos y los Stored Procedure se encuentran dentro de la carpeta Docs que está dentro de ApiEctoTec)
___
## Modificación de cadena de conexión 
Ya con la base de datos y los SP Listo, hay que cambiar el nombre del servidor en la Api, para ello simplemente nos vamos al proyecto Api (ApiEctoTec) y abrimos al archivo appsettings.json

![1](https://user-images.githubusercontent.com/28713740/111880917-b2dcef00-8973-11eb-82c6-906d28e38282.jpg)

Dentro del archivo buscamos la siguiente línea: **ConnectionStrings** y modificamos la línea de **server**
![2](https://user-images.githubusercontent.com/28713740/111881075-942b2800-8974-11eb-8640-554c6bcf8b18.PNG)
En lugar de **DESKTOP-8HHRKK1\\SQLEXPRESS** colocamos el nombre de nuestro servidor. Para obtener el nombre de nuestro servidor, únicamente abrimos el programa **Microsoft SQL Server Management Studio**
![3](https://user-images.githubusercontent.com/28713740/111881218-19aed800-8975-11eb-9ff2-590715223807.PNG)

## Probar el Api
Con todo estos cambios realizados podemos ejecutar el proyecto api y acceder a los endpoints de ésta para probar. 

![4](https://user-images.githubusercontent.com/28713740/111881446-fcc6d480-8975-11eb-9021-1f0e388cb74a.PNG)
![5](https://user-images.githubusercontent.com/28713740/111881448-00f2f200-8976-11eb-9c6a-e8e7a04aef21.PNG)

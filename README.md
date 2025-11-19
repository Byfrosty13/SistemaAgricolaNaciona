Sistema Agricola Naciona (SAN)

Resolucion usanda 1016; 616

Cosas que hacer
mejorar size of the pages
add color and items
add the layout before programing

login 
Este sistema utiliza un archivo JSON local para almacenar y gestionar los usuarios registrados
El módulo permite

Registrar nuevos usuarios

Verificar si un usuario ya existe

Iniciar sesión validando correo y contraseña

Guardar y cargar la información desde Usuarios.json
(ya quedo arreglado el login si el archivo ya es existente )

public static List<Usuarios> LeerUsuarios()

    Verifica si Usuarios.json existe

    Si no existe, devuelve una lista vacía

    Si existe, lee el JSON y lo convierte en una lista de usuarios

Formulario de Registro de Usuarios
El formulario Registro permite crear un nuevo usuario en el sistema
Toda la información registrada se guarda en el archivo Usuarios.json a través de la clase ManejoUsuarios


Formulario de Ubicaciones
¿Qué hace este formulario?

 Carga la lista de provincias
Cuando se selecciona una provincia, carga sus cantones
Cuando se selecciona un cantón, carga sus distritos
Permite limpiar y reiniciar la selección
// me falto mostrar que hiciera o agregar otra parte del código para que salieran las ferias de cada zona

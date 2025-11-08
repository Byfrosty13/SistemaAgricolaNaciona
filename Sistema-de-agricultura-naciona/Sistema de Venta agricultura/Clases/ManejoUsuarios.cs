using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json; 

namespace Sistema_de_Venta_agricultura.Clases
{
    internal class ManejoUsuarios
    {
        private static string ruta = "Usuarios.json";
        

        public static List<Usuarios> LeerUsuarios()
        {
         if(!File.Exists(ruta))
                return new List<Usuarios>();
            //revisa si el archivo existe si no lo crea (Nota me da error si se genera un archivo y se vuevle a usar el
            //)

            string json = File.ReadAllText(ruta);
            return JsonSerializer.Deserialize<List<Usuarios>>(json);
        }

        public static void GuardarUsuarios(List<Usuarios> usuarios)
        {
            string json = JsonSerializer.Serialize(usuarios);
            File.WriteAllText(ruta, json);
        }

        public static bool UsuarioExiste(string cedula)
        {
            var usuarios = LeerUsuarios();
            return usuarios.Any(u => u.Cedula == cedula);
        }

        public static void Registrar(Usuarios nuevo)
        {
            var lista = LeerUsuarios();
            lista.Add(nuevo);
            GuardarUsuarios(lista);
        }

        public static bool Login(string correo, string password)
        {
            var lista = LeerUsuarios();
            return lista.Exists(u => u.Correo == correo && u.Contrasena == password);
        }
            

    }


}



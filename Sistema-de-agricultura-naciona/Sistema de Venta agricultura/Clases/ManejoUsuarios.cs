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

         string json = File.ReadAllText(ruta);
            return JsonSerializer.Deserialize<List<Usuarios>>(json);
        }

    }
}

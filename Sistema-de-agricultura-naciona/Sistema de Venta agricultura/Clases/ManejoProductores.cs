using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Sistema_de_Venta_agricultura.Clases
{
    internal class ManejoProductores
    {
        private static string ruta = "productores.json";

        //hago lo mismo que en manejo usuarios asi revisa si el file existe si no lo crea
        //nota talvez deberia crear algo que maneje archivos json en general
        public static List<Productor> leer()
        {
            if (!File.Exists(ruta))
            {
                return new List<Productor>();
            }
            string json = File.ReadAllText(ruta);
             return JsonSerializer.Deserialize<List<Productor>>(json);

        }

        public static void guardar(List<Productor> Lista)
        {
            string json = JsonSerializer.Serialize(Lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(ruta, json);
        }

        public static void Registrar(Productor p)
            {
            var Lista = leer();
            Lista.Add(p);
            guardar(Lista);

        }

    }
}

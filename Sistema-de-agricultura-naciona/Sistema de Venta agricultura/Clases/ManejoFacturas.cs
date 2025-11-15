

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Sistema_de_Venta_agricultura.Clases
{
    internal static class ManejoFacturas
    {
        private static string ruta = "facturas.json";
        public static List<Factura> leer()
        {
            if (!File.Exists(ruta))
            {
                return new List<Factura>();
            }
            string json = File.ReadAllText(ruta);
            return JsonSerializer.Deserialize<List<Factura>>(json);
        }

        public static void guardar(List<Factura> Lista)
        {
            string json = JsonSerializer.Serialize(Lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(ruta, json);
        }

        public static void Registrar(Factura f)
        {
            var Lista = leer();
            Lista.Add(f);
            guardar(Lista);
        }


    }
}

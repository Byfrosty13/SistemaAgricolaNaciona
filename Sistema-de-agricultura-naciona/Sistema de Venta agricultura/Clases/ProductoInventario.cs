using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Venta_agricultura.Clases
{
    public class ProductoInventario
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public string ProductorId { get; set; }
    }
}


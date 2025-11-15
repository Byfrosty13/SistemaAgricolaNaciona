using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Venta_agricultura.Clases
{
    internal class ProductoInventario
    {
        public int codigoProducto { get; set; }
        public string nombreProducto { get; set; }
        public string tipoProducto { get; set; }
        public int Cantidad { get; set; }
        public string precio { get; set; }
        public double Precio { get; internal set; }
        public string ProductorId { get; set; }
        public string Codigo { get; internal set; }
        public string Nombre { get; internal set; }
        public string Tipo { get; internal set; }
    }
}

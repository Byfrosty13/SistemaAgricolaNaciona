using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Venta_agricultura.Clases
{
    internal class CarritoCompra
    {
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }

        public double subtotal()
        {
            return Cantidad * PrecioUnitario;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Venta_agricultura.Clases
{
    public class Factura
    {
        public int NumeroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreCliente { get; set; }
        public List<CarritoCompra> Items { get; set; }

        public double Total()
        {
            return Items.Sum(item => item.subtotal());
        }


    }
}

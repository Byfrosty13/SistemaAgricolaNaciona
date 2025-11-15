using Sistema_de_Venta_agricultura.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Venta_agricultura.Forms
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            ProductoInventario prod = new ProductoInventario
            {
                codigoProducto = int.Parse(txtCodigo.Text),
                nombreProducto = txtNombre.Text,
                tipoProducto = cboProductor.Text,
                Cantidad = int.Parse(txtNombre.Text),
                precio = txtPrecio.Text,
                ProductorId = cboProductor.Text
            };




        }
    }
}

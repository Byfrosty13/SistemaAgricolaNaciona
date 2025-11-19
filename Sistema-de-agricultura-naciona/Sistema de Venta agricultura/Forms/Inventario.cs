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
            // Validaciones para que reevise 
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Debe llenar todos los campos.");
                return;
            }

            ProductoInventario prod = new ProductoInventario
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Tipo = cboTipoProducto.Text,
                Cantidad = int.Parse(txtCantidad.Text),
                Precio = double.Parse(txtCantidad.Text),
                ProductorId = cboProductor.SelectedValue?.ToString() ?? cboProductor.Text
            };

            // Guardar producto en inventario

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {


        }

        private void ubicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagInicial paginicial = new PagInicial();
            paginicial.Show();
            this.Hide();
        }
    }
}
 
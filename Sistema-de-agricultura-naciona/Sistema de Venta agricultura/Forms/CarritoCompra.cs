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
    public partial class CarritoCompra : Form
    {
        private readonly GestorInventario gestorInventario;

        public CarritoCompra(GestorInventario inventario)
        {
            InitializeComponent();
            gestorInventario = inventario;
        }

        public void PrecargarProductoDesdeLista(ProductoInventario producto)
        {
            // Agregar producto al DataGridView del carrito
        }


     


        public List<CarritoCompra> carrito = new List<CarritoCompra>();

        public CarritoCompra()
        {
            InitializeComponent();

        }

        private void CarritoCompra_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {

        }

        private void dgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}

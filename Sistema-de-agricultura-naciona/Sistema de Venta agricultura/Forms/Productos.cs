using Sistema_de_Venta_agricultura.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Sistema_de_Venta_agricultura.Forms
{

  

    public partial class Productos : Form
    {


        public Productos(GestorInventario gestor)
        {
            InitializeComponent();
            gestorinventario = gestor;
        }
       
        private readonly GestorInventario gestorinventario;
        private object gestorInventario;

 


        private void Productos_Load(object sender, EventArgs e)
        {
            
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagInicial pagInicial = new PagInicial();
            pagInicial.Show();
            this.Hide();

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            inventario.Show();
            this.Hide();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto del inventario");
                return;
            }

            string codigo = dgvProductos.CurrentRow.Cells["Codigo"].Value.ToString();

            // Buscar en el gestor ACTUAL, no en clase estática
            var producto = gestorInventario.BuscarPorCodigo(codigo);

            if (producto == null)
            {
                MessageBox.Show("Error al cargar el producto.");
                return;
            }

            // Pasar el mismo inventario al carrito
            CarritoCompra carrito = new CarritoCompra(gestorinventario);

            carrito.PrecargarProductoDesdeLista(producto);
            carrito.Show();
        }

    }
}

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
    public partial class Horarios : Form
    {
        public Horarios()
        {
            InitializeComponent();
        }

        private void ubicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagInicial paginicial = new PagInicial();
            paginicial.Show();
            this.Hide();
        }

        private void carritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarritoCompra carritoCompra = new CarritoCompra();
            carritoCompra.Show();
            this.Hide();

        }

        private void registroProvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarProvedores registrarProvedores = new RegistrarProvedores();
            registrarProvedores.Show();
            this.Hide();

        }

        private void actualizarDatosDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuentaUser cuentaUser = new CuentaUser();
            cuentaUser.Show();
            this.Hide();
        }
    }
}

using Sistema_de_Venta_agricultura.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Venta_agricultura
{
    public partial class PagInicial : Form
    {
        public PagInicial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void provedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Provedores provedor = new Provedores();
            provedor.Show();
            this.Hide();

        }

        private void ubicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ubicaciones ubicaciones = new Ubicaciones();
            ubicaciones.Show();
            this.Hide();
        }

        private void registroProvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Provedores provedor = new Provedores();
            provedor.Show();
            this.Hide();


        }

        private void actualizarDatosDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuentaUser cuentaUser = new CuentaUser();
            cuentaUser.Show();
            this.Hide();

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
            this.Hide();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        //aqui iba horarios , pero no supe como hacerlo del todo funcional asi que lo quite :/

        private void salriToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void carritoCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PagInicial_Load(object sender, EventArgs e)
        {

        }
    }
}

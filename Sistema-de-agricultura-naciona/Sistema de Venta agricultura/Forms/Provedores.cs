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
    public partial class Provedores : Form
    {
        public Provedores()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
            this.Hide();

        }

        private void registroProvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroProvedorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RegistrarProvedores registrarProvedores = new RegistrarProvedores();
            registrarProvedores.Show();
            this.Hide();

        }
    }
}

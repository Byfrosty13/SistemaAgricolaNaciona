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
    public partial class Ubicaciones : Form

    {
        ManejoUbicaciones manejoUbicaciones = new ManejoUbicaciones();
        public static IEnumerable<object> Keys { get; private set; }

        public Ubicaciones()
        {
            ManejoUbicaciones manejoUbicaciones = new ManejoUbicaciones();
            this.InitializeComponent();
            InitializeComponent();
            CargarProvincias();


            checkedListBoxProvincias.SelectedIndexChanged += ProvinciaSeleccionada;
            CheckedListBoxCantones.SelectedIndexChanged += CantonSeleccionado;
            checkedListBoxDistritos.SelectedIndexChanged += DistritoSeleccionado;
        }

        // para cargar provicias
        private void CargarProvincias()
        {
            checkedListBoxProvincias.Items.Clear();

            foreach (var provincia in Ubicaciones.Keys)
            {
                checkedListBoxProvincias.Items.Add(provincia);
            }
        }

        private void ProvinciaSeleccionada(object sender, EventArgs e)
        {
            if (checkedListBoxProvincias.SelectedItem == null)
                return;

            string provincia = checkedListBoxProvincias.SelectedItem.ToString();

            // Limpiar cantones y distritos al cambiar provincia
            CheckedListBoxCantones.Items.Clear();
            checkedListBoxDistritos.Items.Clear();

            foreach (var Provincia in manejoUbicaciones.ubicaciones.Keys)
            {
                checkedListBoxProvincias.Items.Add(provincia);
            }

        }


        // para los cantones
        private void CantonSeleccionado(object sender, EventArgs e)
        {
            if (checkedListBoxProvincias.SelectedItem == null ||
                CheckedListBoxCantones.SelectedItem == null)
                return;

            string provincia = checkedListBoxProvincias.SelectedItem.ToString();
            string canton = CheckedListBoxCantones.SelectedItem.ToString();

            // Limpiar distritos antes de cargar
            checkedListBoxDistritos.Items.Clear();

            foreach (var distrito in manejoUbicaciones.ubicaciones[provincia][canton])
            {
                checkedListBoxDistritos.Items.Add(distrito);
            }

        }

        // y distritos , solo me queda revisar porque chingados no me carga los distritos
        private void DistritoSeleccionado(object sender, EventArgs e)
        {
            //esto nada mas para que me funcione el selecionar de distritos
        }




        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ubicaciones_Load(object sender, EventArgs e)
        {

        }

        private void CheckedListBoxCanton_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            checkedListBoxProvincias.ClearSelected();
            CheckedListBoxCantones.Items.Clear();
            checkedListBoxDistritos.Items.Clear();


            CargarProvincias();

        }

        private void ubicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagInicial paginicial = new PagInicial();
            paginicial.Show();
            this.Hide();

        }

        private void registroProvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarProvedores registrarProvedores = new RegistrarProvedores();
            registrarProvedores.Show();
            this.Hide();

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
            this.Hide();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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

namespace Sistema_de_Venta_agricultura
{

    public partial class Registro : Form
    {




        public Registro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCedula.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos");
                return;
            }

            if (ManejoUsuarios.UsuarioExiste(txtCedula.Text))
            {
                MessageBox.Show("El usuario con esta cédula ya existe");
                return;
            }

            Usuarios nuevo = new Usuarios
            {
                Nombre = txtNombre.Text,
                Cedula = txtCedula.Text,
                Correo = txtCorreo.Text,
                Contrasena = txtContrasena.Text
            };
            ManejoUsuarios.Registrar(nuevo);
            MessageBox.Show("Registro exitoso");

            Login inicio1 = new Login();
            inicio1.Show();
            this.Hide();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Login inicio1 = new Login();
            inicio1.Show();
            this.Hide();

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            if (txtCedula.Text.Length > 12)
            {
                MessageBox.Show("La cédula no puede tener más de 12 dígitos si eres extrangero o 8 si eres naciona" +
                    ".");

                // notamentalmente agregar que si detecta que es 12 lo mande a categoria cedula extrangero y si es 8 a nacional
                txtCedula.Text = txtCedula.Text.Substring(0, 10);
                txtCedula.SelectionStart = txtCedula.Text.Length;
            }

            if (!long.TryParse(txtCedula.Text, out _) && txtCedula.Text != "")
            {
                MessageBox.Show("La cédula solo puede contener números.");
                txtCedula.Text = new string(txtCedula.Text.Where(char.IsDigit).ToArray());
                txtCedula.SelectionStart = txtCedula.Text.Length;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("El nombre solo puede contener letras y espacios.");
            }
            
        }
    }
}

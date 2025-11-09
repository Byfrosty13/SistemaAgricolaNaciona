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
    public partial class RegistrarProvedores : Form
    {
        public RegistrarProvedores()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Productor p = new Productor
            {
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text
                // revisar porque chingados no me sirve el ID del productor si lo tengo en clase Productor
            };

            ManejoProductores.Registrar(p);
            MessageBox.Show("Proveedor registrado exitosamente.");

        }

        private void txtProductor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("El nombre solo puede contener letras y espacios.");
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTelefono.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor ingrese solo numeros.");
                txtTelefono.Text = txtTelefono.Text.Remove(txtTelefono.Text.Length - 1);
            }
        }
    }
}

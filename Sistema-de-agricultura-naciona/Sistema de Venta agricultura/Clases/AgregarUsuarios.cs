using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Drawing.Text;

namespace Sistema_de_Venta_agricultura.Clases
{
    internal class AgregarUsuarios
    {
        private string ArchivosUsuarios = "usuarios.json";
        private List<Usuarios> listaUsuarios = new List<Usuarios>();
        private string rutaarchivo;

        public AgregarUsuarios()
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            if (File.Exists(rutaarchivo))
            {
                string json = System.IO.File.ReadAllText(ArchivosUsuarios);
                listaUsuarios = JsonSerializer.Deserialize<List<Usuarios>>(json) ?? new List<Usuarios>();
            }

        }

        private void GuardarUsuarios() 
        {
            string json = JsonSerializer.Serialize(Usuarios, new Json)
        }


    }
}

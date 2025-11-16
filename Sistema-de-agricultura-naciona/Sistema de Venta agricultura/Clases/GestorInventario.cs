using System.Collections.Generic;
using System.Linq;

namespace Sistema_de_Venta_agricultura.Clases
{
    public class GestorInventario
    {
        private readonly List<ProductoInventario> productos = new List<ProductoInventario>();

        public void AgregarProducto(ProductoInventario p)
        {
            // Si ya existe el producto actualiza cantidad
            var existente = productos.FirstOrDefault(prod => prod.Codigo == p.Codigo);

            if (existente != null)
            {
                existente.Nombre = p.Nombre;
                existente.Tipo = p.Tipo;
                existente.Precio = p.Precio;
                existente.Cantidad += p.Cantidad;
            }
            else
            {
                productos.Add(p);
            }
        }

        public ProductoInventario BuscarPorCodigo(string codigo)
        {
            return productos.FirstOrDefault(p => p.Codigo == codigo);
        }

        public List<ProductoInventario> ObtenerProductos()
        {
            return productos;
        }

        public bool DescontarStock(string codigo, int cantidad)
        {
            var prod = BuscarPorCodigo(codigo);
            if (prod == null || prod.Cantidad < cantidad)
                return false;

            prod.Cantidad -= cantidad;
            return true;
        }
    }
}

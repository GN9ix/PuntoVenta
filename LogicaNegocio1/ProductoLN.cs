using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using PuntoVenta.Modelos;

namespace LogicaNegocio
{
    public class ProductoLN
    {
        ProductoDAO dao = new ProductoDAO();

        public void CrearProducto(Producto producto)
        {
            dao.InsertarProducto(producto);
        }
        public List<Producto> MostrarProductos()
        {
            return dao.ObtenerProductos();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta.Modelos
{
    public class DetalleVenta
    {
        public Producto Producto { get; set; }

        public int Cantidad { get; set; }

        public string NombreProducto
        {
            get
            {
                return Producto.Nombre;
            }
        }

        public double Precio
        {
            get
            {
                return Producto.PrecioVenta;
            }
        }

        public double Subtotal
        {
            get
            {
                return Producto.PrecioVenta * Cantidad;
            }
        }
    }
}

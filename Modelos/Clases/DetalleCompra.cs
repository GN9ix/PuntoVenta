using PuntoVenta.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta.Clases
{
    public class DetalleCompra
    {
        public Producto Producto { get; set; }

        public int Cantidad { get; set; }

        public double Costo { get; set; }

        public double PrecioVenta { get; set; }

        public string Lote { get; set; } = "";

        public double Subtotal
        {
            get
            {
                return Cantidad * Costo;
            }
        }
    }
}

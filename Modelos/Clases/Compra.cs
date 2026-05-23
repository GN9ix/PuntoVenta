using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta.Clases
{
    public class Compra
    {
        public int Id { get; set; }

        public string Factura { get; set; } = "";

        public string Proveedor { get; set; } = "";

        public DateTime Fecha { get; set; } = DateTime.Now;

        public List<DetalleCompra> Detalles { get; set; }
            = new List<DetalleCompra>();

        public double Total
        {
            get
            {
                return Detalles.Sum(d => d.Subtotal);
            }
        }
    }
}

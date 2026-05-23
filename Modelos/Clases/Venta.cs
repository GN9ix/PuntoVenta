using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta.Modelos
{
    public class Venta
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public List<DetalleVenta> Detalles { get; set; }
            = new List<DetalleVenta>();

        public decimal Total
        {
            get
            {
                return Detalles.Sum(d => d.Subtotal);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta.Modelos
{
    public class Producto
    {
        public int Id { get; set; } //Método que retorne el ID
        public string Nombre { get; set; } = "";
        public string CodigoBarras { get; set; } = "";
        public string Lote { get; set; } = "";
        public DateTime FechaExpiracion { get; set; } //Método que retorne nombre, precio, estado (hay stock o no)
        public decimal PrecioCompra { get; set; }    //Método de Vender
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public string Categoria { get; set; }
    }
}
//Los datos que estoy haciendo en mi prueba
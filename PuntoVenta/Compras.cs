using PuntoVenta.Clases;
using PuntoVenta.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoVenta
{
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
            listaProductos.Add(new Producto
            {
                Id = 1,
                Nombre = "Coca Cola Jumbo 3L",
                CodigoBarras = "123",
                Stock = 10
            });

            listaProductos.Add(new Producto
            {
                Id = 2,
                Nombre = "Tortrix",
                CodigoBarras = "456",
                Stock = 20
            });
        }

        //Función para llamar otros formularios
        private void AbrirEnPrincipal(Form formulario)
        {
            PuntoVenta pv =
                Application.OpenForms["PuntoVenta"] as PuntoVenta;

            if (pv != null)
            {
                pv.AbrirFormHija(formulario);
            }
        }

        private List<Producto> listaProductos = new List<Producto>();
        private List<DetalleCompra> carritoCompra = new List<DetalleCompra>();
        private List<Compra> listaCompras = new List<Compra>();

        private void RealizarCompra()
        {
            if (carritoCompra.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito");
                return;
            }

            if (txt_factura.Text == "" || txt_proveedor.Text == "")
            {
                MessageBox.Show("Completa factura y proveedor");
                return;
            }

            Compra compraNueva = new Compra()
            {
                Factura = txt_factura.Text,
                Proveedor = txt_proveedor.Text
            };

            foreach (DetalleCompra d in carritoCompra)
            {
                d.Producto.Stock += d.Cantidad;

                compraNueva.Detalles.Add(d);
            }

            listaCompras.Add(compraNueva);

            dgv_compras.Rows.Add(
                compraNueva.Factura,
                compraNueva.Proveedor,
                compraNueva.Fecha,
                compraNueva.Total
            );

            MessageBox.Show("Compra realizada correctamente");

            carritoCompra.Clear();

            ActualizarCarrito();

            LimpiarCampos();
        }

        private Producto BuscarProducto(string texto)
        {
            return listaProductos.FirstOrDefault(p =>
                p.Nombre.ToLower() == texto.ToLower()
                ||
                p.CodigoBarras == texto
            );
        }

        private void ActualizarCarrito()
        {
            dgv_carrito_compras.Rows.Clear();

            int no = 1;

            foreach (DetalleCompra d in carritoCompra)
            {
                dgv_carrito_compras.Rows.Add(
                    no,
                    d.Producto.Nombre,
                    d.Cantidad,
                    d.Costo,
                    d.Subtotal
                );

                no++;
            }
        }

        private void AgregarProductoCompra()
        {
            Producto producto = BuscarProducto(txt_producto.Text);

            if (producto == null)
            {
                MessageBox.Show("Producto no encontrado");
                return;
            }

            DetalleCompra detalle = new DetalleCompra()
            {
                Producto = producto,
                Cantidad = (int)num_cantidad.Value,
                Costo = Convert.ToDouble(txt_costo.Text),
                PrecioVenta = Convert.ToDouble(txt_precio.Text),
                Lote = txt_lote.Text
            };

            carritoCompra.Add(detalle);

            ActualizarCarrito();

            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            num_cantidad.Value = 1;
            txt_costo.Clear();
            txt_factura.Clear();
            txt_lote.Clear();
            txt_precio.Clear();
            txt_producto.Clear();
            txt_proveedor.Clear();
        }

        //EVENTOS
        private void btn_caja_Click(object sender, EventArgs e)
        {

            AbrirEnPrincipal(new Caja());
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            AbrirEnPrincipal(new Inventario());
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AgregarProductoCompra();
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            RealizarCompra();
        }
    }
}

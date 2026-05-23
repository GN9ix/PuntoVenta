using LogicaNegocio;
using Microsoft.Data.SqlClient;
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

namespace PuntoVenta.Forms_Tercearios
{
    public partial class form_crear_producto : Form
    {
        public form_crear_producto()
        {
            InitializeComponent();
            CargarProductos();
        }

        public void Agregar()
        {
            if (

                txt_producto.Text != "" &&
                txt_codigo.Text != "" &&
                txt_costo.Text != "" &&
                txt_precio.Text != ""
            )
            {
                Producto producto = new Producto()
                {
                    Nombre = txt_producto.Text,
                    CodigoBarras = txt_codigo.Text,

                    PrecioCompra =
                        Convert.ToDecimal(txt_costo.Text),

                    PrecioVenta =
                        Convert.ToDecimal(txt_precio.Text),

                    Stock = 0,

                    Lote = "",

                    FechaExpiracion = DateTime.Now
                };

                ProductoLN ln = new ProductoLN();

                ln.CrearProducto(producto);
                CargarProductos();

                MessageBox.Show(
                    "Producto creado correctamente");

                txt_producto.Clear();
                txt_codigo.Clear();
                txt_costo.Clear();
                txt_precio.Clear();

                txt_producto.Focus();
            }
            else
            {
                MessageBox.Show(
                    "Completa todos los campos");
            }
        }

        private void CargarProductos()
        {
            ProductoLN ln = new ProductoLN();

            dgv_nuevos_productos.DataSource =
                null;

            dgv_nuevos_productos.DataSource =
                ln.MostrarProductos();
        }


        private void btn_crear_Click(object sender, EventArgs e)
        {
            Agregar();
            txt_producto.Focus();
        }

        private void form_crear_producto_Shown(object sender, EventArgs e)
        {
            txt_producto.Focus();
        }
    }
}

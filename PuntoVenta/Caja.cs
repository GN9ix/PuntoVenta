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
using System.Data.SqlClient;

namespace PuntoVenta
{
    public partial class Caja : Form
    {
        //Inicializadores
        public Caja()
        {
            InitializeComponent();
            ConfigurarCarrito();
            listaProductos.Add(new Producto
            {
                Id = 1,
                Nombre = "Coca Cola",
                CodigoBarras = "123",
                PrecioVenta = 5,
                Stock = 10
            });

            listaProductos.Add(new Producto
            {
                Id = 2,
                Nombre = "Tortrix",
                CodigoBarras = "456",
                PrecioVenta = 3,
                Stock = 20
            });
            listaProductos.Add(new Producto
            {
                Id = 3,
                Nombre = "Fuegos Artificiales",
                CodigoBarras = "7622202015212",
                PrecioVenta = 100,
                Stock = 10
            });
            dgv_productos.DataSource = listaProductos;
        }



        //Variables temporales (Listas e instanciaciones)
        private Venta ventaActual = new Venta();
        private List<Producto> listaProductos = new List<Producto>();

        //FUNCIONES
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

        //Función que actualiza el texto indicando el total de los productos agregados
        private void ActualizarTotal()
        {
            lbl_total.Text = "Q " + ventaActual.Total.ToString("0.00");
        }

        //Función para configurar los productos y la estructura de la tabla
        private void ConfigurarCarrito()
        {
            dgv_carrito.Columns.Clear();

            dgv_carrito.Columns.Add("Numero", "N°");
            dgv_carrito.Columns.Add("Producto", "Producto");
            dgv_carrito.Columns.Add("Cantidad", "Cantidad");
            dgv_carrito.Columns.Add("Precio", "Precio");
            dgv_carrito.Columns.Add("Subtotal", "Subtotal");

            DataGridViewButtonColumn btnEliminar =
                new DataGridViewButtonColumn();

            btnEliminar.Name = "Quitar";
            btnEliminar.HeaderText = "Quitar";
            btnEliminar.Text = "X";
            btnEliminar.UseColumnTextForButtonValue = true;

            dgv_carrito.Columns.Add(btnEliminar);

            dgv_carrito.AllowUserToAddRows = false;
        }

        //Función para Actualizar los datos de los productos en la tabla
        private void ActualizarTabla()
        {
            dgv_carrito.Rows.Clear();

            int contador = 1;

            foreach (DetalleVenta d in ventaActual.Detalles)
            {
                dgv_carrito.Rows.Add(
                    contador,
                    d.Producto.Nombre,
                    d.Cantidad,
                    "Q. " + d.Producto.PrecioVenta.ToString("0.00"),
                    "Q. " + d.Subtotal.ToString("0.00"),
                    "X"
                );

                contador++;
            }
        }



        //Función para Agregar un Producto al Carrito



        private void AgregarProducto(Producto producto)
        {
            DetalleVenta existente = ventaActual.Detalles
                .FirstOrDefault(d => d.Producto.Id == producto.Id);

            if (existente != null)
            {
                existente.Cantidad++;
            }
            else
            {
                ventaActual.Detalles.Add(new DetalleVenta
                {
                    Producto = producto,
                    Cantidad = 1
                });
            }

            ActualizarTabla();
            ActualizarTotal();
        }

        private Producto BuscarProducto(string texto)
        {
            return listaProductos.FirstOrDefault(p =>
                p.CodigoBarras == texto ||
                p.Nombre.Equals(texto,
                StringComparison.OrdinalIgnoreCase)
            );
        }

        private void BuscarProductos(string texto)
        {
            var resultados = listaProductos
                .Where(p => p.Nombre.ToLower().Contains(texto.ToLower())
                         || p.CodigoBarras.Contains(texto))
                .ToList();

            dgv_productos.DataSource = null;
            dgv_productos.DataSource = resultados;

        }

        private void Cobrar()
        {
            foreach (DetalleVenta d in ventaActual.Detalles)
            {
                d.Producto.Stock -= d.Cantidad;
            }

            MessageBox.Show("Venta realizada correctamente");

            ventaActual = new Venta();

            ActualizarTabla();
            ActualizarTotal();
        }

        private void SeleccionarProducto()
        {
            Producto productoSeleccionado =
                (Producto)dgv_productos.CurrentRow.DataBoundItem;

            AgregarProducto(productoSeleccionado);
        }

        //EVENTOS

        //Evento para apuntar el cursor en el TextField para el código de barras
        private void Caja_Shown(object sender, EventArgs e)
        {
            txt_barcod.Focus();
        }

        //Evento para buscar productos por medio del nombre del producto
        private void txt_barcod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Producto p = BuscarProducto(txt_barcod.Text);
                BuscarProductos(txt_barcod.Text);

                if (p != null)
                {
                    AgregarProducto(p);
                }

                txt_barcod.Clear();
            }
        }

        //Evento para agregar los productos al carrito al hacer click en ellos
        private void dgv_productos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SeleccionarProducto();
            txt_barcod.Focus();
        }

        //Evento para cobrar
        private void btn_cobrar_Click(object sender, EventArgs e)
        {
            Cobrar();
        }

        //Evento para eliminar los datos al hacer click en la 'x' de la columna "Quitar"
        private void dgv_carrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (dgv_carrito.Columns[e.ColumnIndex].Name == "Quitar")
            {
                ventaActual.Detalles.RemoveAt(e.RowIndex);

                ActualizarTabla();
                ActualizarTotal();
                txt_barcod.Focus();
            }
        }

        //Evento para que al presionar Enter en la columna "Quitar" elimine la fila
        private void dgv_carrito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int fila = dgv_carrito.CurrentCell.RowIndex;
                int columna = dgv_carrito.CurrentCell.ColumnIndex;

                if (fila < 0)
                    return;

                if (dgv_carrito.Columns[columna].Name == "Quitar")
                {
                    ventaActual.Detalles.RemoveAt(fila);

                    ActualizarTabla();
                    ActualizarTotal();
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                txt_barcod.Focus();
            }
        
        }

        private void dgv_productos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SeleccionarProducto();
            }
            if (e.KeyCode == Keys.Escape)
            {
                txt_barcod.Focus();
            }
        }

        private void btn_compras_Click(object sender, EventArgs e)
        {
            AbrirEnPrincipal(new Compras());
        }
    }
}

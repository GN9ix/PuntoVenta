using LogicaNegocio;
using PuntoVenta.Forms_Tercearios;
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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
            ConfigurarProductos();
            ConfigurarTabla();
            CargarProductos();
        }

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


        private void ConfigurarTabla()
        {
            //Encabezados centrados
            dgv_inventario.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            //Producto
            dgv_inventario.Columns["Producto"]
                .DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            //Costo
            dgv_inventario.Columns["Costo"]
                .DefaultCellStyle.Format = "C2";
            //Subtotal
            dgv_inventario.Columns["Precio"]
                .DefaultCellStyle.Format = "C2";
            //Lote
            dgv_inventario.Columns["Lote"]
                .DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            //F.Vencimiento
            dgv_inventario.Columns["Vencimiento"]
                .DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            DataGridViewImageColumn btnEditar = new DataGridViewImageColumn();
            btnEditar.Name = "Editar";
            btnEditar.HeaderText = "Editar";
            btnEditar.Image = Properties.Resources.editar;
            dgv_inventario.Columns.Add(btnEditar);

            DataGridViewImageColumn btnBorrar = new DataGridViewImageColumn();
            btnBorrar.Name = "Borrar";
            btnBorrar.HeaderText = "Borrar";
            btnBorrar.Image = Properties.Resources.borrar;
            dgv_inventario.Columns.Add(btnBorrar);
        }

        private List<Producto> listaProductos = new List<Producto>();

        private void ConfigurarProductos()
        {
            dgv_inventario.Columns.Clear();

            dgv_inventario.Columns.Add("ID", "ID");
            dgv_inventario.Columns.Add("Producto", "Producto");
            dgv_inventario.Columns.Add("Codigo", "Código");
            dgv_inventario.Columns.Add("Costo", "Costo");
            dgv_inventario.Columns.Add("Precio", "Precio");
            dgv_inventario.Columns.Add("Stock", "Stock");
            dgv_inventario.Columns.Add("Lote", "Lote");
            dgv_inventario.Columns.Add("Vencimiento", "Vencimiento");

            dgv_inventario.AllowUserToAddRows = false;
        }

        private void CargarProductos()
        {
            dgv_inventario.Rows.Clear();

            ProductoLN ln = new ProductoLN();

            listaProductos = ln.MostrarProductos();

            foreach (Producto p in listaProductos)
            {
                dgv_inventario.Rows.Add(
                    p.Id,
                    p.Nombre,
                    p.CodigoBarras,
                    "Q. " + p.PrecioCompra.ToString("0.00"),
                    "Q. " + p.PrecioVenta.ToString("0.00"),
                    p.Stock,
                    p.Lote,
                    p.FechaExpiracion.ToShortDateString()
                );
            }
        }

        private void BuscarProductos(string texto)
        {
            dgv_inventario.Rows.Clear();

            var resultados = listaProductos
                .Where(p =>
                    p.Nombre.ToLower().Contains(texto.ToLower())
                    ||
                    p.CodigoBarras.Contains(texto)
                )
                .ToList();

            foreach (Producto p in resultados)
            {
                dgv_inventario.Rows.Add(
                    p.Id,
                    p.Nombre,
                    p.CodigoBarras,
                    "Q. " + p.PrecioCompra.ToString("0.00"),
                    "Q. " + p.PrecioVenta.ToString("0.00"),
                    p.Stock,
                    p.Lote,
                    p.FechaExpiracion.ToShortDateString()
                );
            }
        }

        //EVENTOS

        private void dgv_inventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                dgv_inventario.Columns[e.ColumnIndex].Name == "Editar")
            {
                MessageBox.Show("Editar producto");
                txt_busqueda.Focus();
            }

            if (e.RowIndex >= 0 &&
                dgv_inventario.Columns[e.ColumnIndex].Name == "Borrar")
            {
                DialogResult resultado = MessageBox.Show(
                "¿Seguro que quieres eliminar este producto?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    MessageBox.Show("Producto eliminado");
                    txt_busqueda.Focus();
                }
                txt_busqueda.Focus();
            }
        }

        private void Inventario_Shown(object sender, EventArgs e)
        {
            txt_busqueda.Focus();
        }

        private void btn_caja_Click(object sender, EventArgs e)
        {
            AbrirEnPrincipal(new Caja());
        }

        private void btn_compras_Click(object sender, EventArgs e)
        {
            AbrirEnPrincipal(new Compras());
        }

        private void btn_nuevo_producto_Click(object sender, EventArgs e)
        {
            AbrirEnPrincipal(new form_crear_producto());
        }

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            BuscarProductos(txt_busqueda.Text);
        }
    }
}

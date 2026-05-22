using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoVenta
{
    public partial class Principal : Form
    {
        public string usuarioActual;
        public Principal(string usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;

            lbl_bienvenida.Text =
                "Hola de nuevo, " + usuarioActual +
                ". ¿Qué deseas hacer hoy?";
        }

        private void AbrirEnPrincipal(Form formulario)
        {
            PuntoVenta pv =
                Application.OpenForms["PuntoVenta"] as PuntoVenta;

            if (pv != null)
            {
                pv.AbrirFormHija(formulario);
            }
        }

        private void img_caja_Click(object sender, EventArgs e)
        {
            AbrirEnPrincipal(new Caja());
        }

        private void panel_caja_Click(object sender, EventArgs e)
        {
            AbrirEnPrincipal(new Caja());
        }

        private void img_compra_Click(object sender, EventArgs e)
        {
            AbrirEnPrincipal(new Compras());
        }

        private void lbl_caja_Click(object sender, EventArgs e)
        {
            AbrirEnPrincipal(new Caja());
        }

        private void panel_inventario_Click(object sender, EventArgs e)
        {
            AbrirEnPrincipal(new Inventario());
        }

        private void img_inventario_Click(object sender, EventArgs e)
        {
            AbrirEnPrincipal(new Inventario());
        }

        private void lbl_inventario_Click(object sender, EventArgs e)
        {
            AbrirEnPrincipal(new Inventario());
        }

        private void panel_compra_Click(object sender, EventArgs e)
        {
            AbrirEnPrincipal(new Compras());
        }

        private void lbl_compra_Click(object sender, EventArgs e)
        {
            AbrirEnPrincipal(new Compras());
        }
    }
}

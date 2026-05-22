using PuntoVenta.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoVenta
{
    public partial class PuntoVenta : Form
    {
        //INICIALIZADORES
        public PuntoVenta(string usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            AbrirFormHija(new Principal(usuarioActual));
        }
        public string usuarioActual;


        //Función para Salir y volver al Login
        private void Salir()
        {
            DialogResult resultado = MessageBox.Show(
                "¿Seguro que quieres salir?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (resultado == DialogResult.Yes)
            {
                this.Owner.Show();
                this.Close();
            }
        }

        //Función para mostrar un Formulario en todo el panel Contenedor
        public void AbrirFormHija(object formhija)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(fh);
            this.Contenedor.Tag = fh;
            fh.Show();
        }

        //----EVENTOS----
        //Botón Principal. Abre el Form Principal en el panel Contenedor
        private void btn_principal_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Principal(usuarioActual));
        }

        //Botón Inventario. Abre el Form Inventario en el panel Contenedor
        private void btn_inventario_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Inventario());
        }

        //Botón Salir. Cierra el Formulario entero y regresa al Login
        private void btn_logout_Click(object sender, EventArgs e)
        {
            Salir();
        }

        //Botón Caja. Abre el Form Caja en el panel Contenedor
        private void btn_caja_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Caja());
        }

        //Botón GN9. Abre el repositorio en GitHub
        private void gn9studios_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/GN9ix/PuntoVenta.git",
                UseShellExecute = true
            });
        }

        //Botón Compras. Abre el Form Compras en el panel Contenedor
        private void btn_compras_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Compras());
        }

        //Botón Usuarios. Abre el Form Ususarios en el panel Contenedor
        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Usuarios());
        }

        //Botón Extras. Abre el Form Extras en el panel Contenedor
        private void btn_config_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Extras());
        }

        //Evento para atajos de teclado
        private void PuntoVenta_KeyDown(object sender, KeyEventArgs e)
        {
            //F1: Mostrar Form Principal
            if (e.KeyCode == Keys.F1)
            {
                AbrirFormHija(new Principal(usuarioActual));
            }

            //F2: Mostrar Form Caja
            if (e.KeyCode == Keys.F2)
            {
                AbrirFormHija(new Caja());
            }

            //F3: Mostrar Form Caja
            if (e.KeyCode == Keys.F3)
            {
                AbrirFormHija(new Inventario());
            }

            //F4: Mostrar Form Caja
            if (e.KeyCode == Keys.F4)
            {
                AbrirFormHija(new Compras());
            }

            //F5: Mostrar Form Caja
            if (e.KeyCode == Keys.F5)
            {
                AbrirFormHija(new Usuarios());
            }

            //F6: Mostrar Form Caja
            if (e.KeyCode == Keys.F6)
            {
                AbrirFormHija(new Extras());
            }

            //Alt+x: Sale del Formulario
            if (e.Alt && e.KeyCode == Keys.X)
            {
                Salir();
            }

            //
            if (e.KeyCode == Keys.F9)
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://github.com/GN9ix/PuntoVenta.git",
                    UseShellExecute = true
                });
            }
        }
    }
}

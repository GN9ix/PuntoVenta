using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;

namespace PuntoVenta
{
    public partial class form_creación_usuario : Form
    {
        public form_creación_usuario()
        {
            InitializeComponent();
        }

        private void btn_hecho_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_usuario.Text) &&
                !string.IsNullOrWhiteSpace(txt_password.Text))
            {
                UsuarioLN ln = new UsuarioLN();

                ln.CrearUsuario(
                    txt_usuario.Text,
                    txt_password.Text
                );

                MessageBox.Show("Usuario creado");

                txt_usuario.Clear();
                txt_password.Clear();

                txt_usuario.Focus();
            }
            else
            {
                MessageBox.Show(
                    "Completa todos los campos");
            }
        }

        private void Mostrar_anterior()
        {
            PuntoVenta pv = Application.OpenForms["PuntoVenta"] as PuntoVenta;

            if (pv != null)
            {
                pv.AbrirFormHija(new Usuarios());
                this.Close();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void box_back_Click(object sender, EventArgs e)
        {
            Mostrar_anterior();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

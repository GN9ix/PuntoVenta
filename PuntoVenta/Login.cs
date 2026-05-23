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
using LogicaNegocio;

namespace PuntoVenta
{
    public partial class Login : Form
    {
        //INICIALIZADOR
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = btn_ingresar;
        }

        UsuarioLN usuarioLN = new UsuarioLN();

        //FUNCIÓN PARA VALIDAR EL USUARIO Y CONTRASEÑA (BORRADOR SIN BD)
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (usuarioLN.Login(
        txt_usuario.Text,
        txt_pass.Text))
            {
                PuntoVenta fpv =
                    new PuntoVenta(txt_usuario.Text);

                fpv.Owner = this;

                txt_pass.Clear();
                txt_usuario.Clear();

                txt_usuario.Focus();

                this.Hide();
                fpv.Show();
            }
            else
            {
                MessageBox.Show(
                    "La contraseña o el usuario son incorrectos");

                txt_pass.Clear();
            }
        }

        //FUNCIÓN PARA BORRAR LOS TEXTFIEL AL PRESIONAR 'CANCELAR'
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_usuario.Clear();
            txt_pass.Clear();
        }

        //EVENTOS DE BOTONES Y TECLADO
        //Salir al presionar el botón de SALIR
        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Seguro que quieres salir?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Salir al presionar el cuadro de imágen
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Seguro que quieres salir?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Autenticar al presionar enter en el TextField de Contraseña
        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_ingresar.PerformClick();
            }
        }

        //Apenas corra el programa, el cursos se ubica en el TextField de Usuario
        private void Login_Shown(object sender, EventArgs e)
        {
            txt_usuario.Focus();
        }

        //Cerrar el programa al presionar ESC, el programa se cierra, no sin antes corroborarlo
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult resultado = MessageBox.Show(
                "¿Seguro que quieres salir?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
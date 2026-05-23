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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        //Función para agregar un nuevo formulario en Extras
        private void AbrirFormHija(Form formhija)
        {
            panel_usuario.Controls.Clear();

            formhija.TopLevel = false;
            formhija.Dock = DockStyle.Fill;

            panel_usuario.Controls.Add(formhija);
            panel_usuario.Tag = formhija;

            formhija.Show();
        }

        private void panel_nuevo_usuario_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new form_creación_usuario());
        }

        private void img_nuevo_user_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new form_creación_usuario());
        }

        private void lbl_nuevo_user_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new form_creación_usuario());
        }
    }
}

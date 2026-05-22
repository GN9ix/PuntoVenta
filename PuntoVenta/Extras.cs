using PuntoVenta.Forms_Tercearios;
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
    public partial class Extras : Form
    {
        public Extras()
        {
            InitializeComponent();
        }

        //Función para agregar un nuevo formulario en Extras
        private void AbrirFormHija(Form formhija)
        {
            panel_cont_extras.Controls.Clear();

            formhija.TopLevel = false;
            formhija.Dock = DockStyle.Fill;

            panel_cont_extras.Controls.Add(formhija);
            panel_cont_extras.Tag = formhija;

            formhija.Show();
        }

        //EVENTOS
        private void box_crew_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new form_crew());
        }

        private void lbl_crew_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new form_crew());
        }

        private void panel_crew_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new form_crew());
        }

        private void box_arqueo_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new form_arqueo());
        }

        private void panel_arqueo_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new form_arqueo());
        }

        private void lbl_arqueo_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new form_arqueo());
        }
    }
}

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
    public partial class form_crew : Form
    {
        public form_crew()
        {
            InitializeComponent();
        }

        private void Mostrar_anterior()
        {
            PuntoVenta pv = Application.OpenForms["PuntoVenta"] as PuntoVenta;

            if (pv != null)
            {
                pv.AbrirFormHija(new Extras());
                this.Close();
            }
        }

        private void box_back_Click(object sender, EventArgs e)
        {
            Mostrar_anterior();
        }
    }
}

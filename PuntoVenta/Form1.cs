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
    public partial class PuntoVenta : Form
    {
        public PuntoVenta()
        {
            InitializeComponent();
            AbrirFormHija(new Principal());
        }

        private void AbrirFormHija(object formhija)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_principal_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Principal());
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Inventario());
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Seguro que quieres salir?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (resultado == DialogResult.Yes)
            {
                this.Owner.Show(); // vuelve al Login
                this.Close();      // cierra PuntoVenta
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

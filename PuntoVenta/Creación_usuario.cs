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
    public partial class Creación_usuario : Form
    {
        public Creación_usuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}

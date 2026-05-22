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
    public partial class form_arqueo : Form
    {
        public form_arqueo()
        {
            InitializeComponent();
        }

        private void CalcularArqueo()
        {
            // ===== BILLETES =====

            double total200 =
                Convert.ToDouble(txt_200_billete.Text) * 200;

            double total100 =
                Convert.ToDouble(txt_100_billete.Text) * 100;

            double total50 =
                Convert.ToDouble(txt_50_billete.Text) * 50;

            double total20 =
                Convert.ToDouble(txt_20_billete.Text) * 20;

            double total10 =
                Convert.ToDouble(txt_10_billete.Text) * 10;

            double total5 =
                Convert.ToDouble(txt_5_billete.Text) * 5;

            double total1 =
                Convert.ToDouble(txt_1_billete.Text) * 1;

            // ===== MOSTRAR TOTALES =====

            lbl_total_200.Text = "Q" + total200.ToString("0.00");
            lbl_total_100.Text = "Q" + total100.ToString("0.00");
            lbl_total_50.Text = "Q" + total50.ToString("0.00");
            lbl_total_20.Text = "Q" + total20.ToString("0.00");
            lbl_total_10.Text = "Q" + total10.ToString("0.00");
            lbl_total_5.Text = "Q" + total5.ToString("0.00");
            lbl_total_1.Text = "Q" + total1.ToString("0.00");

            // ===== TOTAL BILLETES =====

            double totalBilletes =
                total200 +
                total100 +
                total50 +
                total20 +
                total10 +
                total5 +
                total1;

            lbl_total_billetes.Text =
                "Q" + totalBilletes.ToString("0.00");
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

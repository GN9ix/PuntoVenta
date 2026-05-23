namespace PuntoVenta
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            img_caja = new PictureBox();
            panel_caja = new Panel();
            lbl_caja = new Label();
            panel2 = new Panel();
            lbl_bienvenida = new Label();
            panel_compra = new Panel();
            lbl_compra = new Label();
            img_compra = new PictureBox();
            panel_inventario = new Panel();
            lbl_inventario = new Label();
            img_inventario = new PictureBox();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)img_caja).BeginInit();
            panel_caja.SuspendLayout();
            panel2.SuspendLayout();
            panel_compra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_compra).BeginInit();
            panel_inventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_inventario).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // img_caja
            // 
            img_caja.Anchor = AnchorStyles.Top;
            img_caja.BorderStyle = BorderStyle.Fixed3D;
            img_caja.Image = (Image)resources.GetObject("img_caja.Image");
            img_caja.Location = new Point(62, 12);
            img_caja.Name = "img_caja";
            img_caja.Size = new Size(146, 117);
            img_caja.SizeMode = PictureBoxSizeMode.StretchImage;
            img_caja.TabIndex = 3;
            img_caja.TabStop = false;
            img_caja.Click += img_caja_Click;
            // 
            // panel_caja
            // 
            panel_caja.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel_caja.BackColor = Color.DodgerBlue;
            panel_caja.Controls.Add(lbl_caja);
            panel_caja.Controls.Add(img_caja);
            panel_caja.Location = new Point(77, 127);
            panel_caja.Name = "panel_caja";
            panel_caja.Size = new Size(272, 191);
            panel_caja.TabIndex = 4;
            panel_caja.Click += panel_caja_Click;
            // 
            // lbl_caja
            // 
            lbl_caja.Anchor = AnchorStyles.Bottom;
            lbl_caja.AutoSize = true;
            lbl_caja.Font = new Font("Kanit ExtraBold", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_caja.Location = new Point(78, 132);
            lbl_caja.Name = "lbl_caja";
            lbl_caja.Size = new Size(109, 54);
            lbl_caja.TabIndex = 4;
            lbl_caja.Text = "CAJA";
            lbl_caja.Click += lbl_caja_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SkyBlue;
            panel2.Controls.Add(lbl_bienvenida);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1204, 150);
            panel2.TabIndex = 5;
            // 
            // lbl_bienvenida
            // 
            lbl_bienvenida.AutoSize = true;
            lbl_bienvenida.Font = new Font("Audiowide", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_bienvenida.Location = new Point(15, 41);
            lbl_bienvenida.Name = "lbl_bienvenida";
            lbl_bienvenida.Size = new Size(0, 63);
            lbl_bienvenida.TabIndex = 0;
            // 
            // panel_compra
            // 
            panel_compra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel_compra.BackColor = Color.Yellow;
            panel_compra.Controls.Add(lbl_compra);
            panel_compra.Controls.Add(img_compra);
            panel_compra.Location = new Point(842, 126);
            panel_compra.Name = "panel_compra";
            panel_compra.Size = new Size(272, 191);
            panel_compra.TabIndex = 5;
            panel_compra.Click += panel_compra_Click;
            // 
            // lbl_compra
            // 
            lbl_compra.Anchor = AnchorStyles.Bottom;
            lbl_compra.AutoSize = true;
            lbl_compra.Font = new Font("Kanit ExtraBold", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_compra.Location = new Point(47, 135);
            lbl_compra.Name = "lbl_compra";
            lbl_compra.Size = new Size(180, 54);
            lbl_compra.TabIndex = 4;
            lbl_compra.Text = "COMPRAS";
            lbl_compra.Click += lbl_compra_Click;
            // 
            // img_compra
            // 
            img_compra.Anchor = AnchorStyles.Top;
            img_compra.BorderStyle = BorderStyle.Fixed3D;
            img_compra.Image = (Image)resources.GetObject("img_compra.Image");
            img_compra.Location = new Point(65, 10);
            img_compra.Name = "img_compra";
            img_compra.Size = new Size(147, 122);
            img_compra.SizeMode = PictureBoxSizeMode.StretchImage;
            img_compra.TabIndex = 3;
            img_compra.TabStop = false;
            img_compra.Click += img_compra_Click;
            // 
            // panel_inventario
            // 
            panel_inventario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel_inventario.BackColor = Color.Crimson;
            panel_inventario.Controls.Add(lbl_inventario);
            panel_inventario.Controls.Add(img_inventario);
            panel_inventario.Location = new Point(460, 127);
            panel_inventario.Name = "panel_inventario";
            panel_inventario.Size = new Size(272, 191);
            panel_inventario.TabIndex = 5;
            panel_inventario.Click += panel_inventario_Click;
            // 
            // lbl_inventario
            // 
            lbl_inventario.Anchor = AnchorStyles.Bottom;
            lbl_inventario.AutoSize = true;
            lbl_inventario.Font = new Font("Kanit ExtraBold", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_inventario.Location = new Point(28, 136);
            lbl_inventario.Name = "lbl_inventario";
            lbl_inventario.Size = new Size(222, 54);
            lbl_inventario.TabIndex = 5;
            lbl_inventario.Text = "INVENTARIO";
            lbl_inventario.Click += lbl_inventario_Click;
            // 
            // img_inventario
            // 
            img_inventario.Anchor = AnchorStyles.Top;
            img_inventario.BorderStyle = BorderStyle.Fixed3D;
            img_inventario.Image = (Image)resources.GetObject("img_inventario.Image");
            img_inventario.Location = new Point(66, 12);
            img_inventario.Name = "img_inventario";
            img_inventario.Size = new Size(147, 119);
            img_inventario.SizeMode = PictureBoxSizeMode.StretchImage;
            img_inventario.TabIndex = 0;
            img_inventario.TabStop = false;
            img_inventario.Click += img_inventario_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightCyan;
            panel3.Controls.Add(panel_compra);
            panel3.Controls.Add(panel_caja);
            panel3.Controls.Add(panel_inventario);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 150);
            panel3.Name = "panel3";
            panel3.Size = new Size(1204, 499);
            panel3.TabIndex = 6;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1204, 649);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Principal";
            Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)img_caja).EndInit();
            panel_caja.ResumeLayout(false);
            panel_caja.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel_compra.ResumeLayout(false);
            panel_compra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)img_compra).EndInit();
            panel_inventario.ResumeLayout(false);
            panel_inventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)img_inventario).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox img_caja;
        private Panel panel_caja;
        private Label lbl_caja;
        private Panel panel2;
        private Panel panel_inventario;
        private PictureBox img_inventario;
        private Panel panel3;
        private Label lbl_inventario;
        private Panel panel_compra;
        private Label lbl_compra;
        private PictureBox img_compra;
        private Label lbl_bienvenida;
    }
}
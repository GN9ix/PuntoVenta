namespace PuntoVenta
{
    partial class PuntoVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuntoVenta));
            panel1 = new Panel();
            btn_logout = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btn_usuarios = new Button();
            btn_productos = new Button();
            btn_inventario = new Button();
            btn_principal = new Button();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            Contenedor = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1108, 61);
            panel1.TabIndex = 0;
            // 
            // btn_logout
            // 
            btn_logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_logout.BackColor = Color.Red;
            btn_logout.ForeColor = SystemColors.ControlLightLight;
            btn_logout.Location = new Point(1002, 12);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(94, 29);
            btn_logout.TabIndex = 2;
            btn_logout.Text = "SALIR";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(428, 6);
            label1.Name = "label1";
            label1.Size = new Size(307, 55);
            label1.TabIndex = 1;
            label1.Text = "DASHBOARD";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(btn_usuarios);
            panel2.Controls.Add(btn_productos);
            panel2.Controls.Add(btn_inventario);
            panel2.Controls.Add(btn_principal);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(205, 595);
            panel2.TabIndex = 1;
            // 
            // btn_usuarios
            // 
            btn_usuarios.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_usuarios.Font = new Font("Kanit ExtraBold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_usuarios.Location = new Point(46, 496);
            btn_usuarios.Name = "btn_usuarios";
            btn_usuarios.Size = new Size(153, 35);
            btn_usuarios.TabIndex = 9;
            btn_usuarios.Text = "USUARIOS";
            btn_usuarios.TextAlign = ContentAlignment.TopLeft;
            btn_usuarios.UseVisualStyleBackColor = true;
            // 
            // btn_productos
            // 
            btn_productos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_productos.Font = new Font("Kanit ExtraBold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_productos.Location = new Point(46, 351);
            btn_productos.Name = "btn_productos";
            btn_productos.Size = new Size(153, 35);
            btn_productos.TabIndex = 8;
            btn_productos.Text = "PRODUCTOS";
            btn_productos.TextAlign = ContentAlignment.TopLeft;
            btn_productos.UseVisualStyleBackColor = true;
            // 
            // btn_inventario
            // 
            btn_inventario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_inventario.Font = new Font("Kanit ExtraBold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_inventario.Location = new Point(46, 230);
            btn_inventario.Name = "btn_inventario";
            btn_inventario.Size = new Size(153, 35);
            btn_inventario.TabIndex = 7;
            btn_inventario.Text = "INVENTARIO";
            btn_inventario.TextAlign = ContentAlignment.TopLeft;
            btn_inventario.UseVisualStyleBackColor = true;
            btn_inventario.Click += btn_inventario_Click;
            // 
            // btn_principal
            // 
            btn_principal.Font = new Font("Kanit ExtraBold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_principal.Location = new Point(46, 42);
            btn_principal.Name = "btn_principal";
            btn_principal.Size = new Size(153, 35);
            btn_principal.TabIndex = 6;
            btn_principal.Text = "PRINCIPAL";
            btn_principal.TextAlign = ContentAlignment.TopLeft;
            btn_principal.UseVisualStyleBackColor = true;
            btn_principal.Click += btn_principal_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox5.BackColor = SystemColors.ButtonHighlight;
            pictureBox5.Cursor = Cursors.No;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 496);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(37, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox4.BackColor = SystemColors.ButtonHighlight;
            pictureBox4.Cursor = Cursors.No;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 351);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Cursor = Cursors.No;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 230);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.Cursor = Cursors.No;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // Contenedor
            // 
            Contenedor.BackColor = Color.White;
            Contenedor.Dock = DockStyle.Fill;
            Contenedor.Location = new Point(205, 61);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(903, 595);
            Contenedor.TabIndex = 2;
            // 
            // PuntoVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1108, 656);
            Controls.Add(Contenedor);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PuntoVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Punto de Venta";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Button btn_principal;
        private Button btn_usuarios;
        private Button btn_productos;
        private Button btn_inventario;
        private Panel Contenedor;
        private Button btn_logout;
    }
}
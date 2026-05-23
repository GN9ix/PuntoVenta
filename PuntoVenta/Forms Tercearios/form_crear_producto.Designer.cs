namespace PuntoVenta.Forms_Tercearios
{
    partial class form_crear_producto
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
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            dgv_nuevos_productos = new DataGridView();
            panel3 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            txt_precio = new TextBox();
            label6 = new Label();
            txt_costo = new TextBox();
            label5 = new Label();
            txt_codigo = new TextBox();
            label4 = new Label();
            txt_producto = new TextBox();
            label3 = new Label();
            btn_crear = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_nuevos_productos).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Audiowide", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(408, -6);
            label1.Name = "label1";
            label1.Size = new Size(311, 51);
            label1.TabIndex = 0;
            label1.Text = "INVENTARIO";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1101, 45);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dgv_nuevos_productos);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 449);
            panel2.Name = "panel2";
            panel2.Size = new Size(1101, 316);
            panel2.TabIndex = 2;
            // 
            // dgv_nuevos_productos
            // 
            dgv_nuevos_productos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_nuevos_productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_nuevos_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_nuevos_productos.Location = new Point(3, 6);
            dgv_nuevos_productos.Name = "dgv_nuevos_productos";
            dgv_nuevos_productos.RowHeadersVisible = false;
            dgv_nuevos_productos.RowHeadersWidth = 51;
            dgv_nuevos_productos.Size = new Size(1095, 298);
            dgv_nuevos_productos.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MistyRose;
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(1101, 50);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Audiowide", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(379, 6);
            label2.Name = "label2";
            label2.Size = new Size(358, 39);
            label2.TabIndex = 1;
            label2.Text = "NUEVO PRODUCTO";
            // 
            // panel4
            // 
            panel4.BackColor = Color.AntiqueWhite;
            panel4.Controls.Add(txt_precio);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(txt_costo);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txt_codigo);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(txt_producto);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(btn_crear);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 95);
            panel4.Name = "panel4";
            panel4.Size = new Size(1101, 354);
            panel4.TabIndex = 4;
            // 
            // txt_precio
            // 
            txt_precio.Anchor = AnchorStyles.None;
            txt_precio.Location = new Point(773, 205);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(105, 27);
            txt_precio.TabIndex = 8;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(697, 205);
            label6.Name = "label6";
            label6.Size = new Size(76, 28);
            label6.TabIndex = 7;
            label6.Text = "Precio:";
            // 
            // txt_costo
            // 
            txt_costo.Anchor = AnchorStyles.None;
            txt_costo.Location = new Point(285, 205);
            txt_costo.Name = "txt_costo";
            txt_costo.Size = new Size(105, 27);
            txt_costo.TabIndex = 6;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(209, 205);
            label5.Name = "label5";
            label5.Size = new Size(70, 28);
            label5.TabIndex = 5;
            label5.Text = "Costo:";
            // 
            // txt_codigo
            // 
            txt_codigo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_codigo.Location = new Point(142, 128);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(919, 27);
            txt_codigo.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(53, 128);
            label4.Name = "label4";
            label4.Size = new Size(83, 28);
            label4.TabIndex = 3;
            label4.Text = "Código:";
            // 
            // txt_producto
            // 
            txt_producto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_producto.Location = new Point(142, 87);
            txt_producto.Name = "txt_producto";
            txt_producto.Size = new Size(919, 27);
            txt_producto.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(33, 87);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 1;
            label3.Text = "Producto:";
            // 
            // btn_crear
            // 
            btn_crear.Anchor = AnchorStyles.Bottom;
            btn_crear.BackColor = Color.Lime;
            btn_crear.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_crear.Location = new Point(462, 301);
            btn_crear.Name = "btn_crear";
            btn_crear.Size = new Size(187, 50);
            btn_crear.TabIndex = 0;
            btn_crear.Text = "CREAR";
            btn_crear.UseVisualStyleBackColor = false;
            btn_crear.Click += btn_crear_Click;
            // 
            // form_crear_producto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 765);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_crear_producto";
            Text = "form_crear_producto";
            Shown += form_crear_producto_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_nuevos_productos).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private TextBox txt_producto;
        private Label label3;
        private Button btn_crear;
        private TextBox txt_costo;
        private Label label5;
        private TextBox txt_codigo;
        private Label label4;
        private TextBox txt_precio;
        private Label label6;
        private DataGridView dgv_nuevos_productos;
    }
}
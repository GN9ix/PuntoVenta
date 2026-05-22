namespace PuntoVenta
{
    partial class Compras
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel6 = new Panel();
            label8 = new Label();
            label7 = new Label();
            txt_proveedor = new TextBox();
            txt_factura = new TextBox();
            panel5 = new Panel();
            btn_comprar = new Button();
            dgv_carrito_compras = new DataGridView();
            No = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            CostoCompra = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            dgv_compras = new DataGridView();
            Factura = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Tot = new DataGridViewTextBoxColumn();
            btn_caja = new Button();
            btn_inventario = new Button();
            panel4 = new Panel();
            num_cantidad = new NumericUpDown();
            btn_agregar = new Button();
            txt_precio = new TextBox();
            label6 = new Label();
            txt_costo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txt_lote = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txt_producto = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_carrito_compras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_compras).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_cantidad).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1034, 80);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Audiowide", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(352, 5);
            label1.Name = "label1";
            label1.Size = new Size(349, 68);
            label1.TabIndex = 0;
            label1.Text = "COMPRAS";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Honeydew;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dgv_compras);
            panel2.Location = new Point(38, 145);
            panel2.Name = "panel2";
            panel2.Size = new Size(959, 530);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(dgv_carrito_compras);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(525, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(434, 530);
            panel3.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightCyan;
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(txt_proveedor);
            panel6.Controls.Add(txt_factura);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(434, 91);
            panel6.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(96, 56);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 13;
            label8.Text = "Proveedor:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(88, 22);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 12;
            label7.Text = "No. Factura:";
            // 
            // txt_proveedor
            // 
            txt_proveedor.Location = new Point(208, 49);
            txt_proveedor.Name = "txt_proveedor";
            txt_proveedor.Size = new Size(154, 27);
            txt_proveedor.TabIndex = 2;
            // 
            // txt_factura
            // 
            txt_factura.Location = new Point(208, 15);
            txt_factura.Name = "txt_factura";
            txt_factura.Size = new Size(154, 27);
            txt_factura.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Coral;
            panel5.Controls.Add(btn_comprar);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 440);
            panel5.Name = "panel5";
            panel5.Size = new Size(434, 90);
            panel5.TabIndex = 1;
            // 
            // btn_comprar
            // 
            btn_comprar.Anchor = AnchorStyles.Bottom;
            btn_comprar.BackColor = Color.Lime;
            btn_comprar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_comprar.ForeColor = SystemColors.ControlText;
            btn_comprar.Location = new Point(137, 8);
            btn_comprar.Name = "btn_comprar";
            btn_comprar.Size = new Size(164, 70);
            btn_comprar.TabIndex = 0;
            btn_comprar.Text = "REALIZAR COMPRA";
            btn_comprar.UseVisualStyleBackColor = false;
            btn_comprar.Click += btn_comprar_Click;
            // 
            // dgv_carrito_compras
            // 
            dgv_carrito_compras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_carrito_compras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_carrito_compras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_carrito_compras.Columns.AddRange(new DataGridViewColumn[] { No, Nombre, Cantidad, CostoCompra, Total });
            dgv_carrito_compras.Location = new Point(0, 97);
            dgv_carrito_compras.Name = "dgv_carrito_compras";
            dgv_carrito_compras.RowHeadersVisible = false;
            dgv_carrito_compras.RowHeadersWidth = 51;
            dgv_carrito_compras.Size = new Size(434, 343);
            dgv_carrito_compras.TabIndex = 0;
            // 
            // No
            // 
            No.HeaderText = "No";
            No.MinimumWidth = 6;
            No.Name = "No";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Producto";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            // 
            // CostoCompra
            // 
            CostoCompra.HeaderText = "Costo";
            CostoCompra.MinimumWidth = 6;
            CostoCompra.Name = "CostoCompra";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            // 
            // dgv_compras
            // 
            dgv_compras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_compras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_compras.BackgroundColor = Color.FloralWhite;
            dgv_compras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_compras.Columns.AddRange(new DataGridViewColumn[] { Factura, Proveedor, Fecha, Tot });
            dgv_compras.Location = new Point(2, 318);
            dgv_compras.Name = "dgv_compras";
            dgv_compras.RowHeadersVisible = false;
            dgv_compras.RowHeadersWidth = 51;
            dgv_compras.Size = new Size(522, 212);
            dgv_compras.TabIndex = 0;
            // 
            // Factura
            // 
            Factura.HeaderText = "Factura";
            Factura.MinimumWidth = 6;
            Factura.Name = "Factura";
            // 
            // Proveedor
            // 
            Proveedor.HeaderText = "Proveedor";
            Proveedor.MinimumWidth = 6;
            Proveedor.Name = "Proveedor";
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            // 
            // Tot
            // 
            Tot.HeaderText = "Total";
            Tot.MinimumWidth = 6;
            Tot.Name = "Tot";
            // 
            // btn_caja
            // 
            btn_caja.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_caja.BackColor = Color.DeepSkyBlue;
            btn_caja.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_caja.Location = new Point(780, 106);
            btn_caja.Name = "btn_caja";
            btn_caja.Size = new Size(96, 33);
            btn_caja.TabIndex = 2;
            btn_caja.Text = "CAJA";
            btn_caja.UseVisualStyleBackColor = false;
            btn_caja.Click += btn_caja_Click;
            // 
            // btn_inventario
            // 
            btn_inventario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_inventario.BackColor = Color.Maroon;
            btn_inventario.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            btn_inventario.ForeColor = Color.White;
            btn_inventario.Location = new Point(883, 106);
            btn_inventario.Name = "btn_inventario";
            btn_inventario.Size = new Size(96, 33);
            btn_inventario.TabIndex = 3;
            btn_inventario.Text = "INVENTARIO";
            btn_inventario.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_inventario.UseVisualStyleBackColor = false;
            btn_inventario.Click += btn_inventario_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(num_cantidad);
            panel4.Controls.Add(btn_agregar);
            panel4.Controls.Add(txt_precio);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(txt_costo);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(txt_lote);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(txt_producto);
            panel4.Location = new Point(43, 148);
            panel4.Name = "panel4";
            panel4.Size = new Size(519, 309);
            panel4.TabIndex = 3;
            // 
            // num_cantidad
            // 
            num_cantidad.Location = new Point(425, 61);
            num_cantidad.Name = "num_cantidad";
            num_cantidad.Size = new Size(62, 27);
            num_cantidad.TabIndex = 12;
            // 
            // btn_agregar
            // 
            btn_agregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_agregar.BackColor = Color.Aqua;
            btn_agregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_agregar.ForeColor = SystemColors.ControlText;
            btn_agregar.Location = new Point(398, 263);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(116, 43);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "AGREGAR";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(446, 124);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(58, 27);
            txt_precio.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(387, 124);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 10;
            label6.Text = "Precio:";
            // 
            // txt_costo
            // 
            txt_costo.Location = new Point(323, 124);
            txt_costo.Name = "txt_costo";
            txt_costo.Size = new Size(58, 27);
            txt_costo.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(264, 124);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 8;
            label5.Text = "Costo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(275, 64);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 7;
            label4.Text = "Cantidad a agregar:";
            // 
            // txt_lote
            // 
            txt_lote.Location = new Point(98, 124);
            txt_lote.Name = "txt_lote";
            txt_lote.Size = new Size(154, 27);
            txt_lote.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(48, 124);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 2;
            label3.Text = "Lote:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(15, 64);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Producto:";
            // 
            // txt_producto
            // 
            txt_producto.Location = new Point(98, 61);
            txt_producto.Name = "txt_producto";
            txt_producto.Size = new Size(154, 27);
            txt_producto.TabIndex = 0;
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 713);
            Controls.Add(panel4);
            Controls.Add(btn_inventario);
            Controls.Add(btn_caja);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Compras";
            Text = "Compras";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_carrito_compras).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_compras).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_cantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView dgv_compras;
        private Button btn_caja;
        private Button btn_inventario;
        private Panel panel3;
        private DataGridView dgv_carrito_compras;
        private Panel panel4;
        private Panel panel5;
        private TextBox txt_lote;
        private Label label3;
        private Label label2;
        private TextBox txt_producto;
        private TextBox txt_precio;
        private Label label6;
        private TextBox txt_costo;
        private Label label5;
        private Label label4;
        private Panel panel6;
        private Label label8;
        private Label label7;
        private TextBox txt_proveedor;
        private TextBox txt_factura;
        private Button btn_comprar;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn CostoCompra;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Factura;
        private DataGridViewTextBoxColumn Proveedor;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Tot;
        private Button btn_agregar;
        private NumericUpDown num_cantidad;
    }
}
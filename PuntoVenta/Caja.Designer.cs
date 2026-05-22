namespace PuntoVenta
{
    partial class Caja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caja));
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            btn_compras = new Button();
            btn_reporte = new Button();
            txt_barcod = new TextBox();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel_cobro = new Panel();
            btn_cobrar = new Button();
            lbl_total = new Label();
            panel_productos = new Panel();
            dgv_productos = new DataGridView();
            panel5 = new Panel();
            dgv_carrito = new DataGridView();
            No = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            Quitar = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel_cobro.SuspendLayout();
            panel_productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_productos).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_carrito).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(945, 45);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Audiowide", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(388, 1);
            label2.Name = "label2";
            label2.Size = new Size(129, 44);
            label2.TabIndex = 0;
            label2.Text = "CAJA";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btn_compras);
            panel2.Controls.Add(btn_reporte);
            panel2.Controls.Add(txt_barcod);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(945, 77);
            panel2.TabIndex = 1;
            // 
            // btn_compras
            // 
            btn_compras.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_compras.BackColor = Color.Gold;
            btn_compras.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_compras.Location = new Point(843, 32);
            btn_compras.Name = "btn_compras";
            btn_compras.Size = new Size(94, 29);
            btn_compras.TabIndex = 5;
            btn_compras.Text = "COMPRAS";
            btn_compras.UseVisualStyleBackColor = false;
            btn_compras.Click += btn_compras_Click;
            // 
            // btn_reporte
            // 
            btn_reporte.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_reporte.BackColor = Color.MediumOrchid;
            btn_reporte.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_reporte.Location = new Point(739, 32);
            btn_reporte.Name = "btn_reporte";
            btn_reporte.Size = new Size(94, 29);
            btn_reporte.TabIndex = 3;
            btn_reporte.Text = "REPORTES";
            btn_reporte.UseVisualStyleBackColor = false;
            // 
            // txt_barcod
            // 
            txt_barcod.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_barcod.Font = new Font("Segoe UI", 9F);
            txt_barcod.Location = new Point(75, 34);
            txt_barcod.Name = "txt_barcod";
            txt_barcod.Size = new Size(562, 27);
            txt_barcod.TabIndex = 2;
            txt_barcod.Text = "Búsqueda por Nombre o Código de Barras";
            txt_barcod.KeyDown += txt_barcod_KeyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel_cobro);
            panel3.Controls.Add(lbl_total);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 516);
            panel3.Name = "panel3";
            panel3.Size = new Size(945, 114);
            panel3.TabIndex = 2;
            // 
            // panel_cobro
            // 
            panel_cobro.BackColor = Color.Orange;
            panel_cobro.Controls.Add(btn_cobrar);
            panel_cobro.Dock = DockStyle.Right;
            panel_cobro.Location = new Point(407, 0);
            panel_cobro.Name = "panel_cobro";
            panel_cobro.Size = new Size(538, 114);
            panel_cobro.TabIndex = 2;
            // 
            // btn_cobrar
            // 
            btn_cobrar.Anchor = AnchorStyles.Bottom;
            btn_cobrar.BackColor = Color.Lime;
            btn_cobrar.Font = new Font("Audiowide", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cobrar.Location = new Point(174, 18);
            btn_cobrar.Name = "btn_cobrar";
            btn_cobrar.Size = new Size(203, 84);
            btn_cobrar.TabIndex = 0;
            btn_cobrar.Text = "COBRAR";
            btn_cobrar.UseVisualStyleBackColor = false;
            btn_cobrar.Click += btn_cobrar_Click;
            // 
            // lbl_total
            // 
            lbl_total.Anchor = AnchorStyles.Bottom;
            lbl_total.AutoSize = true;
            lbl_total.Font = new Font("Cascadia Code", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_total.Location = new Point(191, 31);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(0, 56);
            lbl_total.TabIndex = 1;
            // 
            // panel_productos
            // 
            panel_productos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_productos.BackColor = Color.Silver;
            panel_productos.Controls.Add(dgv_productos);
            panel_productos.Location = new Point(0, 122);
            panel_productos.Name = "panel_productos";
            panel_productos.Size = new Size(412, 394);
            panel_productos.TabIndex = 3;
            // 
            // dgv_productos
            // 
            dgv_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_productos.Dock = DockStyle.Fill;
            dgv_productos.Location = new Point(0, 0);
            dgv_productos.Name = "dgv_productos";
            dgv_productos.RowHeadersVisible = false;
            dgv_productos.RowHeadersWidth = 51;
            dgv_productos.Size = new Size(412, 394);
            dgv_productos.TabIndex = 0;
            dgv_productos.CellMouseClick += dgv_productos_CellMouseClick;
            dgv_productos.KeyDown += dgv_productos_KeyDown;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel5.Controls.Add(dgv_carrito);
            panel5.Location = new Point(404, 122);
            panel5.Name = "panel5";
            panel5.Size = new Size(541, 394);
            panel5.TabIndex = 4;
            // 
            // dgv_carrito
            // 
            dgv_carrito.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dgv_carrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_carrito.ColumnHeadersHeight = 29;
            dgv_carrito.Columns.AddRange(new DataGridViewColumn[] { No, Producto, Cantidad, Precio, Subtotal, Quitar });
            dgv_carrito.Location = new Point(5, 0);
            dgv_carrito.Name = "dgv_carrito";
            dgv_carrito.RowHeadersVisible = false;
            dgv_carrito.RowHeadersWidth = 51;
            dgv_carrito.Size = new Size(535, 394);
            dgv_carrito.TabIndex = 0;
            dgv_carrito.CellContentClick += dgv_carrito_CellContentClick;
            dgv_carrito.KeyDown += dgv_carrito_KeyDown;
            // 
            // No
            // 
            No.FillWeight = 10F;
            No.Frozen = true;
            No.HeaderText = "N°";
            No.MinimumWidth = 6;
            No.Name = "No";
            No.SortMode = DataGridViewColumnSortMode.Programmatic;
            No.Width = 55;
            // 
            // Producto
            // 
            Producto.Frozen = true;
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.SortMode = DataGridViewColumnSortMode.NotSortable;
            Producto.Width = 75;
            // 
            // Cantidad
            // 
            Cantidad.Frozen = true;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 98;
            // 
            // Precio
            // 
            Precio.Frozen = true;
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.Width = 79;
            // 
            // Subtotal
            // 
            Subtotal.Frozen = true;
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.Width = 94;
            // 
            // Quitar
            // 
            Quitar.Frozen = true;
            Quitar.HeaderText = "Quitar";
            Quitar.MinimumWidth = 6;
            Quitar.Name = "Quitar";
            Quitar.Width = 79;
            // 
            // Caja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 630);
            Controls.Add(panel5);
            Controls.Add(panel_productos);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Caja";
            Text = "Caja";
            Shown += Caja_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel_cobro.ResumeLayout(false);
            panel_productos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_productos).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_carrito).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel_productos;
        private Panel panel5;
        private TextBox txt_barcod;
        private Label label2;
        private Label lbl_total;
        private DataGridView dgv_carrito;
        private DataGridView dgv_productos;
        private Panel panel_cobro;
        private Button btn_cobrar;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn Quitar;
        private Button btn_compras;
        private Button btn_reporte;
    }
}
namespace PuntoVenta
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btn_nuevo_producto = new Button();
            btn_caja = new Button();
            pictureBox1 = new PictureBox();
            btn_compras = new Button();
            txt_busqueda = new TextBox();
            panel3 = new Panel();
            dgv_inventario = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            BarCod = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Lote = new DataGridViewTextBoxColumn();
            Vencimiento = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewTextBoxColumn();
            Borrar = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_inventario).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 45);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Audiowide", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(240, -2);
            label1.Name = "label1";
            label1.Size = new Size(311, 51);
            label1.TabIndex = 0;
            label1.Text = "INVENTARIO";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Firebrick;
            panel2.Controls.Add(btn_nuevo_producto);
            panel2.Controls.Add(btn_caja);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btn_compras);
            panel2.Controls.Add(txt_busqueda);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 70);
            panel2.TabIndex = 1;
            // 
            // btn_nuevo_producto
            // 
            btn_nuevo_producto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_nuevo_producto.BackColor = Color.GreenYellow;
            btn_nuevo_producto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_nuevo_producto.Location = new Point(475, 9);
            btn_nuevo_producto.Name = "btn_nuevo_producto";
            btn_nuevo_producto.Size = new Size(101, 49);
            btn_nuevo_producto.TabIndex = 4;
            btn_nuevo_producto.Text = "NUEVO\r\nPRODUCTO";
            btn_nuevo_producto.UseVisualStyleBackColor = false;
            btn_nuevo_producto.Click += btn_nuevo_producto_Click;
            // 
            // btn_caja
            // 
            btn_caja.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_caja.BackColor = Color.DeepSkyBlue;
            btn_caja.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_caja.Location = new Point(682, 21);
            btn_caja.Name = "btn_caja";
            btn_caja.Size = new Size(94, 29);
            btn_caja.TabIndex = 3;
            btn_caja.Text = "CAJA";
            btn_caja.UseVisualStyleBackColor = false;
            btn_caja.Click += btn_caja_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btn_compras
            // 
            btn_compras.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_compras.BackColor = Color.Gold;
            btn_compras.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_compras.Location = new Point(582, 21);
            btn_compras.Name = "btn_compras";
            btn_compras.Size = new Size(94, 29);
            btn_compras.TabIndex = 1;
            btn_compras.Text = "COMPRAS";
            btn_compras.UseVisualStyleBackColor = false;
            btn_compras.Click += btn_compras_Click;
            // 
            // txt_busqueda
            // 
            txt_busqueda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_busqueda.Location = new Point(67, 22);
            txt_busqueda.Name = "txt_busqueda";
            txt_busqueda.Size = new Size(402, 27);
            txt_busqueda.TabIndex = 0;
            txt_busqueda.Text = "Búsqueda por Nombre o Código de Barras";
            txt_busqueda.TextChanged += txt_busqueda_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(dgv_inventario);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 115);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 335);
            panel3.TabIndex = 2;
            // 
            // dgv_inventario
            // 
            dgv_inventario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_inventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_inventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_inventario.Columns.AddRange(new DataGridViewColumn[] { id, Producto, BarCod, Costo, Precio, Stock, Lote, Vencimiento, Editar, Borrar });
            dgv_inventario.Location = new Point(0, 6);
            dgv_inventario.Name = "dgv_inventario";
            dgv_inventario.RowHeadersVisible = false;
            dgv_inventario.RowHeadersWidth = 51;
            dgv_inventario.Size = new Size(800, 329);
            dgv_inventario.TabIndex = 0;
            dgv_inventario.CellClick += dgv_inventario_CellClick;
            // 
            // id
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            id.DefaultCellStyle = dataGridViewCellStyle1;
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // Producto
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Producto.DefaultCellStyle = dataGridViewCellStyle2;
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // BarCod
            // 
            BarCod.HeaderText = "Codigo de Barras";
            BarCod.MinimumWidth = 6;
            BarCod.Name = "BarCod";
            BarCod.ReadOnly = true;
            // 
            // Costo
            // 
            Costo.HeaderText = "Costo";
            Costo.MinimumWidth = 6;
            Costo.Name = "Costo";
            Costo.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // Lote
            // 
            Lote.HeaderText = "Lote";
            Lote.MinimumWidth = 6;
            Lote.Name = "Lote";
            Lote.ReadOnly = true;
            // 
            // Vencimiento
            // 
            Vencimiento.HeaderText = "Vencimiento";
            Vencimiento.MinimumWidth = 6;
            Vencimiento.Name = "Vencimiento";
            Vencimiento.ReadOnly = true;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.MinimumWidth = 6;
            Editar.Name = "Editar";
            // 
            // Borrar
            // 
            Borrar.HeaderText = "Borrar";
            Borrar.MinimumWidth = 6;
            Borrar.Name = "Borrar";
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inventario";
            Text = "Inventario";
            Shown += Inventario_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_inventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txt_busqueda;
        private DataGridView dgv_inventario;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn BarCod;
        private DataGridViewTextBoxColumn Costo;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Lote;
        private DataGridViewTextBoxColumn Vencimiento;
        private DataGridViewTextBoxColumn Editar;
        private DataGridViewTextBoxColumn Borrar;
        private PictureBox pictureBox1;
        private Button btn_compras;
        private Button btn_caja;
        private Button btn_nuevo_producto;
    }
}
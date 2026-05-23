namespace PuntoVenta
{
    partial class form_creación_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_creación_usuario));
            label1 = new Label();
            panel1 = new Panel();
            lbl_back = new Label();
            box_back = new PictureBox();
            panel2 = new Panel();
            txt_password = new TextBox();
            txt_usuario = new TextBox();
            btn_cancelar = new Button();
            btn_hecho = new Button();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)box_back).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Audiowide", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(162, 34);
            label1.Name = "label1";
            label1.Size = new Size(487, 60);
            label1.TabIndex = 0;
            label1.Text = "CREAR USUARIO";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lbl_back);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(box_back);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(765, 125);
            panel1.TabIndex = 1;
            // 
            // lbl_back
            // 
            lbl_back.AutoSize = true;
            lbl_back.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_back.Location = new Point(15, 64);
            lbl_back.Name = "lbl_back";
            lbl_back.Size = new Size(47, 20);
            lbl_back.TabIndex = 12;
            lbl_back.Text = "Atrás";
            // 
            // box_back
            // 
            box_back.Image = (Image)resources.GetObject("box_back.Image");
            box_back.Location = new Point(12, 12);
            box_back.Name = "box_back";
            box_back.Size = new Size(83, 49);
            box_back.SizeMode = PictureBoxSizeMode.StretchImage;
            box_back.TabIndex = 11;
            box_back.TabStop = false;
            box_back.Click += box_back_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(txt_password);
            panel2.Controls.Add(txt_usuario);
            panel2.Controls.Add(btn_cancelar);
            panel2.Controls.Add(btn_hecho);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(765, 517);
            panel2.TabIndex = 2;
            // 
            // txt_password
            // 
            txt_password.Anchor = AnchorStyles.Top;
            txt_password.Location = new Point(328, 180);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(226, 27);
            txt_password.TabIndex = 8;
            // 
            // txt_usuario
            // 
            txt_usuario.Anchor = AnchorStyles.Top;
            txt_usuario.Location = new Point(328, 116);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(226, 27);
            txt_usuario.TabIndex = 7;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Top;
            btn_cancelar.BackColor = Color.FromArgb(192, 0, 0);
            btn_cancelar.Font = new Font("Montserrat", 7.79999971F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cancelar.ForeColor = SystemColors.ButtonHighlight;
            btn_cancelar.Location = new Point(223, 283);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(94, 29);
            btn_cancelar.TabIndex = 6;
            btn_cancelar.Text = "CANCELAR";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_hecho
            // 
            btn_hecho.Anchor = AnchorStyles.Top;
            btn_hecho.BackColor = Color.Navy;
            btn_hecho.Font = new Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_hecho.ForeColor = SystemColors.ButtonHighlight;
            btn_hecho.Location = new Point(424, 281);
            btn_hecho.Name = "btn_hecho";
            btn_hecho.Size = new Size(94, 29);
            btn_hecho.TabIndex = 5;
            btn_hecho.Text = "HECHO";
            btn_hecho.UseVisualStyleBackColor = false;
            btn_hecho.Click += btn_hecho_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(223, 183);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(163, 123);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre del Usuario:";
            // 
            // form_creación_usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 642);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_creación_usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Creación_usuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)box_back).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Button btn_cancelar;
        private Button btn_hecho;
        private Label label3;
        private TextBox txt_password;
        private TextBox txt_usuario;
        private Label lbl_back;
        private PictureBox box_back;
    }
}
namespace PuntoVenta
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btn_ingresar = new Button();
            btn_cancel = new Button();
            label1 = new Label();
            label2 = new Label();
            txt_usuario = new TextBox();
            txt_pass = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            btn_salir = new Button();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_ingresar
            // 
            btn_ingresar.Anchor = AnchorStyles.Bottom;
            btn_ingresar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_ingresar.BackColor = Color.FromArgb(38, 0, 255);
            btn_ingresar.ForeColor = SystemColors.ControlLightLight;
            btn_ingresar.Location = new Point(237, 335);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(94, 29);
            btn_ingresar.TabIndex = 0;
            btn_ingresar.Text = "Ingresar";
            btn_ingresar.UseVisualStyleBackColor = false;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Anchor = AnchorStyles.Bottom;
            btn_cancel.BackColor = Color.Red;
            btn_cancel.ForeColor = SystemColors.ControlLightLight;
            btn_cancel.Location = new Point(395, 335);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(94, 29);
            btn_cancel.TabIndex = 1;
            btn_cancel.Text = "Cancelar";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(158, 212);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 2;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(134, 260);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 3;
            label2.Text = "Contraseña:";
            // 
            // txt_usuario
            // 
            txt_usuario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_usuario.Font = new Font("Audiowide", 10.8F, FontStyle.Bold);
            txt_usuario.Location = new Point(237, 209);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(316, 30);
            txt_usuario.TabIndex = 4;
            // 
            // txt_pass
            // 
            txt_pass.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_pass.Font = new Font("Audiowide", 10.8F, FontStyle.Bold);
            txt_pass.Location = new Point(237, 257);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '●';
            txt_pass.Size = new Size(316, 30);
            txt_pass.TabIndex = 5;
            txt_pass.KeyDown += txt_pass_KeyDown;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Audiowide", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(199, 153);
            label3.Name = "label3";
            label3.Size = new Size(290, 39);
            label3.TabIndex = 6;
            label3.Text = "INICIAR SESIÓN";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(280, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btn_salir
            // 
            btn_salir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_salir.BackColor = Color.Maroon;
            btn_salir.BackgroundImageLayout = ImageLayout.Center;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.ForeColor = SystemColors.ControlLightLight;
            btn_salir.ImageAlign = ContentAlignment.TopLeft;
            btn_salir.Location = new Point(7, 3);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(65, 30);
            btn_salir.TabIndex = 8;
            btn_salir.Text = "SALIR";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(71, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Desktop;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btn_salir);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(562, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(110, 42);
            panel1.TabIndex = 10;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlDark;
            label5.Location = new Point(531, 9);
            label5.Name = "label5";
            label5.Size = new Size(30, 20);
            label5.TabIndex = 12;
            label5.Text = "Esc";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(684, 416);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(txt_pass);
            Controls.Add(txt_usuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_cancel);
            Controls.Add(btn_ingresar);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            Shown += Login_Shown;
            KeyDown += Login_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ingresar;
        private Button btn_cancel;
        private Label label1;
        private Label label2;
        private TextBox txt_usuario;
        private TextBox txt_pass;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btn_salir;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label5;
    }
}
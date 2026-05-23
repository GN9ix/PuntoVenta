namespace PuntoVenta
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            panel1 = new Panel();
            label1 = new Label();
            panel_nuevo_usuario = new Panel();
            lbl_nuevo_user = new Label();
            img_nuevo_user = new PictureBox();
            panel_lista_usuarios = new Panel();
            panel_usuario = new Panel();
            panel1.SuspendLayout();
            panel_nuevo_usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_nuevo_user).BeginInit();
            panel_usuario.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1062, 143);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Audiowide", 34F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(336, 38);
            label1.Name = "label1";
            label1.Size = new Size(382, 72);
            label1.TabIndex = 0;
            label1.Text = "USUARIOS";
            // 
            // panel_nuevo_usuario
            // 
            panel_nuevo_usuario.Anchor = AnchorStyles.Top;
            panel_nuevo_usuario.BackColor = Color.White;
            panel_nuevo_usuario.Controls.Add(lbl_nuevo_user);
            panel_nuevo_usuario.Controls.Add(img_nuevo_user);
            panel_nuevo_usuario.Location = new Point(31, 98);
            panel_nuevo_usuario.Name = "panel_nuevo_usuario";
            panel_nuevo_usuario.Size = new Size(348, 330);
            panel_nuevo_usuario.TabIndex = 1;
            panel_nuevo_usuario.Click += panel_nuevo_usuario_Click;
            // 
            // lbl_nuevo_user
            // 
            lbl_nuevo_user.AutoSize = true;
            lbl_nuevo_user.Font = new Font("Audiowide", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nuevo_user.Location = new Point(93, 229);
            lbl_nuevo_user.Name = "lbl_nuevo_user";
            lbl_nuevo_user.Size = new Size(152, 78);
            lbl_nuevo_user.TabIndex = 1;
            lbl_nuevo_user.Text = "Nuevo\r\nUsuario";
            lbl_nuevo_user.TextAlign = ContentAlignment.MiddleCenter;
            lbl_nuevo_user.Click += lbl_nuevo_user_Click;
            // 
            // img_nuevo_user
            // 
            img_nuevo_user.Anchor = AnchorStyles.Top;
            img_nuevo_user.Image = (Image)resources.GetObject("img_nuevo_user.Image");
            img_nuevo_user.Location = new Point(76, 25);
            img_nuevo_user.Name = "img_nuevo_user";
            img_nuevo_user.Size = new Size(191, 170);
            img_nuevo_user.SizeMode = PictureBoxSizeMode.StretchImage;
            img_nuevo_user.TabIndex = 0;
            img_nuevo_user.TabStop = false;
            img_nuevo_user.Click += img_nuevo_user_Click;
            // 
            // panel_lista_usuarios
            // 
            panel_lista_usuarios.Anchor = AnchorStyles.Top;
            panel_lista_usuarios.BackColor = Color.White;
            panel_lista_usuarios.Location = new Point(677, 98);
            panel_lista_usuarios.Name = "panel_lista_usuarios";
            panel_lista_usuarios.Size = new Size(348, 330);
            panel_lista_usuarios.TabIndex = 2;
            // 
            // panel_usuario
            // 
            panel_usuario.Controls.Add(panel_lista_usuarios);
            panel_usuario.Controls.Add(panel_nuevo_usuario);
            panel_usuario.Dock = DockStyle.Fill;
            panel_usuario.Location = new Point(0, 143);
            panel_usuario.Name = "panel_usuario";
            panel_usuario.Size = new Size(1062, 574);
            panel_usuario.TabIndex = 1;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1062, 717);
            Controls.Add(panel_usuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Usuarios";
            Text = "Usuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_nuevo_usuario.ResumeLayout(false);
            panel_nuevo_usuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)img_nuevo_user).EndInit();
            panel_usuario.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel_nuevo_usuario;
        private Label lbl_nuevo_user;
        private PictureBox img_nuevo_user;
        private Panel panel_lista_usuarios;
        private Panel panel_usuario;
    }
}
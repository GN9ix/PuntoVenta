namespace PuntoVenta
{
    partial class Extras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extras));
            panel1 = new Panel();
            label1 = new Label();
            panel_cont_extras = new Panel();
            panel_arqueo = new Panel();
            lbl_arqueo = new Label();
            box_arqueo = new PictureBox();
            panel_crew = new Panel();
            lbl_crew = new Label();
            box_crew = new PictureBox();
            panel1.SuspendLayout();
            panel_cont_extras.SuspendLayout();
            panel_arqueo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)box_arqueo).BeginInit();
            panel_crew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)box_crew).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(943, 133);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Audiowide", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(292, 26);
            label1.Name = "label1";
            label1.Size = new Size(359, 85);
            label1.TabIndex = 0;
            label1.Text = "EXTRAS";
            // 
            // panel_cont_extras
            // 
            panel_cont_extras.BackColor = Color.Black;
            panel_cont_extras.Controls.Add(panel_arqueo);
            panel_cont_extras.Controls.Add(panel_crew);
            panel_cont_extras.Dock = DockStyle.Fill;
            panel_cont_extras.Location = new Point(0, 133);
            panel_cont_extras.Name = "panel_cont_extras";
            panel_cont_extras.Size = new Size(943, 539);
            panel_cont_extras.TabIndex = 1;
            // 
            // panel_arqueo
            // 
            panel_arqueo.Anchor = AnchorStyles.Top;
            panel_arqueo.BackColor = Color.White;
            panel_arqueo.Controls.Add(lbl_arqueo);
            panel_arqueo.Controls.Add(box_arqueo);
            panel_arqueo.Location = new Point(124, 99);
            panel_arqueo.Name = "panel_arqueo";
            panel_arqueo.Size = new Size(311, 285);
            panel_arqueo.TabIndex = 2;
            panel_arqueo.Click += panel_arqueo_Click;
            // 
            // lbl_arqueo
            // 
            lbl_arqueo.Anchor = AnchorStyles.Bottom;
            lbl_arqueo.AutoSize = true;
            lbl_arqueo.Font = new Font("Audiowide", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_arqueo.Location = new Point(59, 205);
            lbl_arqueo.Name = "lbl_arqueo";
            lbl_arqueo.Size = new Size(192, 51);
            lbl_arqueo.TabIndex = 3;
            lbl_arqueo.Text = "Arqueo";
            lbl_arqueo.Click += lbl_arqueo_Click;
            // 
            // box_arqueo
            // 
            box_arqueo.Anchor = AnchorStyles.Top;
            box_arqueo.Image = (Image)resources.GetObject("box_arqueo.Image");
            box_arqueo.Location = new Point(77, 15);
            box_arqueo.Name = "box_arqueo";
            box_arqueo.Size = new Size(159, 162);
            box_arqueo.SizeMode = PictureBoxSizeMode.StretchImage;
            box_arqueo.TabIndex = 0;
            box_arqueo.TabStop = false;
            box_arqueo.Click += box_arqueo_Click;
            // 
            // panel_crew
            // 
            panel_crew.Anchor = AnchorStyles.Top;
            panel_crew.BackColor = Color.White;
            panel_crew.Controls.Add(lbl_crew);
            panel_crew.Controls.Add(box_crew);
            panel_crew.Location = new Point(485, 99);
            panel_crew.Name = "panel_crew";
            panel_crew.Size = new Size(311, 285);
            panel_crew.TabIndex = 1;
            panel_crew.Click += panel_crew_Click;
            // 
            // lbl_crew
            // 
            lbl_crew.Anchor = AnchorStyles.Bottom;
            lbl_crew.AutoSize = true;
            lbl_crew.Font = new Font("Audiowide", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_crew.Location = new Point(23, 180);
            lbl_crew.Name = "lbl_crew";
            lbl_crew.Size = new Size(265, 102);
            lbl_crew.TabIndex = 2;
            lbl_crew.Text = "Equipo de\r\nDesarrollo";
            lbl_crew.Click += lbl_crew_Click;
            // 
            // box_crew
            // 
            box_crew.Anchor = AnchorStyles.Top;
            box_crew.Image = (Image)resources.GetObject("box_crew.Image");
            box_crew.Location = new Point(78, 15);
            box_crew.Name = "box_crew";
            box_crew.Size = new Size(159, 162);
            box_crew.SizeMode = PictureBoxSizeMode.StretchImage;
            box_crew.TabIndex = 2;
            box_crew.TabStop = false;
            box_crew.Click += box_crew_Click;
            // 
            // Extras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 672);
            Controls.Add(panel_cont_extras);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Extras";
            Text = "Extras";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_cont_extras.ResumeLayout(false);
            panel_arqueo.ResumeLayout(false);
            panel_arqueo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)box_arqueo).EndInit();
            panel_crew.ResumeLayout(false);
            panel_crew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)box_crew).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel_cont_extras;
        private Panel panel_crew;
        private Label lbl_crew;
        private PictureBox box_crew;
        private Panel panel_arqueo;
        private Label lbl_arqueo;
        private PictureBox box_arqueo;
    }
}
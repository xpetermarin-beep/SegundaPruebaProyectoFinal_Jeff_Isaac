namespace SegundaPruebaProyectoFinal_Jeff_Isaac
{
    partial class Menuprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menuprincipal));
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblUsuario = new Label();
            lblPosicion = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            btnCerrar = new PictureBox();
            btnminimizarRE = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizarRE).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Blue;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(lblUsuario);
            flowLayoutPanel1.Controls.Add(lblPosicion);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 450);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 254);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 260);
            label1.Name = "label1";
            label1.Size = new Size(220, 40);
            label1.TabIndex = 2;
            label1.Text = "BIENVENIDO";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.SlateGray;
            lblUsuario.Location = new Point(3, 300);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "label1";
            lblUsuario.Click += lblNobre_Click;
            // 
            // lblPosicion
            // 
            lblPosicion.BackColor = Color.DodgerBlue;
            lblPosicion.Location = new Point(59, 300);
            lblPosicion.Name = "lblPosicion";
            lblPosicion.Size = new Size(50, 20);
            lblPosicion.TabIndex = 1;
            lblPosicion.Text = "label2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(370, 36);
            label6.Name = "label6";
            label6.Size = new Size(348, 40);
            label6.TabIndex = 13;
            label6.Text = "VAMOS A AGREGAR";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(285, 120);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 118);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(638, 120);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 118);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(3, 139);
            label2.Name = "label2";
            label2.Size = new Size(147, 40);
            label2.TabIndex = 16;
            label2.Text = "Registro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(641, 260);
            label3.Name = "label3";
            label3.Size = new Size(139, 40);
            label3.TabIndex = 17;
            label3.Text = "Eliminar";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Location = new Point(272, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 200);
            panel1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.Location = new Point(615, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(173, 207);
            panel2.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(272, 362);
            label4.Name = "label4";
            label4.Size = new Size(498, 34);
            label4.TabIndex = 20;
            label4.Text = "NOTA: Escoger una de las opciones";
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(776, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(23, 20);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 23;
            btnCerrar.TabStop = false;
            // 
            // btnminimizarRE
            // 
            btnminimizarRE.Image = (Image)resources.GetObject("btnminimizarRE.Image");
            btnminimizarRE.Location = new Point(747, 3);
            btnminimizarRE.Name = "btnminimizarRE";
            btnminimizarRE.Size = new Size(23, 20);
            btnminimizarRE.SizeMode = PictureBoxSizeMode.Zoom;
            btnminimizarRE.TabIndex = 24;
            btnminimizarRE.TabStop = false;
            // 
            // Menuprincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(btnminimizarRE);
            Controls.Add(btnCerrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label6);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menuprincipal";
            Text = "Menuprincipal";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizarRE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblUsuario;
        private Label lblPosicion;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private PictureBox btnCerrar;
        private PictureBox btnminimizarRE;
    }
}
namespace SegundaPruebaProyectoFinal_Jeff_Isaac
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtUsuarioLogin = new TextBox();
            txtContraseñaLogin = new TextBox();
            btnAccederLogin = new Button();
            label8 = new Label();
            linkRegistrarLogin = new LinkLabel();
            btnCerrar = new PictureBox();
            btnminimizar = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 450);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 219);
            label1.Name = "label1";
            label1.Size = new Size(215, 120);
            label1.TabIndex = 1;
            label1.Text = "Bienvenidos\r\n        a la\r\nAcademia\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(405, 122);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(256, 142);
            label3.Name = "label3";
            label3.Size = new Size(513, 20);
            label3.TabIndex = 8;
            label3.Text = "____________________________________________________________________________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(256, 236);
            label4.Name = "label4";
            label4.Size = new Size(513, 20);
            label4.TabIndex = 9;
            label4.Text = "____________________________________________________________________________________";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(462, 45);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 10;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(355, 27);
            label6.Name = "label6";
            label6.Size = new Size(269, 40);
            label6.TabIndex = 11;
            label6.Text = "Inicio de Sesion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(266, 122);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 12;
            label7.Text = "label7";
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.BackColor = SystemColors.InactiveCaptionText;
            txtUsuarioLogin.BorderStyle = BorderStyle.None;
            txtUsuarioLogin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuarioLogin.ForeColor = Color.DimGray;
            txtUsuarioLogin.Location = new Point(256, 122);
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.Size = new Size(513, 25);
            txtUsuarioLogin.TabIndex = 1;
            txtUsuarioLogin.Text = "USUARIO";
            txtUsuarioLogin.TextChanged += txtUsuarioLogin_TextChanged;
            txtUsuarioLogin.Enter += txtUsuarioLogin_Enter;
            txtUsuarioLogin.Leave += txtUsuarioLogin_Leave;
            // 
            // txtContraseñaLogin
            // 
            txtContraseñaLogin.BackColor = SystemColors.InactiveCaptionText;
            txtContraseñaLogin.BorderStyle = BorderStyle.None;
            txtContraseñaLogin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseñaLogin.ForeColor = Color.DimGray;
            txtContraseñaLogin.Location = new Point(256, 219);
            txtContraseñaLogin.Name = "txtContraseñaLogin";
            txtContraseñaLogin.Size = new Size(513, 25);
            txtContraseñaLogin.TabIndex = 2;
            txtContraseñaLogin.Text = "CONTRASEÑA";
            txtContraseñaLogin.Enter += txtContraseñaLogin_Enter;
            txtContraseñaLogin.Leave += txtContraseñaLogin_Leave;
            // 
            // btnAccederLogin
            // 
            btnAccederLogin.BackColor = Color.FromArgb(40, 40, 40);
            btnAccederLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnAccederLogin.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnAccederLogin.FlatStyle = FlatStyle.Flat;
            btnAccederLogin.ForeColor = Color.Gray;
            btnAccederLogin.Location = new Point(253, 299);
            btnAccederLogin.Name = "btnAccederLogin";
            btnAccederLogin.Size = new Size(531, 40);
            btnAccederLogin.TabIndex = 3;
            btnAccederLogin.Text = "ACCEDER";
            btnAccederLogin.UseVisualStyleBackColor = false;
            btnAccederLogin.Click += btnAccederLogin_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(442, 358);
            label8.Name = "label8";
            label8.Size = new Size(134, 17);
            label8.TabIndex = 16;
            label8.Text = "¿No tienes cuenta?";
            label8.Click += label8_Click;
            // 
            // linkRegistrarLogin
            // 
            linkRegistrarLogin.ActiveLinkColor = Color.FromArgb(0, 0, 192);
            linkRegistrarLogin.AutoSize = true;
            linkRegistrarLogin.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkRegistrarLogin.LinkColor = Color.Gray;
            linkRegistrarLogin.Location = new Point(462, 384);
            linkRegistrarLogin.Name = "linkRegistrarLogin";
            linkRegistrarLogin.Size = new Size(99, 21);
            linkRegistrarLogin.TabIndex = 17;
            linkRegistrarLogin.TabStop = true;
            linkRegistrarLogin.Text = "Regristrase";
            linkRegistrarLogin.LinkClicked += linkRegistrarLogin_LinkClicked;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(775, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(23, 20);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 19;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnminimizar
            // 
            btnminimizar.Image = (Image)resources.GetObject("btnminimizar.Image");
            btnminimizar.Location = new Point(746, 0);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(23, 20);
            btnminimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnminimizar.TabIndex = 20;
            btnminimizar.TabStop = false;
            btnminimizar.Click += btnminimizar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(btnminimizar);
            Controls.Add(btnCerrar);
            Controls.Add(linkRegistrarLogin);
            Controls.Add(label8);
            Controls.Add(btnAccederLogin);
            Controls.Add(txtContraseñaLogin);
            Controls.Add(txtUsuarioLogin);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            Opacity = 0.85D;
            Text = "Form1";
            MouseDown += FormLogin_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtUsuarioLogin;
        private TextBox txtContraseñaLogin;
        private Button btnAccederLogin;
        private Label label8;
        private LinkLabel linkRegistrarLogin;
        private PictureBox btnCerrar;
        private PictureBox btnminimizar;
    }
}

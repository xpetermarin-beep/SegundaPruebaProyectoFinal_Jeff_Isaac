namespace SegundaPruebaProyectoFinal_Jeff_Isaac
{
    partial class FormRegistrarNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarNuevo));
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtUsuarioRegistro = new TextBox();
            txtContarseñaRe = new TextBox();
            txtContraseñaNueva = new TextBox();
            btnRegistrarr = new Button();
            label8 = new Label();
            linkRegistrarLogin = new LinkLabel();
            btnCerrar = new PictureBox();
            btnminimizarRE = new PictureBox();
            lblError = new Label();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizarRE).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Blue;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 450);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.MouseDown += flowLayoutPanel1_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 246);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 255);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(203, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(422, 60);
            label6.Name = "label6";
            label6.Size = new Size(147, 40);
            label6.TabIndex = 12;
            label6.Text = "Registro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(266, 140);
            label3.Name = "label3";
            label3.Size = new Size(513, 20);
            label3.TabIndex = 13;
            label3.Text = "____________________________________________________________________________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(266, 207);
            label1.Name = "label1";
            label1.Size = new Size(513, 20);
            label1.TabIndex = 14;
            label1.Text = "____________________________________________________________________________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(266, 277);
            label2.Name = "label2";
            label2.Size = new Size(513, 20);
            label2.TabIndex = 15;
            label2.Text = "____________________________________________________________________________________";
            // 
            // txtUsuarioRegistro
            // 
            txtUsuarioRegistro.BackColor = SystemColors.InactiveCaptionText;
            txtUsuarioRegistro.BorderStyle = BorderStyle.None;
            txtUsuarioRegistro.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuarioRegistro.ForeColor = Color.DimGray;
            txtUsuarioRegistro.Location = new Point(266, 125);
            txtUsuarioRegistro.Name = "txtUsuarioRegistro";
            txtUsuarioRegistro.Size = new Size(513, 25);
            txtUsuarioRegistro.TabIndex = 16;
            txtUsuarioRegistro.Text = "USUARIO";
            txtUsuarioRegistro.Enter += txtUsuarioRegistro_Enter;
            txtUsuarioRegistro.Leave += txtUsuarioRegistro_Leave;
            // 
            // txtContarseñaRe
            // 
            txtContarseñaRe.BackColor = SystemColors.InactiveCaptionText;
            txtContarseñaRe.BorderStyle = BorderStyle.None;
            txtContarseñaRe.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContarseñaRe.ForeColor = Color.DimGray;
            txtContarseñaRe.Location = new Point(266, 191);
            txtContarseñaRe.Name = "txtContarseñaRe";
            txtContarseñaRe.Size = new Size(513, 25);
            txtContarseñaRe.TabIndex = 17;
            txtContarseñaRe.Text = "CONTRASEÑA";
            txtContarseñaRe.Enter += txtContarseñaRe_Enter;
            txtContarseñaRe.Leave += txtContarseñaRe_Leave;
            // 
            // txtContraseñaNueva
            // 
            txtContraseñaNueva.BackColor = SystemColors.InactiveCaptionText;
            txtContraseñaNueva.BorderStyle = BorderStyle.None;
            txtContraseñaNueva.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseñaNueva.ForeColor = Color.DimGray;
            txtContraseñaNueva.Location = new Point(266, 255);
            txtContraseñaNueva.Name = "txtContraseñaNueva";
            txtContraseñaNueva.Size = new Size(513, 25);
            txtContraseñaNueva.TabIndex = 18;
            txtContraseñaNueva.Text = "CONFIRMAR CONTRASEÑA";
            txtContraseñaNueva.Enter += txtContraseñaNueva_Enter;
            txtContraseñaNueva.Leave += txtContraseñaNueva_Leave;
            // 
            // btnRegistrarr
            // 
            btnRegistrarr.BackColor = Color.FromArgb(40, 40, 40);
            btnRegistrarr.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnRegistrarr.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnRegistrarr.FlatStyle = FlatStyle.Flat;
            btnRegistrarr.ForeColor = Color.Gray;
            btnRegistrarr.Location = new Point(266, 319);
            btnRegistrarr.Name = "btnRegistrarr";
            btnRegistrarr.Size = new Size(522, 40);
            btnRegistrarr.TabIndex = 19;
            btnRegistrarr.Text = "Registrar";
            btnRegistrarr.UseVisualStyleBackColor = false;
            btnRegistrarr.Click += btnRegistrarr_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(458, 372);
            label8.Name = "label8";
            label8.Size = new Size(131, 17);
            label8.TabIndex = 20;
            label8.Text = "¿Ya tienes cuenta?";
            // 
            // linkRegistrarLogin
            // 
            linkRegistrarLogin.ActiveLinkColor = Color.FromArgb(0, 0, 192);
            linkRegistrarLogin.AutoSize = true;
            linkRegistrarLogin.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkRegistrarLogin.LinkColor = Color.Gray;
            linkRegistrarLogin.Location = new Point(458, 403);
            linkRegistrarLogin.Name = "linkRegistrarLogin";
            linkRegistrarLogin.Size = new Size(149, 21);
            linkRegistrarLogin.TabIndex = 21;
            linkRegistrarLogin.TabStop = true;
            linkRegistrarLogin.Text = "INICIAR CUENTA";
            linkRegistrarLogin.LinkClicked += linkRegistrarLogin_LinkClicked;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(776, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(23, 20);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 22;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnminimizarRE
            // 
            btnminimizarRE.Image = (Image)resources.GetObject("btnminimizarRE.Image");
            btnminimizarRE.Location = new Point(747, 3);
            btnminimizarRE.Name = "btnminimizarRE";
            btnminimizarRE.Size = new Size(23, 20);
            btnminimizarRE.SizeMode = PictureBoxSizeMode.Zoom;
            btnminimizarRE.TabIndex = 23;
            btnminimizarRE.TabStop = false;
            btnminimizarRE.Click += btnminimizarRE_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.DimGray;
            lblError.Location = new Point(476, 277);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 17);
            lblError.TabIndex = 24;
            // 
            // FormRegistrarNuevo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(lblError);
            Controls.Add(btnminimizarRE);
            Controls.Add(btnCerrar);
            Controls.Add(linkRegistrarLogin);
            Controls.Add(label8);
            Controls.Add(btnRegistrarr);
            Controls.Add(txtContraseñaNueva);
            Controls.Add(txtContarseñaRe);
            Controls.Add(txtUsuarioRegistro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegistrarNuevo";
            Text = "FormRegistrarNuevo";
            MouseDown += FormRegistrarNuevo_MouseDown;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizarRE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox txtUsuarioRegistro;
        private TextBox txtContarseñaRe;
        private TextBox txtContraseñaNueva;
        private Button btnRegistrarr;
        private Label label8;
        private LinkLabel linkRegistrarLogin;
        private PictureBox btnCerrar;
        private PictureBox btnminimizarRE;
        private Label lblError;
    }
}
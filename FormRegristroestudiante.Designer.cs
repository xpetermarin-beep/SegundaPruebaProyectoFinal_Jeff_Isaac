namespace SegundaPruebaProyectoFinal_Jeff_Isaac
{
    partial class FormRegristroestudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegristroestudiante));
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            txtNombreEstudiante = new TextBox();
            label2 = new Label();
            cboSeccion = new ComboBox();
            label3 = new Label();
            cboNivel = new ComboBox();
            label5 = new Label();
            cboMateria = new ComboBox();
            label6 = new Label();
            txtCotiano = new TextBox();
            label7 = new Label();
            txtTareas = new TextBox();
            label8 = new Label();
            txtProyecto = new TextBox();
            label9 = new Label();
            txtExamen = new TextBox();
            label10 = new Label();
            txtPruebas = new TextBox();
            btnGuardarEstudiante = new Button();
            btnLimpiarCampos = new Button();
            btnCerrar = new PictureBox();
            btnminimizarRE = new PictureBox();
            picAgrandar = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizarRE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAgrandar).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Blue;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(251, 807);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.MouseDown += flowLayoutPanel1_MouseDown;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(257, 25);
            label4.Name = "label4";
            label4.Size = new Size(345, 69);
            label4.TabIndex = 21;
            label4.Text = "Nombre completo del estudiante:\r\n\r\n\r\n";
            // 
            // txtNombreEstudiante
            // 
            txtNombreEstudiante.Location = new Point(608, 25);
            txtNombreEstudiante.Name = "txtNombreEstudiante";
            txtNombreEstudiante.Size = new Size(554, 27);
            txtNombreEstudiante.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(271, 154);
            label2.Name = "label2";
            label2.Size = new Size(92, 92);
            label2.TabIndex = 23;
            label2.Text = "Sección:\r\n\r\n\r\n\r\n";
            // 
            // cboSeccion
            // 
            cboSeccion.FormattingEnabled = true;
            cboSeccion.Items.AddRange(new object[] { "7-1", "7-2", "7-3", "7-4", "8-1", "8-2", "8-3", "8-4", "9-1", "9-2", "9-3", "9-4", "10-1", "10-2", "10-3", "10-4", "11-1", "11-2", "11-3", "11-4" });
            cboSeccion.Location = new Point(391, 154);
            cboSeccion.Name = "cboSeccion";
            cboSeccion.Size = new Size(161, 28);
            cboSeccion.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(271, 90);
            label3.Name = "label3";
            label3.Size = new Size(64, 92);
            label3.TabIndex = 25;
            label3.Text = "Nivel:\r\n\r\n\r\n\r\n";
            // 
            // cboNivel
            // 
            cboNivel.FormattingEnabled = true;
            cboNivel.Items.AddRange(new object[] { "7°", "8°", "9°", "10°", " 11°" });
            cboNivel.Location = new Point(391, 90);
            cboNivel.Name = "cboNivel";
            cboNivel.Size = new Size(161, 28);
            cboNivel.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(274, 219);
            label5.Name = "label5";
            label5.Size = new Size(89, 92);
            label5.TabIndex = 27;
            label5.Text = "Materia:\r\n\r\n\r\n\r\n";
            // 
            // cboMateria
            // 
            cboMateria.FormattingEnabled = true;
            cboMateria.Items.AddRange(new object[] { "Español", "Ciencias", "Biología", "FisicaMate", "Quimica", "Civica", "Estudios Sociales", "Ingles", "Ingles Conversacional", "Contabilidad", "Matematicas", "Filosofia", "Musica", "Religion", "Educacion Fisica", "Tecnologia", "Artes Plasticas" });
            cboMateria.Location = new Point(391, 219);
            cboMateria.Name = "cboMateria";
            cboMateria.Size = new Size(161, 28);
            cboMateria.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(271, 274);
            label6.Name = "label6";
            label6.Size = new Size(188, 92);
            label6.TabIndex = 29;
            label6.Text = "Trabajo Cotidiano:\r\n\r\n\r\n\r\n";
            // 
            // txtCotiano
            // 
            txtCotiano.Location = new Point(465, 274);
            txtCotiano.Name = "txtCotiano";
            txtCotiano.Size = new Size(125, 27);
            txtCotiano.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(271, 331);
            label7.Name = "label7";
            label7.Size = new Size(78, 92);
            label7.TabIndex = 31;
            label7.Text = "Tareas:\r\n\r\n\r\n\r\n";
            // 
            // txtTareas
            // 
            txtTareas.Location = new Point(367, 331);
            txtTareas.Name = "txtTareas";
            txtTareas.Size = new Size(125, 27);
            txtTareas.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(274, 400);
            label8.Name = "label8";
            label8.Size = new Size(103, 23);
            label8.TabIndex = 33;
            label8.Text = "Proyecto:";
            label8.Click += label8_Click;
            // 
            // txtProyecto
            // 
            txtProyecto.Location = new Point(391, 400);
            txtProyecto.Name = "txtProyecto";
            txtProyecto.Size = new Size(125, 27);
            txtProyecto.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(274, 453);
            label9.Name = "label9";
            label9.Size = new Size(178, 23);
            label9.TabIndex = 35;
            label9.Text = "Notas Examenes:";
            // 
            // txtExamen
            // 
            txtExamen.Location = new Point(458, 453);
            txtExamen.Name = "txtExamen";
            txtExamen.Size = new Size(151, 27);
            txtExamen.TabIndex = 36;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(274, 521);
            label10.Name = "label10";
            label10.Size = new Size(155, 23);
            label10.TabIndex = 37;
            label10.Text = "Pruebas (Quiz):";
            label10.Click += label10_Click;
            // 
            // txtPruebas
            // 
            txtPruebas.Location = new Point(458, 521);
            txtPruebas.Name = "txtPruebas";
            txtPruebas.Size = new Size(151, 27);
            txtPruebas.TabIndex = 38;
            // 
            // btnGuardarEstudiante
            // 
            btnGuardarEstudiante.BackColor = Color.FromArgb(0, 192, 0);
            btnGuardarEstudiante.BackgroundImageLayout = ImageLayout.Zoom;
            btnGuardarEstudiante.Location = new Point(678, 622);
            btnGuardarEstudiante.Name = "btnGuardarEstudiante";
            btnGuardarEstudiante.Size = new Size(168, 48);
            btnGuardarEstudiante.TabIndex = 39;
            btnGuardarEstudiante.Text = "GUARDAR ESTUDIANTE";
            btnGuardarEstudiante.UseVisualStyleBackColor = false;
            btnGuardarEstudiante.Click += btnGuardarEstudiante_Click;
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.BackColor = Color.FromArgb(0, 192, 192);
            btnLimpiarCampos.Location = new Point(937, 622);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(167, 48);
            btnLimpiarCampos.TabIndex = 40;
            btnLimpiarCampos.Text = "LIMPIAR";
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1309, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(23, 20);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 41;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnminimizarRE
            // 
            btnminimizarRE.Image = (Image)resources.GetObject("btnminimizarRE.Image");
            btnminimizarRE.Location = new Point(1280, 3);
            btnminimizarRE.Name = "btnminimizarRE";
            btnminimizarRE.Size = new Size(23, 20);
            btnminimizarRE.SizeMode = PictureBoxSizeMode.Zoom;
            btnminimizarRE.TabIndex = 42;
            btnminimizarRE.TabStop = false;
            btnminimizarRE.Click += btnminimizarRE_Click;
            // 
            // picAgrandar
            // 
            picAgrandar.Image = (Image)resources.GetObject("picAgrandar.Image");
            picAgrandar.Location = new Point(1251, 3);
            picAgrandar.Name = "picAgrandar";
            picAgrandar.Size = new Size(23, 20);
            picAgrandar.SizeMode = PictureBoxSizeMode.Zoom;
            picAgrandar.TabIndex = 43;
            picAgrandar.TabStop = false;
            picAgrandar.Click += picAgrandar_Click;
            // 
            // FormRegristroestudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1399, 807);
            Controls.Add(picAgrandar);
            Controls.Add(btnminimizarRE);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiarCampos);
            Controls.Add(btnGuardarEstudiante);
            Controls.Add(txtPruebas);
            Controls.Add(label10);
            Controls.Add(txtExamen);
            Controls.Add(label9);
            Controls.Add(txtProyecto);
            Controls.Add(label8);
            Controls.Add(txtTareas);
            Controls.Add(label7);
            Controls.Add(txtCotiano);
            Controls.Add(label6);
            Controls.Add(cboMateria);
            Controls.Add(label5);
            Controls.Add(cboNivel);
            Controls.Add(cboSeccion);
            Controls.Add(label2);
            Controls.Add(txtNombreEstudiante);
            Controls.Add(label4);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegristroestudiante";
            Text = "FormRegristroestudiante";
            MouseDown += FormRegristroestudiante_MouseDown;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizarRE).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAgrandar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label4;
        private TextBox txtNombreEstudiante;
        private Label label2;
        private ComboBox cboSeccion;
        private Label label3;
        private ComboBox cboNivel;
        private Label label5;
        private ComboBox cboMateria;
        private Label label6;
        private TextBox txtCotiano;
        private Label label7;
        private TextBox txtTareas;
        private Label label8;
        private TextBox txtProyecto;
        private Label label9;
        private TextBox txtExamen;
        private Label label10;
        private TextBox txtPruebas;
        private Button btnGuardarEstudiante;
        private Button btnLimpiarCampos;
        private PictureBox btnCerrar;
        private PictureBox btnminimizarRE;
        private PictureBox picAgrandar;
    }
}
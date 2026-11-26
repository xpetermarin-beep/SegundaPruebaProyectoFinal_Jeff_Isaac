namespace SegundaPruebaProyectoFinal_Jeff_Isaac
{
    partial class FormEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEliminar));
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            txtUsuarioRegistro = new TextBox();
            txtBuscarEstudianteEli = new TextBox();
            btnBuscarEli = new Button();
            dgvEliminarEli = new DataGridView();
            btnConfirmarEliminarEli = new Button();
            btnregresarmenuEli = new Button();
            btnCerrar = new PictureBox();
            btnminimizarRE = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEliminarEli).BeginInit();
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
            flowLayoutPanel1.Size = new Size(250, 587);
            flowLayoutPanel1.TabIndex = 1;
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
            label6.Location = new Point(470, 33);
            label6.Name = "label6";
            label6.Size = new Size(357, 40);
            label6.TabIndex = 13;
            label6.Text = "ELIMINAR ESTUDIANTE";
            // 
            // txtUsuarioRegistro
            // 
            txtUsuarioRegistro.BackColor = SystemColors.InactiveCaptionText;
            txtUsuarioRegistro.BorderStyle = BorderStyle.None;
            txtUsuarioRegistro.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuarioRegistro.ForeColor = Color.DimGray;
            txtUsuarioRegistro.Location = new Point(256, 91);
            txtUsuarioRegistro.Name = "txtUsuarioRegistro";
            txtUsuarioRegistro.Size = new Size(221, 25);
            txtUsuarioRegistro.TabIndex = 17;
            txtUsuarioRegistro.Text = "BUSCAR ESTUDIANTE:";
            // 
            // txtBuscarEstudianteEli
            // 
            txtBuscarEstudianteEli.Location = new Point(470, 91);
            txtBuscarEstudianteEli.Name = "txtBuscarEstudianteEli";
            txtBuscarEstudianteEli.Size = new Size(329, 27);
            txtBuscarEstudianteEli.TabIndex = 18;
            // 
            // btnBuscarEli
            // 
            btnBuscarEli.BackColor = Color.FromArgb(40, 40, 40);
            btnBuscarEli.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnBuscarEli.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnBuscarEli.FlatStyle = FlatStyle.Flat;
            btnBuscarEli.ForeColor = Color.Gray;
            btnBuscarEli.Location = new Point(824, 86);
            btnBuscarEli.Name = "btnBuscarEli";
            btnBuscarEli.Size = new Size(149, 37);
            btnBuscarEli.TabIndex = 20;
            btnBuscarEli.Text = "BUSCAR";
            btnBuscarEli.UseVisualStyleBackColor = false;
            btnBuscarEli.Click += btnBuscarEli_Click;
            // 
            // dgvEliminarEli
            // 
            dgvEliminarEli.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEliminarEli.Location = new Point(319, 148);
            dgvEliminarEli.Name = "dgvEliminarEli";
            dgvEliminarEli.RowHeadersWidth = 51;
            dgvEliminarEli.Size = new Size(694, 216);
            dgvEliminarEli.TabIndex = 21;
            // 
            // btnConfirmarEliminarEli
            // 
            btnConfirmarEliminarEli.BackColor = Color.FromArgb(40, 40, 40);
            btnConfirmarEliminarEli.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnConfirmarEliminarEli.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnConfirmarEliminarEli.FlatStyle = FlatStyle.Flat;
            btnConfirmarEliminarEli.ForeColor = Color.Gray;
            btnConfirmarEliminarEli.Location = new Point(486, 427);
            btnConfirmarEliminarEli.Name = "btnConfirmarEliminarEli";
            btnConfirmarEliminarEli.Size = new Size(149, 37);
            btnConfirmarEliminarEli.TabIndex = 22;
            btnConfirmarEliminarEli.Text = "ELIMINAR";
            btnConfirmarEliminarEli.UseVisualStyleBackColor = false;
            btnConfirmarEliminarEli.Click += btnConfirmarEliminarEli_Click;
            // 
            // btnregresarmenuEli
            // 
            btnregresarmenuEli.BackColor = Color.FromArgb(40, 40, 40);
            btnregresarmenuEli.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnregresarmenuEli.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnregresarmenuEli.FlatStyle = FlatStyle.Flat;
            btnregresarmenuEli.ForeColor = Color.Gray;
            btnregresarmenuEli.Location = new Point(754, 427);
            btnregresarmenuEli.Name = "btnregresarmenuEli";
            btnregresarmenuEli.Size = new Size(149, 37);
            btnregresarmenuEli.TabIndex = 23;
            btnregresarmenuEli.Text = "RECRESAR";
            btnregresarmenuEli.UseVisualStyleBackColor = false;
            btnregresarmenuEli.Click += btnregresarmenuEli_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1105, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(23, 20);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 24;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnminimizarRE
            // 
            btnminimizarRE.Image = (Image)resources.GetObject("btnminimizarRE.Image");
            btnminimizarRE.Location = new Point(1076, 3);
            btnminimizarRE.Name = "btnminimizarRE";
            btnminimizarRE.Size = new Size(23, 20);
            btnminimizarRE.SizeMode = PictureBoxSizeMode.Zoom;
            btnminimizarRE.TabIndex = 25;
            btnminimizarRE.TabStop = false;
            btnminimizarRE.Click += btnminimizarRE_Click;
            // 
            // FormEliminar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1128, 587);
            Controls.Add(btnminimizarRE);
            Controls.Add(btnCerrar);
            Controls.Add(btnregresarmenuEli);
            Controls.Add(btnConfirmarEliminarEli);
            Controls.Add(dgvEliminarEli);
            Controls.Add(btnBuscarEli);
            Controls.Add(txtBuscarEstudianteEli);
            Controls.Add(txtUsuarioRegistro);
            Controls.Add(label6);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEliminar";
            Text = "FormEliminar";
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEliminarEli).EndInit();
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
        private TextBox txtUsuarioRegistro;
        private TextBox txtBuscarEstudianteEli;
        private Button btnBuscarEli;
        private DataGridView dgvEliminarEli;
        private Button btnConfirmarEliminarEli;
        private Button btnregresarmenuEli;
        private PictureBox btnCerrar;
        private PictureBox btnminimizarRE;
    }
}
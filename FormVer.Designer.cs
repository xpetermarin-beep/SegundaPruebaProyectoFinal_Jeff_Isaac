namespace SegundaPruebaProyectoFinal_Jeff_Isaac
{
    partial class FormVer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVer));
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            btnRegresarmenu = new Button();
            txtBusacarEstudiante = new TextBox();
            btnBuscarestu = new Button();
            btnMostrartodos = new Button();
            btnCerrar = new PictureBox();
            btnminimizarRE = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizarRE).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Blue;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.Location = new Point(0, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 547);
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
            label6.Location = new Point(423, 30);
            label6.Name = "label6";
            label6.Size = new Size(269, 40);
            label6.TabIndex = 13;
            label6.Text = "VER ESTUDIANTE";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(256, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(632, 259);
            dataGridView1.TabIndex = 14;
            // 
            // btnRegresarmenu
            // 
            btnRegresarmenu.BackColor = Color.Lime;
            btnRegresarmenu.Location = new Point(516, 446);
            btnRegresarmenu.Name = "btnRegresarmenu";
            btnRegresarmenu.Size = new Size(152, 39);
            btnRegresarmenu.TabIndex = 15;
            btnRegresarmenu.Text = "REGRESAR";
            btnRegresarmenu.UseVisualStyleBackColor = false;
            btnRegresarmenu.Click += btnRegresarmenu_Click;
            // 
            // txtBusacarEstudiante
            // 
            txtBusacarEstudiante.Location = new Point(256, 98);
            txtBusacarEstudiante.Name = "txtBusacarEstudiante";
            txtBusacarEstudiante.Size = new Size(260, 27);
            txtBusacarEstudiante.TabIndex = 16;
            // 
            // btnBuscarestu
            // 
            btnBuscarestu.Location = new Point(522, 98);
            btnBuscarestu.Name = "btnBuscarestu";
            btnBuscarestu.Size = new Size(106, 27);
            btnBuscarestu.TabIndex = 17;
            btnBuscarestu.Text = "BUSCAR";
            btnBuscarestu.UseVisualStyleBackColor = true;
            btnBuscarestu.Click += btnBuscarestu_Click;
            // 
            // btnMostrartodos
            // 
            btnMostrartodos.Location = new Point(645, 98);
            btnMostrartodos.Name = "btnMostrartodos";
            btnMostrartodos.Size = new Size(106, 27);
            btnMostrartodos.TabIndex = 18;
            btnMostrartodos.Text = "MOSTRAR.T";
            btnMostrartodos.UseVisualStyleBackColor = true;
            btnMostrartodos.Click += btnMostrartodos_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(874, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(23, 20);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 23;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnminimizarRE
            // 
            btnminimizarRE.Image = (Image)resources.GetObject("btnminimizarRE.Image");
            btnminimizarRE.Location = new Point(845, 5);
            btnminimizarRE.Name = "btnminimizarRE";
            btnminimizarRE.Size = new Size(23, 20);
            btnminimizarRE.SizeMode = PictureBoxSizeMode.Zoom;
            btnminimizarRE.TabIndex = 24;
            btnminimizarRE.TabStop = false;
            btnminimizarRE.Click += btnminimizarRE_Click;
            // 
            // FormVer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(900, 550);
            Controls.Add(btnminimizarRE);
            Controls.Add(btnCerrar);
            Controls.Add(btnMostrartodos);
            Controls.Add(btnBuscarestu);
            Controls.Add(txtBusacarEstudiante);
            Controls.Add(btnRegresarmenu);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(flowLayoutPanel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVer";
            Text = "FormVer";
            Load += FormVer_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Button btnRegresarmenu;
        private TextBox txtBusacarEstudiante;
        private Button btnBuscarestu;
        private Button btnMostrartodos;
        private PictureBox btnCerrar;
        private PictureBox btnminimizarRE;
    }
}
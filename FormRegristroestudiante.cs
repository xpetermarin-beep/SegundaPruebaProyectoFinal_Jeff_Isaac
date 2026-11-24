using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Runtime.InteropServices;

namespace SegundaPruebaProyectoFinal_Jeff_Isaac
{
    public partial class FormRegristroestudiante : Form
    {
        public FormRegristroestudiante()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        private void btnGuard_Click(object sender, EventArgs e)
        {
            ConexionBD bd = new ConexionBD();

        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombreEstudiante.Clear();
            txtCotiano.Clear();
            txtTareas.Clear();
            txtPruebas.Clear();
            txtProyecto.Clear();
            txtExamen.Clear();
            cboMateria.Text = "";
            cboNivel.Text = "";
            cboSeccion.Text = "";
        }

        private void btnGuardarEstudiante_Click(object sender, EventArgs e)
        {
            ConexionBD bd = new ConexionBD();

            decimal cotidiano = Convert.ToDecimal(txtCotiano.Text);
            decimal tareas = Convert.ToDecimal(txtTareas.Text);
            decimal proyecto = Convert.ToDecimal(txtProyecto.Text);
            decimal examenes = Convert.ToDecimal(txtExamen.Text);
            decimal pruebas = Convert.ToDecimal(txtPruebas.Text);

            decimal promedio = (cotidiano + tareas + proyecto + examenes + pruebas) / 5;
            string estado = "";

            string nivel = cboNivel.Text;

            if (nivel == "7°" || nivel == "8°" || nivel == "9°")
            {
                if (promedio >= 65)
                    estado = "Aprobado";
                else
                    estado = "Reprobado";
            }
            else
            {
                if (promedio >= 70)
                    estado = "Aprobado";
                else
                    estado = "Reprobado";
            }

            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                con.Open();
                string sql = @"INSERT INTO Estudiantes
                (NombreCompleto, Seccion, Nivel, Materia, TrabajoCotidiano, Tareas, Proyecto, Examenes, Pruebas, PromedioFinal, Estado)
                VALUES (@nombre, @seccion, @nivel, @materia, @cotidiano, @tareas, @proyecto, @examenes, @pruebas, @promedio, @estado)";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nombre", txtNombreEstudiante.Text);
                cmd.Parameters.AddWithValue("@seccion", cboSeccion.Text);
                cmd.Parameters.AddWithValue("@nivel", cboNivel.Text);
                cmd.Parameters.AddWithValue("@materia", cboMateria.Text);
                cmd.Parameters.AddWithValue("@cotidiano", cotidiano);
                cmd.Parameters.AddWithValue("@tareas", tareas);
                cmd.Parameters.AddWithValue("@proyecto", proyecto);
                cmd.Parameters.AddWithValue("@examenes", examenes);
                cmd.Parameters.AddWithValue("@pruebas", pruebas);
                cmd.Parameters.AddWithValue("@promedio", promedio);
                cmd.Parameters.AddWithValue("@estado", estado);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Estudiante guardado correctamente");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnminimizarRE_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormRegristroestudiante_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x0112, 0xF012, 0);
        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x0112, 0xF012, 0);
        }

        private void picAgrandar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }

}
    
    
    
    
    
    




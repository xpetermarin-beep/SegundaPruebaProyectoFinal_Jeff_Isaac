using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Microsoft.Data.SqlClient;
namespace SegundaPruebaProyectoFinal_Jeff_Isaac
{
    public partial class FormVer : Form
    {
        private string textoSugerido = "";

        public FormVer()
        {
            InitializeComponent();
        }

        private void FormVer_Load(object sender, EventArgs e)
        {
            txtBusacarEstudiante.Text = textoSugerido;
            txtBusacarEstudiante.ForeColor = Color.Gray;
            CargarDatos();
        }

        public void CargarDatos()
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                con.Open();
                string sql = "SELECT * FROM Estudiantes";
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, con);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                con.Open();
                string sql = "SELECT * FROM Estudiantes WHERE NombreCompleto LIKE @buscar";
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, con);
                adaptador.SelectCommand.Parameters.AddWithValue("@buscar", "%" + txtBusacarEstudiante.Text + "%");
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
           foreach (Form form in Application.OpenForms)
            {
                if (form is Menuprincipal)
                {
                    form.Show();
                    this.Hide();
                    return;
                }
            }
            Menuprincipal menu = new Menuprincipal("");
            menu.Show();
            this.Hide();

        }

        private void txtBusacarEstudiante_Enter(object sender, EventArgs e)
        {
            if (txtBusacarEstudiante.Text == textoSugerido)
            {
                txtBusacarEstudiante.Text = "";
                txtBusacarEstudiante.ForeColor = Color.Black;
            }
        }

        private void txtBusacarEstudiante_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBusacarEstudiante.Text))
            {
                txtBusacarEstudiante.Text = textoSugerido;
                txtBusacarEstudiante.ForeColor = Color.Gray;
            }
        }

        private void btnRegresarmenu_Click(object sender, EventArgs e)
        {
            Menuprincipal menu = new Menuprincipal("");
            menu.Show();
            this.Hide();
        }

        private void btnBuscarestu_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                con.Open();
                string sql = "SELECT * FROM Estudiantes WHERE NombreCompleto LIKE @buscar";
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, con);
                adaptador.SelectCommand.Parameters.AddWithValue("@buscar", "%" + txtBusacarEstudiante.Text + "%");
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
        }

        private void btnMostrartodos_Click(object sender, EventArgs e)
        {
            CargarDatos();
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
    }
}
    
    
    
    
    
    
    
    











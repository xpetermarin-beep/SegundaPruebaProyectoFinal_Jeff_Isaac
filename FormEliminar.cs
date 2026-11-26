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
    public partial class FormEliminar : Form
    {
        public FormEliminar()
        {
            InitializeComponent();
        }

        private void btnBuscarEli_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                con.Open();
                string sql = "SELECT * FROM Estudiantes WHERE NombreCompleto LIKE @buscar";
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, con);
                adaptador.SelectCommand.Parameters.AddWithValue("@buscar", "%" + txtBuscarEstudianteEli.Text + "%");
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvEliminarEli.DataSource = tabla;
            }
        }

        private void btnConfirmarEliminarEli_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                con.Open();
                string sql = "DELETE FROM Estudiantes WHERE NombreCompleto = @nombre";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nombre", txtBuscarEstudianteEli.Text);
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show(" El registro se eliminó correctamente");
                    btnBuscarEli_Click(sender, e);
                    txtBuscarEstudianteEli.Clear();
                }
                else
                {
                    MessageBox.Show(" No se encontró ese estudiante");
                }
            }
        }

        private void btnregresarmenuEli_Click(object sender, EventArgs e)
        {
            Menuprincipal menu = new Menuprincipal("");
            menu.Show();
            this.Close();
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

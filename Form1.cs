
using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;





namespace SegundaPruebaProyectoFinal_Jeff_Isaac




{
    public partial class FormLogin : Form
    {
        public FormLogin()
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkRegistrarLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistrarNuevo formRegistrarNuevo = new FormRegistrarNuevo();
            formRegistrarNuevo.Show();

        }

        private void txtUsuarioLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuarioLogin_Leave(object sender, EventArgs e)
        {
            if (txtUsuarioLogin.Text == "")
            {
                txtUsuarioLogin.Text = "USUARIO";
                txtUsuarioLogin.ForeColor = Color.DimGray;
            }
        }

        private void txtUsuarioLogin_Enter(object sender, EventArgs e)
        {
            if (txtUsuarioLogin.Text == "USUARIO")
            {
                txtUsuarioLogin.Text = "";
                txtUsuarioLogin.ForeColor = Color.LightGray;
            }
        }

        private void txtContraseñaLogin_Enter(object sender, EventArgs e)
        {
            if (txtContraseñaLogin.Text == "CONTRASEÑA")
            {
                txtContraseñaLogin.Text = "";
                txtContraseñaLogin.ForeColor = Color.LightGray;
                txtContraseñaLogin.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseñaLogin_Leave(object sender, EventArgs e)
        {
            if (txtContraseñaLogin.Text == "")
            {
                txtContraseñaLogin.Text = "CONTRASEÑA";
                txtContraseñaLogin.ForeColor = Color.DimGray;
                txtContraseñaLogin.UseSystemPasswordChar = false;
            }
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x0112, 0xF012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x0112, 0xF012, 0);
        }

        private void btnAccederLogin_Click(object sender, EventArgs e)
        {
            



            if (txtContraseñaLogin.Text == "" || txtUsuarioLogin.Text == "USUARIO" ||
         txtContraseñaLogin.Text == "" || txtContraseñaLogin.Text == "CONTRASEÑA")
            {
                MessageBox.Show("Completa todos los campos",
                    "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombreUsuario = txtUsuarioLogin.Text.Trim();
            string contrasena = txtContraseñaLogin.Text.Trim();

            try
            {
                using (var conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @NombreUsuario AND Contrasena = @Contrasena";

                    using (var cmd = new SqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                        cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                        int cantidad = (int)cmd.ExecuteScalar();

                        if (cantidad > 0)
                        {
                            MessageBox.Show($"¡Bienvenido, {nombreUsuario}!",
                                "Inicio exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          

                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos",
                                "Error de inicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
                


            }

            


        }
    }
}

using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using SegundaPruebaProyectoFinal_Jeff_Isaac;


namespace SegundaPruebaProyectoFinal_Jeff_Isaac
{
    public partial class FormRegistrarNuevo : Form
    {
        public FormRegistrarNuevo()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);




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

        private void txtUsuarioRegistro_Enter(object sender, EventArgs e)
        {
            if (txtUsuarioRegistro.Text == "USUARIO")
            {
                txtUsuarioRegistro.Text = "";
                txtUsuarioRegistro.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuarioRegistro_Leave(object sender, EventArgs e)
        {
            if (txtUsuarioRegistro.Text == "")
            {
                txtUsuarioRegistro.Text = "USUARIO";
                txtUsuarioRegistro.ForeColor = Color.DimGray;
            }
        }

        private void txtContarseñaRe_Enter(object sender, EventArgs e)
        {
            if (txtContarseñaRe.Text == "CONTRASEÑA")
            {
                txtContarseñaRe.Text = "";
                txtContarseñaRe.ForeColor = Color.LightGray;
                txtContarseñaRe.UseSystemPasswordChar = true;
            }
        }

        private void txtContarseñaRe_Leave(object sender, EventArgs e)
        {
            if (txtContarseñaRe.Text == "")
            {
                txtContarseñaRe.Text = "CONTRASEÑA";
                txtContarseñaRe.ForeColor = Color.DimGray;
                txtContarseñaRe.UseSystemPasswordChar = false;
            }
        }

        private void txtContraseñaNueva_Enter(object sender, EventArgs e)
        {
            if (txtContraseñaNueva.Text == "CONFIRMAR CONTRASEÑA")
            {
                txtContraseñaNueva.Text = "";
                txtContraseñaNueva.ForeColor = Color.LightGray;
                txtContraseñaNueva.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseñaNueva_Leave(object sender, EventArgs e)
        {
            if (txtContraseñaNueva.Text == "")
            {
                txtContraseñaNueva.Text = "CONFIRMAR CONTRASEÑA";
                txtContraseñaNueva.ForeColor = Color.DimGray;
                txtContraseñaNueva.UseSystemPasswordChar = false;
            }
        }

        private void FormRegistrarNuevo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x0112, 0xF012, 0);
        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x0112, 0xF012, 0);
        }

        private void btnRegistrarr_Click(object sender, EventArgs e)



        {
            lblError.Visible = false;
            // ✅ Tus validaciones — NO se tocan
            if (string.IsNullOrWhiteSpace(txtUsuarioRegistro.Text) || string.IsNullOrWhiteSpace(txtUsuarioRegistro.Text))
            {
                lblError.Visible = true;
                lblError.Text = "Por favor, completa todos los campos";
                return;
            }
            else if (txtContarseñaRe.Text != txtContraseñaNueva.Text)
            {
                lblError.Visible = true;
                lblError.Text = "Las contraseñas no coinciden";
                return;
            }

            try
            {
                // 🔹 Verificar si el usuario ya existe en la base de datos
                bool usuarioExiste = false;

                using (var conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string verificar = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @NombreUsuario";
                    using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(verificar, conexion))
                    {
                        cmd.Parameters.AddWithValue("@NombreUsuario", txtUsuarioRegistro.Text);
                        int cantidad = (int)cmd.ExecuteScalar();
                        usuarioExiste = cantidad > 0;
                    }
                }

                if (usuarioExiste)
                {
                    lblError.Visible = true;
                    lblError.Text = "Este nombre de usuario ya existe";
                    return;
                }

                // 🔹 Insertar el nuevo usuario en la base de datos
                using (var conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string insertar = @"INSERT INTO Usuarios (NombreUsuario, Contrasena)
                               VALUES (@NombreUsuario, @Contrasena)";

                    using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(insertar, conexion))
                    {
                        cmd.Parameters.AddWithValue("@NombreUsuario", txtUsuarioRegistro.Text);
                        cmd.Parameters.AddWithValue("@Contrasena", txtContraseñaNueva.Text);


                        cmd.ExecuteNonQuery();
                    }
                }

                // ✅ Mensaje de éxito — igual que antes
                MessageBox.Show("Registro exitoso!\nYa puedes iniciar sesión!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void linkRegistrarLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin form1 = new FormLogin();
            form1.Show();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SegundaPruebaProyectoFinal_Jeff_Isaac
{
    public partial class Menuprincipal : Form


    {
        public Menuprincipal(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);




        private void lblNobre_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void btnminimizarRE_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Menuprincipal_Load(object sender, EventArgs e)
        {

        }

        private void Menuprincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x0112, 0xF012, 0);
        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x0112, 0xF012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormRegristroestudiante formRegistroEstudiante = new FormRegristroestudiante();
            formRegistroEstudiante.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormVer formVer = new FormVer();
            formVer.Show();


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormEliminar formEliminar = new FormEliminar();
            formEliminar.Show();
        }
    }

}







  
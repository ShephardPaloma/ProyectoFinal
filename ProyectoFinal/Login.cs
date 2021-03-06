using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProyectoFinal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            #region Visual
            txtUsuario.Visible = false;
            txtContrasena.Visible = false;
            btnIniciarSecion.Visible = false;
            labelUsuario.Visible = false;
            labelContrasena.Visible = false;
            btnAdministrador.Visible = true;
            btnUsuario.Visible = true;
            #endregion
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            btnmaximizar.Visible = true;
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnrestaurar.Visible = true;
        }

        private void btnIniciarSecion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Debe completar los campos de usuario y contraseña!");
            }
            else
            {
                if((txtUsuario.Text == "Admin") && (txtContrasena.Text == "pass"))
                {
                    
                    PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
                    pantallaPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    txtUsuario.Text = string.Empty;
                    txtContrasena.Text = string.Empty;
                    MessageBox.Show("Los datos ingresados son incorrectos!", "Datos Erroneos", MessageBoxButtons.OK);
                    return;
                }
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            #region Visual
            txtUsuario.Visible = true;
            txtContrasena.Visible = true;
            btnIniciarSecion.Visible = true;
            labelUsuario.Visible = true;
            labelContrasena.Visible = true;
            btnAdministrador.Visible = false;
            btnUsuario.Visible = false;
            #endregion
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {

            PantallaSolicitud pantallaSolicitud = new PantallaSolicitud();
            pantallaSolicitud.Show();
            this.Hide();
        }
    }
}

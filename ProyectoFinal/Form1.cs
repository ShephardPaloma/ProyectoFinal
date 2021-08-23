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
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lIBROToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnrestaurar.Visible = true;
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            btnmaximizar.Visible = true;
            
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            PantallaAutor pantallaAutor = new PantallaAutor();
            pantallaAutor.ShowDialog();
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            PantallaDevolucion pantallaDevolucion = new PantallaDevolucion();
            pantallaDevolucion.ShowDialog();
        }

        private void btnEditorial_Click(object sender, EventArgs e)
        {
            PantallaEditorial pantallaEditorial = new PantallaEditorial();
            pantallaEditorial.ShowDialog();
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            PantallaEstudiante pantallaEstudiante = new PantallaEstudiante();
            pantallaEstudiante.ShowDialog();
        }

        private void btnLibro_Click(object sender, EventArgs e)
        {
            PantallaLibro pantallaLibro = new PantallaLibro();
            pantallaLibro.ShowDialog();
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            PantallaPrestamo pantallaPrestamo = new PantallaPrestamo();
            pantallaPrestamo.ShowDialog();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            panelSubmenu.Visible = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReporteConteo_Click(object sender, EventArgs e)
        {
            panelSubmenu.Visible = false;
            PantallaReporte pantallaReporte = new PantallaReporte();
            pantallaReporte.ShowDialog();
        }

        private void btnReporteLista_Click(object sender, EventArgs e)
        {
            panelSubmenu.Visible = false;
            PantallaReporte2 pantallaReporte2 = new PantallaReporte2();
            pantallaReporte2.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.DataModel.Repositories;
using ProyectoFinal.DataModel.Entities;
using System.Runtime.InteropServices;
using System.Drawing.Printing;


namespace ProyectoFinal
{
    public partial class PantallaReporte : Form
    {
        AutorRepository autorepository = new AutorRepository();
        DevolucionRepository devolucionepository = new DevolucionRepository();
        EditorialRepository editorialrepository = new EditorialRepository();
        EstudianteRepository estudianterepository = new EstudianteRepository();
        LibroRepository librorepository = new LibroRepository();
        PrestamoRepository prestamoepository = new PrestamoRepository();

        public PantallaReporte()
        {
            InitializeComponent();
            var conteo1 = autorepository.GetAll().Count;
            var conteo2 = devolucionepository.GetAll().Count;
            var conteo3 = editorialrepository.GetAll().Count;
            var conteo4 = estudianterepository.GetAll().Count;
            var conteo5 = librorepository.GetAll().Count;
            var conteo6 = prestamoepository.GetAll().Count;

            Grafica.Series["Conteo"].Points.AddXY("Autor", $"{conteo1}");
            Grafica.Series["Conteo"].Points.AddXY("Devolucion", $"{conteo2}");
            Grafica.Series["Conteo"].Points.AddXY("Editorial", $"{conteo3}");
            Grafica.Series["Conteo"].Points.AddXY("Estudiante", $"{conteo4}");
            Grafica.Series["Conteo"].Points.AddXY("Libro", $"{conteo5}");
            Grafica.Series["Conteo"].Points.AddXY("Prestamo", $"{conteo6}");

            txtConteoAutor.Text = Convert.ToString(conteo1);
            txtConteoDevolucion.Text = Convert.ToString(conteo2);
            txtConteoEditorial.Text = Convert.ToString(conteo3);
            txtConteoEstudiante.Text = Convert.ToString(conteo4);
            txtConteoLibro.Text = Convert.ToString(conteo5);
            txtConteoPrestamo.Text = Convert.ToString(conteo6);

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir de esta pantalla?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnmaximizar.Visible = true;
            btnrestaurar.Visible = false;
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnrestaurar.Visible = true;
        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir de esta pantalla?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Grafica_Click(object sender, EventArgs e)
        {

        }

        private void btnAutor_Click(object sender, EventArgs e)
        {

        }

        private void txtConteoAutor_TextChanged(object sender, EventArgs e)
        {

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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            Grafica.Printing.PrintPreview();
        }
    }
}

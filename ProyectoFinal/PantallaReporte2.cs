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
using ProyectoFinal.DataModel.Repositories;
using ProyectoFinal.DataModel.Entities;

namespace ProyectoFinal
{
    public partial class PantallaReporte2 : Form
    {
        AutorRepository autorepository = new AutorRepository();
        DevolucionRepository devolucionepository = new DevolucionRepository();
        EditorialRepository editorialrepository = new EditorialRepository();
        EstudianteRepository estudianterepository = new EstudianteRepository();
        LibroRepository librorepository = new LibroRepository();
        PrestamoRepository prestamoepository = new PrestamoRepository();

        public PantallaReporte2()
        {
            InitializeComponent();

            //var conteo1 = prestamoepository.GetAll().Select(x => new { x.Id});
            //var conteo2 = prestamoepository.GetAll().Select(x => new { x.estudiante.Nombre });
            //var conteo3 = prestamoepository.GetAll().Select(x => new { x.libro.Nombre });
            //var conteo4 = prestamoepository.GetAll().Select(x => new { x.Estatus });
            //var conteo5 = prestamoepository.GetAll().Select(x => new { x.FechaRegistro });

            //DataTable table = new DataTable();
            //table.Columns.Add("ID");
            //table.Columns.Add("Estudiante");
            //table.Columns.Add("Libro");
            //table.Columns.Add("Estatus");
            //table.Columns.Add("Fecha Registro");
            //dgvReporte2.DataSource = table;

           // dgvReporte2.DataSource = (conteo1, conteo2, conteo3, conteo4, conteo5).ToString().ToList();
           // dgvReporte2.DataSource = conteo1;
              dgvReporte2.DataSource = prestamoepository.GetAll().Select(x => new { x.Id, x.estudiante.Nombre,  x.Estatus, x.FechaRegistro }).ToList();


      // dgvReporte2.Columns["ID"].

            //Grafica.Series["Conteo"].Points.AddXY("Autor", $"{conteo1}");
            //Grafica.Series["Conteo"].Points.AddXY("Devolucion", $"{conteo2}");
            //Grafica.Series["Conteo"].Points.AddXY("Editorial", $"{conteo3}");
            //Grafica.Series["Conteo"].Points.AddXY("Estudiante", $"{conteo4}");
            //Grafica.Series["Conteo"].Points.AddXY("Libro", $"{conteo5}");
            //Grafica.Series["Conteo"].Points.AddXY("Prestamo", $"{conteo6}");

            //txtConteoAutor.Text = Convert.ToString(conteo1);
            //txtConteoDevolucion.Text = Convert.ToString(conteo2);
            //txtConteoEditorial.Text = Convert.ToString(conteo3);
            //txtConteoEstudiante.Text = Convert.ToString(conteo4);
            //txtConteoLibro.Text = Convert.ToString(conteo5);
            //txtConteoPrestamo.Text = Convert.ToString(conteo6);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PantallaReporte2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDBDataSet2.Prestamo' table. You can move, or remove it, as needed.
            this.prestamoTableAdapter.Fill(this.bibliotecaDBDataSet2.Prestamo);

        }
    }
}

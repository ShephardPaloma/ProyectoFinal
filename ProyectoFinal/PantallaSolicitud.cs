using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.DataModel.Context;
using ProyectoFinal.DataModel.Entities;
using ProyectoFinal.DataModel.Repositories;
using System.Runtime.InteropServices;

namespace ProyectoFinal
{
    public partial class PantallaSolicitud : Form
    {
        SolicitudRepository solicitudRepository = new SolicitudRepository();
        public PantallaSolicitud()
        {
            InitializeComponent();

            #region Visual
            imagenSolicitud.Visible = true;
            labelIDEstudiante.Visible = false;
            labelNombre.Visible = false;
            labelApellido.Visible = false;
            labelLibro.Visible = false;
            labelEditorial.Visible = false;
            labelAutor.Visible = false;
            txtIDSolicitud.Visible = false;
            cbNombre.Visible = false;
            cbApellido.Visible = false;
            cbLibro.Visible = false;
            cbEditorial.Visible = false;
            cbAutor.Visible = false;
            btnCrear.Visible = false;
            btnActualizar.Visible = false;
            txtSolicitudID.Visible = false;
            dgvSolicitud.Visible = false;
            #endregion

            cbNombre.Text = string.Empty;
            cbApellido.Text = string.Empty;
            cbLibro.Text = string.Empty;
            cbEditorial.Text = string.Empty;
            cbAutor.Text = string.Empty;

        }
        private void PantallaSolicitud_Load(object sender, EventArgs e)
        {
            using (BibliotecaDbContext context = new BibliotecaDbContext())
            {
                var nombres = context.Estudiantes.Where(x => x.Estatus == "A" && x.Borrado == false).Select(x => x.Nombre).ToList();
                cbNombre.DataSource = nombres;

                var apellidos = context.Estudiantes.Where(x => x.Estatus == "A" && x.Borrado == false).Select(x => x.Apellido ).ToList();
                cbApellido.DataSource = apellidos;

                var libros = context.Libros.Where(x => x.Estatus == "A" && x.Borrado == false).Select(x => x.Nombre ).ToList();
                cbLibro.DataSource = libros;

                var editorial = context.Editorials.Where(x => x.Estatus == "A" && x.Borrado == false).Select(x => x.Nombre ).ToList();
                cbEditorial.DataSource = editorial;

                var autor = context.Autors.Where(x => x.Estatus == "A" && x.Borrado == false).Select(x => x.Nombre ).ToList();
                cbAutor.DataSource = autor;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbNombre.Text) || string.IsNullOrWhiteSpace(cbApellido.Text) || string.IsNullOrWhiteSpace(cbLibro.Text) || string.IsNullOrWhiteSpace(cbEditorial.Text) || string.IsNullOrWhiteSpace(cbAutor.Text))
            {
                MessageBox.Show("Debe completar todos los datos");
            }
            else
            {
                Solicitud nuevasolicitud = new Solicitud()
                {
                    Nombre = cbNombre.Text,
                    Apellido = cbApellido.Text,
                    Libro = cbLibro.Text,
                    Editorial = cbEditorial.Text,
                    Autor= cbAutor.Text
                };

                var existeID = solicitudRepository.FindById(nuevasolicitud.Id);
                if (existeID != null && existeID.Borrado == false)
                {
                    MessageBox.Show("La solicitud ingresada, ya existe!", "Solicitud duplicada", MessageBoxButtons.OK);
                    return;
                }

                solicitudRepository.Create(nuevasolicitud);
                MessageBox.Show("Solicitud creada correctamente!");

                
                cbNombre.Text = string.Empty;
                cbApellido.Text = string.Empty;
                cbLibro.Text = string.Empty;
                cbEditorial.Text = string.Empty;
                cbAutor.Text = string.Empty;

            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir del sistema?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir del sistema?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblhora_Click(object sender, EventArgs e)
        {

        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearVentana_Click(object sender, EventArgs e)
        {
            #region visual
            dgvSolicitud.Visible = false;
            imagenSolicitud.Visible = false;
            labelIDEstudiante.Visible = true;
            labelNombre.Visible = true;
            labelApellido.Visible = true;
            labelLibro.Visible = true;
            labelEditorial.Visible = true;
            labelAutor.Visible = true;
            txtIDSolicitud.Visible = true;
            cbNombre.Visible = true;
            cbApellido.Visible = true;
            cbLibro.Visible = true;
            cbEditorial.Visible = true;
            cbAutor.Visible = true;
            btnCrear.Visible = true;
            btnActualizar.Visible = false;
            txtSolicitudID.Visible = false;
            #endregion
        }

        private void btnActualizarVentana_Click(object sender, EventArgs e)
        {
            #region Visual
            dgvSolicitud.Visible = true;
            imagenSolicitud.Visible = false;
            labelIDEstudiante.Visible = true;
            labelNombre.Visible = true;
            labelApellido.Visible = true;
            labelLibro.Visible = true;
            labelEditorial.Visible = true;
            labelAutor.Visible = true;
            txtIDSolicitud.Visible = false;
            cbNombre.Visible = true;
            cbApellido.Visible = true;
            cbLibro.Visible = true;
            cbEditorial.Visible = true;
            cbAutor.Visible = true;
            btnCrear.Visible = false;
            btnActualizar.Visible = true;
            txtSolicitudID.Visible = true;
            #endregion


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea actualizar la solicitud?", "Actualizar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                var solicitudAct = solicitudRepository.FindById(Convert.ToInt32(txtSolicitudID.Text));

                solicitudAct.Nombre = cbNombre.Text;
                solicitudAct.Apellido = cbApellido.Text;
                solicitudAct.Libro = cbLibro.Text;
                solicitudAct.Editorial = cbEditorial.Text;
                solicitudAct.Autor = cbAutor.Text;

                OperationResult respuesta = solicitudRepository.Update(solicitudAct);

                if (respuesta.Success)
                {
                    MessageBox.Show("Datos de la solicitud actualizados correctamente!");
                    
                    var infosolicitud = solicitudRepository.FindById(Convert.ToInt32(txtSolicitudID.Text));
                    var vistasolicitud = solicitudRepository.GetAll();
                    dgvSolicitud.DataSource = vistasolicitud.Where(x => x.Id == infosolicitud.Id).Select(x => new { x.Id, x.Nombre, x.Apellido, x.Libro, x.Editorial, x.Autor, x.Estatus, x.FechaRegistro, x.FechaActualizacion }).ToList();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error!");
                }

            }
        }

        private void txtSolicitudID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

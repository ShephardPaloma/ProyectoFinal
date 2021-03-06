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
using ProyectoFinal.DataModel.Context;

namespace ProyectoFinal
{
    public partial class PantallaPrestamo : Form
    {
        PrestamoRepository prestamorepository = new PrestamoRepository();
        public PantallaPrestamo()
        {
            InitializeComponent();
            dgvPrestamo.Visible = false;
            #region Visual
            imagenPrestamo.Visible = true;
            labelPrestamoID.Visible = false;
            labelLibroID.Visible = false;
            labelEstudianteID.Visible = false;
            txtIDPrestamo.Visible = false;
            cbLibroID.Visible = false;
            cbEstudianteID.Visible = false;
            btnCrear.Visible = false;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = false;
            txtBuscarId.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = false;
            labelEliminar.Visible = false;
            txtEliminar.Visible = false;
            btnEliminar.Visible = false;
            dgvPrestamo.Visible = true;
            #endregion
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir de esta pantalla?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
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

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnrestaurar.Visible = true;
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = true;
            btnrestaurar.Visible = false;
        }

        private void btnCrearVentana_Click(object sender, EventArgs e)
        {
            dgvPrestamo.Visible = true;
            #region Visual
            imagenPrestamo.Visible = false;
            labelPrestamoID.Visible = true;
            labelLibroID.Visible = true;
            labelEstudianteID.Visible = true;
            txtIDPrestamo.Visible = true;
            cbLibroID.Visible = true;
            cbEstudianteID.Visible = true;
            btnCrear.Visible = true;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = false;
            txtBuscarId.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = false;
            labelEliminar.Visible = false;
            txtEliminar.Visible = false;
            btnEliminar.Visible = false;
            txtIDPrestamo.Enabled = false;
            txtIDPrestamo.Clear();
            #endregion
        }

        private void btnBTodosVentana_Click(object sender, EventArgs e)
        {
            dgvPrestamo.Visible = true;
            #region Visual
            imagenPrestamo.Visible = true;
            labelPrestamoID.Visible = false;
            labelLibroID.Visible = false;
            labelEstudianteID.Visible = false;
            txtIDPrestamo.Visible = false;
            cbLibroID.Visible = false;
            cbEstudianteID.Visible = false;
            btnCrear.Visible = false;
            btnBuscarTodos.Visible = true;
            labelBuscarID.Visible = false;
            txtBuscarId.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = false;
            labelEliminar.Visible = false;
            txtEliminar.Visible = false;
            btnEliminar.Visible = false;
            #endregion
        }

        private void btnBIDVentana_Click(object sender, EventArgs e)
        {
            dgvPrestamo.Visible = true;
            #region Visual
            imagenPrestamo.Visible = true;
            labelPrestamoID.Visible = false;
            labelLibroID.Visible = false;
            labelEstudianteID.Visible = false;
            txtIDPrestamo.Visible = false;
            cbLibroID.Visible = false;
            cbEstudianteID.Visible = false;
            btnCrear.Visible = false;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = true;
            txtBuscarId.Visible = true;
            btnBuscarID.Visible = true;
            btnActualizar.Visible = false;
            labelEliminar.Visible = false;
            txtEliminar.Visible = false;
            btnEliminar.Visible = false;
            #endregion
        }

        private void btnActualizarVentana_Click(object sender, EventArgs e)
        {
            dgvPrestamo.Visible = true;
            #region Visual
            imagenPrestamo.Visible = false;
            labelPrestamoID.Visible = true;
            labelLibroID.Visible = true;
            labelEstudianteID.Visible = true;
            txtIDPrestamo.Visible = true;
            cbLibroID.Visible = true;
            cbEstudianteID.Visible = true;
            btnCrear.Visible = false;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = false;
            txtBuscarId.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = true;
            labelEliminar.Visible = false;
            txtEliminar.Visible = false;
            btnEliminar.Visible = false;
            txtIDPrestamo.Enabled = false;
            #endregion
        }

        private void btnEliminarVentana_Click(object sender, EventArgs e)
        {
            dgvPrestamo.Visible = true;
            #region Visual
            imagenPrestamo.Visible = true;
            labelPrestamoID.Visible = false;
            labelLibroID.Visible = false;
            labelEstudianteID.Visible = false;
            txtIDPrestamo.Visible = false;
            cbLibroID.Visible = false;
            cbEstudianteID.Visible = false;
            btnCrear.Visible = false;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = false;
            txtBuscarId.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = false;
            labelEliminar.Visible = true;
            txtEliminar.Visible = true;
            btnEliminar.Visible = true;
            #endregion
        }

        private void PantallaPrestamo_Load(object sender, EventArgs e)
        {
            MtBuscarTodo();
            using (BibliotecaDbContext context = new BibliotecaDbContext())
            {
                var listaestudiantes = context.Estudiantes.Where(x => x.Estatus == "A" && x.Borrado == false).Select(x => new { x.Id, x.Nombre }).ToList();
                cbEstudianteID.DisplayMember = "Nombre";
                cbEstudianteID.ValueMember = "Id";
                cbEstudianteID.DataSource = listaestudiantes;

                var listalibros = context.Libros.Where(x => x.Estatus == "A" && x.Borrado == false).Select(x => new { x.Id, x.Nombre }).ToList();
                cbLibroID.DisplayMember = "Nombre";
                cbLibroID.ValueMember = "Id";
                cbLibroID.DataSource = listalibros;
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MtBuscarTodo();
            if (string.IsNullOrWhiteSpace(txtIDPrestamo.Text) || string.IsNullOrWhiteSpace(cbEstudianteID.Text) || string.IsNullOrWhiteSpace(cbLibroID.Text))
            {
                MessageBox.Show("Debe completar los datos de Estudiante Id y Libro Id");
            }
            else
            {
                if (MessageBox.Show("Seguro que desea actualizar el prestamo?", "Actualizar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    var prestamoAct = prestamorepository.FindById(Convert.ToInt32(txtIDPrestamo.Text));

                    prestamoAct.EstudianteId = Convert.ToInt32(cbEstudianteID.Text);
                    prestamoAct.LibroId = Convert.ToInt32(cbLibroID.Text);


                    OperationResult respuesta = prestamorepository.Update(prestamoAct);

                    if (respuesta.Success)
                    {
                        MessageBox.Show("Datos del prestamo actualizado correctamente!");
                        MtBuscarTodo();

                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error!");
                    }

                }
            }
        }

        public void MtBuscarTodo()
        {
            dgvPrestamo.DataSource = prestamorepository.GetAll().Select(x => new { x.Id, x.EstudianteId, x.LibroId, x.Estatus, x.FechaRegistro, x.FechaActualizacion }).ToList();
        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            MtBuscarTodo();
        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarId.Text))
            {
                MessageBox.Show("Debe indicar el id del prestamo!", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MtBuscarTodo();
                return;
            }

            var infolibro = prestamorepository.FindById(Convert.ToInt32(txtBuscarId.Text));

            if (infolibro == null)
            {
                MessageBox.Show("No existe el prestamo, favor intentar de nuevo!!", "prestamo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MtBuscarTodo();
                return;
            }

            var vistaprestamo = prestamorepository.GetAll();

            dgvPrestamo.DataSource = vistaprestamo.Where(x => x.Id == infolibro.Id).Select(x => new { x.Id, x.EstudianteId, x.LibroId, x.Estatus, x.FechaRegistro, x.FechaActualizacion}).ToList();

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbEstudianteID.Text) || string.IsNullOrWhiteSpace(cbLibroID.Text))
            {
                MessageBox.Show("Debe completar todos los datos");
            }
            else
            {
                string estudianteid = cbEstudianteID.SelectedValue.ToString();
                string libroid = cbLibroID.SelectedValue.ToString();

                Prestamo nuevoprestamo = new Prestamo()
                {
                    EstudianteId = Convert.ToInt32(estudianteid),
                    LibroId = Convert.ToInt32(libroid)
                };

                var existeID = prestamorepository.FindById(nuevoprestamo.Id);
                if (existeID != null && existeID.Borrado == false)
                {
                    MessageBox.Show("El prestamo ingresado, ya existe!", "prestamo duplicado", MessageBoxButtons.OK);
                    return;
                }

                prestamorepository.Create(nuevoprestamo);
                MessageBox.Show("Datos del prestamo creados correctamente!");

                cbEstudianteID.Text = string.Empty;
                cbLibroID.Text = string.Empty;
                MtBuscarTodo();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MtBuscarTodo();
            if (string.IsNullOrWhiteSpace(txtEliminar.Text))
            {
                MessageBox.Show("Debe indicar el id del prestamo válido!");
            }

            var infoprestamo = prestamorepository.FindById(Convert.ToInt32(txtEliminar.Text));

           
            if (infoprestamo == null)
            {
                MessageBox.Show("No existe el prestamo, favor intentar de nuevo!!", "libro no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MtBuscarTodo();
                return;
            }
            else
            {
                if (MessageBox.Show("Seguro que desea eliminar el registro del prestamo", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var librosAct = prestamorepository.FindById(Convert.ToInt32(txtEliminar.Text));

                    OperationResult resultado = prestamorepository.Delete(librosAct);

                    if (resultado.Success)
                    {
                        MessageBox.Show("Datos del prestamo eliminados correctamente!");

                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error!");
                    }
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
    }
}

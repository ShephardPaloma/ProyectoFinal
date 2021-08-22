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

namespace ProyectoFinal
{
    public partial class PantallaPrestamo : Form
    {
        PrestamoRepository prestamorepository = new PrestamoRepository();
        public PantallaPrestamo()
        {
            InitializeComponent();

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
            // TODO: This line of code loads data into the 'bibliotecaDBDataSet1.Libro' table. You can move, or remove it, as needed.
            this.libroTableAdapter.Fill(this.bibliotecaDBDataSet1.Libro);
            // TODO: This line of code loads data into the 'bibliotecaDBDataSet1.Estudiante' table. You can move, or remove it, as needed.
            this.estudianteTableAdapter.Fill(this.bibliotecaDBDataSet1.Estudiante);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
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
                Prestamo nuevoprestamo = new Prestamo()
                {
                    EstudianteId = Convert.ToInt32(cbEstudianteID.Text),
                    LibroId = Convert.ToInt32(cbLibroID.Text)
                };

                var existeID = prestamorepository.FindById(nuevoprestamo.Id);
                if (existeID != null && existeID.Borrado == false)
                {
                    MessageBox.Show("El prestamo ingresado, ya existe!", "prestamo duplicado", MessageBoxButtons.OK);
                    return;
                }

                prestamorepository.Create(nuevoprestamo);
                MessageBox.Show("Datos del prestamo creados correctamente!");

                MtBuscarTodo();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //validar si está vacio
            if (string.IsNullOrWhiteSpace(txtEliminar.Text))
            {
                MessageBox.Show("Debe indicar el id del prestamo válido!");
            }

            var infoprestamo = prestamorepository.FindById(Convert.ToInt32(txtEliminar.Text));

            //validar que existe el registro de prestamo
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
    }
}

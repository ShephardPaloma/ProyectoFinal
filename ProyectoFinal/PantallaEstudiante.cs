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
    public partial class PantallaEstudiante : Form
    {
        EstudianteRepository estudianterepository = new EstudianteRepository();
        public PantallaEstudiante()
        {
            InitializeComponent();
            dgvEstudiante.Visible = false;
            #region Visual
            imagenEstudiante.Visible = true;
            labelIDEstudiante.Visible = false;
            labelNombre.Visible = false;
            labelApellido.Visible = false;
            labelTelefono.Visible = false;
            labelDireccion.Visible = false;
            txtIDEstudiante.Visible = false;
            txtNombre.Visible = false;
            txtApellido.Visible = false;
            txtDireccion.Visible = false;
            txtTelefono.Visible = false;
            btnCrear.Visible = false;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = false;
            txtBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = false;
            labelEliminar.Visible = false;
            txtEliminar.Visible = false;
            btnEliminar.Visible = false;
            #endregion
        }

        private void btncerrar_Click(object sender, EventArgs e)
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
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            btnmaximizar.Visible = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearVentana_Click_1(object sender, EventArgs e)
        {
            dgvEstudiante.Visible = true;
            #region Visual
            imagenEstudiante.Visible = false;
            labelIDEstudiante.Visible = true;
            labelNombre.Visible = true;
            labelApellido.Visible = true;
            labelTelefono.Visible = true;
            labelDireccion.Visible = true;
            txtIDEstudiante.Visible = true;
            txtNombre.Visible = true;
            txtApellido.Visible = true;
            txtDireccion.Visible = true;
            txtTelefono.Visible = true;
            btnCrear.Visible = true;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = false;
            txtBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = false;
            labelEliminar.Visible = false;
            txtEliminar.Visible = false;
            btnEliminar.Visible = false;
            txtIDEstudiante.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtIDEstudiante.Enabled = false;
            #endregion
        }

        private void btnBTodosVentana_Click_1(object sender, EventArgs e)
        {
            dgvEstudiante.Visible = true;

            #region Visual
            imagenEstudiante.Visible = true;
            labelIDEstudiante.Visible = false;
            labelNombre.Visible = false;
            labelApellido.Visible = false;
            labelTelefono.Visible = false;
            labelDireccion.Visible = false;
            txtIDEstudiante.Visible = false;
            txtNombre.Visible = false;
            txtApellido.Visible = false;
            txtDireccion.Visible = false;
            txtTelefono.Visible = false;
            btnCrear.Visible = false;
            btnBuscarTodos.Visible = true;
            labelBuscarID.Visible = false;
            txtBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = false;
            labelEliminar.Visible = false;
            txtEliminar.Visible = false;
            btnEliminar.Visible = false;
            #endregion
        }

        private void btnBIDVentana_Click_1(object sender, EventArgs e)
        {
            dgvEstudiante.Visible = true;

            #region Visual
            imagenEstudiante.Visible = true;
            labelIDEstudiante.Visible = false;
            labelNombre.Visible = false;
            labelApellido.Visible = false;
            labelTelefono.Visible = false;
            labelDireccion.Visible = false;
            txtIDEstudiante.Visible = false;
            txtNombre.Visible = false;
            txtApellido.Visible = false;
            txtDireccion.Visible = false;
            txtTelefono.Visible = false;
            btnCrear.Visible = false;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = true;
            txtBuscarID.Visible = true;
            btnBuscarID.Visible = true;
            btnActualizar.Visible = false;
            labelEliminar.Visible = false;
            txtEliminar.Visible = false;
            btnEliminar.Visible = false;
            #endregion
        }

        private void btnActualizarVentana_Click_1(object sender, EventArgs e)
        {
            dgvEstudiante.Visible = true;

            #region Visual
            imagenEstudiante.Visible = false;
            labelIDEstudiante.Visible = true;
            labelNombre.Visible = true;
            labelApellido.Visible = true;
            labelTelefono.Visible = true;
            labelDireccion.Visible = true;
            txtIDEstudiante.Visible = true;
            txtNombre.Visible = true;
            txtApellido.Visible = true;
            txtDireccion.Visible = true;
            txtTelefono.Visible = true;
            btnCrear.Visible = false;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = false;
            txtBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = true;
            labelEliminar.Visible = false;
            txtEliminar.Visible = false;
            btnEliminar.Visible = false;
            #endregion
        }

        private void btnEliminarVentana_Click_1(object sender, EventArgs e)
        {
            dgvEstudiante.Visible = true;

            #region Visual
            imagenEstudiante.Visible = true;
            labelIDEstudiante.Visible = false;
            labelNombre.Visible = false;
            labelApellido.Visible = false;
            labelTelefono.Visible = false;
            labelDireccion.Visible = false;
            txtIDEstudiante.Visible = false;
            txtNombre.Visible = false;
            txtApellido.Visible = false;
            txtDireccion.Visible = false;
            txtTelefono.Visible = false;
            btnCrear.Visible = false;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = false;
            txtBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = false;
            labelEliminar.Visible = true;
            txtEliminar.Visible = true;
            btnEliminar.Visible = true;
            #endregion
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Debe completar todos los datos");
            }
            else
            {
                Estudiante nuevoestudiante = new Estudiante()
                {
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text,
                    Apellido = txtApellido.Text

                };

                var existeID = estudianterepository.FindById(nuevoestudiante.Id);
                if (existeID != null && existeID.Borrado == false)
                {
                    MessageBox.Show("El Estudiante ingresado, ya existe!", "Estudiante duplicada", MessageBoxButtons.OK);
                    return;
                }

                estudianterepository.Create(nuevoestudiante);
                MessageBox.Show("Editorial creada correctamente!");

                MtBuscarTodo();

            }

        }
        public void MtBuscarTodo()
        {
            dgvEstudiante.DataSource = estudianterepository.GetAll().Select(x => new { x.Id, x.Nombre, x.Apellido, x.Direccion, x.Telefono, x.Estatus, x.FechaRegistro, x.FechaActualizacion }).ToList();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea actualizar el Estuadiante?", "Actualizar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                var estudianteAct = estudianterepository.FindById(Convert.ToInt32(txtIDEstudiante.Text));

                estudianteAct.Nombre = txtNombre.Text;
                estudianteAct.Direccion = txtDireccion.Text;
                estudianteAct.Apellido = txtApellido.Text;
                estudianteAct.Telefono = txtTelefono.Text;

                OperationResult respuesta = estudianterepository.Update(estudianteAct);

                if (respuesta.Success)
                {
                    MessageBox.Show("Datos del Estudiante actualizados correctamente!");
                    MtBuscarTodo();

                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error!");
                }
                MtBuscarTodo();
            }
        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarID.Text))
            {
                MessageBox.Show("Debe indicar el id del Estudiante!", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            var infoestudiante = estudianterepository.FindById(Convert.ToInt32(txtBuscarID.Text));

            if (infoestudiante == null)
            {
                MessageBox.Show("No existe el Estudiante, favor intentar de nuevo!!", "Estudiante no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            var vistaestudiante = estudianterepository.GetAll();

            dgvEstudiante.DataSource = vistaestudiante.Where(x => x.Id == infoestudiante.Id).Select(x => new { x.Id, x.Nombre, x.Apellido, x.Direccion, x.Telefono, x.Estatus, x.FechaRegistro, x.FechaActualizacion }).ToList();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEliminar.Text))
            {
                MessageBox.Show("Debe indicar un id de Estudiante válido!");
            }

            var EstudianteElimi = estudianterepository.FindById(Convert.ToInt32(txtEliminar.Text));

           
            if (EstudianteElimi == null)
            {
                MessageBox.Show("No existe el Estudiante, favor intentar de nuevo!!", "Estudiante no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MtBuscarTodo();
                return;
            }
            else
            {
                if (MessageBox.Show("Seguro que desea eliminar el registro del Estudiante", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var EstudianteElimin = estudianterepository.FindById(Convert.ToInt32(txtEliminar.Text));

                    OperationResult resultado = estudianterepository.Delete(EstudianteElimin);

                    if (resultado.Success)
                    {
                        MessageBox.Show("Datos del Estudiante eliminados correctamente!");
                        MtBuscarTodo();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error!");
                    }
                }
            }
        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            MtBuscarTodo();
        }

        private void PantallaEstudiante_Load(object sender, EventArgs e)
        {
            MtBuscarTodo();
        }

        private void dgvEstudiante_SelectionChanged(object sender, EventArgs e)
        {
            txtIDEstudiante.Text = dgvEstudiante.CurrentRow.Cells["Id"].Value.ToString();
            txtNombre.Text = dgvEstudiante.CurrentRow.Cells["Nombre"].Value.ToString();
            txtApellido.Text = dgvEstudiante.CurrentRow.Cells["Apellido"].Value.ToString();
            txtDireccion.Text = dgvEstudiante.CurrentRow.Cells["Direccion"].Value.ToString();
            txtTelefono.Text = dgvEstudiante.CurrentRow.Cells["Telefono"].Value.ToString();
        }
    }
}

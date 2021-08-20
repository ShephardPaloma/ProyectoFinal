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
    public partial class PantallaEditorial : Form
    {
        EditorialRepository editorialepository = new EditorialRepository();
        public PantallaEditorial()
        {
            InitializeComponent();
            dgvEditorial.Visible = false;
            #region Visual
            imagenEditorial.Visible = true;
            labelEditorialID.Visible = false;
            labelNombre.Visible = false;
            labelDireccion.Visible = false;
            txtNombre.Visible = false;
            txtIDEditorial.Visible = false;
            txtDireccion.Visible = false;
            btnCrear.Visible = false;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = false;
            txtBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = false;
            txtEliminar.Visible = false;
            labelEliminar.Visible = false;
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
            this.WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = true;
            btnrestaurar.Visible = false;
        }

        private void btnCrearVentana_Click(object sender, EventArgs e)
        {
            dgvEditorial.Visible = true;
            #region Visual
            imagenEditorial.Visible = false;
            labelEditorialID.Visible = true;
            labelNombre.Visible = true;
            labelDireccion.Visible = true;
            txtNombre.Visible = true;
            txtIDEditorial.Visible = true;
            txtDireccion.Visible = true;
            btnCrear.Visible = true;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = false;
            txtBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = false;
            txtEliminar.Visible = false;
            labelEliminar.Visible = false;
            btnEliminar.Visible = false;
            #endregion
        }

        private void btnBTodosVentana_Click(object sender, EventArgs e)
        {
            dgvEditorial.Visible = true;

            #region Visual
            imagenEditorial.Visible = true;
            labelEditorialID.Visible = false;
            labelNombre.Visible = false;
            labelDireccion.Visible = false;
            txtNombre.Visible = false;
            txtIDEditorial.Visible = false;
            txtDireccion.Visible = false;
            btnCrear.Visible = false;
            btnBuscarTodos.Visible = true;
            labelBuscarID.Visible = false;
            txtBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = false;
            txtEliminar.Visible = false;
            labelEliminar.Visible = false;
            btnEliminar.Visible = false;
            #endregion
        }

        private void btnBIDVentana_Click(object sender, EventArgs e)
        {
            dgvEditorial.Visible = true;

            #region Visual
            imagenEditorial.Visible = true;
            labelEditorialID.Visible = false;
            labelNombre.Visible = false;
            labelDireccion.Visible = false;
            txtNombre.Visible = false;
            txtIDEditorial.Visible = false;
            txtDireccion.Visible = false;
            btnCrear.Visible = false;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = true;
            txtBuscarID.Visible = true;
            btnBuscarID.Visible = true;
            btnActualizar.Visible = false;
            txtEliminar.Visible = false;
            labelEliminar.Visible = false;
            btnEliminar.Visible = false;
            #endregion
        }

        private void btnActualizarVentana_Click(object sender, EventArgs e)
        {
            dgvEditorial.Visible = true;

            #region Visual
            imagenEditorial.Visible = false;
            labelEditorialID.Visible = true;
            labelNombre.Visible = true;
            labelDireccion.Visible = true;
            txtNombre.Visible = true;
            txtIDEditorial.Visible = true;
            txtDireccion.Visible = true;
            btnCrear.Visible = false;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = false;
            txtBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = true;
            txtEliminar.Visible = false;
            labelEliminar.Visible = false;
            btnEliminar.Visible = false;
            #endregion
        }

        private void btnEliminarVentana_Click(object sender, EventArgs e)
        {
            dgvEditorial.Visible = true;

            #region Visual
            imagenEditorial.Visible = true;
            labelEditorialID.Visible = false;
            labelNombre.Visible = false;
            labelDireccion.Visible = false;
            txtNombre.Visible = false;
            txtIDEditorial.Visible = false;
            txtDireccion.Visible = false;
            btnCrear.Visible = false;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = false;
            txtBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = false;
            txtEliminar.Visible = true;
            labelEliminar.Visible = true;
            btnEliminar.Visible = true;
            #endregion
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            MtBuscarTodo();
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Debe completar todos los datos");
            }
            else
            {
                Editorial nuevaeditorial = new Editorial()
                {
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text
                };

                var existeID = editorialepository.FindById(nuevaeditorial.Id);
                if (existeID != null && existeID.Borrado == false)
                {
                    MessageBox.Show("La editorial ingresada, ya existe!", "Editorial duplicada", MessageBoxButtons.OK);
                    return;
                }

                editorialepository.Create(nuevaeditorial);
                MessageBox.Show("Editorial creada correctamente!");

                MtBuscarTodo();
            }
        }
        public void MtBuscarTodo()
        {
            dgvEditorial.DataSource = editorialepository.GetAll().Select(x => new { x.Id, x.Nombre, x.Direccion, x.Estatus, x.FechaRegistro, x.FechaActualizacion }).ToList();
        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            MtBuscarTodo();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea actualizar la Editorial?", "Actualizar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                var editorialAct = editorialepository.FindById(Convert.ToInt32(txtIDEditorial.Text));

                editorialAct.Nombre = txtNombre.Text;
                editorialAct.Direccion = txtDireccion.Text;

                OperationResult respuesta = editorialepository.Update(editorialAct);

                if (respuesta.Success)
                {
                    MessageBox.Show("Datos de la Editorial actualizados correctamente!");
                    MtBuscarTodo();

                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error!");
                }
                MtBuscarTodo();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEliminar.Text))
            {
                MessageBox.Show("Debe indicar un id de Editorial válido!");
            }

            var EditorialElimi = editorialepository.FindById(Convert.ToInt32(txtEliminar.Text));

            
            if (EditorialElimi == null)
            {
                MessageBox.Show("No existe la Editorial, favor intentar de nuevo!!", "Editorial no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MtBuscarTodo();
                return;
            }
            else
            {
                if (MessageBox.Show("Seguro que desea eliminar el registro de la Editorial", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var EditorialElimin = editorialepository.FindById(Convert.ToInt32(txtEliminar.Text));

                    OperationResult resultado = editorialepository.Delete(EditorialElimin);

                    if (resultado.Success)
                    {
                        MessageBox.Show("Datos de la Editorial eliminados correctamente!");

                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error!");
                    }
                }
            }
        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarID.Text))
            {
                MessageBox.Show("Debe indicar el id de la Editorial!", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                return;
            }

            var infoeditorial = editorialepository.FindById(Convert.ToInt32(txtBuscarID.Text));

            if (infoeditorial == null)
            {
                MessageBox.Show("No existe la Editorial, favor intentar de nuevo!!", "Editorial no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
                return;
            }

            var vistaeditorial = editorialepository.GetAll();

            dgvEditorial.DataSource = vistaeditorial.Where(x => x.Id == infoeditorial.Id).Select(x => new { x.Id, x.Nombre, x.Direccion, x.Estatus, x.FechaRegistro }).ToList();
        }

    }
}

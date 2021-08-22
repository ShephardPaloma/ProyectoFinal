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
    public partial class PantallaAutor : Form
    {
        AutorRepository autorepository = new AutorRepository();
        public PantallaAutor()
        {

            InitializeComponent();
            dgvAutor.Visible = false;
            
            #region Visual
            imagenAutor.Visible = true;
            txtID.Visible = false;
            txtNombre.Visible = false;
            txtApellido.Visible = false;
            txtNacionalidad.Visible = false;
            labelID.Visible = false;
            labelNombre.Visible = false;
            labelApellido.Visible = false;
            labelNacionalidad.Visible = false;
            btnBuscarTodos.Visible = false;
            btnActualizar.Visible = false;
            btnCrear.Visible = false;
            btnEliminar.Visible = false;
            btnBuscarID.Visible = false;
            labelBuscarID.Visible = false;
            txtBuscarId.Visible = false;
            btnEliminar.Visible = false;
            labelEliminar.Visible = false;
            txtEliminar.Visible = false;
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

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            #region Visual
            dgvAutor.Visible = true;
            imagenAutor.Visible = false;
            txtID.Visible = true;
            txtNombre.Visible = true;
            txtApellido.Visible = true;
            txtNacionalidad.Visible = true;
            labelID.Visible = true;
            labelNombre.Visible = true;
            labelApellido.Visible = true;
            labelNacionalidad.Visible = true;
            btnBuscarTodos.Visible = false;
            btnActualizar.Visible = false;
            btnCrear.Visible = true;
            btnEliminar.Visible = false;
            btnBuscarID.Visible = false;
            labelBuscarID.Visible = false;
            txtBuscarId.Visible = false;
            btnEliminar.Visible = false;
            labelEliminar.Visible = false;
            txtEliminar.Visible = false;
            txtID.Enabled = false;
            txtID.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtNacionalidad.Clear();
            #endregion
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            #region Visual
            dgvAutor.Visible = true;
            imagenAutor.Visible = true;
            btnBuscarTodos.Visible = true;
            txtID.Visible = false;
            txtNombre.Visible = false;
            txtApellido.Visible = false;
            txtNacionalidad.Visible = false;
            labelID.Visible = false;
            labelNombre.Visible = false;
            labelApellido.Visible = false;
            labelNacionalidad.Visible = false;
            btnActualizar.Visible = false;
            btnCrear.Visible = false;
            btnEliminar.Visible = false;
            btnBuscarID.Visible = false;
            labelBuscarID.Visible = false;
            txtBuscarId.Visible = false;
            btnEliminar.Visible = false;
            labelEliminar.Visible = false;
            txtEliminar.Visible = false;
            #endregion
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            #region Visual
            dgvAutor.Visible = true;
            imagenAutor.Visible = false;
            btnBuscarTodos.Visible = false;
            txtID.Visible = true;
            txtNombre.Visible = true;
            txtApellido.Visible = true;
            txtNacionalidad.Visible = true;
            labelID.Visible = true;
            labelNombre.Visible = true;
            labelApellido.Visible = true;
            labelNacionalidad.Visible = true;
            btnActualizar.Visible = true;
            btnCrear.Visible = false;
            btnEliminar.Visible = false;
            btnBuscarID.Visible = false;
            labelBuscarID.Visible = false;
            txtBuscarId.Visible = false;
            btnEliminar.Visible = false;
            labelEliminar.Visible = false;
            txtEliminar.Visible = false;
            txtID.Enabled = false;
            #endregion
        }

        private void btnBIDVentana_Click(object sender, EventArgs e)
        {
            #region Visual
            dgvAutor.Visible = true;
            imagenAutor.Visible = true;
            btnBuscarTodos.Visible = false;
            txtID.Visible = false;
            txtNombre.Visible = false;
            txtApellido.Visible = false;
            txtNacionalidad.Visible = false;
            labelID.Visible = false;
            labelNombre.Visible = false;
            labelApellido.Visible = false;
            labelNacionalidad.Visible = false;
            btnActualizar.Visible = false;
            btnCrear.Visible = false;
            btnEliminar.Visible = false;
            btnBuscarID.Visible = true;
            labelBuscarID.Visible = true;
            txtBuscarId.Visible = true;
            btnEliminar.Visible = false;
            labelEliminar.Visible = false;
            txtEliminar.Visible = false;
            #endregion
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            #region Visual
            dgvAutor.Visible = true;
            imagenAutor.Visible = true;
            btnBuscarTodos.Visible = false;
            txtID.Visible = false;
            txtNombre.Visible = false;
            txtApellido.Visible = false;
            txtNacionalidad.Visible = false;
            labelID.Visible = false;
            labelNombre.Visible = false;
            labelApellido.Visible = false;
            labelNacionalidad.Visible = false;
            btnActualizar.Visible = false;
            btnCrear.Visible = false;
            btnEliminar.Visible = false;
            btnBuscarID.Visible = true;
            labelBuscarID.Visible = true;
            txtBuscarId.Visible = true;
            btnEliminar.Visible = false;
            labelEliminar.Visible = false;
            txtEliminar.Visible = false;
            #endregion
        }

        private void btnEliminarVentana_Click(object sender, EventArgs e)
        {
            #region Visual
            dgvAutor.Visible = true;
            imagenAutor.Visible = true;
            btnBuscarTodos.Visible = false;
            txtID.Visible = false;
            txtNombre.Visible = false;
            txtApellido.Visible = false;
            txtNacionalidad.Visible = false;
            labelID.Visible = false;
            labelNombre.Visible = false;
            labelApellido.Visible = false;
            labelNacionalidad.Visible = false;
            btnActualizar.Visible = false;
            btnCrear.Visible = false;
            btnEliminar.Visible = false;
            btnBuscarID.Visible = false;
            labelBuscarID.Visible = false;
            txtBuscarId.Visible = false;
            btnEliminar.Visible = true;
            labelEliminar.Visible = true;
            txtEliminar.Visible = true;
            #endregion
        }

        private void PantallaAutor_Load(object sender, EventArgs e)
        {
            MtBuscarTodo();
        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarId.Text))
            {
                MessageBox.Show("Debe indicar el id del autor!", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MtBuscarTodo();
                return;
            }

            var infoautor= autorepository.FindById(Convert.ToInt32(txtBuscarId.Text));

            if (infoautor == null)
            {
                MessageBox.Show("No existe el autor, favor intentar de nuevo!!", "autor no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MtBuscarTodo();
                return;
            }

            var vistaautores = autorepository.GetAll();

            dgvAutor.DataSource = vistaautores.Where(x => x.Id == infoautor.Id).Select(x => new { x.Id, x.Nombre, x.Apellido, x.Nacionalidad, x.Estatus, x.FechaRegistro}).ToList();


        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            MtBuscarTodo();
        }
        public void MtBuscarTodo()
        {
            dgvAutor.DataSource = autorepository.GetAll().Select(x => new { x.Id, x.Nombre, x.Apellido, x.Nacionalidad, x.Estatus, x.FechaRegistro, x.FechaActualizacion }).ToList();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtNacionalidad.Text))
            {
                MessageBox.Show("Debe completar todos los datos");
            }
            else
            {
                Autor nuevoautor = new Autor()
                {
                    
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Nacionalidad = txtNacionalidad.Text
                };

                var existeID = autorepository.FindById(nuevoautor.Id);
                if (existeID != null && existeID.Borrado == false)
                {
                    MessageBox.Show("El autor ingresado, ya existe!", "Autor duplicado", MessageBoxButtons.OK);
                    return;
                }

                autorepository.Create(nuevoautor);
                MessageBox.Show("Datos del autor creados correctamente!");

                MtBuscarTodo();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtNacionalidad.Text))
            {
                MessageBox.Show("Debe completar Los datos de nombre, apellido o nacionalidad.");
            }
            else
            {
                if (MessageBox.Show("Seguro que desea actualizar el autor?", "Actualizar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    var autoresAct = autorepository.FindById(Convert.ToInt32(txtID.Text));


                    autoresAct.Nombre = txtNombre.Text;
                    autoresAct.Apellido = txtApellido.Text;
                    autoresAct.Nacionalidad = txtNacionalidad.Text;


                    OperationResult respuesta = autorepository.Update(autoresAct);

                    if (respuesta.Success)
                    {
                        MessageBox.Show("Datos del Autor actualizado correctamente!");
                        MtBuscarTodo();

                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error!");
                    }
                
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //validar si está vacio
            if (string.IsNullOrWhiteSpace(txtEliminar.Text))
            {
                MessageBox.Show("Debe indicar el id del autor válido!");
            }
            
            var infoautor = autorepository.FindById(Convert.ToInt32(txtEliminar.Text));

            //validar que existe el registro de autor
            if (infoautor == null)
            {
                MessageBox.Show("No existe el autor, favor intentar de nuevo!!", "autor no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MtBuscarTodo();
                return;
            }
            else
            {
                if (MessageBox.Show("Seguro que desea eliminar el registro del autor", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var autoresAct = autorepository.FindById(Convert.ToInt32(txtEliminar.Text));

                    OperationResult resultado = autorepository.Delete(autoresAct);

                    if (resultado.Success)
                    {
                        MessageBox.Show("Datos del autor eliminados correctamente!");

                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error!");
                    }
                }
            }
        }

        private void dgvAutor_SelectionChanged(object sender, EventArgs e)
        {
            txtID.Text = dgvAutor.CurrentRow.Cells["Id"].Value.ToString();
            txtNombre.Text = dgvAutor.CurrentRow.Cells["Nombre"].Value.ToString();
            txtApellido.Text = dgvAutor.CurrentRow.Cells["Apellido"].Value.ToString();
            txtNacionalidad.Text = dgvAutor.CurrentRow.Cells["Nacionalidad"].Value.ToString();
        }


    }
}

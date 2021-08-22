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
    public partial class PantallaLibro : Form
    {
        LibroRepository librorepository = new LibroRepository();
        public PantallaLibro()
        {
            InitializeComponent();

            #region Visual
            imagenLibro.Visible = true;
            labelIDLibro.Visible = false;
            labelAutorID.Visible = false;
            labelEditorialID.Visible = false;
            labelNombre.Visible = false;
            txtIDLibro.Visible = false;
            cbAutorID.Visible = false;
            cbEditorialID.Visible = false;
            txtNombre.Visible = false;
            btnCrear.Visible = false;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = false;
            txtBuscarId.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = false;
            labelEliminar.Visible = false;
            txtEliminar.Visible = false;
            btnEliminar.Visible = false;
            dgvLibro.Visible = true;
            #endregion
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void btnCrearVentana_Click_1(object sender, EventArgs e)
        {
            #region Visual
            dgvLibro.Visible = true;
            imagenLibro.Visible = false;
            labelIDLibro.Visible = true;
            labelAutorID.Visible = true;
            labelEditorialID.Visible = true;
            labelNombre.Visible = true;
            txtIDLibro.Visible = true;
            cbAutorID.Visible = true;
            cbEditorialID.Visible = true;
            txtNombre.Visible = true;
            btnCrear.Visible = true;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = false;
            txtBuscarId.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = false;
            labelEliminar.Visible = false;
            txtEliminar.Visible = false;
            btnEliminar.Visible = false;
            txtIDLibro.Clear();
            txtNombre.Clear();
            txtIDLibro.Enabled = false;
            #endregion
        }

        private void btnBTodosVentana_Click_1(object sender, EventArgs e)
        {
            #region Visual
            imagenLibro.Visible = true;
            labelIDLibro.Visible = false;
            labelAutorID.Visible = false;
            labelEditorialID.Visible = false;
            labelNombre.Visible = false;
            txtIDLibro.Visible = false;
            cbAutorID.Visible = false;
            cbEditorialID.Visible = false;
            txtNombre.Visible = false;
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

        private void btnBIDVentana_Click_1(object sender, EventArgs e)
        {
            #region Visual
            imagenLibro.Visible = true;
            labelIDLibro.Visible = false;
            labelAutorID.Visible = false;
            labelEditorialID.Visible = false;
            labelNombre.Visible = false;
            btnCrear.Visible = false;
            txtIDLibro.Visible = false;
            cbAutorID.Visible = false;
            cbEditorialID.Visible = false;
            txtNombre.Visible = false;
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

        private void btnActualizarVentana_Click_1(object sender, EventArgs e)
        {
            #region Visual
            imagenLibro.Visible = false;
            labelIDLibro.Visible = true;
            labelAutorID.Visible = true;
            labelEditorialID.Visible = true;
            labelNombre.Visible = true;
            txtIDLibro.Visible = true;
            cbAutorID.Visible = true;
            cbEditorialID.Visible = true;
            txtNombre.Visible = true;
            btnCrear.Visible = false;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = false;
            txtBuscarId.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = true;
            labelEliminar.Visible = false;
            txtEliminar.Visible = false;
            btnEliminar.Visible = false;
            txtNombre.Clear();
            txtIDLibro.Enabled = false;
            #endregion
        }

        private void btnEliminarVentana_Click_1(object sender, EventArgs e)
        {
            #region Visual
            imagenLibro.Visible = true;
            labelIDLibro.Visible = false;
            labelAutorID.Visible = false;
            labelEditorialID.Visible = false;
            labelNombre.Visible = false;
            txtIDLibro.Visible = false;
            cbAutorID.Visible = false;
            cbEditorialID.Visible = false;
            txtNombre.Visible = false;
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

        private void PantallaLibro_Load(object sender, EventArgs e)
        {
            MtBuscarTodo();
            // TODO: This line of code loads data into the 'bibliotecaDBDataSet1.Editorial' table. You can move, or remove it, as needed.
            this.editorialTableAdapter.Fill(this.bibliotecaDBDataSet1.Editorial);
            // TODO: This line of code loads data into the 'bibliotecaDBDataSet.Autor' table. You can move, or remove it, as needed.
            this.autorTableAdapter.Fill(this.bibliotecaDBDataSet.Autor);
            
        }
        public void MtBuscarTodo()
        {
            dgvLibro.DataSource = librorepository.GetAll().Select(x => new { x.Id, x.Nombre, x.AutorId, x.EditorialId, x.Estatus, x.FechaRegistro, x.FechaActualizacion }).ToList();
        }

        private void cbAutorID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(cbAutorID.Text) || string.IsNullOrWhiteSpace(cbEditorialID.Text))
            {
                MessageBox.Show("Debe completar todos los datos");
            }
            else
            {
                Libro nuevolibro = new Libro()
                {
                    Nombre = txtNombre.Text,
                    AutorId = Convert.ToInt32(cbAutorID.Text),
                    EditorialId = Convert.ToInt32(cbEditorialID.Text)
                };

                var existeID = librorepository.FindById(nuevolibro.Id);
                if (existeID != null && existeID.Borrado == false)
                {
                    MessageBox.Show("El libro ingresado, ya existe!", "libro duplicado", MessageBoxButtons.OK);
                    return;
                }

                librorepository.Create(nuevolibro);
                MessageBox.Show("Datos del libro creados correctamente!");

                MtBuscarTodo();
            }
        }

        private void dgvLibro_SelectionChanged(object sender, EventArgs e)
        {
            txtIDLibro.Text = dgvLibro.CurrentRow.Cells["Id"].Value.ToString();
            txtNombre.Text = dgvLibro.CurrentRow.Cells["Nombre"].Value.ToString();
            cbAutorID.Text = dgvLibro.CurrentRow.Cells["AutorId"].Value.ToString();
            cbEditorialID.Text = dgvLibro.CurrentRow.Cells["EditorialId"].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(cbAutorID.Text) || string.IsNullOrWhiteSpace(cbEditorialID.Text))
            {
                MessageBox.Show("Debe completar los datos de nombre, autor Id, editorial Id!");
            }
            else
            {
                if (MessageBox.Show("Seguro que desea actualizar el libro?", "Actualizar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    var libroAct = librorepository.FindById(Convert.ToInt32(txtIDLibro.Text));


                    libroAct.Nombre = txtNombre.Text;
                    libroAct.AutorId = Convert.ToInt32(cbAutorID.Text);
                    libroAct.EditorialId = Convert.ToInt32(cbEditorialID.Text);


                    OperationResult respuesta = librorepository.Update(libroAct);

                    if (respuesta.Success)
                    {
                        MessageBox.Show("Datos del Libro actualizado correctamente!");
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
                MessageBox.Show("Debe indicar el id del libro válido!");
            }

            var infoautor = librorepository.FindById(Convert.ToInt32(txtEliminar.Text));

            //validar que existe el registro de prestamo
            if (infoautor == null)
            {
                MessageBox.Show("No existe el libro, favor intentar de nuevo!!", "libro no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MtBuscarTodo();
                return;
            }
            else
            {
                if (MessageBox.Show("Seguro que desea eliminar el registro del libro", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var librosAct = librorepository.FindById(Convert.ToInt32(txtEliminar.Text));

                    OperationResult resultado = librorepository.Delete(librosAct);

                    if (resultado.Success)
                    {
                        MessageBox.Show("Datos del libro eliminados correctamente!");

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

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarId.Text))
            {
                MessageBox.Show("Debe indicar el id del libro!", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MtBuscarTodo();
                return;
            }

            var infolibro = librorepository.FindById(Convert.ToInt32(txtBuscarId.Text));

            if (infolibro == null)
            {
                MessageBox.Show("No existe el libro, favor intentar de nuevo!!", "libro no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MtBuscarTodo();
                return;
            }

            var vistalibros = librorepository.GetAll();

            dgvLibro.DataSource = vistalibros.Where(x => x.Id == infolibro.Id).Select(x => new { x.Id, x.Nombre, x.AutorId, x.EditorialId, x.Estatus, x.FechaRegistro, x.FechaActualizacion }).ToList();

        }

        private void dgvLibro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

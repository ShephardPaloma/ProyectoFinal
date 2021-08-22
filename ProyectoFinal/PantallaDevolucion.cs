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
    public partial class PantallaDevolucion : Form
    {
        DevolucionRepository devolucionrepository = new DevolucionRepository();
        public PantallaDevolucion()
        {
            InitializeComponent();

            #region Visual
            imagenDevolucion.Visible = true;
            labelDevolucionID.Visible = false;
            labelPrestamoID.Visible = false;
            btnCrear.Visible = false;
            txtDevolucionID.Visible = false;
            cbPrestamoID.Visible = false;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            txtBuscarId.Visible = false;
            btnActualizar.Visible = false;
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
            this.WindowState = FormWindowState.Normal;
            btnmaximizar.Visible = true;
            btnrestaurar.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearVentana_Click_1(object sender, EventArgs e)
        {
            #region Visual
            imagenDevolucion.Visible = true;
            labelDevolucionID.Visible = true;
            labelPrestamoID.Visible = true;
            btnCrear.Visible = true;
            txtDevolucionID.Visible = true;
            cbPrestamoID.Visible = true;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            txtBuscarId.Visible = false;
            btnActualizar.Visible = false;
            btnEliminar.Visible = false;
            labelEliminar.Visible = false;
            txtEliminar.Visible = false;
            #endregion
        }

        private void btnBTodosVentana_Click_1(object sender, EventArgs e)
        {
            #region Visual
            imagenDevolucion.Visible = true;
            labelDevolucionID.Visible = false;
            labelPrestamoID.Visible = false;
            btnCrear.Visible = false;
            txtDevolucionID.Visible = false;
            cbPrestamoID.Visible = false;
            btnBuscarTodos.Visible = true;
            labelBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            txtBuscarId.Visible = false;
            btnActualizar.Visible = false;
            btnEliminar.Visible = false;
            labelEliminar.Visible = false;
            txtEliminar.Visible = false;
            #endregion
        }

        private void btnBIDVentana_Click_1(object sender, EventArgs e)
        {
            #region Visual
            imagenDevolucion.Visible = true;
            labelDevolucionID.Visible = false;
            labelPrestamoID.Visible = false;
            btnCrear.Visible = false;
            txtDevolucionID.Visible = false;
            cbPrestamoID.Visible = false;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = true;
            btnBuscarID.Visible = true;
            txtBuscarId.Visible = true;
            btnActualizar.Visible = false;
            btnEliminar.Visible = false;
            labelEliminar.Visible = false;
            txtEliminar.Visible = false;
            #endregion
        }

        private void btnActualizarVentana_Click_1(object sender, EventArgs e)
        {
            #region Visual
            imagenDevolucion.Visible = true;
            labelDevolucionID.Visible = true;
            labelPrestamoID.Visible = true;
            btnCrear.Visible = false;
            txtDevolucionID.Visible = true;
            cbPrestamoID.Visible = true;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            txtBuscarId.Visible = false;
            btnActualizar.Visible = true;
            btnEliminar.Visible = false;
            labelEliminar.Visible = false;
            txtEliminar.Visible = false;
            #endregion
        }

        private void btnEliminarVentana_Click_1(object sender, EventArgs e)
        {
            #region Visual
            imagenDevolucion.Visible = true;
            labelDevolucionID.Visible = false;
            labelPrestamoID.Visible = false;
            btnCrear.Visible = false;
            txtDevolucionID.Visible = false;
            cbPrestamoID.Visible = false;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            txtBuscarId.Visible = false;
            btnActualizar.Visible = false;
            btnEliminar.Visible = true;
            labelEliminar.Visible = true;
            txtEliminar.Visible = true;
            #endregion
        }

        private void PantallaDevolucion_Load(object sender, EventArgs e)
        {
            MtBuscarTodo();
            // TODO: This line of code loads data into the 'bibliotecaDBDataSet1.Prestamo' table. You can move, or remove it, as needed.
            this.prestamoTableAdapter.Fill(this.bibliotecaDBDataSet1.Prestamo);
            // TODO: This line of code loads data into the 'bibliotecaDBDataSet1.Libro' table. You can move, or remove it, as needed.
            this.libroTableAdapter.Fill(this.bibliotecaDBDataSet1.Libro);

        }
        public void MtBuscarTodo()
        {
            dgvDevolucion.DataSource = devolucionrepository.GetAll().Select(x => new { x.Id, x.PrestamoId, x.Estatus, x.FechaRegistro, x.FechaActualizacion }).ToList();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbPrestamoID.Text))
            {
                MessageBox.Show("Debe completar el campo de Prestamo Id");
            }
            else
            {
                Devolucion nuevadevolucion = new Devolucion()
                {
                    PrestamoId = Convert.ToInt32(cbPrestamoID.Text)
                };

                var existeID = devolucionrepository.FindById(nuevadevolucion.Id);
                if (existeID != null && existeID.Borrado == false)
                {
                    MessageBox.Show("La devolucion ingresada, ya existe!", "Devolucion duplicada", MessageBoxButtons.OK);
                    return;
                }

                devolucionrepository.Create(nuevadevolucion);
                MessageBox.Show("Datos de la devolucion han sido creados correctamente!");

                MtBuscarTodo();
            }
        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarId.Text))
            {
                MessageBox.Show("Debe indicar el id de la devolucion!", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MtBuscarTodo();
                return;
            }

            var infodevolucion = devolucionrepository.FindById(Convert.ToInt32(txtBuscarId.Text));

            if (infodevolucion == null)
            {
                MessageBox.Show("No existe la devolucion, favor intentar de nuevo!!", "devolucion no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MtBuscarTodo();
                return;
            }

            var vistadevoluciones = devolucionrepository.GetAll();

            dgvDevolucion.DataSource = vistadevoluciones.Where(x => x.Id == infodevolucion.Id).Select(x => new { x.Id, x.PrestamoId, x.Estatus, x.FechaRegistro, x.FechaActualizacion }).ToList();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(cbPrestamoID.Text))
            {
                MessageBox.Show("Debe completar los datos prestamo Id.");
            }
            else
            {
                if (MessageBox.Show("Seguro que desea actualizar la devolucion?", "Actualizar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    var devolucionAct = devolucionrepository.FindById(Convert.ToInt32(txtDevolucionID.Text));

                    devolucionAct.PrestamoId = Convert.ToInt32(cbPrestamoID.Text);

                    OperationResult respuesta = devolucionrepository.Update(devolucionAct);

                    if (respuesta.Success)
                    {
                        MessageBox.Show("Datos de la devolucion actualizado correctamente!");
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
            if (string.IsNullOrWhiteSpace(txtEliminar.Text))
            {
                MessageBox.Show("Debe indicar el id de la devolucion válida!");
            }

            var infoautor = devolucionrepository.FindById(Convert.ToInt32(txtEliminar.Text));

            //validar que existe el registro de la devolucion
            if (infoautor == null)
            {
                MessageBox.Show("No existe la devolucion, favor intentar de nuevo!!", "devolucion no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MtBuscarTodo();
                return;
            }
            else
            {
                if (MessageBox.Show("Seguro que desea eliminar el registro de la devolucion", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var devolucionAct = devolucionrepository.FindById(Convert.ToInt32(txtEliminar.Text));

                    OperationResult resultado = devolucionrepository.Delete(devolucionAct);

                    if (resultado.Success)
                    {
                        MessageBox.Show("Datos de la devolucion eliminados correctamente!");

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

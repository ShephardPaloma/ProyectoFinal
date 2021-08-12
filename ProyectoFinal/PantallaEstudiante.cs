using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class PantallaEstudiante : Form
    {
        public PantallaEstudiante()
        {
            InitializeComponent();

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
            cbBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = false;
            labelEliminar.Visible = false;
            cbEliminar.Visible = false;
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
            cbBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = false;
            labelEliminar.Visible = false;
            cbEliminar.Visible = false;
            btnEliminar.Visible = false;
            #endregion
        }

        private void btnBTodosVentana_Click_1(object sender, EventArgs e)
        {
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
            cbBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = false;
            labelEliminar.Visible = false;
            cbEliminar.Visible = false;
            btnEliminar.Visible = false;
            #endregion
        }

        private void btnBIDVentana_Click_1(object sender, EventArgs e)
        {
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
            cbBuscarID.Visible = true;
            btnBuscarID.Visible = true;
            btnActualizar.Visible = false;
            labelEliminar.Visible = false;
            cbEliminar.Visible = false;
            btnEliminar.Visible = false;
            #endregion
        }

        private void btnActualizarVentana_Click_1(object sender, EventArgs e)
        {
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
            cbBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = true;
            labelEliminar.Visible = false;
            cbEliminar.Visible = false;
            btnEliminar.Visible = false;
            #endregion
        }

        private void btnEliminarVentana_Click_1(object sender, EventArgs e)
        {
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
            cbBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = false;
            labelEliminar.Visible = true;
            cbEliminar.Visible = true;
            btnEliminar.Visible = true;
            #endregion
        }
    }
}

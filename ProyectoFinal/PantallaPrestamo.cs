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
    public partial class PantallaPrestamo : Form
    {
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
            cbBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = false;
            labelEliminar.Visible = false;
            cbEliminar.Visible = false;
            btnEliminar.Visible = false;
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
            cbBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = false;
            labelEliminar.Visible = false;
            cbEliminar.Visible = false;
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
            cbBuscarID.Visible = true;
            btnBuscarID.Visible = true;
            btnActualizar.Visible = false;
            labelEliminar.Visible = false;
            cbEliminar.Visible = false;
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
            cbBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = true;
            labelEliminar.Visible = false;
            cbEliminar.Visible = false;
            btnEliminar.Visible = false;
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

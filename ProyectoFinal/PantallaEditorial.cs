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
    public partial class PantallaEditorial : Form
    {
        public PantallaEditorial()
        {
            InitializeComponent();

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
            cbBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = false;
            cbEliminar.Visible = false;
            labelEliminar.Visible = false;
            btnEliminar.Visible = false;
            #endregion
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Ponerlo a que vuelva a la pantalla principal
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
            cbBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = false;
            cbEliminar.Visible = false;
            labelEliminar.Visible = false;
            btnEliminar.Visible = false;
            #endregion
        }

        private void btnBTodosVentana_Click(object sender, EventArgs e)
        {
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
            cbBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = false;
            cbEliminar.Visible = false;
            labelEliminar.Visible = false;
            btnEliminar.Visible = false;
            #endregion
        }

        private void btnBIDVentana_Click(object sender, EventArgs e)
        {
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
            cbBuscarID.Visible = true;
            btnBuscarID.Visible = true;
            btnActualizar.Visible = false;
            cbEliminar.Visible = false;
            labelEliminar.Visible = false;
            btnEliminar.Visible = false;
            #endregion
        }

        private void btnActualizarVentana_Click(object sender, EventArgs e)
        {
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
            cbBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = true;
            cbEliminar.Visible = false;
            labelEliminar.Visible = false;
            btnEliminar.Visible = false;
            #endregion
        }

        private void btnEliminarVentana_Click(object sender, EventArgs e)
        {
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
            cbBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = false;
            cbEliminar.Visible = true;
            labelEliminar.Visible = true;
            btnEliminar.Visible = true;
            #endregion
        }
    }
}

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
    public partial class PantallaLibro : Form
    {
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
            cbBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            btnActualizar.Visible = false;
            labelEliminar.Visible = false;
            cbEliminar.Visible = false;
            btnEliminar.Visible = false;
            #endregion
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Ponerlo a que vuelva a la pantalla principal
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
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            btnmaximizar.Visible = true;
            
        }

        private void btnCrearVentana_Click(object sender, EventArgs e)
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

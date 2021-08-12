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
        }

        private void btnCrearVentana_Click(object sender, EventArgs e)
        {
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
        }

        private void btnBTodosVentana_Click(object sender, EventArgs e)
        {
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
        }

        private void btnBIDVentana_Click(object sender, EventArgs e)
        {
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
        }

        private void btnActualizarVentana_Click(object sender, EventArgs e)
        {
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
        }

        private void btnEliminarVentana_Click(object sender, EventArgs e)
        {
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
            btnmaximizar.Visible = false;
            btnrestaurar.Visible = true;
        }
    }
}

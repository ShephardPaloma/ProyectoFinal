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
    public partial class PantallaAutor : Form
    {
        public PantallaAutor()
        {
            InitializeComponent();
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
            cbBuscarID.Visible = false;
            btnEliminar.Visible = false;
            labelEliminar.Visible = false;
            cbEliminar.Visible = false;
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

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();//Ponerlo a que vuelva a la pantalla principal
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
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
            cbBuscarID.Visible = false;
            btnEliminar.Visible = false;
            labelEliminar.Visible = false;
            cbEliminar.Visible = false;
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
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
            cbBuscarID.Visible = false;
            btnEliminar.Visible = false;
            labelEliminar.Visible = false;
            cbEliminar.Visible = false;
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
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
            cbBuscarID.Visible = false;
            btnEliminar.Visible = false;
            labelEliminar.Visible = false;
            cbEliminar.Visible = false;
        }

        private void btnBIDVentana_Click(object sender, EventArgs e)
        {
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
            cbBuscarID.Visible = true;
            btnEliminar.Visible = false;
            labelEliminar.Visible = false;
            cbEliminar.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
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
            cbBuscarID.Visible = true;
            btnEliminar.Visible = false;
            labelEliminar.Visible = false;
            cbEliminar.Visible = false;
        }

        private void btnEliminarVentana_Click(object sender, EventArgs e)
        {
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
            cbBuscarID.Visible = false;
            btnEliminar.Visible = true;
            labelEliminar.Visible = true;
            cbEliminar.Visible = true;

        }
    }
}

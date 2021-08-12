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
    public partial class PantallaDevolucion : Form
    {
        public PantallaDevolucion()
        {
            InitializeComponent();
            imagenDevolucion.Visible = true;
            labelDevolucionID.Visible = false;
            labelPrestamoID.Visible = false;
            btnCrear.Visible = false;
            txtDevolucionID.Visible = false;
            cbPrestamoID.Visible = false;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            cbBuscarID.Visible = false;
            btnActualizar.Visible = false;
            btnEliminar.Visible = false;
            labelEliminar.Visible = false;
            cbEliminar.Visible = false;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Ponerlo a que vuelva a la pantalla principal
        }

        private void btnBTodosVentana_Click(object sender, EventArgs e)
        {
            imagenDevolucion.Visible = true;
            labelDevolucionID.Visible = false;
            labelPrestamoID.Visible = false;
            btnCrear.Visible = false;
            txtDevolucionID.Visible = false;
            cbPrestamoID.Visible = false;
            btnBuscarTodos.Visible = true;
            labelBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            cbBuscarID.Visible = false;
            btnActualizar.Visible = false;
            btnEliminar.Visible = false;
            labelEliminar.Visible = false;
            cbEliminar.Visible = false;
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
            Application.Exit(); //Ponerlo a que vuelva a la pantalla principal
        }

        private void btnCrearVentana_Click(object sender, EventArgs e)
        {
            imagenDevolucion.Visible = true;
            labelDevolucionID.Visible = true;
            labelPrestamoID.Visible = true;
            btnCrear.Visible = true;
            txtDevolucionID.Visible = true;
            cbPrestamoID.Visible = true;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            cbBuscarID.Visible = false;
            btnActualizar.Visible = false;
            btnEliminar.Visible = false;
            labelEliminar.Visible = false;
            cbEliminar.Visible = false;
        }

        private void btnBIDVentana_Click(object sender, EventArgs e)
        {
            imagenDevolucion.Visible = true;
            labelDevolucionID.Visible = false;
            labelPrestamoID.Visible = false;
            btnCrear.Visible = false;
            txtDevolucionID.Visible = false;
            cbPrestamoID.Visible = false;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = true;
            btnBuscarID.Visible = true;
            cbBuscarID.Visible = true;
            btnActualizar.Visible = false;
            btnEliminar.Visible = false;
            labelEliminar.Visible = false;
            cbEliminar.Visible = false;
        }

        private void btnActualizarVentana_Click(object sender, EventArgs e)
        {
            imagenDevolucion.Visible = true;
            labelDevolucionID.Visible = true;
            labelPrestamoID.Visible = true;
            btnCrear.Visible = false;
            txtDevolucionID.Visible = true;
            cbPrestamoID.Visible = true;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            cbBuscarID.Visible = false;
            btnActualizar.Visible = true;
            btnEliminar.Visible = false;
            labelEliminar.Visible = false;
            cbEliminar.Visible = false;
        }

        private void btnEliminarVentana_Click(object sender, EventArgs e)
        {
            imagenDevolucion.Visible = true;
            labelDevolucionID.Visible = false;
            labelPrestamoID.Visible = false;
            btnCrear.Visible = false;
            txtDevolucionID.Visible = false;
            cbPrestamoID.Visible = false;
            btnBuscarTodos.Visible = false;
            labelBuscarID.Visible = false;
            btnBuscarID.Visible = false;
            cbBuscarID.Visible = false;
            btnActualizar.Visible = false;
            btnEliminar.Visible = true;
            labelEliminar.Visible = true;
            cbEliminar.Visible = true;
        }
    }
}

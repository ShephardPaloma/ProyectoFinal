using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ProyectoFinal.DataModel.Context;
using ProyectoFinal.DataModel.Entities;
using ProyectoFinal.DataModel.Repositories;
using System.Drawing.Printing;

namespace ProyectoFinal
{
    public partial class PantallaSolicitud2 : Form
    {
        SolicitudRepository solicitudRepository = new SolicitudRepository();
        public PantallaSolicitud2()
        {
            InitializeComponent();

            #region Visual
            dgvSolicitud.Visible = false;
            imagenSolicitud.Visible = true;
            labelBuscarID.Visible = false;
            labelEliminar.Visible = false;
            txtBuscarId.Visible = false;
            txtEliminar.Visible = false;
            btnBuscarID.Visible = false;
            btnEliminar.Visible = false;
            btnBuscarTodos.Visible = false;
            btnImprimir.Visible = false;
            #endregion
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir de esta pantalla?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir de esta pantalla?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
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
      
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public void MtBuscarTodo()
        {
            dgvSolicitud.DataSource = solicitudRepository.GetAll().Select(x => new { x.Id, x.Nombre, x.Apellido, x.Libro, x.Editorial, x.Autor, x.Estatus, x.FechaRegistro, x.FechaActualizacion }).ToList();
        }

        private void btnBTodosVentana_Click(object sender, EventArgs e)
        {
            
            #region Visual
            dgvSolicitud.Visible = true;
            imagenSolicitud.Visible = true;
            labelBuscarID.Visible = false;
            labelEliminar.Visible = false;
            txtBuscarId.Visible = false;
            txtEliminar.Visible = false;
            btnBuscarID.Visible = false;
            btnEliminar.Visible = false;
            btnBuscarTodos.Visible = true;
            btnImprimir.Visible = true;
            #endregion
        }

        private void btnBIDVentana_Click(object sender, EventArgs e)
        {
            MtBuscarTodo();
            #region Visual
            dgvSolicitud.Visible = true;
            imagenSolicitud.Visible = true;
            labelBuscarID.Visible = true;
            labelEliminar.Visible = false;
            txtBuscarId.Visible = true;
            txtEliminar.Visible = false;
            btnBuscarID.Visible = true;
            btnEliminar.Visible = false;
            btnBuscarTodos.Visible = false;
            btnImprimir.Visible = false;
            #endregion
        }

        private void btnEliminarVentana_Click(object sender, EventArgs e)
        {
            MtBuscarTodo();
            #region Visual
            dgvSolicitud.Visible = true;
            imagenSolicitud.Visible = true;
            labelBuscarID.Visible = false;
            labelEliminar.Visible = true;
            txtBuscarId.Visible = false;
            txtEliminar.Visible = true;
            btnBuscarID.Visible = false;
            btnEliminar.Visible = true;
            btnBuscarTodos.Visible = false;
            btnImprimir.Visible = false;
            #endregion
        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            MtBuscarTodo();
        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            MtBuscarTodo();
            if (string.IsNullOrWhiteSpace(txtBuscarId.Text))
            {
                MessageBox.Show("Debe indicar el id de la solicitud!", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MtBuscarTodo();
                return;
            }

            var infosolicitud = solicitudRepository.FindById(Convert.ToInt32(txtBuscarId.Text));

            if (infosolicitud == null)
            {
                MessageBox.Show("No existe la solicitud, favor intentar de nuevo!!", "Solicitud no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MtBuscarTodo();
                return;
            }

            var vistasolicitud = solicitudRepository.GetAll();

            dgvSolicitud.DataSource = vistasolicitud.Where(x => x.Id == infosolicitud.Id).Select(x => new { x.Id, x.Nombre, x.Apellido, x.Libro, x.Editorial, x.Autor, x.Estatus, x.FechaRegistro, x.FechaActualizacion }).ToList();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MtBuscarTodo();
            if (string.IsNullOrWhiteSpace(txtEliminar.Text))
            {
                MessageBox.Show("Debe indicar id de solicitud válido!");
            }

            var infosolicitud = solicitudRepository.FindById(Convert.ToInt32(txtEliminar.Text));


            if (infosolicitud == null)
            {
                MessageBox.Show("No existe la solicitud, favor intentar de nuevo!!", "libro no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MtBuscarTodo();
                return;
            }
            else
            {
                if (MessageBox.Show("Seguro que desea eliminar el registro de la solicitud?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var solicitudAct = solicitudRepository.FindById(Convert.ToInt32(txtEliminar.Text));

                    OperationResult resultado = solicitudRepository.Delete(solicitudAct);

                    if (resultado.Success)
                    {
                        MessageBox.Show("Datos de la solicitud eliminados correctamente!");

                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error!");
                    }
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MtBuscarTodo();

            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
            ((Form)ppd).WindowState = FormWindowState.Maximized;

            doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
            {
                const int DGV_ALTO = 35;
                int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;

                foreach (DataGridViewColumn col in dgvSolicitud.Columns)
                {
                    ep.Graphics.DrawString(col.HeaderText, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
                    left += col.Width;

                    if (col.Index < dgvSolicitud.ColumnCount - 1)
                        ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 75 + (dgvSolicitud.RowCount - 1) * DGV_ALTO);
                }
                left = ep.MarginBounds.Left;
                ep.Graphics.FillRectangle(Brushes.Black, left, top + 40, ep.MarginBounds.Right - left, 3);
                top += 43;

                foreach (DataGridViewRow row in dgvSolicitud.Rows)
                {
                    if (row.Index == dgvSolicitud.RowCount - 1) break;
                    left = ep.MarginBounds.Left;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Segoe UI", 13), Brushes.Black, left, top + 4);
                        left += cell.OwningColumn.Width;
                    }
                    top += DGV_ALTO;
                    ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left, top, ep.MarginBounds.Right, top);
                }
            };
            ppd.ShowDialog();
        }
    }
}

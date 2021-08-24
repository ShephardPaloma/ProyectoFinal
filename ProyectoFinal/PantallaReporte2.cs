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


namespace ProyectoFinal
{
    public partial class PantallaReporte2 : Form
    {
      

        public PantallaReporte2()
        {
            InitializeComponent();

           
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

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnmaximizar.Visible = true;
            btnrestaurar.Visible = false;
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnrestaurar.Visible = true;
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

        private void PantallaReporte2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDBDataSet3.sp_ConsultaReporte2' table. You can move, or remove it, as needed.
            this.sp_ConsultaReporte2TableAdapter.Fill(this.bibliotecaDBDataSet3.sp_ConsultaReporte2);
            // TODO: This line of code loads data into the 'bibliotecaDBDataSet2.Prestamo' table. You can move, or remove it, as needed.
            this.prestamoTableAdapter.Fill(this.bibliotecaDBDataSet2.Prestamo);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_ConsultaReporte2TableAdapter.FillBy(this.bibliotecaDBDataSet3.sp_ConsultaReporte2);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

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

namespace PROYECTO_BINAES
{
    public partial class frmAgregarEvento : Form
    {
        public frmAgregarEvento()
        {
            InitializeComponent();
        }
        //MOVER PESTAÑA
        //Movilizar la ventana
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMenssage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frmAgregarEvento_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMenssage(this.Handle, 0x112, 0xf012, 0);
        }
       

        //BOTON CERRAR
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }

        private void btnMostrarEventos_Click(object sender, EventArgs e)
        {
            dgvTodoslosEventos.DataSource = null;
            dgvTodoslosEventos.DataSource = EventoDAO.ObtenerEventos();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdEvento.Text);
            string titulo = txtTituloEvento.Text;
            string objetivo = txtObjetivoEvento.Text;
            int cantidad = Convert.ToInt32(txtCantidadEvento.Text);
            int id_horarioevento = Convert.ToInt32(txtIdH_E.Text);
            DateTime fechainicio = Convert.ToDateTime(txtFhApertura.Text);
            DateTime fechacierre = Convert.ToDateTime(txtFhCierre.Text); 

            if(id > 0 && titulo.Length > 0 && objetivo.Length > 0 && cantidad > 0 && id_horarioevento >0)
            {
                if(EventoDAO.AgregarEvento(id, titulo, objetivo, cantidad, id_horarioevento, fechainicio, fechacierre))
                {
                    MessageBox.Show("Evento agregado", "BINAES - Biblioteca Nacional de El Salvador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdEvento.Clear();
                    txtTituloEvento.Clear();
                    txtObjetivoEvento.Clear();
                    txtCantidadEvento.Clear();
                    txtIdH_E.Clear();
                    txtFhApertura.Clear();
                    txtFhCierre.Clear(); 
                } else
                {
                    MessageBox.Show("Error!", "BINAES - Biblioteca Nacional de El Salvador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
            else
            {
                MessageBox.Show("Los campos están vacíos", "BINAES - Biblioteca Nacional de El Salvador",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

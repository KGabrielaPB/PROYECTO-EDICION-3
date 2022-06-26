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
    public partial class frmCatálogo : Form
    {
        Usuario usuario;
        public frmCatálogo(Usuario usu)
        {
            InitializeComponent();
            this.usuario = usu;
        }
        //Movilizar la pantalla
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMenssage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMenssage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        } 

        //MAXIMIZAR
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        //RESTAURAR
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        //MINIMIZAR
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //ÁREAS
        private void mspAreas_Click(object sender, EventArgs e)
        {
            frmAreas frm = new frmAreas(usuario);
            frm.Show(); 
        }

        //SERVICIOS
        private void mspPrestarEjemplares_Click(object sender, EventArgs e)
        {
            frmPrestaryReservar frm = new frmPrestaryReservar(usuario);
            frm.Show();
        }

        private void mspReservarEjemplares_Click(object sender, EventArgs e)
        {
            //frmReservar_Ejemplares frm = new frmReservar_Ejemplares(usuario);
            //frm.Show();
        }

        //EVENTOS
        private void mspEventos2_Click(object sender, EventArgs e)
        {
            frmEventos frm = new frmEventos(usuario);
            frm.Show();
        }

        //REDES SOCIALES
        private void mspFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://es-la.facebook.com/");

        }

        private void mspTwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mobile.twitter.com/binaes");

        }

        private void mspInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");

        }

        //CERRAR FORMULARIO
        private void aTRASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}

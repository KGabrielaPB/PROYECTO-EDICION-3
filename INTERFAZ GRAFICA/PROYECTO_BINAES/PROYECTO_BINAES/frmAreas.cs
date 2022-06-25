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
    public partial class frmAreas : Form
    {
        public frmAreas()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMenssage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //MOVER PESTAÑA

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMenssage(this.Handle, 0x112, 0xf012, 0);
        }

        //CERRAR
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //MAXIMIZAR
        private void btnMaximizar2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar2.Visible = false;
            btnRestaurar2.Visible = true;
        }

        //RESTAURAR
        private void btnRestaurar2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar2.Visible = false;
            btnMaximizar2.Visible = true;
        }

        //MINIMIZAR
        private void btnMinimizar2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //INICIO DE SESIÓN
        private void mspIniciodeSesión_Click(object sender, EventArgs e)
        {
            //this.Hide();  //(para quitar el primer frm y que solo se vea el segundo)
            frmInicioDeSesion frm = new frmInicioDeSesion();
            frm.Show();
        }

        //NOSOTROS
        private void mspNosotros2_Click(object sender, EventArgs e)
        {
            
        }

        //SERVICIOS
        private void mspPrestarEjemplares_Click(object sender, EventArgs e)
        {
            frmPrestar_Ejemplares frm = new frmPrestar_Ejemplares();
            frm.Show();
        }

        private void mspReservarEjemplares_Click(object sender, EventArgs e)
        {
            frmReservar_Ejemplares frm = new frmReservar_Ejemplares();
            frm.Show();
        }

        //EVENTOS
        private void mspEventos2_Click(object sender, EventArgs e)
        {
            frmEventos frm = new frmEventos();
            frm.Show();
        }

        //CATALOGO
        private void mspCatálogo_Click(object sender, EventArgs e)
        {
            frmCatálogo frm = new frmCatálogo();
            frm.Show();
        }

        //REDES SOCIALES
        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://es-la.facebook.com/");

        }

        private void twitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mobile.twitter.com/binaes");

        }

        private void instagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");

        }


        //SALIR DEL FORMULARIO
        private void aTRASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }

        
    }
}

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
    public partial class frmEventos : Form
    {
        public frmEventos()
        {
            InitializeComponent();
        }

        //Movilizar la ventana
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMenssage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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



        //INICIO DE SESIÓN
        private void mspIniciodeSesión_Click(object sender, EventArgs e)
        {
            frmInicioDeSesion frm = new frmInicioDeSesion();
            frm.Show(); 
        }
        //NOSOTROS
        private void mspNosotros3_Click(object sender, EventArgs e)
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

        //AREAS
        private void mspÁreas_Click(object sender, EventArgs e)
        {
            frmAreas frm = new frmAreas();
            frm.Show(); 
        }

        //CATALOGO
        private void mspCatálogo_Click(object sender, EventArgs e)
        {
            frmCatálogo frm = new frmCatálogo();
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

        //SALIR DEL FORMULARIO
        private void aTRASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }

        private void frmEventos_Load(object sender, EventArgs e)
        {
            btnDesinscribirseFeriadelLibro.Visible = false;
            btnDesinscribirseCONIA.Visible = false;
            btnDesinscribirseCharlando.Visible = false;
            btnDesinscribirseJuegosVR.Visible = false;
            btnDesinscribirseCine.Visible = false;
            btnDesinscribirseFeriaTeatral.Visible = false; 
            btnDesinscribirseJyD.Visible = false; 
        }

        private void btnInscribirseFeriadelLibro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Te has inscrito éxitosamente", "BINAES - Biblioteca Nacional de El Salvador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDesinscribirseFeriadelLibro.Visible = true;
        }

        private void btnDesinscribirseFeriadelLibro_Click(object sender, EventArgs e)
        {
            btnDesinscribirseFeriadelLibro.Visible = false;
            btnInscribirseFeriadelLibro.Visible = true;
        }

        private void btnInscribirseCONIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Te has inscrito éxitosamente", "BINAES - Biblioteca Nacional de El Salvador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDesinscribirseCONIA.Visible = true;
        }

        private void btnDesinscribirseCONIA_Click(object sender, EventArgs e)
        {
            btnDesinscribirseCONIA.Visible = false;
            btnInscribirseCONIA.Visible = true; 
        }
        

        private void btnInscribirseCharlando_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Te has inscrito éxitosamente", "BINAES - Biblioteca Nacional de El Salvador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDesinscribirseCharlando.Visible = true;
        }

        private void btnDesinscribirseCharlando_Click(object sender, EventArgs e)
        {
            btnDesinscribirseCharlando.Visible = false;
            btnInscribirseCharlando.Visible = true;
        }

        private void btnInscribirseCine_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Te has inscrito éxitosamente", "BINAES - Biblioteca Nacional de El Salvador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDesinscribirseCine.Visible = true;
        }

        private void btnDesinscribirseCine_Click(object sender, EventArgs e)
        {
            btnDesinscribirseCine.Visible = false;
            btnInscribirseCine.Visible = true; 
        }

        private void btnInscribirseJyD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Te has inscrito éxitosamente", "BINAES - Biblioteca Nacional de El Salvador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDesinscribirseJyD.Visible = true;
        }

        private void btnDesinscribirseJyD_Click(object sender, EventArgs e)
        {
            btnDesinscribirseJyD.Visible = false;
            btnInscribirseJyD.Visible = true;
        }

        private void btnInscribirseJuegosVR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Te has inscrito éxitosamente", "BINAES - Biblioteca Nacional de El Salvador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDesinscribirseJuegosVR.Visible = true;
        }

        private void btnDesinscribirseJuegosVR_Click(object sender, EventArgs e)
        {
            btnDesinscribirseJuegosVR.Visible = false;
            btnInscribirseJuegosVR.Visible = true;
        }

        private void btnInscribirseFeriaTeatral_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Te has inscrito éxitosamente", "BINAES - Biblioteca Nacional de El Salvador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDesinscribirseFeriaTeatral.Visible = true;
        }

        private void btnDesinscribirseFeriaTeatral_Click(object sender, EventArgs e)
        {
            btnDesinscribirseFeriaTeatral.Visible = false;
            btnInscribirseFeriaTeatral.Visible = true;
        }
    }
}

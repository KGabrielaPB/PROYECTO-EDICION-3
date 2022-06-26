using PROYECTO_BINAES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_BINAES
{
    public partial class frmPrestaryReservar : Form
    {
        Usuario usuario;
        public frmPrestaryReservar(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario; 
        }
        private void frmPrestar_Ejemplares_Load_1(object sender, EventArgs e)
        {
            Refresh();
            this.button2.Enabled = false;
            this.button3.Enabled = false;
        }

        private void Refresh()
        {
            using (EFDB.PROYECTOv17Entities db = new EFDB.PROYECTOv17Entities())
            {

                var lst = (from d in db.EJEMPLAR
                           select new Ejemplar
                           {
                               CodigoEjemplar = d.codigo,
                               Nombre = d.nombre,
                               Autor = d.autor
                           }).AsQueryable();

                if (!txt1.Text.Trim().Equals(""))
                {
                    int codigo = 0;
                     int.TryParse(txt1.Text.Trim(), out codigo);
                    lst = lst.Where(d => d.CodigoEjemplar == codigo || d.Nombre.Contains(txt1.Text.Trim()));
                }
                dgv1.DataSource = lst.ToList();
            }

        }

       

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void dgv1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.button2.Enabled = true;
            this.button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgv1.CurrentRow;
            string codigo = dr.Cells[0].Value.ToString();
            if(EjemplaresDAO.ReservarLibro(int.Parse(codigo), 2010))
            {
                MessageBox.Show($"La reserva se ha realizado de manera correcta", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgv1.CurrentRow;
            string codigo = dr.Cells[0].Value.ToString();
            if(EjemplaresDAO.PrestarLibro(int.Parse(codigo), 2010)){
                MessageBox.Show($"La reserva se ha realizado de manera correcta", "",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblMain_Click(object sender, EventArgs e)
        {

        }
    }

}

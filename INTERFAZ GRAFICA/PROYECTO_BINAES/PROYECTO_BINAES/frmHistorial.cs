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
    public partial class frmHistorial : Form
    {
        Usuario usuario;
        string type = "1";
        public frmHistorial(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
        private void frmHistorial_Load(object sender, EventArgs e)
        {
            this.Refresh();
            this.comboBox1.DataSource = new List<object>() {
                new { text = "RESERVA", value = 1 },
                new { text = "PRESTAMO", value = 2 }
            };
            this.comboBox1.DisplayMember = "text";
            this.comboBox1.ValueMember = "value";
            this.comboBox1.SelectedIndex = 0;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Refresh()
        {
            using (EFDB.PROYECTOv17Entities db = new EFDB.PROYECTOv17Entities())
            {
                
                if (type == "1")
                {


                    var lst = (from r in db.RESERVA
                           select new Reserva
                           {
                               CodigoEjemplar = r.codigo_ejemplar,
                               Nombre = r.EJEMPLAR.nombre,
                               Autor = r.EJEMPLAR.autor,
                               FechaDevolucion = r.f_h_devolucion,
                               FechaReserva = r.f_h_reserva,
                               Carnet = r.carnet_usuario,
                           }).AsQueryable();
                    if (!txt1.Text.Trim().Equals(""))
                    {
                        int codigo = 0;
                        int.TryParse(txt1.Text.Trim(), out codigo);
                        lst = lst.Where(d => d.CodigoEjemplar == codigo || d.Nombre.Contains(txt1.Text.Trim()));
                    }
                    if (usuario.rol == "Cliente")
                    {
                        lst = lst.Where(d => d.Carnet == usuario.carnet);
                    }
                    dgv1.DataSource = lst.ToList();
                }
                else if (type == "2")
                {
                    var lst = (from r in db.PRESTAMO
                           select new Prestamo
                           {
                               CodigoEjemplar = r.codigo_ejemplar,
                               Nombre = r.EJEMPLAR.nombre,
                               Autor = r.EJEMPLAR.autor,
                               FechaDevolucion = r.f_h_devolucion,
                               FechaPrestamo = r.f_h_prestamo,
                               Carnet = r.carnet_usuario,
                           }).AsQueryable();
                    if (!txt1.Text.Trim().Equals(""))
                    {
                        int codigo = 0;
                        int.TryParse(txt1.Text.Trim(), out codigo);
                        lst = lst.Where(d => d.CodigoEjemplar == codigo || d.Nombre.Contains(txt1.Text.Trim()));
                    }
                    if (usuario.rol == "Cliente")
                    {
                        lst = lst.Where(d => d.Carnet == usuario.carnet);
                    }
                    dgv1.DataSource = lst.ToList();

                }
                
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lblMain_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.type = this.comboBox1.SelectedValue.ToString();
        }
    }
}

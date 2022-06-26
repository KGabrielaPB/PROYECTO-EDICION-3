using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registr0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            using (Model.PROYECTOv17Entities db = new Model.PROYECTOv17Entities())
            {
                var lst = (from d in db.PRESTAMO
                           select new Model.ViewModel.Prestamo
                           {
                               carnet_usuario = d.carnet_usuario,
                               codigo_ejemplar = d.codigo_ejemplar,
                               f_h_prestamo = d.f_h_prestamo,
                           }).AsQueryable();

                if (!txt1.Text.Trim().Equals(""))
                {
                    int codigo = int.Parse(txt1.Text.Trim());
                    lst = lst.Where(d => d.codigo_ejemplar == codigo);
                }

                dgv1.DataSource = lst.ToList();
            }
                using (Model.PROYECTOv17Entities db = new Model.PROYECTOv17Entities())
                {
                    var lst = (from d in db.RESERVA
                               select new Model.ViewModel.Reserva
                               {
                                   carnet_usuario = d.carnet_usuario,
                                   codigo_ejemplar = d.codigo_ejemplar,
                                   f_h_reserva = d.f_h_reserva,
                               }).AsQueryable();

                    if (!txt2.Text.Trim().Equals(""))
                    {
                        int codigo = int.Parse(txt2.Text.Trim());
                        lst = lst.Where(d => d.codigo_ejemplar == codigo);
                    }

                    dgv2.DataSource = lst.ToList();
                }
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}

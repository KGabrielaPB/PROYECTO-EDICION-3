using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_BINAES.TablaEvento
{
    internal class Evento
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Objetivo { get; set; }
        public int Cantidad { get; set; }
        //public int Id_HorarioEvento { get; set; }

        public int IdHorarioEvento { get; set; }

        public DateTime F_h_Apertura { get; set; }

        public DateTime F_h_Cierre { get; set; }
 
        public Evento()
        {

        }

        public Evento(int id, string titulo, string objetivo, int cantidad, int id_HorarioEvento,DateTime f_h_apertura, DateTime f_h_cierre)
        {
            //TABLA EVENTO
            this.Id = id;
            this.Titulo = titulo;
            this.Objetivo = objetivo;
            this.Cantidad = cantidad;
           // this.Id_HorarioEvento = id_HorarioEvento;

            //TABLA HORARIOEVENTO
            this.IdHorarioEvento = id_HorarioEvento; 
            this.F_h_Apertura = f_h_apertura;
            this.F_h_Cierre = f_h_cierre;
        }
    }
}

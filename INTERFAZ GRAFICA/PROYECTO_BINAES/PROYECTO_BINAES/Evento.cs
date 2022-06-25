using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_BINAES
{
    internal class Evento
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Objetivo { get; set; }
        public int Cantidad { get; set; } 
        public int Id_HorarioEvento { get; set; }

        public Evento()
        {
           
        }

        public Evento(int id, string titulo, string objetivo, int cantidad, int id_HorarioEvento)
        {
            this.Id = id;
            this.Titulo = titulo; 
            this.Objetivo = objetivo;
            this.Cantidad = cantidad;
            this.Id_HorarioEvento = id_HorarioEvento;
        }

            
    }
}

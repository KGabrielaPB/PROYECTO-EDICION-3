using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_BINAES.Models
{
    public class Prestamo
    {
        [System.ComponentModel.DisplayName("Codigo")]
        public int CodigoEjemplar { get; set; }
        [System.ComponentModel.DisplayName("Carnet")]
        public int Carnet { get; set; }
        [System.ComponentModel.DisplayName("Nombre")]
        public string Nombre { get; set; }
        [System.ComponentModel.DisplayName("Autor")]
        public string Autor { get; set; }
        [System.ComponentModel.DisplayName("Fecha reserva")]
        public DateTime FechaPrestamo { get; set; }

        [System.ComponentModel.DisplayName("Fecha devolucion")]
        public DateTime FechaDevolucion { get; set; }

    }
}

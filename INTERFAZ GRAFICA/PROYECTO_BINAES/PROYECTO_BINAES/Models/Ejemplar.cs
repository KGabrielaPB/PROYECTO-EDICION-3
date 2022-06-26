using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_BINAES.Models
{
    public class Ejemplar
    {
        [System.ComponentModel.DisplayName("Codigo")]
        public int CodigoEjemplar { get; set; }
        [System.ComponentModel.DisplayName("Nombre")]
        public string Nombre { get; set; }
        [System.ComponentModel.DisplayName("Autor")]
        public string Autor { get; set; }
        
    }
}

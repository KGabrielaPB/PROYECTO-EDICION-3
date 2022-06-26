using System;

namespace PROYECTO_BINAES
{
    internal class Evento
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Objetivo { get; set; }
        public int Cantidad { get; set; }
        public int IdHorarioEvento { get; set; }
        public DateTime F_h_Apertura { get; set; }
        public DateTime F_h_Cierre { get; set; }

    }
}
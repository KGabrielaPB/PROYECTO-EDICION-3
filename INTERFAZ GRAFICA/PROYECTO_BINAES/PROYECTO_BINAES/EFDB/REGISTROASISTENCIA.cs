//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PROYECTO_BINAES.EFDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class REGISTROASISTENCIA
    {
        public int carnet_usuario { get; set; }
        public int id_area { get; set; }
        public int id_evento { get; set; }
        public System.DateTime f_h_entrada { get; set; }
        public System.DateTime f_h_salida { get; set; }
    
        public virtual AREA AREA { get; set; }
        public virtual EVENTO EVENTO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}

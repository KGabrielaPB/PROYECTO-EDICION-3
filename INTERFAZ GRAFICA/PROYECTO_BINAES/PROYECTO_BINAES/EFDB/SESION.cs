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
    
    public partial class SESION
    {
        public int id { get; set; }
        public System.DateTime f_h_inicio { get; set; }
        public System.DateTime f_h_cierre { get; set; }
        public int carnet_usuario { get; set; }
    
        public virtual USUARIO USUARIO { get; set; }
    }
}

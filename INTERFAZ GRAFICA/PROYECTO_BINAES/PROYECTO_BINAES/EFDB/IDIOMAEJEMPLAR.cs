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
    
    public partial class IDIOMAEJEMPLAR
    {
        public int id { get; set; }
        public string Espanol { get; set; }
        public string Ingles { get; set; }
        public string Aleman { get; set; }
        public string Frances { get; set; }
        public string Italiano { get; set; }
        public string Japones { get; set; }
        public string Portugues { get; set; }
        public string Arabe { get; set; }
        public int codigo_ejemplar { get; set; }
    
        public virtual EJEMPLAR EJEMPLAR { get; set; }
    }
}
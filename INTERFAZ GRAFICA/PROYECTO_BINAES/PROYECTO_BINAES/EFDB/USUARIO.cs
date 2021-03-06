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
    
    public partial class USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIO()
        {
            this.PRESTAMO = new HashSet<PRESTAMO>();
            this.REGISTROASISTENCIA = new HashSet<REGISTROASISTENCIA>();
            this.RESERVA = new HashSet<RESERVA>();
            this.SESION = new HashSet<SESION>();
            this.TELEFONOUSUARIO = new HashSet<TELEFONOUSUARIO>();
        }
    
        public int carnet { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string direccion { get; set; }
        public string nombre { get; set; }
        public int codigo_ejemplar { get; set; }
        public int id_ocupacionusuario { get; set; }
        public int id_institucionusuario { get; set; }
        public int id_rol { get; set; }
    
        public virtual EJEMPLAR EJEMPLAR { get; set; }
        public virtual INSTITUCIONUSUARIO INSTITUCIONUSUARIO { get; set; }
        public virtual OCUPACIONUSUARIO OCUPACIONUSUARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRESTAMO> PRESTAMO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTROASISTENCIA> REGISTROASISTENCIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESERVA> RESERVA { get; set; }
        public virtual ROL ROL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SESION> SESION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TELEFONOUSUARIO> TELEFONOUSUARIO { get; set; }
    }
}

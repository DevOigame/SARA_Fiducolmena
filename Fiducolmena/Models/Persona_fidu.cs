//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fiducolmena.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Persona_fidu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Persona_fidu()
        {
            this.Autorizacion = new HashSet<Autorizacion>();
            this.Formulario = new HashSet<Formulario>();
            this.Informacion_proyecto = new HashSet<Informacion_proyecto>();
        }
    
        public string identificacion { get; set; }
        public string tipo_identificacion { get; set; }
        public Nullable<System.DateTime> fecha_expedicion { get; set; }
        public string primer_nombre { get; set; }
        public string segundo_nombre { get; set; }
        public string primer_apellido { get; set; }
        public string segundo_apellido { get; set; }
        public string enroll { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Autorizacion> Autorizacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Formulario> Formulario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Informacion_proyecto> Informacion_proyecto { get; set; }
    }
}
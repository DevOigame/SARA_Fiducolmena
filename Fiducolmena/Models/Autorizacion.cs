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
    
    public partial class Autorizacion
    {
        public long id { get; set; }
        public bool autorizacion_1 { get; set; }
        public bool autorizacion_2 { get; set; }
        public bool autorizacion_3 { get; set; }
        public string persona_id { get; set; }
    
        public virtual Persona_fidu Persona_fidu { get; set; }
    }
}

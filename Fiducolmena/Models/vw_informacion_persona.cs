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
    
    public partial class vw_informacion_persona
    {
        public string identificacion { get; set; }
        public string tipo_identificacion { get; set; }
        public Nullable<System.DateTime> fecha_expedicion { get; set; }
        public string primer_nombre { get; set; }
        public string segundo_nombre { get; set; }
        public string primer_apellido { get; set; }
        public string segundo_apellido { get; set; }
        public bool autorizacion_1 { get; set; }
        public bool autorizacion_2 { get; set; }
        public bool autorizacion_3 { get; set; }
        public string producto { get; set; }
        public long numero_encargo { get; set; }
        public string ciudad { get; set; }
        public string inmueble { get; set; }
        public string unidad { get; set; }
        public string torre { get; set; }
        public long valor_inmueble { get; set; }
        public long cantidad_garage { get; set; }
        public long cantidad_depositos { get; set; }
        public long valor_cuota_inicial { get; set; }
        public System.DateTime fecha_diligenciamiento { get; set; }
        public string nombre_proceso { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SARLAFTFIDUCOLMENAEntities : DbContext
    {
        public SARLAFTFIDUCOLMENAEntities()
            : base("name=SARLAFTFIDUCOLMENAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__BiometricValidationStateDBContext> C__BiometricValidationStateDBContext { get; set; }
        public virtual DbSet<Autorizacion> Autorizacion { get; set; }
        public virtual DbSet<BiometricValidationState> BiometricValidationState { get; set; }
        public virtual DbSet<Formulario> Formulario { get; set; }
        public virtual DbSet<Informacion_proyecto> Informacion_proyecto { get; set; }
        public virtual DbSet<Persona_fidu> Persona_fidu { get; set; }
        public virtual DbSet<Persona_val> Persona_val { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<vw_informacion_persona> vw_informacion_persona { get; set; }
    
        public virtual int sp_act_validacion(string identificacion)
        {
            var identificacionParameter = identificacion != null ?
                new ObjectParameter("identificacion", identificacion) :
                new ObjectParameter("identificacion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_act_validacion", identificacionParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_registro(Nullable<int> ejecucion, string tipo_identificacion, string identificacion, Nullable<System.DateTime> fecha_expedicion, string primer_nombre, string segundo_nombre, string primer_apellido, string segundo_apellido, Nullable<bool> autorizacion_1, Nullable<bool> autorizacion_2, Nullable<bool> autorizacion_3, string producto, Nullable<long> numero_encargo, string ciudad, string inmueble, string unidad, string torre, Nullable<long> valor_inmueble, Nullable<long> cantidad_garage, Nullable<long> cantidad_depositos, Nullable<long> valor_couta_inicial, Nullable<long> num_Enc_Fijo)
        {
            var ejecucionParameter = ejecucion.HasValue ?
                new ObjectParameter("ejecucion", ejecucion) :
                new ObjectParameter("ejecucion", typeof(int));
    
            var tipo_identificacionParameter = tipo_identificacion != null ?
                new ObjectParameter("tipo_identificacion", tipo_identificacion) :
                new ObjectParameter("tipo_identificacion", typeof(string));
    
            var identificacionParameter = identificacion != null ?
                new ObjectParameter("identificacion", identificacion) :
                new ObjectParameter("identificacion", typeof(string));
    
            var fecha_expedicionParameter = fecha_expedicion.HasValue ?
                new ObjectParameter("fecha_expedicion", fecha_expedicion) :
                new ObjectParameter("fecha_expedicion", typeof(System.DateTime));
    
            var primer_nombreParameter = primer_nombre != null ?
                new ObjectParameter("primer_nombre", primer_nombre) :
                new ObjectParameter("primer_nombre", typeof(string));
    
            var segundo_nombreParameter = segundo_nombre != null ?
                new ObjectParameter("segundo_nombre", segundo_nombre) :
                new ObjectParameter("segundo_nombre", typeof(string));
    
            var primer_apellidoParameter = primer_apellido != null ?
                new ObjectParameter("primer_apellido", primer_apellido) :
                new ObjectParameter("primer_apellido", typeof(string));
    
            var segundo_apellidoParameter = segundo_apellido != null ?
                new ObjectParameter("segundo_apellido", segundo_apellido) :
                new ObjectParameter("segundo_apellido", typeof(string));
    
            var autorizacion_1Parameter = autorizacion_1.HasValue ?
                new ObjectParameter("autorizacion_1", autorizacion_1) :
                new ObjectParameter("autorizacion_1", typeof(bool));
    
            var autorizacion_2Parameter = autorizacion_2.HasValue ?
                new ObjectParameter("autorizacion_2", autorizacion_2) :
                new ObjectParameter("autorizacion_2", typeof(bool));
    
            var autorizacion_3Parameter = autorizacion_3.HasValue ?
                new ObjectParameter("autorizacion_3", autorizacion_3) :
                new ObjectParameter("autorizacion_3", typeof(bool));
    
            var productoParameter = producto != null ?
                new ObjectParameter("producto", producto) :
                new ObjectParameter("producto", typeof(string));
    
            var numero_encargoParameter = numero_encargo.HasValue ?
                new ObjectParameter("numero_encargo", numero_encargo) :
                new ObjectParameter("numero_encargo", typeof(long));
    
            var ciudadParameter = ciudad != null ?
                new ObjectParameter("ciudad", ciudad) :
                new ObjectParameter("ciudad", typeof(string));
    
            var inmuebleParameter = inmueble != null ?
                new ObjectParameter("inmueble", inmueble) :
                new ObjectParameter("inmueble", typeof(string));
    
            var unidadParameter = unidad != null ?
                new ObjectParameter("unidad", unidad) :
                new ObjectParameter("unidad", typeof(string));
    
            var torreParameter = torre != null ?
                new ObjectParameter("torre", torre) :
                new ObjectParameter("torre", typeof(string));
    
            var valor_inmuebleParameter = valor_inmueble.HasValue ?
                new ObjectParameter("valor_inmueble", valor_inmueble) :
                new ObjectParameter("valor_inmueble", typeof(long));
    
            var cantidad_garageParameter = cantidad_garage.HasValue ?
                new ObjectParameter("cantidad_garage", cantidad_garage) :
                new ObjectParameter("cantidad_garage", typeof(long));
    
            var cantidad_depositosParameter = cantidad_depositos.HasValue ?
                new ObjectParameter("cantidad_depositos", cantidad_depositos) :
                new ObjectParameter("cantidad_depositos", typeof(long));
    
            var valor_couta_inicialParameter = valor_couta_inicial.HasValue ?
                new ObjectParameter("valor_couta_inicial", valor_couta_inicial) :
                new ObjectParameter("valor_couta_inicial", typeof(long));
    
            var num_Enc_FijoParameter = num_Enc_Fijo.HasValue ?
                new ObjectParameter("Num_Enc_Fijo", num_Enc_Fijo) :
                new ObjectParameter("Num_Enc_Fijo", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_registro", ejecucionParameter, tipo_identificacionParameter, identificacionParameter, fecha_expedicionParameter, primer_nombreParameter, segundo_nombreParameter, primer_apellidoParameter, segundo_apellidoParameter, autorizacion_1Parameter, autorizacion_2Parameter, autorizacion_3Parameter, productoParameter, numero_encargoParameter, ciudadParameter, inmuebleParameter, unidadParameter, torreParameter, valor_inmuebleParameter, cantidad_garageParameter, cantidad_depositosParameter, valor_couta_inicialParameter, num_Enc_FijoParameter);
        }
    
        public virtual int sp_registro_inicial(string tipo_identificacion, string identificacion)
        {
            var tipo_identificacionParameter = tipo_identificacion != null ?
                new ObjectParameter("tipo_identificacion", tipo_identificacion) :
                new ObjectParameter("tipo_identificacion", typeof(string));
    
            var identificacionParameter = identificacion != null ?
                new ObjectParameter("identificacion", identificacion) :
                new ObjectParameter("identificacion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_registro_inicial", tipo_identificacionParameter, identificacionParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}

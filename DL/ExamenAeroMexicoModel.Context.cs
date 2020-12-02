﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ExamenAeroMexicoEntities : DbContext
    {
        public ExamenAeroMexicoEntities()
            : base("name=ExamenAeroMexicoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DetalleReservacion> DetalleReservacions { get; set; }
        public virtual DbSet<Pasajero> Pasajeroes { get; set; }
        public virtual DbSet<Reservacion> Reservacions { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Vuelo> Vueloes { get; set; }
    
        public virtual int DetalleReservacionAdd(Nullable<int> idPasajero, Nullable<int> idReservacion)
        {
            var idPasajeroParameter = idPasajero.HasValue ?
                new ObjectParameter("IdPasajero", idPasajero) :
                new ObjectParameter("IdPasajero", typeof(int));
    
            var idReservacionParameter = idReservacion.HasValue ?
                new ObjectParameter("IdReservacion", idReservacion) :
                new ObjectParameter("IdReservacion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DetalleReservacionAdd", idPasajeroParameter, idReservacionParameter);
        }
    
        public virtual int PasajeroAdd(string nombre, string apellidoPaterno, string apellidoMaterno, ObjectParameter idPasajero)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PasajeroAdd", nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, idPasajero);
        }
    
        public virtual ObjectResult<PasajeroGetById_Result> PasajeroGetById(Nullable<int> idPasajero)
        {
            var idPasajeroParameter = idPasajero.HasValue ?
                new ObjectParameter("IdPasajero", idPasajero) :
                new ObjectParameter("IdPasajero", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PasajeroGetById_Result>("PasajeroGetById", idPasajeroParameter);
        }
    
        public virtual int PasajeroUpdate(string nombre, string apellidoPaterno, string apellidoMaterno, Nullable<int> idPasajero)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var idPasajeroParameter = idPasajero.HasValue ?
                new ObjectParameter("IdPasajero", idPasajero) :
                new ObjectParameter("IdPasajero", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PasajeroUpdate", nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, idPasajeroParameter);
        }
    
        public virtual int ReservacionAdd(Nullable<int> idUsuario, string numeroVuelo, ObjectParameter idReservacion)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var numeroVueloParameter = numeroVuelo != null ?
                new ObjectParameter("NumeroVuelo", numeroVuelo) :
                new ObjectParameter("NumeroVuelo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ReservacionAdd", idUsuarioParameter, numeroVueloParameter, idReservacion);
        }
    
        public virtual int UsuarioAdd(string nombre, string apellidoPaterno, string apellidoMaterno, string userName, string contrasenia)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var contraseniaParameter = contrasenia != null ?
                new ObjectParameter("Contrasenia", contrasenia) :
                new ObjectParameter("Contrasenia", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UsuarioAdd", nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, userNameParameter, contraseniaParameter);
        }
    
        public virtual ObjectResult<UsuarioGetById_Result> UsuarioGetById(Nullable<int> idUsuario)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UsuarioGetById_Result>("UsuarioGetById", idUsuarioParameter);
        }
    
        public virtual int UsuarioUpdate(string nombre, Nullable<int> idUsuario, string apellidoPaterno, string apellidoMaterno, string userName, string contrasenia)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var contraseniaParameter = contrasenia != null ?
                new ObjectParameter("Contrasenia", contrasenia) :
                new ObjectParameter("Contrasenia", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UsuarioUpdate", nombreParameter, idUsuarioParameter, apellidoPaternoParameter, apellidoMaternoParameter, userNameParameter, contraseniaParameter);
        }
    
        public virtual int VueloAdd(string numeroVuelo, string origen, string destino, Nullable<System.DateTime> fechaSalida)
        {
            var numeroVueloParameter = numeroVuelo != null ?
                new ObjectParameter("NumeroVuelo", numeroVuelo) :
                new ObjectParameter("NumeroVuelo", typeof(string));
    
            var origenParameter = origen != null ?
                new ObjectParameter("Origen", origen) :
                new ObjectParameter("Origen", typeof(string));
    
            var destinoParameter = destino != null ?
                new ObjectParameter("Destino", destino) :
                new ObjectParameter("Destino", typeof(string));
    
            var fechaSalidaParameter = fechaSalida.HasValue ?
                new ObjectParameter("FechaSalida", fechaSalida) :
                new ObjectParameter("FechaSalida", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("VueloAdd", numeroVueloParameter, origenParameter, destinoParameter, fechaSalidaParameter);
        }
    
        public virtual int VueloUpdate(string numeroVuelo, string origen, string destino, Nullable<System.DateTime> fechaSalida)
        {
            var numeroVueloParameter = numeroVuelo != null ?
                new ObjectParameter("NumeroVuelo", numeroVuelo) :
                new ObjectParameter("NumeroVuelo", typeof(string));
    
            var origenParameter = origen != null ?
                new ObjectParameter("Origen", origen) :
                new ObjectParameter("Origen", typeof(string));
    
            var destinoParameter = destino != null ?
                new ObjectParameter("Destino", destino) :
                new ObjectParameter("Destino", typeof(string));
    
            var fechaSalidaParameter = fechaSalida.HasValue ?
                new ObjectParameter("FechaSalida", fechaSalida) :
                new ObjectParameter("FechaSalida", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("VueloUpdate", numeroVueloParameter, origenParameter, destinoParameter, fechaSalidaParameter);
        }
    
        public virtual ObjectResult<VueloGetAll_Result> VueloGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VueloGetAll_Result>("VueloGetAll");
        }
    
        public virtual ObjectResult<VueloGetByNumeroVuelo_Result> VueloGetByNumeroVuelo(string numeroVuelo)
        {
            var numeroVueloParameter = numeroVuelo != null ?
                new ObjectParameter("NumeroVuelo", numeroVuelo) :
                new ObjectParameter("NumeroVuelo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VueloGetByNumeroVuelo_Result>("VueloGetByNumeroVuelo", numeroVueloParameter);
        }
    }
}

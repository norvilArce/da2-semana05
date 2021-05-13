﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Ventas
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class VentasLeonEntities : DbContext
    {
        public VentasLeonEntities()
            : base("name=VentasLeonEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tb_Abastecimiento> Tb_Abastecimiento { get; set; }
        public virtual DbSet<Tb_Categoria> Tb_Categoria { get; set; }
        public virtual DbSet<Tb_Cliente> Tb_Cliente { get; set; }
        public virtual DbSet<Tb_Detalle_Compra> Tb_Detalle_Compra { get; set; }
        public virtual DbSet<Tb_Detalle_Factura> Tb_Detalle_Factura { get; set; }
        public virtual DbSet<Tb_Factura> Tb_Factura { get; set; }
        public virtual DbSet<Tb_Orden_Compra> Tb_Orden_Compra { get; set; }
        public virtual DbSet<Tb_Producto> Tb_Producto { get; set; }
        public virtual DbSet<Tb_Proveedor> Tb_Proveedor { get; set; }
        public virtual DbSet<Tb_RepositorioDocumentos> Tb_RepositorioDocumentos { get; set; }
        public virtual DbSet<Tb_Ubigeo> Tb_Ubigeo { get; set; }
        public virtual DbSet<Tb_UnidadMedida> Tb_UnidadMedida { get; set; }
        public virtual DbSet<Tb_Usuario> Tb_Usuario { get; set; }
        public virtual DbSet<Tb_Vendedor> Tb_Vendedor { get; set; }
        public virtual DbSet<vw_VistaClientes> vw_VistaClientes { get; set; }
        public virtual DbSet<vw_VistaVendedores> vw_VistaVendedores { get; set; }
        public virtual DbSet<vw_VistaFacturas> vw_VistaFacturas { get; set; }
    
        public virtual ObjectResult<usp_ListarFacturasVendedorFechas_Result> usp_ListarFacturasVendedorFechas(string codven, Nullable<System.DateTime> fecini, Nullable<System.DateTime> fecfin)
        {
            var codvenParameter = codven != null ?
                new ObjectParameter("codven", codven) :
                new ObjectParameter("codven", typeof(string));
    
            var feciniParameter = fecini.HasValue ?
                new ObjectParameter("fecini", fecini) :
                new ObjectParameter("fecini", typeof(System.DateTime));
    
            var fecfinParameter = fecfin.HasValue ?
                new ObjectParameter("fecfin", fecfin) :
                new ObjectParameter("fecfin", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarFacturasVendedorFechas_Result>("usp_ListarFacturasVendedorFechas", codvenParameter, feciniParameter, fecfinParameter);
        }
    }
}

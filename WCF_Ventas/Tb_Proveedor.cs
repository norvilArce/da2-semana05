//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Tb_Proveedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Proveedor()
        {
            this.Tb_Abastecimiento = new HashSet<Tb_Abastecimiento>();
            this.Tb_Orden_Compra = new HashSet<Tb_Orden_Compra>();
        }
    
        public string Cod_prv { get; set; }
        public string Raz_soc_prv { get; set; }
        public string Dir_prv { get; set; }
        public string Tel_prv { get; set; }
        public string Ruc_Prv { get; set; }
        public string Rep_ven { get; set; }
        public string Id_Ubigeo { get; set; }
        public Nullable<System.DateTime> Fec_Registro { get; set; }
        public string Usu_Registro { get; set; }
        public Nullable<System.DateTime> Fec_Ult_Mod { get; set; }
        public string Usu_Ult_Mod { get; set; }
        public Nullable<int> Est_prv { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Abastecimiento> Tb_Abastecimiento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Orden_Compra> Tb_Orden_Compra { get; set; }
        public virtual Tb_Ubigeo Tb_Ubigeo { get; set; }
    }
}

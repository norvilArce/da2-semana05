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
    
    public partial class Tb_Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Producto()
        {
            this.Tb_Abastecimiento = new HashSet<Tb_Abastecimiento>();
            this.Tb_Detalle_Compra = new HashSet<Tb_Detalle_Compra>();
            this.Tb_Detalle_Factura = new HashSet<Tb_Detalle_Factura>();
        }
    
        public string Cod_pro { get; set; }
        public string Des_pro { get; set; }
        public Nullable<decimal> Pre_pro { get; set; }
        public Nullable<int> Stk_act { get; set; }
        public Nullable<int> Stk_min { get; set; }
        public Nullable<int> Id_UM { get; set; }
        public Nullable<int> Id_Cat { get; set; }
        public Nullable<int> Importado { get; set; }
        public Nullable<System.DateTime> Fec_Registro { get; set; }
        public string Usu_Registro { get; set; }
        public Nullable<System.DateTime> Fec_Ult_Mod { get; set; }
        public string Usu_Ult_Mod { get; set; }
        public Nullable<int> Est_pro { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Abastecimiento> Tb_Abastecimiento { get; set; }
        public virtual Tb_Categoria Tb_Categoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Detalle_Compra> Tb_Detalle_Compra { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Detalle_Factura> Tb_Detalle_Factura { get; set; }
        public virtual Tb_UnidadMedida Tb_UnidadMedida { get; set; }
    }
}
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
    
    public partial class Tb_RepositorioDocumentos
    {
        public int Id { get; set; }
        public string Ruta { get; set; }
        public Nullable<System.DateTime> FecRegistro { get; set; }
        public string UsuRegistro { get; set; }
    
        public virtual Tb_Usuario Tb_Usuario { get; set; }
    }
}

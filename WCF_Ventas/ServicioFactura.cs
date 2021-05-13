using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;

namespace WCF_Ventas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioFactura" en el código y en el archivo de configuración a la vez.
    public class ServicioFactura : IServicioFactura
    {
        public List<FacturaBE> GetAllFacturasClienteFechas(string strCod, DateTime fecini, DateTime fecfin)
        {
            VentasLeonEntities misVentas = new VentasLeonEntities();
            List<FacturaBE> objListaFacturaBE = new List<FacturaBE>();
            try
            {
                //hacemos la consulta con LINQ
                var query = (from Fact in misVentas.vw_VistaFacturas
                             where Fact.Cod_cli == strCod && Fact.Fec_fac >= fecini && Fact.Fec_fac <= fecfin
                             select Fact);
                //devolvemos la lista de facturas
                foreach(var resultado in query)
                {
                    FacturaBE objFacturaBE = new FacturaBE();
                    objFacturaBE.Num_fac = resultado.Num_fac;
                    objFacturaBE.Fec_fac=Convert.ToDateTime(resultado.Fec_fac);
                    objFacturaBE.Fec_can=Convert.ToDateTime(resultado.Fec_can);
                    objFacturaBE.Estado = resultado.Estado;
                    objFacturaBE.Cod_ven= resultado.Cod_ven;
                    objFacturaBE.Nom_ven= resultado.Nom_ven;
                    objFacturaBE.Ape_ven= resultado.Ape_ven;
                    objFacturaBE.Total=Convert.ToSingle(resultado.Total);

                    //agregamos la instancia a la lista de facturas
                    objListaFacturaBE.Add(objFacturaBE);
                }
                return objListaFacturaBE;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<FacturaBE> GetAllFacturasVendedorFechas(string strCod, DateTime fecini, DateTime fecfin)
        {
            VentasLeonEntities misVentas = new VentasLeonEntities();
            List<FacturaBE> objListaFacturaBE = new List<FacturaBE>();
            try
            {
                var query = misVentas.usp_ListarFacturasVendedorFechas(strCod, fecini, fecfin);
                foreach(var resultado in query)
                {
                    FacturaBE objFacturaBE = new FacturaBE();
                    objFacturaBE.Num_fac = resultado.num_fac;
                    objFacturaBE.Fec_fac = Convert.ToDateTime(resultado.fec_fac);
                    objFacturaBE.Fec_can = Convert.ToDateTime(resultado.fec_can);
                    objFacturaBE.Estado = resultado.estado;
                    objFacturaBE.Cod_cli = resultado.Cod_cli;
                    objFacturaBE.Raz_soc_cli = resultado.Raz_soc_cli;
                    objFacturaBE.Ruc_cli= resultado.Ruc_cli;
                    objFacturaBE.Total = Convert.ToSingle(resultado.total);

                    //agregamos la instancia a la lista de facturas
                    objListaFacturaBE.Add(objFacturaBE);
                }
                return objListaFacturaBE;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}

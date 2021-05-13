using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;

namespace WCF_Ventas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCliente" en el código y en el archivo de configuración a la vez.
    public class ServicioCliente : IServicioCliente
    {
        public ClienteBE ConsultarCliente(String strCod)
        {
            VentasLeonEntities misVentas = new VentasLeonEntities();
            try
            {
                //obtener con LINQ la instancia del cliente a consultar su facturacion
                Tb_Cliente objConsulta = (from objCli in misVentas.Tb_Cliente
                                          where objCli.Cod_cli == strCod
                                          select objCli).FirstOrDefault();
                //creamos una instancia del cliente para retornar el resultado
                ClienteBE objClienteBE = new ClienteBE();

                objClienteBE.Cod_cli = objConsulta.Cod_cli;
                objClienteBE.Raz_soc_cli = objConsulta.Raz_soc_cli;
                objClienteBE.Ruc_cli = objConsulta.Ruc_cli;
                objClienteBE.Dir_cli= objConsulta.Dir_cli;
                objClienteBE.Departamento= objConsulta.Tb_Ubigeo.Departamento;
                objClienteBE.Provincia= objConsulta.Tb_Ubigeo.Provincia;
                objClienteBE.Distrito= objConsulta.Tb_Ubigeo.Distrito;
                objClienteBE.Contacto= objConsulta.Contacto;

                if (objConsulta.Tip_cli == "1")
                {
                    objClienteBE.Tipo = "Con opciona credito";
                }
                else
                {
                    objClienteBE.Tipo = "Sin opcion a credito";
                }

                if (objConsulta.Est_cli == 1)
                {
                    objClienteBE.Estado = "Activo";
                }
                else
                {
                    objClienteBE.Estado = "Inactivo";
                }

                objClienteBE.Deuda = CalcularDeudaCliente(strCod);
                objClienteBE.CantFacturas = Convert.ToInt16(objConsulta.Tb_Factura.Count);

                return objClienteBE;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Single CalcularDeudaCliente(string strCod)
        {
            VentasLeonEntities misVentas = new VentasLeonEntities();
            try
            {
                //haciedno la consulta con LINQ sin usar SP
                Single sngDeuda = Convert.ToSingle(
                    (from Fact in misVentas.vw_VistaFacturas
                     where Fact.Cod_cli == strCod
                     select Fact.Total).Sum());
                return sngDeuda;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }            
        }
    }
}

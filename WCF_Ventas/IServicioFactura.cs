using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Ventas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioFactura" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioFactura
    {
        [OperationContract]
        List<FacturaBE> GetAllFacturasClienteFechas(String strCod, DateTime fecini, DateTime fecfin);

        [OperationContract]
        List<FacturaBE> GetAllFacturasVendedorFechas(String strCod, DateTime fecini, DateTime fecfin);
    }

    // Agregamos la DataContractual
    [DataContract]
    [Serializable]
    public class FacturaBE
    {
        private String mvarnum_fac;
        private DateTime mvarfec_fac;
        private DateTime mvarfec_can;
        private String mvarcod_cli;
        private String mvarraz_soc_cli;
        private String mvarruc_cli;
        private String mvartel_cli;
        private String mvarDepartamento;
        private String mvarProvincia;
        private String mvarDistrito;
        private Single mvarTotal;
        private String mvarest_fac;
        private String mvarestado;
        private String mvarcod_ven;
        private String mvarape_ven;
        private String mvarnom_ven;


        [DataMember]
        public String Num_fac
        {
            get { return mvarnum_fac; }
            set { mvarnum_fac = value; }

        }

        [DataMember]
        public DateTime Fec_fac
        {
            get { return mvarfec_fac; }
            set { mvarfec_fac = value; }

        }

        [DataMember]
        public DateTime Fec_can
        {
            get { return mvarfec_can; }
            set { mvarfec_can = value; }

        }

        [DataMember]
        public String Cod_cli
        {
            get { return mvarcod_cli; }
            set { mvarcod_cli = value; }

        }

        [DataMember]
        public String Raz_soc_cli
        {
            get { return mvarraz_soc_cli; }
            set { mvarraz_soc_cli = value; }

        }

        [DataMember]
        public String Ruc_cli
        {
            get { return mvarruc_cli; }
            set { mvarruc_cli = value; }

        }

        [DataMember]
        public String Tel_cli
        {
            get { return mvartel_cli; }
            set { mvartel_cli = value; }

        }

        [DataMember]
        public String Departamento
        {
            get { return mvarDepartamento; }
            set { mvarDepartamento = value; }

        }

        [DataMember]
        public String Provincia
        {
            get { return mvarProvincia; }
            set { mvarProvincia = value; }

        }

        [DataMember]
        public String Distrito
        {
            get { return mvarDistrito; }
            set { mvarDistrito = value; }

        }


        [DataMember]
        public Single Total
        {
            get { return mvarTotal; }
            set { mvarTotal = value; }

        }

        [DataMember]
        public String Est_fac
        {
            get { return mvarest_fac; }
            set { mvarest_fac = value; }

        }

        [DataMember]
        public String Estado
        {
            get { return mvarestado; }
            set { mvarestado = value; }

        }

        [DataMember]
        public String Cod_ven
        {
            get { return mvarcod_ven; }
            set { mvarcod_ven = value; }

        }

        [DataMember]
        public String Nom_ven
        {
            get { return mvarnom_ven; }
            set { mvarnom_ven = value; }

        }

        [DataMember]
        public String Ape_ven
        {
            get { return mvarape_ven; }
            set { mvarape_ven = value; }

        }

    }
}

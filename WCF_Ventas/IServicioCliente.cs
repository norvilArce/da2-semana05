using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Ventas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioCliente" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioCliente
    {
        [OperationContract]
        ClienteBE ConsultarCliente(String strCod);

        [OperationContract]
        Single CalcularDeudaCliente(String strCod);
    }

    // Creamos la data contractual de clientes
    [DataContract]
    [Serializable]
    public class ClienteBE
    {
        private String mvarcod_cli;
        private String mvarraz_soc_cli;
        private String mvardir_cli;
        private String mvartel_cli;
        private String mvarruc_cli;
        private String mvarcontacto;
        private String mvarDepartamento;
        private String mvarProvincia;
        private String mvarDistrito;
        private DateTime mvarfec_reg;
        private String mvartipo;
        private Single mvardeuda;
        private String mvarestado;
        private Int16 mvarcantfacturas;


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
        public String Dir_cli
        {
            get { return mvardir_cli; }
            set { mvardir_cli = value; }
        }

        [DataMember]
        public String Tel_cli
        {
            get { return mvartel_cli; }
            set { mvartel_cli = value; }
        }

        [DataMember]
        public String Ruc_cli
        {
            get { return mvarruc_cli; }
            set { mvarruc_cli = value; }
        }

        [DataMember]
        public String Contacto
        {
            get { return mvarcontacto; }
            set { mvarcontacto = value; }
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
        public DateTime Fec_reg
        {
            get { return mvarfec_reg; }
            set { mvarfec_reg = value; }
        }

        [DataMember]
        public String Tipo
        {
            get { return mvartipo; }
            set { mvartipo = value; }
        }

        [DataMember]
        public Single Deuda
        {
            get { return mvardeuda; }
            set { mvardeuda = value; }
        }

        [DataMember]
        public String Estado
        {
            get { return mvarestado; }
            set { mvarestado = value; }
        }

        [DataMember]
        public Int16 CantFacturas
        {
            get { return mvarcantfacturas; }
            set { mvarcantfacturas = value; }
        }




    }

}

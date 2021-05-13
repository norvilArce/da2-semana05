using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindows
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                ProxyCliente.ServicioClienteClient objServCliente = new ProxyCliente.ServicioClienteClient();
                ProxyCliente.ClienteBE objClienteBE = new ProxyCliente.ClienteBE();

                ProxyFactura.ServicioFacturaClient objServFactura = new ProxyFactura.ServicioFacturaClient();                

                //invocamos a las operaciones
                //consultamos el cliente
                objClienteBE = objServCliente.ConsultarCliente(txtCod.Text.Trim());
                lblRS.Text = objClienteBE.Raz_soc_cli;
                lblDir.Text = objClienteBE.Dir_cli;
                lblRUC.Text = objClienteBE.Ruc_cli;
                lblDepartamento.Text = objClienteBE.Departamento;
                lblProvincia.Text = objClienteBE.Provincia;
                lblDistrito.Text = objClienteBE.Distrito;
                lblDeuda.Text = objClienteBE.Deuda.ToString();

                //mostramos la facturacion
                dtgDatos.AutoGenerateColumns = false;
                dtgDatos.DataSource = objServFactura.GetAllFacturasClienteFechas(txtCod.Text.Trim(), dtpFI.Value.Date, dtpFF.Value.Date);
                lblRegistros.Text = dtgDatos.Rows.Count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

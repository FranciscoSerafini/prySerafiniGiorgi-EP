using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prySerafiniGiorgi_EP
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void cmdCargarVentas_Click(object sender, EventArgs e)
        {
            bool bandera = false;
          

            if(File.Exists("./ventas.txt"))//pregunta si el archivo existe
            {
                StreamReader SrVentas = new StreamReader("./ventas.txt",true);
                while (!SrVentas.EndOfStream)//recorremos el archivo
                {
                    string auxID = SrVentas.ReadLine();
                    string[] vecVentas = auxID.Split(',');
                    

                    if (mskNroFac.Text == auxID.Substring(0, 5))//preguntamos si el codigo ingresado se repite
                    {
                        MessageBox.Show("Tu codigo de factura se repite, intente con otro");
                        bandera = true;
                    }
                }
                SrVentas.Close();

            }
            if (bandera==false)//si el codigo no se repite escribiremos en el AdeD
            {
                StreamWriter Ventas = new StreamWriter("./ventas.txt", true);
                Ventas.WriteLine(mskNroFac.Text + ',' + lstTipoFactura.Text + ','  + mskFechaVentas.Text + ',' + mskIDCliente.Text + ',' + mskIdVendedor.Text + ',' + txtMonto.Text);
                MessageBox.Show("Venta cargada con éxito.");
                Ventas.Close();
                lstTipoFactura.SelectedIndex = 0;
                mskNroFac.Text = "";
                mskFechaVentas.Text = "";
                mskIDCliente.Text = "";
                mskIDCliente.Text = "";
                txtMonto.Text = "";
                lstTipoFactura.Focus();
            }
            

        }
    }
}

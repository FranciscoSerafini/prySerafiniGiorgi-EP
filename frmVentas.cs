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
            //string archivoVentas = @"D:\Escritorio\prySerafiniGiorgi-EP\bin\Debug";
            //bool fileExists = File.Exists(archivoVentas);

            if(File.Exists("./ventas.txt"))
            {
                StreamReader SrVentas = new StreamReader("./ventas.txt",true);
                while (!SrVentas.EndOfStream)
                {
                    string auxID = SrVentas.ReadLine();
                    

                    if (mskNroFac.Text == auxID.Substring(0, 4))
                    {
                        MessageBox.Show("Tu codigo de factura se repite, intente con otro");
                        bandera = true;
                    }
                }
                SrVentas.Close();

            }
            if (bandera==false)
            {
                StreamWriter Ventas = new StreamWriter("./ventas.txt", true);
                Ventas.WriteLine(lstTipoFactura.Text + ";" + mskNroFac.Text + ";" + DTPFecha.Text + ";" + mskIDCliente.Text + ";" + mskIdVendedor.Text + ";" + txtMonto.Text);
                MessageBox.Show("Venta cargada con éxito.");
                Ventas.Close();
                lstTipoFactura.SelectedIndex = 0;
                mskNroFac.Text = "";
                DTPFecha.Text = "";
                mskIDCliente.Text = "";
                mskIDCliente.Text = "";
                txtMonto.Text = "";
                lstTipoFactura.Focus();
            }
            

        }
    }
}

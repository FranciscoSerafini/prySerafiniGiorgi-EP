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
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void cmdRegistrarVendedores_Click(object sender, EventArgs e)
        {
            bool bandera = false;
           // string archivo = @"D:\Escritorio\prySerafiniGiorgi-EP\bin\Debug";
           // bool FileExists = File.Exists(archivo);
            
            if (File.Exists("./vendedores.txt"))//pregunta si escribe el archivo
            {
                StreamReader SrVendedores = new StreamReader("./vendedores.txt",true);
                while (!SrVendedores.EndOfStream)
                {
                    
                    string auxIDVendedores = SrVendedores.ReadLine();
                    
                    
                    if (mskIDVendedor.Text == auxIDVendedores.Substring(0, 5))
                    {
                        MessageBox.Show("Tu codigo se repite, intente con otro");
                        bandera = true;
                    }
                }
                SrVendedores.Close();
            }
            if (bandera == false)
            {
                StreamWriter vendedores = new StreamWriter("./vendedores.txt",true);
                vendedores.WriteLine(mskIDVendedor.Text + " " + txtNameVendedor.Text + " " + txtActivoCliente.Text + " " + txtComision.Text);
                vendedores.Close();
               // limpieza de cajas de textos y mascaras
                txtActivoCliente.Text = "";
                txtComision.Text = "";
                txtNameVendedor.Text = "";
                mskIDVendedor.Text = "";
                mskIDVendedor.Focus();
                

            }

        }
    }
}

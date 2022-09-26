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
            //declaracion de variables
            bool bandera = false;
            string varCheckActivo = "NO ACTIVO";
            string varCheckComision = "NO COMISION";

            
            if (File.Exists("./vendedores.txt"))//pregunta si escribe el archivo
            {
                StreamReader SrVendedores = new StreamReader("./vendedores.txt",true);
                while (!SrVendedores.EndOfStream)
                {
                    string auxIDVendedores = SrVendedores.ReadLine();
                    string [] vecVendedor = auxIDVendedores.Split(',');
                    
                    
                    if (mskIDVendedor.Text == auxIDVendedores.Substring(0, 5))
                    {
                        MessageBox.Show("Tu codigo se repite, intente con otro");
                        mskIDVendedor.Text = "";
                        mskIDVendedor.Focus();
                        bandera = true;
                    }
                }
                SrVendedores.Close();
            }
            if (bandera == false)
            {
                StreamWriter vendedores = new StreamWriter("./vendedores.txt",true);
                vendedores.WriteLine(mskIDVendedor.Text + ',' + txtNameVendedor.Text + ','+ varCheckActivo + ',' + varCheckComision);
                vendedores.Close();
                txtNameVendedor.Text = "";
                mskIDVendedor.Text = "";
                mskIDVendedor.Focus();
                MessageBox.Show("Tu registro se cargo correctamente");
                

            }
            if (chkActivo.Checked == true)
            {
                varCheckActivo = "SI ACTIVO";
            }
            if (chkComision.Checked == true)
            {
                varCheckComision = "SI COMISION";
            }

        }
    }
}

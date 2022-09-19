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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        

        private void cmdRegistroCliente_Click(object sender, EventArgs e)
        {
        
        bool bandera = false;
            //leemos el archivo
            StreamReader srIDClientes = new StreamReader("./clientes.txt");
            //recorremos el archivo
            while (!srIDClientes.EndOfStream)
            {
                string auxID = srIDClientes.ReadLine();
                
                if (mskClienteID.Text == auxID.Substring(0,5))
                {
                    MessageBox.Show("El ID del cliente se repite, intente con otro");
                    bandera = true;
                    
                }
            }
            srIDClientes.Close();
            if (bandera == false)
            {
                StreamWriter cliente = new StreamWriter("./clientes.txt", true);
                cliente.WriteLine(mskClienteID.Text + ";" + txtClienteName.Text);
                MessageBox.Show("Datos registrado con exito!!!");
                cliente.Close();
                //limpieza de caja de texto y mascara
                txtClienteName.Text = "";
                mskClienteID.Text = "";
                txtClienteName.Focus();

            }
            





            

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

            //File.Create("./clientes.txt");
        }
    }
}

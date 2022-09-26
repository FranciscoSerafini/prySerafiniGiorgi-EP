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
            if (File.Exists("./clientes.txt"))//preguntamos si el archivo existe
            {
                StreamReader srIDClientes = new StreamReader("./clientes.txt");//lee el archivo
                while (!srIDClientes.EndOfStream)//recorremos el archivo
                {
                    string auxID = srIDClientes.ReadLine();
                    string [] datosClientes = auxID.Split(',');

                    if (mskClienteID.Text == auxID.Substring(0,5))
                    {
                        MessageBox.Show("El ID del cliente se repite, intente con otro");
                        mskClienteID.Text = "";
                        mskClienteID.Focus();
                        bandera = true;

                    }
                }
                srIDClientes.Close();
            }
           
            if (bandera == false)
            {
                StreamWriter cliente = new StreamWriter("./clientes.txt", true);//el true lo utilizamos para que si no hay un archivo que lo cree
                cliente.WriteLine(mskClienteID.Text + ";" + txtClienteName.Text);//escritura en archivo
                MessageBox.Show("Datos registrado con exito!!!");
                cliente.Close();
                //limpieza de caja de texto y mascara
                txtClienteName.Text = "";
                mskClienteID.Text = "";
                mskClienteID.Focus();

            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

           
        }

        private void mskClienteID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mskClienteID.Text != "" && txtClienteName.Text !="")
            {
                cmdRegistroCliente.Enabled = true;
            }
            else
            {
                cmdRegistroCliente.Enabled=false;
            }
        }

        private void txtClienteName_TextChanged(object sender, EventArgs e)
        {
            if (mskClienteID.Text != "" && txtClienteName.Text != "")
            {
                cmdRegistroCliente.Enabled = true;
            }
            else
            {
                cmdRegistroCliente.Enabled = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

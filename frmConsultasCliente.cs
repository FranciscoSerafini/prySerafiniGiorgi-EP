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
    public partial class frmConsultasCliente : Form
    {
        

        public frmConsultasCliente()
        {
            InitializeComponent();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            StreamReader clientes = new StreamReader("./clientes.txt");
            while (!clientes.EndOfStream)
            {
                string ID = clientes.ReadLine();
                string[] Clientes = ID.Split(';');
                dataGridView1.Rows.Add(Clientes[0], Clientes[1]);


            }
            clientes.Close();
        }

        private void frmConsultasCliente_Load(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

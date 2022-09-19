using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySerafiniGiorgi_EP
{
    public partial class frmKAKTUS : Form
    {
        public frmKAKTUS()
        {
            InitializeComponent();
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes = new frmClientes();
            frmClientes.ShowDialog();
        }

        private void vENDEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendedor frmVendedor = new frmVendedor();
            frmVendedor.ShowDialog();
        }

        private void vENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas frmVentas = new frmVentas();
            frmVentas.ShowDialog();
        }

        private void cLIENTESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultasCliente frmConsultasCliente = new frmConsultasCliente();
            frmConsultasCliente.ShowDialog();
        }

        private void vENTASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaVentas frmConsultaVentas= new frmConsultaVentas();
            frmConsultaVentas.ShowDialog();
        }
    }
}

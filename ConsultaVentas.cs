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
    public partial class frmConsultaVentas : Form
    {
        public frmConsultaVentas()
        {
            InitializeComponent();
        }

        private void cmdListarVentas_Click(object sender, EventArgs e)
        {
            StreamReader Ventas = new StreamReader("./ventas.txt");
            while (!Ventas.EndOfStream)
            {
               string ventas = Ventas.ReadLine();
                string[] factura = ventas.Split(';');
                

                GRLConsultaVentas.Rows.Add(factura[0], factura[1], factura[2], factura[3], factura[4], factura[5]);

            }
            Ventas.Close();
        }
    }
}

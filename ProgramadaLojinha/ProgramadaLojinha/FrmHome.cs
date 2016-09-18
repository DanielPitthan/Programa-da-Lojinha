using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramadaLojinha
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }
       

        private void pedidoDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLojinha frmPedido = new FrmLojinha();
            frmPedido.ShowDialog();
        }

        
        private void conexãoDataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConfigConnection frmConfigDB = new FrmConfigConnection();
            frmConfigDB.ShowDialog();
        }

        private void impressãoDePedidoLojinhaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmImprimePedido frmpedido = new FrmImprimePedido();
            frmpedido.ShowDialog();
        }
    }
}

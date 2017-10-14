using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comanda_net
{
    public partial class Listar_Comandas_Abertas : Form
    {
        public Listar_Comandas_Abertas()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Listar_Comandas_Abertas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comanda_net_databaseDataSet2.T_COMANDA' table. You can move, or remove it, as needed.
            this.t_COMANDATableAdapter.Fill(this.comanda_net_databaseDataSet2.T_COMANDA);

        }
    }
}

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
    public partial class Listar_Cliente : Form
    {
        public Listar_Cliente()
        {
            InitializeComponent();
        }

        private void Listar_Cliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comanda_net_databaseCliente.T_CLIENTE' table. You can move, or remove it, as needed.
            this.t_CLIENTETableAdapter.Fill(this.comanda_net_databaseCliente.T_CLIENTE);

        }
    }
}

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
    public partial class Listar_Produtos : Form
    {
        public Listar_Produtos()
        {
            InitializeComponent();
        }

        private void Listar_Produtos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comanda_net_databaseDataSet5.T_PRODUTO' table. You can move, or remove it, as needed.
            this.t_PRODUTOTableAdapter.Fill(this.comanda_net_databaseDataSet5.T_PRODUTO);
            // TODO: This line of code loads data into the 'comanda_net_databaseDataSet4.T_PRODUTOS' table. You can move, or remove it, as needed.
            this.t_PRODUTOSTableAdapter.Fill(this.comanda_net_databaseDataSet4.T_PRODUTOS);

        }
    }
}

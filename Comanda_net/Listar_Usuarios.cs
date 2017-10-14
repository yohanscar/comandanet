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
    public partial class Listar_Usuarios : Form
    {
        public Listar_Usuarios()
        {
            InitializeComponent();
        }

        private void Listar_Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comanda_net_databaseUsuarios.T_USUARIO' table. You can move, or remove it, as needed.
            this.t_USUARIOTableAdapter.Fill(this.comanda_net_databaseUsuarios.T_USUARIO);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.t_USUARIOTableAdapter.FillBy(this.comanda_net_databaseUsuarios.T_USUARIO);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.t_USUARIOTableAdapter.FillBy1(this.comanda_net_databaseUsuarios.T_USUARIO);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void listar_UsuariosToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.t_USUARIOTableAdapter.Listar_Usuarios(this.comanda_net_databaseUsuarios.T_USUARIO);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

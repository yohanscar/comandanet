using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComandaFrmk;
using ComandaNetLibs;

namespace Comanda_net
{
    public partial class Abrir_Consumo : Form
    {

        public FR_CLIENTE form_cliente_cons = null;
        public FR_COMANDA form_comanda = null;
        public FR_Mensagem mensagem = new FR_Mensagem();
        public FR_CONSUMO form_consumo = new FR_CONSUMO();

        public Abrir_Consumo()
        {
            InitializeComponent();
        }

        private void bt_Buscar_Click(object sender, EventArgs e)
        {

            form_cliente_cons = new FR_CLIENTE();
            form_cliente_cons._Rg = Convert.ToInt32(textRG.Text);
            NL_Cliente x = new NL_Cliente(this.form_cliente_cons);

            x.ConsultarCliente();
            form_cliente_cons = x.Cliente;

            textNome.Text = form_cliente_cons._Nome ;
           
            //  = selectedUF.ToString();        form_cliente_cons._UF

        }

        private void button1_Click(object sender, EventArgs e)
        {  //Abrir
           // textCamandaNum.Text;
            form_comanda = new FR_COMANDA();
            form_comanda._NumComanda = Convert.ToInt32(textCamandaNum.Text);

            form_consumo = new FR_CONSUMO(form_cliente_cons, form_comanda);

            NL_Consumo x = new NL_Consumo(form_consumo);
            mensagem = x.AbrirConsumo();
            MessageBox.Show(mensagem._mensagem);


        }
        private void Abrir_Consumo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comanda_net_databaseDataSet1.T_COMANDA' table. You can move, or remove it, as needed.
            this.t_COMANDATableAdapter.Fill(this.comanda_net_databaseDataSet1.T_COMANDA);

        }

        private void queryComandasDisponiveisToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.t_COMANDATableAdapter.QueryComandasDisponiveis(this.comanda_net_databaseDataSet1.T_COMANDA);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.t_COMANDATableAdapter.FillBy(this.comanda_net_databaseDataSet1.T_COMANDA);
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
                this.t_COMANDATableAdapter.FillBy1(this.comanda_net_databaseDataSet1.T_COMANDA);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.t_COMANDATableAdapter.FillBy1(this.comanda_net_databaseDataSet1.T_COMANDA);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       

       
    }
}

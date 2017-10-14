using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComandaNetLibs;
using ComandaFrmk;

namespace Comanda_net
{
    public partial class Cadastra_cliente : Form
    {
        public FR_Mensagem mensagem = new FR_Mensagem();
        public FR_CLIENTE form_cliente = new FR_CLIENTE();

        public Cadastra_cliente()
        {
            InitializeComponent();
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            Object selectedUF = comboUF.SelectedItem;
                 
            form_cliente._Nome = Convert.ToString(textNome.Text);
            form_cliente._Rg = Convert.ToInt32(textRG.Text);
            form_cliente._UF =  selectedUF.ToString();
            form_cliente._DataNasc = dateTimePicker1.Value.Date;
            form_cliente._Email = Convert.ToString(textEmail.Text);
            form_cliente._Telefone = Convert.ToInt32(textTelefone.Text);


            NL_Cliente x = new NL_Cliente(form_cliente);
            mensagem = x.CadastrarCliente();
            MessageBox.Show(mensagem._mensagem);

            if (mensagem._codRetorno == 0)
            {
              //  textNome.Text      = " ";
              //  textRG.Text        = " ";
              //  textEmail.Text     = " ";
              //  textTelefone.Text  = " ";
                mensagem._codRetorno = 0;
            }


        }
    }
}

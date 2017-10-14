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
    public partial class Excluir_Cliente : Form
    {
        public FR_CLIENTE form_cliente = null;
        public FR_Mensagem mensagem = new FR_Mensagem();

        public Excluir_Cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { // buscar
            form_cliente = new FR_CLIENTE();
            form_cliente._CodCliente = Convert.ToInt32(textRG.Text);
            NL_Cliente x = new NL_Cliente(this.form_cliente);

            x.ConsultarCliente();

            textNome.Text = form_cliente._Nome;
            textRG.Text = Convert.ToString(form_cliente._Rg);

            //  = selectedUF.ToString();        form_cliente._UF

            
            textEmail.Text = form_cliente._Email;
            textTelefone.Text = Convert.ToString(form_cliente._Telefone);   

        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            NL_Cliente x = new NL_Cliente(this.form_cliente);

            mensagem = x.ExcluirCliente();

        }
    }
}

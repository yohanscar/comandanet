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
    public partial class Alterar_Cliente : Form
    {
        public FR_CLIENTE form_cliente = null;
        public FR_Mensagem mensagem = new FR_Mensagem();
        public NL_Cliente x = null;

        public Alterar_Cliente()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        { // buscar cliente

            form_cliente = new FR_CLIENTE();
            form_cliente._Rg = Convert.ToInt32(textRG.Text);
            x = new NL_Cliente(this.form_cliente);

            x.ConsultarCliente();
            form_cliente = x.Cliente;

            textNome.Text = form_cliente._Nome;
            textRG.Text = Convert.ToString(form_cliente._Rg); 

           //  = selectedUF.ToString();        form_cliente._UF
            comboUF.SelectedIndex = comboUF.FindString(form_cliente._UF);

         //   dateTimePicker1.Value = new DateTime(form_cliente._DataNasc.Year , form_cliente._DataNasc.Month , form_cliente._DataNasc.Day );
            textEmail.Text = form_cliente._Email;
            textTelefone.Text = Convert.ToString (form_cliente._Telefone);   
        }

        private void bt_alterar_Click(object sender, EventArgs e)
        {
            Object selectedUF = comboUF.SelectedItem;

            form_cliente._Nome = Convert.ToString(textNome.Text);
            form_cliente._Rg = Convert.ToInt32(textRG.Text);
            form_cliente._UF = selectedUF.ToString();
            form_cliente._DataNasc = dateTimePicker1.Value.Date;
            form_cliente._Email = Convert.ToString(textEmail.Text);
            form_cliente._Telefone = Convert.ToInt32(textTelefone.Text);

            mensagem = x.AlterarCliente(form_cliente);




        }
    }
}

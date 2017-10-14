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
    public partial class Cadastrar_Comanda : Form
    {
        public FR_COMANDA form_comanda = new FR_COMANDA();
        public FR_Mensagem mensagem = new FR_Mensagem();

        public Cadastrar_Comanda()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {

            form_comanda._NumComanda = Convert.ToInt32( textComanaNum.Text) ;
            NL_Comanda x = new NL_Comanda(form_comanda);
           
            mensagem = x.CadastrarComanda();
            if ( mensagem._codRetorno == 0) {
                textComanaNum.Text = " ";
            }

            MessageBox.Show(mensagem._mensagem);

        }
    }
}

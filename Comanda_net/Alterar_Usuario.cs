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
    public partial class Alterar_Usuario : Form
    {

        public FR_USUARIO form_usuario = new FR_USUARIO();
        public FR_Mensagem mensagem = new FR_Mensagem();

        public Alterar_Usuario()
        {
            InitializeComponent();
        }

        private void bt_Buscar_Click(object sender, EventArgs e)
        {
            form_usuario._IdUsuario = Convert.ToInt32(textIdUsuario.Text);

            NL_Usuario x = new NL_Usuario(form_usuario);
            mensagem = x.PesquisarUsuario();

            textNome.Text = x.usuario._nome;
            // textPass.Text = x.usuario._senha;
            textRG.Text = x.usuario._Rg.ToString();
            textBoxTelefone.Text = x.usuario._telefone.ToString();

          //  dateTimePickerDtNascimento.Value = new DateTime(x.usuario._dataNasc.Year, x.usuario._dataNasc.Month, x.usuario._dataNasc.Day);
        }
    }
}

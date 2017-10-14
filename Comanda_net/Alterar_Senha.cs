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
    public partial class Alterar_Senha : Form
    {
        FR_Mensagem mensagem = new FR_Mensagem();
        FR_USUARIO dadosAtuais = new FR_USUARIO();
        FR_USUARIO dadosNovos = new FR_USUARIO();

        public Alterar_Senha()
        {
            InitializeComponent();
        }

        private void BtConfirmar_Click(object sender, EventArgs e)
        {

            if (textNovaSenha.Text == textConfirmeNova.Text)
            {
                this.dadosAtuais._IdUsuario = Convert.ToInt32(textUsuario.Text);
                this.dadosNovos._IdUsuario = Convert.ToInt32(textUsuario.Text);

                this.dadosAtuais._senha = textSenhaAtual.Text;

                this.dadosNovos._senha = textNovaSenha.Text;

                NL_Usuario x = new NL_Usuario(this.dadosAtuais,this.dadosNovos);

                mensagem = x.AlterarSenha();

                MessageBox.Show(mensagem._mensagem);
            }
            else
            {
                MessageBox.Show("Confirme a nova senha Corretamente!");
            }
        }
    }
}

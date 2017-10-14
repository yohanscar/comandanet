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
    public partial class login : Form
    {
        private FR_USUARIO dadosLogin = new FR_USUARIO(); 
        private FR_Mensagem mensagem;

        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_entrar_Click(object sender, EventArgs e)
        {
            this.dadosLogin._IdUsuario = Convert.ToInt32(user.Text);
            this.dadosLogin._senha = senha.Text;
            
            NL_Usuario x = new NL_Usuario(dadosLogin);

            mensagem = x.Login();

            if (mensagem._codRetorno == 0)
            {
                MessageBox.Show(mensagem._mensagem);
                this.Close();
            }
            else 
            {
                user.Text = " ";
                senha.Text = " ";
                MessageBox.Show(mensagem._mensagem);
            }
        }
    }
}

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
    public partial class Cadastrar_Usuario : Form
    {
        public FR_USUARIO form_usuario = new FR_USUARIO();
        public FR_Mensagem mensagem = new FR_Mensagem();

        public Cadastrar_Usuario()
        {
            InitializeComponent();
        }

        private void bt_cadastrar_User_Click(object sender, EventArgs e)
        {
           Object selectedGerencia = comboBoxGerencia.SelectedItem;
           Object selectedBar      = comboBoxBar.SelectedItem;
           Object selectedRecepcao = comboBoxRecepcao.SelectedItem;
           Object selectedCaixa    = comboBoxCaixa.SelectedItem;

           form_usuario._IdUsuario = Convert.ToInt32(textIdUsuario.Text);

           form_usuario._senha = textPass.Text;
           form_usuario._nome = textNome.Text;
           form_usuario._Rg   = Convert.ToInt32(txtRG.Text);
           form_usuario._Email = textEmail.Text;
           form_usuario._telefone = Convert.ToInt32(textBoxTelefone.Text);
           form_usuario._dataNasc = dateTimePickerDtNascimento.Value.Date;

           if ( (selectedGerencia.ToString() == "SIM" )) 
           {
               form_usuario._perfilGerencia = 1 ;
           } else { form_usuario._perfilGerencia = 0; }


           if ((selectedRecepcao.ToString() == "SIM"))
           {
               form_usuario._perfilRecepcao = 1 ;
           } else { form_usuario._perfilRecepcao = 0; }


           if ((selectedBar.ToString() == "SIM"))
           {
               form_usuario._perfilBar = 1 ;
           } else { form_usuario._perfilBar = 0; }


           if ((selectedCaixa.ToString() == "SIM"))
           {
               form_usuario._perfilCaixa = 1 ;
           } else { form_usuario._perfilCaixa = 0; }

            NL_Usuario x = new NL_Usuario(form_usuario);
            mensagem = x.CadastrarUsuario();

            MessageBox.Show(mensagem._mensagem); 
           
        }

    }
}

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
    public partial class Adicionar_Produto_base : Form
    {
        public FR_Mensagem mensagem = new FR_Mensagem();
        public FR_PRODUTO formProduto = new FR_PRODUTO();

        public Adicionar_Produto_base()
        {
            InitializeComponent();
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            formProduto._CodProduto = Convert.ToInt32(textCodigo.Text);
            formProduto._DescProduto = Convert.ToString(textDescricaoProduto.Text);
            formProduto._VlUnitario = Convert.ToDouble(textValorUnitario.Text);


            NL_Produto x = new NL_Produto(formProduto);
            mensagem = x.CadastrarProduto();
            MessageBox.Show(mensagem._mensagem);
        }
    }
}

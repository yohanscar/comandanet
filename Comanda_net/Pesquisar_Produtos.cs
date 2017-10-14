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
    public partial class Pesquisar_Produtos : Form
    {
        public FR_PRODUTO form_produto = null;
        public FR_Mensagem mensagem = new FR_Mensagem();

        public Pesquisar_Produtos()
        {
            InitializeComponent();
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {

            form_produto = new FR_PRODUTO();
            form_produto._CodProduto = Convert.ToInt32(textCodigo.Text);
            NL_Produto x = new NL_Produto(this.form_produto);

            x.PesquisarProduto();

            textDescricaoProduto.Text = x.produto._DescProduto;
            textValorUnitario.Text = Convert.ToString(x.produto._VlUnitario);

        }
    }
}

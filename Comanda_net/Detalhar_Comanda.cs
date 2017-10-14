using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using ComandaNetLibs;
using ComandaFrmk;

namespace Comanda_net
{
    public partial class Detalhar_Comanda : Form
    {
        public FR_Mensagem mensagem = new FR_Mensagem();
        public FR_CONSUMO formConsumo = new FR_CONSUMO();
        public FR_LISTA_ITENS listaItens;
        public FR_ITEN_CONSUMO ProdutoAddRem;
        public int count = 0;
        private Double valorTotal = 0; 
        
                
        public Detalhar_Comanda()
        {
            InitializeComponent();

            listaItens = new FR_LISTA_ITENS();
            dataGridItens.AutoGenerateColumns = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { //  BOTAO BUSCAR ON CLICK
            
            formConsumo._Comanda._NumComanda = Convert.ToInt32(textBox_comanda.Text);
            NL_Consumo x = new NL_Consumo(formConsumo);
            listaItens = null;
            listaItens = new FR_LISTA_ITENS();

            x.BuscarConsumo();
            textCliente.Text = Convert.ToString(x.Consumo._Cliente._CodCliente);
            valorTotal = x.Consumo._TotalConsumo;
            for (count = 0; count < x.qtdeItens; count++)
            {
                listaItens.Add(x.ItensConsumo[count]);
            }

            dataGridItens.DataSource = null;
            dataGridItens.DataSource = listaItens;
            dataGridItens.Refresh();

           textCliente.Text = x.Consumo._Cliente._Nome;

           labelValorTotal.Text = string.Format("{0:###.##}", x.Consumo._TotalConsumo);

           //  textAbertura.Text = Convert.ToString(x.Consumo._HrAbertura);
           // textFechamento.Text = Convert.ToString(x.Consumo._HrFechamento);

            formConsumo = x.Consumo;
            return;


        }

        private void textBox_comanda_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            ProdutoAddRem = new FR_ITEN_CONSUMO();
            
            ProdutoAddRem._CodProduto = Convert.ToInt32(textCodProduto.Text);

            formConsumo._Comanda._NumComanda = Convert.ToInt32(textBox_comanda.Text);
            NL_Consumo x = new NL_Consumo(formConsumo,ProdutoAddRem);
            mensagem = x.AdicionarIten();

            listaItens = null;
            listaItens = new FR_LISTA_ITENS();

            x.BuscarConsumo();
            textCliente.Text = x.Consumo._Cliente._Nome;
            valorTotal = x.Consumo._TotalConsumo;
            for (count = 0; count < x.qtdeItens; count++)
            {
                listaItens.Add(x.ItensConsumo[count]);
            }

            dataGridItens.DataSource = null;
            dataGridItens.DataSource = listaItens;
            dataGridItens.Refresh();

            labelValorTotal.Text = string.Format("{0:###.##}", x.Consumo._TotalConsumo);
            MessageBox.Show(mensagem._mensagem);
        }

        private void bt_Rem_Click(object sender, EventArgs e)
        {
            ProdutoAddRem = new FR_ITEN_CONSUMO();
            ProdutoAddRem._CodProduto = Convert.ToInt32(textCodProduto.Text);

            formConsumo._Comanda._NumComanda = Convert.ToInt32(textBox_comanda.Text);
            NL_Consumo x = new NL_Consumo(formConsumo, ProdutoAddRem);
            mensagem = x.RemoverIten();

            listaItens = null;
            listaItens = new FR_LISTA_ITENS();

            x.BuscarConsumo();
            textCliente.Text = x.Consumo._Cliente._Nome;
            valorTotal = x.Consumo._TotalConsumo;
            for (count = 0; count < x.qtdeItens; count++)
            {
                listaItens.Add(x.ItensConsumo[count]);
            }

            dataGridItens.DataSource = null;
            dataGridItens.Rows.Clear();
            dataGridItens.DataSource = listaItens;
            dataGridItens.Refresh();

            labelValorTotal.Text = string.Format("{0:###.##}", x.Consumo._TotalConsumo);
            MessageBox.Show(mensagem._mensagem);
        }

        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            formConsumo._Comanda._NumComanda = Convert.ToInt32(textBox_comanda.Text);
            NL_Consumo x = new NL_Consumo(formConsumo, ProdutoAddRem);


            DialogResult result2 = MessageBox.Show(" Deseja Realmente Fechar o Consumo? \n Valor Total R$ " + valorTotal +",00",
            "Confirmar",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question);

            if (result2 == DialogResult.Yes)
            {
                mensagem = x.FecharConsumo();

                textCliente.Text = " ";

                listaItens = null;
                listaItens = new FR_LISTA_ITENS();

                labelValorTotal.Text =  " 00";
                dataGridItens.DataSource = null;
                dataGridItens.Rows.Clear();
                dataGridItens.DataSource = listaItens;
                dataGridItens.Refresh();

                MessageBox.Show(mensagem._mensagem);
            }

        }

        

    }
}

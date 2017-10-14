using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComandaDataLibs;
using ComandaFrmk;

namespace ComandaNetLibs
{
    public class NL_Produto
    {
        public FR_PRODUTO produto = null;
        public DL_ManterProduto con = null;
        public FR_Mensagem mensagem = new FR_Mensagem();

        public NL_Produto(FR_PRODUTO parm)
        {
            produto = parm;
        }

        public FR_Mensagem CadastrarProduto()
        {

            produto._DtInclusao = DateTime.Now;

            con = new DL_ManterProduto(produto);
            mensagem = con.insertProduto();

            con = null;
            return mensagem;
        }

        public FR_Mensagem PesquisarProduto()
        {
            con = new DL_ManterProduto(produto);

            mensagem = con.selectProduto();

            this.produto = con.dadosProduto;

            con = null;
            return mensagem;
        }

        public FR_Mensagem ExcluirProduto()
        {
            con = new DL_ManterProduto(produto);

            mensagem = con.deleteProduto();

            this.produto = con.dadosProduto;

            con = null;
            return mensagem;
        }

        public void AlterarProduto()
        {
            throw new System.NotImplementedException();
        }
    }
}

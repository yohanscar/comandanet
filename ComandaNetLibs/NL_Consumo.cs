using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComandaDataLibs;
using ComandaFrmk;


namespace ComandaNetLibs
{
    public class NL_Consumo
    {
       

        public FR_CONSUMO Consumo = null;
        public FR_ITEN_CONSUMO[] ItensConsumo = new FR_ITEN_CONSUMO[500];
        public int qtdeItens = 0;
        public FR_ITEN_CONSUMO addRemProduto = null;
        public DL_ManterConsumo con = null;
        public DL_ManterCliente con2 = null;
        public FR_Mensagem mensagem = new FR_Mensagem();


        public NL_Consumo(FR_CONSUMO parm)
        {
            this.Consumo = parm;
        }

        public NL_Consumo()
        {
            Consumo = new FR_CONSUMO();

        }

        public NL_Consumo(FR_CONSUMO parm1, FR_ITEN_CONSUMO parm2)
        {
            this.Consumo = parm1;
            this.addRemProduto = parm2;

        }

        public FR_Mensagem AbrirConsumo()
        {
            con = new DL_ManterConsumo(Consumo);

            mensagem = con.GetMaxConsumo();
            con.dadosConsumo._IdConsumo = con.dadosConsumo._IdConsumo + 1;

            mensagem = con.insertConsumo();

            con = null;
            return mensagem;
        }

        public FR_Mensagem BuscarConsumo()
        {
            int i=0;
            con = new DL_ManterConsumo(Consumo);

            mensagem = con.GetConsumo();
            Consumo = con.dadosConsumo;

            mensagem = con.GetItensConsumo();
            ItensConsumo = con.itensConsumo;
            qtdeItens = con.count;

            Consumo._TotalConsumo = 0;

            for (i = 0; i < qtdeItens; i++)
            {
                Consumo._TotalConsumo = Consumo._TotalConsumo + ItensConsumo[i]._SubTotal;
            }

            con2 = new DL_ManterCliente(Consumo._Cliente);

            mensagem = con2.selectCliente_COD();
            Consumo._Cliente = con2.dadosCliente;

            con = null;
            con2 = null;
            return mensagem;
        }

        public FR_Mensagem AdicionarIten()
        {
            con = new DL_ManterConsumo(Consumo, addRemProduto);
            mensagem = con.GetMaxOcorConsumo();
            con.ItenAddRem._OcorConsumo = con.ItenAddRem._OcorConsumo + 1;
            con.ItenAddRem._CodProduto = addRemProduto._CodProduto;

            mensagem = con.insertItenConsumo();

            con = null;
            return mensagem;
        }


        public FR_Mensagem RemoverIten()
        {
            con = new DL_ManterConsumo(Consumo,addRemProduto);
            mensagem = con.GetMaxOcorProduto();

            mensagem = con.deleteItenConsumo();

            con = null;
            return mensagem;
        }

        public FR_Mensagem FecharConsumo()
        {
            con = new DL_ManterConsumo(Consumo);

            mensagem = con.ClearConsumo();

            con = null;
            return mensagem;
        }

    }
}

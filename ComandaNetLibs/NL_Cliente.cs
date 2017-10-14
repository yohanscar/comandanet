using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComandaDataLibs;
using ComandaFrmk;

namespace ComandaNetLibs
{
    public class NL_Cliente
    {
        

        public FR_CLIENTE Cliente = null;
        public FR_Mensagem mensagem = new FR_Mensagem();
        public DL_ManterCliente con = null;

        public NL_Cliente(FR_CLIENTE parm)
        {
            this.Cliente = parm;
        }

        public FR_Mensagem CadastrarCliente()
        {
            con = new DL_ManterCliente( Cliente);
            con.GetMaxCliente();
            con.dadosCliente._CodCliente = con.dadosCliente._CodCliente + 1;
            mensagem = con.insertCliente();

            return mensagem;
        }

        public FR_Mensagem ConsultarCliente()
        {
            con = new DL_ManterCliente(Cliente);
            mensagem = con.selectCliente();  
            return mensagem;
        }

        public FR_Mensagem ExcluirCliente()
        {

            con = new DL_ManterCliente(Cliente);

            mensagem = con.deleteCliente();

            con = null;
            return mensagem;
        }

        public FR_Mensagem AlterarCliente(FR_CLIENTE parm)
        {
            con = new DL_ManterCliente(Cliente);

            mensagem = con.deleteCliente();

            con = null;

            return mensagem;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComandaFrmk;
using ComandaDataLibs;

namespace ComandaNetLibs
{
    public class NL_Comanda
    {
        public FR_COMANDA comanda = null;
        public DL_ManterComanda con = null;
        public FR_Mensagem mensagem = new FR_Mensagem();


        public NL_Comanda(FR_COMANDA parm)
        {
            this.comanda = parm;
        }


        public FR_Mensagem CadastrarComanda()
        {
            comanda._Staus = 1;

            con = new DL_ManterComanda(comanda);
            mensagem = con.insertComanda();

            con = null;
            return mensagem;
        }
 



    }
}

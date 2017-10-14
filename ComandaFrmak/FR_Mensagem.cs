using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandaFrmk
{
    public class FR_Mensagem
    {
        public int     _codRetorno  {get; set;}
        public string  _mensagem    {get; set;}

        public FR_Mensagem()
        {

        }

        public FR_Mensagem(int codRetorno, string Mensagem)
        {
            _codRetorno = codRetorno;
            _mensagem = Mensagem;
        }
    }
}

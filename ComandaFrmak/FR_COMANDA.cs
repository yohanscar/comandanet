using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandaFrmk
{
    public class FR_COMANDA
    {

        public int _NumComanda { get; set; }
        public int _Staus { get; set; }

        public FR_COMANDA()
        {

        }

        public FR_COMANDA(int NumComanda, int status) 
        {
            this._NumComanda = NumComanda;
            this._Staus = status;
        }

        public FR_COMANDA(FR_COMANDA parm)
        {
            this._NumComanda = parm._NumComanda;
            this._Staus = parm._Staus;
        }

    }
}

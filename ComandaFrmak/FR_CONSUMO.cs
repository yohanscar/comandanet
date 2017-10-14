using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandaFrmk
{
    public class FR_CONSUMO
    {
        public int        _IdConsumo    { get; set; }
        public FR_CLIENTE _Cliente      { get; set; }
        public FR_COMANDA _Comanda      { get; set; }
        public DateTime   _HrAbertura   { get; set; }
        public DateTime   _HrFechamento { get; set; }
        public Double     _TotalConsumo { get; set; }


        public FR_CONSUMO()
        {
            _Comanda = new FR_COMANDA();
            _Cliente = new FR_CLIENTE();


        }

        public FR_CONSUMO(FR_CLIENTE Cliente, FR_COMANDA Comanda)
        {
            this._Cliente = Cliente;
            this._Comanda = Comanda;
        }

        public FR_CONSUMO(FR_CONSUMO parm)
        {
            this._IdConsumo = parm._IdConsumo;
            this._Cliente = parm._Cliente;
            this._Comanda = parm._Comanda;
            this._HrAbertura = parm._HrAbertura;
            this._HrFechamento = parm._HrFechamento;
        }





    }
}

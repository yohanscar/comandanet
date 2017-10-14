using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComandaFrmk;

namespace ComandaFrmk
{
    public class FR_ITEN_CONSUMO
    {
        public int     _IdConsumo   { get; set; }
        public int     _OcorConsumo { get; set; }
        public int     _CodProduto  { get; set; }
        public string  _DescProduto { get; set; }
        public int     _QtdeProduto { get; set; }
        public Double  _VlUnitario  { get; set; }
        public double  _SubTotal     { get; set; }
         

        public FR_ITEN_CONSUMO()
        {

        }

        public FR_ITEN_CONSUMO(FR_ITEN_CONSUMO parm)
        {
            this._IdConsumo = parm._IdConsumo;
            this._OcorConsumo = parm._OcorConsumo;
            this._CodProduto = parm._CodProduto;
            this._DescProduto = parm._DescProduto;
            this._QtdeProduto = parm._QtdeProduto;
            this._VlUnitario = parm._VlUnitario;
            this._SubTotal = parm._SubTotal;
        }

    }
}

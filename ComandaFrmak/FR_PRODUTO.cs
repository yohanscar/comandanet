using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandaFrmk
{
    public class FR_PRODUTO
    {


    //   [dbo].[T_PRODUTOS](
	//   [COD_PRODUTO] [numeric](10, 0) NULL,
	//   [DESC_PRODUTO] [varchar](60) NULL,
	//   [VL_UNITARIO] [numeric](7, 2) NULL,
	//   [DT_INCLUSAO] [datetime] NULL,
	//   [DT_MANUT] [datetime] NOT NULL

        public int      _CodProduto   { get; set; }
        public string   _DescProduto  { get; set; }
        public Double   _VlUnitario   { get; set; }
        public DateTime _DtInclusao   { get; set; }
        public DateTime _Dtmanut      { get; set; }
        
        public FR_PRODUTO()
        {



        }

        public FR_PRODUTO(FR_PRODUTO parm)
        {
            this._CodProduto  = parm._CodProduto;
            this._DescProduto = parm._DescProduto;
            this._VlUnitario  = parm._VlUnitario;
            this._DtInclusao  = parm._DtInclusao;
            this._Dtmanut = parm._Dtmanut;
        }
    }
}

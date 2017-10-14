using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandaFrmk
{
    public class FR_CLIENTE
    {
        
        public int _CodCliente     { get; set; }
        public string _UF          { get; set; }
        public string _Nome        { get; set; }
        public int _Telefone       { get; set; }
        public string _Email       { get; set; }
        public int _Rg             { get; set; }
        public DateTime _DataNasc  { get; set; }
        
        public FR_CLIENTE()
        {

        }

        public FR_CLIENTE(FR_CLIENTE parm)
        {
            this._CodCliente =  parm._CodCliente;  
            this._UF         =  parm._UF;         
            this._Nome       =  parm._Nome;       
            this._Telefone   =  parm._Telefone;    
            this._Email      =  parm._Email;      
            this._Rg         =  parm._Rg;          
            this._DataNasc   =  parm._DataNasc; 
        }

    }
}

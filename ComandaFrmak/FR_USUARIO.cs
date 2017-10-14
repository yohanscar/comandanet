using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandaFrmk
{
    public class FR_USUARIO
    {
        //  [ID_USUARIO] [numeric](10, 0) NULL,
        //	[SENHA] [varchar](10) NULL,
        //	[NOME] [varchar](60) NULL,
        //	[RG] [numeric](15, 0) NULL,
        //	[EMAIL] [varchar](60) NULL,
        //	[TELEFONE] [numeric](11, 0) NULL,
        //	[PERFIL_GERENCIA] [smallint] NULL,
        //	[PERFIL_RECEPCAO] [smallint] NULL,
        //	[PERFIL_BARMAN] [smallint] NULL,
        //	[PERFIL_CAIXA] [smallint] NULL

        public int      _IdUsuario      { get; set; }
        public string   _senha          { get; set; }
        public string   _nome           { get; set; }
        public int      _Rg             { get; set; }
        public string   _Email          { get; set; }
        public int      _telefone       { get; set; }
        public int      _perfilGerencia { get; set; }
        public int      _perfilRecepcao { get; set; }
        public int      _perfilBar      { get; set; }
        public int      _perfilCaixa    { get; set; }
        public DateTime _dataNasc       { get; set; }

        public FR_USUARIO(FR_USUARIO parm)
        {
            this._IdUsuario = parm._IdUsuario;
            this._senha = parm._senha;
            this._nome = parm._nome;
            this._Rg = parm._Rg;
            this._Email = parm._Email;
            this._telefone = parm._telefone;
            this._perfilGerencia = parm._perfilGerencia;
            this._perfilRecepcao = parm._perfilRecepcao;
            this._perfilBar = parm._perfilBar;
            this._perfilCaixa = parm._perfilCaixa;
            this._dataNasc = parm._dataNasc;
        }

        public FR_USUARIO(int IdUsuario, string senha, string nome, int Rg, string email , int telefone, int perfilGerencia, int perfilRecepcao, int perfilBar, int perfilCaixa, DateTime dataNasc)
        {
            this._IdUsuario = IdUsuario;
            this._senha = senha;
            this._nome = nome;
            this._Rg = Rg;
            this._Email = email;
            this._telefone = telefone;
            this._perfilGerencia = perfilGerencia;
            this._perfilRecepcao = perfilRecepcao;
            this._perfilBar = perfilBar;
            this._perfilCaixa = perfilCaixa;
            this._dataNasc = dataNasc;
        }

        public FR_USUARIO()
        {

        }

      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComandaFrmk;
using ComandaDataLibs;

namespace ComandaNetLibs
{
    public class NL_Usuario
    {
        public FR_USUARIO usuario = null;
        private FR_USUARIO usuarioNovo = null;
        private FR_USUARIO userAux = null;
        private DL_ManterUsuario con = null;
        public FR_Mensagem mensagem = new FR_Mensagem();

        public NL_Usuario(FR_USUARIO parm)
        {
            this.usuario = parm;
            
        }

        public NL_Usuario(FR_USUARIO parmAtual, FR_USUARIO parmNovo)
        {
            this.usuario = parmAtual;
            this.usuarioNovo = parmNovo;
        }

        public FR_Mensagem CadastrarUsuario()
        {
            con = new DL_ManterUsuario(this.usuario);
            mensagem = con.insertUsuario();

            con = null;
            return mensagem;
        }


        public FR_Mensagem PesquisarUsuario()
        {
            con = new DL_ManterUsuario(this.usuario);
            mensagem = con.selectUsuario();
            
            this.usuario = con.dados_usuario;

            con = null;
            return mensagem;
        }

        public void ListarUsuario()
        {
            throw new System.NotImplementedException();
        }

        public void AlterarUsuario()
        {
            throw new System.NotImplementedException();
        }

        public FR_Mensagem AlterarSenha()
        {
            con = new DL_ManterUsuario(this.usuario);
            mensagem = con.selectUsuario();

            if ((con.dados_usuario._senha != usuario._senha))
            {
                this.mensagem._mensagem = " Verifique Senha Atual! ";
            }
            else
            {
                this.usuario._senha = this.usuarioNovo._senha;
                mensagem = con.updateSenha(this.usuario);
            }

            con = null;
            return mensagem;
        }

        public void ExcluirUsuario()
        {
            throw new System.NotImplementedException();
        }

        public FR_Mensagem Login()
        {
            string x = usuario._senha; 
            con = new DL_ManterUsuario(this.usuario);
           
            mensagem = con.selectUsuario();

            if ((con.dados_usuario._senha != x))
            {
                this.mensagem._codRetorno = 8;
                this.mensagem._mensagem = " Usuário e/ou Senha incorretos!! \n Favor Verificar. ";
            }
            else
            {
                this.mensagem._codRetorno = 0;
                this.mensagem._mensagem = " Bem Vindo : "+ con.dados_usuario._nome + " \n Login Efetuado com Sucesso!";
            }

            con = null;
            return mensagem;
        }

        public void Logon()
        {
            throw new System.NotImplementedException();
        }

    }
}

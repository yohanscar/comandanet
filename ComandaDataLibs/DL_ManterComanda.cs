using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComandaFrmk;
using System.Data;                              //database namespaces
using System.Data.SqlClient;                    //database namespaces

namespace ComandaDataLibs
{
    public class DL_ManterComanda
    {
        public FR_COMANDA dadosComanda = null;
        public FR_Mensagem mensagem = new FR_Mensagem();
        private FR_UTEIS util = new FR_UTEIS();

        public DL_ManterComanda(FR_COMANDA parm)
        {
            this.dadosComanda = parm;
        }


        public FR_Mensagem insertComanda() 
        {
             
            SqlConnection conexao = new SqlConnection(util.getStringConexao());

            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.T_COMANDA ( NUM_COMANDA , STATUS ) VALUES (" + dadosComanda._NumComanda + ", " + dadosComanda._Staus + " )", conexao);
          

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conexao.Close();
                Console.WriteLine(ex.Message);

                mensagem._codRetorno = 8;
                mensagem._mensagem = "ERRO DE ACESSO AO BANCO DE DADOS";
            }
            finally
            {
                conexao.Close();
                mensagem._codRetorno = 0;
                mensagem._mensagem = "COMANDA CADASTRADA COM SUCESSO";
            }
            return mensagem;
        }




    }
}

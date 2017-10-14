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
   

    public class DL_ManterUsuario
    {
       //private string strcon = "Data Source=localhost;Initial Catalog=Comanda_net_database;Integrated Security=True";
       public FR_USUARIO dados_usuario = null;
       public FR_Mensagem mensagem = new FR_Mensagem();
       private FR_UTEIS util = new FR_UTEIS();

        /*
       public int    ID_USUARIO          ;
       public string SENHA               ;
       public string NOME                ;
       public int    RG                  ;
       public string EMAIL               ;
       public int    TELEFONE            ;
       public int    PERFIL_GERENCIA     ;
       public int    PERFIL_RECEPCAO     ;
       public int    PERFIL_BARMAN       ;
       public int    PERFIL_CAIXA        ; 

        */

       public DL_ManterUsuario(FR_USUARIO parm)
       {
           this.dados_usuario = parm;
       }


       public FR_Mensagem insertUsuario()
        {
            
            SqlConnection conexao = new SqlConnection(util.getStringConexao());
          
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.T_USUARIO (ID_USUARIO ,SENHA ,NOME ,RG ,EMAIL ,TELEFONE ,PERFIL_GERENCIA ,PERFIL_RECEPCAO ,PERFIL_BARMAN ,PERFIL_CAIXA) VALUES ( " + dados_usuario._IdUsuario + " ,'" + dados_usuario._senha + "' ,'" + dados_usuario._nome   + "' ," + dados_usuario._Rg  + " , '" + dados_usuario._Email  + "' ," + dados_usuario._telefone  + "  ," + dados_usuario._perfilGerencia   + "  , "+ dados_usuario._perfilRecepcao   + "  ," + dados_usuario._perfilBar  + "," + dados_usuario._perfilCaixa + " )", conexao);
                                                                                                                                                                                                                                                                                                                
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //   MessageBox.Show("Erro " + ex.Message); 
                conexao.Close();
                Console.WriteLine(ex.Message);

                mensagem._codRetorno = 8;
                mensagem._mensagem = "ERRO DE ACESSO AO BANCO DE DADOS";
            }
            finally
            {
                conexao.Close();
                mensagem._codRetorno = 0;
                mensagem._mensagem = "USARIO CADASTRADO COM SUCESSO";
            }
            return mensagem;
        }

        public FR_Mensagem selectUsuario()
        {

            SqlConnection conexao = new SqlConnection(util.getStringConexao());

            this.dados_usuario._senha = " "; /* --> Em caso de ausencia de registros
                                                   impede comparacao errone no if do LOGIN */

            SqlCommand cmd = new SqlCommand("SELECT ID_USUARIO , SENHA , NOME , RG , EMAIL, TELEFONE , PERFIL_GERENCIA , PERFIL_RECEPCAO , PERFIL_BARMAN , PERFIL_CAIXA FROM dbo.T_USUARIO WHERE ID_USUARIO = " + dados_usuario._IdUsuario + "  " , conexao);

            SqlDataReader dr = null;
            try
            {
                conexao.Open();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                                      
                    this.dados_usuario._senha = dr.GetString(1);
                    this.dados_usuario._nome = dr.GetString(2);
                    this.dados_usuario._Rg = (int) dr.GetSqlDecimal(3);
                    this.dados_usuario._Email = dr.GetString(4);
                    this.dados_usuario._telefone = (int)dr.GetSqlDecimal(5);
                    this.dados_usuario._perfilGerencia = (int)dr.GetSqlInt16(6);
                    this.dados_usuario._perfilRecepcao = (int)dr.GetSqlInt16(7);
                    this.dados_usuario._perfilBar = (int)dr.GetSqlInt16(8);
                    this.dados_usuario._perfilCaixa = (int)dr.GetSqlInt16(9);
                        
                    Console.WriteLine(dr.GetValue(0));
                    Console.WriteLine(dr.GetString(1));
                    Console.WriteLine(dr.GetString(2));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro." + e.Message);
            }
            finally
            {
                dr.Close();
                conexao.Close();
            }
            
            return mensagem;
        }

       

        public void updateUsuario()
        {

            return;
        }

        public FR_Mensagem updateSenha(FR_USUARIO parm)
        {

            SqlConnection conexao = new SqlConnection(util.getStringConexao());

            SqlCommand cmd = new SqlCommand("UPDATE dbo.T_USUARIO SET SENHA =" + parm._senha + " WHERE ID_USUARIO = " + parm._IdUsuario +  " " , conexao);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //   MessageBox.Show("Erro " + ex.Message); 
                conexao.Close();
                Console.WriteLine(ex.Message);

                mensagem._codRetorno = 8;
                mensagem._mensagem = "ERRO DE ACESSO AO BANCO DE DADOS";
            }
            finally
            {
                conexao.Close();
                mensagem._codRetorno = 0;
                mensagem._mensagem = "SENHA ALTERADA COM SUCESSO";
            }
            return mensagem;
        }

        public void deleteUsuario()
        {

            return;
        }



    }
}

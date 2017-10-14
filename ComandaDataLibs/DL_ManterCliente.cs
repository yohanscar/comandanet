using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;                              //database namespaces
using System.Data.SqlClient;                    //database namespaces
using ComandaFrmk;


namespace ComandaDataLibs
{
    public class DL_ManterCliente
    {

        private FR_UTEIS util = new FR_UTEIS();
        public FR_CLIENTE dadosCliente = null;
        public FR_Mensagem mensagem = new FR_Mensagem();

        public DL_ManterCliente(FR_CLIENTE parm)
        {
            this.dadosCliente = parm;
        }

       public FR_Mensagem insertCliente()
       {

           SqlConnection conexao = new SqlConnection(util.getStringConexao());
           SqlCommand cmd = new SqlCommand("INSERT INTO dbo.T_CLIENTE (COD_CLIENTE ,UF,NOME  ,TELEFONE  ,EMAIL   ,RG  ,DATA_NASCIMENTO) VALUES ( " + dadosCliente._CodCliente + " ,'" + dadosCliente._UF + "', '" + dadosCliente._Nome + "','" + dadosCliente._Telefone + "','" + dadosCliente._Email + "', '" + dadosCliente._Rg + "' , '" + dadosCliente._DataNasc + "')", conexao);
                         
            try { 
                conexao.Open();
                cmd.ExecuteNonQuery();
            } 
            catch (Exception ex) 
            { 
             //   MessageBox.Show("Erro " + ex.Message); 
                mensagem._codRetorno = 8;
                mensagem._mensagem = "ERRO DE ACESSO AO BANCO DE DADOS";

                conexao.Close();
                Console.WriteLine(ex.Message);
            } 
            finally
            { 
                conexao.Close();
                mensagem._codRetorno = 0;
                mensagem._mensagem = "CLIENTE CADASTRADO COM SUCESSO";
            }
            return mensagem;
        }

       public FR_Mensagem selectCliente()
       {
            SqlConnection conexao = new SqlConnection(util.getStringConexao());

            SqlCommand cmd = new SqlCommand("SELECT COD_CLIENTE  ,UF ,NOME ,TELEFONE ,EMAIL ,RG ,DATA_NASCIMENTO FROM dbo.T_CLIENTE WHERE RG = " + dadosCliente._Rg + "  ", conexao);
        
            SqlDataReader dr = null;
            try
            {
                conexao.Open();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {

                    this.dadosCliente._CodCliente = (int)dr.GetSqlDecimal(0);
                    this.dadosCliente._UF = dr.GetString(1);
                    this.dadosCliente._Nome = dr.GetString(2);
                    this.dadosCliente._Telefone = (int)dr.GetSqlDecimal(3);
                    this.dadosCliente._Email = dr.GetString(4);
                    this.dadosCliente._Rg = (int) dr.GetSqlDecimal(5);
                    this.dadosCliente._DataNasc = dr.GetDateTime(6);
        
                    Console.WriteLine(dr.GetValue(0));
                    Console.WriteLine(dr.GetString(1));
                    Console.WriteLine(dr.GetDouble(2));
                }
            }
            catch
            {
                Console.WriteLine("Erro.");
            }
            finally
            {
                dr.Close();
                conexao.Close();
            }
            return mensagem;
       }


       public FR_Mensagem selectCliente_COD()
       {
           SqlConnection conexao = new SqlConnection(util.getStringConexao());

           SqlCommand cmd = new SqlCommand("SELECT COD_CLIENTE  ,UF ,NOME ,TELEFONE ,EMAIL ,RG ,DATA_NASCIMENTO FROM dbo.T_CLIENTE WHERE COD_CLIENTE = " + dadosCliente._CodCliente + "  ", conexao);

           SqlDataReader dr = null;
           try
           {
               conexao.Open();
               dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
               while (dr.Read())
               {

                   this.dadosCliente._CodCliente = (int)dr.GetSqlDecimal(0);
                   this.dadosCliente._UF = dr.GetString(1);
                   this.dadosCliente._Nome = dr.GetString(2);
                   this.dadosCliente._Telefone = (int)dr.GetSqlDecimal(3);
                   this.dadosCliente._Email = dr.GetString(4);
                   this.dadosCliente._Rg = (int)dr.GetSqlDecimal(5);
                   this.dadosCliente._DataNasc = dr.GetDateTime(6);

                   Console.WriteLine(dr.GetValue(0));
                   Console.WriteLine(dr.GetString(1));
                   Console.WriteLine(dr.GetDouble(2));
               }
           }
           catch
           {
               Console.WriteLine("Erro.");
           }
           finally
           {
               dr.Close();
               conexao.Close();
           }
           return mensagem;
       }

       public FR_Mensagem deleteCliente()
       {



           return mensagem;
       }

       public FR_Mensagem GetMaxCliente()
       {
           SqlConnection conexao = new SqlConnection(util.getStringConexao());

           SqlCommand cmd = new SqlCommand("SELECT MAX(COD_CLIENTE) FROM dbo.T_CLIENTE ", conexao);

           SqlDataReader dr = null;
           try
           {
               conexao.Open();
               dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
               while (dr.Read())
               {

                   this.dadosCliente._CodCliente = (int)dr.GetSqlDecimal(0);
                  
                   Console.WriteLine(dr.GetValue(0));
               }
           }
           catch
           {
               Console.WriteLine("Erro.");
           }
           finally
           {
               dr.Close();
               conexao.Close();
           }
           return mensagem;
       }

       public FR_Mensagem updateCliente(FR_CLIENTE parm)
       {

           SqlConnection conexao = new SqlConnection(util.getStringConexao());

           SqlCommand cmd = new SqlCommand("UPDATE dbo.T_CLIENTE SET NOME = " + " ,TELEFONE = " + parm._Telefone + " ,EMAIL = '" + parm._Email + "'  ,DATA_NASCIMENTO =" + parm._DataNasc + " WHERE COD_CLIENTE = " + parm._CodCliente + " ", conexao);

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
               mensagem._mensagem = "CLIENTE ALTERADO COM SUCESSO";
           }
           return mensagem;
       }
       
    }
}

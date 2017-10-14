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
    public class DL_ManterProduto
    {

        public FR_PRODUTO dadosProduto = null;
        public FR_Mensagem mensagem = new FR_Mensagem();
        private FR_UTEIS util = new FR_UTEIS();
        public IDataRecord x;

        public DL_ManterProduto(FR_PRODUTO parm)
        {
            this.dadosProduto = parm;
        }


        public FR_Mensagem insertProduto() 
        {

            SqlConnection conexao = new SqlConnection(util.getStringConexao());
           
            SqlCommand cmd = new SqlCommand(" INSERT INTO dbo.T_PRODUTO (COD_PRODUTO ,DESC_PRODUTO ,VL_UNITARIO ,DT_INCLUSAO ,DT_MANUT) VALUES (" + dadosProduto._CodProduto + ", '" + dadosProduto._DescProduto + "' ," + dadosProduto._VlUnitario + ",'" + dadosProduto._DtInclusao + "','" + dadosProduto._DtInclusao + "' )", conexao);
          

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
                mensagem._mensagem = "PRODUTO CADASTRADO COM SUCESSO";
            }
            return mensagem;
        }

        public FR_Mensagem selectProduto()
        {
        
            SqlConnection conexao = new SqlConnection(util.getStringConexao());
        
            SqlCommand cmd = new SqlCommand("SELECT COD_PRODUTO ,DESC_PRODUTO ,VL_UNITARIO ,DT_INCLUSAO ,DT_MANUT FROM dbo.T_PRODUTO WHERE COD_PRODUTO = " + dadosProduto._CodProduto + "  ", conexao);
        
            SqlDataReader dr = null;
            try
            {
                conexao.Open();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {

                    this.dadosProduto._CodProduto = (int)dr.GetSqlDecimal(0);
                    this.dadosProduto._DescProduto = dr.GetString(1);
               //     this.dadosProduto._VlUnitario =  Double.Parse( dr.GetValue(2));
                    this.dadosProduto._DtInclusao = dr.GetDateTime(3);
                    this.dadosProduto._Dtmanut = dr.GetDateTime(4);
        
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

        public void updateProduto()
        {

            return;
        }

        public FR_Mensagem deleteProduto()
        {
            SqlConnection conexao = new SqlConnection(util.getStringConexao());

            SqlCommand cmd = new SqlCommand(" DELETE FROM dbo.T_PRODUTO WHERE COD_PRODUTO = " + dadosProduto._CodProduto + "  ", conexao);
            
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
                mensagem._mensagem = "PRODUTO EXCLUIDO COM SUCESSO";
            }
            return mensagem;
         
        }

    }
}

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
    public class DL_ManterConsumo
    {
        
        public FR_CONSUMO dadosConsumo = null;
        public FR_ITEN_CONSUMO[] itensConsumo = new FR_ITEN_CONSUMO[500];
        public FR_Mensagem mensagem = new FR_Mensagem();
        private FR_UTEIS util = new FR_UTEIS();
        public int count = 0;
        public FR_ITEN_CONSUMO ItenAddRem;


        public DL_ManterConsumo(FR_CONSUMO parm)
        {
            this.dadosConsumo = parm;
        }


        public DL_ManterConsumo(FR_CONSUMO parm1, FR_ITEN_CONSUMO parm2)
        {
            this.dadosConsumo = parm1;
            this.ItenAddRem = parm2;
            this.ItenAddRem._IdConsumo = this.dadosConsumo._IdConsumo;
            this.ItenAddRem._QtdeProduto = 1;
        }

        public FR_Mensagem insertConsumo() 
        {
            DateTime y = DateTime.Today ;
            SqlConnection conexao = new SqlConnection(util.getStringConexao());

            dadosConsumo._HrAbertura = y;
            dadosConsumo._HrFechamento = y;


            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.T_CONSUMO(ID_CONSUMO,NUM_COMANDA,COD_CLIENTE,HORA_ABERTURA,HORA_FECHAMENTO)VALUES( " + dadosConsumo._IdConsumo + ", " + dadosConsumo._Comanda._NumComanda + ", " + dadosConsumo._Cliente._CodCliente + ",'" + dadosConsumo._HrAbertura + "','" + dadosConsumo._HrFechamento +"')", conexao);
          

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
                mensagem._mensagem = "CONSUMO ABERTO COM SUCESSO";
            }
            return mensagem;
        }

        public FR_Mensagem GetMaxConsumo()
        {
            SqlConnection conexao = new SqlConnection(util.getStringConexao());

            SqlCommand cmd = new SqlCommand("SELECT MAX(ID_CONSUMO) FROM dbo.T_CONSUMO ", conexao);

            SqlDataReader dr = null;
            try
            {
                conexao.Open();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {

                    this.dadosConsumo._IdConsumo = (int)dr.GetSqlDecimal(0);

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

        public FR_Mensagem GetConsumo()
        {
            SqlConnection conexao = new SqlConnection(util.getStringConexao());

            SqlCommand cmd = new SqlCommand("SELECT ID_CONSUMO , NUM_COMANDA , COD_CLIENTE , HORA_ABERTURA , HORA_FECHAMENTO FROM dbo.T_CONSUMO WHERE NUM_COMANDA = " + dadosConsumo._Comanda._NumComanda + " ", conexao);

            SqlDataReader dr = null;
            try
            {
                conexao.Open();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {

                    this.dadosConsumo._IdConsumo = (int)dr.GetSqlDecimal(0);
                    this.dadosConsumo._Comanda._NumComanda = (int)dr.GetSqlDecimal(1);
                    this.dadosConsumo._Cliente._CodCliente = (int)dr.GetSqlDecimal(2);
                    this.dadosConsumo._HrAbertura = (DateTime) dr.GetDateTime(3);
                    this.dadosConsumo._HrFechamento = (DateTime)dr.GetDateTime(4);
                    

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

        public FR_Mensagem GetItensConsumo()
        {
            SqlConnection conexao = new SqlConnection(util.getStringConexao());

            SqlCommand cmd = new SqlCommand("SELECT a.ID_CONSUMO , a.OCOR_CONSUMO , a.COD_PRODUTO , a.QTDE_PRODUTO , b.DESC_PRODUTO , b.VL_UNITARIO FROM dbo.T_ITENS_CONSUMO a , dbo.T_PRODUTO b WHERE a.COD_PRODUTO = b.COD_PRODUTO and a.ID_CONSUMO = " + dadosConsumo._IdConsumo + " ", conexao);

            SqlDataReader dr = null;
            try
            {
                conexao.Open();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    this.itensConsumo[count] = new FR_ITEN_CONSUMO();

                    this.itensConsumo[count]._IdConsumo = (int)dr.GetSqlDecimal(0);
                    this.itensConsumo[count]._OcorConsumo = (int)dr.GetSqlDecimal(1);
                    this.itensConsumo[count]._CodProduto = (int)dr.GetSqlDecimal(2);
                    this.itensConsumo[count]._QtdeProduto = (int)dr.GetSqlDecimal(3);
                    this.itensConsumo[count]._DescProduto = dr.GetString(4);
                    this.itensConsumo[count]._VlUnitario = (Double) dr.GetSqlDouble(5);
                    this.itensConsumo[count]._SubTotal = this.itensConsumo[count]._VlUnitario * this.itensConsumo[count]._QtdeProduto;

                    Console.WriteLine(dr.GetValue(0));
                    count ++;
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

        public FR_Mensagem insertItenConsumo()
        {

            SqlConnection conexao = new SqlConnection(util.getStringConexao());

            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.T_ITENS_CONSUMO (ID_CONSUMO  , OCOR_CONSUMO , COD_PRODUTO , QTDE_PRODUTO ) VALUES (" + ItenAddRem._IdConsumo + "," + ItenAddRem._OcorConsumo + "," +ItenAddRem._CodProduto + "," + ItenAddRem._QtdeProduto + ") ", conexao);

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
                mensagem._mensagem = "ITEM INSERIDO COM SUCESSO";
            }
            return mensagem;
        }

        public FR_Mensagem GetMaxOcorConsumo()
        {
           
            SqlConnection conexao = new SqlConnection(util.getStringConexao());

            SqlCommand cmd = new SqlCommand("SELECT MAX(OCOR_CONSUMO) FROM dbo.T_ITENS_CONSUMO WHERE ID_CONSUMO = " + ItenAddRem._IdConsumo + " ", conexao);

            SqlDataReader dr = null;
            try
            {
                conexao.Open();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {

                    this.ItenAddRem._OcorConsumo = (int)dr.GetSqlDecimal(0);

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

        public FR_Mensagem GetMaxOcorProduto()
        {
           
            SqlConnection conexao = new SqlConnection(util.getStringConexao());

            SqlCommand cmd = new SqlCommand("SELECT MAX(OCOR_CONSUMO) FROM dbo.T_ITENS_CONSUMO WHERE ID_CONSUMO = " + ItenAddRem._IdConsumo + " AND COD_PRODUTO = " + ItenAddRem._CodProduto + " ", conexao);

            SqlDataReader dr = null;
            try
            {
                conexao.Open();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {

                    this.ItenAddRem._OcorConsumo = (int)dr.GetSqlDecimal(0);

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

        
        public FR_Mensagem deleteItenConsumo()
        {

            SqlConnection conexao = new SqlConnection(util.getStringConexao());

            SqlCommand cmd = new SqlCommand("DELETE FROM dbo.T_ITENS_CONSUMO WHERE ID_CONSUMO =  " + ItenAddRem._IdConsumo + " AND OCOR_CONSUMO = " + ItenAddRem._OcorConsumo + " ", conexao);

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
                mensagem._mensagem = "ITEM REMOVIDO COM SUCESSO";
            }
            return mensagem;
        }




        public FR_Mensagem ClearConsumo()
        {

            DeleteItensConsumo();
            DeleteConsumo();

            mensagem._codRetorno = 0;
            mensagem._mensagem = "CONSUMO FINALIZADO COM SUCESSO";
            return mensagem;
        }

        private void DeleteConsumo(){

            SqlConnection conexao = new SqlConnection(util.getStringConexao());

            SqlCommand cmd = new SqlCommand("DELETE FROM dbo.T_CONSUMO WHERE ID_CONSUMO =  " + dadosConsumo._IdConsumo + " ", conexao);

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
                mensagem._mensagem = "ITEM REMOVIDO COM SUCESSO";
            }

        }

            
        private void DeleteItensConsumo()
        {

            SqlConnection conexao = new SqlConnection(util.getStringConexao());

            SqlCommand cmd = new SqlCommand("DELETE FROM dbo.T_ITENS_CONSUMO WHERE ID_CONSUMO =  " + dadosConsumo._IdConsumo + " ", conexao);

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
                mensagem._mensagem = "ITEM REMOVIDO COM SUCESSO";
            }
        }

        }

        
    }


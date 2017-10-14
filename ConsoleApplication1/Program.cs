using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string strcon = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL11.MSSQLSERVER\\MSSQL\\DATA\\Comanda_net_database.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

            string constr = "Data Source=localhost;Initial Catalog=Comanda_net_database;Integrated Security=True";

            SqlConnection conexao = new SqlConnection();

            try
            {
                conexao.ConnectionString = strcon;
                conexao.Open();
                Console.Write("conectou");
                Console.ReadKey();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandaFrmk
{
    public class FR_UTEIS
    {
        private string strcon;

        public FR_UTEIS()
        {

        }

        public String getStringConexao()
        {
           // strcon = "Data Source=1.1.1.1;Initial Catalog=Comanda_net_database;Integrated Security=True";
            strcon = "Data Source=localhost;Initial Catalog=Comanda_net_database;Integrated Security=True";
            return strcon;
        }

    }
}

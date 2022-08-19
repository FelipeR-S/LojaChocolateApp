using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaChocolateApp.Repository
{
    public class SQLServerConn
    {
        private static string server = Environment.MachineName;
        private static string database = "Loja_Chocolate";
        private static string user = "administrador";
        private static string password = "1234";

        public static string StrCon
        {
            get { return $"Data Source={server}; Integrated Security=false; Initial Catalog={database}; User ID={user}; Password={password}"; }
        }
    }
}

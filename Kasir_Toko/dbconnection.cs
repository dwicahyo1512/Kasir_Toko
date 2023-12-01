using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasir_Toko
{
    internal class dbconnection
    {
        public string dbconnect()
        {
            string conn = "server=localhost;user=root;password=;database=kasir_toko";
                return conn;
        }
    }
}

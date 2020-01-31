using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Datos
    {
        
        public Datos()
        {

        }

        public void ConectarSQL(string host, string user, string pass)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            
        }
    }
}

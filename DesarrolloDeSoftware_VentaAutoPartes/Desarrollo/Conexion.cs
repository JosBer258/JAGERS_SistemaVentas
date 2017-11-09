using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Desarrollo.Properties;
using System.Windows.Forms;

namespace Desarrollo
{
    public class Conexion
    {
        public string ccnx;
        public string sql;
        public string mensaje;
        public SqlConnection cnx;
        public SqlCommand cmd;

        public Conexion()
        {
            this.ccnx = Settings.Default.VentasAutoPartesConnectionString;
            this.cnx = new SqlConnection(this.ccnx);

        }
    }
}

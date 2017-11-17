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
        public SqlDataAdapter DataAdapter;
        public DataTable dt;
        public DataRow Dr;
        public SqlDataReader DtR;
        public DataSet Dataset;
        public DataView DataView;
    


        public Conexion()
        {
            try
            {
                this.ccnx = Settings.Default.VentasAutoPartesConnectionString;
                this.cnx = new SqlConnection(this.ccnx);
            }
            catch(Exception)
            {

            }

        }

        public void Abrir()
        {
            try
            {
                cnx.Open();
            }
            catch(Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}

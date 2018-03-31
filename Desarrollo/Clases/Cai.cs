using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desarrollo.Clases
{
    class Cai:Conexion
    {
        private int var_codigoCai;
        private string var_codigo_proporcionado;
        private DateTime FechaLimite;
        private string RangoInicial;
        private string Rangofinal;
        private string Correlativo;
        private string CodigoEstado;

        public int CodigoCai
        {
            get
            {
                return var_codigoCai;
            }

            set
            {
                var_codigoCai = value;
            }
        }

        public string CodigoProporcionado
        {
            get
            {
                return var_codigo_proporcionado;
            }

            set
            {
                var_codigo_proporcionado = value;
            }
        }

        public DateTime FechaLimite1
        {
            get
            {
                return FechaLimite;
            }

            set
            {
                FechaLimite = value;
            }
        }

        public string RangoInicial1
        {
            get
            {
                return RangoInicial;
            }

            set
            {
                RangoInicial = value;
            }
        }

        public string Rangofinal1
        {
            get
            {
                return Rangofinal;
            }

            set
            {
                Rangofinal = value;
            }
        }

        public string Correlativo1
        {
            get
            {
                return Correlativo;
            }

            set
            {
                Correlativo = value;
            }
        }

        public string CodigoEstado1
        {
            get
            {
                return CodigoEstado;
            }

            set
            {
                CodigoEstado = value;
            }
        }
        public bool RevisionDeExistencia()
        {
            this.sql = string.Format(@"select * from Cai where Codigo_Estado='{0}' ",
                1);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {

                this.cnx.Close();
                return false;

            }
            else
            {
                this.cnx.Close();

                return true;
            }

        }

        public int ObtenerUltimoCodigoCai()
        {
            int Codigo = 0;
            this.sql = string.Format(@"select top 1 Codigo_Cai as CodigoFinal from Cai order by Codigo_Cai desc");
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Codigo = Convert.ToInt16((Reg["CodigoFinal"].ToString()));

            }
            else
            {

            }

            this.cnx.Close();
            return (Codigo + 1);
        }
        public bool RevisionRangos()
        {

            if (Convert.ToDouble(RangoInicial1) >= Convert.ToDouble(Rangofinal1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RevisionRangosSql()
        {
            double Codigo = 0;
            bool t = false;
            this.sql = string.Format(@"select top 1 RangoInicial as RangoPrim,
            (select top 1 RangoFinal from Cai order by RangoInicial desc) as Rangofin 
            from Cai order by RangoInicial asc ");
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {

                Codigo = Convert.ToDouble((Reg["Rangofin"].ToString()));
                if (Convert.ToDouble(RangoInicial1) <= Codigo)
                {
                    t = false;
                }
                else
                {
                    t = true;
                }
            }
            else
            {

            }

            this.cnx.Close();
            return t;
        }
        public void CargarPorCodigo(DataGridView dgv, int a)
        {

            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                double conv = Convert.ToDouble(Convert.ToInt32(a));

                double busq;
                busq = a;


                con.sql = string.Format
                (@"select A.Codigo_Cai as Codigo, A.CodigoProporcionado as Clave,A.FechaLimite as 
Fecha_Limite, A.RangoInicial as RangoInicial,A.RangoFinal as Rango_final,
A.Correlativo,B.Descripcion_Estado as Descripcion_de_Estado from Cai as A
inner join Estados as B on A.Codigo_Estado=B.Codigo_Estado where Codigo_Cai = '{0}' and Codigo_Tipo_Estado=7", busq);
                con.cmd = new SqlCommand(con.sql, con.cnx);
                con.DataAdapter = new SqlDataAdapter(con.cmd);
                con.dt = new DataTable();
                con.DataAdapter.Fill(con.dt);
                dgv.DataSource = con.dt;

            }
            catch
            {

            }
        }
        public int longitudMaximaBusqueda()
        {
            int Codigo = 0;
            this.sql = string.Format(@"Select LEN(Codigo_Cai) as MAximoValor from Cai where Codigo_Cai = (select top 1 Codigo_Cai as CodigoFinal from Cai order by Codigo_Cai desc)");
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Codigo = Convert.ToInt16((Reg["MaximoValor"].ToString()));

            }
            else
            {

            }

            this.cnx.Close();
            return Codigo;
        }
        public bool RevisionDeDatos()
        {
            this.sql = string.Format(@"select * from Cai where CodigoProporcionado='{0}' or RangoInicial='{1}' or RangoFinal='{2}'",
                CodigoProporcionado, Convert.ToDouble(RangoInicial1), Convert.ToDouble(Rangofinal1));
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {

                this.cnx.Close();
                return false;

            }
            else
            {
                this.cnx.Close();

                return true;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desarrollo.Clases
{
    class C_Mora:Conexion
    {

        public void Agregar_Mora(double porc, int esta)
        {
            Conexion Con = new Conexion();

            Con.sql = string.Format(
              @"insert into Mora 
              (Porcentaje_Mora, CodEstado_Mora) 
              values ('{0}','{1}')", porc, esta);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();
            Con.Dr = Con.dt.NewRow();
            Con.dt.Rows.InsertAt(Con.Dr, 0);

        }

        public void Modificar_Mora(int est, int cod)
        {
            Conexion Con = new Conexion();

            Con.sql = string.Format(@"update Mora set CodEstado_Mora = '{0}' where Codigo_Mora = '{1}'",  est, cod);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();
            Con.Dr = Con.dt.NewRow();
            Con.dt.Rows.InsertAt(Con.Dr, 0);
        }

        public int Nuevocodigo()
        {
            int Codigo = 0;
            this.sql = string.Format(@"select top 1 Codigo_Transaccion as CodigoFinal from Transacciones order by Codigo_Transaccion desc");
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


        public int NuevocodigoMora()
        {
            int Codigo = 0;
            this.sql = string.Format(@"select top 1 Codigo_Mora as CodigoFinal from Mora order by Codigo_Mora desc");
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

        public void tabla(int est, int ct, int cd, float m, int cc, int itp, int cm)
        {
            


            this.sql = string.Format(@"insert into Transacciones (Codigo_Estado, Codigo_Tipo_Transaccion, Codigo_Tipo_Documento,
                                     Monto, Codigo_Cliente, ID_Transacion_Padre, Codigo_Mora,Fecha) 
                                     values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}',  getdate())",
                                  est, ct, cd, m, cc, itp, cm);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            this.cnx.Close();


            


        }
    }
}

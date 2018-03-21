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
    class C_Mora : Conexion
    {
        private string var_CodTran;
        private string var_CodDocumt;
        private string var_CodCliente;
        private float var_ValorRes;
        private float var_MontoTotal;

        public string Var_CodTran
        {
            get
            {
                return var_CodTran;
            }

            set
            {
                var_CodTran = value;
            }
        }

        public string Var_CodDocumt
        {
            get
            {
                return var_CodDocumt;
            }

            set
            {
                var_CodDocumt = value;
            }
        }

        public string Var_CodCliente
        {
            get
            {
                return var_CodCliente;
            }

            set
            {
                var_CodCliente = value;
            }
        }

        public float Var_ValorRes
        {
            get
            {
                return var_ValorRes;
            }

            set
            {
                var_ValorRes = value;
            }
        }

        public float Var_MontoTotal
        {
            get
            {
                return var_MontoTotal;
            }

            set
            {
                var_MontoTotal = value;
            }
        }

        public void Fun_Agregar_Mora(double porc, int esta)
        {
            Conexion Con = new Conexion();

            Con.sql = string.Format(
              @"insert into Mora 
              (Porcentaje_Mora, CodEstado_Mora) 
              values ('{0}','{1}')", porc, esta);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Regi = null;
            Regi = this.cmd.ExecuteReader();
            this.cnx.Close();

        }

        public void Modificar_Mora(int est, int cod)
        {
            sql = string.Format(@"update Mora set CodEstado_Mora = '{0}' where Codigo_Mora = '{1}'",  est, cod);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Regi = null;
            Regi = this.cmd.ExecuteReader();
            this.cnx.Close();
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

        public float Fun_ExtraerSatosUtiles(TextBox FV_MontActual, int FV_NumeroDocum)
        {
            float FV_Porcentaje=0;

            this.sql = string.Format(@"select A.ValResd as 'Residual', B.Porcentaje_Mora as 'Mora', A.Codigo_Cliente as 'CodCliente' 
                                     from Transacciones as A inner join Mora as B on A.Codigo_Mora= B.Codigo_Mora
                                        where	A.Codigo_Transaccion = '{0}'", FV_NumeroDocum);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                FV_MontActual.Text = (Reg["Residual"].ToString());
                FV_Porcentaje = (float) Convert.ToDouble(Reg["Mora"].ToString());
                Var_CodCliente= (Reg["CodCliente"].ToString());
            }
            else
            {

            }

            this.cnx.Close();
            return FV_Porcentaje;
        }

        public bool Fun_VerExisDetalles()
        {
            bool L_Respuesta = false;

            this.sql = string.Format(@"select * from Transaccion_Detalles as A inner join Transacciones as B
            on A.TranCod=B.Codigo_Transaccion where A.TranCod='{0}' and B.Numero_Documento='{1}'", Var_CodTran, Var_CodDocumt);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                L_Respuesta=true;
            }
            else
            {

            }

            this.cnx.Close();
            return L_Respuesta;
        }
        
        public void Fun_MosNumDetalles(TextBox FV_NuMora)
        {
            this.sql = string.Format(@"select COUNT(TranCod) as 'Suma' 
                                        from Transaccion_Detalles where TranCod='{0}';", Var_CodTran);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                FV_NuMora.Text=(Reg["Suma"].ToString());
            }
            else
            {

            }

            this.cnx.Close();
        }


        public string Fun_MosFechDetalles()
        {
            string L_Fecha = "";

            this.sql = string.Format(@"select top 1 TranDetCod, FechaReal from Transaccion_Detalles 
                                       where TranCod='{0}' order by TranDetCod desc", Var_CodTran);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                L_Fecha = (Reg["FechaReal"].ToString());
            }
            else
            {

            }

            this.cnx.Close();

            return L_Fecha;
        }



        public void Fun_UpdateCreditoCliente()
        {
            

            sql = string.Format(
              @"update Creditos set Codigo_Estado = 2 where Codigo_Credito= 
                (select Codigo_Credito from Clientes where Codigo_Cliente='{0}')", Var_CodCliente);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Regi = null;
            Regi = this.cmd.ExecuteReader();
            this.cnx.Close();

        }

        public void Fun_UpdateTran()
        {
            sql = string.Format(
              @"update Transacciones set ValResd = '{0}' where Codigo_Transaccion='{1}'", Var_ValorRes, Var_CodTran);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Regi = null;
            Regi = this.cmd.ExecuteReader();
            this.cnx.Close();

        }


        public void Fun_InsertarDetalles()
        {
            sql = string.Format(
              @"insert into Transaccion_Detalles(TranCod, Monto, CodTipoAccion,FechaReal ) 
                values('{0}','{1}',2,GETDATE())",  Var_CodTran, Var_MontoTotal);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Regi = null;
            Regi = this.cmd.ExecuteReader();
            this.cnx.Close();

        }

    }
}

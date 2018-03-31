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
    class N_Ventas:Conexion
    {
        public bool verificacionRangoFinalyCorrelativo()/*este es para verificar si el 
            correlativo y rangofinal son iguales*/
        {

            bool Final = false;
            this.sql = string.Format(@"select RangoFinal, Correlativo  from Cai where Codigo_Estado=1");
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {

                if (Convert.ToDouble((Reg["RangoFinal"].ToString())) == Convert.ToDouble((Reg["Correlativo"].ToString())))
                {

                    Final = false;

                }
                else
                {
                    Final = true;

                }
            }
            else
            {

            }

            this.cnx.Close();


            return Final;
        }
        public void cambioEstadoIgualdadCorrelativoyRangoFinal()/*este es para cambiar el estado a desactivado
            una vez que el rango final y el correlativo sean iguales*/
        {

            this.sql = string.Format(@"update Cai set Codigo_Estado =2  where Codigo_Estado=1");
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            if (Reg.Read())
            {


                this.cnx.Close();

            }
            else
            {

            }

            this.cnx.Close();




        }

        public bool verificacionVencimientoFecha()//este es para ingreso de sistema
        {
            DateTime Codigo;
            bool Final = false;
            this.sql = string.Format(@"select FechaLimite  from Cai where Codigo_Estado=1");
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Codigo = Convert.ToDateTime((Reg["FechaLimite"].ToString())).Date;
                if (Codigo < DateTime.Now.Date)
                {
                    Final = false;

                }
                else
                {
                    Final = true;

                }
            }
            else
            {

            }

            this.cnx.Close();


            return Final;
        }
        public bool verificacionCodigoCaiEstado()
        {

            bool Final = false;
            this.sql = string.Format(@"select * from Cai where Codigo_Estado=1");
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Final = true;
            }
            else
            {
                Final = false;
            }

            this.cnx.Close();

            return Final;

        }

        public string ObtenerCodigocai()
        {
            string Codigo = "";

            this.sql = string.Format(@"select *  from Cai where Codigo_Estado=1");
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Codigo = ((Reg["CodigoProporcionado"].ToString()));

            }
            else
            {

            }

            this.cnx.Close();


            return Codigo;
        }


        public double ObtenerNumeroFactura()
        {
            double Codigo = 0;
            double Final = 0;
            this.sql = string.Format(@"select *  from Cai where Codigo_Estado=1");
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Codigo = Convert.ToDouble((Reg["Correlativo"].ToString()));

            }
            else
            {

            }

            this.cnx.Close();
            Final = CorrelativoAnalisis(Codigo);

            return Final;
        }
        private double CorrelativoAnalisis(double a)
        {
            double b = 0;
            int a2 = (int)a;
            switch (a2)
            {

                case 0:

                    this.sql = string.Format(@"select RangoInicial from Cai where Codigo_Estado=1");
                    this.cmd = new SqlCommand(this.sql, this.cnx);
                    this.cnx.Open();
                    SqlDataReader Reg = null;
                    Reg = this.cmd.ExecuteReader();

                    if (Reg.Read())
                    {
                        b = Convert.ToDouble((Reg["RangoInicial"].ToString()));

                    }
                    else
                    {

                    }
                    this.cnx.Close();
                    return b;
                    break;
                default:
                    this.sql = string.Format(@"select Correlativo from Cai where Codigo_Estado=1");
                    this.cmd = new SqlCommand(this.sql, this.cnx);
                    this.cnx.Open();
                    SqlDataReader Regi = null;
                    Regi = this.cmd.ExecuteReader();

                    if (Regi.Read())
                    {
                        b = Convert.ToDouble((Regi["Correlativo"].ToString())) + 1;

                    }
                    else
                    {

                    }
                    this.cnx.Close();
                    return b;
                    break;

            }
        }


        ///IMPUESTOS
        public void VerificarImpuestosNuevos(string Fecha)
        {
            this.sql = string.Format(@"select * from Impuesto where Fecha_Iniciacion ='{0}' and Codigo_Estado=3", Fecha);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                this.cnx.Close();
                UpdateImpuestos(Fecha);

            }
            this.cnx.Close();
        }

        public void UpdateImpuestos(string Fecha)
        {
            this.sql = string.Format(@"update Impuesto set Codigo_Estado=2 where Codigo_Estado=1 and Fecha_Iniciacion <'{0}';update Impuesto set Codigo_Estado=1 where Codigo_Estado=3 and Fecha_Iniciacion ='{0}';", Fecha);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }

        public double OptenerImpuesto()
        {
            double Impuesto = 0;
            this.sql = string.Format(@"select Top 1 Codigo_Impuesto , PorcentajeImpuesto as 'Imp' from Impuesto where Codigo_Estado=1 order by Codigo_Impuesto");
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {

                Impuesto = Convert.ToDouble((Reg["Imp"].ToString()));

            }
            this.cnx.Close();
            return Impuesto;
        }

        public void Fun_ExtraerLocalidades(ComboBox RolBox)
        {
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select Cod_Localidad, Nombre from Localidad");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();

            RolBox.ValueMember = "Cod_Localidad";
            RolBox.DisplayMember = "Nombre";
            RolBox.DataSource = Con.dt;
        }

        public int Var_OptenerCodigoCliente_PersonaAutorizada(int C_PersonaAutorizada)
        {
            int Co=0;
            this.sql = string.Format(@"select D.Codigo_Cliente as C_P from Clientes as C inner join PersonasAutorizadas as D on C.Codigo_Cliente=D.Codigo_Cliente
                                        where D.Codigo_PersonasAutorizadas='{0}'", C_PersonaAutorizada);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {

                Co = Convert.ToInt32((Reg["C_P"].ToString()));

            }
            this.cnx.Close();
            return Co;
        }

        public double Var_OptenerCredito(int CodigoDel_Cliente)
        {
            double Monto = 0;

            this.sql = string.Format(@"select  B.Saldo_Actual as Monto from Clientes as A inner join Creditos as B on A.Codigo_Credito=B.Codigo_Credito
                                       where  B.Codigo_Estado=1 and A.Codigo_Cliente='{0}'", CodigoDel_Cliente);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            
            if (Reg.Read())
            {

                Monto = Convert.ToDouble((Reg["Monto"].ToString()));

            }
            this.cnx.Close();

            return Monto;
        }


        ////
        public string Fun_ExtraerTotales(DateTimePicker Date, int CodEmp, int TipoTransaccion)
        {
            string Total="0";
            string Fecha_R = String.Format("{0:yyyy-MM-dd}", Date.Value);


            this.sql = string.Format(@"select sum(CAST(A.Monto as decimal(12,2))) as 
                                       'Monto Total' from Transacciones as A inner Join 
                                        Facturas as B on A.Numero_Documento=B.Cod_Factura   
                                        where B.Codigo_Empleado='{0}' and A.Fecha = '2017-12-09' and 
                                        A.Codigo_Tipo_Transaccion ='{1}'", CodEmp,  TipoTransaccion );
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {

                Total = (Reg["Monto Total"].ToString());

            }
            this.cnx.Close();

            return Total;
        }

        public bool Fun_ComprobarUsuarioYContraseña(string Cod, string Contraseña)
        {
            bool Verificacion = false;

            this.sql = string.Format(@"select * from Empleados where Contraseña = '{0}' and Codigo_Empleado = '{1}'", Contraseña, Cod);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {

                Verificacion = true;

            }
            this.cnx.Close();

            return Verificacion;
        }

        public bool Fun_ActuaizacionYCierreCaja(float CreditoFianl, float EfectivoFinal, float TarjetaFinal, float TotalCaja, int Codigo_Emp)
        {
            bool Verificacion = false;

            this.sql = string.Format(@"update Arqueo_Detalles 
                                        set CreditoFinal ='{0}', EfectivoFinal='{1}', EstadoFinal='1',
                                        TarjetaFinal='{2}', MontoCajaFinal='{3}' where Cod_Empleado='{4}' and Cod_Arqueo=
                                        (select top 1 Codigo_Arqueo from Arqueo order by Codigo_Arqueo desc)",
                                         CreditoFianl, EfectivoFinal, TarjetaFinal,TotalCaja, Codigo_Emp);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {

                Verificacion = true;

            }
            this.cnx.Close();

            return Verificacion;
        }

        //public bool Fun_ReconocerEstadoDeCaja
    }
}

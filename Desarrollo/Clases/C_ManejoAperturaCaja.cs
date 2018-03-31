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
    class C_ManejoAperturaCaja: Conexion
    {

        public void Fun_ExtraerCodigosEmpleadosPorLocalidad(ComboBox RolBox, Double CodL)
        {
            int Co = (int)CodL;

            cnx.Open();
            sql = string.Format(@"select Codigo_Empleado from Empleados where Cod_Localidad='{0}' and Codigo_Rol='2'", Co);
            cmd = new SqlCommand(sql, cnx);
            DataAdapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            cnx.Close();

            RolBox.ValueMember = "Codigo_Empleado";
            RolBox.DisplayMember = "Codigo_Empleado";
            RolBox.DataSource = dt;
            
        }


        public void Fun_OptenerNombreEmpleado(int CodEmp, TextBox NombreEmpleado)
        {
            sql = string.Format(@"select ([Nombre] + space(2) + [Apellido]) as 'Empleado' from Empleados where Codigo_Empleado='{0}'", CodEmp);
            cmd = new SqlCommand(sql, cnx);
            cnx.Open();
            SqlDataReader Reg = null;
            Reg = cmd.ExecuteReader();

            if (Reg.Read())
            { NombreEmpleado.Text = (Reg["Empleado"].ToString());}
            else{} cnx.Close();

        }


        public void Fun_ExtraerEstadosEmpleadosVerificacionApertura(ComboBox RolBox)
        {         
            cnx.Open();
            sql = string.Format(@"select Codigo_Estado, Descripcion_Estado from Estados where Codigo_Tipo_Estado=27");
            cmd = new SqlCommand(sql, cnx);
            DataAdapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            cnx.Close();

            RolBox.ValueMember = "Codigo_Estado";
            RolBox.DisplayMember = "Descripcion_Estado";
            RolBox.DataSource = dt;
        }


        public bool VerificarArqueo(DateTimePicker FechaActual)
        {
            bool Resp = false;
            string Fecha_R = String.Format("{0:yyyy-MM-dd}", FechaActual.Value);

            sql = string.Format(@"select * from Arqueo where Fecha_Realizacion='{0}'", Fecha_R);
            cmd = new SqlCommand(sql, cnx);
            cnx.Open();

            SqlDataReader Reg = null;
            Reg = cmd.ExecuteReader();

            if (Reg.Read())
            {
                Resp = true;
            }
            else
            {

            }

            cnx.Close();
            return Resp;
        }


        public void IngresoDatos(DateTimePicker FechaApertura, string NombreEncargado)
        {

            string Fecha_R = String.Format("{0:yyyy-MM-dd}", FechaApertura.Value);

            sql = string.Format(@"insert into Arqueo values ('{0}', '{1}',1)", Fecha_R, NombreEncargado);

            cmd = new SqlCommand(sql, cnx);
            cnx.Open();
            SqlDataReader Reg = null;
            Reg = cmd.ExecuteReader();
            cnx.Close();
        }


        public void ActualizarMonto(int Cod, int Estado, double Mont)
        {
            float Monto = (float)Mont;
            int Codigo = Cod;

            sql = string.Format(@"update Arqueo_Detalles set MontoInicial = '{0}', EstadoInicial='{1}' where Cod_Arqueo=
            (select Top 1 Codigo_Arqueo from Arqueo order by Codigo_Arqueo desc) and Cod_Empleado={2} ", Monto, Estado, Codigo);

            cmd = new SqlCommand(sql, cnx);
            cnx.Open();
            SqlDataReader Reg = null;
            Reg = cmd.ExecuteReader();
            cnx.Close();
        }


        public void FuncionMostrarData(DataGridView dgv, DateTimePicker FechaDateTime)
        {
            cnx.Open();
            try
            {
                string busq = String.Format("{0:yyyy-MM-dd}", FechaDateTime.Value);



                sql = string.Format
                (@"select A.Cod_Empleado as Codigo, (B.Nombre + ' ' + B.Apellido) as 'Empleado', 
                    CAST(A.MontoInicial as decimal(10,2)) as 'Monto de Apertura de Caja', 
					A.EstadoInicial as 'Codigo del Estado Inicial', 
                    (select AE.Descripcion_Estado from Estados as AE where
                    AE.Descripcion_Estado like '%Apertura%' and AE.Codigo_Estado=A.EstadoInicial) as 'Estado de Apertura'
                    ,CAST(A.MontoCajaFinal as decimal(10,2)) as 'Monto Total en Caja'
                    , CAST(A.CreditoFinal as decimal(10,2)) as 'Monto de Credito Final', 
                    CAST(A.EfectivoFinal as decimal(10,2)) as 'Monto total en efectivo', 
                    CAST(A.TarjetaFinal as decimal(10,2)) as 'Monto de Tarjeta Final', 
                    (select AE.Descripcion_Estado from Estados as AE where AE.Descripcion_Estado 
                    like '%Cierre%' and AE.Codigo_Estado=A.EstadoFinal) as 'Estado de Cierre'
                    from Arqueo_Detalles as A inner join Empleados as B on A.Cod_Empleado=B.Codigo_Empleado
                     inner join Arqueo as D on D.Codigo_Arqueo = A.Cod_Arqueo
                   where D.Fecha_Realizacion= '{0}'", busq);
                cmd = new SqlCommand(sql, cnx);
                DataAdapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dgv.DataSource = dt;

            }
            catch
            {

            }
            cnx.Close();
        }

        
        public void IngresoDetalles(float Monto, int Cod)
        {

            sql = string.Format(@"insert into [dbo].[Arqueo_Detalles] ([Cod_Arqueo],[Cod_Empleado],[MontoInicial],[EstadoInicial],  EstadoFinal)
                                      values
                                      ((select TOP 1 Codigo_Arqueo from Arqueo order by Codigo_Arqueo desc), '{0}','{1}',2, 3)", Cod, Monto);

            cmd = new SqlCommand(sql, cnx);
            cnx.Open();
            SqlDataReader Reg = null;
            Reg = cmd.ExecuteReader();
            cnx.Close();
        }


        public void Fun_ShowArquSinFil(DataGridView dgv)
        {
            cnx.Open();
            try
            {
                sql = string.Format
                (@"select Codigo_Arqueo as 'Codigo', Fecha_Realizacion as 'Fecha de Realizacion', NombreEncargado as 'Nombre del Encargado', (select B.Descripcion_Estado from Estados as B where A.Estado_Caja = B.Codigo_Estado and B.Descripcion_Estado like '%Caja%') as 'Estado'  from Arqueo as A");
                cmd = new SqlCommand(sql, cnx);
                DataAdapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dgv.DataSource = dt;

            }
            catch
            {

            }
            cnx.Close();
        }


        public int Fun_MosArq_FechaMaximaAño()
        {
            int AMaximo = 0;
            this.sql = string.Format(@" select Top 1 YEAR(Fecha_Realizacion) as 'MaximoAños' from Arqueo  order by Fecha_Realizacion desc");
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                AMaximo = Convert.ToInt16((Reg["MaximoAños"].ToString()));

            }
            else
            {

            }

            this.cnx.Close();
            return AMaximo;
        }


        public int Fun_MosArq_FechaMinimaAño()
        {

            int AMinimo = 0;
            this.sql = string.Format(@" select Top 1 YEAR(Fecha_Realizacion) as 'Minimo' from Arqueo  order by Fecha_Realizacion asc");
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                AMinimo = Convert.ToInt16((Reg["Minimo"].ToString()));

            }
            else
            {

            }

            this.cnx.Close();
            return AMinimo;
        }


        public void Fun_PonerAños(ComboBox ComboAños)
        {
            for(int i = Fun_MosArq_FechaMinimaAño(); i <= Fun_MosArq_FechaMaximaAño(); i++)
            {
                ComboAños.Items.Add(i);
            }
        }


        public void Fun_ShwPorFiltro(DataGridView dgv, int ATiempo, int AMes)
        {
            int MesMasUno= AMes + 1;

            cnx.Open();
            try
            {
                sql = string.Format
                (@"select Codigo_Arqueo as 'Codigo', Fecha_Realizacion as 'Fecha de Realizacion', 
                  NombreEncargado as 'Nombre del Encargado', (select B.Descripcion_Estado from Estados as B 
                  where A.Estado_Caja = B.Codigo_Estado and B.Descripcion_Estado like '%Caja%') as 'Estado'  
                  from Arqueo as A
                  where YEAR(Fecha_Realizacion)='{0}' and MONTH(Fecha_Realizacion)='{1}'", ATiempo, MesMasUno);
                cmd = new SqlCommand(sql, cnx);
                DataAdapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dgv.DataSource = dt;

            }
            catch
            {

            }
            cnx.Close();
        }


        public void Fun_LlenarDetalles(DataGridView dgv, int CodigoArqueo)
        {
           
            cnx.Open();
            try
            {
                sql = string.Format
                (@"select A.Cod_Empleado as Codigo, (B.Nombre + ' ' + B.Apellido) as 'Empleado', 
                    CAST(A.MontoInicial as decimal(10,2)) as 'Monto de Apertura de Caja', 
					A.EstadoInicial as 'Codigo del Estado Inicial', 
                    (select AE.Descripcion_Estado from Estados as AE where
                    AE.Descripcion_Estado like '%Apertura%' and AE.Codigo_Estado=A.EstadoInicial) as 'Estado de Apertura'
                    ,CAST(A.MontoCajaFinal as decimal(10,2)) as 'Monto Total en Caja'
                    , CAST(A.CreditoFinal as decimal(10,2)) as 'Monto de Credito Final', 
                    CAST(A.EfectivoFinal as decimal(10,2)) as 'Monto total en efectivo', 
                    CAST(A.TarjetaFinal as decimal(10,2)) as 'Monto de Tarjeta Final', 
                    (select AE.Descripcion_Estado from Estados as AE where AE.Descripcion_Estado 
                    like '%Cierre%' and AE.Codigo_Estado=A.EstadoFinal) as 'Estado de Cierre'
                    from Arqueo_Detalles as A inner join Empleados as B on A.Cod_Empleado=B.Codigo_Empleado
                    where A.Cod_Arqueo='{0}'", CodigoArqueo);
                cmd = new SqlCommand(sql, cnx);
                DataAdapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dgv.DataSource = dt;

            }
            catch
            {

            }
            cnx.Close();
        }


        public bool Fun_VerExistenciaApertAnteri(DateTimePicker Date)
        {
            bool Existencia = false;
            string FechaActual=String.Format("{0:yyyy-MM-dd}", Date.Value);
            this.sql = string.Format(@"select top 1 Codigo_Arqueo, 
                                        NombreEncargado from Arqueo where Fecha_Realizacion != '{0}' and Estado_Caja = 1
                                        order by Codigo_Arqueo desc", FechaActual);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Existencia = true;

            }
            else
            {

            }

            this.cnx.Close();
            return Existencia;
        }


        public void Fun_LlenarDetallesCasoDeApertAntExistente(DataGridView dgv)
        {

            cnx.Open();
            try
            {
                sql = string.Format
                (@"select A.Cod_Empleado as Codigo, (B.Nombre + ' ' + B.Apellido) as 'Empleado', 
                    CAST(A.MontoInicial as decimal(10,2)) as 'Monto de Apertura de Caja', 
					A.EstadoInicial as 'Codigo del Estado Inicial', 
                    (select AE.Descripcion_Estado from Estados as AE where
                    AE.Descripcion_Estado like '%Apertura%' and AE.Codigo_Estado=A.EstadoInicial) as 'Estado de Apertura'
                    ,CAST(A.MontoCajaFinal as decimal(10,2)) as 'Monto Total en Caja'
                    , CAST(A.CreditoFinal as decimal(10,2)) as 'Monto de Credito Final', 
                    CAST(A.EfectivoFinal as decimal(10,2)) as 'Monto total en efectivo',
                    CAST(A.TarjetaFinal as decimal(10,2)) as 'Monto de Tarjeta Final', 
                    (select AE.Descripcion_Estado from Estados as AE where AE.Descripcion_Estado 
                    like '%Cierre%' and AE.Codigo_Estado=A.EstadoFinal) as 'Estado de Cierre'
                    from Arqueo_Detalles as A inner join Empleados as B on A.Cod_Empleado=B.Codigo_Empleado
                    where A.Cod_Arqueo= (select top 1 B.Codigo_Arqueo from Arqueo as B where 
                    B.Fecha_Realizacion != getdate() and Estado_Caja = 1
                    order by Codigo_Arqueo  desc)");
                cmd = new SqlCommand(sql, cnx);
                DataAdapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dgv.DataSource = dt;

            }
            catch
            {

            }
            cnx.Close();
        }


        public void Fun_ForzarCierre(DateTimePicker Date)
        {
            
            string FechaActual = String.Format("{0:yyyy-MM-dd}", Date.Value);

            sql = string.Format(@"update Arqueo 
                                set Estado_Caja = 2 where Codigo_Arqueo = (select top 1 B.Codigo_Arqueo from Arqueo as B where 
                                B.Fecha_Realizacion != '{0}' and Estado_Caja = 1 order by Codigo_Arqueo  desc)", FechaActual);

            cmd = new SqlCommand(sql, cnx);
            cnx.Open();
            SqlDataReader Reg = null;
            Reg = cmd.ExecuteReader();
            cnx.Close();
            MessageBox.Show("Cierre Realizado", "Confirmación de Cierre");
        }


        public bool Fun_VerificarCierrePorDet(DateTimePicker Date)
        {
            bool Existencia = false;
            string FechaActual = String.Format("{0:yyyy-MM-dd}", Date.Value);
            this.sql = string.Format(@"select * from Arqueo_Detalles as B inner join Arqueo  as A on A.Codigo_Arqueo = B.Cod_Arqueo 
                                        where A.Fecha_Realizacion ='{0}' and B.EstadoFinal = 2", FechaActual);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Existencia = true;

            }
            else
            {

            }

            this.cnx.Close();

            return Existencia;
        }

        public void Fun_CierreCaja(DateTimePicker Date)
        {
            string FechaActual = String.Format("{0:yyyy-MM-dd}", Date.Value);

            sql = string.Format(@"update Arqueo 
                                set Estado_Caja = 2 where Codigo_Arqueo = (select top 1 B.Codigo_Arqueo from Arqueo as B where 
                                B.Fecha_Realizacion = '{0}' and Estado_Caja = 1 order by Codigo_Arqueo  desc)", FechaActual);

            cmd = new SqlCommand(sql, cnx);
            cnx.Open();
            SqlDataReader Reg = null;
            Reg = cmd.ExecuteReader();
            cnx.Close();
            MessageBox.Show("Cierre Realizado", "Confirmación de Cierre");
        }



        public bool VerificacionDeCajaCerrada(DateTimePicker Date)
        {

            bool VerificacionDeCajaCerrada = false;
            string FechaActual = String.Format("{0:yyyy-MM-dd}", Date.Value);

            this.sql = string.Format(@"select * from Arqueo where Fecha_Realizacion = '{0}' and Estado_Caja= 2", FechaActual);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                VerificacionDeCajaCerrada = true;

            }
            else
            {

            }

            this.cnx.Close();

            return VerificacionDeCajaCerrada;
        }
    }



}

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
    class C_Credito:Conexion
    {
        private string var_filtro_info_cliente;
        private int var_filtro_cod_client;
        private float var_aumento_saldo_credit;
        private float var_resid_actual;
        private int var_numero_documento;

        private int var_cod_transaccion;
        private int var_cod_accion;
        private string var_nom_clien_trans_gener;
        

        public string Var_filtrocliente
        {
            get
            {
                return var_filtro_info_cliente;
            }

            set
            {
                var_filtro_info_cliente = value;
            }
        }

        public int Var_filtro_cod_client
        {
            get
            {
                return var_filtro_cod_client;
            }

            set
            {
                var_filtro_cod_client = value;
            }
        }

        public float Var_aumento_saldo_credit
        {
            get
            {
                return var_aumento_saldo_credit;
            }

            set
            {
                var_aumento_saldo_credit = value;
            }
        }

        public float Var_resid_actual
        {
            get
            {
                return var_resid_actual;
            }

            set
            {
                var_resid_actual = value;
            }
        }

        public int Var_numero_documento
        {
            get
            {
                return var_numero_documento;
            }

            set
            {
                var_numero_documento = value;
            }
        }

        public int Var_cod_transaccion
        {
            get
            {
                return var_cod_transaccion;
            }

            set
            {
                var_cod_transaccion = value;
            }
        }

        public int Var_cod_accion
        {
            get
            {
                return var_cod_accion;
            }

            set
            {
                var_cod_accion = value;
            }
        }

        public string Var_clien_trans_gener
        {
            get
            {
                return var_nom_clien_trans_gener;
            }

            set
            {
                var_nom_clien_trans_gener = value;
            }
        }

        public void Fun_MostrarTiposPago(ComboBox L_CombPago)
        {
            cnx.Open();
            sql = string.Format(@"select Cod_TipoDetalles, Descripcion from 
                                Transaccion_Tipo_Accion where Descripcion != 'Cargo'");
            cmd = new SqlCommand(sql, cnx);
            DataAdapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            cnx.Close();

            L_CombPago.ValueMember = "Cod_TipoDetalles";
            L_CombPago.DisplayMember = "Descripcion";
            L_CombPago.DataSource = dt;
        }



        public void Fun_MostrarCliente(ComboBox L_MostrarCliente)
        {
            cnx.Open();
            sql = string.Format(@"select Codigo_Cliente,  (CAST( ID as nvarchar) + ' ' + Nombre + ' ' + Apellido ) 
                                    as 'NombreCliente' from Clientes
                                    where (CAST( ID as nvarchar) + ' ' + Nombre + ' ' + Apellido ) 
                                    like '%{0}%'", Var_filtrocliente);
            cmd = new SqlCommand(sql, cnx);
            DataAdapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            cnx.Close();

            L_MostrarCliente.ValueMember = "Codigo_Cliente";
            L_MostrarCliente.DisplayMember = "NombreCliente";
            L_MostrarCliente.DataSource = dt;
        }

        public void Fun_MostrarCreditos(DataGridView Dvg_Creditos)
        {
            cnx.Open();

            sql = string.Format
            (@" select   A.Codigo_Transaccion as 'Codigo', A.Numero_Documento as 'No. de Factura', 
            (select B.Descripcion_Estado  from Estados as B where B.Codigo_Estado=A.Codigo_Estado and B.Descripcion_Estado like '%Transaccion%') as 'Estado',
            A.Fecha as 'Fecha de emision', A.Fecha_Vencimiento as 'Fecha de Vencimiento', A.Monto as 'Monto Original', 
            A.ValResd as 'Monto Actual', ('%' + CAST((CAST((Select C.Porcentaje_Mora from Mora as C where C.Codigo_Mora=A.Codigo_Mora) as float)*100) as NVARCHAR)) as 'Porcentaje de Mora'
            from Transacciones as A
            WHERE A.Codigo_Tipo_Transaccion=1 and A.Codigo_Cliente= '{0}' and A.Codigo_Estado = 2 ", Var_filtro_cod_client);
            cmd = new SqlCommand(sql, cnx);
            DataAdapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            Dvg_Creditos.DataSource = dt;
            cnx.Close();
        }

        public void Fun_UpdateSaldoCredit()
        {
            this.sql = string.Format(@"update Creditos set Saldo_Actual = Saldo_Actual + {0}
            where Codigo_Credito = (select Codigo_Credito from Clientes where Codigo_Cliente='{1}')",
            Var_aumento_saldo_credit, Var_filtro_cod_client);
            this.cmd = new SqlCommand(this.sql, this.cnx);

            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }


        public void Fun_UpdateTransaccionValRes()
        {
            this.sql = string.Format(@"update Transacciones set ValResd = '{0}' where Numero_Documento='{1}'", Var_resid_actual, Var_numero_documento);
            
            this.cmd = new SqlCommand(this.sql, this.cnx);

            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }


        public void Fun_InsertarDetalles()
        {
            this.sql = string.Format(@"insert into Transaccion_Detalles([TranCod],[Monto],[CodTipoAccion],[FechaReal]) values ('{0}','{1}','{2}',GETDATE())", 
                Var_cod_transaccion, Var_aumento_saldo_credit, Var_cod_accion);

            this.cmd = new SqlCommand(this.sql, this.cnx);

            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }


        public void Fun_UpdateEstadoTransaccion()
        {
            this.sql = string.Format(@"update Transacciones set Codigo_Estado = '1' where Codigo_Transaccion ='{0}'", Var_cod_transaccion);

            this.cmd = new SqlCommand(this.sql, this.cnx);

            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }


        public void Fun_ExtraerTransacciones(DataGridView LDGV_Transacciones)
        {

            cnx.Open();
            try
            {
                sql = string.Format
                (@"select A.Codigo_Transaccion as [Código de Transacción], A.Numero_Documento as [No. de Documento], B.Descripcion as [Tipo de Transacción],
	                C.Descripcion as [Tipo de Documentación], A.Fecha as [Fecha de Realización], A.Monto as [Monto Total],
	                D.Nombre +space(2)+ D.Apellido as [Nombre del Cliente], A.Fecha_Vencimiento as [Fecha de Vencimiento],	               
	                ('%' + CAST(( E.[Porcentaje_Mora]* 100) as nvarchar)) as [Porcentaje de Mora],
                    (Select F.Descripcion_Estado from Estados as F where F.Codigo_Estado=A.Codigo_Estado and F.Descripcion_Estado like '%Transac%')
                     as 'Estados' FROM [dbo].[Transacciones] as A
                     inner join [dbo].[Tipo_Transaccion] as B on A.Codigo_Tipo_Transaccion = B.Codigo_TipoTransaccion
                    inner join [dbo].[Tipos_Documentos] as C on A.Codigo_Tipo_Documento = C.Codigo_TipoDeDocumento
                    left join [dbo].[Clientes] as D on A.Codigo_Cliente = D.Codigo_Cliente left join [dbo].[Mora] as E
                    on A.Codigo_Mora = E.Codigo_Mora
	                where (A.Codigo_Estado='4' or A.Codigo_Estado='2')and A.Codigo_Tipo_Documento='2' and A.Codigo_Tipo_Transaccion='1'
			        and DATEDIFF(DAY, A.Fecha_Vencimiento, GETDATE())>30");
                cmd = new SqlCommand(sql, cnx);
                DataAdapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                LDGV_Transacciones.DataSource = dt;

                cnx.Close();

            }
            catch
            {

            }
        }



            public void Fun_ExtraerTransaccionesClientes(DataGridView LDGV_Transacciones)
        {

            cnx.Open();
            try
            {
                sql = string.Format
                (@"select A.Codigo_Transaccion as [Código de Transacción], A.Numero_Documento as [No. de Documento], B.Descripcion as [Tipo de Transacción],
	                C.Descripcion as [Tipo de Documentación], A.Fecha as [Fecha de Realización], A.Monto as [Monto Total],
	                D.Nombre +space(2)+ D.Apellido as [Nombre del Cliente], A.Fecha_Vencimiento as [Fecha de Vencimiento],	               
	                ('%' + CAST(( E.[Porcentaje_Mora]* 100) as nvarchar)) as [Porcentaje de Mora],
                    (Select F.Descripcion_Estado from Estados as F where F.Codigo_Estado=A.Codigo_Estado and F.Descripcion_Estado like '%Transac%')
                     as 'Estados' FROM [dbo].[Transacciones] as A
                     inner join [dbo].[Tipo_Transaccion] as B on A.Codigo_Tipo_Transaccion = B.Codigo_TipoTransaccion
                    inner join [dbo].[Tipos_Documentos] as C on A.Codigo_Tipo_Documento = C.Codigo_TipoDeDocumento
                    left join [dbo].[Clientes] as D on A.Codigo_Cliente = D.Codigo_Cliente left join [dbo].[Mora] as E
                    on A.Codigo_Mora = E.Codigo_Mora
	                where A.Codigo_Estado !='3' and A.Codigo_Tipo_Documento='2' and A.Codigo_Tipo_Transaccion='1'
			        and (CAST( D.ID as nvarchar) + ' ' + D.Nombre + ' ' + D.Apellido ) like '%{0}%'", Var_clien_trans_gener);
                cmd = new SqlCommand(sql, cnx);
                DataAdapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                LDGV_Transacciones.DataSource = dt;

                cnx.Close();

            }
            catch
            {

            }

        }



        public void Fun_ExtraerDetallesTran(DataGridView LDGV_Transacciones, int FVL_CodTrans)
        {

            cnx.Open();
            try
            {
                sql = string.Format
                (@"select A.Monto as 'Monto Operado', B.Descripcion as 'Accion', A.FechaReal as 'Fecha de realizacion' from Transaccion_Detalles as A inner join Transaccion_Tipo_Accion as B 
                    on A.CodTipoAccion=B.Cod_TipoDetalles where A.TranCod='{0}'", FVL_CodTrans);
                cmd = new SqlCommand(sql, cnx);
                DataAdapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                LDGV_Transacciones.DataSource = dt;

                cnx.Close();

            }
            catch
            {

            }

        }
    }
}

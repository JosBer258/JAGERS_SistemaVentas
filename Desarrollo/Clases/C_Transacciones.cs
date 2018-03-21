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
    class C_Transacciones : Conexion
    {
 
        public int Fun_UltimoDocumento()
        {
            int NuevoCodigo = 0;

            this.sql = string.Format(@"select	Top 1 Codigo_TipoDeDocumento as CodigoFinal from Tipos_Documentos order by Codigo_TipoDeDocumento desc");
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                NuevoCodigo = Convert.ToInt32((Reg["CodigoFinal"].ToString()));

            }
            else
            {

            }

            this.cnx.Close();

            return (NuevoCodigo + 1);
        }

        public int Fun_UnltimoTransaccion()
        {
            int NuevoCodigo = 0;

            this.sql = string.Format(@"select  Top 1 Codigo_TipoTransaccion as CodigoFinal from Tipo_Transaccion order by Codigo_TipoTransaccion desc");
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                NuevoCodigo = Convert.ToInt32((Reg["CodigoFinal"].ToString()));

            }
            else
            {

            }

            this.cnx.Close();

            return (NuevoCodigo + 1);
        }

        public void Fun_CargarDocumentos(DataGridView dgv)
        {
            try
            {
                this.sql = string.Format
                (@"select Codigo_TipoDeDocumento as 'Codigo', Descripcion as 'Descripcion',Codigo_Estado as 'Codigo de Estado',
                (select B.Descripcion_Estado from Estados AS B where B.Codigo_Estado=A.Codigo_Estado and 
                B.Descripcion_Estado like '%Tipo de Documento%') 
                as 'Estado' from Tipos_Documentos as A");
                this.cmd = new SqlCommand(this.sql, this.cnx);
                this.DataAdapter = new SqlDataAdapter(this.cmd);
                this.dt = new DataTable();
                this.DataAdapter.Fill(this.dt);
                dgv.DataSource = this.dt;

            }
            catch
            {

            }

        }

        public void Fun_ExtraerEstados(ComboBox RolBox)
        {


            this.cnx.Open();
            this.sql = string.Format(@"select Codigo_Estado, Descripcion_Estado from Estados where Descripcion_Estado like '%Tipo de Document%'");
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.DataAdapter = new SqlDataAdapter(this.cmd);
            this.dt = new DataTable();
            this.DataAdapter.Fill(this.dt);
            this.cnx.Close();

            RolBox.ValueMember = "Codigo_Estado";
            RolBox.DisplayMember = "Descripcion_Estado";
            RolBox.DataSource = this.dt;
        }

        public void Fun_VerificarDocumentos(int FV_Estado, string FV_Desc)
        {
            this.sql = string.Format(@"select * from Tipos_Documentos where Descripcion = '{0}'", FV_Desc);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                MessageBox.Show("Existe Duplicacion de Datos, Ingrese una Descripcion Diferente", "Error de Duplicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.cnx.Close();
                Fun_IngresarDocumento(FV_Estado, FV_Desc);
            }

            this.cnx.Close();

        }

        public void Fun_IngresarDocumento(int FV_Estado, string FV_Desc)
        {
            this.sql = string.Format(@"insert into Tipos_Documentos values ('{0}','{1}')", FV_Desc, FV_Estado);

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();

            MessageBox.Show("Se ha incresado con Exito");
        }

        public void Fun_VerificarAct_Documento(int FV_Cod, int FV_Estado, string FV_Desc)
        {
            this.sql = string.Format(@"select * from Tipos_Documentos where Descripcion = '{0}' and Codigo_TipoDeDocumento != '{1}'", FV_Desc, FV_Cod);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                MessageBox.Show("Existe Duplicacion de Datos, Ingrese una Descripcion Diferente", "Error de Duplicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.cnx.Close();
                Fun_Modificar_Documento(FV_Cod, FV_Estado, FV_Desc);
            }

            this.cnx.Close();
        }

        public void Fun_Modificar_Documento(int FV_Cod, int FV_Estado, string FV_Desc)
        {
            this.sql = string.Format(@"update Tipos_Documentos set Descripcion = '{0}' , Codigo_Estado='{1}' where Codigo_TipoDeDocumento='{2}'",
                FV_Desc, FV_Estado, FV_Cod);

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();

            MessageBox.Show("Se ha Modificado con Exito");
        }

        public void Fun_VerificarTransaccion(string FV_Natur, string FV_Desc)
        {

            this.sql = string.Format(@"select * from Tipo_Transaccion where Descripcion='{0}' ", FV_Desc);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                MessageBox.Show("Existe Duplicacion de Datos, Ingrese una Descripcion Diferente", "Error de Duplicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.cnx.Close();
                Fun_AgregarTransaccion(FV_Natur, FV_Desc);


            }

            this.cnx.Close();
        }

        public void Fun_AgregarTransaccion(string FV_Natu, string FV_Desc)
        {
            this.sql = string.Format(@"insert into Tipo_Transaccion values ('{0}','{1}')", FV_Desc, FV_Natu);

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();

            MessageBox.Show("Se ha incresado con Exito");
        }

        public void Fun_VerificarModiT(int FV_Cod, string FV_Natu, string FV_Desc)
        {
            this.sql = string.Format(@"select * from Tipo_Transaccion where Descripcion='{0}'  and Codigo_TipoTransaccion !='{1}' ", FV_Desc, FV_Cod);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                MessageBox.Show("Existe Duplicacion de Datos, Ingrese una Descripcion Diferente", "Error de Duplicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.cnx.Close();
                Fun_ModificatTransaccion(FV_Cod,FV_Natu,FV_Desc);
            }

            this.cnx.Close();
        }

        public void Fun_ModificatTransaccion(int FV_Cod, string FV_Natu, string FV_Desc)
        {

            this.sql = string.Format(@"UPDATE Tipo_Transaccion set Descripcion='{0}', Naturaleza='{1}' where Codigo_TipoTransaccion='{2}'", FV_Desc, FV_Natu, FV_Cod);

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();

            MessageBox.Show("Se ha incresado con Exito");
        }


        public void Fun_ExtraerEstadFact(ComboBox Combo)
        {

            cnx.Open();
            sql = string.Format(@"SELECT Codigo_Estado, Descripcion_Estado FROM Estados WHERE Codigo_Tipo_Estado = 8");
            cmd = new SqlCommand(sql, cnx);
            DataAdapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            cnx.Close();

            Combo.ValueMember = "Codigo_Estado";
            Combo.DisplayMember = "Descripcion_Estado";
            Combo.DataSource = dt;

        }

        public void Fun_ExtraerTipoDoc(ComboBox ComtipoDoc)
        {
            cnx.Open();
            sql = string.Format(@"SELECT Codigo_TipoDeDocumento, Descripcion FROM Tipos_Documentos");
            cmd = new SqlCommand(sql, cnx);
            DataAdapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            cnx.Close();

            ComtipoDoc.ValueMember = "Codigo_TipoDeDocumento";
            ComtipoDoc.DisplayMember = "Descripcion";
            ComtipoDoc.DataSource = dt;

        }

        public void Fun_ExtraerTipoTrans(ComboBox ComtipoTrans)
        {
           cnx.Open();
            sql = string.Format(@"SELECT Codigo_TipoTransaccion, Descripcion FROM Tipo_Transaccion");
            cmd = new SqlCommand(sql, cnx);
            DataAdapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            cnx.Close();

            ComtipoTrans.ValueMember = "Codigo_TipoTransaccion";
            ComtipoTrans.DisplayMember = "Descripcion";
            ComtipoTrans.DataSource = dt;

        }

        public void Fun_FiltrarEstado(DataGridView dgv, int FV_Busqueda)
        {
            cnx.Open();
            try
            {
                sql = string.Format
                (@"select
A.Codigo_Transaccion as [Código de Transacción],
	               A.Numero_Documento as [No. de Documento],
	               B.Descripcion as [Tipo de Transacción],
	               C.Descripcion as [Tipo de Documentación],
	               A.Fecha as [Fecha de Realización],
	               A.Monto as [Monto Total],
	               D.Nombre +space(2)+ D.Apellido as [Nombre del Cliente],
	               A.Fecha_Vencimiento as [Fecha de Vencimiento],
	       
	               ('%' + CAST(( E.[Porcentaje_Mora]* 100) as nvarchar)) as [Porcentaje de Mora],
                   (Select F.Descripcion_Estado from Estados as F where F.Codigo_Estado=A.Codigo_Estado and F.Descripcion_Estado like '%Transac%')
                    as 'Estados' FROM [dbo].[Transacciones] as A
                    inner join [dbo].[Tipo_Transaccion] as B
                    on A.Codigo_Tipo_Transaccion = B.Codigo_TipoTransaccion
                    inner join [dbo].[Tipos_Documentos] as C
                    on A.Codigo_Tipo_Documento = C.Codigo_TipoDeDocumento
                    left join [dbo].[Clientes] as D
                    on A.Codigo_Cliente = D.Codigo_Cliente
                    left join [dbo].[Mora] as E
                    on A.Codigo_Mora = E.Codigo_Mora
                    
                   WHERE A.Codigo_Estado =" + (FV_Busqueda));
                cmd = new SqlCommand(sql, cnx);
                DataAdapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dgv.DataSource = dt;

                cnx.Close();
            }
            catch
            {

            }

        }

        public void Fun_FiltrarTipoTrans(DataGridView dgv, int FV_Busqueda)
        {
            cnx.Open();
            try
            {
                sql = string.Format
                (@"select
A.Codigo_Transaccion as [Código de Transacción],
	               A.Numero_Documento as [No. de Documento],
	               B.Descripcion as [Tipo de Transacción],
	               C.Descripcion as [Tipo de Documentación],
	               A.Fecha as [Fecha de Realización],
	               A.Monto as [Monto Total],
	               D.Nombre +space(2)+ D.Apellido as [Nombre del Cliente],
	               A.Fecha_Vencimiento as [Fecha de Vencimiento],
	            
	                ('%' + CAST(( E.[Porcentaje_Mora]* 100) as nvarchar)) as [Porcentaje de Mora],
                   (Select F.Descripcion_Estado from Estados as F where F.Codigo_Estado=A.Codigo_Estado and F.Descripcion_Estado like '%Transac%')
                    as 'Estados' FROM [dbo].[Transacciones] as A
                    inner join [dbo].[Tipo_Transaccion] as B
                    on A.Codigo_Tipo_Transaccion = B.Codigo_TipoTransaccion
                    inner join [dbo].[Tipos_Documentos] as C
                    on A.Codigo_Tipo_Documento = C.Codigo_TipoDeDocumento
                    left join [dbo].[Clientes] as D
                    on A.Codigo_Cliente = D.Codigo_Cliente
                    left join [dbo].[Mora] as E
                    on A.Codigo_Mora = E.Codigo_Mora
                    
                   WHERE A.Codigo_Tipo_Transaccion =" + (FV_Busqueda));
                cmd = new SqlCommand(sql, cnx);
                DataAdapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dgv.DataSource = dt;

                cnx.Close();
            }
            catch
            {

            }
        }

        public void Fun_FiltrarTipoDoc(DataGridView dgv, int FV_Busqueda)
        {
            cnx.Open();
            try
            {
                sql = string.Format
                (@"select
A.Codigo_Transaccion as [Código de Transacción],
	               A.Numero_Documento as [No. de Documento],
	               B.Descripcion as [Tipo de Transacción],
	               C.Descripcion as [Tipo de Documentación],
	               A.Fecha as [Fecha de Realización],
	               A.Monto as [Monto Total],
	               D.Nombre +space(2)+ D.Apellido as [Nombre del Cliente],
	               A.Fecha_Vencimiento as [Fecha de Vencimiento],
	               
	                ('%' + CAST(( E.[Porcentaje_Mora]* 100) as nvarchar)) as [Porcentaje de Mora],
                   (Select F.Descripcion_Estado from Estados as F where F.Codigo_Estado=A.Codigo_Estado and F.Descripcion_Estado like '%Transac%')
                    as 'Estados' FROM [dbo].[Transacciones] as A
                    inner join [dbo].[Tipo_Transaccion] as B
                    on A.Codigo_Tipo_Transaccion = B.Codigo_TipoTransaccion
                    inner join [dbo].[Tipos_Documentos] as C
                    on A.Codigo_Tipo_Documento = C.Codigo_TipoDeDocumento
                    left join [dbo].[Clientes] as D
                    on A.Codigo_Cliente = D.Codigo_Cliente
                    left join [dbo].[Mora] as E
                    on A.Codigo_Mora = E.Codigo_Mora
                    
                   WHERE A.Codigo_Tipo_Documento =" + (FV_Busqueda));
                cmd = new SqlCommand(sql, cnx);
                DataAdapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dgv.DataSource = dt;

                cnx.Close();
            }
            catch
            {

            }
        }


        public void Fun_ExtraerTransacciones(DataGridView dgv)
        {

            cnx.Open();
            try
            {
                sql = string.Format
                (@"select A.Codigo_Transaccion as [Código de Transacción],
	               A.Numero_Documento as [No. de Documento],
	               B.Descripcion as [Tipo de Transacción],
	               C.Descripcion as [Tipo de Documentación],
	               A.Fecha as [Fecha de Realización],
	               A.Monto as [Monto Total],
	               D.Nombre +space(2)+ D.Apellido as [Nombre del Cliente],
	               A.Fecha_Vencimiento as [Fecha de Vencimiento],
	               
	               ('%' + CAST(( E.[Porcentaje_Mora]* 100) as nvarchar)) as [Porcentaje de Mora],
                   (Select F.Descripcion_Estado from Estados as F where F.Codigo_Estado=A.Codigo_Estado and F.Descripcion_Estado like '%Transac%')
                    as 'Estados' FROM [dbo].[Transacciones] as A
                    inner join [dbo].[Tipo_Transaccion] as B
                    on A.Codigo_Tipo_Transaccion = B.Codigo_TipoTransaccion
                    inner join [dbo].[Tipos_Documentos] as C
                    on A.Codigo_Tipo_Documento = C.Codigo_TipoDeDocumento
                    left join [dbo].[Clientes] as D
                    on A.Codigo_Cliente = D.Codigo_Cliente
                    left join [dbo].[Mora] as E
                    on A.Codigo_Mora = E.Codigo_Mora");
                cmd = new SqlCommand(sql, cnx);
                DataAdapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dgv.DataSource = dt;

                cnx.Close();

            }
            catch
            {

            }

        }


        public void Fun_FiltarFechaVenc(DataGridView dgv, string FV_BusqFechaVenc)
        {
            cnx.Open();
            try
            {
                sql = string.Format
                (@"select
A.Codigo_Transaccion as [Código de Transacción],
	               A.Numero_Documento as [No. de Documento],
	               B.Descripcion as [Tipo de Transacción],
	               C.Descripcion as [Tipo de Documentación],
	               A.Fecha as [Fecha de Realización],
	               A.Monto as [Monto Total],
	               D.Nombre + space(2)+D.Apellido as [Nombre del Cliente],
	               A.Fecha_Vencimiento as [Fecha de Vencimiento],
	             
	               ('%' + CAST(( E.[Porcentaje_Mora]* 100) as nvarchar)) as [Porcentaje de Mora],
                   (Select F.Descripcion_Estado from Estados as F where F.Codigo_Estado=A.Codigo_Estado and F.Descripcion_Estado like '%Transac%')
                    FROM [dbo].[Transacciones] as A
                    inner join [dbo].[Tipo_Transaccion] as B
                    on A.Codigo_Tipo_Transaccion = B.Codigo_TipoTransaccion
                    inner join [dbo].[Tipos_Documentos] as C
                    on A.Codigo_Tipo_Documento = C.Codigo_TipoDeDocumento
                    left join [dbo].[Clientes] as D
                    on A.Codigo_Cliente = D.Codigo_Cliente
                    left join [dbo].[Mora] as E
                    on A.Codigo_Mora = E.Codigo_Mora
                    
                   WHERE A.Fecha_Vencimiento = '" + FV_BusqFechaVenc + "'");
                cmd = new SqlCommand(sql, cnx);
                DataAdapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dgv.DataSource = dt;

                cnx.Close();
            }
            catch
            {

            }
        }


    }
}

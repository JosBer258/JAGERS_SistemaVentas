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
    class C_DatoHistoricos : Conexion
    {
        public void Fun_CargarDataEmpleadoHistorico(DataGridView dgv)
        {

            cnx.Open();

            DataAdapter = new SqlDataAdapter(@"select [Codigo_EmpleadoHistorico] as 'Codigo Empleado Historico', 
                               [Codigo_Empleado] as 'Codigo Empleado', [ID], [Nombre], [Correo], [Telefono],
                               [FechaIngreso] as 'Fecha Ingreso', [Estado], [Rol], [NombreEmpleado_Modific] as 'Empleado Modifica', 
                               [Fecha_Modificacion] as 'Fecha Modificacion', [Accion]
                               from [Empleado|Historico]", ccnx);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            dgv.DataSource = dt;
            cnx.Close();
        }

        public void Fun_CargarDataProductoHistorico(DataGridView dgv)
        {

            cnx.Open();

            DataAdapter = new SqlDataAdapter(@"select [Cod_ProductoHistorico] as 'Codigo Producto Historico', 
                               [Cod_Producto] as 'Codigo Producto', [Nombre],
                               [PrecioVenta] as 'Precio Venta', [PrecioCompra] as 'Precio Compra', 
                               [FechaModificacion] as 'Fecha Modificacion', [Estado], [FechaIngreso] as 'Fecha Ingreso',
                               [Empleado_Modifacion] as 'Empleado Modifica', [Accion]
                               from [Productos|Historicos]", ccnx);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            dgv.DataSource = dt;
            cnx.Close();
        }

        public void ExtraerNombEmpleadoHistorico(DataGridView dgv, string Nom)
        {

            cnx.Open();
            try
            {
                sql = string.Format
                (@"select [Codigo_EmpleadoHistorico] as 'Codigo Empleado Historico', 
                               [Codigo_Empleado] as 'Codigo Empleado', [ID], [Nombre],[Correo], [Telefono],
                               [FechaIngreso] as 'Fecha Ingreso', [Estado], [Rol], [NombreEmpleado_Modific] as 'Empleado Modifica', 
                               [Fecha_Modificacion] as 'Fecha Modificacion', [Accion]
                               from [Empleado|Historico]
                               where Nombre like '%{0}%'", Nom);
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

        public void ExtraerNombProductoHistorico(DataGridView dgv, string Nom)
        {

            cnx.Open();
            try
            {
                sql = string.Format
                (@"select [Cod_ProductoHistorico] as 'Codigo Producto Historico', 
                               [Cod_Producto] as 'Codigo Producto', [Nombre],
                               [PrecioVenta] as 'Precio Venta', [PrecioCompra] as 'Precio Compra', 
                               [FechaModificacion] as 'Fecha Modificacion', [Estado], [FechaIngreso] as 'Fecha Ingreso',
                               [Empleado_Modifacion] as 'Empleado Modifica', [Accion]
                               from [Productos|Historicos]
                               where Nombre like '%{0}%'", Nom);
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

        public void Var_IngresarProductosHistoricos(string FV_Nombre, float FV_PrVenta, float FV_PrCompra, string FV_EmpMod)
        {
            sql = string.Format(@"insert into [Productos|Historicos] 
           (Cod_Producto, Nombre, PrecioVenta, PrecioCompra, FechaIngreso, Estado, Empleado_Modifacion, Accion)
           values 
          ((select top 1 Cod_Producto from Producto order by Cod_Producto desc),'{0}','{1}','{2}',GETDATE(),
                                                                               'Productos-Activos','{3}','Agregar')",
                                                                               FV_Nombre, FV_PrVenta, FV_PrCompra, FV_EmpMod);

            cmd = new SqlCommand(sql, cnx);
            cnx.Open();
            SqlDataReader Reg = null;
            Reg = cmd.ExecuteReader();
            cnx.Close();
        }

        public void Var_ModificarProductosHistoricos(int FV_CodP, string FV_Nombre, float FV_PrVenta,
            float FV_PrCompra, string FV_EmpMod,
           string FV_Estados, string FV_Accion)
        {
            cnx.Open();
            sql = string.Format(@"
                            insert into [Productos|Historicos] (Cod_Producto, Nombre, PrecioVenta, PrecioCompra, 
                            FechaModificacion, Estado, Empleado_Modifacion, Accion)
                            values ('{0}','{1}','{2}','{3}',GETDATE(),'{4}','{5}','{6}')",
                            FV_CodP, FV_Nombre, FV_PrVenta, FV_PrCompra, FV_Estados, FV_EmpMod, FV_Accion);

            cmd = new SqlCommand(sql, cnx);
            SqlDataReader Reg = null;
            Reg = cmd.ExecuteReader();


            cnx.Close();
        }


        public void Fun_IngresoHistoricos(string FV_ID, string FV_Nombre, string FV_Correo, string FV_Telefono
            , string FV_Estado, string FV_Rol, string FV_EmplMod, string FV_Accion)
        {
            sql = string.Format(@"insert into [Empleado|Historico] 
                (Codigo_Empleado, ID, Nombre, Correo, Telefono, FechaIngreso, Estado, Rol, NombreEmpleado_Modific, Accion)
                values ((select top 1 Codigo_Empleado from Empleados order by Codigo_Empleado desc),'{0}','{1}','{2}','{3}', GETDATE(), 
                '{4}','{5}','{6}','{7}')", FV_ID, FV_Nombre, FV_Correo, FV_Telefono, FV_Estado, FV_Rol, FV_EmplMod, FV_Accion);

            cmd = new SqlCommand(sql, cnx);
            cnx.Open();
            int Reg = cmd.ExecuteNonQuery();
            if (Reg > 0)
            {

            }
            cnx.Close();
        }


        public void Fun_UpdateHistoricos(int FV_Cod,string FV_ID, string FV_Nombre, string FV_Correo, string FV_Telefono
           , string FV_Estado, string FV_Rol, string FV_EmplMod, string FV_Accion)
        {
            sql = string.Format(@"insert into [Empleado|Historico] 
                (Codigo_Empleado, ID, Nombre, Correo, Telefono, Fecha_Modificacion, Estado, Rol, NombreEmpleado_Modific, Accion)
                values ('{0}','{1}','{2}','{3}','{4}', GETDATE(), 
                '{5}','{6}','{7}','{8}')", FV_Cod, FV_ID, FV_Nombre, FV_Correo, FV_Telefono, FV_Estado, FV_Rol, FV_EmplMod, FV_Accion);

            cmd = new SqlCommand(sql, cnx);
            cnx.Open();
            int Reg = cmd.ExecuteNonQuery();
            if (Reg > 0)
            {

            }
            cnx.Close();
        }
    }
}

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
    class C_Factura: Conexion
    {

        public void LlenarDetalles(DataGridView dgv, double a)
        {
            int busq;
            busq = (int)a;

            sql = string.Format(@"select B.NombreProducto as 'Nombre del Producto', B.Descripcion as 'Descripcion del Producto',D.Descripcion as 'Marca',  C.Descripcion as 'Modelo' ,
CAST(A.PrecioVenta as decimal(10,2)) as 'Precio de Venta' , A.CantidadVenta as 'Cantidad'   from [Detalles|Factura] as A inner join Producto as B on A.Codigo_Producto=B.Cod_Producto 
inner join Modelo as C on B.Cod_Modelo=C.Cod_Modelo inner join Marca as D on C.Cod_Marca=D.Cod_Marca
where A.Codigo_Factura = '{0}'", busq);

            cmd = new SqlCommand(sql, cnx);
            cnx.Open();
            DataAdapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            dgv.DataSource = dt;
            cnx.Close();
        }


        public void UpdateFactura(int FN_Estado, int FN_Codigo)
        {

            sql = string.Format(@"update Facturas set Codigo_Estado = '{0}' where Cod_Factura= '{1}'", FN_Estado, FN_Codigo);
            cmd = new SqlCommand(sql, cnx);
            cnx.Open();
            try
            {
                SqlDataReader Reg = null;
                Reg = cmd.ExecuteReader();
            }
            catch
            {

            }
            cnx.Close();
        }

        public void Fun_UpdateTransacciones(int FN_Codigo)
        {

            sql = string.Format(@"update Transacciones set Codigo_Estado = 3 where Numero_Documento='{0}'", FN_Codigo);
            cmd = new SqlCommand(sql, cnx);
            cnx.Open();
            try
            {
                SqlDataReader Reg = null;
                Reg = cmd.ExecuteReader();
            }
            catch
            {

            }
            cnx.Close();
        }
        public void Fun_ExtraerEstados(ComboBox RolBox)
        {
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select Codigo_Estado, Descripcion_Estado from Estados where Descripcion_Estado like '%Factura%'");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();

            RolBox.ValueMember = "Codigo_Estado";
            RolBox.DisplayMember = "Descripcion_Estado";
            RolBox.DataSource = Con.dt;
        }



        public void Fun_InsertarDatagriew(DataGridView dgv)
        {

            cnx.Open();
            try
            {
                sql = string.Format
                (@" select A.Cod_Factura as 'Codigo', (E.Nombre + '' + E.Apellido) as 'Nombre del Cliente',  (D.Nombre + SPACE(1) + D.Apellido) as 'Nombre del Empleado'  ,
                    (F.Nombre + SPACE(1) + F.Apellido) as 'Nombre de Persona Autorizada' ,
                    A.Fecha_Factura as 'Fecha de Realizacion',  CAST(B.Monto as decimal(10,2)) as 'Monto por Factura' , 
                    A.[Impuesto_Porcentaje] as 'Impuesto', C.CodigoProporcionado as 'Clave Cai',
                    A.Codigo_Estado as 'Codigo del Estado',
                    (select Z.Descripcion_Estado from Estados as Z where Z.Codigo_Estado=A.Codigo_Estado and Z.Descripcion_Estado 
                    like '%Factur%') as 'Descripcion del Estado'
                    from Transacciones as B inner join Facturas as A on A.Cod_Factura=B.Numero_Documento
                    inner join Cai as C on A.Codigo_Cai=C.Codigo_Cai
                    inner join Empleados as D on D.Codigo_Empleado=A.Codigo_Empleado
                    left join Clientes As E on E.Codigo_Cliente=B.Codigo_Cliente
                    left join PersonasAutorizadas as F on F.Codigo_PersonasAutorizadas=A.Codigo_PersonaAutorizada");
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





        public void Fun_InsertarDatagriewC(DataGridView dgv, double a)
        {
            int Cod = (int)a;

            cnx.Open();
            try
            {
                sql = string.Format
                (@" select A.Cod_Factura as 'Codigo', (E.Nombre + '' + E.Apellido) as 'Nombre del Cliente',  (D.Nombre + SPACE(1) + D.Apellido) as 'Nombre del Empleado'  ,
                    (F.Nombre + SPACE(1) + F.Apellido) as 'Nombre de Persona Autorizada' ,
                    A.Fecha_Factura as 'Fecha de Realizacion', B.Monto as 'Monto por Factura' , 
                    A.[Impuesto_Porcentaje] as 'Impuesto', C.CodigoProporcionado as 'Clave Cai',
                    A.Codigo_Estado as 'Codigo del Estado',
                    (select Z.Descripcion_Estado from Estados as Z where Z.Codigo_Estado=A.Codigo_Estado and Z.Descripcion_Estado 
                    like '%Factur%') as 'Descripcion del Estado'
                    from Transacciones as B inner join Facturas as A on A.Cod_Factura=B.Numero_Documento
                    inner join Cai as C on A.Codigo_Cai=C.Codigo_Cai
                    inner join Empleados as D on D.Codigo_Empleado=A.Codigo_Empleado
                    left join Clientes As E on E.Codigo_Cliente=B.Codigo_Cliente
                    left join PersonasAutorizadas as F on F.Codigo_PersonasAutorizadas=A.Codigo_PersonaAutorizada
                    where A.Cod_Factura like '%{0}%'", Cod);
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



    }
}

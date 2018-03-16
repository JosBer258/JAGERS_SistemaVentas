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
        //Funciones Inciales
        public int UltimoDocumento()
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

        public int UnltimoTransaccion()
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

        public void CargarDocumentos(DataGridView dgv)
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

        //Documentos
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

        public void VerificarDocumentos(int Estado, string Desc)
        {
            this.sql = string.Format(@"select * from Tipos_Documentos where Descripcion = '{0}'", Desc);
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
                IngresarDocumento(Estado, Desc);
            }

            this.cnx.Close();

        }

        public void IngresarDocumento(int Estado2, string Desc2)
        {
            this.sql = string.Format(@"insert into Tipos_Documentos values ('{0}','{1}')", Desc2, Estado2);

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();

            MessageBox.Show("Se ha incresado con Exito");
        }

        public void VerificarAct_Documento(int Cod, int Estado, string Desc)
        {
            this.sql = string.Format(@"select * from Tipos_Documentos where Descripcion = '{0}' and Codigo_TipoDeDocumento != '{1}'", Desc, Cod);
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
                Modificar_Documento(Cod, Estado, Desc);
            }

            this.cnx.Close();
        }

        public void Modificar_Documento(int Cod1, int Estado2, string Desc3)
        {
            this.sql = string.Format(@"update Tipos_Documentos set Descripcion = '{0}' , Codigo_Estado='{1}' where Codigo_TipoDeDocumento='{2}'",
                Desc3, Estado2, Cod1);

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();

            MessageBox.Show("Se ha Modificado con Exito");
        }

        //Transacciones
        public void VerificarTransaccion(string Natu, string Des)
        {

            this.sql = string.Format(@"select * from Tipo_Transaccion where Descripcion='{0}' ", Des);
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
                AgregarTransaccion(Natu, Des);


            }

            this.cnx.Close();
        }

        public void AgregarTransaccion(string Natu2, string Des2)
        {
            this.sql = string.Format(@"insert into Tipo_Transaccion values ('{0}','{1}')", Des2, Natu2);

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();

            MessageBox.Show("Se ha incresado con Exito");
        }

        public void VerificarModiT(int Cod, string Natu, string Des)
        {
            this.sql = string.Format(@"select * from Tipo_Transaccion where Descripcion='{0}'  and Codigo_TipoTransaccion !='{1}' ", Des, Cod);
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
                ModificatTransaccion(Cod,Natu,Des);
            }

            this.cnx.Close();
        }

        public void ModificatTransaccion(int Cod1, string Natu1, string Des1)
        {
            //"update Tipo_Transaccion set Descripcion='{0}', Descripcion='{1}' where Codigo_TipoTransaccion='{2}'


            this.sql = string.Format(@"UPDATE Tipo_Transaccion set Descripcion='{0}', Naturaleza='{1}' where Codigo_TipoTransaccion='{2}'", Des1, Natu1, Cod1);

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();

            MessageBox.Show("Se ha incresado con Exito");
        }
    }
}

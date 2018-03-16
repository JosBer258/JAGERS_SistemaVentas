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
    class C_Clientes:Conexion
    {


        private int Codigocliente;
        private string NumeroIDCliente;
        private string NombreCliente;
        private string ApellidoCliente;
        private string CelularCliente;
        private string TelefonoCliente;
        private string EmailCliente;
        private string DireccionCliente;
        private string DepartamentoCliente;
        private string CiudadCliente;
        private string RTNCliente;
        private string CodigoEmpresa;
        private string NombreEmpresa;
        private string DireccionEmpresa;
        private string TelefonoEmpresa;
        private string RTNEmpresa;
        private string CiudadEmpresa;
        private int codpruebs;

        public int Codigocliente1
        {
            get
            {
                return Codigocliente;
            }

            set
            {
                Codigocliente = value;
            }
        }

        public string NumeroIDCliente1
        {
            get
            {
                return NumeroIDCliente;
            }

            set
            {
                NumeroIDCliente = value;
            }
        }

        public string NombreCliente1
        {
            get
            {
                return NombreCliente;
            }

            set
            {
                NombreCliente = value;
            }
        }

        public string ApellidoCliente1
        {
            get
            {
                return ApellidoCliente;
            }

            set
            {
                ApellidoCliente = value;
            }
        }

        public string CelularCliente1
        {
            get
            {
                return CelularCliente;
            }

            set
            {
                CelularCliente = value;
            }
        }

        public string TelefonoCliente1
        {
            get
            {
                return TelefonoCliente;
            }

            set
            {
                TelefonoCliente = value;
            }
        }

        public string EmailCliente1
        {
            get
            {
                return EmailCliente;
            }

            set
            {
                EmailCliente = value;
            }
        }

        public string DireccionCliente1
        {
            get
            {
                return DireccionCliente;
            }

            set
            {
                DireccionCliente = value;
            }
        }

        public string DepartamentoCliente1
        {
            get
            {
                return DepartamentoCliente;
            }

            set
            {
                DepartamentoCliente = value;
            }
        }

        public string CiudadCliente1
        {
            get
            {
                return CiudadCliente;
            }

            set
            {
                CiudadCliente = value;
            }
        }

        public string RTNCliente1
        {
            get
            {
                return RTNCliente;
            }

            set
            {
                RTNCliente = value;
            }
        }

        public string CodigoEmpresa1
        {
            get
            {
                return CodigoEmpresa;
            }

            set
            {
                CodigoEmpresa = value;
            }
        }

        public string NombreEmpresa1
        {
            get
            {
                return NombreEmpresa;
            }

            set
            {
                NombreEmpresa = value;
            }
        }

        public string DireccionEmpresa1
        {
            get
            {
                return DireccionEmpresa;
            }

            set
            {
                DireccionEmpresa = value;
            }
        }

        public string TelefonoEmpresa1
        {
            get
            {
                return TelefonoEmpresa;
            }

            set
            {
                TelefonoEmpresa = value;
            }
        }

        public string RTNEmpresa1
        {
            get
            {
                return RTNEmpresa;
            }

            set
            {
                RTNEmpresa = value;
            }
        }

        public string CiudadEmpresa1
        {
            get
            {
                return CiudadEmpresa;
            }

            set
            {
                CiudadEmpresa = value;
            }
        }

        public int Codpruebs
        {
            get
            {
                return codpruebs;
            }

            set
            {
                codpruebs = value;
            }
        }

        public string NomEmpresa()
        {
            string Codigo = "";
                
                this.sql = string.Format
                (@"select NombreEmpresa as NombEmpresa from Empresas where Codigo_Empresa ='{0}'", Codpruebs);
                this.cmd = new SqlCommand(this.sql, this.cnx);
                this.cnx.Open();
                SqlDataReader Reg = null;
                Reg = this.cmd.ExecuteReader();

                if (Reg.Read())
                {
                    Codigo = Convert.ToString(Reg["NombEmpresa"]);

                }

            
            this.cnx.Close();
            return Codigo;
        }
        public string InfoEmpresa()
        {
            string Codigo = "";

            this.sql = string.Format
            (@"select Direccion+space(2)+Telefono as InfEmpresa from Empresas where Codigo_Empresa ='{0}'", Codpruebs);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Codigo = Convert.ToString(Reg["InfEmpresa"]);

            }


            this.cnx.Close();
            return Codigo;
        }


        public int ObtenerUltimoID()
        {
            int Codigo = 0;
            this.sql = string.Format(@"select top 1 Codigo_Cliente as CodigoFinal from Clientes order by Codigo_Cliente desc");
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
        public int ObtenerUltimoCodigoEmpresa()
        {
            int Codigo = 0;
            this.sql = string.Format(@"select top 1 Codigo_Empresa as CodigoFinal from Empresas order by Codigo_Empresa desc");
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
        public int longitudMaximaCombo()
        {
            int Codigo = 0;
            this.sql = string.Format(@"Select LEN(Codigo_Empresa) as MAximoValor from Empresas where Codigo_Empresa = (select top 1 Codigo_Empresa as CodigoFinal from Empresas order by Codigo_Empresa desc)");
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
            this.sql = string.Format(@"select * from Clientes where ID='{0}' or (Nombre='{1}' and Apellido='{2}') or RTN='{3}'", Convert.ToDouble(NumeroIDCliente1), NombreCliente1, ApellidoCliente1,Convert.ToDouble( RTNCliente1));
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
        public bool RevisionDeDatosNuevaEmpresa()
        {
            this.sql = string.Format(@"select * from Empresas where NombreEmpresa='{0}' or RTN='{1}'", NombreEmpresa1, Convert.ToDouble(RTNEmpresa1));
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
        public void IngresoDatos()
        {

            
                    this.sql = string.Format(@"insert into Clientes values(
            '{0}',  '{1}',  '{2}',  '{3}', '{4}', '{5}', '{6}', '{7}','{8}','{9}','{10}',NULL,NULL) ",
         Convert.ToDouble(NumeroIDCliente1), NombreCliente1, ApellidoCliente1, Convert.ToDouble(CelularCliente1), Convert.ToDouble(TelefonoCliente1),
         EmailCliente1, DireccionCliente1, DepartamentoCliente1, CiudadCliente1, Convert.ToDouble(RTNCliente1), 1);
                    this.cmd = new SqlCommand(this.sql, this.cnx);
                    this.cnx.Open();
                    SqlDataReader Reg = null;
                    Reg = this.cmd.ExecuteReader();
                    this.cnx.Close();
                    

        }
        public void IngresoDatos2()
        {

              

                    this.sql = string.Format(@"insert into Clientes values(
            '{0}',  '{1}',  '{2}',  '{3}', '{4}', '{5}', '{6}', '{7}','{8}','{9}','{10}','{11}',NULL) ",
            Convert.ToDouble(NumeroIDCliente1), NombreCliente1, ApellidoCliente1, Convert.ToDouble(CelularCliente1), Convert.ToDouble(TelefonoCliente1),
            EmailCliente1, DireccionCliente1, DepartamentoCliente1, CiudadCliente1, Convert.ToDouble(RTNCliente1), 1, Codpruebs);
                    this.cmd = new SqlCommand(this.sql, this.cnx);
                    this.cnx.Open();
                    SqlDataReader Regi = null;
                    Regi = this.cmd.ExecuteReader();
                    this.cnx.Close();
                   
        }
        public void IngresoDatos3()
        {



            this.sql = string.Format(@"insert into Clientes values(
            '{0}',  '{1}',  '{2}',  '{3}', '{4}', '{5}', '{6}', '{7}','{8}','{9}','{10}',(select top 1 Codigo_Empresa as CodigoFinal from Empresas order by Codigo_Empresa desc),NULL) ",
    Convert.ToDouble(NumeroIDCliente1), NombreCliente1, ApellidoCliente1, Convert.ToDouble(CelularCliente1), Convert.ToDouble(TelefonoCliente1),
    EmailCliente1, DireccionCliente1, DepartamentoCliente1, CiudadCliente1, Convert.ToDouble(RTNCliente1), 1);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Regi = null;
            Regi = this.cmd.ExecuteReader();
            this.cnx.Close();

        }
        public void IngresoNuevaEmpresa()
        {



            this.sql = string.Format(@"insert into Empresas values(
            '{0}',  '{1}',  '{2}',  '{3}', '{4}') ",NombreEmpresa1, DireccionEmpresa1, Convert.ToDouble(TelefonoEmpresa1), Convert.ToDouble(RTNEmpresa1), CiudadEmpresa1);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Regi = null;
            Regi = this.cmd.ExecuteReader();
            this.cnx.Close();

        }




        //////CUENTA CREDITO 
        //LLENAR PERSONA AUTORIZADA

        public void LlenarPersonasAutorizadas(DataGridView dgv, int a)
        {
            

            this.sql = string.Format(@"select Codigo_PersonasAutorizadas as Codigo, Numero_Identidad as ID, Nombre, Apellido, Telefono, 
            (select Descripcion_Estado from Estados as E where E.Codigo_Estado =  PersonasAutorizadas.Codigo_Estado and E.Codigo_Tipo_Estado=9) as Estado
             from PersonasAutorizadas where Codigo_Cliente='{0}'", a);

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            this.DataAdapter = new SqlDataAdapter(this.cmd);
            this.dt = new DataTable();
            this.DataAdapter.Fill(this.dt);
            dgv.DataSource = this.dt;
            this.cnx.Close();


        }


        public void LlenarPersonasCuentasBancarias(DataGridView dgv, int a)
        {


            this.sql = string.Format(@"select Codigo_CuentaBancaria as Codigo, NombreCuenta as 'Nombre de Cuenta', TipoCuenta as 'Tipo de Cuenta Bancaria' from CuentaBancaria
            where Codigo_Cliente='{0}'", a);

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            this.DataAdapter = new SqlDataAdapter(this.cmd);
            this.dt = new DataTable();
            this.DataAdapter.Fill(this.dt);
            dgv.DataSource = this.dt;
            this.cnx.Close();


        }



        public void LlenarReferenciasBan(DataGridView dgv, int a)
        {


            this.sql = string.Format(@"select Codigo_Referencia as 'Codigo', Nombre, Direccion, Telefono from Referencias
            where Codigo_Tipo = 1 and Codigo_Cliente ='{0}'", a);

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            this.DataAdapter = new SqlDataAdapter(this.cmd);
            this.dt = new DataTable();
            this.DataAdapter.Fill(this.dt);
            dgv.DataSource = this.dt;
            this.cnx.Close();


        }


        public void LlenarReferenciasPersonales(DataGridView dgv, int a)
        {


            this.sql = string.Format(@"select Codigo_Referencia as 'Codigo', Nombre, Direccion, Telefono from Referencias
            where Codigo_Tipo = 2 and Codigo_Cliente='{0}'", a);

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            this.DataAdapter = new SqlDataAdapter(this.cmd);
            this.dt = new DataTable();
            this.DataAdapter.Fill(this.dt);
            dgv.DataSource = this.dt;
            this.cnx.Close();


        }

        public void ExtraerEstadosCredito(ComboBox Co)
        {
            this.cnx.Open();
            this.sql = string.Format(@"select Codigo_Estado, Descripcion_Estado from Estados where Codigo_Tipo_Estado = 13");
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.DataAdapter = new SqlDataAdapter(this.cmd);
            this.dt = new DataTable();
            this.DataAdapter.Fill(this.dt);
            this.cnx.Close();


            Co.ValueMember = "Codigo_Estado";
            Co.DisplayMember = "Descripcion_Estado";
            Co.DataSource = this.dt;
            this.cnx.Close();
        }

        ////AGREGAR Y O MODIFICAR CUENTA
        //AUTO GENERAR EL NUEVO CODIGO DE CREDITO

        public string CodigoCreditoNuevo()
        {
            string Mensaje="";

            Conexion Cn = new Conexion();
            Cn.sql = string.Format(@"select Top 1 Codigo_Credito as  Cod from Creditos order by Codigo_Credito desc");
            Cn.cmd = new SqlCommand(Cn.sql, Cn.cnx);
            Cn.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Cn.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Mensaje = Convert.ToString(Convert.ToInt16(Reg["Cod"].ToString()) +1);
            }
            else
            {

            }

            return Mensaje;
        }

        public bool AgregarCuenta(float Monto, float Saldo, int Cod)
        {
            this.sql = string.Format(@"insert into Creditos values ('{0}','{1}',1)", 
                Monto, Saldo);

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Regi = null;

            try
            {
                Regi = this.cmd.ExecuteReader();
                
                this.cnx.Close();
                AgregarCuentaACliente(Cod);
                return true;
                
            }
            catch (Exception)
            {
                this.cnx.Close();
                return false;
            }
            
        }

        public void AgregarCuentaACliente( int Codigo_Cliente)
        {
            this.sql = string.Format(@"update Clientes set Codigo_Credito=(select Top 1 Codigo_Credito from Creditos order by Codigo_Credito desc) 
            where Codigo_Cliente='{0}'", Codigo_Cliente);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Regi = null;
            try
            {   Regi = this.cmd.ExecuteReader();
                MessageBox.Show("Se ha realizado la apertura de la cuenta de credito","Apertura de Cuenta de Credito", MessageBoxButtons.OK , MessageBoxIcon.Asterisk);
                this.cnx.Close();           }
            catch (Exception)
            {   }
            this.cnx.Close();}

        public bool ModificarCuenta(float Monto, float Saldo,int Est ,int Cod)
        {
            this.sql = string.Format(@"update Creditos set Monto_Credito='{0}', 
                                     Saldo_Actual='{1}', Codigo_Estado='{2}'  where Codigo_Credito='{3}'",
                Monto, Saldo, Est, Cod);

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Regi = null;

            try
            {
                Regi = this.cmd.ExecuteReader();
                
                    MessageBox.Show("Se ha realizado la actualiación exitosamente", "Actualizacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
                this.cnx.Close();
                return true;

            }
            catch (Exception)
            {
                this.cnx.Close();
                return false;
            }

        }

        public void VerificarCuentas(string Nombr, string Tip, int Co)
        {
            Conexion Cn = new Conexion();
            Cn.sql = string.Format(@"select * from CuentaBancaria where NombreCuenta='{0}' 
            and TipoCuenta='{1}' and Codigo_Cliente='{2}'", Nombr, Tip, Co);
            Cn.cmd = new SqlCommand(Cn.sql, Cn.cnx);
            Cn.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Cn.cmd.ExecuteReader();

            if (Reg.Read())
            {
                this.cnx.Close();

            }
            else
            {
                this.cnx.Close();
                AgregarCuentaBancaria(Nombr,Tip,Co);

            }
        }

        public void AgregarCuentaBancaria(string Nombre, string Tipo, int Cod)
        {
            this.sql = string.Format(@"insert into CuentaBancaria values ('{0}','{1}','{2}')", 
            Nombre, Tipo, Cod);

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Regi = null;
            try
            {
                Regi = this.cmd.ExecuteReader();
                this.cnx.Close();
            }
            catch (Exception)
            { }
            this.cnx.Close();
        }

        public void VerificarReferencias(int tipo1, string Telefono1, string Nombr1, string Dir1, int Co1)
        {
            Conexion Cn = new Conexion();
            Cn.sql = string.Format(@"select * from Referencias where Nombre='{0}' and Codigo_Cliente='{1}'", 
                Nombr1, Co1);
            Cn.cmd = new SqlCommand(Cn.sql, Cn.cnx);
            Cn.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Cn.cmd.ExecuteReader();

            if (Reg.Read())
            {
                this.cnx.Close();

            }
            else
            {
                this.cnx.Close();
                AgregarCuentaReferencias(tipo1, Telefono1, Nombr1, Dir1, Co1);

            } 
        }

        public void AgregarCuentaReferencias(int tipo, string Telefono, string Nombr, string Dir, int Co)
        {
            this.sql = string.Format(@"insert into Referencias values('{0}','{1}','{2}','{3}','{4}')", tipo, Co, Nombr, Dir, Telefono);

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Regi = null;
            try
            {
                Regi = this.cmd.ExecuteReader();
                this.cnx.Close();
            }
            catch (Exception)
            { }
            this.cnx.Close();
        }

        public void ExtraerEstadoParaReferencias(ComboBox Com)
        {
            this.cnx.Open();
            this.sql = string.Format(@"select Codigo_Estado, Descripcion_Estado from Estados where Codigo_Tipo_Estado = 9");
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.DataAdapter = new SqlDataAdapter(this.cmd);
            this.dt = new DataTable();
            this.DataAdapter.Fill(this.dt);
            this.cnx.Close();


            Com.ValueMember = "Codigo_Estado";
            Com.DisplayMember = "Descripcion_Estado";
            Com.DataSource = this.dt;
            this.cnx.Close();
        }

        public void VerificarReferencias(int Cliente1, string ID1, string Nombre1, string Apellido1, string Telefono1, int Estado1, int Accion)
        {
            Conexion Cn = new Conexion();
            Cn.sql = string.Format(@"select * from PersonasAutorizadas where 
            (Numero_Identidad='{0}' or (Nombre='{1}' and Apellido='{2}')) and Codigo_Cliente='{3}'",
                ID1, Nombre1, Apellido1, Cliente1);
            Cn.cmd = new SqlCommand(Cn.sql, Cn.cnx);
            Cn.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Cn.cmd.ExecuteReader();

            if (Reg.Read())
            {
                this.cnx.Close();
                MessageBox.Show("Exite duplicacion de Datos\n Porfavor revise los datos nuevamente", "Error de Duplicación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.cnx.Close();
                Ingresar_VerificarReferencias(Cliente1, ID1, Nombre1, Apellido1, Telefono1, Estado1);
                MessageBox.Show("Los datos se Ingresaron exitosamente", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        public void Actualizar_VerificarReferencias(int Cod_Persona, string Telefono, int Estado)
        {
            this.sql = string.Format(@"update PersonasAutorizadas set Telefono='{0}',
                                    Codigo_Estado='{1}' where Codigo_PersonasAutorizadas='{2}'", 
                                    Telefono, Estado, Cod_Persona);

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Regi = null;
            try
            {
                Regi = this.cmd.ExecuteReader();
                MessageBox.Show("Los datos se actualizaron exitosamente", "Confirmación de Actualización", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.cnx.Close();
            }
            catch (Exception)
            { }
            this.cnx.Close();
        }

        public void Ingresar_VerificarReferencias(int Cliente, string ID, string Nombre, string Apellido, string Telefono, int Estado)
        {
            this.sql = string.Format(@" insert into PersonasAutorizadas values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}' )", 
                Cliente, ID, Nombre, Apellido, Telefono, Estado );

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Regi = null;
            try
            {
                Regi = this.cmd.ExecuteReader();
                this.cnx.Close();
            }
            catch (Exception)
            { }
            this.cnx.Close();
        }

        public int NuevoPersonaAutorizada()
        {
            int CodigoNuevo = 0;
            this.sql = string.Format(@"select Top 1 Codigo_PersonasAutorizadas as Cod from PersonasAutorizadas  order by Codigo_PersonasAutorizadas desc");
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                CodigoNuevo = Convert.ToInt16(Convert.ToInt16((Reg["Cod"].ToString()))+1);

            }
            else
            {

            }

            this.cnx.Close();
            return CodigoNuevo;
        }

        public int OptenerEstados(string a)
        {
            int CodigoNuevo = 0;

            this.sql = string.Format(@"select Codigo_Estado from Estados where Descripcion_Estado='{0}'", a);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                
               CodigoNuevo = Convert.ToInt16((Reg["Codigo_Estado"].ToString()));

            }
            else
            {

            }

            this.cnx.Close();
            return CodigoNuevo;
        }


    }
}

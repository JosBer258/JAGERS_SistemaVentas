using Desarrollo.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desarrollo.Pantallas.Modulo__Empleados
{
    public partial class Form_Manejo_de_Empleados : Form
    {
        C_Empleados Emp = new C_Empleados();
        Validaciones Val = new Validaciones();

        public Form_Manejo_de_Empleados()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form_Manejo_de_Empleados_Load(object sender, EventArgs e)
        {
            Fun_CargarPrimerDataGriew(Pest2_DataGriew_InformacionEmpleado);//CASO: Buscar Empleado

            Fun_ExtraerRoles();//CASO: Agregar Nuevo Empleado
            Fun_ExtraerFechaActual();//CASO: Agregar Nuevo Empleado
            Fun_ExtraerEstados();

            try
            { this.empleadosTableAdapter.Fill(this.ventasAutoPartesDataSet.Empleados);}
            catch
            {

            }

            Pest1_Radio_Nuevo_Empleado.Checked = true;
            Pest1_Radio_Manejo.Checked = false;
            Pest2_Radio_Codigo.Checked = true;
            Pest2_Radio_ID.Checked = false;
            Pest2_Radio_Nombre.Checked = false;
            Pest2_Txt_IDBuscar.Enabled = false;
            Pest2_Txt_NombreBuscar.Enabled = false;


         

            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LimpiarTodo();

  

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void Pest2_DataGriew_InformacionEmpleado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string a;
            a = Pest2_DataGriew_InformacionEmpleado.CurrentCell.ColumnIndex.ToString();

            if(Convert.ToInt16(a)==1 || Convert.ToInt16(a) == 0)
            {
                Pest1_Radio_Manejo.Checked = true;
                MessageBox.Show("Lito");
                Pest1_Txt_CodigoEmpleado.Text = Pest2_DataGriew_InformacionEmpleado.CurrentCell.Value.ToString();

            }
            


           
           
            
         

        }

        private void Picture_Click(object sender, EventArgs e)
        {
           
        }


        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pest2_Radio_Codigo_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest2_Radio_Codigo.Checked == true)
            { Pest2_Txt_CodigoBuscar.Enabled = true;

                Pest2_Txt_IDBuscar.Text = "";
                Pest2_Txt_NombreBuscar.Text = "";
            }
            else { Pest2_Txt_CodigoBuscar.Enabled = false;}
        }

        private void Pest2_Radio_ID_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest2_Radio_ID.Checked == true)
            { Pest2_Txt_IDBuscar.Enabled = true;
                Pest2_Txt_CodigoBuscar.Text = "";
                Pest2_Txt_NombreBuscar.Text = "";

            }
            else { Pest2_Txt_IDBuscar.Enabled = false; }
        }

        private void Pest2_Radio_Nombre_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest2_Radio_Nombre.Checked == true)
            { Pest2_Txt_NombreBuscar.Enabled = true;
                Pest2_Txt_CodigoBuscar.Text = "";
                Pest2_Txt_IDBuscar.Text = "";
            }
            else { Pest2_Txt_NombreBuscar.Enabled = false; }
        }

        private void Pest1_Radio_Nuevo_Empleado_CheckedChanged(object sender, EventArgs e)
        {
            if(Pest1_Radio_Nuevo_Empleado.Checked == true)//CASO: Agregar Empleado
            {
                Pest1_ComBox_Estado.Enabled = false;
                Pest1_ComBox_Estado.SelectedValue = (4);
                Pest1_Txt_CodigoEmpleado.Text =Convert.ToString(Emp.OptenerUltimoID());
            }
            else
            {

                Pest1_Txt_CodigoEmpleado.Text = Convert.ToString("");
                Pest1_ComBox_Estado.Enabled = true;
            }
        }

        private void Pest1_Radio_Manejo_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void Pest1_Guardar_Click(object sender, EventArgs e)
        {
            if (Pest1_Radio_Nuevo_Empleado.Checked == true)//CASO: Agregar Empleado
            {
                Fun_Ajecutar();//CASO: Agregar Empleado
            }
            else
            {

            }
        }

        private void Pest1_Txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.SoloNumeros(e);
        }

        private void Pest1_Txt_NombreEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender,e);
        }

        private void Pest1_Txt_ApellidoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void Pest1_Text_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarDireccion(sender, e);
        }

        private void Pest1_Text_CorreoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarCorreoIngreso(sender, e);
        }

        private void Pest1_Txt_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarPassword(sender, e);
        }

        private void Pest2_Txt_CodigoBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.SoloNumeros(e);
        }

        private void Pest2_Txt_IDBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.SoloNumeros(e);
        }

        private void Pest2_Txt_NombreBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void label17_Click(object sender, EventArgs e)
        {
          
        }

        private void Pest1_ComBox_FechaMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pest1_ComBox_FechaDia.Items.Clear(); //CASO: Agregar Empleado
            Fun_LLenarDias();//CASO: Agregar Empleado
            Fun_ExtraerEstados();
        }


        ///////////////////////////////////////////CASO: Agregar Nuevo Empleado/////////////////////////////////////////////////////////////////////

        private void Fun_Ajecutar()
        {
            if (Pest1_Txt_ID.Text == "")
            {
                MessageBox.Show("El Numero de Identitad del Empleado es Requerido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Pest1_Txt_ID.Focus();
                return;
            }

            if (Pest1_Txt_NombreEmpleado.Text == "")
            {
                MessageBox.Show("El Nombre del Empleado es Requerido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Pest1_Txt_NombreEmpleado.Focus();
                return;
            }

            if (Pest1_Txt_ApellidoEmpleado.Text == "")
            {
                MessageBox.Show("El Apellido del Empleado es Requerido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Pest1_Txt_ApellidoEmpleado.Focus();
                return;
            }
            
            if(Pest1_Text_CorreoEmpleado.Text == "")
            {
                MessageBox.Show("El Correo del Empleado es Requerido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Pest1_Text_CorreoEmpleado.Focus();
                return;
            }

            if (Pest1_ComBox_FechaMes.SelectedIndex == -1)
            {
                MessageBox.Show("Debe elegir el mes de Nacimiento del Empleado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Pest1_ComBox_FechaMes.Focus();
                return;
            }

            if (Pest1_ComBox_FechaAño.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el Año de Nacimiento del Empleado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Pest1_ComBox_FechaAño.Focus();
                return;
            }

            if (Pest1_ComBox_FechaDia.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el dia de Nacimiento del Empleado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Pest1_ComBox_FechaDia.Focus();
                return;
            }

           


            if (Pest1_ComBox_GeneroEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("El Genero del Empleado es Requerido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Pest1_ComBox_GeneroEmpleado.Focus();
                return;
            }

            if (Pest1_ComBox_RolEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe elegir un Rol para el Empleado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Pest1_ComBox_RolEmpleado.Focus();
                return;
            }

            if (Pest1_Mask_CelularEmpleado.Mask == "")
            {
                MessageBox.Show("El Numero Celular del Empleado es Requerido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Pest1_Mask_CelularEmpleado.Focus();
                return;
            }

            if (Pest1_Mask_NumeroFijoEmpleado.Mask == "")
            {
                MessageBox.Show("El Numero Fijo del Empleado es Requerido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Pest1_Mask_NumeroFijoEmpleado.Focus();
                return;
            }

            Fun_AgregarEmpleado();
        }
        private void Fun_AgregarEmpleado()
        {
            Emp.Var_Telefono_fijo = Pest1_Mask_NumeroFijoEmpleado.Text;
            Emp.Var_Telefono_celular = Pest1_Mask_CelularEmpleado.Text;
            Emp.Var_Nombre_empleado = Pest1_Txt_NombreEmpleado.Text;
            Emp.Var_Id_empleado = Pest1_Txt_ID.Text;
            Emp.Var_Genero = Convert.ToString(Pest1_ComBox_GeneroEmpleado.SelectedItem);
            Emp.Var_Fecha_nacimiento =
                (Convert.ToString(Pest1_ComBox_FechaAño.SelectedItem) + "-" +
                Convert.ToString(Convert.ToInt16(Pest1_ComBox_FechaMes.SelectedIndex) + 1) + "-" +
                Convert.ToString(Pest1_ComBox_FechaDia.SelectedItem));

            Emp.Var_Estado_civil= Convert.ToString(Pest1_ComBox_EstadoCivil.SelectedItem);
            Emp.Var_Contrasena = Val.EncriptarContraseña(Convert.ToString(Pest1_Txt_Contraseña.Text));

            Emp.Var_Rol = Convert.ToString(Pest1_ComBox_RolEmpleado.SelectedValue.ToString());


            Emp.Var_Codigo_estado = Convert.ToString(Pest1_ComBox_Estado.SelectedItem);
            Emp.Var_Codigo_empleado = Convert.ToInt16(Pest1_Txt_CodigoEmpleado.Text);
            Emp.Var_Apellido_empleado = Convert.ToString(Pest1_Txt_ApellidoEmpleado.Text);
            Emp.Var_Correo_empleado = Convert.ToString(Pest1_Text_CorreoEmpleado.Text);
            Emp.Var_Direccion= Convert.ToString(Pest1_Text_Direccion.Text);


            if (Emp.RevisionDeDatos()==false)
            {
                MessageBox.Show("Existe una duplicación de datos ya sea por el Numero de Identidad"+
                "o el Nombre completo del empleado, por favor revise nuevamente los datos del Nuevo empleado.", "Duplicacion de Datos", MessageBoxButtons.OK);
                return;
            } else
            {
                Emp.IngresoDatos();
            }
            //LimpiarTodo();
        }

        private void Fun_ExtraerFechaActual()
        {
            int años=0;
            años = DateTime.Now.Year;
            for (int i = (años- 60); i < (años - 18); i++)
            {
                Pest1_ComBox_FechaAño.Items.Add(i);
                //28 de Nociembre a las 4, semi formales
            }
        }

        public void Fun_LLenarDias()
        {
            
            if (Pest1_ComBox_FechaAño.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el año de Nacimiento");
                return;
            }

            int daias = System.DateTime.DaysInMonth(Convert.ToInt16(Pest1_ComBox_FechaAño.SelectedItem), (Convert.ToInt16(Pest1_ComBox_FechaMes.SelectedIndex)+1));
 
            for (int i = 1; i < (daias +1); i++)
            {
                    Pest1_ComBox_FechaDia.Items.Add(i);
                
                //28 de Nociembre a las 4, semi formales
            }
        }
        public void Fun_ExtraerRoles()
        {
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select Codigo_Rol, Descripcion from Rol");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);           
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable(); 
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();


            Con.Dr = Con.dt.NewRow();
            Con.dt.Rows.InsertAt(Con.Dr, 0);

            Pest1_ComBox_RolEmpleado.ValueMember = "Codigo_Rol";
            Pest1_ComBox_RolEmpleado.DisplayMember = "Descripcion";
            Pest1_ComBox_RolEmpleado.DataSource = Con.dt;
        }


        private void LimpiarTodo()
        {
            Emp.OptenerUltimoID();
            Pest1_Txt_ApellidoEmpleado.Text = "";
            Pest1_Text_CorreoEmpleado.Text = "";
            Pest1_Text_Direccion.Text = "";
            Pest1_Txt_ID.Text = "";
            Pest1_Txt_NombreEmpleado.Text = "";
            Pest1_ComBox_EstadoCivil.SelectedIndex = -1;
            Pest1_ComBox_FechaAño.SelectedIndex = -1;
            Pest1_ComBox_FechaDia.SelectedIndex = -1;
            Pest1_ComBox_FechaMes.SelectedIndex = -1;
            Pest1_ComBox_GeneroEmpleado.SelectedIndex = -1;
            Pest1_ComBox_RolEmpleado.SelectedIndex = -1;
            Pest1_Mask_CelularEmpleado.Mask = "";
            Pest1_Mask_NumeroFijoEmpleado.Mask = "";

        }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////

///////////////////////////////////////////////////////////////////////////////////////////////////////////////
//CASO: Buscar Empleado
/// </summary>

        public void Fun_CargarPrimerDataGriew(DataGridView dgv)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                con.DataAdapter = new SqlDataAdapter("select A.Codigo_Empleado as Codigo,  A.ID as Id, Nombre, A.Apellido, A.Correo, A.TelefonoCelular as Telefono, A.TelefonoFijo as Celular, A.Contraseña, A.Direccion, b.Descripcion, (select Descripcion_Estado from Estados where Codigo_Tipo_Estado = 1 and Codigo_Estado = A.Codigo_Estado) as Estado from Empleados as A inner join Rol as b on A.Codigo_Rol = B.Codigo_Rol", con.ccnx);
                con.dt = new DataTable();
                con.DataAdapter.Fill(con.dt);
                dgv.DataSource = con.dt;

            }
            catch
            {

            }
        }

        private void Pest2_Bttn_Actualizar_Click(object sender, EventArgs e)
        {
            Pest2_Radio_Codigo.Checked = false;
            Pest2_Radio_ID.Checked = false;
            Pest2_Radio_Nombre.Checked = false;
            Fun_CargarPrimerDataGriew(Pest2_DataGriew_InformacionEmpleado);
            Pest2_Txt_CodigoBuscar.Text = "";
            Pest2_Txt_IDBuscar.Text ="";
            Pest2_Txt_NombreBuscar.Text ="";
        }

        private void Pest2_Txt_CodigoBuscar_TextChanged(object sender, EventArgs e)
        {
            if (Pest2_Txt_CodigoBuscar.Text == "") {
                Fun_CargarPorCodigo(Pest2_DataGriew_InformacionEmpleado, Convert.ToInt16(0));

            }
            else
            {
                Fun_CargarPorCodigo(Pest2_DataGriew_InformacionEmpleado, Convert.ToInt16(Convert.ToInt16(Pest2_Txt_CodigoBuscar.Text)));
            }
            }

        public void Fun_CargarPorCodigo(DataGridView dgv, int a)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                int busq;
                busq = a;
                

                con.sql = string.Format
                (@"select A.Codigo_Empleado as Codigo, A.ID as Id, Nombre, A.Apellido, A.Correo, 
                  A.TelefonoCelular as Telefono, A.TelefonoFijo as Celular, A.Contraseña, A.Direccion, 
                  b.Descripcion, (select Descripcion_Estado from Estados where Codigo_Tipo_Estado = 1 
                  and Codigo_Estado = A.Codigo_Estado) as Estado from Empleados as A inner join Rol as b on 
                  A.Codigo_Rol = B.Codigo_Rol where A.Codigo_Empleado like '%{0}%'", busq);
                con.cmd = new SqlCommand(con.sql, con.cnx);
                con.DataAdapter = new SqlDataAdapter(con.cmd);
                con.dt = new DataTable();
                con.DataAdapter.Fill(con.dt);
                dgv.DataSource = con.dt;

            }
            catch
            {

            }
        }


        public void Fun_CargarPorNombre(DataGridView dgv, string a)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                string busq;
                busq = a;


                con.sql = string.Format
                (@"select A.Codigo_Empleado as Codigo, A.ID as Id, Nombre, A.Apellido, A.Correo, 
                  A.TelefonoCelular as Telefono, A.TelefonoFijo as Celular, A.Contraseña, A.Direccion, 
                  b.Descripcion, (select Descripcion_Estado from Estados where Codigo_Tipo_Estado = 1 
                  and Codigo_Estado = A.Codigo_Estado) as Estado from Empleados as A inner join Rol as b on 
                  A.Codigo_Rol = B.Codigo_Rol where  A.Nombre like '%{0}%'", busq);
                con.cmd = new SqlCommand(con.sql, con.cnx);
                con.DataAdapter = new SqlDataAdapter(con.cmd);
                con.dt = new DataTable();
                con.DataAdapter.Fill(con.dt);
                dgv.DataSource = con.dt;

            }
            catch
            {

            }
        }



        public void Fun_CargarPorID(DataGridView dgv, int a)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                int busq;
                busq = a;


                con.sql = string.Format
                (@"select A.Codigo_Empleado as Codigo, A.ID as Id, Nombre, A.Apellido, A.Correo, 
                  A.TelefonoCelular as Telefono, A.TelefonoFijo as Celular, A.Contraseña, A.Direccion, 
                  b.Descripcion, (select Descripcion_Estado from Estados where Codigo_Tipo_Estado = 1 
                  and Codigo_Estado = A.Codigo_Estado) as Estado from Empleados as A inner join Rol as b on 
                  A.Codigo_Rol = B.Codigo_Rol  where A.ID like '%{0}%'", busq);
                con.cmd = new SqlCommand(con.sql, con.cnx);
                con.DataAdapter = new SqlDataAdapter(con.cmd);
                con.dt = new DataTable();
                con.DataAdapter.Fill(con.dt);
                dgv.DataSource = con.dt;

            }
            catch
            {

            }
        }

        private void Pest2_Txt_NombreBuscar_TextChanged(object sender, EventArgs e)
        {
            if (Pest2_Txt_NombreBuscar.Text == "")
            { Fun_CargarPorNombre(Pest2_DataGriew_InformacionEmpleado, "a"); }
            else
            { Fun_CargarPorNombre(Pest2_DataGriew_InformacionEmpleado, Pest2_Txt_NombreBuscar.Text);
            }
        }

        private void Pest2_Txt_IDBuscar_TextChanged(object sender, EventArgs e)
        {
            if (Pest2_Txt_IDBuscar.Text == "")
            { Fun_CargarPorID(Pest2_DataGriew_InformacionEmpleado, Convert.ToInt16(0)); }
            else
            {
                Fun_CargarPorID(Pest2_DataGriew_InformacionEmpleado, Convert.ToInt16(Convert.ToInt16(Pest2_Txt_IDBuscar.Text)));
            }
        }






        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///CASO: Modificar Clientes
        ///

        public void Fun_DeshabilitarTextBox()
        {       
            Pest1_Txt_ApellidoEmpleado.Enabled=true;
            Pest1_Txt_CodigoEmpleado.Enabled=true;
            Pest1_Txt_ID.Enabled=true;
            Pest1_Txt_NombreEmpleado.Enabled=true;
        }


        public void Fun_ExtraerDatosATextBox()
        {

        }

        public void Fun_ExtraerEstados()
        {
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select Codigo_Estado, Descripcion_Estado from Estados where Codigo_Tipo_Estado = 1");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();


            Con.Dr = Con.dt.NewRow();
            Con.dt.Rows.InsertAt(Con.Dr, 0);

            Pest1_ComBox_Estado.ValueMember = "Codigo_Estado";
            Pest1_ComBox_Estado.DisplayMember = "Descripcion_Estado";
            Pest1_ComBox_Estado.DataSource = Con.dt;
        }
    }
}

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
        private bool CambiosRealizados=false;


        public Form_Manejo_de_Empleados()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            if (CambiosRealizados == true)
            {
                opcion = MessageBox.Show("No ha guardado los cambios realizados, ¿Quiere guardar los datos y salir?","",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Error);
                if (opcion == DialogResult.Yes)
                {
                    IngresoCambios();

                }
                else if (opcion == DialogResult.No)
                {
                    this.Close();
                }else if(opcion == DialogResult.Cancel)
                {
                    return;
                }
            }else
            {
                this.Close();
            }
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
            CambiosRealizados = false;
            Fun_CargarPrimerDataGriew(Pest2_DataGriew_InformacionEmpleado);//CASO: Buscar Empleado
            Pest1_Txt_CodigoEmpleado.Enabled = false;

            Fun_ExtraerRoles();//CASO: Agregar Nuevo Empleado
            Fun_ExtraerFechaActual();//CASO: Agregar Nuevo Empleado
            Fun_ExtraerEstados();

            var blankContextMenu = new ContextMenuStrip();
            Pest2_Txt_CodigoBuscar.ContextMenuStrip = blankContextMenu;
            Pest2_Txt_IDBuscar.ContextMenuStrip = blankContextMenu;
            Pest2_Txt_NombreBuscar.ContextMenuStrip = blankContextMenu;
  
            Pest1_Txt_ApellidoEmpleado.ContextMenuStrip = blankContextMenu;
            Pest1_Text_CorreoEmpleado.ContextMenuStrip = blankContextMenu;
            Pest1_Text_Direccion.ContextMenuStrip = blankContextMenu;
            Pest1_Txt_ID.ContextMenuStrip = blankContextMenu;
            Pest1_Txt_NombreEmpleado.ContextMenuStrip = blankContextMenu;
            Pest1_ComBox_FechaDia.ContextMenuStrip = blankContextMenu;
            Pest1_ComBox_EstadoCivil.ContextMenuStrip = blankContextMenu;
            Pest1_ComBox_FechaAño.ContextMenuStrip = blankContextMenu;
            Pest1_ComBox_FechaMes.ContextMenuStrip = blankContextMenu;
            Pest1_ComBox_GeneroEmpleado.ContextMenuStrip = blankContextMenu;
            Pest1_ComBox_RolEmpleado.ContextMenuStrip = blankContextMenu;
            Pest1_Mask_CelularEmpleado.ContextMenuStrip = blankContextMenu;
            Pest1_Mask_NumeroFijoEmpleado.ContextMenuStrip = blankContextMenu;
            Pest1_Txt_Contraseña.ContextMenuStrip = blankContextMenu;



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
            Pest1_Radio_Nuevo_Empleado.Checked = true;
            CambiosRealizados = false;
            Pest1_Txt_CodigoEmpleado.Text = Convert.ToString(Emp.OptenerUltimoID());


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
                if(Convert.ToInt16(a) == 0)
                {
                    
                    Pest1_Txt_CodigoEmpleado.Text = Pest2_DataGriew_InformacionEmpleado.CurrentCell.Value.ToString();
                    ExtraerPorNombre(Pest1_Txt_CodigoEmpleado.Text);
                    Pest1_Radio_Manejo.Checked = true;
                }
                else
                 if (Convert.ToInt16(a) == 1)
                {
                    
                    Pest1_Txt_ID.Text = Pest2_DataGriew_InformacionEmpleado.CurrentCell.Value.ToString();
                    ExtraerPorIdentidad(Pest1_Txt_ID.Text);
                    Pest1_Radio_Manejo.Checked = true;
                }
                CambiosRealizados = false;
                MessageBox.Show("Listo");                
           }      

        }

        /// <summary>
        /// FUNCION: CASO DE Modificar Empleado, Extraxxion de Todos los Datos
        /// </summary>
        public void ExtraerPorIdentidad(string Id)
        {
            Conexion Cn = new Conexion();
            Cn.sql = string.Format(@"select
                                        [Codigo_Empleado],
                                        [ID],
                                        [Nombre],
                                        [Apellido],
                                        [Correo],
                                        [TelefonoFijo],
                                        [TelefonoCelular],
                                        [FechaNacimiento],
                                        [Genero],
                                        [Contraseña],		
                                        [EstadoCivil],
                                        [Codigo_Rol],
                                        [Codigo_Estado],
                                        [Direccion],
                                        YEAR([FechaNacimiento]) as Año,
                                        MONTH([FechaNacimiento]) as Mes,
                                        DAY([FechaNacimiento]) as Dia
                                        from Empleados where ID='{0}'", Id);
            Cn.cmd = new SqlCommand(Cn.sql, Cn.cnx);
            Cn.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Cn.cmd.ExecuteReader();

            if (Reg.Read())
            {
                int dia, años;
                dia =Convert.ToInt16(Reg["Dia"].ToString());
                años = Convert.ToInt16(Reg["Año"].ToString()); ;

               Pest1_Txt_CodigoEmpleado.Text = (Reg["Codigo_Empleado"].ToString());
               Pest1_Txt_ApellidoEmpleado.Text = (Reg["Apellido"].ToString());
               Pest1_Text_CorreoEmpleado.Text = (Reg["Correo"].ToString());
               Pest1_Text_Direccion.Text = (Reg["Direccion"].ToString());
               Pest1_Txt_ID.Text = (Reg["ID"].ToString());
               Pest1_Txt_NombreEmpleado.Text = (Reg["Nombre"].ToString());


               Pest1_ComBox_GeneroEmpleado.SelectedItem = (Reg["Genero"].ToString());
               Pest1_ComBox_EstadoCivil.SelectedItem = (Reg["EstadoCivil"].ToString());
                Pest1_ComBox_FechaAño.SelectedItem = años;
               Pest1_ComBox_FechaMes.SelectedIndex = Convert.ToInt16((Reg["Mes"].ToString()))-1;
                Pest1_ComBox_FechaDia.SelectedItem = dia;

             
               Pest1_ComBox_RolEmpleado.SelectedIndex = Convert.ToInt16((Reg["Codigo_Rol"].ToString()));
               Pest1_Mask_CelularEmpleado.Text = (Reg["TelefonoCelular"].ToString());
               Pest1_Mask_NumeroFijoEmpleado.Text = (Reg["TelefonoFijo"].ToString());
               Pest1_Txt_Contraseña.Text = (Reg["Contraseña"].ToString());
               Pest1_ComBox_Estado.SelectedIndex = Convert.ToInt16((Reg["Codigo_Estado"].ToString()));



            }
            else
            {

            }
        }

        public void ExtraerPorNombre(string Cod)
        {
            Conexion Cn = new Conexion();
            Cn.sql = string.Format(@"select
                                        [Codigo_Empleado],
                                        [ID],
                                        [Nombre],
                                        [Apellido],
                                        [Correo],
                                        [TelefonoFijo],
                                        [TelefonoCelular],
                                        [FechaNacimiento],
                                        [Genero],
                                        [Contraseña],		
                                        [EstadoCivil],
                                        [Codigo_Rol],
                                        [Codigo_Estado],
                                        [Direccion],
                                        YEAR([FechaNacimiento]) as Año,
                                        MONTH([FechaNacimiento]) as Mes,
                                        DAY([FechaNacimiento]) as Dia
                                        from Empleados where Codigo_Empleado='{0}'", Cod);
            Cn.cmd = new SqlCommand(Cn.sql, Cn.cnx);
            Cn.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Cn.cmd.ExecuteReader();

            if (Reg.Read())
            {
                int dia, años;
                dia = Convert.ToInt16(Reg["Dia"].ToString());
                años = Convert.ToInt16(Reg["Año"].ToString()); ;

                Pest1_Txt_CodigoEmpleado.Text = (Reg["Codigo_Empleado"].ToString());
                Pest1_Txt_ApellidoEmpleado.Text = (Reg["Apellido"].ToString());
                Pest1_Text_CorreoEmpleado.Text = (Reg["Correo"].ToString());
                Pest1_Text_Direccion.Text = (Reg["Direccion"].ToString());
                Pest1_Txt_ID.Text = (Reg["ID"].ToString());
                Pest1_Txt_NombreEmpleado.Text = (Reg["Nombre"].ToString());


                Pest1_ComBox_GeneroEmpleado.SelectedItem = (Reg["Genero"].ToString());
                Pest1_ComBox_EstadoCivil.SelectedItem = (Reg["EstadoCivil"].ToString());
                Pest1_ComBox_FechaAño.SelectedItem = años;
                Pest1_ComBox_FechaMes.SelectedIndex = Convert.ToInt16((Reg["Mes"].ToString())) - 1;
                Pest1_ComBox_FechaDia.SelectedItem = dia;


                Pest1_ComBox_RolEmpleado.SelectedIndex = Convert.ToInt16((Reg["Codigo_Rol"].ToString()));
                Pest1_Mask_CelularEmpleado.Text = (Reg["TelefonoCelular"].ToString());
                Pest1_Mask_NumeroFijoEmpleado.Text = (Reg["TelefonoFijo"].ToString());
                Pest1_Txt_Contraseña.Text = (Reg["Contraseña"].ToString());
                Pest1_ComBox_Estado.SelectedIndex = Convert.ToInt16((Reg["Codigo_Estado"].ToString()));



            }
            else
            {

            }
        }




        public void ExtraerPorCodigo(int Codigo)
        {

        }


        private void Picture_Click(object sender, EventArgs e)
        {
           
        }


        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (Pest1_Radio_Manejo.Checked == true)
            {
                CambiosRealizados = true;
            }
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

                Pest1_Txt_ApellidoEmpleado.Enabled = true;
                Pest1_ComBox_FechaDia.Enabled = true;
                Pest1_ComBox_FechaAño.Enabled = true;
                Pest1_ComBox_FechaMes.Enabled = true;
                Pest1_ComBox_GeneroEmpleado.Enabled = true;
                Pest1_Txt_ID.Enabled = true;
                Pest1_Txt_NombreEmpleado.Enabled = true;
            }
            else
            {
                Pest1_ComBox_Estado.Enabled = true;
                Pest1_ComBox_Estado.SelectedValue = (1);

                Pest1_Txt_ApellidoEmpleado.Enabled = false;
                 Pest1_ComBox_FechaDia.Enabled = false;
                 Pest1_ComBox_FechaAño.Enabled = false;
                 Pest1_ComBox_FechaMes.Enabled = false;
                Pest1_ComBox_GeneroEmpleado.Enabled = false;
                Pest1_Txt_ID.Enabled = false;
                Pest1_Txt_NombreEmpleado.Enabled = false;
            }

        }

        private void Pest1_Radio_Manejo_CheckedChanged(object sender, EventArgs e)
        {
           
            if(Pest1_Radio_Nuevo_Empleado.Checked== true)
            {
                
                Pest1_ComBox_Estado.SelectedValue = (1);
            }
        }


        private void Pest1_Guardar_Click(object sender, EventArgs e)
        {
            if (Pest1_Radio_Nuevo_Empleado.Checked == true)//CASO: Agregar Empleado
            {
                Fun_Ajecutar();//CASO: Agregar Empleado
            }
            else if(Pest1_Radio_Manejo.Checked== true)
            {
                IngresoCambios();
                CambiosRealizados = false;
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


            if (Pest1_Text_CorreoEmpleado.Text == "")
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

            if (Pest1_Mask_CelularEmpleado.Text == "")
            {
                MessageBox.Show("El Numero Celular del Empleado es Requerido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Pest1_Mask_CelularEmpleado.Focus();
                return;
            }

            if (Pest1_Mask_NumeroFijoEmpleado.Text == "")
            {
                MessageBox.Show("El Numero Fijo del Empleado es Requerido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Pest1_Mask_NumeroFijoEmpleado.Focus();
                return;
            }

            if (Pest1_ComBox_EstadoCivil.SelectedIndex == -1)
            {
                
                Pest1_ComBox_RolEmpleado.SelectedIndex=(1);
                return;
            }

            if (Pest1_Text_Direccion.Text == "")
            {
                MessageBox.Show("La direccion del Empleado es Requerido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Pest1_Text_Direccion.Focus();
                return;
            }

            if (Pest1_Txt_Contraseña.Text == "")
            {
                MessageBox.Show("La contraseña del Empleado es Requerido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Pest1_Txt_Contraseña.Focus();
                return;
            }

            if (Val.Verificaremail(Pest1_Text_CorreoEmpleado.Text) == true) {   } else {

                MessageBox.Show("El correo no tiene el formato Valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Pest1_Text_CorreoEmpleado.Focus();
                return;
            }

            if (Pest1_Txt_ID.Text.Trim().Length < 5)
            {
                MessageBox.Show("El ID debe ser almenos de 5 digitos de Longitud", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Pest1_Txt_ID.Focus();
                return;
            }

            if (Pest1_Txt_Contraseña.Text.Trim().Length < 8)
            {
                MessageBox.Show("La contraseña debe ser almenos de 8 digitos de Longitud", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Pest1_Txt_Contraseña.Focus();
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
            Emp.Var_Codigo_estado = Convert.ToString(Pest1_ComBox_Estado.SelectedValue);
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

                for (int i = 1; i < 32; i++)
                {
                    Pest1_ComBox_FechaDia.Items.Add(i);

                    //28 de Nociembre a las 4, semi formales
                }
            }
            else
            {

                int daias = System.DateTime.DaysInMonth(Convert.ToInt16(Pest1_ComBox_FechaAño.SelectedItem), (Convert.ToInt16(Pest1_ComBox_FechaMes.SelectedIndex) + 1));

                for (int i = 1; i < (daias + 1); i++)
                {
                    Pest1_ComBox_FechaDia.Items.Add(i);

                    //28 de Nociembre a las 4, semi formales
                }
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
            Pest1_Txt_CodigoEmpleado.Text = Convert.ToString(Emp.OptenerUltimoID());
            Pest1_Txt_ApellidoEmpleado.Text = "";
            Pest1_Text_CorreoEmpleado.Text = "";
            Pest1_Text_Direccion.Text = "";
            Pest1_Txt_ID.Text = "";
            Pest1_Txt_NombreEmpleado.Text = "";
            Pest1_ComBox_FechaDia.SelectedIndex = -1;
            Pest1_ComBox_EstadoCivil.SelectedIndex = -1;
            Pest1_ComBox_FechaAño.SelectedIndex = -1;
            Pest1_ComBox_FechaMes.SelectedIndex = -1;
            Pest1_ComBox_GeneroEmpleado.SelectedIndex = -1;
            Pest1_ComBox_RolEmpleado.SelectedIndex = -1;
            Pest1_Mask_CelularEmpleado.Text = String.Empty;
            Pest1_Mask_NumeroFijoEmpleado.Text = String.Empty; 
            Pest1_Txt_Contraseña.Text = String.Empty;
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
                Fun_CargarPrimerDataGriew(Pest2_DataGriew_InformacionEmpleado);

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
            { Fun_CargarPrimerDataGriew(Pest2_DataGriew_InformacionEmpleado); }
            else
            { Fun_CargarPorNombre(Pest2_DataGriew_InformacionEmpleado, Pest2_Txt_NombreBuscar.Text);
            }
        }

        private void Pest2_Txt_IDBuscar_TextChanged(object sender, EventArgs e)
        {
            if (Pest2_Txt_IDBuscar.Text == "")
            { Fun_CargarPrimerDataGriew(Pest2_DataGriew_InformacionEmpleado); }
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
            Pest1_Txt_ApellidoEmpleado.Enabled=false;
            Pest1_Txt_CodigoEmpleado.Enabled=false;
            Pest1_Txt_ID.Enabled=false;
            Pest1_Txt_NombreEmpleado.Enabled=false;
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

        private void Pest1_ComBox_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Pest1_Radio_Manejo.Checked == true)
            {
                CambiosRealizados = true;
            }
        }

        private void Pest1_ComBox_EstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Pest1_Radio_Manejo.Checked == true)
            {
                CambiosRealizados = true;
            }
        }

        private void Pest1_Mask_NumeroFijoEmpleado_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (Pest1_Radio_Manejo.Checked == true)
            {
                CambiosRealizados = true;
            }
        }

        private void Pest1_ComBox_RolEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Pest1_Radio_Manejo.Checked == true)
            {
                CambiosRealizados = true;
            }
        }

        private void Pest1_Text_Direccion_TextChanged(object sender, EventArgs e)
        {
            if (Pest1_Radio_Manejo.Checked == true)
            {
                CambiosRealizados = true;
            }
        }

        private void Pest1_Text_CorreoEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (Pest1_Radio_Manejo.Checked == true)
            {
                CambiosRealizados = true;
            }
        }

        private void Pest1_Txt_Contraseña_TextChanged(object sender, EventArgs e)
        {
            if (Pest1_Radio_Manejo.Checked == true)
            {
                 CambiosRealizados = true;

            }
            
        }

        private void IngresoCambios()
        {
            int Est=0, cod_r=0;
            string esta_civil="";
            string Contraseña_cambiada="";

            Est = Convert.ToInt16(Pest1_ComBox_Estado.SelectedValue);
            cod_r =Convert.ToInt16( Pest1_ComBox_RolEmpleado.SelectedValue);
            esta_civil = Convert.ToString(Pest1_ComBox_EstadoCivil.SelectedItem);

            Contraseña_cambiada = Val.EncriptarContraseña(Pest1_Txt_Contraseña.Text);

                 //  public void Fun_MoodificarDatos(string Telefono, int Estado, string Civil, int CodigoRol, string Direccion, string correo, string contra, string fijo, int Codigo_e)
        

            Emp.Fun_MoodificarDatos(
                Pest1_Mask_CelularEmpleado.Text, 
                Est, 
                esta_civil, 
                cod_r, 
                Pest1_Text_Direccion.Text, 
                Pest1_Text_CorreoEmpleado.Text,
                Contraseña_cambiada,
                Pest1_Mask_NumeroFijoEmpleado.Text ,
                Convert.ToInt16(Pest1_Txt_CodigoEmpleado.Text));
        
        }
    }
}

using Desarrollo.Clases;
using Desarrollo.Pantallas.Manueales;
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
    public partial class Form_Manejo_de_Empleados : System.Windows.Forms.Form
    {
        C_Empleados Cl_Emp = new C_Empleados();
        Validaciones Cl_Val = new Validaciones();

        private bool LEmp_CambiosRealizados = false;
        public string LEmp_NombEmp="";

        public Form_Manejo_de_Empleados()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            if (LEmp_CambiosRealizados == true)
            {
                opcion = MessageBox.Show("No ha guardado los cambios realizados, ¿Quiere guardar los datos y salir?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
                if (opcion == DialogResult.Yes)
                {
                    IngresoCambios();

                }
                else if (opcion == DialogResult.No)
                {
                    this.Close();
                } else if (opcion == DialogResult.Cancel)
                {
                    return;
                }
            } else
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
            LEmp_CambiosRealizados = false;
            Cl_Emp.Fun_CargarPrimerDataGriew(Pest2_DataGriew_InformacionEmpleado);
            Pest1_Txt_CodigoEmpleado.Enabled = false;
            Cl_Emp.Fun_ExtraerRoles(Pest1_ComBox_RolEmpleado);
            Cl_Val.ExtraerFechaNacimientoPermitida(Pest1_ComBox_FechaAño);
            Cl_Emp.Fun_ExtraerEstados(Pest1_ComBox_Estado);
            Cl_Emp.Fun_ExtraerLocalidades(Comb_Localidad);



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
            { this.empleadosTableAdapter.Fill(this.ventasAutoPartesDataSet.Empleados); }
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
            LEmp_CambiosRealizados = false;
            Pest1_Txt_CodigoEmpleado.Text = Convert.ToString(Cl_Emp.Fun_OptenerUltimoID());


        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void Pest2_DataGriew_InformacionEmpleado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string a;
            a = Pest2_DataGriew_InformacionEmpleado.CurrentCell.ColumnIndex.ToString();

            if (Convert.ToInt16(a) == 1 || Convert.ToInt16(a) == 0)
            {
                LimpiarTodo();
                if (Convert.ToInt16(a) == 0)
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
                LEmp_CambiosRealizados = false;
                MessageBox.Show("Listo");
            }

        }


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
                                        DAY([FechaNacimiento]) as Dia,
										Cod_Localidad
                                        from Empleados where ID='{0}'", Id);
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
                Comb_Localidad.SelectedValue = Convert.ToInt16((Reg["Cod_Localidad"].ToString()));



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
                                        DAY([FechaNacimiento]) as Dia,
										Cod_Localidad
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
                Comb_Localidad.SelectedValue = Convert.ToInt16((Reg["Cod_Localidad"].ToString()));


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
                LEmp_CambiosRealizados = true;
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
            else { Pest2_Txt_CodigoBuscar.Enabled = false; }
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
            if (Pest1_Radio_Nuevo_Empleado.Checked == true)
            {
                Pest1_ComBox_Estado.Enabled = false;
                Pest1_ComBox_Estado.SelectedValue = (4);
                Pest1_Txt_CodigoEmpleado.Text = Convert.ToString(Cl_Emp.Fun_OptenerUltimoID());
                Pest1_Txt_Contraseña.Enabled = true;
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
                Pest1_Txt_Contraseña.Enabled = false;
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

            if (Pest1_Radio_Nuevo_Empleado.Checked == true)
            {

                Pest1_ComBox_Estado.SelectedValue = (1);
                Pest1_Txt_Contraseña.Enabled = true;
            }
        }

        private void Pest1_Guardar_Click(object sender, EventArgs e)
        {
            if (Pest1_Radio_Nuevo_Empleado.Checked == true)
            {
                
                Fun_Ajecutar();
                Cl_Emp.IngresoLogin();
                LimpiarTodo();
                LEmp_CambiosRealizados = false;
            }
            else if (Pest1_Radio_Manejo.Checked == true)
            {
                IngresoCambios();
                LEmp_CambiosRealizados = false;
            }
        }

        private void Pest1_Txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
         
            Cl_Val.ValidarID(sender, e);//Validacion de ID
        }

        private void Pest1_Txt_NombreEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Val.PrimeroMayuscula(sender, e, Pest1_Txt_NombreEmpleado);
            Cl_Val.ValirLetrasYEspacios(sender, e, Pest1_Txt_NombreEmpleado);
        }

        private void Pest1_Txt_ApellidoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Val.PrimeroMayuscula(sender, e, Pest1_Txt_ApellidoEmpleado);
            Cl_Val.ValirLetrasYEspacios(sender, e, Pest1_Txt_ApellidoEmpleado);
        }

        private void Pest1_Text_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Val.ValirLetrasYEspacios_Direccion(sender, e, Pest1_Text_Direccion);
        }

        private void Pest1_Text_CorreoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Val.ValidarCorreoIngreso(sender, e, Pest1_Text_CorreoEmpleado);
        }

        private void Pest1_Txt_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Val.ValidarPassword(sender, e);
        }

        private void Pest2_Txt_CodigoBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Val.ValidarID(sender, e);
        }

        private void Pest2_Txt_IDBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Val.ValidarID(sender, e);
        }

        private void Pest2_Txt_NombreBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Pest1_ComBox_FechaMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pest1_ComBox_FechaDia.Items.Clear();
            Fun_LLenarDias();

        }

        private void Fun_Ajecutar()
        {
            bool resp = false;


            if (string.IsNullOrWhiteSpace(Pest1_Txt_ID.Text)) {
                errorProvider1.SetError(Pest1_Txt_ID, "Por favor, El ID del empleado es requerido");
                Pest1_Txt_ID.Focus();
                resp = true;
            }
            else { errorProvider1.SetError(Pest1_Txt_ID, ""); }


            if (string.IsNullOrWhiteSpace(Pest1_Txt_NombreEmpleado.Text))
            { errorProvider1.SetError(Pest1_Txt_NombreEmpleado, "Por favor, El Nombre del empleado es requerido");
                Pest1_Txt_NombreEmpleado.Focus();
                resp = true;
            } else { errorProvider1.SetError(Pest1_Txt_NombreEmpleado, ""); }



            if (string.IsNullOrWhiteSpace(Pest1_Txt_ApellidoEmpleado.Text))
            { errorProvider1.SetError(Pest1_Txt_ApellidoEmpleado, "Por favor, El Apellido del empleado es requerido");
                Pest1_Txt_ApellidoEmpleado.Focus();
                resp = true;
            }
            else { errorProvider1.SetError(Pest1_Txt_ApellidoEmpleado, ""); }


            if (string.IsNullOrWhiteSpace(Pest1_Text_CorreoEmpleado.Text))
            { errorProvider1.SetError(Pest1_Text_CorreoEmpleado, "Por favor, El correo del empleado es requerido");
                Pest1_Text_CorreoEmpleado.Focus();
                resp = true;
            } else { errorProvider1.SetError(Pest1_Text_CorreoEmpleado, ""); }


            if (Pest1_ComBox_FechaMes.SelectedIndex == -1)
            {  errorProvider1.SetError(Pest1_ComBox_FechaMes, "Por favor, seleccione el mes de nacimiento del empleado");
                Pest1_ComBox_FechaMes.Focus();
                resp = true;
            }
            else { errorProvider1.SetError(Pest1_ComBox_FechaMes, ""); }


            if (Pest1_ComBox_FechaAño.SelectedIndex == -1)
            { errorProvider1.SetError(Pest1_ComBox_FechaAño, "Por favor, seleccione el año de nacimiento del empleado");
                Pest1_ComBox_FechaAño.Focus();
                resp = true;
            }
            else { errorProvider1.SetError(Pest1_ComBox_FechaAño, ""); }


            if (Pest1_ComBox_FechaDia.SelectedIndex == -1)
            {
                errorProvider1.SetError(Pest1_ComBox_FechaDia, "Por favor, seleccione el año de nacimiento del empleado");
                Pest1_ComBox_FechaDia.Focus();
                resp = true;
            }
            else { errorProvider1.SetError(Pest1_ComBox_FechaDia, "");
            }

            /// 

            if (Pest1_ComBox_GeneroEmpleado.SelectedIndex == -1)
            {
                errorProvider1.SetError(Pest1_ComBox_GeneroEmpleado, "Por favor, seleccione el genero del empleado");
                Pest1_ComBox_GeneroEmpleado.Focus();
                resp = true;
            }
            else {errorProvider1.SetError(Pest1_ComBox_GeneroEmpleado, "");
            }



            if (Pest1_ComBox_EstadoCivil.SelectedIndex == -1)
            {
                errorProvider1.SetError(Pest1_ComBox_EstadoCivil, "Por favor, seleccione el estado civil del empleado");
                Pest1_ComBox_EstadoCivil.Focus();
                resp = true;
            }
            else { errorProvider1.SetError(Pest1_ComBox_EstadoCivil, "");
            }

            if (Pest1_ComBox_RolEmpleado.SelectedIndex == -1)
            {
                errorProvider1.SetError(Pest1_ComBox_RolEmpleado, "Por favor, seleccione el rol del empleado");
                Pest1_ComBox_RolEmpleado.Focus();
                resp = true;
            }
            else { errorProvider1.SetError(Pest1_ComBox_RolEmpleado, "");
            }

            //

            if (string.IsNullOrWhiteSpace(Pest1_Txt_Contraseña.Text))
            {
                errorProvider1.SetError(Pest1_Txt_Contraseña, "Por favor, La contraseña del empleado es requerido");
                Pest1_Txt_Contraseña.Focus();
                resp = true;
            }
            else { errorProvider1.SetError(Pest1_Txt_Contraseña, ""); }



            if (string.IsNullOrWhiteSpace(Pest1_Text_Direccion.Text))
            {
                errorProvider1.SetError(Pest1_Text_Direccion, "Por favor, La direccion del empleado es requerido");
                Pest1_Text_Direccion.Focus();
                resp = true;
            }
            else { errorProvider1.SetError(Pest1_Text_Direccion, ""); }


            if (string.IsNullOrWhiteSpace(Pest1_Mask_NumeroFijoEmpleado.Text))
            {
                errorProvider1.SetError(Pest1_Mask_NumeroFijoEmpleado, "Por favor, El Numero Fijo del empleado es requerido");
                Pest1_Mask_NumeroFijoEmpleado.Focus();
                resp = true;
            }
            else { errorProvider1.SetError(Pest1_Mask_NumeroFijoEmpleado, ""); }

            if (string.IsNullOrWhiteSpace(Pest1_Mask_CelularEmpleado.Text))
            {
                errorProvider1.SetError(Pest1_Mask_CelularEmpleado, "Por favor, El Numero celular del empleado es requerido");
                Pest1_Mask_CelularEmpleado.Focus();
                resp = true;
            }
            else { errorProvider1.SetError(Pest1_Mask_CelularEmpleado, ""); }


            if (Cl_Val.Verificaremail(Pest1_Text_CorreoEmpleado.Text) == true) { } else {

                errorProvider1.SetError(Pest1_Text_CorreoEmpleado, "El correo no tiene el formato Valido");
                Pest1_Text_CorreoEmpleado.Focus();
                return;
            }


            if (Pest1_Txt_ID.Text.Trim().Length < 5)
            {
                errorProvider1.SetError(Pest1_Txt_ID, "El ID debe ser almenos de 5 digitos de Longitud");
                Pest1_Txt_ID.Focus();
                return;
            }

            if (Pest1_Txt_Contraseña.Text.Trim().Length < 8)
            {
                errorProvider1.SetError(Pest1_Txt_Contraseña, "La contraseña debe ser almenos de 8 digitos de Longitud");
                Pest1_Txt_Contraseña.Focus();
                return;
            }

            if(resp == true){
                return; }
            else{
                Fun_AgregarEmpleado(); }
        }

        private void Fun_AgregarEmpleado()
        {
            Cl_Emp.Var_Telefono_fijo = Pest1_Mask_NumeroFijoEmpleado.Text;
            Cl_Emp.Var_Telefono_celular = Pest1_Mask_CelularEmpleado.Text;
            Cl_Emp.Var_Nombre_empleado = Pest1_Txt_NombreEmpleado.Text;
            Cl_Emp.Var_Id_empleado = Pest1_Txt_ID.Text;
            Cl_Emp.Var_Genero = Convert.ToString(Pest1_ComBox_GeneroEmpleado.SelectedItem);
            Cl_Emp.Var_Fecha_nacimiento =
                (Convert.ToString(Pest1_ComBox_FechaAño.SelectedItem) + "-" +
                Convert.ToString(Convert.ToInt16(Pest1_ComBox_FechaMes.SelectedIndex) + 1) + "-" +
                Convert.ToString(Pest1_ComBox_FechaDia.SelectedItem));
            Cl_Emp.Var_Estado_civil = Convert.ToString(Pest1_ComBox_EstadoCivil.SelectedItem);
            Cl_Emp.Var_Contrasena = Cl_Val.EncriptarContraseña(Convert.ToString(Pest1_Txt_Contraseña.Text));
            Cl_Emp.Var_Rol = Convert.ToString(Pest1_ComBox_RolEmpleado.SelectedValue.ToString());
            Cl_Emp.Var_Codigo_estado = Convert.ToString(Pest1_ComBox_Estado.SelectedValue);
            Cl_Emp.Var_Codigo_empleado = Convert.ToInt16(Pest1_Txt_CodigoEmpleado.Text);
            Cl_Emp.Var_Apellido_empleado = Convert.ToString(Pest1_Txt_ApellidoEmpleado.Text);
            Cl_Emp.Var_Correo_empleado = Convert.ToString(Pest1_Text_CorreoEmpleado.Text);
            Cl_Emp.Var_Direccion = Convert.ToString(Pest1_Text_Direccion.Text);
            Cl_Emp.Localidad= Convert.ToInt16(Comb_Localidad.SelectedValue);
            if (Cl_Emp.Fun_RevisionDeDatos() == false)
            {
                MessageBox.Show("Existe una duplicación de datos ya sea por el Numero de Identidad" +
                "o el Nombre completo del empleado, por favor revise nuevamente los datos del Nuevo empleado.", "Duplicacion de Datos", MessageBoxButtons.OK);
                return;
            } else
            {
                Cl_Emp.Fun_IngresoDatos();
                Cl_Emp.Fun_IngresoHistoricos(Convert.ToString(Pest1_ComBox_Estado.DisplayMember),
                    Convert.ToString(Pest1_ComBox_RolEmpleado.DisplayMember), LEmp_NombEmp);

                MessageBox.Show("Se ha ingresado un Nuevo Empleado", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cl_Emp.Fun_CargarPrimerDataGriew(Pest2_DataGriew_InformacionEmpleado);
            }
            //LimpiarTodo();

        }
        
        public void Fun_LLenarDias()
        {

            if (Pest1_ComBox_FechaAño.SelectedIndex == -1)
            {

                for (int i = 1; i < 32; i++)
                {
                    Pest1_ComBox_FechaDia.Items.Add(i);

                }
            }
            else
            {

                int daias = System.DateTime.DaysInMonth(Convert.ToInt16(Pest1_ComBox_FechaAño.SelectedItem), (Convert.ToInt16(Pest1_ComBox_FechaMes.SelectedIndex) + 1));

                for (int i = 1; i < (daias + 1); i++)
                {
                    Pest1_ComBox_FechaDia.Items.Add(i);

                }
            }
        }

        private void LimpiarTodo()
        {
            Pest1_Txt_CodigoEmpleado.Text = Convert.ToString(Cl_Emp.Fun_OptenerUltimoID());
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

            errorProvider1.SetError(Pest1_Txt_ID, "");
            errorProvider1.SetError(Pest1_Txt_NombreEmpleado, "");
            errorProvider1.SetError(Pest1_Txt_ApellidoEmpleado, "");
            errorProvider1.SetError(Pest1_Text_CorreoEmpleado, "");
            errorProvider1.SetError(Pest1_ComBox_FechaMes, "");
            errorProvider1.SetError(Pest1_ComBox_FechaAño, "");
            errorProvider1.SetError(Pest1_ComBox_FechaDia, "");
            errorProvider1.SetError(Pest1_ComBox_GeneroEmpleado, "");
            errorProvider1.SetError(Pest1_ComBox_EstadoCivil, "");
            errorProvider1.SetError(Pest1_ComBox_RolEmpleado, "");
            errorProvider1.SetError(Pest1_Txt_Contraseña, "");
            errorProvider1.SetError(Pest1_Text_Direccion, "");
            errorProvider1.SetError(Pest1_Mask_NumeroFijoEmpleado, "");
            errorProvider1.SetError(Pest1_Mask_CelularEmpleado, "");


        }

        private void Pest2_Bttn_Actualizar_Click(object sender, EventArgs e)
        {
            Pest2_Radio_Codigo.Checked = false;
            Pest2_Radio_ID.Checked = false;
            Pest2_Radio_Nombre.Checked = false;
            Cl_Emp.Fun_CargarPrimerDataGriew(Pest2_DataGriew_InformacionEmpleado);
            Pest2_Txt_CodigoBuscar.Text = "";
            Pest2_Txt_IDBuscar.Text ="";
            Pest2_Txt_NombreBuscar.Text ="";
        }

        private void Pest2_Txt_CodigoBuscar_TextChanged(object sender, EventArgs e)
        {
            if (Pest2_Txt_CodigoBuscar.Text == "") {
                Cl_Emp.Fun_CargarPrimerDataGriew(Pest2_DataGriew_InformacionEmpleado);

            }
            else
            {
                Cl_Emp.Fun_CargarPorCodigo(Pest2_DataGriew_InformacionEmpleado, Convert.ToInt32(Convert.ToInt64(Pest2_Txt_CodigoBuscar.Text)));
            }
            }

        
        private void Pest2_Txt_NombreBuscar_TextChanged(object sender, EventArgs e)
        {
            if (Pest2_Txt_NombreBuscar.Text == "")
            { Cl_Emp.Fun_CargarPrimerDataGriew(Pest2_DataGriew_InformacionEmpleado); }
            else
            {
                Cl_Emp.Fun_CargarPorNombre(Pest2_DataGriew_InformacionEmpleado, Pest2_Txt_NombreBuscar.Text);
            }
        }

        private void Pest2_Txt_IDBuscar_TextChanged(object sender, EventArgs e)
        {
            if (Pest2_Txt_IDBuscar.Text == "")
            { Cl_Emp.Fun_CargarPrimerDataGriew(Pest2_DataGriew_InformacionEmpleado); }
            else
            {
                Cl_Emp.Fun_CargarPorID(Pest2_DataGriew_InformacionEmpleado, (Pest2_Txt_IDBuscar.Text));
            }
        }


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

        private void Pest1_ComBox_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Pest1_Radio_Manejo.Checked == true)
            {
                LEmp_CambiosRealizados = true;
            }
        }

        private void Pest1_ComBox_EstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Pest1_Radio_Manejo.Checked == true)
            {
                LEmp_CambiosRealizados = true;
            }
        }

        private void Pest1_Mask_NumeroFijoEmpleado_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (Pest1_Radio_Manejo.Checked == true)
            {
                LEmp_CambiosRealizados = true;
            }
        }

        private void Pest1_ComBox_RolEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Pest1_Radio_Manejo.Checked == true)
            {
                LEmp_CambiosRealizados = true;
            }
        }

        private void Pest1_Text_Direccion_TextChanged(object sender, EventArgs e)
        {
            if (Pest1_Radio_Manejo.Checked == true)
            {
                LEmp_CambiosRealizados = true;
            }
        }

        private void Pest1_Text_CorreoEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (Pest1_Radio_Manejo.Checked == true)
            {
                LEmp_CambiosRealizados = true;
            }
        }

        private void Pest1_Txt_Contraseña_TextChanged(object sender, EventArgs e)
        {
            if (Pest1_Radio_Manejo.Checked == true)
            {
                 LEmp_CambiosRealizados = true;

            }
            
        }

        private void IngresoCambiosBase()
        {
            
            int Est=0, cod_r=0;
            string esta_civil="";
            string Contraseña_cambiada="";

            Est = Convert.ToInt16(Pest1_ComBox_Estado.SelectedValue);
            cod_r =Convert.ToInt16( Pest1_ComBox_RolEmpleado.SelectedValue);
            esta_civil = Convert.ToString(Pest1_ComBox_EstadoCivil.SelectedItem);

            Contraseña_cambiada = Cl_Val.EncriptarContraseña(Pest1_Txt_Contraseña.Text);

            Cl_Emp.Fun_MoodificarDatos(
                Pest1_Mask_CelularEmpleado.Text, 
                Est, 
                esta_civil, 
                cod_r, 
                Pest1_Text_Direccion.Text, 
                Pest1_Text_CorreoEmpleado.Text,
                Contraseña_cambiada,
                Pest1_Mask_NumeroFijoEmpleado.Text ,
                Convert.ToInt16(Pest1_Txt_CodigoEmpleado.Text), 
                Convert.ToInt16(Comb_Localidad.SelectedValue));

            Cl_Emp.Var_Telefono_fijo = Pest1_Mask_NumeroFijoEmpleado.Text;
            Cl_Emp.Var_Telefono_celular = Pest1_Mask_CelularEmpleado.Text;
            Cl_Emp.Var_Nombre_empleado = Pest1_Txt_NombreEmpleado.Text;
            Cl_Emp.Var_Id_empleado = Pest1_Txt_ID.Text;
            Cl_Emp.Var_Codigo_empleado = Convert.ToInt16(Pest1_Txt_CodigoEmpleado.Text);
            Cl_Emp.Var_Apellido_empleado = Convert.ToString(Pest1_Txt_ApellidoEmpleado.Text);
            Cl_Emp.Var_Correo_empleado = Convert.ToString(Pest1_Text_CorreoEmpleado.Text);


            Cl_Emp.Fun_UpdateHistoricos(Convert.ToString(Pest1_ComBox_Estado.DisplayMember), Convert.ToString(Pest1_ComBox_RolEmpleado.DisplayMember), LEmp_NombEmp);
            Cl_Emp.Fun_CargarPrimerDataGriew(Pest2_DataGriew_InformacionEmpleado);
            LimpiarTodo();
        }




        private void IngresoCambios()
        {
            bool resp = false;


            if (string.IsNullOrWhiteSpace(Pest1_Txt_ID.Text))
            {
                errorProvider1.SetError(Pest1_Txt_ID, "Por favor, El ID del empleado es requerido");
                Pest1_Txt_ID.Focus();
                resp = true;
            }
            else { errorProvider1.SetError(Pest1_Txt_ID, ""); }


            if (string.IsNullOrWhiteSpace(Pest1_Txt_NombreEmpleado.Text))
            {
                errorProvider1.SetError(Pest1_Txt_NombreEmpleado, "Por favor, El Nombre del empleado es requerido");
                Pest1_Txt_NombreEmpleado.Focus();
                resp = true;
            }
            else { errorProvider1.SetError(Pest1_Txt_NombreEmpleado, ""); }



            if (string.IsNullOrWhiteSpace(Pest1_Txt_ApellidoEmpleado.Text))
            {
                errorProvider1.SetError(Pest1_Txt_ApellidoEmpleado, "Por favor, El Apellido del empleado es requerido");
                Pest1_Txt_ApellidoEmpleado.Focus();
                resp = true;
            }
            else { errorProvider1.SetError(Pest1_Txt_ApellidoEmpleado, ""); }


            if (string.IsNullOrWhiteSpace(Pest1_Text_CorreoEmpleado.Text))
            {
                errorProvider1.SetError(Pest1_Text_CorreoEmpleado, "Por favor, El correo del empleado es requerido");
                Pest1_Text_CorreoEmpleado.Focus();
                resp = true;
            }
            else { errorProvider1.SetError(Pest1_Text_CorreoEmpleado, ""); }


            if (Pest1_ComBox_FechaMes.SelectedIndex == -1)
            {
                errorProvider1.SetError(Pest1_ComBox_FechaMes, "Por favor, seleccione el mes de nacimiento del empleado");
                Pest1_ComBox_FechaMes.Focus();
                resp = true;
            }
            else { errorProvider1.SetError(Pest1_ComBox_FechaMes, ""); }


            if (Pest1_ComBox_FechaAño.SelectedIndex == -1)
            {
                errorProvider1.SetError(Pest1_ComBox_FechaAño, "Por favor, seleccione el año de nacimiento del empleado");
                Pest1_ComBox_FechaAño.Focus();
                resp = true;
            }
            else { errorProvider1.SetError(Pest1_ComBox_FechaAño, ""); }


            if (Pest1_ComBox_FechaDia.SelectedIndex == -1)
            {
                errorProvider1.SetError(Pest1_ComBox_FechaDia, "Por favor, seleccione el año de nacimiento del empleado");
                Pest1_ComBox_FechaDia.Focus();
                resp = true;
            }
            else
            {
                errorProvider1.SetError(Pest1_ComBox_FechaDia, "");
            }

            /// 

            if (Pest1_ComBox_GeneroEmpleado.SelectedIndex == -1)
            {
                errorProvider1.SetError(Pest1_ComBox_GeneroEmpleado, "Por favor, seleccione el genero del empleado");
                Pest1_ComBox_GeneroEmpleado.Focus();
                resp = true;
            }
            else
            {
                errorProvider1.SetError(Pest1_ComBox_GeneroEmpleado, "");
            }



            if (Pest1_ComBox_EstadoCivil.SelectedIndex == -1)
            {
                errorProvider1.SetError(Pest1_ComBox_EstadoCivil, "Por favor, seleccione el estado civil del empleado");
                Pest1_ComBox_EstadoCivil.Focus();
                resp = true;
            }
            else
            {
                errorProvider1.SetError(Pest1_ComBox_EstadoCivil, "");
            }

            if (Pest1_ComBox_RolEmpleado.SelectedIndex == -1)
            {
                errorProvider1.SetError(Pest1_ComBox_RolEmpleado, "Por favor, seleccione el rol del empleado");
                Pest1_ComBox_RolEmpleado.Focus();
                resp = true;
            }
            else
            {
                errorProvider1.SetError(Pest1_ComBox_RolEmpleado, "");
            }

            //

            if (string.IsNullOrWhiteSpace(Pest1_Txt_Contraseña.Text))
            {
                errorProvider1.SetError(Pest1_Txt_Contraseña, "Por favor, La contraseña del empleado es requerido");
                Pest1_Txt_Contraseña.Focus();
                resp = true;
            }
            else { errorProvider1.SetError(Pest1_Txt_Contraseña, ""); }



            if (string.IsNullOrWhiteSpace(Pest1_Text_Direccion.Text))
            {
                errorProvider1.SetError(Pest1_Text_Direccion, "Por favor, La direccion del empleado es requerido");
                Pest1_Text_Direccion.Focus();
                resp = true;
            }
            else { errorProvider1.SetError(Pest1_Text_Direccion, ""); }


            if (string.IsNullOrWhiteSpace(Pest1_Mask_NumeroFijoEmpleado.Text))
            {
                errorProvider1.SetError(Pest1_Mask_NumeroFijoEmpleado, "Por favor, El Numero Fijo del empleado es requerido");
                Pest1_Mask_NumeroFijoEmpleado.Focus();
                resp = true;
            }
            else { errorProvider1.SetError(Pest1_Mask_NumeroFijoEmpleado, ""); }

            if (string.IsNullOrWhiteSpace(Pest1_Mask_CelularEmpleado.Text))
            {
                errorProvider1.SetError(Pest1_Mask_CelularEmpleado, "Por favor, El Numero celular del empleado es requerido");
                Pest1_Mask_CelularEmpleado.Focus();
                resp = true;
            }
            else { errorProvider1.SetError(Pest1_Mask_CelularEmpleado, ""); }


            if (Cl_Val.Verificaremail(Pest1_Text_CorreoEmpleado.Text) == true) {
                errorProvider1.SetError(Pest1_Text_CorreoEmpleado, "");
            }
            else
            {

                errorProvider1.SetError(Pest1_Text_CorreoEmpleado, "El correo no tiene el formato Valido");
                Pest1_Text_CorreoEmpleado.Focus();
                return;
            }

            if (resp == true)
            {
                return;
            }
            else
            {
                IngresoCambiosBase();
            }
        }


        private void Pest1_Mask_NumeroFijoEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (Pest1_Radio_Manejo.Checked == true)
            {
                LEmp_CambiosRealizados = true;

            }
        }

        private void Pest1_Mask_CelularEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (Pest1_Radio_Manejo.Checked == true)
            {
                LEmp_CambiosRealizados = true;

            }
        }

        private void Pest1_Txt_CodigoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Pest1_Text_Direccion_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Cl_Val.PrimeroMayuscula(sender, e, Pest1_Text_Direccion);
            Cl_Val.ValirLetrasYEspacios_Direccion(sender, e, Pest1_Text_Direccion);
        }

        private void Pest1_Text_Direccion_TextChanged_1(object sender, EventArgs e)
        {
            LEmp_CambiosRealizados = true;
        }

        private void Bttn_Ayuda_Click(object sender, EventArgs e)
        {
            Form_VistaManualPDF Manual = new Form_VistaManualPDF();
            Manual.PDF_Local.src = (Application.StartupPath + @"\ManualesHTML\ManualesPantalla\Manual Pantalla de Empleados.pdf");
            Manual.ShowDialog();
        }
    }
}

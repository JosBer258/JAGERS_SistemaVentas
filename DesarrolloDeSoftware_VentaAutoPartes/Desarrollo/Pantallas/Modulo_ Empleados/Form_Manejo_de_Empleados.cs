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
           // Pest3_Txt_ID.Text = Pest2_DataGriew_InformacionEmpleado.CurrentCell.Value.ToString();

        
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form_Manejo_de_Empleados_Load(object sender, EventArgs e)
        {


            Fun_ExtraerRoles();//CASO: Agregar Nuevo Empleado
            Fun_ExtraerFechaActual();//CASO: Agregar Nuevo Empleado
            Fun_CodigoTelefonicos();///CASO: Agregar Nuevo Empleado

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
            Pest1_Txt_ApellidoEmpleado.Text = "";
            Pest1_Text_CorreoEmpleado.Text = "";
            Pest1_Text_Direccion.Text = "";
            Pest1_Txt_ID.Text = "";
            Pest1_Txt_NombreEmpleado.Text = "";
            Pest1_ComBox_CelularCodigo.SelectedIndex = -1;
           

            Pest1_ComBox_EstadoCivil.SelectedIndex = -1;
            Pest1_ComBox_FechaAño.SelectedIndex = -1;
            Pest1_ComBox_FechaDia.SelectedIndex = -1;
            Pest1_ComBox_FechaMes.SelectedIndex.Equals("");
            Pest1_ComBox_GeneroEmpleado.SelectedIndex.Equals("");
            Pest1_ComBox_RolEmpleado.SelectedIndex.Equals("");
            Pest1_ComBox_TelefonoFijoCodigo.SelectedIndex.Equals(""); ;

            Pest1_Mask_CelularEmpleado.Mask = "";
            Pest1_Mask_NumeroFijoEmpleado.Mask = "";

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void Pest2_DataGriew_InformacionEmpleado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           // Pest3_Txt_ID.Text = Pest2_DataGriew_InformacionEmpleado.CurrentCell.Value.ToString();
           Pest2_Radio_Nombre.Text= Pest2_DataGriew_InformacionEmpleado.CurrentCell.ColumnIndex.ToString();
            
           

        }

        private void Picture_Click(object sender, EventArgs e)
        {
            Mensjae();
        }

        private void Mensjae(){
            MessageBox.Show("Hola");
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
            { Pest2_Txt_CodigoBuscar.Enabled = true;}
            else { Pest2_Txt_CodigoBuscar.Enabled = false;}
        }

        private void Pest2_Radio_ID_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest2_Radio_ID.Checked == true)
            { Pest2_Txt_IDBuscar.Enabled = true; }
            else { Pest2_Txt_IDBuscar.Enabled = false; }
        }

        private void Pest2_Radio_Nombre_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest2_Radio_Nombre.Checked == true)
            { Pest2_Txt_NombreBuscar.Enabled = true; }
            else { Pest2_Txt_NombreBuscar.Enabled = false; }
        }

        private void Pest1_Radio_Nuevo_Empleado_CheckedChanged(object sender, EventArgs e)
        {
            if(Pest1_Radio_Nuevo_Empleado.Checked == true)
            {
                Pest1_ComBox_Estado.Enabled = false;
                Pest1_ComBox_Estado.Items.Add("Nuevo-Empleado");
                Pest1_ComBox_Estado.SelectedItem = ("Nuevo-Empleado");
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

        
        
        ///////////////////////////////////////////CASO: Agregar Nuevo Empleado/////////////////////////////////////////////////////////////////////
        
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



        public void Fun_CodigoTelefonicos()
        {
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select Cod_Pais, CodigoTelefonico from [dbo].[Nacionalidad]");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();

            Con.Dr = Con.dt.NewRow();
            Con.dt.Rows.InsertAt(Con.Dr, 0);

            Pest1_ComBox_TelefonoFijoCodigo.ValueMember = "Cod_Pais";
            Pest1_ComBox_TelefonoFijoCodigo.DisplayMember = "CodigoTelefonico";
            Pest1_ComBox_CelularCodigo.ValueMember = "Cod_Pais";
            Pest1_ComBox_CelularCodigo.DisplayMember = "CodigoTelefonico";

            Pest1_ComBox_TelefonoFijoCodigo.DataSource = Con.dt;
            Pest1_ComBox_CelularCodigo.DataSource = Con.dt;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



    }
}

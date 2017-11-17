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
    public partial class Form_ManejoRoles : Form
    {
        public Form_ManejoRoles()
        {
            InitializeComponent();
        }

        private void Form_ManejoRoles_Load(object sender, EventArgs e)
        {
            Txt_Codigo.Enabled = false;
            Radio_Modificar.Checked = true;
            try
            { this.empleadosTableAdapter.Fill(this.ventasAutoPartesDataSet.Empleados);
                // TODO: esta línea de código carga datos en la tabla 'ventasAutoPartesDataSet.Rol' Puede moverla o quitarla según sea necesario.
                this.rolTableAdapter.Fill(this.ventasAutoPartesDataSet.Rol);
            }
            catch { }

            CargarRoles(DataGriew_MuestraDatos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rolTableAdapter.FillBy(this.ventasAutoPartesDataSet.Rol);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rolTableAdapter.FillBy1(this.ventasAutoPartesDataSet.Rol);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Bttn_Guardar_Click(object sender, EventArgs e)
        {

        }

        //Funciones de Busqueda de los Roles
      
        private void CargarRoles( DataGridView dvg)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                con.DataAdapter = new SqlDataAdapter(@"select Codigo_Rol as 'Codigo del Rol', Descripcion as 'Descripcion del Rol' from Rol", con.ccnx);
                con.dt = new DataTable();
                con.DataAdapter.Fill(con.dt);
                dvg.DataSource = con.dt;

            }
            catch
            {

            }

        }

        private void DataGriew_MuestraDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGriew_MuestraDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGriew_MuestraDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string a;
            a = DataGriew_MuestraDatos.CurrentCell.ColumnIndex.ToString();

            if (Convert.ToInt16(a) == 0)
            {
                ExtraerRolesPorCodigo();

            }
            else
            {
                ExtraerRolesPorNombre();
            }

        }

        private void ExtraerRolesPorCodigo()
        {

        }

        private void ExtraerRolesPorNombre()
        {

        }


        private void ValidarDescripcion_Update()
        {

        }


        private void Update_LaTabla()
        {

        }
    }
}

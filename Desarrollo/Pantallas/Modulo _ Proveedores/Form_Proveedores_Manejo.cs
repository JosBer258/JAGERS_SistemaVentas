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

namespace Desarrollo.Pantallas.Modulo___Proveedores
{
    public partial class Form_Proveedores_Manejo : System.Windows.Forms.Form
    {
        Validaciones Val = new Validaciones();
        public Form_Proveedores_Manejo()
        {
            InitializeComponent();
            Pest2_Radio_CodigoProveedor.Checked = false;
            Pest2_Radio_NombreProveedor.Checked = false;
            Pest2_Txt_CodigoBusqueda.Enabled = false;
            Pest2_Txt_NombreBusqueda.Enabled = false;


        } 

        private void validacionMenu()
        {
            var blankContextMenu = new ContextMenuStrip();
            var boxes = Pest4_Grupo_ManejoDatos.Controls.OfType<TextBox>();
            foreach (var box in boxes)
            {
                box.ContextMenuStrip = blankContextMenu;

            }


            var boxe = Pest4_Grupo_OpcionesBusqueda.Controls.OfType<TextBox>();
            foreach (var box in boxe)
            {
                box.ContextMenuStrip = blankContextMenu;

            }
          
            var boxe1 = Pest2_Grupo_Busqueda.Controls.OfType<TextBox>();
            foreach (var box in boxe1)
            {
                box.ContextMenuStrip = blankContextMenu;

            }


            var boxe3 = Pest3_Grupo_Manejo.Controls.OfType<TextBox>();
            foreach (var box in boxe3)
            {
                box.ContextMenuStrip = blankContextMenu;

            }


            var boxe4 = Pest1_Grupo_DatosDeProveedor.Controls.OfType<TextBox>();
            foreach (var box in boxe4)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxe5 = Pest1_Grupo_ContactosDeProveedor.Controls.OfType<TextBox>();
            foreach (var box in boxe5)
            {
                box.ContextMenuStrip = blankContextMenu;

            }


        }

        private void Form_Proveedores_Manejo_Load(object sender, EventArgs e)
        {
            Fun_ExtraerEstados2();
            validacionMenu();
            Fun_ExtraerTele();
            Pest4_Radio_Nuevo.Checked = true;
            Fun_ExtraerProveedores();
            Fun_CargarPrimerDataGriewC(Pest4_DataGrid_ManejoContactos);
            Fun_CargarPrimerDataGriew(dataGridView2);
            this.proveedorTableAdapter.Fill(this.ventasAutoPartesDataSet.Proveedor);
            this.contacto_ProveedorTableAdapter.Fill(this.ventasAutoPartesDataSet._Contacto_Proveedor);

            Pest4_Txt_BuscarNombre.Enabled = false;
            Pest4_Txt_BuscarCodigo.Enabled = false;
            Pest4_Txt_BuscarProvNombre.Enabled = false;


            Fun_ExtraerEstados();
            Fun_ExtraerNacionalidad();
            Fun_ExtraerCodigo();
            Fun_ExtraerCodigoContacto();



            


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (Pest4_Radio_Nuevo.Checked != true)
            {
                
                Pest4_Radio_CodigoBusqueda.Enabled = true;
                Pest4_Radio_NombreBusqueda.Enabled = true;
                Pest4_Radio_ProveedorBusqueda.Enabled = true;
                Pest4_DataGrid_ManejoContactos.Enabled = true;


            }
            else
            {
                
            }

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTTN_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pest4_Bttn_Aceptar_Click(object sender, EventArgs e)
        {

            C_ContactosProveedores contactos = new C_ContactosProveedores();
            if (Pest4_Radio_Nuevo.Checked == true)
            {
                if (comboBox1.SelectedIndex == -1 || string.IsNullOrWhiteSpace(Pest4_Txt_NombreCont.Text) ||
                   string.IsNullOrWhiteSpace(Pest4_Txt_ApellidoCont.Text) || string.IsNullOrWhiteSpace(Pest4_Txt_RolContact.Text) ||
                   string.IsNullOrWhiteSpace(Pest4_Txt_CorreoContact.Text) ||
                   string.IsNullOrWhiteSpace(Pest1_Mask_NumeroFijoEmpleado.Text))
                {
                    MessageBox.Show("No se admiten Valores Vacios");
                    return;

                }

                try
                {
                    Pest4_CoBx_Estado.SelectedValue = 1;
                    contactos.Var_CodigoProveedor = Convert.ToInt16(comboBox1.SelectedValue);

                    contactos.Var_NombreContacto = Pest4_Txt_NombreCont.Text;
                    contactos.Var_ApellidoContacto = Pest4_Txt_ApellidoCont.Text;
                    contactos.Var_CargoContacto = Pest4_Txt_RolContact.Text;
                    contactos.Var_CorreoContacto = Pest4_Txt_CorreoContact.Text;
                    contactos.Var_TelefonoContacto = Pest1_Mask_NumeroFijoEmpleado.Text;


                    if (contactos.Var_NombreContacto == "")
                    {
                        return;
                    }

                    contactos.Fun_Agregar_Contacto();


                    Pest4_Txt_CodigoContac.Clear();
                    Pest4_Txt_NombreCont.Clear();
                    Pest4_Txt_ApellidoCont.Clear();
                    Pest4_Txt_CorreoContact.Clear();
                    Pest1_Mask_NumeroFijoEmpleado.Clear();
                    Pest4_Txt_RolContact.Clear();
                    Pest4_CoBx_Estado.SelectedValue = -1;
                    comboBox1.SelectedValue = -1;
                    Pest4_Txt_BuscarNombre.Clear();
                    Pest4_Txt_BuscarCodigo.Clear();
                    Pest4_Txt_BuscarProvNombre.Clear();
                    Fun_CargarPrimerDataGriewC(Pest4_DataGrid_ManejoContactos);

                    MessageBox.Show("Registro agregado correctamente", "Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception)
                {

                }
            }
            else
            {
                

                    contactos.Var_CodigoProveedor = Convert.ToInt16(comboBox1.SelectedValue);

                    contactos.Var_NombreContacto = Pest4_Txt_NombreCont.Text;
                    contactos.Var_ApellidoContacto = Pest4_Txt_ApellidoCont.Text;
                    contactos.Var_CargoContacto = Pest4_Txt_RolContact.Text;
                    contactos.Var_CorreoContacto = Pest4_Txt_CorreoContact.Text;
                    contactos.Var_TelefonoContacto = Pest1_Mask_NumeroFijoEmpleado.Text;
                    contactos.Var_EstadoContacto = Convert.ToInt16(Pest4_CoBx_Estado.SelectedValue);
                    contactos.Var_CodigoContacto = Convert.ToInt16(Pest4_Txt_CodigoContac.Text);
                    
                    contactos.Fun_Modificar_Contacto();

                    MessageBox.Show("Registro modificadamente correctamente", "Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Pest4_Txt_CodigoContac.Clear();
                Pest4_Txt_NombreCont.Clear();
                Pest4_Txt_ApellidoCont.Clear();
                Pest4_Txt_CorreoContact.Clear();
                Pest1_Mask_NumeroFijoEmpleado.Clear();
                Pest4_Txt_RolContact.Clear();
                Pest4_CoBx_Estado.SelectedValue = -1;
                comboBox1.SelectedValue = -1;
                Pest4_Txt_BuscarNombre.Clear();
                Pest4_Txt_BuscarCodigo.Clear();
                Pest4_Txt_BuscarProvNombre.Clear();
                Fun_CargarPrimerDataGriewC(Pest4_DataGrid_ManejoContactos);

            }

      
        }

        private void Pest1_Bttn_Limpiar_Click(object sender, EventArgs e)
        {
            
            LimpiarProveedor();
            
        }

        private void Pest1_Bttn_LimpiarCont_Click(object sender, EventArgs e)
        {
            LimpiarContactos();

        }

        private void LimpiarProveedor()
        {
            //TextBoxs del proveedor 
            Pest1_Txt__Nombre.Text = "";
            Pest1_Txt__Correo.Text = "";
            Pest1_Txt__Direccion.Text = "";
            Pest1_ComBox_Estados.Text = "";
            Pest1_ComBox_Nacionalidad.Text = "";
            Pest1_Txt__CodigoPostal.Text = "";
        }

        private void LimpiarContactos()
        {
            //TextBoxs del contacto
            Pest1_Txt__ContactoNombre.Text = "";
            Pest1_Txt__ContactoApellido.Text = "";
            Pest1_Txt__ContactoRol.Text = "";
            Pest1_Txt__ContactoCorreo.Text = "";
            Pest1_Txt__ContactoTelefono.Text = "";


            dataGridView4.Rows.Clear();

            


        }

        private void Pest1_Bttn_Guardar_Click(object sender, EventArgs e)
        {
            bool Verificar = false;

            if (string.IsNullOrWhiteSpace(Pest1_Txt__Nombre.Text))
            {
                
                errorProvider1.SetError(Pest1_Txt__Nombre, "El Nombre del Proveedor es Requerido");
                Verificar = true;
            }
            else
            {
                errorProvider1.SetError(Pest1_Txt__Nombre, "");

            }


            if (string.IsNullOrWhiteSpace(Pest1_Txt__Correo.Text))
            {
                errorProvider1.SetError(Pest1_Txt__Correo, "El Correo del Proveedor es Requerido");
                Verificar = true;
            }
            else
            {
                errorProvider1.SetError(Pest1_Txt__Correo, "");
            }



            if (string.IsNullOrWhiteSpace(Pest1_Txt__Direccion.Text))
            {
                errorProvider1.SetError(Pest1_Txt__Direccion, "La Direccion del Proveedor es Requerido");
                Verificar = true;
            }
            else
            { errorProvider1.SetError(Pest1_Txt__Direccion, "");
            }
          


            if (Pest1_ComBox_Estados.SelectedIndex == -1)
            {
                errorProvider1.SetError(Pest1_ComBox_Estados, "Debe elegir un Estado para el Proveedor");
                Verificar = true;
            }
            else
            {errorProvider1.SetError(Pest1_ComBox_Estados, "");}




            if (Pest1_ComBox_Nacionalidad.SelectedIndex == -1)
            {
               errorProvider1.SetError(Pest1_ComBox_Nacionalidad, "Debe elegir una Nacionalidad para el Proveedor");
                Verificar = true;
            }
            else
            {
                errorProvider1.SetError(Pest1_ComBox_Nacionalidad, "");
            }




            if (Val.Verificaremail(Pest1_Txt__Correo.Text))
            {
                errorProvider1.SetError(Pest1_Txt__Correo, "");
            }
            else
            {
                errorProvider1.SetError(Pest1_Txt__Correo, "Please fill the required field");
                Verificar = true;
            }



            if (Verificar == true)
            {
                return;
            } 

            C_Proveedores proveedor = new C_Proveedores();
            C_ContactosProveedores contactos = new C_ContactosProveedores();

            Conexion Con = new Conexion();


            proveedor.Var_NombreProveedor = Pest1_Txt__Nombre.Text;
            proveedor.Var_CorreoProveedor = Pest1_Txt__Correo.Text;
            proveedor.Var_DireccionProveedor = Pest1_Txt__Direccion.Text;
            proveedor.Var_EstadoProveedor = Convert.ToInt16(Pest1_ComBox_Estados.SelectedValue);
            proveedor.Var_NacionalidadProveedor = Convert.ToInt16(Pest1_ComBox_Nacionalidad.SelectedValue);
            Fun_ExtraerCodigoPostal(proveedor.Var_NacionalidadProveedor);
            //Pest1_Txt__CodigoPostal.Text;
            proveedor.Var_CodigoPostalProveedor = Convert.ToInt16(Pest1_Txt__CodigoPostal.Text);
    

          


            contactos.Var_NombreContacto = Pest1_Txt__ContactoNombre.Text;
            contactos.Var_ApellidoContacto = Pest1_Txt__ContactoApellido.Text;
            contactos.Var_CargoContacto = Pest1_Txt__ContactoRol.Text;
            contactos.Var_CorreoContacto = Pest1_Txt__ContactoCorreo.Text;
            contactos.Var_TelefonoContacto = Pest1_Txt__ContactoTelefono.Text;
            contactos.Var_CodigoProveedor = Convert.ToInt16(Pest1_Txt__CodigoProveedor.Text);

            if (proveedor.RevisionDeDatos() == false)
            {
                MessageBox.Show("Ya existe un proveedor con este mismo nombre: " + proveedor.Var_NombreProveedor, "Duplicacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                proveedor.Fun_Agregar_Proveedor();

            }

            //Funcion de cuantos contactos 

           
                foreach (DataGridViewRow Row in dataGridView4.Rows)
                {
                    String strFila = Row.Index.ToString();
                    

                    contactos.Var_CodigoProveedor = Convert.ToInt16(Pest1_Txt__CodigoProveedor.Text);
                   

                    contactos.Var_NombreContacto = Convert.ToString(Row.Cells["Nombre_Contacto"].Value);
                    contactos.Var_ApellidoContacto = Convert.ToString(Row.Cells["Apellido_Contacto"].Value);
                    contactos.Var_CargoContacto = Convert.ToString(Row.Cells["Cargo"].Value);
                    contactos.Var_CorreoContacto = Convert.ToString(Row.Cells["Correo"].Value);
                    contactos.Var_TelefonoContacto = Convert.ToString(Row.Cells["Telefono"].Value);
                    contactos.Var_CodigoProveedor = Convert.ToInt16(Row.Cells["Codigo_Proveedor"].Value);

                    if (contactos.Var_NombreContacto == "")
                    {
                        return;
                    }

                    contactos.Fun_Agregar_Contacto();
                }

            LimpiarProveedor();
            LimpiarContactos();
            Fun_ExtraerCodigo();
            Fun_ExtraerCodigoContacto();
            Fun_CargarPrimerDataGriew(dataGridView2);
            Fun_CargarPrimerDataGriewContactos(Pest3_DataG_ContactosProveedor);
        }


        public void Fun_ExtraerCodigo()
        {
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select TOP 1 Codigo_Proveedor from Proveedor ORDER BY Codigo_Proveedor DESC");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            SqlDataReader Reg2 = null;
            Reg2 = Con.cmd.ExecuteReader();
            if (Reg2.Read())
            {
                Pest1_Txt__CodigoProveedor.Text = Convert.ToString(Convert.ToInt16((Reg2["Codigo_Proveedor"].ToString())) + 1);
                Con.cnx.Close();
            }
            
        }
        public void Fun_ExtraerCodigoContacto()
        {
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select TOP 1 Codigo_Contacto from [dbo].[Contacto|Proveedor] ORDER BY Codigo_Contacto DESC");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            SqlDataReader Reg = null;
            Reg = Con.cmd.ExecuteReader();
            if (Reg.Read())
            {
                Pest1_Txt__ContactoCodigo.Text = Convert.ToString(Convert.ToInt16((Reg["Codigo_Contacto"].ToString())) + 1);
                Con.cnx.Close();
            }

        }
        public void Fun_ExtraerEstados()
        {
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select Codigo_Estado, Descripcion_Estado from Estados WHERE Codigo_Tipo_Estado = 3");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();

            Pest1_ComBox_Estados.ValueMember = "Codigo_Estado";
            Pest1_ComBox_Estados.DisplayMember = "Descripcion_Estado";
            Pest1_ComBox_Estados.DataSource = Con.dt;
            Pest3_ComBx_Estado.ValueMember = "Codigo_Estado";
            Pest3_ComBx_Estado.DisplayMember = "Descripcion_Estado";
            Pest3_ComBx_Estado.DataSource = Con.dt;
            Pest4_CoBx_Estado.ValueMember = "Codigo_Estado";
            Pest4_CoBx_Estado.DisplayMember = "Descripcion_Estado";
            Pest4_CoBx_Estado.DataSource = Con.dt;
        }

        public void Fun_ExtraerEstados2()
        {
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select Codigo_Estado, Descripcion_Estado from Estados WHERE Codigo_Tipo_Estado = 11");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();

            Pest4_CoBx_Estado.ValueMember = "Codigo_Estado";
            Pest4_CoBx_Estado.DisplayMember = "Descripcion_Estado";
            Pest4_CoBx_Estado.DataSource = Con.dt;
        }
        public void Fun_ExtraerNacionalidad()
        {
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select * from Nacionalidad");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();



            Pest1_ComBox_Nacionalidad.ValueMember = "Cod_Pais";
            Pest1_ComBox_Nacionalidad.DisplayMember = "Nombre";
            Pest1_ComBox_Nacionalidad.DataSource = Con.dt;
            Pest3_ComBx_Nacionalidad.ValueMember = "Cod_Pais";
            Pest3_ComBx_Nacionalidad.DisplayMember = "Nombre";
            Pest3_ComBx_Nacionalidad.DataSource = Con.dt;
        }
        public void Fun_ExtraerCodigoPostal(int a)
        {
            Conexion Con = new Conexion();
            Con.cnx.Open();

            Con.sql = string.Format(@"SELECT CodigoTelefonico FROM Nacionalidad WHERE Cod_Pais = '{0}'", a);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            
            SqlDataReader Reg = null;
            Reg = Con.cmd.ExecuteReader();
            if (Reg.Read())
            {
                Pest1_Txt__CodigoPostal.Text = Convert.ToString((Reg["CodigoTelefonico"].ToString()));


                Con.cnx.Close();

            }
            Con.cnx.Close();
        }

        private void Pest1_Bttn_AgregarCont_Click(object sender, EventArgs e)
        {
            bool Verificar = false;

            if (string.IsNullOrWhiteSpace(Pest1_Txt__ContactoNombre.Text))
            {
                errorProvider1.SetError(Pest1_Txt__ContactoNombre, "El Nombre del Contacto es Requerido");
                Verificar = true;
            }
            else
            { errorProvider1.SetError(Pest1_Txt__ContactoNombre, ""); }


            if (string.IsNullOrWhiteSpace(Pest1_Txt__ContactoApellido.Text))
            {
                errorProvider1.SetError(Pest1_Txt__ContactoApellido, "El Apellido del Contacto es Requerido");
                Verificar = true;
            }
            else
            { errorProvider1.SetError(Pest1_Txt__ContactoApellido, ""); }



            if (string.IsNullOrWhiteSpace(Pest1_Txt__ContactoRol.Text))
            {
                errorProvider1.SetError(Pest1_Txt__ContactoRol, "El Rol del Contacto es Requerido");
                Verificar = true;
            }
            else
            { errorProvider1.SetError(Pest1_Txt__ContactoRol, ""); }

            if (string.IsNullOrWhiteSpace(Pest1_Txt__ContactoCorreo.Text))
            {
                errorProvider1.SetError(Pest1_Txt__ContactoCorreo, "El Correo del Contacto es Requerido");
                Verificar = true;
            }
            else
            { errorProvider1.SetError(Pest1_Txt__ContactoCorreo, ""); }

            if (string.IsNullOrWhiteSpace(Pest1_Txt__ContactoApellido.Text))
            {
                errorProvider1.SetError(Pest1_Txt__ContactoTelefono, "El Telefono del Contacto es Requerido");
                Verificar = true;
            }
            else
            { errorProvider1.SetError(Pest1_Txt__ContactoTelefono, ""); }

            if (Val.Verificaremail(Pest1_Txt__ContactoCorreo.Text))
            {
                errorProvider1.SetError(Pest1_Txt__ContactoCorreo, "");
            }
            else
            {
                errorProvider1.SetError(Pest1_Txt__ContactoCorreo, "Error en cuanto al formato del Correo");
                Verificar = true;
            }


            for (int i = 0; i < dataGridView4.Rows.Count; i++)
            {
                if ((string)this.dataGridView4.Rows[i].Cells[1].Value == Pest1_Txt__ContactoNombre.Text && (string)this.dataGridView4.Rows[i].Cells[2].Value == Pest1_Txt__ContactoApellido.Text)
                {
                    MessageBox.Show("Existe una duplicacion de los Datos del Contacto\n Revise sus datos nuevamente");
                    Verificar = true;
                }
                else
                {
                    Verificar = false;
                    MessageBox.Show("Nom aqui:" + (string)this.dataGridView4.Rows[i].Cells[1].Value +
                        "\nNom: " + Pest1_Txt__ContactoNombre.Text +
                        "\nApe aqui" + (string)this.dataGridView4.Rows[i].Cells[2].Value +
                        "\nApellido: " + Pest1_Txt__ContactoApellido.Text);
                }



            }




            if (Verificar == true)
            {
                return;
            }

            int contactoCodigo = Convert.ToInt16(Pest1_Txt__ContactoCodigo.Text);
            string nombreContacto = Pest1_Txt__ContactoNombre.Text;
            string apellidoContacto = Pest1_Txt__ContactoApellido.Text;
            string correoContacto = Pest1_Txt__ContactoCorreo.Text;
            string contactoTelefono = Pest1_Txt__ContactoTelefono.Text;
            string contactoRol = Pest1_Txt__ContactoRol.Text;
            int codigoEstado = 1;
            int codigoProveedor = Convert.ToInt16(Pest1_Txt__CodigoProveedor.Text);

            dataGridView4.Rows.Insert(0,contactoCodigo, nombreContacto, apellidoContacto, correoContacto, contactoTelefono, contactoRol, codigoEstado, codigoProveedor);

            Pest1_Txt__ContactoNombre.Text = "";
            Pest1_Txt__ContactoApellido.Text = "";
            Pest1_Txt__ContactoRol.Text = "";
            Pest1_Txt__ContactoCorreo.Text = "";
            Pest1_Txt__ContactoTelefono.Text = "";
            Pest1_Txt__ContactoCodigo.Text = Convert.ToString(Convert.ToInt16(Pest1_Txt__ContactoCodigo.Text) + 1);

        }

        private void Pest1_ComBox_Nacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        public void AdqurirCodigoPostal(int a)
        {

        }


        private void Pest2_Radio_NombreProveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest2_Radio_NombreProveedor.Checked == true)
            {
                Pest2_Txt_NombreBusqueda.Enabled = true;
                Pest2_Txt_CodigoBusqueda.Text = "";
            }
            else { Pest2_Txt_NombreBusqueda.Enabled = false; }
        }

        private void Pest2_Radio_CodigoProveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest2_Radio_CodigoProveedor.Checked == true)
            {
                Pest2_Txt_CodigoBusqueda.Enabled = true;
                Pest2_Txt_NombreBusqueda.Text = "";
            }
            else { Pest2_Txt_CodigoBusqueda.Enabled = false; }
        }

        private void Pest2_Txt_NombreBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (Pest2_Txt_NombreBusqueda.Text == string.Empty)
            {
                Fun_CargarPrimerDataGriew(dataGridView2);

            }
            else
            {
                Fun_CargarPorNombre(dataGridView2, Pest2_Txt_NombreBusqueda.Text);
            }
        }

        private void Pest2_Txt_CodigoBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (Pest2_Txt_CodigoBusqueda.Text == string.Empty)
            {
                Fun_CargarPrimerDataGriew(dataGridView2);

            }
            else
            {
                Fun_CargarPorCodigo(dataGridView2, Convert.ToDouble(Pest2_Txt_CodigoBusqueda.Text));
            }
        }

        public void Fun_CargarPorCodigo(DataGridView dgv, double a)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                int busq;
                busq = (int)a;


                con.sql = string.Format
                (@"SELECT Codigo_Proveedor as 'Codigo',	D.Nombre as Nombre, Correo as Correo, CodigoPostal as 
                'Codigo Postal', Direccion as Direccion,
                Codigo_Estado as 'Codigo del Estado', (select E.Descripcion_Estado as 'Estado' from Estados as E
                where E.Codigo_Estado = D.Codigo_Estado
                and Descripcion_Estado like '%Proveedor%') as 'Estado' , N.Cod_Pais as 'Codigo del Pais', N.Nombre as 'Pais de Nacionalidad' 
                FROM Proveedor as D inner join Nacionalidad as N on D.Codigo_Nacionalidad = N.Cod_Pais where D.Codigo_Proveedor like '%{0}%'", busq);
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
                (@"SELECT Codigo_Proveedor as 'Codigo',	D.Nombre as Nombre, Correo as Correo, CodigoPostal as 
                'Codigo Postal', Direccion as Direccion,
                Codigo_Estado as 'Codigo del Estado', (select E.Descripcion_Estado as 'Estado' from Estados as E
                where E.Codigo_Estado = D.Codigo_Estado
                and Descripcion_Estado like '%Proveedor%') as 'Estado' , N.Cod_Pais as 'Codigo del Pais', N.Nombre as 'Pais de Nacionalidad' 
                FROM Proveedor as D inner join Nacionalidad as N on D.Codigo_Nacionalidad = N.Cod_Pais where D.Nombre like '%{0}%'", busq);
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

        private void Pest2_Txt_NombreBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void Pest2_Txt_CodigoBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarID(sender, e);
        }

        private void Pest2_Bttn_Limpiar_Click(object sender, EventArgs e)
        {
            Pest2_Radio_CodigoProveedor.Checked = false;
            Pest2_Radio_NombreProveedor.Checked = false;
            Pest2_Txt_CodigoBusqueda.Text = "";
            Pest2_Txt_NombreBusqueda.Text = "";
            Fun_CargarPrimerDataGriew(dataGridView2);
           
        }
       
        public void Fun_CargarPrimerDataGriew(DataGridView dgv)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                con.DataAdapter = new SqlDataAdapter(@"SELECT Codigo_Proveedor as 'Codigo',	D.Nombre as Nombre, Correo as Correo, CodigoPostal as 
                'Codigo Postal', Direccion as Direccion,
                Codigo_Estado as 'Codigo del Estado', (select E.Descripcion_Estado as 'Estado' from Estados as E
                where E.Codigo_Estado = D.Codigo_Estado
                and Descripcion_Estado like '%Proveedor%') as 'Estado' , N.Cod_Pais as 'Codigo del Pais', N.Nombre as 'Pais de Nacionalidad' 
                FROM Proveedor as D inner join Nacionalidad as N on D.Codigo_Nacionalidad = N.Cod_Pais", con.ccnx);
                con.dt = new DataTable();
                con.DataAdapter.Fill(con.dt);
                dgv.DataSource = con.dt;

            }
            catch
            {

            }
        }

        private void Pest3_DataG_ContactosProveedor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Pest3_DataG_ContactosProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
               
                



        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Pest3_Txt_Codigo.Text= dataGridView2.CurrentRow.Cells[0].Value.ToString();
            Pest3_Txt_Nombre.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            Pest3_Txt_CorreoElectronico.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            Pest3_Txt_CodigoPostal.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            Pest3_Txt_Direccion.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            Pest3_ComBx_Estado.SelectedValue= dataGridView2.CurrentRow.Cells[5].Value.ToString();
            Pest3_ComBx_Nacionalidad.SelectedValue = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            BuscarCodigoPostal(Convert.ToInt16(dataGridView2.CurrentRow.Cells[7].Value.ToString()));
            MessageBox.Show("Listo");
        }

        public void BuscarCodigoPostal(int Cod)
        {
            Conexion Co = new Conexion();

            Co.sql = string.Format(@"select CodigoTelefonico from Nacionalidad where Cod_Pais = '{0}'",Cod );
            Co.cmd = new SqlCommand(Co.sql, Co.cnx);
            Co.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Co.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Pest3_Txt_CodigoPostal.Text=(Reg["CodigoTelefonico"].ToString());

            }
            else
            {

            }

            Co.cnx.Close();

        }
        private void Pest1_ComBox_Estados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pest3_Txt_Codigo_TextChanged(object sender, EventArgs e)
        {
            if (Pest3_Txt_Codigo.Text == "")
            {
                Fun_CargarPorCodigoProveedor(Pest3_DataG_ContactosProveedor, Convert.ToInt16(0));

            }
            else
            {
                Fun_CargarPorCodigoProveedor(Pest3_DataG_ContactosProveedor, Convert.ToInt16(Convert.ToInt16(Pest3_Txt_Codigo.Text)));
            }
        }
        public void Fun_CargarPorCodigoProveedor(DataGridView dgv, int a)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                int busq;
                busq = a;


                con.sql = string.Format
                (@" select Codigo_Contacto as 'Codigo de Contact', (Nombre + ' ' + Apellido) as Nombre, Correo as Correo,
                    Cargo as 'Cargo' , (select E.Descripcion_Estado  from Estados as E where E.Codigo_Estado = D.Codigo_Estado and E.Descripcion_Estado like '%Contacto%') 
                    as Estado from [Contacto|Proveedor] as D where D.Codigo_Proveedor = '{0}' and Codigo_Estado = 1", busq);
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

        private void LimpiarPest3()
        {
            Pest3_Txt_Codigo.Text = "";
            Pest3_Txt_Nombre.Text = "";
            Pest3_Txt_CorreoElectronico.Text = "";
            Pest3_Txt_CodigoPostal.Text = "";
            Pest3_Txt_Direccion.Text = "";
            Pest3_ComBx_Estado.SelectedIndex = -1;
            Pest3_ComBx_Nacionalidad.SelectedIndex = -1;
            
        }
        private void Pest3_Bttn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarPest3();
        }

        public void Fun_CargarPrimerDataGriewContactos(DataGridView dgv)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                con.DataAdapter = new SqlDataAdapter("select * from [Contacto|Proveedor] where Codigo_Estado = 1", con.ccnx);
                con.dt = new DataTable();
                con.DataAdapter.Fill(con.dt);
                dgv.DataSource = con.dt;

            }
            catch
            {

            }
        }

        private void Pest3_Txt_Aceptar_Click(object sender, EventArgs e)
        {
            bool Est=false;
            if (string.IsNullOrWhiteSpace(Pest3_Txt_Codigo.Text))
            {

                errorProvider1.SetError(Pest3_Txt_Codigo, "Debe elegir un proveedor");
                Est = true;
            }
            else
            {
                errorProvider1.SetError(Pest3_Txt_Codigo, "");
            }



            if (string.IsNullOrWhiteSpace(Pest3_Txt_Direccion.Text))
            {
                
                errorProvider1.SetError(Pest3_Txt_Direccion, "Debe elegir un Estado para el Proveedor");
                Est = true;
            }
            else
            {
                errorProvider1.SetError(Pest3_Txt_Direccion, "");
            }


           
            if (Pest3_ComBx_Estado.SelectedIndex == -1)
            {
                errorProvider1.SetError(Pest3_ComBx_Estado, "Debe elegir un Estado para el Proveedor");
                Est = true;
            }
            else
            {
                errorProvider1.SetError(Pest3_ComBx_Estado, "");
            }


            if (string.IsNullOrWhiteSpace(Pest3_Txt_CorreoElectronico.Text))
            {
                errorProvider1.SetError(Pest3_Txt_CorreoElectronico, "El correo electronico del Proveedor es Requerido");
                Est = true;
            }
            else
            {
                errorProvider1.SetError(Pest3_Txt_CorreoElectronico, "");
            }



            if (Val.Verificaremail(Pest3_Txt_CorreoElectronico.Text))
            {
                errorProvider1.SetError(Pest3_Txt_CorreoElectronico, "");
            }
            else
            {
                errorProvider1.SetError(Pest3_Txt_CorreoElectronico, "Formato de Correo");
                Est = true;
            }


            if (Est == true)
            {
                return;
            }


            C_Proveedores proveedor = new C_Proveedores();

            Conexion Con = new Conexion();

            proveedor.Var_CodigoProveedor = Convert.ToInt16(Pest3_Txt_Codigo.Text);
            proveedor.Var_CorreoProveedor = Pest3_Txt_CorreoElectronico.Text;
            proveedor.Var_DireccionProveedor = Pest3_Txt_Direccion.Text;
            proveedor.Var_EstadoProveedor = Convert.ToInt16(Pest1_ComBox_Estados.SelectedValue);



            proveedor.Fun_Modificar_Proveedor(proveedor.Var_CodigoProveedor, proveedor.Var_CorreoProveedor, proveedor.Var_DireccionProveedor, proveedor.Var_EstadoProveedor);

            Fun_CargarPrimerDataGriew(dataGridView2);
            Fun_CargarPrimerDataGriewC(Pest4_DataGrid_ManejoContactos);
            MessageBox.Show("Registro modificado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            LimpiarPest3();
        }


        ///////////////CONTACTOS

        public void CargarTexBoxContactos(int Id)
        {



            Conexion Cn = new Conexion();
            Cn.sql = string.Format(@"select Codigo_Contacto, Nombre, 
Apellido, Correo, Telefono, Cargo, Codigo_Estado, 
Codigo_Proveedor from [Contacto|Proveedor] 
where Codigo_Contacto='{0}'", Id);
            Cn.cmd = new SqlCommand(Cn.sql, Cn.cnx);
            Cn.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Cn.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Pest4_Txt_NombreCont.Text = (Reg["Nombre"].ToString());
          
            }
            else
            {

            }
        }

        public void Fun_CargarPorCodigo_C(DataGridView dgv, int a)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                int busq;
                busq = a;

                con.sql = string.Format
                (@"
                 select A.Codigo_Contacto, A.Nombre, A.Apellido, A.Correo, A.Telefono, A.Cargo, A.Codigo_Estado as 'Codigo del Estado', 
                (select Descripcion_Estado from Estados where Codigo_Estado= A.Codigo_Estado and Descripcion_Estado  like '%Contacto%') as Estado, 
                 A.Codigo_Proveedor as 'Codigo del Proveedor', B.Nombre as 'Nombre del Proveedor', B.Direccion as 'Direccion del Proveedor'
                 ,B.Codigo_Nacionalidad as 'Codigo de Nacionalidad', N.Nombre as 'Nacionalidad'
                from [Contacto|Proveedor] 
                as A inner join [dbo].[Proveedor] as B on 
                A.Codigo_Proveedor = b.Codigo_Proveedor inner join Nacionalidad as N
                on N.Cod_Pais = B.Codigo_Nacionalidad
                where [Codigo_Contacto] like '%{0}%'", busq);

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

        public void Fun_CargarPrimerDataGriewC(DataGridView dgv)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            
                con.DataAdapter = new SqlDataAdapter(@"select A.Codigo_Contacto, A.Nombre, A.Apellido, A.Correo, A.Telefono, A.Cargo, A.Codigo_Estado as 'Codigo del Estado', 
                (select Descripcion_Estado from Estados where Codigo_Estado= A.Codigo_Estado and Descripcion_Estado  like '%Contacto%') as Estado, 
                 A.Codigo_Proveedor as 'Codigo del Proveedor', B.Nombre as 'Nombre del Proveedor', B.Direccion as 'Direccion del Proveedor'
                 ,B.Codigo_Nacionalidad as 'Codigo de Nacionalidad', N.Nombre as 'Nacionalidad'
                from [Contacto|Proveedor] 
                as A inner join [dbo].[Proveedor] as B on 
                A.Codigo_Proveedor = b.Codigo_Proveedor inner join Nacionalidad as N
                on N.Cod_Pais = B.Codigo_Nacionalidad", con.ccnx);
                con.dt = new DataTable();
                con.DataAdapter.Fill(con.dt);
                dgv.DataSource = con.dt;

   
        }


        public void Fun_CargarPorCodigoProveedorC(DataGridView dgv, int a)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                int busq;
                busq = a;

                con.sql = string.Format
                (@"select A.Codigo_Contacto, A.Nombre, A.Apellido, A.Correo, A.Telefono, A.Cargo, A.Codigo_Estado as 'Codigo del Estado', 
                (select Descripcion_Estado from Estados where Codigo_Estado= A.Codigo_Estado and Descripcion_Estado  like '%Contacto%') as Estado, 
                 A.Codigo_Proveedor as 'Codigo del Proveedor', B.Nombre as 'Nombre del Proveedor', B.Direccion as 'Direccion del Proveedor'
                 ,B.Codigo_Nacionalidad as 'Codigo de Nacionalidad', N.Nombre as 'Nacionalidad'
                from [Contacto|Proveedor] 
                as A inner join [dbo].[Proveedor] as B on 
                A.Codigo_Proveedor = b.Codigo_Proveedor inner join Nacionalidad as N
                on N.Cod_Pais = B.Codigo_Nacionalidad
                where B.[Codigo_Proveedor] like '%{0}%'", busq);

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


        public void Fun_CargarPorNombre_C(DataGridView dgv, string a)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                string busq;
                busq = a;


                con.sql = string.Format
                (@"select A.Codigo_Contacto, A.Nombre, A.Apellido, A.Correo, A.Telefono, A.Cargo, A.Codigo_Estado as 'Codigo del Estado', 
                (select Descripcion_Estado from Estados where Codigo_Estado= A.Codigo_Estado and Descripcion_Estado  like '%Contacto%') as Estado, 
                 A.Codigo_Proveedor as 'Codigo del Proveedor', B.Nombre as 'Nombre del Proveedor', B.Direccion as 'Direccion del Proveedor'
                 ,B.Codigo_Nacionalidad as 'Codigo de Nacionalidad', N.Nombre as 'Nacionalidad'
                from [Contacto|Proveedor] 
                as A inner join [dbo].[Proveedor] as B on 
                A.Codigo_Proveedor = b.Codigo_Proveedor inner join Nacionalidad as N
                on N.Cod_Pais = B.Codigo_Nacionalidad
                where A.Nombre like '%{0}%'", busq);

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

        private void Pest4_Txt_BuscarNombre_TextChanged(object sender, EventArgs e)
        {
            if (Pest4_Txt_BuscarNombre.Text == string.Empty)
            {

                Fun_CargarPrimerDataGriewC(Pest4_DataGrid_ManejoContactos);

            }
            else
            {
                Fun_CargarPorNombre_C(Pest4_DataGrid_ManejoContactos, Pest4_Txt_BuscarNombre.Text);
            }
        }

        private void Pest4_Txt_BuscarCodigo_TextChanged(object sender, EventArgs e)
        {
            if (Pest4_Txt_BuscarCodigo.Text == "")
            {
                Fun_CargarPrimerDataGriewC(Pest4_DataGrid_ManejoContactos);

            }
            else
            {
                Fun_CargarPorCodigo_C(Pest4_DataGrid_ManejoContactos, Convert.ToInt16(Convert.ToInt16(Pest4_Txt_BuscarCodigo.Text)));
            }
        }

        private void Pest4_Txt_BuscarProvNombre_TextChanged(object sender, EventArgs e)
        {
            if (Pest4_Txt_BuscarProvNombre.Text == "")
            {
                Fun_CargarPrimerDataGriewC(Pest4_DataGrid_ManejoContactos);
               // Fun_CargarPrimerDataGriewC(DataGridView dgv)
                    }
            else
            {
                Fun_CargarPorCodigoProveedorC(Pest4_DataGrid_ManejoContactos,Convert.ToInt16(Pest4_Txt_BuscarProvNombre.Text));
            }
        }

        private void Pest4_Radio_Nuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest4_Radio_BusqYManeji.Checked != true)
            {
                Pest4_Txt_BuscarCodigo.Enabled = false;
                Pest4_Txt_BuscarNombre.Enabled = false;
                Pest4_Txt_BuscarProvNombre.Enabled = false;
                Pest4_Radio_CodigoBusqueda.Enabled = false;
                Pest4_Radio_NombreBusqueda.Enabled = false;
                Pest4_Radio_ProveedorBusqueda.Enabled = false;
                Pest4_DataGrid_ManejoContactos.Enabled = false;

                Pest4_Txt_NombreCont.Enabled = true;
                Pest4_Txt_ApellidoCont.Enabled = true;
            }
            else
            {
                Pest4_Txt_NombreCont.Enabled = false;
                Pest4_Txt_ApellidoCont.Enabled = false;
                Pest4_Txt_NombreCont.Text = "";
                Pest4_Txt_ApellidoCont.Text = "";
                Pest4_Txt_RolContact.Text = "";
                Pest4_Txt_CorreoContact.Text = "";
                Pest1_Mask_NumeroFijoEmpleado.Text = "";
            }





        }

        private void Pest1_Txt__CodigoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Val.SoloNumeros(e);
        }

        private void Pest1_Txt__Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            Val.ValirLetrasYEspacios(sender, e, Pest1_Txt__Nombre);
        }

        private void Pest1_Txt__Correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarCorreoIngreso(sender, e, Pest1_Txt__Correo);
        }

        private void Pest1_Txt__Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, Pest1_Txt__Direccion);
        }

        private void Pest1_Txt__CodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void Pest1_Txt__ContactoCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarID(sender, e);
        }

        private void Pest1_Txt__ContactoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios(sender, e, Pest1_Txt__ContactoNombre);
        }

        private void Pest1_Txt__ContactoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios(sender, e, Pest1_Txt__ContactoApellido);
        }

        private void Pest1_Txt__ContactoRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios(sender, e, Pest1_Txt__ContactoRol);
        }

        private void Pest1_Txt__ContactoCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Val.ValidarCorreoIngreso(sender, e);
            Val.ValidarCorreoIngreso(sender, e, Pest1_Txt__ContactoCorreo);
        }

        private void Pest1_Txt__ContactoTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarID(sender,e);
        }

        private void Pest3_Txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarID(sender,e);
        }

        private void Pest3_Txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios(sender, e, Pest3_Txt_Nombre);
        }

        private void Pest3_Txt_CorreoElectronico_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarCorreoIngreso(sender, e, Pest3_Txt_CorreoElectronico);
        }

        private void Pest3_Txt_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, Pest3_Txt_Direccion);
        }

        private void Pest3_Txt_CodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarID(sender, e);
        }

        private void Pest4_Radio_NombreBusqueda_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest4_Radio_NombreBusqueda.Checked == true)
            {
                Pest4_Txt_BuscarNombre.Enabled = true;
            }else
            {
                Pest4_Txt_BuscarNombre.Enabled = false;
            }
        }

        private void Pest4_Radio_ProveedorBusqueda_CheckedChanged(object sender, EventArgs e)
        {
            if(Pest4_Radio_ProveedorBusqueda.Checked == true){ 
            Pest4_Txt_BuscarProvNombre.Enabled = true;
            }else
            {
                Pest4_Txt_BuscarProvNombre.Enabled = false;
            }
        }

        private void Pest4_Radio_CodigoBusqueda_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest4_Radio_CodigoBusqueda.Checked == true)
            {
                Pest4_Txt_BuscarCodigo.Enabled = true;
            }
            else
            {
                Pest4_Txt_BuscarCodigo.Enabled = false;
            }
        }


       

            public void Fun_ExtraerProveedores()
        {
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select Codigo_Proveedor, Nombre from Proveedor");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();

   

            comboBox1.ValueMember = "Codigo_Proveedor";
            comboBox1.DisplayMember = "Nombre";
            comboBox1.DataSource = Con.dt;
           
        }

        
            public void Fun_ExtraerTele()
        {
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select Cod_Pais, CodigoTelefonico from Nacionalidad");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();


            Pest4_ComBox_TelefonoFijoCodigo.ValueMember = "Cod_Pais";
            Pest4_ComBox_TelefonoFijoCodigo.DisplayMember = "CodigoTelefonico";
            Pest4_ComBox_TelefonoFijoCodigo.DataSource = Con.dt;

        }


        private void Pest4_Txt_BuscarCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarID(sender, e);
        }

        private void Pest4_Txt_BuscarNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void Pest4_Txt_BuscarProvNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarID(sender, e);
        }

        private void Pest4_Txt_CodigoContac_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarID(sender, e);
        }

        private void Pest4_Txt_NombreCont_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void Pest4_Txt_ApellidoCont_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void Pest4_Txt_CorreoContact_KeyPress(object sender, KeyPressEventArgs e)
        {
           // Val.ValidarCorreoIngreso(sender, e);
        }

        private void Pest4_Txt_RolContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void Pest4_Bttn_Limpiar_Click(object sender, EventArgs e)
        {
         
            Pest4_Txt_NombreCont.Text="";
            Pest4_Txt_ApellidoCont.Text = "";
            Pest4_Txt_RolContact.Text = "";
            Pest4_Txt_CorreoContact.Text = "";
            Pest1_Mask_NumeroFijoEmpleado.Text = "";
        }

        private void Pest4_DataGrid_ManejoContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Pest4_Radio_BusqYManeji.Checked = true;
            Pest4_Txt_CodigoContac.Text= Pest4_DataGrid_ManejoContactos.CurrentRow.Cells[0].Value.ToString();
            Pest4_Txt_NombreCont.Text =  Pest4_DataGrid_ManejoContactos.CurrentRow.Cells[1].Value.ToString();
            Pest4_Txt_ApellidoCont.Text  = Pest4_DataGrid_ManejoContactos.CurrentRow.Cells[2].Value.ToString();      
            Pest4_Txt_CorreoContact.Text = Pest4_DataGrid_ManejoContactos.CurrentRow.Cells[3].Value.ToString();
            Pest1_Mask_NumeroFijoEmpleado.Text = Pest4_DataGrid_ManejoContactos.CurrentRow.Cells[4].Value.ToString();
            Pest4_Txt_RolContact.Text = Pest4_DataGrid_ManejoContactos.CurrentRow.Cells[5].Value.ToString();
            comboBox1.SelectedValue = Convert.ToInt32(Pest4_DataGrid_ManejoContactos.CurrentRow.Cells[8].Value.ToString());
            Pest4_ComBox_TelefonoFijoCodigo.SelectedValue = Convert.ToInt32(Pest4_DataGrid_ManejoContactos.CurrentRow.Cells[11].Value.ToString());
            Pest4_CoBx_Estado.SelectedValue = Convert.ToInt32(Pest4_DataGrid_ManejoContactos.CurrentRow.Cells[6].Value.ToString());           
            MessageBox.Show("Listo");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Pest3_Grupo_Manejo_Enter(object sender, EventArgs e)
        {

        }
    }
}

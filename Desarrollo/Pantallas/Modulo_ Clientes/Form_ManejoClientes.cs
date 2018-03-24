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

namespace Desarrollo.Pantallas.Modulo__Ingreso_al_sistema
{
    public partial class Form_ManejoClientes : System.Windows.Forms.Form
    {
        C_Clientes cli = new C_Clientes();
        Validaciones val = new Validaciones();
        public int Cod;
        private double Din,Don;
        public bool Verificar = false;
        public bool NewCuentaCredito = false;
        int Det=0;
        
        public Form_ManejoClientes()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            if (Verificar == true)
            {
                opcion = MessageBox.Show("No ha guardado los cambios realizados en la pestaña de Modificacion, ¿Quiere guardar los datos y salir?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
                if (opcion == DialogResult.Yes)
                {
                    Pest3_Btn_Aceptar_Click_1(sender, e);

                }
                else if (opcion == DialogResult.No)
                {
                    this.Close();
                }
                else if (opcion == DialogResult.Cancel)
                {
                    return;
                }
            }
            else
            {
                this.Close();
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_existencia_NO.Checked == false && rb_existencia_SI.Checked == true)
            {

                if (rb_empresa_nueva.Checked == true && rb_existencia_SI.Checked == true)
                {
                    Pest4_combo_CodigoEmpresa.Enabled = false;
                    Pest4_txt_NombreEmpresa.Enabled = false;
                    Pest4_txt_InformacionEmpresa.Enabled = false;
                    Pest4_txt_TelefonoNuevaEmpresa.Enabled = true;
                    Pest4_txt_CodigoNuevaEmpresa.Enabled = false;
                    Pest4_txt_CodigoClienteNuevaEmpresa.Text = Convert.ToString(cli.ObtenerUltimoID());
                    if (Pest4_txt_CodigoClienteNuevaEmpresa.Text != string.Empty)
                    {
                        Pest4_txt_CodigoNuevaEmpresa.Text = Convert.ToString(cli.ObtenerUltimoCodigoEmpresa());
                    }
                    Pest4_txt_CodigoNuevaEmpresa.Clear();
                    Pest4_txt_RTNNuevaEmpresa.Enabled = true;
                    Pest4_combo_CodigoEmpresa.Text = string.Empty;
                    Pest4_txt_NombreNueva.Enabled = true;
                    Pest4_txt_CiudadNuevaEmpresa.Enabled = true;
                    Pest4_txt_DireccionNuevaEmpresa.Enabled = true;
                }
                else
                {
                    Pest4_combo_CodigoEmpresa.Enabled = true;
                    Pest4_txt_NombreEmpresa.Enabled = true;
                    Pest4_txt_InformacionEmpresa.Enabled = true;
                    Pest4_txt_TelefonoNuevaEmpresa.Enabled = false;
                    Pest4_txt_CodigoNuevaEmpresa.Enabled = false;
                    Pest4_txt_CodigoNuevaEmpresa.Clear();
                    Pest4_txt_CodigoClienteNuevaEmpresa.Clear();
                    Pest4_txt_RTNNuevaEmpresa.Enabled = false;
                    Pest4_txt_NombreNueva.Enabled = false;
                    Pest4_txt_CiudadNuevaEmpresa.Enabled = false;
                    Pest4_txt_DireccionNuevaEmpresa.Enabled = false; Pest4_txt_NombreNueva.Clear();
                    Pest4_txt_RTNNuevaEmpresa.Clear();
                    Pest4_txt_TelefonoNuevaEmpresa.Clear();
                    Pest4_txt_DireccionNuevaEmpresa.Clear();
                    Pest4_txt_CiudadNuevaEmpresa.Clear();
                }

                if (Pest4_txt_CodigoClienteNuevaEmpresa.Text != string.Empty)
                {
                    Pest4_txt_CodigoNuevaEmpresa.Text = Convert.ToString(cli.ObtenerUltimoCodigoEmpresa());
                }



            }
           
                
            
            else
            {

                Pest4_combo_CodigoEmpresa.Enabled = false;
                Pest4_txt_NombreEmpresa.Enabled = false;
                Pest4_txt_InformacionEmpresa.Enabled = false;
                Pest4_txt_TelefonoNuevaEmpresa.Enabled = false;
                Pest4_txt_CodigoNuevaEmpresa.Enabled = false;
                Pest4_txt_CodigoNuevaEmpresa.Clear();
                Pest4_txt_RTNNuevaEmpresa.Enabled = false;
                Pest4_txt_NombreNueva.Enabled = false;
                Pest4_combo_CodigoEmpresa.Text = string.Empty;
                Pest4_txt_CodigoClienteNuevaEmpresa.Clear();
                Pest4_txt_CiudadNuevaEmpresa.Enabled = false;
                Pest4_txt_DireccionNuevaEmpresa.Enabled = false; Pest4_txt_NombreNueva.Clear();
                Pest4_txt_RTNNuevaEmpresa.Clear();
                Pest4_txt_TelefonoNuevaEmpresa.Clear();
                Pest4_txt_DireccionNuevaEmpresa.Clear();
                Pest4_txt_CiudadNuevaEmpresa.Clear();
            }
        }

        private void rb_existencia_NO_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_existencia_NO.Checked == false && rb_existencia_SI.Checked == true)
            {

                if (rb_empresa_nueva.Checked == true && rb_existencia_SI.Checked == true)
                {
                    Pest4_combo_CodigoEmpresa.Enabled = false;
                    Pest4_txt_NombreEmpresa.Enabled = false;
                    Pest4_txt_InformacionEmpresa.Enabled = false;
                    Pest4_txt_TelefonoNuevaEmpresa.Enabled = true;
                    Pest4_txt_CodigoNuevaEmpresa.Enabled = false;
                    Pest4_txt_CodigoClienteNuevaEmpresa.Text = Convert.ToString(cli.ObtenerUltimoID());
                    if(Pest4_txt_CodigoClienteNuevaEmpresa.Text != string.Empty)
                    {
                        Pest4_txt_CodigoNuevaEmpresa.Text = Convert.ToString(cli.ObtenerUltimoCodigoEmpresa());
                    }
                    Pest4_txt_CodigoNuevaEmpresa.Clear();
                    Pest4_txt_RTNNuevaEmpresa.Enabled = true;
                    Pest4_combo_CodigoEmpresa.Text = string.Empty;
                    Pest4_txt_NombreNueva.Enabled = true;
                    Pest4_txt_CiudadNuevaEmpresa.Enabled = true;
                    Pest4_txt_DireccionNuevaEmpresa.Enabled = true;
                }
                else
                {
                    Pest4_combo_CodigoEmpresa.Enabled = true;
                    Pest4_txt_NombreEmpresa.Enabled = true;
                    Pest4_txt_InformacionEmpresa.Enabled = true;
                    Pest4_txt_TelefonoNuevaEmpresa.Enabled = false;
                    Pest4_txt_CodigoNuevaEmpresa.Enabled = false;
                    Pest4_txt_CodigoNuevaEmpresa.Clear();
                    Pest4_txt_CodigoClienteNuevaEmpresa.Clear();
                    Pest4_txt_RTNNuevaEmpresa.Enabled = false;
                    Pest4_txt_NombreNueva.Enabled = false;
                    Pest4_txt_CiudadNuevaEmpresa.Enabled = false;
                    Pest4_txt_DireccionNuevaEmpresa.Enabled = false; Pest4_txt_NombreNueva.Clear();
                    Pest4_txt_RTNNuevaEmpresa.Clear();
                    Pest4_txt_TelefonoNuevaEmpresa.Clear();
                    Pest4_txt_DireccionNuevaEmpresa.Clear();
                    Pest4_txt_CiudadNuevaEmpresa.Clear();
                }


                if (Pest4_txt_CodigoClienteNuevaEmpresa.Text != string.Empty)
                {
                    Pest4_txt_CodigoNuevaEmpresa.Text = Convert.ToString(cli.ObtenerUltimoCodigoEmpresa());
                }


            }
            else
            {

                Pest4_combo_CodigoEmpresa.Enabled = false;
                Pest4_txt_NombreEmpresa.Enabled = false;
                Pest4_txt_InformacionEmpresa.Enabled = false;
                Pest4_txt_TelefonoNuevaEmpresa.Enabled = false;
                Pest4_txt_CodigoNuevaEmpresa.Enabled = false;
                Pest4_txt_CodigoNuevaEmpresa.Clear();
                Pest4_txt_RTNNuevaEmpresa.Enabled = false;
                Pest4_txt_NombreNueva.Enabled = false;
                Pest4_combo_CodigoEmpresa.Text = string.Empty;
                Pest4_txt_CodigoClienteNuevaEmpresa.Clear();
                Pest4_txt_CiudadNuevaEmpresa.Enabled = false;
                Pest4_txt_DireccionNuevaEmpresa.Enabled = false; Pest4_txt_NombreNueva.Clear();
                Pest4_txt_RTNNuevaEmpresa.Clear();
                Pest4_txt_TelefonoNuevaEmpresa.Clear();
                Pest4_txt_DireccionNuevaEmpresa.Clear();
                Pest4_txt_CiudadNuevaEmpresa.Clear();
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void Form_ManejoClientes_Load(object sender, EventArgs e)
        {
            llenarDataGridView(Pest1_DataGriew_InformacionCliente);
            ExtraerEstados();
            Pest5_Pest2_Check_NuevaPersona.Checked = true;

    if (Cod==2 || Cod == 4)
            {
                Pest2_Radio_Pendiente.Enabled = false;
                Pest2_Radio_Pagado.Enabled = false;
            }
   

            cli.ExtraerEstadoParaReferencias(Pest5_Pest2_Combo_Estado);





            Pest2_Radio_Contado.Checked = true;
            Pest2_Radio_Pagado.Checked = true;
            

         
            rb_existencia_SI.Checked = true;
            rb_empresa_existente.Checked = true;
            Pest4_txt_CodigoCliente.Enabled = false;
            Pest4_txt_CodigoClienteNuevaEmpresa.Enabled = false;
            Pest4_txt_NombreEmpresa.ReadOnly = true;
            Pest4_txt_InformacionEmpresa.ReadOnly = true;
            Pest4_txt_CodigoCliente.Text = Convert.ToString(cli.ObtenerUltimoID());
            Pest4_combo_CodigoEmpresa.MaxLength = cli.longitudMaximaCombo();
            EmpresaExistente();
            validacionMenu();

            cli.ExtraerEstadosCredito(Pest5_Estados);



        }

        private void validacionMenu()
        {
            var blankContextMenu = new ContextMenuStrip();

            var boxes = groupBox2.Controls.OfType<TextBox>();
                    foreach (var box in boxes)
                    {
                        box.ContextMenuStrip = blankContextMenu;

                    }


            var boxe = groupBox10.Controls.OfType<TextBox>();
            foreach (var box in boxe)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxex = groupBox9.Controls.OfType<ComboBox>();
            foreach (var box in boxex)
            {
                box.ContextMenuStrip = blankContextMenu;

            }


            var boxe1 = Pest1_Grupo_Busqueda.Controls.OfType<TextBox>();
            foreach (var box in boxe1)
            {
                box.ContextMenuStrip = blankContextMenu;

            }


            var boxe2 = pest3_grupo_modificacion.Controls.OfType<TextBox>();
            foreach (var box in boxe2)
            {
                box.ContextMenuStrip = blankContextMenu;

            }
            //CREDITOS
            var boxes1 = groupBox1.Controls.OfType<TextBox>();
            foreach (var box in boxes1)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes2 = groupBox13.Controls.OfType<TextBox>();
            foreach (var box in boxes2)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes3 = groupBox12.Controls.OfType<TextBox>();
            foreach (var box in boxes3)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes4 = groupBox11.Controls.OfType<TextBox>();
            foreach (var box in boxes4)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes5 = groupBox15.Controls.OfType<TextBox>();
            foreach (var box in boxes5)
            {
                box.ContextMenuStrip = blankContextMenu;

            }


        }

        private void rb_empresa_nueva_CheckedChanged(object sender, EventArgs e)
        {
            if ( rb_existencia_SI.Checked == true)
            {

                if (rb_empresa_nueva.Checked == true )
                {
                    if(rb_existencia_SI.Checked == true)
                    {
                        Pest4_combo_CodigoEmpresa.Enabled = false;
                        Pest4_txt_NombreEmpresa.Enabled = false;
                        Pest4_txt_InformacionEmpresa.Enabled = false;
                        Pest4_txt_CodigoClienteNuevaEmpresa.Text = Convert.ToString(cli.ObtenerUltimoID());
                        Pest4_txt_TelefonoNuevaEmpresa.Enabled = true;
                        Pest4_txt_CodigoNuevaEmpresa.Enabled = false;
                        if (Pest4_txt_CodigoClienteNuevaEmpresa.Text != string.Empty)
                        {
                            Pest4_txt_CodigoNuevaEmpresa.Text = Convert.ToString(cli.ObtenerUltimoCodigoEmpresa());
                        }
                        Pest4_txt_RTNNuevaEmpresa.Enabled = true;
                        Pest4_combo_CodigoEmpresa.Text = string.Empty;
                        Pest4_txt_NombreNueva.Enabled = true;
                        Pest4_txt_CiudadNuevaEmpresa.Enabled = true;
                        Pest4_txt_DireccionNuevaEmpresa.Enabled = true;
                    }
                    
                }
                else
                {
                    Pest4_combo_CodigoEmpresa.Enabled = true;
                    Pest4_txt_NombreEmpresa.Enabled = true;
                    Pest4_txt_InformacionEmpresa.Enabled = true;
                    Pest4_txt_TelefonoNuevaEmpresa.Enabled = false;
                    Pest4_txt_CodigoNuevaEmpresa.Enabled = false;
                    Pest4_txt_CodigoNuevaEmpresa.Clear();
                    Pest4_txt_CodigoClienteNuevaEmpresa.Clear();
                    Pest4_txt_RTNNuevaEmpresa.Enabled = false;
                    Pest4_txt_NombreNueva.Enabled = false;
                    Pest4_txt_CiudadNuevaEmpresa.Enabled = false;
                    Pest4_txt_DireccionNuevaEmpresa.Enabled = false;
                    Pest4_txt_NombreNueva.Clear();
                    Pest4_txt_RTNNuevaEmpresa.Clear();
                    Pest4_txt_TelefonoNuevaEmpresa.Clear();
                    Pest4_txt_DireccionNuevaEmpresa.Clear();
                    Pest4_txt_CiudadNuevaEmpresa.Clear();
                }



                if (Pest4_txt_CodigoClienteNuevaEmpresa.Text != string.Empty)
                {
                    Pest4_txt_CodigoNuevaEmpresa.Text = Convert.ToString(cli.ObtenerUltimoCodigoEmpresa());
                }

            }
            else
            {

                Pest4_combo_CodigoEmpresa.Enabled = false;
                Pest4_txt_NombreEmpresa.Enabled = false;
                Pest4_txt_InformacionEmpresa.Enabled = false;
                Pest4_txt_TelefonoNuevaEmpresa.Enabled = false;
                Pest4_txt_CodigoNuevaEmpresa.Enabled = false;
                Pest4_txt_RTNNuevaEmpresa.Enabled = false;
                Pest4_txt_CodigoClienteNuevaEmpresa.Clear();
                Pest4_combo_CodigoEmpresa.Text = string.Empty;
                Pest4_txt_CodigoNuevaEmpresa.Clear();
                Pest4_txt_NombreNueva.Enabled = false;
                Pest4_txt_CiudadNuevaEmpresa.Enabled = false;
                Pest4_txt_DireccionNuevaEmpresa.Enabled = false;
                Pest4_txt_NombreNueva.Clear();
                Pest4_txt_RTNNuevaEmpresa.Clear();
                Pest4_txt_TelefonoNuevaEmpresa.Clear();
                Pest4_txt_DireccionNuevaEmpresa.Clear();
                Pest4_txt_CiudadNuevaEmpresa.Clear();
            }
        }

        public void EmpresaExistente()
        {
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select Codigo_Empresa, NombreEmpresa from Empresas");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();


            Con.Dr = Con.dt.NewRow();
            Con.dt.Rows.InsertAt(Con.Dr, 0);

            Pest4_combo_CodigoEmpresa.ValueMember = "Codigo_Empresa";
            Pest4_combo_CodigoEmpresa.DisplayMember = "Codigo_Empresa";
            Pest4_combo_CodigoEmpresa.DataSource = Con.dt;
        }

        private void Pest_txt_CodigoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pest_combo_CodigoEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Pest_combo_CodigoEmpresa_TextChanged(object sender, EventArgs e)
        {

            if (Pest4_combo_CodigoEmpresa.Text != string.Empty)
            {

                double a = Convert.ToDouble(Pest4_combo_CodigoEmpresa.Text);
                cli.Codpruebs = (int)a;
                
                if(cli.Codpruebs>=cli.ObtenerUltimoCodigoEmpresa())
                {
                    this.errorProvider1.SetError(Pest4_combo_CodigoEmpresa, "Ingrese un valor adecuado");
                    
                    Pest4_txt_NombreEmpresa.Clear();
                    Pest4_txt_InformacionEmpresa.Clear();
                }
                else
                {
                    Pest4_txt_NombreEmpresa.Text = cli.NomEmpresa();
                    Pest4_txt_InformacionEmpresa.Text = cli.InfoEmpresa();
                    this.errorProvider1.Clear();
                    
                }
                

            }
            else
            {
                errorProvider1.SetError(Pest4_combo_CodigoEmpresa, "");
                Pest4_txt_NombreEmpresa.Clear();
                Pest4_txt_InformacionEmpresa.Clear();
                
                
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fun_LimpiezaNuevoCliente();

        }

        private void Fun_LimpiezaNuevoCliente()
        {
            Pest4_combo_CodigoEmpresa.Text = string.Empty;
            Pest4_txt_ApellidoCliente.Clear();
            Pest4_txt_CelularCliente.Clear();
            Pest4_txt_CiudadCliente.Clear();
            Pest4_txt_CiudadNuevaEmpresa.Clear();
            Pest4_txt_DepartamentoCliente.Clear();
            Pest4_txt_DireccionCliente.Clear();
            Pest4_txt_DireccionNuevaEmpresa.Clear();
            Pest4_txt_EmailCliente.Clear();
            Pest4_txt_IDCliente.Clear();
            Pest4_txt_NombreCliente.Clear();
            Pest4_txt_NombreNueva.Clear();
            Pest4_txt_RTNCliente.Clear();
            Pest4_txt_RTNNuevaEmpresa.Clear();
            Pest4_txt_TelefonoCliente.Clear();
            Pest4_txt_TelefonoNuevaEmpresa.Clear();
        }

        private void Pest_combo_CodigoEmpresa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Pest4_combo_CodigoEmpresa.SelectedIndex == -1)
            {
                Pest4_txt_NombreEmpresa.Clear();
                Pest4_txt_InformacionEmpresa.Clear();
                
            }

            else
            {
                int a = (int)(Pest4_combo_CodigoEmpresa.SelectedIndex);
                cli.Codpruebs = a;
                
                Pest4_txt_NombreEmpresa.Text = cli.NomEmpresa();
                Pest4_txt_InformacionEmpresa.Text = cli.InfoEmpresa();
            }
        }
  
        private bool Vacios(object sender, EventArgs e, int a)
        {
            int s=0;
            int x=0;
            switch (a)
            {
                case 1:
                    
                    var boxes = groupBox2.Controls.OfType<TextBox>();
                    foreach (var box in boxes)
                    {
                        if (string.IsNullOrWhiteSpace(box.Text))
                        {
                            errorProvider1.SetError(box, "Please fill the required field");
                            s++;
                        }
                        else
                        {
                            errorProvider1.SetError(box,"");
                        }
                        
                    }
                    if(s>0)
                        return false;
                    else
                    {
                        
                        return true;
                    }
                        

                    break;

                default:
                    /*foreach (object t in groupBox10.Controls)
                    {
                        if (t.GetType() == typeof(TextBox))
                        {
                            if (((TextBox)t).Text == string.Empty) v += 1;
                        }
                    }
                    if (v > 0)
                    {
                        MessageBox.Show("Como minimo un textbox de Datos de Empresa esta vacio");
                        return false;
                    }
                    else return true;*/
                    var boxesx = groupBox2.Controls.OfType<TextBox>();
                    foreach (var box in boxesx)
                    {
                        if (string.IsNullOrWhiteSpace(box.Text))
                        {
                            errorProvider1.SetError(box, "Please fill the required field");
                            x++;
                        }
                        else
                        {
                            errorProvider1.SetError(box, "");
                        }

                    }
                   
                    var boxess = groupBox10.Controls.OfType<TextBox>();
                    foreach (var box in boxess)
                    {
                        if (string.IsNullOrWhiteSpace(box.Text))
                        {
                            errorProvider1.SetError(box, "Please fill the required field");
                            x++;
                        }
                        else
                        {
                            errorProvider1.SetError(box, "");
                        }
                        
                    }
                    if (x > 0)
                        return false;
                    else
                        return true;

                    break;
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cli.Codigocliente1 = cli.ObtenerUltimoID();
            cli.NumeroIDCliente1 = Convert.ToString(Pest4_txt_IDCliente.Text);
            cli.NombreCliente1 = Convert.ToString(Pest4_txt_NombreCliente.Text);
            cli.ApellidoCliente1 = Convert.ToString(Pest4_txt_ApellidoCliente.Text);
            cli.CelularCliente1 = Convert.ToString(Pest4_txt_CelularCliente.Text);
            cli.TelefonoCliente1 = Convert.ToString(Pest4_txt_TelefonoCliente.Text);
            cli.EmailCliente1 = Convert.ToString(Pest4_txt_EmailCliente.Text);
            cli.DireccionCliente1 = Convert.ToString(Pest4_txt_DireccionCliente.Text);
            cli.DepartamentoCliente1 = Convert.ToString(Pest4_txt_DepartamentoCliente.Text);
            cli.CiudadCliente1 = Convert.ToString(Pest4_txt_CiudadCliente.Text);
            cli.RTNCliente1 = Convert.ToString(Pest4_txt_RTNCliente.Text);
            
            if (rb_existencia_NO.Checked == true && Vacios(sender, e, 1) == true)
            {
                if (cli.RevisionDeDatos() == false)
                {
                    MessageBox.Show("Existe una duplicación de datos ya sea por el Numero de Identidad" +
                "o el Nombre completo del Cliente o el RTN del Cliente, por favor revise nuevamente los datos del Nuevo Cliente.", "Duplicacion de Datos", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    if (val.Verificaremail(cli.EmailCliente1) == true)
                    {
                         cli.IngresoDatos();
                    MessageBox.Show("Datos Ingresados correctamente");
                        
                    }
                   else
                    {
                        errorProvider1.SetError(Pest4_txt_EmailCliente, "Formato Incorrecto");
                    }
                }

            }

            else if (rb_existencia_SI.Checked == true && rb_empresa_existente.Checked == true && Vacios(sender, e, 1) == true)
            {
                if (Pest4_combo_CodigoEmpresa.Text == string.Empty && Pest4_combo_CodigoEmpresa.SelectedIndex < 0)
                {
                    errorProvider1.SetError(Pest4_combo_CodigoEmpresa, "Please fill the required field");

                }
                else
                {
                    if (cli.Codpruebs >= cli.ObtenerUltimoCodigoEmpresa())
                    {
                        errorProvider1.SetError(Pest4_combo_CodigoEmpresa, "Ingrese un valor adecuado");
                    }
                    else
                    {
                        if (cli.RevisionDeDatos() == false)
                        {
                            MessageBox.Show("Existe una duplicación de datos ya sea por el Numero de Identidad" +
                        "o el Nombre completo del Cliente o el RTN del Cliente, por favor revise nuevamente los datos del Nuevo Cliente.", "Duplicacion de Datos", MessageBoxButtons.OK);
                            return;
                        }
                        else
                        {
                            
                            if (val.Verificaremail(cli.EmailCliente1) == true)
                            {
                                cli.IngresoDatos2();
                                MessageBox.Show("Datos Ingresados correctamente");
                                errorProvider1.SetError(Pest4_combo_CodigoEmpresa, "");
                            }
                            else
                            {
                                errorProvider1.SetError(Pest4_txt_EmailCliente, "Formato Incorrecto");
                            }
                        }

                    }
                }

            }
            else if (rb_existencia_SI.Checked == true && rb_empresa_nueva.Checked == true && Vacios(sender, e, 2) == true)
            {
                cli.NombreEmpresa1 = Convert.ToString(Pest4_txt_NombreNueva.Text);
                cli.RTNEmpresa1 = Convert.ToString(Pest4_txt_RTNNuevaEmpresa.Text);
                cli.TelefonoEmpresa1 = Convert.ToString(Pest4_txt_TelefonoNuevaEmpresa.Text);
                cli.DireccionEmpresa1 = Convert.ToString(Pest4_txt_DireccionNuevaEmpresa.Text);
                cli.CiudadEmpresa1 = Convert.ToString(Pest4_txt_CiudadNuevaEmpresa.Text);

                if (cli.RevisionDeDatos() == false || cli.RevisionDeDatosNuevaEmpresa() == false)
                {
                    MessageBox.Show("Existe una duplicación de datos ya sea por el Numero de Identidad" +
                "o el Nombre completo del Clienteo el RTN del Cliente o por los equivalentes en el apartado de Empresas, por favor revise nuevamente los datos del Nuevo Cliente.", "Duplicacion de Datos", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    
                    if (val.Verificaremail(cli.EmailCliente1) == true)
                    {
                        cli.IngresoNuevaEmpresa();
                        cli.IngresoDatos3();
                        MessageBox.Show("Datos Ingresados correctamente");
                        Pest4_txt_CodigoClienteNuevaEmpresa.Text = Convert.ToString(cli.ObtenerUltimoID());
                        Pest4_txt_CodigoNuevaEmpresa.Text = Convert.ToString(cli.ObtenerUltimoCodigoEmpresa());
                    }
                    else
                    {
                        errorProvider1.SetError(Pest4_txt_EmailCliente, "Formato Incorrecto");
                    }

                }



            }

            Pest4_combo_CodigoEmpresa.MaxLength = cli.longitudMaximaCombo();
            Pest4_txt_CodigoCliente.Text = Convert.ToString(cli.ObtenerUltimoID());
            EmpresaExistente();
            llenarDataGridView(Pest1_DataGriew_InformacionCliente);
            Fun_LimpiezaNuevoCliente();

        }

        private void Pest4_txt_IDCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarID(sender, e);
        }

        private void Pest4_txt_NombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValirLetrasYEspacios(sender,e, Pest4_txt_NombreCliente);
           // val.PrimeroMayuscula(sender, e, Pest4_txt_NombreCliente);
        }

        private void Pest4_txt_ApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValirLetrasYEspacios(sender, e, Pest4_txt_ApellidoCliente);
           // val.PrimeroMayuscula(sender, e, Pest4_txt_ApellidoCliente);
        }

        private void Pest4_txt_CelularCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            val.NumerosReales_NegativosOPositivos(sender, e, Pest4_txt_CelularCliente);
        }

        private void Pest4_txt_TelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            val.NumerosReales_NegativosOPositivos(sender, e, Pest4_txt_TelefonoCliente);
        }

        private void Pest4_txt_EmailCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarCorreoIngreso(sender, e, Pest4_txt_EmailCliente);
        }

        private void Pest4_txt_DireccionCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValirLetrasYEspacios_Direccion(sender, e, Pest4_txt_DireccionCliente);
           // val.PrimeroMayuscula(sender, e, Pest4_txt_DireccionCliente);
        }

        private void Pest4_txt_DepartamentoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValirLetrasYEspacios(sender, e, Pest4_txt_DepartamentoCliente);
           // val.PrimeroMayuscula(sender, e, Pest4_txt_DepartamentoCliente);
        }

        private void Pest4_txt_CiudadCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //val.PrimeroMayuscula(sender,e,Pest4_txt_CiudadCliente);
            val.ValirLetrasYEspacios(sender,e,Pest4_txt_CiudadCliente);

        }

        private void Pest4_txt_RTNCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarID(sender, e);
        }

        private void Pest4_txt_CodigoNuevaEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarID(sender, e);
        }

        private void Pest4_txt_TelefonoNuevaEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.NumerosReales_NegativosOPositivos(sender, e, Pest4_txt_TelefonoNuevaEmpresa);
        }

        private void Pest4_txt_RTNNuevaEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarID(sender, e);
        }

        private void Pest4_txt_NombreNueva_KeyPress(object sender, KeyPressEventArgs e)
        {
            //val.ValidarNombres_SoloLetras(sender, e);
            val.ValirLetrasYEspacios(sender,e, Pest4_txt_NombreNueva);
            //val.PrimeroMayuscula(sender, e, Pest4_txt_NombreNueva);


        }

        private void Pest4_txt_CiudadNuevaEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            //val.ValidarNombres_SoloLetras(sender, e);
            val.ValirLetrasYEspacios(sender, e, Pest4_txt_CiudadNuevaEmpresa);
           // val.PrimeroMayuscula(sender, e, Pest4_txt_CiudadNuevaEmpresa);
  
        }

        private void Pest4_txt_DireccionNuevaEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValirLetrasYEspacios_Direccion(sender, e, Pest4_txt_DireccionNuevaEmpresa);
            //val.PrimeroMayuscula(sender, e, Pest4_txt_DireccionNuevaEmpresa);
        }

        private void Pest4_combo_CodigoEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarID(sender, e);
        }

        private void rb_empresa_existente_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_existencia_NO.Checked == false && rb_existencia_SI.Checked == true)
            {

                if (rb_empresa_nueva.Checked == true && rb_existencia_SI.Checked == true)
                {
                    Pest4_combo_CodigoEmpresa.Enabled = false;
                    Pest4_txt_NombreEmpresa.Enabled = false;
                    Pest4_txt_InformacionEmpresa.Enabled = false;
                    Pest4_txt_TelefonoNuevaEmpresa.Enabled = true;
                    Pest4_txt_CodigoNuevaEmpresa.Enabled = false;
                    Pest4_txt_CodigoClienteNuevaEmpresa.Text = Convert.ToString(cli.ObtenerUltimoID());
                    if (Pest4_txt_CodigoClienteNuevaEmpresa.Text != string.Empty)
                    {
                        Pest4_txt_CodigoNuevaEmpresa.Text = Convert.ToString(cli.ObtenerUltimoCodigoEmpresa());
                    }
                    Pest4_txt_CodigoNuevaEmpresa.Clear();
                    Pest4_txt_RTNNuevaEmpresa.Enabled = true;
                    Pest4_combo_CodigoEmpresa.Text = string.Empty;
                    Pest4_txt_NombreNueva.Enabled = true;
                    Pest4_txt_CiudadNuevaEmpresa.Enabled = true;
                    Pest4_txt_DireccionNuevaEmpresa.Enabled = true;
                }
                else
                {
                    Pest4_combo_CodigoEmpresa.Enabled = true;
                    Pest4_txt_NombreEmpresa.Enabled = true;
                    Pest4_txt_InformacionEmpresa.Enabled = true;
                    Pest4_txt_TelefonoNuevaEmpresa.Enabled = false;
                    Pest4_txt_CodigoNuevaEmpresa.Enabled = false;
                    Pest4_txt_CodigoNuevaEmpresa.Clear();
                    Pest4_txt_CodigoClienteNuevaEmpresa.Clear();
                    Pest4_txt_RTNNuevaEmpresa.Enabled = false;
                    Pest4_txt_NombreNueva.Enabled = false;
                    Pest4_txt_CiudadNuevaEmpresa.Enabled = false;
                    Pest4_txt_DireccionNuevaEmpresa.Enabled = false;
                }


                if (Pest4_txt_CodigoClienteNuevaEmpresa.Text != string.Empty)
                {
                    Pest4_txt_CodigoNuevaEmpresa.Text = Convert.ToString(cli.ObtenerUltimoCodigoEmpresa());
                }


            }
            else
            {

                Pest4_combo_CodigoEmpresa.Enabled = false;
                Pest4_txt_NombreEmpresa.Enabled = false;
                Pest4_txt_InformacionEmpresa.Enabled = false;
                Pest4_txt_TelefonoNuevaEmpresa.Enabled = false;
                Pest4_txt_CodigoNuevaEmpresa.Enabled = false;
                Pest4_txt_CodigoNuevaEmpresa.Clear();
                Pest4_txt_RTNNuevaEmpresa.Enabled = false;
                Pest4_txt_NombreNueva.Enabled = false;
                Pest4_combo_CodigoEmpresa.Text = string.Empty;
                Pest4_txt_CodigoClienteNuevaEmpresa.Clear();
                Pest4_txt_CiudadNuevaEmpresa.Enabled = false;
                Pest4_txt_DireccionNuevaEmpresa.Enabled = false;
            }
        }

        private void toolmessage_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        Validaciones validar = new Validaciones();
        Conexion Con = new Conexion();
       
       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest1_Radio_Codigo.Checked == true)
            {
                Pest1_Radio_Codigo.Checked = true;
                Pest1_Txtbx_Codigo.Enabled = true;
                Pest1_Txtbx_NombreCliente.Text = string.Empty;
                Pest1_Txtbx_NombreCliente.Focus();
            }
            else
            {
                Pest1_Radio_Codigo.Checked = false;
                Pest1_Txtbx_Codigo.Enabled = false;
            }
        }

        private void Pest1_Txtbx_Codigo_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (Pest1_Txtbx_Codigo.Text != string.Empty)
            {
                a = Convert.ToInt32(Pest1_Txtbx_Codigo.Text);
                CargarPorCodigo(Pest1_DataGriew_InformacionCliente, a);
            }
            else
            {
                llenarDataGridView(Pest1_DataGriew_InformacionCliente);
            }

        }

        private void Pest1_Txtbx_NombreCliente_TextChanged(object sender, EventArgs e)
        {
            buscarNombreCliente();
        }

        private void Pest1_Radio_TodosContactos_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest1_Radio_TodosContactos.Checked == true)
            {
                Pest1_Txtbx_Codigo.Text = string.Empty;
                Pest1_Txtbx_NombreCliente.Text = string.Empty;
                llenarDataGridView(Pest1_DataGriew_InformacionCliente);
            }
            else
            {
                Pest1_Radio_TodosContactos.Checked = false;

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Pest1_Radio_NombreCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest1_Radio_NombreCliente.Checked == true)
            {
                Pest1_Radio_NombreCliente.Checked = true;
                Pest1_Txtbx_NombreCliente.Enabled = true;
                Pest1_Txtbx_Codigo.Text = string.Empty;

            }
            else
            {
                Pest1_Radio_NombreCliente.Checked = false;
                Pest1_Txtbx_NombreCliente.Enabled = false;
            }
        }

        private void Pest1_Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Pest1_Txtbx_Codigo.Text = String.Empty;
            Pest1_Txtbx_NombreCliente.Text = String.Empty;
        }

        private void Pest1_DataGriew_InformacionCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

       
        private void Pest1_Txtbx_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
           // validar.Solonumero(sender, e);

        }

        private void Pest1_Txtbx_NombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
          //  validar.SoloLetras(e);
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Pest1_DataGriew_InformacionCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectFila(e);
        }

        private void Pest3_Btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (Pest3_Txtbx_NumeroCelular.Text == String.Empty
            || Pest3_Txtbx_TelefonoFijo.Text == String.Empty
            || Pest3_Txtbx_Correo.Text == String.Empty
            || Pest3_Txtbx_Direccion.Text == String.Empty
            || Pest3_Txtbx_Departamento.Text == String.Empty
            || Pest3_Txtbx_Ciudad.Text == String.Empty
            || Pest3_CmbBx_Estado.SelectedIndex == 0)
            {
                MessageBox.Show("No puede dejar campos vacios", "ERROR");
            }
            else { actualizarCliente(); llenarDataGridView(Pest1_DataGriew_InformacionCliente); }
        }

        ///////////////////////////////////////FUNCIONES//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        public void llenarDataGridView(DataGridView dgv)
        {

            try
            {
                
                  Con.DataAdapter = new SqlDataAdapter(@"select C.Codigo_Cliente as 'Codigo del Cliente', C.ID as 'Identidad', C.Nombre as Nombre, C.Apellido as Apellido, C.NumeroCelular as 'Numero de Celular',
C.TelefonoFijo as 'Telefono Fijo', C.Correo as Correo, C.Direccion as Direccion, C.Departamento as Departamento, C.Ciudad as Ciudad, C.RTN as RTN, (Select Descripcion_Estado from Estados where Codigo_Estado=C.Codigo_Estado and Descripcion_Estado like '%Cliente%') as Estado
,Emp.Codigo_Empresa as 'Codigo de Empresa', C.Codigo_Credito as 'Codigo de Credito', Emp.NombreEmpresa as 'Nombre de la empresa'
 from Clientes as C left join Empresas as Emp on C.Codigo_Empresa=Emp.Codigo_Empresa
", Con.cnx);
                Con.dt = new DataTable();
                Con.DataAdapter.Fill(Con.dt);
                dgv.DataSource = Con.dt;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void buscarNombreCliente()
        {
            CargarPorNombre(Pest1_DataGriew_InformacionCliente, Pest1_Txtbx_NombreCliente.Text);
        }

        public void ExtraerEstados()
        {
            Con.cnx.Open();
           
           Con.sql = string.Format(@"select Codigo_Estado, Descripcion_Estado from Estados where Codigo_Tipo_Estado = 2");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();


            Pest3_CmbBx_Estado.ValueMember = "Codigo_Estado";
            Pest3_CmbBx_Estado.DisplayMember = "Descripcion_Estado";
            Pest3_CmbBx_Estado.DataSource = Con.dt;
            Con.cnx.Close();
        }


        private void actualizarCliente()
        {
            using (SqlConnection sc = new SqlConnection())
            {
                Con.cnx.Open();

                using (SqlCommand com = Con.cnx.CreateCommand())
                {
                    com.CommandText = "UPDATE Clientes SET  NumeroCelular = @clienteNumeroCelular, TelefonoFijo = @clienteTelefonoFijo, Direccion = @clienteDireccion, Correo = @clienteCorreo, Departamento = @clienteDepartamento, Ciudad = @clienteCiudad, Codigo_Estado = @clienteCodigoEstado WHERE Codigo_Cliente =" + Pest3_Txtbx_CodigoCliente.Text;

                    com.Parameters.AddWithValue("@clienteNumeroCelular", Pest3_Txtbx_NumeroCelular.Text);
                    com.Parameters.AddWithValue("@clienteTelefonoFijo", Pest3_Txtbx_TelefonoFijo.Text);
                    com.Parameters.AddWithValue("@clienteCorreo", Pest3_Txtbx_Correo.Text);
                    com.Parameters.AddWithValue("@clienteDireccion", Pest3_Txtbx_Direccion.Text);
                    com.Parameters.AddWithValue("@clienteDepartamento", Pest3_Txtbx_Departamento.Text);
                    com.Parameters.AddWithValue("@clienteCiudad", Pest3_Txtbx_Ciudad.Text);
                    com.Parameters.AddWithValue("@clienteCodigoEstado", Pest3_CmbBx_Estado.SelectedValue);

                    com.ExecuteNonQuery();
                }

                llenarDataGridView(Pest1_DataGriew_InformacionCliente);

                Con.cnx.Close();
            }

            MessageBox.Show("Cliente actualizado exitosamente");

        }

        public void CargarPorCodigo(DataGridView dgv, int a)
        {
            int busq;
            busq = a;

            Con.sql = string.Format(@"
select C.Codigo_Cliente as 'Codigo del Cliente', C.ID as 'Identidad', C.Nombre as Nombre, C.Apellido as Apellido, C.NumeroCelular as 'Numero de Celular',
C.TelefonoFijo as 'Telefono Fijo', C.Correo as Correo, C.Direccion as Direccion, C.Departamento as Departamento, C.Ciudad as Ciudad, C.RTN as RTN, (Select Descripcion_Estado from Estados where Codigo_Estado=C.Codigo_Estado and Descripcion_Estado like '%Cliente%') as Estado
,Emp.Codigo_Empresa as 'Codigo de Empresa', C.Codigo_Credito as 'Codigo de Credito', Emp.NombreEmpresa as 'Nombre de la empresa'
 from Clientes as C left join Empresas as Emp on C.Codigo_Empresa=Emp.Codigo_Empresa 
WHERE Codigo_Cliente like '%{0}%'", busq);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.cnx.Open();
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            dgv.DataSource = Con.dt;



            Con.cnx.Close();
        }

        public void CargarPorNombre(DataGridView dgv, string a)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                string busq;
                busq = a;

                con.sql = string.Format
                (@"select C.Codigo_Cliente as 'Codigo del Cliente', C.ID as 'Identidad', C.Nombre as Nombre, C.Apellido as Apellido, C.NumeroCelular as 'Numero de Celular',
C.TelefonoFijo as 'Telefono Fijo', C.Correo as Correo, C.Direccion as Direccion, C.Departamento as Departamento, C.Ciudad as Ciudad, C.RTN as RTN, (Select Descripcion_Estado from Estados where Codigo_Estado=C.Codigo_Estado and Descripcion_Estado like '%Cliente%') as Estado
,Emp.Codigo_Empresa as 'Codigo de Empresa', C.Codigo_Credito as 'Codigo de Credito', Emp.NombreEmpresa as 'Nombre de la empresa'
 from Clientes as C left join Empresas as Emp on C.Codigo_Empresa=Emp.Codigo_Empresa
WHERE Nombre like '%{0}%'", busq);
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

        public void LlenarFacturas(DataGridView dgv, int a, int b, int e)
        {
            int busq, Tip;
            busq = b;
            Tip = a;

            Con.sql = string.Format(@"
            select A.Cod_Factura as 'Codigo de Factura', Fecha_Factura as 'Fecha de Realizacion', Tip.Descripcion as 'Tipo de Transaccion' ,
            ('%' + CAST(( A.[Impuesto_Porcentaje]* 100) as nvarchar)) as Impuesto, (C.Nombre + ' '+ C.Apellido) as 'Nombre del Cliente', CAST(T.Monto as decimal(10,2)) as 'Monto Total' , 
            (select E.Descripcion_Estado from Estados as E where E.Codigo_Estado=T  .Codigo_Estado and E.Descripcion_Estado like '%Transaccion%') as 'Estado de Transaccion'
            from Facturas as A inner join Transacciones as T on A.Cod_Factura=T.Numero_Documento inner join Tipo_Transaccion as Tip on Tip.Codigo_TipoTransaccion=T.Codigo_Tipo_Transaccion inner join
            Clientes as C on T.Codigo_Cliente = C.Codigo_Cliente
            where T.Codigo_Tipo_Transaccion='{0}'  and C.Codigo_Cliente ='{1}' and T.Codigo_Estado='{2}'", Tip, busq, e);

            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.cnx.Open();
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            dgv.DataSource = Con.dt;



            Con.cnx.Close();


        }

        public void LlenarFacturasPagadas(DataGridView dgv, int a, int e)
        {
            int busq, Tip;
            busq = a;
            

            Con.sql = string.Format(@"
            select A.Cod_Factura as 'Codigo de Factura', Fecha_Factura as 'Fecha de Realizacion', Tip.Descripcion as 'Tipo de Transaccion' ,
            ('%' + CAST(( A.[Impuesto_Porcentaje]* 100) as nvarchar)) as Impuesto, (C.Nombre + ' '+ C.Apellido) as 'Nombre del Cliente', CAST(T.Monto as decimal(10,2)) as 'Monto Total' , 
            (select E.Descripcion_Estado from Estados as E where E.Codigo_Estado=T.Codigo_Estado and E.Descripcion_Estado like '%Transaccion%') as 'Estado de Transaccion'
            from Facturas as A inner join Transacciones as T on A.Cod_Factura=T.Numero_Documento inner join Tipo_Transaccion as Tip on Tip.Codigo_TipoTransaccion=T.Codigo_Tipo_Transaccion inner join
            Clientes as C on T.Codigo_Cliente = C.Codigo_Cliente
            where (T.Codigo_Tipo_Transaccion=2 or T.Codigo_Tipo_Transaccion=3)  and C.Codigo_Cliente ='{0}' and T.Codigo_Estado='{1}'", busq, e);

            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.cnx.Open();
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            dgv.DataSource = Con.dt;



            Con.cnx.Close();


        }


        public void LlenarFacturasC(DataGridView dgv, int a)
        {
            int busq;
            busq = a;

            Con.sql = string.Format(@"select B.Cod_Factura, B.Fecha_Factura, I.PorcentajeImpuesto, C.Nombre, a.Monto from Transacciones as a inner join Facturas as B on A.Numero_Documento = B.Cod_Factura
inner join Impuesto as I on B.Impuesto_Fecha = I.Fecha_Modificacion inner join Clientes as C on C.Codigo_Cliente = A.Codigo_Cliente
where a.Codigo_Tipo_Transaccion=1 and C.Codigo_Cliente = '{0}'", busq);

            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.cnx.Open();
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            dgv.DataSource = Con.dt;



            Con.cnx.Close();


        }
        public void selectFila(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.Pest1_DataGriew_InformacionCliente.Rows[e.RowIndex];
            
                Pest2_Text_Codigo.Text =Convert.ToString( row.Cells["Codigo del Cliente"].Value.ToString());
                Pest2_Text_ID.Text = Convert.ToString(row.Cells["Identidad"].Value.ToString());
                Pest2_Text_Nombre.Text = Convert.ToString( Convert.ToString(row.Cells["Nombre"].Value.ToString()) + " " + Convert.ToString(row.Cells["Apellido"].Value.ToString()));
               

                Pest3_Txtbx_CodigoCliente.Text = row.Cells["Codigo del Cliente"].Value.ToString();
                Pest3_Txtbx_ID.Text = row.Cells["Identidad"].Value.ToString();
                Pest3_Txtbx_NombreCliente.Text = row.Cells["Nombre"].Value.ToString();
                Pest3_Txtbx_Apellido.Text = row.Cells["Apellido"].Value.ToString();
                Pest3_Txtbx_NumeroCelular.Text = row.Cells["Numero de Celular"].Value.ToString();
                Pest3_Txtbx_TelefonoFijo.Text = row.Cells["Telefono Fijo"].Value.ToString();
                Pest3_Txtbx_Correo.Text = row.Cells["Correo"].Value.ToString();
                Pest3_Txtbx_Direccion.Text = row.Cells["Direccion"].Value.ToString();
                Pest3_Txtbx_Departamento.Text = row.Cells["Departamento"].Value.ToString();
                Pest3_Txtbx_Ciudad.Text = row.Cells["Ciudad"].Value.ToString();
                Pest3_Txtbx_RTN.Text = row.Cells["RTN"].Value.ToString();
                Pest3_Txtbx_CodigoEmpresa.Text = row.Cells["Codigo de Empresa"].Value.ToString();
                Pest3_Textbx_CodigoCredito.Text = row.Cells["Codigo de Credito"].Value.ToString();
                Pest3_Txtbx_NombreEmpresa.Text = row.Cells["Nombre de la empresa"].Value.ToString();



                string comp = row.Cells["Codigo de Credito"].Value.ToString();
                if (comp == "") {
                    ComprobarCredito(Convert.ToInt32(0));

                
                    Pest5_Txt_CodigoCredito.Text = cli.CodigoCreditoNuevo();
                } else { 

                 ComprobarCredito(Convert.ToInt32(row.Cells["Codigo de Credito"].Value.ToString()));

                    }
                ///Cuenta Credito
 
                Pest5_Txt_MontoCredito.Text = "0";
                textBox1.Text = "0";
                Pest5_Txt_CodigoCliente.Text=row.Cells["Codigo del Cliente"].Value.ToString();
                Pest5_Txt_ID.Text = row.Cells["Identidad"].Value.ToString();
                Pest5_Txt_Nombre.Text = row.Cells["Nombre"].Value.ToString();
                Pest5_Txt_CodigoCredito.Text= row.Cells["Codigo de Credito"].Value.ToString();

                
                ExtraerDatosCredito();

                if (Pest5_Txt_CodigoCredito.Text == "")
                {
                    Pest5_Txt_CodigoCredito.Text= cli.CodigoCreditoNuevo();
                }
                //comboBox2----ESTADOs
                cli.LlenarPersonasAutorizadas(dataGridView5, Convert.ToInt16(Pest5_Txt_CodigoCliente.Text));
                cli.LlenarPersonasCuentasBancarias(dataGridView4, Convert.ToInt16(Pest5_Txt_CodigoCliente.Text));

                cli.LlenarReferenciasBan(dataGridView6, Convert.ToInt16(Pest5_Txt_CodigoCliente.Text));
                cli.LlenarReferenciasPersonales(dataGridView7, Convert.ToInt16(Pest5_Txt_CodigoCliente.Text));






                LlenarFacturasPagadas(dataGridView2, Convert.ToInt16(Pest2_Text_Codigo.Text), 1);




                DataTable dt = new DataTable();
                Con.cnx.Open();
                SqlDataReader myReader = null;
                
                Con.sql = string.Format(@"SELECT c.*, emp.NombreEmpresa FROM Clientes c INNER JOIN Empresas emp ON(c.Codigo_Empresa = emp.Codigo_Empresa)
                                      where Codigo_Cliente = '{0}'", Convert.ToInt16(Pest3_Txtbx_CodigoCliente.Text));

                SqlCommand myCommand = new SqlCommand(Con.sql, Con.cnx);

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    Pest3_CmbBx_Estado.SelectedValue = ((myReader["Codigo_estado"].ToString()));
                }
                
                Con.cnx.Close();
                Verificar = false;
                MessageBox.Show("Listo");
            }
        }

        private void Pest1_DataGriew_InformacionCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectFila(e);
        }

        private void Pest1_Radio_Codigo_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest1_Radio_Codigo.Checked == true)
            {
                Pest1_Radio_Codigo.Checked = true;
                Pest1_Txtbx_Codigo.Enabled = true;
                Pest1_Txtbx_NombreCliente.Text = string.Empty;
                Pest1_Txtbx_NombreCliente.Focus();
            }
            else
            {
                Pest1_Radio_Codigo.Checked = false;
                Pest1_Txtbx_Codigo.Enabled = false;
            }
        }

        private void Pest1_Radio_NombreCliente_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Pest1_Radio_NombreCliente.Checked == true)
            {
                Pest1_Radio_NombreCliente.Checked = true;
                Pest1_Txtbx_NombreCliente.Enabled = true;
                Pest1_Txtbx_Codigo.Text = string.Empty;

            }
            else
            {
                Pest1_Radio_NombreCliente.Checked = false;
                Pest1_Txtbx_NombreCliente.Enabled = false;
            }
        }

        private void Pest1_Radio_TodosContactos_CheckedChanged_1(object sender, EventArgs e)
        {

            if (Pest1_Radio_TodosContactos.Checked == true)
            {
                Pest1_Txtbx_Codigo.Text = string.Empty;
                Pest1_Txtbx_NombreCliente.Text = string.Empty;
                llenarDataGridView(Pest1_DataGriew_InformacionCliente);
            }
            else
            {
                Pest1_Radio_TodosContactos.Checked = false;

            }
        }

        private void Pest1_Btn_Limpiar_Click_1(object sender, EventArgs e)
        {
            Pest1_Txtbx_Codigo.Text = String.Empty;
            Pest1_Txtbx_NombreCliente.Text = String.Empty;
            llenarDataGridView(Pest1_DataGriew_InformacionCliente);
        }

        private void Pest1_DataGriew_InformacionCliente_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pest1_Txtbx_Codigo_TextChanged_1(object sender, EventArgs e)
        {
            int a;
            if (Pest1_Txtbx_Codigo.Text != string.Empty)
            {
                a = Convert.ToInt32(Pest1_Txtbx_Codigo.Text);
                CargarPorCodigo(Pest1_DataGriew_InformacionCliente, a);
            }
            else
            {
                llenarDataGridView(Pest1_DataGriew_InformacionCliente);
            }

        }

        private void Pest1_Txtbx_NombreCliente_TextChanged_1(object sender, EventArgs e)
        {
            buscarNombreCliente();
        }

        private void Pest1_Txtbx_Codigo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validar.ValidarID(sender,e);
        }

        private void Pest1_Txtbx_NombreCliente_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validar.ValidarNombres_SoloLetras(sender, e);
        }

        private void Pest3_Btn_Aceptar_Click_1(object sender, EventArgs e)
        {
            if (Pest3_Txtbx_NumeroCelular.Text == String.Empty
            || Pest3_Txtbx_TelefonoFijo.Text == String.Empty
            || Pest3_Txtbx_Correo.Text == String.Empty
            || Pest3_Txtbx_Direccion.Text == String.Empty
            || Pest3_Txtbx_Departamento.Text == String.Empty
            || Pest3_Txtbx_Ciudad.Text == String.Empty
            || Pest3_CmbBx_Estado.SelectedIndex == -1)
            {
                MessageBox.Show("No es permitido dejar campo vacio", "ERROR");
            }
            else { actualizarCliente(); llenarDataGridView(Pest1_DataGriew_InformacionCliente); }

            llenarDataGridView(Pest1_DataGriew_InformacionCliente);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


     

        }

        public void LlenarDetalles(DataGridView dgv, int a)
        {
            int busq;
            busq = a;

            Con.sql = string.Format(@"select B.NombreProducto as 'Nombre del Producto', B.Descripcion as 'Descripcion del Producto',D.Descripcion as 'Marca',  C.Descripcion as 'Modelo' ,
CAST(A.PrecioVenta as decimal(10,2)) as 'Precio de Venta' , A.CantidadVenta as 'Cantidad'   from [Detalles|Factura] as A inner join Producto as B on A.Codigo_Producto=B.Cod_Producto 
inner join Modelo as C on B.Cod_Modelo=C.Cod_Modelo inner join Marca as D on C.Cod_Marca=D.Cod_Marca
where A.Codigo_Factura = '{0}'", busq);

            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.cnx.Open();
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            dgv.DataSource = Con.dt;



            Con.cnx.Close();


        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest2_Radio_Credito.Checked == true)
            {
                Pest2_Radio_Pagado.Enabled = true;
                Pest2_Radio_Pendiente.Enabled = true;
                Pest2_Radio_Mora.Enabled = true;
            }
            else
            {
                Pest2_Radio_Pagado.Checked = true;
                Pest2_Radio_Pendiente.Enabled = false;
                Pest2_Radio_Mora.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(Pest2_Text_Codigo.Text))
            {
                MessageBox.Show("Debe selecionar un cliente en la pestaña de busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Pest1_DataGriew_InformacionCliente.Focus();
                return;
            }

            if (Pest2_Radio_Contado.Checked == true)
            {

                if (Pest2_Radio_Pagado.Checked == true) {

                    LlenarFacturasPagadas(dataGridView2, Convert.ToInt16(Pest2_Text_Codigo.Text), 1);
                }
                else
                if (Pest2_Radio_Anuladas.Checked==true) {

                    LlenarFacturasPagadas(dataGridView2, Convert.ToInt16(Pest2_Text_Codigo.Text), 3);
                }
            }
            else
            {
                if (Pest2_Radio_Mora.Checked == true)
                {

                    LlenarFacturas(dataGridView2, 1, Convert.ToInt16(Pest2_Text_Codigo.Text),4 );

                }
                else
                if (Pest2_Radio_Pagado.Checked==true)
                {
                    LlenarFacturas(dataGridView2, 1, Convert.ToInt16(Pest2_Text_Codigo.Text), 1);
                }
                else if(Pest2_Radio_Pendiente.Checked==true)
                {
                    LlenarFacturas(dataGridView2, 1, Convert.ToInt16(Pest2_Text_Codigo.Text), 2);
                }
                else//Anuladas
                {
                    LlenarFacturas(dataGridView2, 1, Convert.ToInt16(Pest2_Text_Codigo.Text), 3);
                }
            }
        }

        private void Pest2_Radio_Contado_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest2_Radio_Contado.Checked == true)
            {
                Pest2_Radio_Pagado.Checked = true;
                Pest2_Radio_Anuladas.Enabled = true;
                Pest2_Radio_Pagado.Enabled = true;
                Pest2_Radio_Mora.Enabled = false;
                Pest2_Radio_Pendiente.Enabled = false;
            }
            else
            {

            }
           
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Pest2_Radio_Pendiente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Pest2_Radio_Pagado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Pest2_Radio_Todos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string Bus;
            Bus = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            LlenarDetalles(dataGridView3, (int) Convert.ToDouble(Bus));
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Pest3_Txtbx_NumeroCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.NumerosReales_NegativosOPositivos(sender, e, Pest3_Txtbx_NumeroCelular);
        }

        private void Pest3_Txtbx_TelefonoFijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.NumerosReales_NegativosOPositivos(sender, e, Pest3_Txtbx_TelefonoFijo);
        }

        private void Pest3_Txtbx_Correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarCorreoIngreso(sender, e, Pest3_Txtbx_Correo);
        }

        private void Pest3_Txtbx_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValirLetrasYEspacios_Direccion(sender, e, Pest3_Txtbx_Direccion);
        }

        private void Pest3_Txtbx_Departamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValirLetrasYEspacios(sender, e, Pest3_Txtbx_Departamento);
        }

        private void Pest3_Txtbx_Ciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValirLetrasYEspacios(sender, e, Pest3_Txtbx_Ciudad);
        }

        private void Pest3_Txtbx_NumeroCelular_TextChanged(object sender, EventArgs e)
        {
            Verificar = true;
        }

        private void Pest3_Txtbx_TelefonoFijo_TextChanged(object sender, EventArgs e)
        {
            Verificar = true;
        }

        private void Pest3_Txtbx_Correo_TextChanged(object sender, EventArgs e)
        {
            Verificar = true;
        }

        private void Pest3_Txtbx_Direccion_TextChanged(object sender, EventArgs e)
        {
            Verificar = true;
        }

        private void Pest3_Txtbx_Departamento_TextChanged(object sender, EventArgs e)
        {
            Verificar = true;
        }

        private void Pest3_Txtbx_Ciudad_TextChanged(object sender, EventArgs e)
        {
            Verificar = true;
        }


          ///////////////////////////////////////////////////////////////////////////////////////
         ///////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////
       //APERTURAS DE CUENTAS A CREDITOS

        public void ComprobarCredito(int a)
        {
            if (a == 0)
            {
                Pest5_Label_Presentacion.Text= "Apertura de\nNueva cuenta";
                button13.Text = "Realizar Apertura";
                NewCuentaCredito = true;
                tabControl2.Enabled = false;               
                Pest5_Estados.SelectedValue = 1;
                Pest5_Estados.Enabled = false;

               
            }
            else
            {
                Pest5_Label_Presentacion.Text = "Modificacion de\nCuenta a Credito";
                Pest5_Txt_CodigoCredito.Text = Convert.ToString(a);
                button13.Text = "Realizar Modificacion";
                ExtraerDatosCredito();
                NewCuentaCredito = false;
                Pest5_Estados.Enabled = true;
                tabControl2.Enabled = true;
                ExtraerDatosCredito();
            }
        }

        private void groupBox15_Enter(object sender, EventArgs e)
        {

        }

        public void ExtraerDatosCredito()
        {
            int Codigo = Convert.ToInt16(Pest5_Txt_CodigoCliente.Text);
            Conexion Cn = new Conexion();
            Cn.sql = string.Format(@"select C.Monto_Credito as Monto, 
                        C.Saldo_Actual as Saldo, C.Codigo_Estado as Estado from Creditos as C inner join Clientes as B on
                       C.Codigo_Credito=B.[Codigo_Credito] where B.Codigo_Cliente='{0}'", Codigo);
            Cn.cmd = new SqlCommand(Cn.sql, Cn.cnx);
            Cn.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Cn.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Pest5_Txt_MontoCredito.Text = (Reg["Monto"].ToString());
                textBox1.Text = (Reg["Saldo"].ToString());
                Pest5_Estados.SelectedValue=(Convert.ToInt32((Reg["Estado"].ToString())));

                Din = Convert.ToDouble((Reg["Monto"].ToString()));
                Don= Convert.ToDouble((Reg["Saldo"].ToString()));
            }
            else
            {

            }

        }

        private void Pest5_Txt_MontoCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.NumerosDecimales(sender, e, Pest5_Txt_MontoCredito);
        }
                
        private void Pest5_Txt_MontoCredito_TextChanged(object sender, EventArgs e)
        {
            if (Pest5_Txt_MontoCredito.Text == "")
            {
                Pest5_Txt_MontoCredito.Text = "0";
            }
            if (NewCuentaCredito == true)
            {
                textBox1.Text = Pest5_Txt_MontoCredito.Text;
            }
            else
            {
               
                double ahora;
                                
                ahora= Convert.ToDouble(Pest5_Txt_MontoCredito.Text)-Din;
                textBox1.Text = Convert.ToString(ahora + Don);
                
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Pest5_Txt_CodigoCliente.Text=="0")
            {
                errorProvider1.SetError(Pest5_Txt_CodigoCliente, "Debe llenar este campo");
                return;
            }
            else
            {
                errorProvider1.SetError(Pest5_Txt_CodigoCliente, "");
            }


            if (NewCuentaCredito == true)
            {
                bool NewCuenta;

                if (Pest5_Txt_MontoCredito.Text == string.Empty || Pest5_Txt_MontoCredito.Text == "0")
                {
                    errorProvider1.SetError(Pest5_Txt_MontoCredito, "Debe llenar este campo");
                    return;
                }
                else
                {
                    errorProvider1.SetError(Pest5_Txt_MontoCredito, "");
                }



                float Mon = (float)Convert.ToDouble(Pest5_Txt_MontoCredito.Text);
                float Sal = (float)Convert.ToDouble(textBox1.Text);
                NewCuenta = cli.AgregarCuenta(Mon, Sal, Convert.ToInt32(Pest5_Txt_CodigoCliente.Text));


                if (NewCuentaCredito == true)
                {
                    ComprobarCredito(Convert.ToInt16(Pest5_Txt_CodigoCredito.Text));
                    NewCuentaCredito = false;
                    tabControl2.Enabled = true;
                    ExtraerDatosCredito();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error en cuanto a la ejecucion, pro favir intentelo mas tarde");
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(Pest5_Txt_MontoCredito.Text) || Pest5_Txt_MontoCredito.Text == "0")
                {
                    errorProvider1.SetError(Pest5_Txt_MontoCredito, "Debe llenar este campo");
                    return;
                }
                else
                {
                    errorProvider1.SetError(Pest5_Txt_MontoCredito, "");
                }


                if (Convert.ToDouble(textBox1.Text)<0)
                {
                    errorProvider1.SetError(Pest5_Txt_MontoCredito, "Debe llenar este campo");
                    return;
                }
                else
                {
                    errorProvider1.SetError(Pest5_Txt_MontoCredito, "");
                }



                int Estad = Convert.ToInt16(Pest5_Estados.SelectedValue);
                float Mon = (float)Convert.ToDouble(Pest5_Txt_MontoCredito.Text);
                float Sal = (float)Convert.ToDouble(textBox1.Text);

                cli.ModificarCuenta(Mon, Sal, Estad,Convert.ToInt32(Pest5_Txt_CodigoCredito.Text));
            }
            llenarDataGridView(Pest1_DataGriew_InformacionCliente);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Pest5_Pest1_Txt_Nombre.Text)) {
                errorProvider1.SetError(Pest5_Pest1_Txt_Nombre, "Please fill the required field");
                return;
            }
            else { errorProvider1.SetError(Pest5_Pest1_Txt_Nombre, ""); }

            if (string.IsNullOrWhiteSpace(Pest5_Pest1_Txt_Tipo.Text)) {
                errorProvider1.SetError(Pest5_Pest1_Txt_Tipo, "Please fill the required field");
                return;
            }
            else { errorProvider1.SetError(Pest5_Pest1_Txt_Tipo, ""); }

            cli.VerificarCuentas(Pest5_Pest1_Txt_Nombre.Text, Pest5_Pest1_Txt_Tipo.Text, Convert.ToInt32(Pest5_Txt_CodigoCliente.Text));
            cli.LlenarPersonasCuentasBancarias(dataGridView4, Convert.ToInt16(Pest5_Txt_CodigoCliente.Text));

            Pest5_Pest1_Txt_Nombre.Text = String.Empty;
            Pest5_Pest1_Txt_Tipo.Text = String.Empty;
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            bool Resp=false;

            var boxesxx = groupBox12.Controls.OfType<TextBox>();
            foreach (var box in boxesxx)
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    errorProvider1.SetError(box, "Campo Requerido");
                    Resp = true;
                }
                else
                {
                    errorProvider1.SetError(box, "");
                }

            }

            if (Pest5_Pest2_Combo_Estado.SelectedIndex==-1) {
                errorProvider1.SetError(Pest5_Pest2_Combo_Estado, "Campo Requerido");
                Resp = true;
            }
            else
            {
                errorProvider1.SetError(Pest5_Pest2_Combo_Estado, "");
            }                 
                

            if (Resp == true)
            {
                return;
            }


            if (Pest5_Pest2_Check_NuevaPersona.Checked == true)
            {
                cli.VerificarReferencias(Convert.ToInt32(Pest5_Txt_CodigoCliente.Text), Pest5_Pest2_Txt_ID.Text, Pest5_Pest2_Txt_Nombre.Text, Pest5_Pest2_Txt_Apellido.Text, Pest5_Pest2_Txt_Telefono.Text, Convert.ToInt32(Pest5_Pest2_Combo_Estado.SelectedValue), 1);               
                Pest5_Pest2_Txt_Codigo.Text = Convert.ToString(cli.NuevoPersonaAutorizada());
            }
            else
            {
                int est=Convert.ToInt32( Pest5_Pest2_Combo_Estado.SelectedValue);

                 cli.Actualizar_VerificarReferencias(Convert.ToInt32(Pest5_Pest2_Txt_Codigo.Text), Convert.ToString(Pest5_Pest2_Txt_Telefono.Text), est)
                ; Pest5_Pest2_Txt_Codigo.Text = "";
            }

            cli.LlenarPersonasAutorizadas(dataGridView5, Convert.ToInt16(Pest5_Txt_CodigoCliente.Text));
            Pest5_Pest2_Txt_ID.Text = string.Empty;
            Pest5_Pest2_Txt_Nombre.Text = string.Empty;
            Pest5_Pest2_Txt_Apellido.Text = string.Empty;
            Pest5_Pest2_Txt_Telefono.Text = string.Empty;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bool valid=false;
           
            if (string.IsNullOrWhiteSpace(Pest5_Pest3_Txt_Telefono.Text)) {
                errorProvider1.SetError(Pest5_Pest3_Txt_Telefono, "Please fill the required field");
                valid = true;
            } else {
                errorProvider1.SetError(Pest5_Pest3_Txt_Telefono, "");
            }
            if (string.IsNullOrWhiteSpace(Pest5_Pest3_Nombre.Text)) {
                errorProvider1.SetError(Pest5_Pest3_Nombre, "Please fill the required field");
                valid = true;
            } else {
                errorProvider1.SetError(Pest5_Pest3_Nombre, "");
            }
            if (string.IsNullOrWhiteSpace(Pest5_Pest3_Txt_Direccion.Text)) {
                errorProvider1.SetError(Pest5_Pest3_Txt_Direccion, "Please fill the required field");
                valid = true;
            } else {
                errorProvider1.SetError(Pest5_Pest3_Txt_Direccion, "");
            }
            if (valid == true)
            {
                return;
            }

            cli.VerificarReferencias(1, Pest5_Pest3_Txt_Telefono.Text, Pest5_Pest3_Nombre.Text, Pest5_Pest3_Txt_Direccion.Text, Convert.ToInt32(Pest5_Txt_CodigoCliente.Text));
            cli.LlenarReferenciasBan(dataGridView6, Convert.ToInt16(Pest5_Txt_CodigoCliente.Text));
            Pest5_Pest3_Txt_Telefono.Text = string.Empty;
            Pest5_Pest3_Nombre.Text = string.Empty;
            Pest5_Pest3_Txt_Direccion.Text = string.Empty;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {//VerificarReferencias(int tipo1, string Telefono1, string Nombr1, string Dir1, int Co1)
            bool valid = false;
                       
            if(string.IsNullOrWhiteSpace(Pest5_Pest4_Txt_Telefono.Text))
            {
                errorProvider1.SetError(Pest5_Pest4_Txt_Telefono, "Please fill the required field");
                valid = true;
            }
            else
            {
                errorProvider1.SetError(Pest5_Pest4_Txt_Telefono, "");
            }


            if (string.IsNullOrWhiteSpace(Pest5_Pest4_Txt_Nombre.Text))
            {
                errorProvider1.SetError(Pest5_Pest4_Txt_Nombre, "Please fill the required field");
                valid = true;
            }
            else
            {
                errorProvider1.SetError(Pest5_Pest4_Txt_Nombre, "");
            }


            if (string.IsNullOrWhiteSpace(Pest5_Pest4_Txt_Direccion.Text))
            {
                errorProvider1.SetError(Pest5_Pest4_Txt_Direccion, "Please fill the required field");
                valid = true;
            }
            else
            {
                errorProvider1.SetError(Pest5_Pest4_Txt_Direccion, "");
            }
            if (valid == true)
            {
                return;
            }


            cli.VerificarReferencias(2, Pest5_Pest4_Txt_Telefono.Text, Pest5_Pest4_Txt_Nombre.Text, Pest5_Pest4_Txt_Direccion.Text, Convert.ToInt32(Pest5_Txt_CodigoCliente.Text));
            cli.LlenarReferenciasPersonales(dataGridView7, Convert.ToInt16(Pest5_Txt_CodigoCliente.Text));
            Pest5_Pest4_Txt_Telefono.Text = string.Empty;
            Pest5_Pest4_Txt_Nombre.Text = string.Empty;
            Pest5_Pest4_Txt_Direccion.Text = string.Empty;
        }

        private void Pest5_Txt_CodigoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void textBox43_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValirLetrasYEspacios(sender, e, Pest5_Pest1_Txt_Nombre);
            //7val.PrimeroMayuscula(sender, e, textBox43);
        }

        private void textBox42_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValirLetrasYEspacios(sender, e, Pest5_Pest1_Txt_Tipo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pest5_Pest1_Txt_Nombre.Text = String.Empty;
            Pest5_Pest1_Txt_Tipo.Text = String.Empty;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Pest5_Pest3_Txt_Telefono.Text = string.Empty;
            Pest5_Pest3_Nombre.Text = string.Empty;
            Pest5_Pest3_Txt_Direccion.Text = string.Empty;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pest5_Pest4_Txt_Telefono.Text = string.Empty;
            Pest5_Pest4_Txt_Nombre.Text = string.Empty;
            Pest5_Pest4_Txt_Direccion.Text = string.Empty;
        }

        private void radioButton1_CheckedChanged_2(object sender, EventArgs e)
        {
            if (Pest5_Pest2_Check_NuevaPersona.Checked == true)
            {
                Pest5_Pest2_Txt_Codigo.Text= Convert.ToString(cli.NuevoPersonaAutorizada());
                 Pest5_Pest2_Txt_ID.Enabled = true;
                    Pest5_Pest2_Txt_Nombre.Enabled = true;
                    Pest5_Pest2_Txt_Apellido.Enabled = true;
                
            }
            else
            {
                Pest5_Pest2_Txt_Codigo.Text = "";
            }
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pest5_Pest2_Txt_ID.Text = string.Empty;
            Pest5_Pest2_Txt_Nombre.Text = string.Empty;
            Pest5_Pest2_Txt_Apellido.Text = string.Empty;
            Pest5_Pest2_Txt_Telefono.Text = string.Empty;
            Pest5_Pest2_Txt_Codigo.Text = Convert.ToString(cli.NuevoPersonaAutorizada());
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest5_Pest2_Check_ManejoPersona.Checked==true) {
                Pest5_Pest2_Txt_ID.Enabled = false;
                Pest5_Pest2_Txt_Nombre.Enabled = false;
                Pest5_Pest2_Txt_Apellido.Enabled = false;
            }

        }

        private void dataGridView5_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        { Pest5_Pest2_Check_ManejoPersona.Checked = true;
            Pest5_Pest2_Txt_ID.Text = dataGridView5.CurrentRow.Cells[1].Value.ToString();//ID
            Pest5_Pest2_Txt_Nombre.Text = dataGridView5.CurrentRow.Cells[2].Value.ToString();//NOM
            Pest5_Pest2_Txt_Apellido.Text = dataGridView5.CurrentRow.Cells[3].Value.ToString();//APP
            Pest5_Pest2_Txt_Telefono.Text = dataGridView5.CurrentRow.Cells[4].Value.ToString();//TELE
            Pest5_Pest2_Txt_Codigo.Text = dataGridView5.CurrentRow.Cells[0].Value.ToString();
            Pest5_Pest2_Combo_Estado.SelectedValue = cli.OptenerEstados(dataGridView5.CurrentRow.Cells[5].Value.ToString());
             }

        private void textBox49_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValirLetrasYEspacios(sender, e, Pest5_Pest4_Txt_Nombre);
          
        }

        private void textBox45_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValirLetrasYEspacios_Direccion(sender, e, Pest5_Pest4_Txt_Direccion);
       
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.NumerosReales_NegativosOPositivos(sender, e, Pest5_Pest4_Txt_Telefono);
        }

        private void textBox41_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.NumerosReales_NegativosOPositivos(sender, e, Pest5_Pest3_Txt_Telefono);
        }

        private void textBox46_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValirLetrasYEspacios(sender,e, Pest5_Pest3_Nombre);
           
        }

        private void textBox40_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValirLetrasYEspacios_Direccion(sender, e, Pest5_Pest3_Txt_Direccion);
          
        }

        private void textBox39_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarID(sender, e);
        }

        private void textBox35_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.NumerosReales_NegativosOPositivos(sender, e, Pest5_Pest2_Txt_Telefono);
        }

        private void textBox36_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValirLetrasYEspacios(sender, e, Pest5_Pest2_Txt_Nombre);
     
        }

        private void textBox38_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValirLetrasYEspacios(sender, e, Pest5_Pest2_Txt_Apellido);
           
        }

        private void Bttn_Ayuda_Click(object sender, EventArgs e)
        {
            Form_VistaManualPDF Manual = new Form_VistaManualPDF();
            Manual.PDF_Local.src = (Application.StartupPath + @"\ManualesHTML\ManualesPantalla\Manual Pantalla de Clientes.pdf");
            Manual.ShowDialog();
        }

        private void Pest5_Txt_Nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

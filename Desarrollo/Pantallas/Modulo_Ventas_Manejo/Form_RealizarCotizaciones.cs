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

namespace Desarrollo.Pantallas.Modulo_Ventas_Manejo
{
    public partial class Form_RealizarCotizaciones : System.Windows.Forms.Form
    {
        public string Cot_NombreEmpleado="";
        double Total;
        Conexion Con = new Conexion();
        Validaciones Val = new Validaciones();
        string NombreProducto;
        string NombreCliente;

        public Form_RealizarCotizaciones()
        {
            InitializeComponent();
        }

        private void Form_RealizarCotizaciones_Load(object sender, EventArgs e)
        {
            Txt_NombreEmpleado.Text = Cot_NombreEmpleado;

            var blankContextMenu = new ContextMenuStrip();
            txt_Nombre1.ContextMenuStrip = blankContextMenu;
            txt_Nombre2.ContextMenuStrip = blankContextMenu;
            Txt_Cantidad.ContextMenuStrip = blankContextMenu;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        ////LLENADO DE LOS DATOS*********************************************************

        private void FiltroClienteEmpresa(string NombreEmpresa)
        {
            if (NombreEmpresa == string.Empty)
            {
                NombreEmpresa = "a";
            }


            Con.cnx.Open();
            Con.sql = string.Format(@"select Codigo_Empresa, NombreEmpresa from Empresas where NombreEmpresa like '%{0}%' ", NombreEmpresa);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();


            cmb_Nombre.ValueMember = "Codigo_Empresa";
            cmb_Nombre.DisplayMember = "NombreEmpresa";
            cmb_Nombre.DataSource = Con.dt;
            Con.cnx.Close();
        }

        private void FiltroClienteNormal(string NombreCliente)
        {
            if (NombreCliente == string.Empty)
            {
                NombreCliente = "a";
            }
            Con.cnx.Open();
            

            Con.sql = string.Format(@"select Codigo_Cliente,(Nombre + ' ' + Apellido) as Nombre from Clientes where Nombre like '%{0}%'", NombreCliente);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();


            cmb_Nombre.ValueMember = "Codigo_Cliente";
            cmb_Nombre.DisplayMember = "Nombre";
            cmb_Nombre.DataSource = Con.dt;
            Con.cnx.Close();
        }

        private void txt_Nombre1_TextChanged(object sender, EventArgs e)
        {
            cmb_Nombre.DataSource = null;
            cmb_Nombre.Items.Clear();

            if (Check_RepresentarEmpresa.Checked==true)
            {
                FiltroClienteEmpresa(txt_Nombre1.Text);
            } else
            {
                FiltroClienteNormal(txt_Nombre1.Text);
            }
        }


        private void FiltroProducto(string NombreProducto)
        {
            if (NombreProducto == string.Empty)
            {
                NombreProducto = "a";
            }
            Con.cnx.Open();


            Con.sql = string.Format(@"select Cod_Producto, NombreProducto from Producto where NombreProducto like '%{0}%'", NombreProducto);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();


            ComBox_DescripcionProducto.ValueMember = "Cod_Producto";
            ComBox_DescripcionProducto.DisplayMember = "NombreProducto";
            ComBox_DescripcionProducto.DataSource = Con.dt;
        
        }

        private void txt_Nombre2_TextChanged(object sender, EventArgs e)
        {
            FiltroProducto(txt_Nombre2.Text);
        }

        private void AgregarProductos(int a)
        {
            
            Con.sql = string.Format(@"
            select A.NombreProducto as Nombre, A.PrecioVenta as Precio, 
            B.Descripcion as Modelo, C.Descripcion as Marca from Producto As A inner Join Modelo as B
            on A.Cod_Modelo=B.Cod_Modelo inner join Marca as C on C.Cod_Marca=B.Cod_Marca
            where A.Cod_Producto='{0}'", a);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Con.cmd.ExecuteReader();

            if (Reg.Read())
            {
                
                NombreProducto =(Reg["Nombre"].ToString());
                Text_Marca.Text = (Reg["Marca"].ToString());
                Text_Modelo.Text = (Reg["Modelo"].ToString());
                Text_Precio.Text = (Reg["Precio"].ToString());
                Con.cnx.Close();
            }
            else
            {
                Con.cnx.Close();
            }

            
        }

        private void ComBox_DescripcionProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            AgregarProductos(Convert.ToInt32(ComBox_DescripcionProducto.SelectedValue));
           
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            bool verif=false;
            double TotalPorP=0;
            

            if (ComBox_DescripcionProducto.SelectedIndex == -1)
            {
                errorProvider1.SetError(ComBox_DescripcionProducto, "Debe selecionar un producto");
                return;
            }
            else
            {
                errorProvider1.SetError(ComBox_DescripcionProducto, "");
            }

            if (string.IsNullOrWhiteSpace(Txt_Cantidad.Text) || Convert.ToUInt32(Txt_Cantidad.Text)<=0)
            {
                errorProvider1.SetError(Txt_Cantidad, "Debe Ingresar una Cantidad mayor de 0");
                return;
            }
            else
            {
                errorProvider1.SetError(Txt_Cantidad,"");
            }

            


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToString((string)this.dataGridView1.Rows[i].Cells[0].Value) == NombreProducto) {
                    verif = true; }                                                 
            }


            if (verif == true)
            {
                MessageBox.Show("Un producto solo puede ser agregado una sola vez");
                return;
            }

            Total = Total + (Convert.ToDouble(Text_Precio.Text) * Convert.ToUInt32(Txt_Cantidad.Text));
            TotalPorP = Convert.ToDouble(Total);

            dataGridView1.Rows.Insert(0,NombreProducto, Text_Marca.Text,  
                Text_Modelo.Text , Text_Precio.Text, Txt_Cantidad.Text, Convert.ToString(TotalPorP));
            label2.Text = Convert.ToString(Total);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
                     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double Resta;
            Resta=Convert.ToDouble(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            Total = Total - Resta;
            label2.Text = Convert.ToString(Total);
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            

            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Debe agregar algun Producto","",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmb_Nombre.SelectedIndex == -1)
            {
                NombreCliente = "Desconocido";
            }
            else
            {
                if (Check_RepresentarEmpresa.Checked==true) {
                    ClienteEmpresa(Convert.ToInt32(cmb_Nombre.SelectedValue));
                }
                else
                {
                    ClienteNormal(Convert.ToInt32(cmb_Nombre.SelectedValue));
                }
            }

            


            Cotizacion_Impresion_Forma Coti = new Cotizacion_Impresion_Forma();
            Coti.NomCliente= NombreCliente;
            Coti.NomEmpleado= Txt_NombreEmpleado.Text;
            Coti.FechaRealizacion= Date_Fecha.Text;
            Coti.Total = label2.Text;
            Coti.FechaFinal = dateTimePicker1.Text;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Cotizaccion_LlenadoDeDataGriew Cot = new Cotizaccion_LlenadoDeDataGriew();
                
                Cot.Descripcion = Convert.ToString("Producto: " + (string)this.dataGridView1.Rows[i].Cells[0].Value + 
                                                  "\nDe Marca: " + (string)this.dataGridView1.Rows[i].Cells[1].Value + 
                                                  "\nDe Modelo: " + (string)this.dataGridView1.Rows[i].Cells[2].Value +
                                                  "\nCantidad: " + (string)this.dataGridView1.Rows[i].Cells[4].Value);  

                Cot.Precio = Convert.ToString("L. " + Convert.ToString(this.dataGridView1.Rows[i].Cells[5].Value));
                Coti.Datos.Add(Cot);
            }
             Coti.ShowDialog();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            label2.Text = "0";
            txt_Nombre2.Text = string.Empty;

        }

        private void btn_DescartarProducto_Click(object sender, EventArgs e)
        {
            int Var_renglonesSeleccionados = dataGridView1.SelectedRows.Count;
            int Var_cuadrosselecionados = dataGridView1.SelectedCells.Count;

            if (Var_renglonesSeleccionados == 0 && Var_cuadrosselecionados == 0)
            {
                MessageBox.Show("Tienes que seleccionar por lo menos una fila.");
                return;
            }

            double Resta;
            Resta = Convert.ToDouble(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            Total = Total - Resta;
            label2.Text = Convert.ToString(Total);
        }


        public void ClienteNormal(int a)
        {
            Con.sql = string.Format(@" select (Nombre + ' ' + Apellido) 
            as Nombre from Clientes where Codigo_Cliente='{0}'", a);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Con.cmd.ExecuteReader();

            if (Reg.Read())
            {

                NombreCliente = (Reg["Nombre"].ToString());
            }
            else
            {

            }
        }

        public void ClienteEmpresa(int a)
        {
            Con.sql = string.Format(@"select NombreEmpresa from Empresas where Codigo_Empresa='{0}'", a);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Con.cmd.ExecuteReader();

            if (Reg.Read())
            {

                NombreCliente = (Reg["NombreEmpresa"].ToString());
         
            }
            else
            {

            }

        }

        private void txt_Nombre1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios(sender, e, txt_Nombre1);
        }

        private void txt_Nombre2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_LetrasYNumeros(sender, e);
        }

        private void Txt_Cantidad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarID(sender, e);
        }
    }



}

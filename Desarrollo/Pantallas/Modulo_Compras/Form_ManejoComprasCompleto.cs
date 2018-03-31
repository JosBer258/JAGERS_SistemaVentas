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

namespace Desarrollo.Pantallas.Modulo_Compras
{
    public partial class Form_ManejoComprasCompleto : System.Windows.Forms.Form
    {
        public string NombreEmpleado;
        public string Codigo;
        Desarrollo.Clases.Validaciones Val = new Clases.Validaciones();
        Desarrollo.Clases.C_Compras Comp = new Clases.C_Compras();
        Conexion Con = new Conexion();

        //Variables
        string NombreProducto;
        string NombreLocalidad;
        double PrecioProducto;
        public string CodLocalidad;

        public Form_ManejoComprasCompleto()
        {
            InitializeComponent();
        }

        private void Pest1_ComBo_InforProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_ManejoComprasCompleto_Load(object sender, EventArgs e)
        {
            Pest1_Txt_Empleado.Text = NombreEmpleado;
            Pest1_Txt_cod_compra.Text = Convert.ToString(Comp.CodigoNuevoCompra());
            dateTimePicker3.Enabled = false;
            dateTimePicker2.Enabled = false;
            Comp.Llenar_DataGriewIncial(Pest2_dataGridView_Facturas);
            Pest2_radio_ModoGlobal.Checked = true;

            //Validar para evitar Control de Clic Derecho
            var blankContextMenu = new ContextMenuStrip();
            Pest1_Txt_Cantidad.ContextMenuStrip = blankContextMenu;
            Pest1_Txt_PrecioCompra.ContextMenuStrip = blankContextMenu;
            Pes1_Txt_Nombre.ContextMenuStrip = blankContextMenu;
            Pest1_Txt_FilroProveedor.ContextMenuStrip = blankContextMenu;
            Pest2_Text_NombreProveedor.ContextMenuStrip = blankContextMenu;
            Pest2_Txt_CodigoCompra.ContextMenuStrip = blankContextMenu;


            Pest2_Text_NombreProveedor.Enabled = false;
            Pest2_Txt_CodigoCompra.Enabled = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pest1_Txt_FilroProveedor_TextChanged(object sender, EventArgs e)
        {
            Comp.FiltroBusquedaProveedor(Pest1_ComBo_InforProveedor, Pest1_Txt_FilroProveedor.Text);
        }

        private void Pes1_Txt_Nombre_TextChanged(object sender, EventArgs e)
        {
            Comp.FiltroBusquedaProductos(Pest1_ComBo_Descripcion, Pes1_Txt_Nombre.Text);
        }

        private void Pest1_ComBo_Descripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Comp.ExtraccionIformacionProductos(comboBox1, Convert.ToString(Pest1_ComBo_Descripcion.SelectedValue));
        }

        private void Pest1_Bttn_Agregar_Click(object sender, EventArgs e)
        {
            bool verif = false;
            bool Verfi2 = false;

            Fun_ExtraerLocalidadProducto(Convert.ToInt32(Pest1_ComBo_Descripcion.SelectedValue), Convert.ToInt32(comboBox1.SelectedValue));

            if (string.IsNullOrWhiteSpace(Pest1_Txt_PrecioCompra.Text))
            { errorProvider1.SetError(Pest1_Txt_PrecioCompra, "Debe ingresar el Valor de la Compra");
                Verfi2 = true; } else
            { errorProvider1.SetError(Pest1_Txt_PrecioCompra, ""); }


            if (string.IsNullOrWhiteSpace(Pest1_Txt_Cantidad.Text) || Convert.ToDouble(Pest1_Txt_Cantidad.Text)<=0)
            { errorProvider1.SetError(Pest1_Txt_Cantidad, "Debe ingresar la cantidad de entrada");
                Verfi2 = true; }
            else { errorProvider1.SetError(Pest1_Txt_Cantidad, ""); }


            if (Pest1_ComBo_Descripcion.SelectedIndex == -1)
            {
                errorProvider1.SetError(Pest1_ComBo_Descripcion, "Debe selecionar un Producto");
                Verfi2 = true; }
            else { errorProvider1.SetError(Pest1_ComBo_Descripcion, "");
            }


            if (comboBox1.SelectedIndex == -1)
            { errorProvider1.SetError(comboBox1, "Debe selecionar una Localidad"); Verfi2 = true; }
            else { errorProvider1.SetError(comboBox1, ""); }

            if (Verfi2 == true)
            {
                return;
            }


            for (int i = 0; i < Pest1_DataGriew_ProductosLista.Rows.Count; i++)
            {
                if (Convert.ToString((string)this.Pest1_DataGriew_ProductosLista.Rows[i].Cells[0].Value) == NombreProducto &&
                    Convert.ToString((string)this.Pest1_DataGriew_ProductosLista.Rows[i].Cells[1].Value) == NombreLocalidad)
                {
                    verif = true;
                }


                if (Convert.ToString((string)this.Pest1_DataGriew_ProductosLista.Rows[i].Cells[0].Value) == NombreProducto &&
                    Convert.ToString((string)this.Pest1_DataGriew_ProductosLista.Rows[i].Cells[2].Value) != Pest1_Txt_PrecioCompra.Text)
                {
                    verif = true;
                }
            }
            if (verif == true)
            {
                MessageBox.Show("El producto no puede agregarse dos veces si es de la misma localidad y su precio debera ser constante");
                return;
            }


            PrecioProducto = Convert.ToDouble(Convert.ToDouble(Pest1_Txt_PrecioCompra.Text) * Convert.ToDouble(Pest1_Txt_Cantidad.Text));
            Pest1_DataGriew_ProductosLista.Rows.Insert(0, NombreProducto, NombreLocalidad, Pest1_Txt_PrecioCompra.Text, Pest1_Txt_Cantidad.Text, PrecioProducto);

            //Calculo del Total y de la Cantidad Ingresada
            Pest1_Txt_TotalCompra.Text = Convert.ToString(Convert.ToDouble(Pest1_Txt_TotalCompra.Text) + Convert.ToDouble(PrecioProducto));
            Pest1_Txt_CantPreIngresados.Text = Convert.ToString(Convert.ToDouble(Pest1_Txt_CantPreIngresados.Text) + Convert.ToDouble(Pest1_Txt_Cantidad.Text));

            //Limpiesa
            Pest1_Txt_PrecioCompra.Text = string.Empty;
            Pest1_Txt_Cantidad.Text = string.Empty;
        }


        /// /// FUNCIONES /// ///
        private void Fun_ExtraerLocalidadProducto(int Cod_P, int Cod_L)
        {
            Con.sql = string.Format(@"select L.Nombre as 'Name', P.NombreProducto as 'Nombre' from Localidad as L inner join [Producto|Localidad] as Pl
                                    on L.Cod_Localidad=Pl.Cod_Localidad inner join Producto as P
                                    on P.Cod_Producto=Pl.Cod_Producto 
                                    where P.Cod_Producto='{0}' and L.Cod_Localidad='{1}'", Cod_P, Cod_L);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Con.cmd.ExecuteReader();

            if (Reg.Read())
            {
                NombreProducto = Reg["Nombre"].ToString();
                NombreLocalidad = Reg["Name"].ToString();

            }
            else
            {

            }

            Con.cnx.Close();
        }

        private void Pest1_Bttn_DescartarProducto_Click(object sender, EventArgs e)
        {
            int Var_renglonesSeleccionados = Pest1_DataGriew_ProductosLista.SelectedRows.Count;
            int Var_cuadrosselecionados = Pest1_DataGriew_ProductosLista.SelectedCells.Count;

            if (Var_renglonesSeleccionados == 0 && Var_cuadrosselecionados == 0)
            {
                MessageBox.Show("Tienes que seleccionar por lo menos una fila.");
                return;
            }

            double RestaCant, RestTotal;

            RestaCant = Convert.ToDouble(Pest1_DataGriew_ProductosLista.CurrentRow.Cells[3].Value.ToString());
            RestTotal = Convert.ToDouble(Pest1_DataGriew_ProductosLista.CurrentRow.Cells[4].Value.ToString());

            Pest1_DataGriew_ProductosLista.Rows.RemoveAt(Pest1_DataGriew_ProductosLista.CurrentRow.Index);
            Pest1_Txt_TotalCompra.Text = Convert.ToString(Convert.ToDouble(Pest1_Txt_TotalCompra.Text) - RestTotal);
            Pest1_Txt_CantPreIngresados.Text = Convert.ToString(Convert.ToDouble(Pest1_Txt_CantPreIngresados.Text) - RestaCant);

        }

        private void Pest1_Bttn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pest1_Bttn_Productos_Click(object sender, EventArgs e)
        {
            Desarrollo.Pantallas.Modulo___Productos.Form_Productos_ManejoProductos Pro = new Modulo___Productos.Form_Productos_ManejoProductos();
            Pro.Localidad = CodLocalidad;
            Pro.EmpNombr = this.NombreEmpleado;
            Pro.ShowDialog();
        }

        private void Pest1_Bttn_Guardar_Click(object sender, EventArgs e)
        {

            if (Pest1_DataGriew_ProductosLista.RowCount == 0)
            {
                MessageBox.Show("Debe agregar algun Producto", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Pest1_ComBo_InforProveedor.SelectedIndex == -1)
            {
                errorProvider1.SetError(Pest1_ComBo_InforProveedor, "Debe seleccionar un Porveedor");
                return;
            }
            else
            {
                errorProvider1.SetError(Pest1_ComBo_InforProveedor, "");
            }



            try
            {

                string Fecha_R = String.Format("{0:yyyy-MM-dd}", Fecha_Realizar.Value);
                string Fecha_E = String.Format("{0:yyyy-MM-dd}", Fecha_Entrega.Value);
                Comp.AgregarCompra(Convert.ToInt32(Pest1_Txt_cod_compra.Text), Fecha_E, Fecha_R, Codigo, Convert.ToInt16(Pest1_ComBo_InforProveedor.SelectedValue));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            foreach (DataGridViewRow Row in Pest1_DataGriew_ProductosLista.Rows)
            {
                try
                {
                    String strFila = Row.Index.ToString();
                    //AgregarDetallesCompra(string NombreProducto, int CantidadIngresada, float Precio)
                    Comp.AgregarDetallesCompra(Convert.ToString(Row.Cells["DG_Nombre"].Value),
                                               Convert.ToString(Row.Cells["DG_Localidad"].Value),
                                               Convert.ToInt32(Row.Cells["DG_Cantidad"].Value),
                                        (float)Convert.ToDouble(Row.Cells["DG_Precio"].Value));


                    //ModificarProductos_Localidad(string NombreProducto, string Localidad, int Cantidad)
                    Comp.ModificarProductos_Localidad(Convert.ToString(Row.Cells["DG_Nombre"].Value), Convert.ToString(Row.Cells["DG_Localidad"].Value),
                                              Convert.ToInt32(Row.Cells["DG_Cantidad"].Value));

                    //ModificarProducto(string NombreProducto, float PrecioCompra)
                    Comp.ModificarProducto(Convert.ToString(Row.Cells["DG_Nombre"].Value), (float)Convert.ToDouble(Row.Cells["DG_Precio"].Value));

                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }


            MessageBox.Show("La compra se ha registrado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            LimpiarTodo();
        }


        private void LimpiarTodo()
        {
            Pest1_Txt_cod_compra.Text = Convert.ToString(Comp.CodigoNuevoCompra());
            Pest1_Txt_PrecioCompra.Text = string.Empty;
            Pest1_Txt_Cantidad.Text = string.Empty;
            Pes1_Txt_Nombre.Text = string.Empty;
            Pest1_Txt_FilroProveedor.Text = string.Empty;
            Pest1_Txt_CantPreIngresados.Text = "0";
            Pest1_Txt_TotalCompra.Text = "0";
            Pest1_DataGriew_ProductosLista.Rows.Clear();
            Comp.Llenar_DataGriewIncial(Pest2_dataGridView_Facturas);
        }

        private void Pest1_Txt_FilroProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios(sender, e, Pest1_Txt_FilroProveedor);
        }

        private void Pes1_Txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios(sender, e, Pes1_Txt_Nombre);
        }

        private void Pest1_Txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarID(sender, e);
        }

        private void Pest1_Txt_PrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.NumerosDecimales(sender, e, Pest1_Txt_PrecioCompra);
        }

        private void Pest2_radio_Cod_Compra_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest2_radio_Cod_Compra.Checked == true)
            {
                Pest2_Txt_CodigoCompra.Enabled = true;
            } else
            {
                Pest2_Txt_CodigoCompra.Text = string.Empty;
                Pest2_Txt_CodigoCompra.Enabled = false;
            }
        }

        private void Pest2_Radio_Proveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest2_Radio_Proveedor.Checked == true)
            {
                Pest2_Text_NombreProveedor.Enabled = true;
            }
            else
            {
                Pest2_Text_NombreProveedor.Text = string.Empty;
                Pest2_Text_NombreProveedor.Enabled = false;
            }
        }

        private void Pest2_Txt_CodigoCompra_TextChanged(object sender, EventArgs e)
        {
            if (Pest2_Txt_CodigoCompra.Text == string.Empty)
            {
                Comp.Llenar_DataGriewIncial(Pest2_dataGridView_Facturas);
            }
            else
            {
                Comp.Llenar_DataGriewCodigo(Pest2_dataGridView_Facturas, Convert.ToDouble(Pest2_Txt_CodigoCompra.Text));
            }
        }

        private void Pest2_Text_NombreProveedor_TextChanged(object sender, EventArgs e)
        {
            if (Pest2_Text_NombreProveedor.Text == string.Empty)
            {
                Comp.Llenar_DataGriewIncial(Pest2_dataGridView_Facturas);
            }
            else
            {
                Comp.Llenar_DataGriewProveedor(Pest2_dataGridView_Facturas, (Pest2_Text_NombreProveedor.Text));
            }


        }

        private void Pest2_dataGridView_Facturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            float Codigos_Fac = 0;
            Codigos_Fac = (float)Convert.ToDouble(Pest2_dataGridView_Facturas.CurrentRow.Cells[0].Value.ToString());

            Comp.Llenar_DataGriewDetalles(Pest2_dataGridView_DetalleFactura, Codigos_Fac);
        }

        private void Pest2_Txt_CodigoCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarID(sender, e);
        }

        private void Pest2_Text_NombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios(sender, e, Pest2_Text_NombreProveedor);
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            string busq = Convert.ToDateTime(dateTimePicker3.Text).ToString("yyyy-MM-dd");
            Comp.Llenar_DataGriewFechaEntrega(Pest2_dataGridView_Facturas, busq);
        }

        private void Pest2_radio_FechaFinal_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest2_radio_FechaFinal.Checked == true)
            {
                dateTimePicker3.Enabled = true;
            }
            else
            {
                dateTimePicker3.Enabled = false;
                Comp.Llenar_DataGriewIncial(Pest2_dataGridView_Facturas);
            }
        }

        private void Pest2_radio_Fechacompra_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest2_radio_Fechacompra.Checked==true)
            {
                dateTimePicker2.Enabled = true;
            }
            else
            {
                dateTimePicker2.Enabled = false;
                Comp.Llenar_DataGriewIncial(Pest2_dataGridView_Facturas);
            }
        }

        private void Pest2_radio_ModoGlobal_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string busq = Convert.ToDateTime(dateTimePicker2.Text).ToString("yyyy-MM-dd");
            Comp.Llenar_DataGriewFechaPedido(Pest2_dataGridView_Facturas, busq);
        }

        private void Pest2_Bttn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pest2_dataGridView_DetalleFactura.DataSource = null;
            Pest2_dataGridView_DetalleFactura.RowCount = 0;
            Pest2_dataGridView_DetalleFactura.Rows.Clear();
            Pest2_dataGridView_DetalleFactura.Refresh();
        }

        private void Pest1_Bttn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }
    }
}

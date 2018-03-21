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
using Desarrollo.Clases;
using Desarrollo.Pantallas.Modulo__Ingreso_al_sistema;
using Desarrollo.Pantallas.Modulo_Ventas_Manejo.Modulo_ArqueodeCaja;

namespace Desarrollo.Pantallas.Modulo_Ventas_Nuevas
{
    public partial class Form_Ventas_Nuevas : System.Windows.Forms.Form
    {
        N_Ventas ven = new N_Ventas();
        public string Mensaje;
        public string Cod_Empleado;
        public string NombreEmp;
        public double Impuesto;
        public string Lo;

        public int TotalTienda;
        public int TotalBodega;

        //METODO DE PAGO
        public bool Var_ConfirmarMetodoDePago = false;
        public int Codigo_Cliente;

        public double Var_TotalAPagarCredito = 0;
        public double Var_TotalAPagarEfectivo = 0;
        public double Var_TotalAPagarEfectivoCambio = 0;
        public double Var_TotalAPagarTarjeta = 0;



        public string OptenerLocalidad(int Cod_Empl)
        {
            Conexion Con = new Conexion();
            string Codigo_Localidad = "";

            Con.sql = string.Format(@"select [Cod_Localidad] as CL from Empleados where Codigo_Empleado='{0}'", Cod_Empl);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Con.cmd.ExecuteReader();

            if (Reg.Read())
            {

                Codigo_Localidad = Reg["CL"].ToString();
               

            }
            else
            {

            }

            Con.cnx.Close();
            return Codigo_Localidad;
        }
        public Form_Ventas_Nuevas()
        {
            InitializeComponent();
        }

        private void Form_Ventas_Nuevas_Load(object sender, EventArgs e)
        {
            if (ven.verificacionRangoFinalyCorrelativo() == false)
            {

                ven.cambioEstadoIgualdadCorrelativoyRangoFinal();

            }
            if (ven.verificacionCodigoCaiEstado() == false)
            {
                MessageBox.Show("imposibilidad de realizar ventas debido a la falta de un cai activo");
                this.Close();
            }
            txt_codigoCai.Text = ven.ObtenerCodigocai();
            txt_codigoFactura.Text = Convert.ToString(ven.ObtenerNumeroFactura());
            textBox3.Text = NombreEmp;


            textBox5.Enabled = false;
            Fun_TipoFactura();
            // OptenerUltimoCodigoFactura();

            //Impuestos
            string Fecha_R = String.Format("{0:yyyy-MM-dd}", Var_FechaActual.Value);
            ven.VerificarImpuestosNuevos(Fecha_R);
            Impuesto = ven.OptenerImpuesto();
            txt_Impuesto.Text = "%" + Convert.ToString(100 * Impuesto);

            var blankContextMenu = new ContextMenuStrip();
            txt_codigoCai.ContextMenuStrip = blankContextMenu;
            textBox3.ContextMenuStrip = blankContextMenu;
            txt_Impuesto.ContextMenuStrip = blankContextMenu;
            textBox5.ContextMenuStrip = blankContextMenu;
            txtnombre.ContextMenuStrip = blankContextMenu;
            txtcanComprar.ContextMenuStrip = blankContextMenu;

            txtprecioVenta.ContextMenuStrip = blankContextMenu;
            txtcanExistente.ContextMenuStrip = blankContextMenu;


            //ULTIMAS MODIFICACIONES
             Lo = OptenerLocalidad(Convert.ToInt32(Cod_Empleado));
            ven.Fun_ExtraerLocalidades(ComBox_Localidad);

            ComBox_Localidad.SelectedValue = Convert.ToInt16(Lo);

        }

        public void Fun_LlenarEmpresa(string FiltroEmpresa)
        {
            string a;
            if (FiltroEmpresa == string.Empty)
            {
                return;
            }
            else
            {
                a = FiltroEmpresa;
            }
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select A.Codigo_Cliente as 'Codigo del Cliente',
                                     B.NombreEmpresa as 'Nombre' FROM Clientes as A inner join Empresas as B on A.Codigo_Empresa=B.Codigo_Empresa
                                     WHERE B.NombreEmpresa like '%{0}%'", a);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();

            comboBox3.ValueMember = "Codigo del Cliente";
            comboBox3.DisplayMember = "Nombre";
            comboBox3.DataSource = Con.dt;
        }


        public void Fun_ClienteComun(string ClienteComun)
        {
            string a;
            if (ClienteComun == string.Empty)
            {
                return;
            }
            else
            {
                a = ClienteComun;
            }
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select A.Codigo_Cliente as 'Codigo del Cliente', (A.Nombre + ' ' + A.Apellido) as 'Nombre Cliente' FROM Clientes as A 
                                        WHERE A.Nombre like '%{0}%'", a);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();

            comboBox3.ValueMember = "Codigo del Cliente";
            comboBox3.DisplayMember = "Nombre Cliente";
            comboBox3.DataSource = Con.dt;
        }

        public void Fun_PersonaAutorizada(string Autorizado)
        {
            string a;
            if (Autorizado == string.Empty)
            {
                return;
            }
            else
            {
                a = Autorizado;
            }
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select P.Codigo_PersonasAutorizadas as 'Cod Persona', 
                                    (P.Nombre + ' - ' + P.Numero_Identidad ) as 'Nombre Autorizada' 
                                    from Clientes as A inner join PersonasAutorizadas as P on A.Codigo_Cliente=P.Codigo_Cliente
                                    where A.Nombre like '%{0}%'", a);

            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();

            comboBox3.ValueMember = "Cod Persona";
            comboBox3.DisplayMember = "Nombre Autorizada";
            comboBox3.DataSource = Con.dt;
        }


        public void Fun_TipoFactura()
        {
            Conexion Con = new Conexion();

            string mostrar;

            Con.cnx.Open();
            mostrar = Con.sql = string.Format(@"select Codigo_Tipo, Descripcion_Tipo from Tipo_Factura");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();

            comboBox1.ValueMember = "Codigo_Tipo";
            comboBox1.DisplayMember = "Descripcion_Tipo";
            comboBox1.DataSource = Con.dt;



        }


        public void OptenerUltimoCodigoFactura()
        {


            Conexion Con = new Conexion();

            Con.sql = string.Format(@"select Top 1 Cod_Factura as Cod from Facturas order by Cod_Factura desc");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Con.cmd.ExecuteReader();

            if (Reg.Read())
            {
                txt_codigoFactura.Text = Convert.ToString(Convert.ToInt16((Reg["Cod"].ToString())) + 1);

            }
            else
            {

            }

            Con.cnx.Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            comboBox3.DataSource = null;
            comboBox3.Items.Clear();

            if (radioButton1.Checked == true)
            {
                Fun_LlenarEmpresa(textBox5.Text);
            }

            if (radioButton2.Checked == true)
            {
                Fun_ClienteComun(textBox5.Text);
            }

            if (radioButton3.Checked == true)
            {
                Fun_PersonaAutorizada(textBox5.Text);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Desarrollo.Pantallas.Modulo_Ventas_Manejo.Form_Busqueda_Producto Bus = new Modulo_Ventas_Manejo.Form_Busqueda_Producto();
            AddOwnedForm(Bus);
            Bus.Localidad = this.Lo;
            Bus.ShowDialog();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones Val = new Validaciones();

            Val.ValirLetrasYEspacios(sender, e, textBox5);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
                textBox5.Enabled = true;
            else
                textBox5.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                textBox5.Enabled = true;
            else
                textBox5.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                textBox5.Enabled = true;
            else
                textBox5.Enabled = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones Val = new Validaciones();

            Val.ValirLetrasYEspacios(sender, e, txtnombre);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones Val = new Validaciones();


        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones Val = new Validaciones();

            Val.ValidarID(sender, e);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones Val = new Validaciones();

            Val.ValidarID(sender, e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones Val = new Validaciones();

            Val.ValidarID(sender, e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones Val = new Validaciones();

            Val.ValirLetrasYEspacios(sender, e, textBox3);
        }
        public int preciototalpro = 0;

        public void Limpiar()
        {
            txtcodigo.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtcanExistente.Text = string.Empty;
            txtprecioVenta.Text = string.Empty;
            dataGridView1.Rows.Clear();
            TextBo_Cal_Suptotal.Text="0";
            TextBo_Cal_IVA.Text = "0";
            TextBo_Cal_TOTAL.Text = "0";
            txtcanExistente.Text = string.Empty;
            textBox5.Text = string.Empty;
            txtcanComprar.Text = string.Empty;
        }

        public void Limpiar1()
        {
            txtcodigo.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtcanExistente.Text = string.Empty;
            txtprecioVenta.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sumatoria = TotalBodega + TotalTienda;


            if (string.IsNullOrWhiteSpace(txtcodigo.Text))
            {
                MessageBox.Show("Debe selecionar un Producto", "Error de Agregado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtcanComprar.Text) || Convert.ToDouble(txtcanComprar.Text) == 0)
            {
                MessageBox.Show("Debe ingrsar la cantidad a vender", "Error de Agregado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int ContP = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToString((string)this.dataGridView1.Rows[i].Cells[1].Value) == txtnombre.Text)
                {
                    ContP = ContP + 1;
                }


            }

            if (ContP > 0)
            {
                MessageBox.Show("No puede insertar el mismo producto dos veces", "Error de Agregado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (Convert.ToInt32(txtcanExistente.Text) < Convert.ToInt32(txtcanComprar.Text))
            {
                if (Lo != "1")
                {
                    MessageBox.Show("La cantidad sobrepasa los limites permitivos", "Error de Agregado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else if (sumatoria < Convert.ToInt32(txtcanComprar.Text))
                {
                    MessageBox.Show("La cantidad sobrepasa los limites permitivos", "Error de Agregado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            }



            double Sub, Imp;

            Sub = Convert.ToDouble(txtprecioVenta.Text) * Convert.ToDouble(txtcanComprar.Text);
            Imp = Convert.ToDouble(Sub) * Convert.ToDouble(this.Impuesto);

            dataGridView1.Rows.Add(txtcodigo.Text, txtnombre.Text, txtprecioVenta.Text, txtcanComprar.Text, Imp, Sub);
            Var_ConfirmarMetodoDePago = false;

            TextBo_Cal_Suptotal.Text =
                                        Convert.ToString(Convert.ToDouble(TextBo_Cal_Suptotal.Text) +
                                        (Convert.ToDouble(txtprecioVenta.Text) * Convert.ToDouble(txtcanComprar.Text)));

            TextBo_Cal_IVA.Text = Convert.ToString(Convert.ToDouble(TextBo_Cal_Suptotal.Text) * Convert.ToDouble(this.Impuesto));

            TextBo_Cal_TOTAL.Text = Convert.ToString(Convert.ToDouble(TextBo_Cal_Suptotal.Text) + Convert.ToDouble(TextBo_Cal_IVA.Text));
            Limpiar1();


        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int Var_renglonesSeleccionados = dataGridView1.SelectedRows.Count;
            int Var_cuadrosselecionados = dataGridView1.SelectedCells.Count;

            if (Var_renglonesSeleccionados == 0 && Var_cuadrosselecionados==0)
            {
                MessageBox.Show("Tienes que seleccionar por lo menos una fila.");
                return;
            }

            double RestaImpusto, RestSubtotal, Rest_Total;

            RestaImpusto = Convert.ToDouble(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            RestSubtotal = Convert.ToDouble(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            Rest_Total = RestaImpusto + RestSubtotal;

            TextBo_Cal_IVA.Text = Convert.ToString(Convert.ToDouble(TextBo_Cal_IVA.Text) - RestaImpusto);
            TextBo_Cal_Suptotal.Text = Convert.ToString(Convert.ToDouble(TextBo_Cal_Suptotal.Text) - RestSubtotal);
            TextBo_Cal_TOTAL.Text = Convert.ToString(Convert.ToDouble(TextBo_Cal_TOTAL.Text) - Rest_Total);

            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Desarrollo.Pantallas.Modulo___Productos.Form_Productos_ManejoProductos P = new Modulo___Productos.Form_Productos_ManejoProductos();
            P.Localidad = this.Lo;
            P.EmpNombr = this.NombreEmp;
            P.ShowDialog();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Desarrollo.Pantallas.Modulo_Ventas_Manejo.Form_BusquedaFacturas F = new Modulo_Ventas_Manejo.Form_BusquedaFacturas();
            F.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Desarrollo.Pantallas.Modulo_Ventas_Manejo.Form_RealizarCotizaciones C = new Modulo_Ventas_Manejo.Form_RealizarCotizaciones();
            C.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_ManejoClientes M = new Form_ManejoClientes();
            M.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            /* Bus.Localidad = this.Lo;*/
            if (radioButton1.Checked == true || radioButton2.Checked == true)
            {
                Codigo_Cliente = Convert.ToInt32(comboBox3.SelectedValue);
            }
            else if (radioButton3.Checked == true)
            {
                Codigo_Cliente = ven.Var_OptenerCodigoCliente_PersonaAutorizada(Convert.ToInt32(comboBox3.SelectedValue));
            }
            else
            {
                Codigo_Cliente = 0;
            }

            if (Convert.ToDouble(TextBo_Cal_TOTAL.Text) == 0)
            {
                MessageBox.Show("Debe selecionar un Producto", "Error de Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Pantallas.Modulo_Ventas_Manejo.Form_DefinirMetodoDePago M = new Modulo_Ventas_Manejo.Form_DefinirMetodoDePago();
            AddOwnedForm(M);
            M.CodigoCliente = this.Codigo_Cliente;
            M.Total = Convert.ToDouble(TextBo_Cal_TOTAL.Text);
            M.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (Var_ConfirmarMetodoDePago == false)
            {
                MessageBox.Show("Defina los metodos de pago que se van a utilizar", "Error de Impresion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Bttn_DefinirMetodosDePago.Focus();
                return;
            }

            if (TextBo_Cal_TOTAL.Text == "0")
            {
                MessageBox.Show("Debe agregar un Producto", "Error de Impresion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button14.Focus();
                return;
            }


            DialogResult opcion;
            opcion = MessageBox.Show("¿Esta seguro de realizar la Venta?", "Confirmacion de Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (opcion == DialogResult.Yes)
            {
                double Valor = Convert.ToDouble(txt_codigoFactura.Text);
                IngresoDeVentas();
                MessageBox.Show("Se ha realizado la Venta exitosamente", "Aviso de Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Limpiar();
                UpdateCorrelativo((int) Valor);
                Cai();
            }


        }

        private void Cai()
        {
            if (ven.verificacionRangoFinalyCorrelativo() == false)
            {

                ven.cambioEstadoIgualdadCorrelativoyRangoFinal();

            }
            if (ven.verificacionCodigoCaiEstado() == false)
            {
                MessageBox.Show("imposibilidad de realizar ventas debido a la falta de un cai activo");
                this.Close();
            }
            txt_codigoCai.Text = ven.ObtenerCodigocai();
            txt_codigoFactura.Text = Convert.ToString(ven.ObtenerNumeroFactura());
            textBox3.Text = NombreEmp;
        }

        //***FUNCIONES DE VENTA*******************************************************************************************************************
        public void IngresoDeVentas()
        {
            float PorcentajeIngreso = (float)Convert.ToDouble(Impuesto);
            string Fecha_Facturacion = String.Format("{0:yyyy-MM-dd}", Var_FechaActual.Value);

            if (radioButton3.Checked == true)
            {
                AgregarConPersonaAutorizada(Convert.ToInt32(txt_codigoFactura.Text), Fecha_Facturacion, PorcentajeIngreso, Convert.ToInt32(Cod_Empleado), Convert.ToInt32(comboBox3.SelectedValue));
            }
            else
            {

                AgregarFacturaSinPersonaAutorizada(Convert.ToInt32(txt_codigoFactura.Text), Fecha_Facturacion, PorcentajeIngreso, Convert.ToInt32(Cod_Empleado));
            }

            ManejoProductos();
            ManejoDeTransaccion();



        }
        Conexion Conex = new Conexion();
        private void AgregarFacturaSinPersonaAutorizada(int CodigoFac, string Fecha, float Porcentaje, int Cod_EmpleadoFac)
        {


            Conex.sql = string.Format(@"insert into 
            Facturas(Cod_Factura, Fecha_Factura,Impuesto_Porcentaje,Codigo_Empleado,Codigo_Cai,Codigo_Mora,Codigo_Estado,Codigo_Tipo)
            values('{0}','{1}','{2}','{3}',
	    	(select Top 1 Codigo_Cai from Cai where Codigo_Estado=1 order by Codigo_Cai desc),
	    	(select Top 1 Codigo_Mora from Mora where CodEstado_Mora=1 order by Codigo_Mora desc), 
	    	'1', '1')", CodigoFac, Fecha, Porcentaje, Cod_EmpleadoFac);

            Conex.cmd = new SqlCommand(Conex.sql, Conex.cnx);
            Conex.cnx.Open();
            SqlDataReader Reg = null;
            Reg = Conex.cmd.ExecuteReader();
            Conex.cnx.Close();
        }

        private void AgregarConPersonaAutorizada(int CodigoFac, string Fecha, float Porcentaje, int Cod_EmpleadoFac, int CodPersonaAutorizada)
        {
            Conex.sql = string.Format(@"insert into 
            Facturas(Cod_Factura, Fecha_Factura,Impuesto_Porcentaje,Codigo_Empleado,Codigo_PersonaAutorizada,Codigo_Cai,Codigo_Mora,Codigo_Estado,Codigo_Tipo)
            values('{0}','{1}','{2}','{3}','{4}',
	    	(select Top 1 Codigo_Cai from Cai where Codigo_Estado=1 order by Codigo_Cai desc),
	    	(select Top 1 Codigo_Mora from Mora where CodEstado_Mora=1 order by Codigo_Mora desc), 
	    	'1', '1')", CodigoFac, Fecha, Porcentaje, Cod_EmpleadoFac, CodPersonaAutorizada);

            Conex.cmd = new SqlCommand(Conex.sql, Conex.cnx);
            Conex.cnx.Open();
            SqlDataReader Reg = null;
            Reg = Conex.cmd.ExecuteReader();
            Conex.cnx.Close();
        }

        private void ManejoProductos()
        {
            float Pre = 0;

            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                Pre = (float)Convert.ToDouble(Row.Cells["Column5"].Value);

                if (Convert.ToInt32(Lo)!= 1){
                    RestarProductosNormales(Convert.ToInt32(Row.Cells["Column6"].Value), Convert.ToInt32(Lo), Convert.ToInt32(Row.Cells["Column1"].Value));
                }
                else
                {
                    int Ti = OptenerTienda(Convert.ToInt32(Row.Cells["Column1"].Value));

                    float CantidadesSumatoria = Ti-Convert.ToInt32(Row.Cells["Column6"].Value);
                    if (CantidadesSumatoria < 0)
                    {
                   

                        SumRestaBodega((int)CantidadesSumatoria, Convert.ToInt32(Row.Cells["Column1"].Value));
                        ActualizarA0Tienda(Convert.ToInt32(Row.Cells["Column1"].Value));
                    }
                    else
                    {
                        
                        RestarProductosNormales((int)Convert.ToDouble(Row.Cells["Column6"].Value), Convert.ToInt32(Lo), Convert.ToInt32(Row.Cells["Column1"].Value));
                    }
                }
                
                AgregarProductps((int)Convert.ToDouble(Row.Cells["Column1"].Value), Pre, Convert.ToInt32(Row.Cells["Column6"].Value));
            }

        }

        private void AgregarProductps(int Cod_Prod, float Precio, int Cantidad)
        {
            Conex.sql = string.Format(@"insert into [Detalles|Factura](Codigo_Factura, Codigo_Producto, PrecioVenta,CantidadVenta) values 
            ((select Top 1 A.Cod_Factura from Facturas as A order by A.Cod_Factura desc),'{0}','{1}','{2}')", Cod_Prod, Precio, Cantidad);
            Conex.cmd = new SqlCommand(Conex.sql, Conex.cnx);
            Conex.cnx.Open();
            SqlDataReader Reg = null;
            Reg = Conex.cmd.ExecuteReader();
            Conex.cnx.Close();
        }

        ///***************************************************************************************************************************************
        ///
        private void ManejoDeTransaccion()
        {
            string FechaTransacc = String.Format("{0:yyyy-MM-dd}", Var_FechaActual.Value);
            float MontoDeEntrada;
            string FechaVencim = String.Format("{0:yyyy-dd-MM}", Var_FechaActual.Value);

            if (Var_TotalAPagarCredito != 0)
            {
                MontoDeEntrada = (float)Convert.ToDouble(Var_TotalAPagarCredito);

                if (Convert.ToString(comboBox3.SelectedValue) == string.Empty)
                {
                    MessageBox.Show("El cliente no cuenta con credito", "Error de registro", MessageBoxButtons.OK);
                }
                else
                {
                    UpdateSaldo(Convert.ToInt16(Codigo_Cliente), MontoDeEntrada);
                    TrandaccionesCreditoConCliente(FechaTransacc, MontoDeEntrada, Convert.ToInt16(Codigo_Cliente), FechaVencim);
                }
            }


            if (Var_TotalAPagarTarjeta != 0)
            {
                MontoDeEntrada = (float)Convert.ToDouble(Var_TotalAPagarTarjeta);

                if (Convert.ToString(comboBox3.SelectedValue) == string.Empty)
                {
                    TransaccionesSinClientes(3, 2, FechaTransacc, MontoDeEntrada);
                }
                else
                {
                    TransaccionesContadoConCliente(3, 2, FechaTransacc, MontoDeEntrada, Convert.ToInt16(Codigo_Cliente));
                }

            }

            if (Var_TotalAPagarEfectivo != 0)
            {
                MontoDeEntrada = (float)Convert.ToDouble(Var_TotalAPagarEfectivo - Var_TotalAPagarEfectivoCambio);

                if (Convert.ToString(comboBox3.SelectedValue) == string.Empty)
                {
                    TransaccionesSinClientes(2, 2, FechaTransacc, MontoDeEntrada);
                }
                else
                {
                    TransaccionesContadoConCliente(2, 2, FechaTransacc, MontoDeEntrada, Convert.ToInt16(Codigo_Cliente));
                }

            }

            /* public double Var_TotalAPagarEfectivo = 0;
             public double Var_TotalAPagarEfectivoCambio = 0;
             public double ;*/
        }


        private void TrandaccionesCreditoConCliente(string FechaI, float Monto_Entrante, int C_ClienteIn, string FechaVen)
        {
            Conex.sql = string.Format(@"insert into Transacciones 
            (Codigo_Estado, Numero_Documento, Codigo_Tipo_Transaccion, Codigo_Tipo_Documento, Fecha,Monto, Codigo_Cliente,Fecha_Vencimiento, Codigo_Mora,ValResd)
            values(2,(select Top 1 A.Cod_Factura from Facturas as A order by A.Cod_Factura desc),
            1,2,'{0}','{1}','{2}',(SELECT DATEADD(day,20, '{3}'))
            ,(SELECT TOP 1 Codigo_Mora FROM Mora ORDER BY Codigo_Mora DESC),'{4}' )", FechaI, Monto_Entrante, C_ClienteIn, FechaVen, Monto_Entrante);
            Conex.cmd = new SqlCommand(Conex.sql, Conex.cnx);
            Conex.cnx.Open();
            SqlDataReader Reg = null;
            Reg = Conex.cmd.ExecuteReader();
            Conex.cnx.Close();
        }


        private void TrandaccionesCreditoSinCliente(string FechaI, float Monto_Entrante, string FechaVen)
        {
            Conex.sql = string.Format(@"insert into Transacciones 
            (Codigo_Estado, Numero_Documento, Codigo_Tipo_Transaccion, Codigo_Tipo_Documento, Fecha,Monto,Fecha_Vencimiento, Codigo_Mora,ValResd)
            values(2,(select Top 1 A.Cod_Factura from Facturas as A order by A.Cod_Factura desc),
            1,2,'{0}','{1}',(SELECT DATEADD(day,20, '{2}'))
            ,(SELECT TOP 1 Codigo_Mora FROM Mora ORDER BY Codigo_Mora DESC),'{3}')", FechaI, Monto_Entrante, FechaVen, Monto_Entrante);
            Conex.cmd = new SqlCommand(Conex.sql, Conex.cnx);
            Conex.cnx.Open();
            SqlDataReader Reg = null;
            Reg = Conex.cmd.ExecuteReader();
            Conex.cnx.Close();
        }


        private void TransaccionesContadoConCliente(int TipoTrans, int TipDocu, string Date, float Tot, int CodCl)
        {
            Conex.sql = string.Format(@"insert into Transacciones 
                                      (Codigo_Estado, Numero_Documento, Codigo_Tipo_Transaccion, Codigo_Tipo_Documento, Fecha,Monto,Codigo_Cliente ,Codigo_Mora)
                                      values(1,(select Top 1 A.Cod_Factura from Facturas as A order by A.Cod_Factura desc),
                                      '{0}','{1}','{2}','{3}','{4}',(SELECT TOP 1 Codigo_Mora FROM Mora ORDER BY Codigo_Mora DESC))", TipoTrans, TipDocu, Date, Tot, CodCl);
            Conex.cmd = new SqlCommand(Conex.sql, Conex.cnx);
            Conex.cnx.Open();
            SqlDataReader Reg = null;
            Reg = Conex.cmd.ExecuteReader();
            Conex.cnx.Close();
        }

        private void TransaccionesSinClientes(int TipoTrans, int TipDocu, string Date, float Tot)
        {
            Conex.sql = string.Format(@"insert into Transacciones 
                                    (Codigo_Estado, Numero_Documento, Codigo_Tipo_Transaccion, Codigo_Tipo_Documento, Fecha,Monto, Codigo_Mora)
                                    values(1,(select Top 1 A.Cod_Factura from Facturas as A order by A.Cod_Factura desc),
                                    '{0}','{1}','{2}','{3}',(SELECT TOP 1 Codigo_Mora FROM Mora ORDER BY Codigo_Mora DESC))", TipoTrans, TipDocu, Date, Tot);
            Conex.cmd = new SqlCommand(Conex.sql, Conex.cnx);
            Conex.cnx.Open();
            SqlDataReader Reg = null;
            Reg = Conex.cmd.ExecuteReader();
            Conex.cnx.Close();
        }



        //PRODUCTOS
        private void RestarProductosNormales(int C, int L, int P)
        {

            Conex.sql = string.Format(@"update [Producto|Localidad] set Cantidad=CAST( (CAST(Cantidad as float)- {0}) as nvarchar) where Cod_Localidad='{1}' and Cod_Producto='{2}'",C,L,P);
            Conex.cmd = new SqlCommand(Conex.sql, Conex.cnx);
            Conex.cnx.Open();
            SqlDataReader Reg = null;
            Reg = Conex.cmd.ExecuteReader();
            Conex.cnx.Close();

        }

        private int OptenerBodega(int CP)
        {

            return 0;
        }


        private int OptenerTienda(int CP)
        {
            int Co = 0;
            Conex.sql = string.Format(@"select Cantidad as C from [Producto|Localidad] where Cod_Producto='{0}' and Cod_Localidad=1", CP);
            Conex.cmd = new SqlCommand(Conex.sql, Conex.cnx);
            Conex.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Conex.cmd.ExecuteReader();

            if (Reg.Read())
            {

                Co = Convert.ToInt32((Reg["C"].ToString()));

            }
            Conex.cnx.Close();
            return Co;
        }

        private void ActualizarA0Tienda(int C)
        {
            Conex.sql = string.Format(@"update [Producto|Localidad] set Cantidad=0 where Cod_Localidad=1 and Cod_Producto='{0}'", C);
            Conex.cmd = new SqlCommand(Conex.sql, Conex.cnx);
            Conex.cnx.Open();
            SqlDataReader Reg = null;
            Reg = Conex.cmd.ExecuteReader();
            Conex.cnx.Close();
        }

        private void SumRestaBodega(int C, int P)
        {
            Conex.sql = string.Format(@"update [Producto|Localidad] set Cantidad=CAST( (CAST(Cantidad as float)+ {0}) as nvarchar) where Cod_Localidad=2 and Cod_Producto='{1}'", C, P);
            Conex.cmd = new SqlCommand(Conex.sql, Conex.cnx);
            Conex.cnx.Open();
            SqlDataReader Reg = null;
            Reg = Conex.cmd.ExecuteReader();
            Conex.cnx.Close();
        }


        private void UpdateCorrelativo(int Codi)
        {
            Conex.sql = string.Format(@"update Cai set Correlativo='{0}' where Codigo_Cai=(select Top 1 Codigo_Cai from Cai order by Codigo_Cai desc)", Codi);
            Conex.cmd = new SqlCommand(Conex.sql, Conex.cnx);
            Conex.cnx.Open();
            SqlDataReader Reg = null;
            Reg = Conex.cmd.ExecuteReader();
            Conex.cnx.Close();
        }


        private void UpdateSaldo(int Cod, float Sal)
        {
            Conex.sql = string.Format(@"update Creditos set Saldo_Actual=CAST( (CAST(Saldo_Actual as float)- {0}) as nvarchar) where 
Codigo_Credito=(select B.Codigo_Credito from Clientes as B where B.Codigo_Cliente='{1}')", Sal, Cod);
            Conex.cmd = new SqlCommand(Conex.sql, Conex.cnx);
            Conex.cnx.Open();
            SqlDataReader Reg = null;
            Reg = Conex.cmd.ExecuteReader();
            Conex.cnx.Close();
        }

        private void txtcanComprar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones Val = new Validaciones();
            Val.ValidarID(sender,e);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form_PantallCierreConfirmacion Cierre = new Form_PantallCierreConfirmacion();
            Cierre.Var_TotCaj = ven.Fun_ExtraerTotales(Var_FechaActual, Convert.ToInt32(Cod_Empleado), 2);
            Cierre.Var_TotCrd = ven.Fun_ExtraerTotales(Var_FechaActual, Convert.ToInt32(Cod_Empleado), 1); 
            Cierre.Var_TotTrg = ven.Fun_ExtraerTotales(Var_FechaActual, Convert.ToInt32(Cod_Empleado), 3);
            Cierre.Cod_Usuario = Cod_Empleado;
            Cierre.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Manueales.Manuales Manual = new Manueales.Manuales();
            Manual.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}

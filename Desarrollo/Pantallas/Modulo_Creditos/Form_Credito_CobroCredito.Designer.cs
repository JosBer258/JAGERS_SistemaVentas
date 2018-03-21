namespace Desarrollo.Pantallas.Modulo_Creditos
{
    partial class Form_Credito_CobroCredito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Bttn_MuestraClientes = new System.Windows.Forms.Button();
            this.Bttn_Ayuda = new System.Windows.Forms.Button();
            this.Bttn_Salir = new System.Windows.Forms.Button();
            this.Bttn_LimpiarTodo = new System.Windows.Forms.Button();
            this.DVG_MuesCredito = new System.Windows.Forms.TabPage();
            this.DVG_RePago = new System.Windows.Forms.TabPage();
            this.Pest1_Txt_NombreEmpleado = new System.Windows.Forms.TextBox();
            this.Pest1_DATE_FechaActual = new System.Windows.Forms.DateTimePicker();
            this.Pest1_Grupo_FiltroBusqueda = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Pest1_ComBox_MuestDatos = new System.Windows.Forms.ComboBox();
            this.Pest1_Txt_Filtro = new System.Windows.Forms.TextBox();
            this.Pest1_Grupo_Factura = new System.Windows.Forms.GroupBox();
            this.Pest1_Txt_MontoResidual = new System.Windows.Forms.TextBox();
            this.Pest1_Txt_MontoOriginal = new System.Windows.Forms.TextBox();
            this.Pest1_Txt_NFactura = new System.Windows.Forms.TextBox();
            this.Pest1_Txt_NTransacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Pest1_Bttn_Limpiar = new System.Windows.Forms.Button();
            this.Pest1_Bttn_RealizarPag = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Pest1_Txt_MontAPagar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pest1_ComBox_MetodoPago = new System.Windows.Forms.ComboBox();
            this.Pest1_DGV_DatosFactura = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Pest2_Grupo_Cliente = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Pest2_ComBo_Muestra = new System.Windows.Forms.ComboBox();
            this.Pest2_Txt_FiltroNombre = new System.Windows.Forms.TextBox();
            this.Pest2_Grupo_Opciones = new System.Windows.Forms.GroupBox();
            this.Pest2_Grupo_Muestra = new System.Windows.Forms.GroupBox();
            this.Pest2_DGV_MuestraDatos = new System.Windows.Forms.DataGridView();
            this.Pest2_Bttn_AplicarMora = new System.Windows.Forms.Button();
            this.Pest2_Bttn_VerDetalle = new System.Windows.Forms.Button();
            this.Pest2_Radio_Todos = new System.Windows.Forms.RadioButton();
            this.Pest2_Radio_FilPorClie = new System.Windows.Forms.RadioButton();
            this.Pest2_Cod_Trans = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DVG_MuesCredito.SuspendLayout();
            this.DVG_RePago.SuspendLayout();
            this.Pest1_Grupo_FiltroBusqueda.SuspendLayout();
            this.Pest1_Grupo_Factura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pest1_DGV_DatosFactura)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.Pest2_Grupo_Cliente.SuspendLayout();
            this.Pest2_Grupo_Opciones.SuspendLayout();
            this.Pest2_Grupo_Muestra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pest2_DGV_MuestraDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // Bttn_MuestraClientes
            // 
            this.Bttn_MuestraClientes.Location = new System.Drawing.Point(228, 558);
            this.Bttn_MuestraClientes.Name = "Bttn_MuestraClientes";
            this.Bttn_MuestraClientes.Size = new System.Drawing.Size(242, 99);
            this.Bttn_MuestraClientes.TabIndex = 16;
            this.Bttn_MuestraClientes.Text = "Clientes";
            this.Bttn_MuestraClientes.UseVisualStyleBackColor = true;
            this.Bttn_MuestraClientes.Click += new System.EventHandler(this.Bttn_MuestraClientes_Click);
            // 
            // Bttn_Ayuda
            // 
            this.Bttn_Ayuda.Location = new System.Drawing.Point(467, 558);
            this.Bttn_Ayuda.Name = "Bttn_Ayuda";
            this.Bttn_Ayuda.Size = new System.Drawing.Size(238, 99);
            this.Bttn_Ayuda.TabIndex = 17;
            this.Bttn_Ayuda.Text = "Ayuda";
            this.Bttn_Ayuda.UseVisualStyleBackColor = true;
            this.Bttn_Ayuda.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bttn_Salir
            // 
            this.Bttn_Salir.Location = new System.Drawing.Point(-6, 558);
            this.Bttn_Salir.Name = "Bttn_Salir";
            this.Bttn_Salir.Size = new System.Drawing.Size(244, 95);
            this.Bttn_Salir.TabIndex = 18;
            this.Bttn_Salir.Text = "Salir";
            this.Bttn_Salir.UseVisualStyleBackColor = true;
            this.Bttn_Salir.Click += new System.EventHandler(this.Bttn_Salir_Click);
            // 
            // Bttn_LimpiarTodo
            // 
            this.Bttn_LimpiarTodo.Location = new System.Drawing.Point(702, 558);
            this.Bttn_LimpiarTodo.Name = "Bttn_LimpiarTodo";
            this.Bttn_LimpiarTodo.Size = new System.Drawing.Size(238, 99);
            this.Bttn_LimpiarTodo.TabIndex = 19;
            this.Bttn_LimpiarTodo.Text = "Limpiar";
            this.Bttn_LimpiarTodo.UseVisualStyleBackColor = true;
            this.Bttn_LimpiarTodo.Click += new System.EventHandler(this.Bttn_LimpiarTodo_Click);
            // 
            // DVG_MuesCredito
            // 
            this.DVG_MuesCredito.Controls.Add(this.Pest2_Grupo_Muestra);
            this.DVG_MuesCredito.Controls.Add(this.Pest2_Grupo_Opciones);
            this.DVG_MuesCredito.Controls.Add(this.Pest2_Grupo_Cliente);
            this.DVG_MuesCredito.Location = new System.Drawing.Point(4, 25);
            this.DVG_MuesCredito.Name = "DVG_MuesCredito";
            this.DVG_MuesCredito.Padding = new System.Windows.Forms.Padding(3);
            this.DVG_MuesCredito.Size = new System.Drawing.Size(880, 494);
            this.DVG_MuesCredito.TabIndex = 1;
            this.DVG_MuesCredito.Text = "Muestra de Transaciones Vencidas";
            this.DVG_MuesCredito.UseVisualStyleBackColor = true;
            this.DVG_MuesCredito.Click += new System.EventHandler(this.DVG_MuesCredito_Click);
            // 
            // DVG_RePago
            // 
            this.DVG_RePago.Controls.Add(this.Pest1_Txt_NombreEmpleado);
            this.DVG_RePago.Controls.Add(this.Pest1_DATE_FechaActual);
            this.DVG_RePago.Controls.Add(this.Pest1_Grupo_FiltroBusqueda);
            this.DVG_RePago.Controls.Add(this.Pest1_Grupo_Factura);
            this.DVG_RePago.Controls.Add(this.Pest1_DGV_DatosFactura);
            this.DVG_RePago.Location = new System.Drawing.Point(4, 25);
            this.DVG_RePago.Name = "DVG_RePago";
            this.DVG_RePago.Padding = new System.Windows.Forms.Padding(3);
            this.DVG_RePago.Size = new System.Drawing.Size(880, 494);
            this.DVG_RePago.TabIndex = 0;
            this.DVG_RePago.Text = "Realizar Pago";
            this.DVG_RePago.UseVisualStyleBackColor = true;
            // 
            // Pest1_Txt_NombreEmpleado
            // 
            this.Pest1_Txt_NombreEmpleado.Enabled = false;
            this.Pest1_Txt_NombreEmpleado.Location = new System.Drawing.Point(16, 60);
            this.Pest1_Txt_NombreEmpleado.Name = "Pest1_Txt_NombreEmpleado";
            this.Pest1_Txt_NombreEmpleado.Size = new System.Drawing.Size(294, 22);
            this.Pest1_Txt_NombreEmpleado.TabIndex = 18;
            // 
            // Pest1_DATE_FechaActual
            // 
            this.Pest1_DATE_FechaActual.Enabled = false;
            this.Pest1_DATE_FechaActual.Location = new System.Drawing.Point(16, 32);
            this.Pest1_DATE_FechaActual.Name = "Pest1_DATE_FechaActual";
            this.Pest1_DATE_FechaActual.Size = new System.Drawing.Size(294, 22);
            this.Pest1_DATE_FechaActual.TabIndex = 17;
            // 
            // Pest1_Grupo_FiltroBusqueda
            // 
            this.Pest1_Grupo_FiltroBusqueda.Controls.Add(this.label8);
            this.Pest1_Grupo_FiltroBusqueda.Controls.Add(this.label5);
            this.Pest1_Grupo_FiltroBusqueda.Controls.Add(this.Pest1_ComBox_MuestDatos);
            this.Pest1_Grupo_FiltroBusqueda.Controls.Add(this.Pest1_Txt_Filtro);
            this.Pest1_Grupo_FiltroBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest1_Grupo_FiltroBusqueda.Location = new System.Drawing.Point(411, 14);
            this.Pest1_Grupo_FiltroBusqueda.Name = "Pest1_Grupo_FiltroBusqueda";
            this.Pest1_Grupo_FiltroBusqueda.Size = new System.Drawing.Size(453, 93);
            this.Pest1_Grupo_FiltroBusqueda.TabIndex = 16;
            this.Pest1_Grupo_FiltroBusqueda.TabStop = false;
            this.Pest1_Grupo_FiltroBusqueda.Text = "Busqueda de Cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 30);
            this.label8.TabIndex = 17;
            this.label8.Text = "Informacion del \r\nCliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Filtro de Busqueda";
            // 
            // Pest1_ComBox_MuestDatos
            // 
            this.Pest1_ComBox_MuestDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Pest1_ComBox_MuestDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest1_ComBox_MuestDatos.FormattingEnabled = true;
            this.Pest1_ComBox_MuestDatos.Location = new System.Drawing.Point(169, 58);
            this.Pest1_ComBox_MuestDatos.Name = "Pest1_ComBox_MuestDatos";
            this.Pest1_ComBox_MuestDatos.Size = new System.Drawing.Size(278, 23);
            this.Pest1_ComBox_MuestDatos.TabIndex = 15;
            this.Pest1_ComBox_MuestDatos.SelectedIndexChanged += new System.EventHandler(this.Pest1_ComBox_MuestDatos_SelectedIndexChanged);
            // 
            // Pest1_Txt_Filtro
            // 
            this.Pest1_Txt_Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest1_Txt_Filtro.Location = new System.Drawing.Point(169, 26);
            this.Pest1_Txt_Filtro.MaxLength = 45;
            this.Pest1_Txt_Filtro.Name = "Pest1_Txt_Filtro";
            this.Pest1_Txt_Filtro.Size = new System.Drawing.Size(172, 21);
            this.Pest1_Txt_Filtro.TabIndex = 15;
            this.Pest1_Txt_Filtro.TextChanged += new System.EventHandler(this.Pest1_Txt_Filtro_TextChanged);
            this.Pest1_Txt_Filtro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest1_Txt_Filtro_KeyPress);
            // 
            // Pest1_Grupo_Factura
            // 
            this.Pest1_Grupo_Factura.Controls.Add(this.Pest1_Txt_MontoResidual);
            this.Pest1_Grupo_Factura.Controls.Add(this.Pest1_Txt_MontoOriginal);
            this.Pest1_Grupo_Factura.Controls.Add(this.Pest1_Txt_NFactura);
            this.Pest1_Grupo_Factura.Controls.Add(this.Pest1_Txt_NTransacion);
            this.Pest1_Grupo_Factura.Controls.Add(this.label7);
            this.Pest1_Grupo_Factura.Controls.Add(this.label6);
            this.Pest1_Grupo_Factura.Controls.Add(this.label4);
            this.Pest1_Grupo_Factura.Controls.Add(this.label3);
            this.Pest1_Grupo_Factura.Controls.Add(this.Pest1_Bttn_Limpiar);
            this.Pest1_Grupo_Factura.Controls.Add(this.Pest1_Bttn_RealizarPag);
            this.Pest1_Grupo_Factura.Controls.Add(this.label2);
            this.Pest1_Grupo_Factura.Controls.Add(this.Pest1_Txt_MontAPagar);
            this.Pest1_Grupo_Factura.Controls.Add(this.label1);
            this.Pest1_Grupo_Factura.Controls.Add(this.Pest1_ComBox_MetodoPago);
            this.Pest1_Grupo_Factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest1_Grupo_Factura.Location = new System.Drawing.Point(16, 113);
            this.Pest1_Grupo_Factura.Name = "Pest1_Grupo_Factura";
            this.Pest1_Grupo_Factura.Size = new System.Drawing.Size(848, 116);
            this.Pest1_Grupo_Factura.TabIndex = 15;
            this.Pest1_Grupo_Factura.TabStop = false;
            this.Pest1_Grupo_Factura.Text = "Datos de la Factura";
            // 
            // Pest1_Txt_MontoResidual
            // 
            this.Pest1_Txt_MontoResidual.Enabled = false;
            this.Pest1_Txt_MontoResidual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest1_Txt_MontoResidual.Location = new System.Drawing.Point(326, 68);
            this.Pest1_Txt_MontoResidual.Name = "Pest1_Txt_MontoResidual";
            this.Pest1_Txt_MontoResidual.Size = new System.Drawing.Size(113, 21);
            this.Pest1_Txt_MontoResidual.TabIndex = 14;
            // 
            // Pest1_Txt_MontoOriginal
            // 
            this.Pest1_Txt_MontoOriginal.Enabled = false;
            this.Pest1_Txt_MontoOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest1_Txt_MontoOriginal.Location = new System.Drawing.Point(326, 32);
            this.Pest1_Txt_MontoOriginal.Name = "Pest1_Txt_MontoOriginal";
            this.Pest1_Txt_MontoOriginal.Size = new System.Drawing.Size(113, 21);
            this.Pest1_Txt_MontoOriginal.TabIndex = 13;
            // 
            // Pest1_Txt_NFactura
            // 
            this.Pest1_Txt_NFactura.Enabled = false;
            this.Pest1_Txt_NFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest1_Txt_NFactura.Location = new System.Drawing.Point(90, 69);
            this.Pest1_Txt_NFactura.Name = "Pest1_Txt_NFactura";
            this.Pest1_Txt_NFactura.Size = new System.Drawing.Size(139, 21);
            this.Pest1_Txt_NFactura.TabIndex = 12;
            // 
            // Pest1_Txt_NTransacion
            // 
            this.Pest1_Txt_NTransacion.Enabled = false;
            this.Pest1_Txt_NTransacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest1_Txt_NTransacion.Location = new System.Drawing.Point(90, 33);
            this.Pest1_Txt_NTransacion.Name = "Pest1_Txt_NTransacion";
            this.Pest1_Txt_NTransacion.Size = new System.Drawing.Size(139, 21);
            this.Pest1_Txt_NTransacion.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 30);
            this.label7.TabIndex = 10;
            this.label7.Text = "No. de \r\nTransacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "No. de \r\nFactura\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Monto \r\nResidual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Monto \r\nOrigina";
            // 
            // Pest1_Bttn_Limpiar
            // 
            this.Pest1_Bttn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest1_Bttn_Limpiar.Location = new System.Drawing.Point(710, 63);
            this.Pest1_Bttn_Limpiar.Name = "Pest1_Bttn_Limpiar";
            this.Pest1_Bttn_Limpiar.Size = new System.Drawing.Size(118, 39);
            this.Pest1_Bttn_Limpiar.TabIndex = 5;
            this.Pest1_Bttn_Limpiar.Text = "Limpiar";
            this.Pest1_Bttn_Limpiar.UseVisualStyleBackColor = true;
            this.Pest1_Bttn_Limpiar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Pest1_Bttn_RealizarPag
            // 
            this.Pest1_Bttn_RealizarPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest1_Bttn_RealizarPag.Location = new System.Drawing.Point(710, 18);
            this.Pest1_Bttn_RealizarPag.Name = "Pest1_Bttn_RealizarPag";
            this.Pest1_Bttn_RealizarPag.Size = new System.Drawing.Size(118, 39);
            this.Pest1_Bttn_RealizarPag.TabIndex = 4;
            this.Pest1_Bttn_RealizarPag.Text = "Realizar Pago";
            this.Pest1_Bttn_RealizarPag.UseVisualStyleBackColor = true;
            this.Pest1_Bttn_RealizarPag.Click += new System.EventHandler(this.Pest1_Bttn_RealizarPag_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monto a \r\nPagar";
            // 
            // Pest1_Txt_MontAPagar
            // 
            this.Pest1_Txt_MontAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest1_Txt_MontAPagar.Location = new System.Drawing.Point(536, 68);
            this.Pest1_Txt_MontAPagar.MaxLength = 7;
            this.Pest1_Txt_MontAPagar.Name = "Pest1_Txt_MontAPagar";
            this.Pest1_Txt_MontAPagar.Size = new System.Drawing.Size(147, 21);
            this.Pest1_Txt_MontAPagar.TabIndex = 2;
            this.Pest1_Txt_MontAPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest1_Txt_MontAPagar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Metodo de\r\n Pago";
            // 
            // Pest1_ComBox_MetodoPago
            // 
            this.Pest1_ComBox_MetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Pest1_ComBox_MetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest1_ComBox_MetodoPago.FormattingEnabled = true;
            this.Pest1_ComBox_MetodoPago.Location = new System.Drawing.Point(536, 25);
            this.Pest1_ComBox_MetodoPago.Name = "Pest1_ComBox_MetodoPago";
            this.Pest1_ComBox_MetodoPago.Size = new System.Drawing.Size(147, 23);
            this.Pest1_ComBox_MetodoPago.TabIndex = 0;
            // 
            // Pest1_DGV_DatosFactura
            // 
            this.Pest1_DGV_DatosFactura.AllowUserToAddRows = false;
            this.Pest1_DGV_DatosFactura.AllowUserToDeleteRows = false;
            this.Pest1_DGV_DatosFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Pest1_DGV_DatosFactura.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pest1_DGV_DatosFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pest1_DGV_DatosFactura.Location = new System.Drawing.Point(16, 248);
            this.Pest1_DGV_DatosFactura.Name = "Pest1_DGV_DatosFactura";
            this.Pest1_DGV_DatosFactura.ReadOnly = true;
            this.Pest1_DGV_DatosFactura.Size = new System.Drawing.Size(848, 228);
            this.Pest1_DGV_DatosFactura.TabIndex = 14;
            this.Pest1_DGV_DatosFactura.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Pest1_DGV_DatosFactura_CellContentDoubleClick);
            this.Pest1_DGV_DatosFactura.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Pest1_DGV_DatosFactura_CellDoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DVG_RePago);
            this.tabControl1.Controls.Add(this.DVG_MuesCredito);
            this.tabControl1.Location = new System.Drawing.Point(18, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(888, 523);
            this.tabControl1.TabIndex = 24;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Pest2_Grupo_Cliente
            // 
            this.Pest2_Grupo_Cliente.Controls.Add(this.label10);
            this.Pest2_Grupo_Cliente.Controls.Add(this.Pest2_Txt_FiltroNombre);
            this.Pest2_Grupo_Cliente.Controls.Add(this.Pest2_ComBo_Muestra);
            this.Pest2_Grupo_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest2_Grupo_Cliente.Location = new System.Drawing.Point(186, 16);
            this.Pest2_Grupo_Cliente.Name = "Pest2_Grupo_Cliente";
            this.Pest2_Grupo_Cliente.Size = new System.Drawing.Size(673, 78);
            this.Pest2_Grupo_Cliente.TabIndex = 17;
            this.Pest2_Grupo_Cliente.TabStop = false;
            this.Pest2_Grupo_Cliente.Text = "Busqueda de Cliente";
            this.Pest2_Grupo_Cliente.Enter += new System.EventHandler(this.Pest2_Grupo_Cliente_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Filtro de Busqueda";
            // 
            // Pest2_ComBo_Muestra
            // 
            this.Pest2_ComBo_Muestra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Pest2_ComBo_Muestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest2_ComBo_Muestra.FormattingEnabled = true;
            this.Pest2_ComBo_Muestra.Location = new System.Drawing.Point(349, 29);
            this.Pest2_ComBo_Muestra.Name = "Pest2_ComBo_Muestra";
            this.Pest2_ComBo_Muestra.Size = new System.Drawing.Size(304, 23);
            this.Pest2_ComBo_Muestra.TabIndex = 15;
            this.Pest2_ComBo_Muestra.SelectedIndexChanged += new System.EventHandler(this.Pest2_ComBo_Muestra_SelectedIndexChanged);
            // 
            // Pest2_Txt_FiltroNombre
            // 
            this.Pest2_Txt_FiltroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest2_Txt_FiltroNombre.Location = new System.Drawing.Point(154, 31);
            this.Pest2_Txt_FiltroNombre.MaxLength = 45;
            this.Pest2_Txt_FiltroNombre.Name = "Pest2_Txt_FiltroNombre";
            this.Pest2_Txt_FiltroNombre.Size = new System.Drawing.Size(189, 21);
            this.Pest2_Txt_FiltroNombre.TabIndex = 15;
            this.Pest2_Txt_FiltroNombre.TextChanged += new System.EventHandler(this.Pest2_Txt_FiltroNombre_TextChanged);
            this.Pest2_Txt_FiltroNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest2_Txt_FiltroNombre_KeyPress);
            // 
            // Pest2_Grupo_Opciones
            // 
            this.Pest2_Grupo_Opciones.Controls.Add(this.Pest2_Radio_FilPorClie);
            this.Pest2_Grupo_Opciones.Controls.Add(this.Pest2_Radio_Todos);
            this.Pest2_Grupo_Opciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest2_Grupo_Opciones.Location = new System.Drawing.Point(18, 16);
            this.Pest2_Grupo_Opciones.Name = "Pest2_Grupo_Opciones";
            this.Pest2_Grupo_Opciones.Size = new System.Drawing.Size(162, 78);
            this.Pest2_Grupo_Opciones.TabIndex = 18;
            this.Pest2_Grupo_Opciones.TabStop = false;
            this.Pest2_Grupo_Opciones.Text = "Opciones";
            // 
            // Pest2_Grupo_Muestra
            // 
            this.Pest2_Grupo_Muestra.Controls.Add(this.label9);
            this.Pest2_Grupo_Muestra.Controls.Add(this.Pest2_Cod_Trans);
            this.Pest2_Grupo_Muestra.Controls.Add(this.Pest2_Bttn_VerDetalle);
            this.Pest2_Grupo_Muestra.Controls.Add(this.Pest2_Bttn_AplicarMora);
            this.Pest2_Grupo_Muestra.Controls.Add(this.Pest2_DGV_MuestraDatos);
            this.Pest2_Grupo_Muestra.Location = new System.Drawing.Point(18, 111);
            this.Pest2_Grupo_Muestra.Name = "Pest2_Grupo_Muestra";
            this.Pest2_Grupo_Muestra.Size = new System.Drawing.Size(841, 361);
            this.Pest2_Grupo_Muestra.TabIndex = 19;
            this.Pest2_Grupo_Muestra.TabStop = false;
            this.Pest2_Grupo_Muestra.Text = "Muestra de transaciones al credito";
            this.Pest2_Grupo_Muestra.Enter += new System.EventHandler(this.Pest2_Grupo_Muestra_Enter);
            // 
            // Pest2_DGV_MuestraDatos
            // 
            this.Pest2_DGV_MuestraDatos.AllowUserToAddRows = false;
            this.Pest2_DGV_MuestraDatos.AllowUserToDeleteRows = false;
            this.Pest2_DGV_MuestraDatos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pest2_DGV_MuestraDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pest2_DGV_MuestraDatos.Location = new System.Drawing.Point(19, 73);
            this.Pest2_DGV_MuestraDatos.Name = "Pest2_DGV_MuestraDatos";
            this.Pest2_DGV_MuestraDatos.ReadOnly = true;
            this.Pest2_DGV_MuestraDatos.Size = new System.Drawing.Size(802, 269);
            this.Pest2_DGV_MuestraDatos.TabIndex = 0;
            this.Pest2_DGV_MuestraDatos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Pest2_DGV_MuestraDatos_CellContentDoubleClick);
            this.Pest2_DGV_MuestraDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Pest2_DGV_MuestraDatos_CellDoubleClick);
            // 
            // Pest2_Bttn_AplicarMora
            // 
            this.Pest2_Bttn_AplicarMora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest2_Bttn_AplicarMora.Location = new System.Drawing.Point(685, 21);
            this.Pest2_Bttn_AplicarMora.Name = "Pest2_Bttn_AplicarMora";
            this.Pest2_Bttn_AplicarMora.Size = new System.Drawing.Size(136, 45);
            this.Pest2_Bttn_AplicarMora.TabIndex = 1;
            this.Pest2_Bttn_AplicarMora.Text = "Aplicar Mora";
            this.Pest2_Bttn_AplicarMora.UseVisualStyleBackColor = true;
            this.Pest2_Bttn_AplicarMora.Click += new System.EventHandler(this.Pest2_Bttn_AplicarMora_Click);
            // 
            // Pest2_Bttn_VerDetalle
            // 
            this.Pest2_Bttn_VerDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest2_Bttn_VerDetalle.Location = new System.Drawing.Point(533, 22);
            this.Pest2_Bttn_VerDetalle.Name = "Pest2_Bttn_VerDetalle";
            this.Pest2_Bttn_VerDetalle.Size = new System.Drawing.Size(136, 45);
            this.Pest2_Bttn_VerDetalle.TabIndex = 2;
            this.Pest2_Bttn_VerDetalle.Text = "Ver detalles";
            this.Pest2_Bttn_VerDetalle.UseVisualStyleBackColor = true;
            this.Pest2_Bttn_VerDetalle.Click += new System.EventHandler(this.Pest2_Bttn_VerDetalle_Click);
            // 
            // Pest2_Radio_Todos
            // 
            this.Pest2_Radio_Todos.AutoSize = true;
            this.Pest2_Radio_Todos.Location = new System.Drawing.Point(16, 23);
            this.Pest2_Radio_Todos.Name = "Pest2_Radio_Todos";
            this.Pest2_Radio_Todos.Size = new System.Drawing.Size(123, 17);
            this.Pest2_Radio_Todos.TabIndex = 3;
            this.Pest2_Radio_Todos.TabStop = true;
            this.Pest2_Radio_Todos.Text = "Muestra de todos";
            this.Pest2_Radio_Todos.UseVisualStyleBackColor = true;
            this.Pest2_Radio_Todos.CheckedChanged += new System.EventHandler(this.Pest2_Radio_Todos_CheckedChanged);
            // 
            // Pest2_Radio_FilPorClie
            // 
            this.Pest2_Radio_FilPorClie.AutoSize = true;
            this.Pest2_Radio_FilPorClie.Location = new System.Drawing.Point(16, 46);
            this.Pest2_Radio_FilPorClie.Name = "Pest2_Radio_FilPorClie";
            this.Pest2_Radio_FilPorClie.Size = new System.Drawing.Size(121, 17);
            this.Pest2_Radio_FilPorClie.TabIndex = 4;
            this.Pest2_Radio_FilPorClie.TabStop = true;
            this.Pest2_Radio_FilPorClie.Text = "Filtrar por cliente";
            this.Pest2_Radio_FilPorClie.UseVisualStyleBackColor = true;
            this.Pest2_Radio_FilPorClie.CheckedChanged += new System.EventHandler(this.Pest2_Radio_FilPorClie_CheckedChanged);
            // 
            // Pest2_Cod_Trans
            // 
            this.Pest2_Cod_Trans.Enabled = false;
            this.Pest2_Cod_Trans.Location = new System.Drawing.Point(336, 34);
            this.Pest2_Cod_Trans.Name = "Pest2_Cod_Trans";
            this.Pest2_Cod_Trans.Size = new System.Drawing.Size(175, 22);
            this.Pest2_Cod_Trans.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Cod. Transacion";
            // 
            // Form_Credito_CobroCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(925, 650);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Bttn_LimpiarTodo);
            this.Controls.Add(this.Bttn_Salir);
            this.Controls.Add(this.Bttn_Ayuda);
            this.Controls.Add(this.Bttn_MuestraClientes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Credito_CobroCredito";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobro de Credito a Cliente";
            this.Load += new System.EventHandler(this.Form_Credito_CobroCredito_Load);
            this.DVG_MuesCredito.ResumeLayout(false);
            this.DVG_RePago.ResumeLayout(false);
            this.DVG_RePago.PerformLayout();
            this.Pest1_Grupo_FiltroBusqueda.ResumeLayout(false);
            this.Pest1_Grupo_FiltroBusqueda.PerformLayout();
            this.Pest1_Grupo_Factura.ResumeLayout(false);
            this.Pest1_Grupo_Factura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pest1_DGV_DatosFactura)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.Pest2_Grupo_Cliente.ResumeLayout(false);
            this.Pest2_Grupo_Cliente.PerformLayout();
            this.Pest2_Grupo_Opciones.ResumeLayout(false);
            this.Pest2_Grupo_Opciones.PerformLayout();
            this.Pest2_Grupo_Muestra.ResumeLayout(false);
            this.Pest2_Grupo_Muestra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pest2_DGV_MuestraDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Bttn_MuestraClientes;
        private System.Windows.Forms.Button Bttn_Ayuda;
        private System.Windows.Forms.Button Bttn_Salir;
        private System.Windows.Forms.Button Bttn_LimpiarTodo;
        private System.Windows.Forms.TabPage DVG_MuesCredito;
        private System.Windows.Forms.TabPage DVG_RePago;
        private System.Windows.Forms.GroupBox Pest1_Grupo_FiltroBusqueda;
        private System.Windows.Forms.GroupBox Pest1_Grupo_Factura;
        private System.Windows.Forms.Button Pest1_Bttn_Limpiar;
        private System.Windows.Forms.Button Pest1_Bttn_RealizarPag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pest1_Txt_MontAPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Pest1_ComBox_MetodoPago;
        private System.Windows.Forms.DataGridView Pest1_DGV_DatosFactura;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DateTimePicker Pest1_DATE_FechaActual;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Pest1_ComBox_MuestDatos;
        private System.Windows.Forms.TextBox Pest1_Txt_Filtro;
        private System.Windows.Forms.TextBox Pest1_Txt_MontoResidual;
        private System.Windows.Forms.TextBox Pest1_Txt_MontoOriginal;
        private System.Windows.Forms.TextBox Pest1_Txt_NFactura;
        private System.Windows.Forms.TextBox Pest1_Txt_NTransacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Pest1_Txt_NombreEmpleado;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox Pest2_Grupo_Muestra;
        private System.Windows.Forms.DataGridView Pest2_DGV_MuestraDatos;
        private System.Windows.Forms.GroupBox Pest2_Grupo_Opciones;
        private System.Windows.Forms.GroupBox Pest2_Grupo_Cliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Pest2_ComBo_Muestra;
        private System.Windows.Forms.TextBox Pest2_Txt_FiltroNombre;
        private System.Windows.Forms.Button Pest2_Bttn_VerDetalle;
        private System.Windows.Forms.Button Pest2_Bttn_AplicarMora;
        private System.Windows.Forms.RadioButton Pest2_Radio_FilPorClie;
        private System.Windows.Forms.RadioButton Pest2_Radio_Todos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Pest2_Cod_Trans;
    }
}
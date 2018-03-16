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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_CodigoDeRecibo = new System.Windows.Forms.TextBox();
            this.Txt_NombreEmpleado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Check_Correo = new System.Windows.Forms.CheckBox();
            this.Check_Impresion = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_InformacionClienteGenerado = new System.Windows.Forms.TextBox();
            this.Txt_Filtros_Cliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Check_RepresentaEmpresa = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DataGriew_DatosFactura = new System.Windows.Forms.DataGridView();
            this.DG_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_FechaRealizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_TotalPorCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_MontoAPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.Bttn_LimpiaLista = new System.Windows.Forms.Button();
            this.Bttn_Ayuda = new System.Windows.Forms.Button();
            this.Bttn_Salir = new System.Windows.Forms.Button();
            this.Bttn_LimpiarTodo = new System.Windows.Forms.Button();
            this.Bttn_Guardar = new System.Windows.Forms.Button();
            this.Bttn_AgregarADataGriew = new System.Windows.Forms.Button();
            this.Bttn_LimpiarDeSeleccion = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Txt_TotalAPagarPorFactura = new System.Windows.Forms.TextBox();
            this.Txt_Busqueda_MontoTOTALFactura = new System.Windows.Forms.TextBox();
            this.Txt_Busqueda_TotalCargos = new System.Windows.Forms.TextBox();
            this.Txt_Busqueda_FechaRealizacion = new System.Windows.Forms.TextBox();
            this.Txt_Buscar_MontoFactura = new System.Windows.Forms.TextBox();
            this.Txt_Busqueda_CodigoFactura = new System.Windows.Forms.TextBox();
            this.Txt_FechaRealizacion = new System.Windows.Forms.TextBox();
            this.Bttn_GenerarInformacion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriew_DatosFactura)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo de Recibo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del Empleado";
            // 
            // Txt_CodigoDeRecibo
            // 
            this.Txt_CodigoDeRecibo.Enabled = false;
            this.Txt_CodigoDeRecibo.Location = new System.Drawing.Point(182, 52);
            this.Txt_CodigoDeRecibo.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_CodigoDeRecibo.Name = "Txt_CodigoDeRecibo";
            this.Txt_CodigoDeRecibo.Size = new System.Drawing.Size(148, 22);
            this.Txt_CodigoDeRecibo.TabIndex = 3;
            // 
            // Txt_NombreEmpleado
            // 
            this.Txt_NombreEmpleado.Enabled = false;
            this.Txt_NombreEmpleado.Location = new System.Drawing.Point(182, 89);
            this.Txt_NombreEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_NombreEmpleado.Name = "Txt_NombreEmpleado";
            this.Txt_NombreEmpleado.Size = new System.Drawing.Size(148, 22);
            this.Txt_NombreEmpleado.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Check_Correo);
            this.groupBox1.Controls.Add(this.Check_Impresion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(346, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 79);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metodos de Salida de Factura";
            // 
            // Check_Correo
            // 
            this.Check_Correo.AutoSize = true;
            this.Check_Correo.Location = new System.Drawing.Point(99, 26);
            this.Check_Correo.Name = "Check_Correo";
            this.Check_Correo.Size = new System.Drawing.Size(74, 20);
            this.Check_Correo.TabIndex = 2;
            this.Check_Correo.Text = "Correo";
            this.Check_Correo.UseVisualStyleBackColor = true;
            // 
            // Check_Impresion
            // 
            this.Check_Impresion.AutoSize = true;
            this.Check_Impresion.Location = new System.Drawing.Point(99, 52);
            this.Check_Impresion.Name = "Check_Impresion";
            this.Check_Impresion.Size = new System.Drawing.Size(95, 20);
            this.Check_Impresion.TabIndex = 1;
            this.Check_Impresion.Text = "Impresion";
            this.Check_Impresion.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_InformacionClienteGenerado);
            this.groupBox2.Controls.Add(this.Txt_Filtros_Cliente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Check_RepresentaEmpresa);
            this.groupBox2.Location = new System.Drawing.Point(552, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 79);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // Txt_InformacionClienteGenerado
            // 
            this.Txt_InformacionClienteGenerado.Enabled = false;
            this.Txt_InformacionClienteGenerado.Location = new System.Drawing.Point(163, 47);
            this.Txt_InformacionClienteGenerado.Name = "Txt_InformacionClienteGenerado";
            this.Txt_InformacionClienteGenerado.Size = new System.Drawing.Size(129, 22);
            this.Txt_InformacionClienteGenerado.TabIndex = 6;
            // 
            // Txt_Filtros_Cliente
            // 
            this.Txt_Filtros_Cliente.Location = new System.Drawing.Point(58, 47);
            this.Txt_Filtros_Cliente.Name = "Txt_Filtros_Cliente";
            this.Txt_Filtros_Cliente.Size = new System.Drawing.Size(99, 22);
            this.Txt_Filtros_Cliente.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            // 
            // Check_RepresentaEmpresa
            // 
            this.Check_RepresentaEmpresa.AutoSize = true;
            this.Check_RepresentaEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_RepresentaEmpresa.Location = new System.Drawing.Point(6, 20);
            this.Check_RepresentaEmpresa.Name = "Check_RepresentaEmpresa";
            this.Check_RepresentaEmpresa.Size = new System.Drawing.Size(168, 17);
            this.Check_RepresentaEmpresa.TabIndex = 3;
            this.Check_RepresentaEmpresa.Text = "Representa una Empresa";
            this.Check_RepresentaEmpresa.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Codigo de Factura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha de Realizacion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(513, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Monto a Pagar\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(263, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Total por Cargos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(503, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Monto Total por Factura";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(267, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Monto por Factura";
            // 
            // DataGriew_DatosFactura
            // 
            this.DataGriew_DatosFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGriew_DatosFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGriew_DatosFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DG_Codigo,
            this.DG_FechaRealizacion,
            this.DG_Monto,
            this.DG_TotalPorCargo,
            this.DG_MontoTotal,
            this.DG_MontoAPagar,
            this.DG_Estado});
            this.DataGriew_DatosFactura.Location = new System.Drawing.Point(17, 282);
            this.DataGriew_DatosFactura.Name = "DataGriew_DatosFactura";
            this.DataGriew_DatosFactura.Size = new System.Drawing.Size(833, 255);
            this.DataGriew_DatosFactura.TabIndex = 14;
            // 
            // DG_Codigo
            // 
            this.DG_Codigo.HeaderText = "Codigo";
            this.DG_Codigo.Name = "DG_Codigo";
            // 
            // DG_FechaRealizacion
            // 
            this.DG_FechaRealizacion.HeaderText = "Fecha de Realizacion";
            this.DG_FechaRealizacion.Name = "DG_FechaRealizacion";
            this.DG_FechaRealizacion.ReadOnly = true;
            // 
            // DG_Monto
            // 
            this.DG_Monto.HeaderText = "Monto de Factura";
            this.DG_Monto.Name = "DG_Monto";
            this.DG_Monto.ReadOnly = true;
            // 
            // DG_TotalPorCargo
            // 
            this.DG_TotalPorCargo.HeaderText = "Total por Cargo";
            this.DG_TotalPorCargo.Name = "DG_TotalPorCargo";
            this.DG_TotalPorCargo.ReadOnly = true;
            // 
            // DG_MontoTotal
            // 
            this.DG_MontoTotal.HeaderText = "Monto Total";
            this.DG_MontoTotal.Name = "DG_MontoTotal";
            this.DG_MontoTotal.ReadOnly = true;
            // 
            // DG_MontoAPagar
            // 
            this.DG_MontoAPagar.HeaderText = "Monto a Pagar";
            this.DG_MontoAPagar.Name = "DG_MontoAPagar";
            this.DG_MontoAPagar.ReadOnly = true;
            // 
            // DG_Estado
            // 
            this.DG_Estado.HeaderText = "Estado";
            this.DG_Estado.Name = "DG_Estado";
            this.DG_Estado.ReadOnly = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(685, 550);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Total a Pagar: Lp. 0.00";
            // 
            // Bttn_LimpiaLista
            // 
            this.Bttn_LimpiaLista.Location = new System.Drawing.Point(173, 586);
            this.Bttn_LimpiaLista.Name = "Bttn_LimpiaLista";
            this.Bttn_LimpiaLista.Size = new System.Drawing.Size(167, 60);
            this.Bttn_LimpiaLista.TabIndex = 16;
            this.Bttn_LimpiaLista.Text = "Limpiar de Lista";
            this.Bttn_LimpiaLista.UseVisualStyleBackColor = true;
            // 
            // Bttn_Ayuda
            // 
            this.Bttn_Ayuda.Location = new System.Drawing.Point(520, 586);
            this.Bttn_Ayuda.Name = "Bttn_Ayuda";
            this.Bttn_Ayuda.Size = new System.Drawing.Size(167, 60);
            this.Bttn_Ayuda.TabIndex = 17;
            this.Bttn_Ayuda.Text = "Ayuda";
            this.Bttn_Ayuda.UseVisualStyleBackColor = true;
            this.Bttn_Ayuda.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bttn_Salir
            // 
            this.Bttn_Salir.Location = new System.Drawing.Point(0, 586);
            this.Bttn_Salir.Name = "Bttn_Salir";
            this.Bttn_Salir.Size = new System.Drawing.Size(167, 60);
            this.Bttn_Salir.TabIndex = 18;
            this.Bttn_Salir.Text = "Salir";
            this.Bttn_Salir.UseVisualStyleBackColor = true;
            this.Bttn_Salir.Click += new System.EventHandler(this.Bttn_Salir_Click);
            // 
            // Bttn_LimpiarTodo
            // 
            this.Bttn_LimpiarTodo.Location = new System.Drawing.Point(693, 586);
            this.Bttn_LimpiarTodo.Name = "Bttn_LimpiarTodo";
            this.Bttn_LimpiarTodo.Size = new System.Drawing.Size(167, 60);
            this.Bttn_LimpiarTodo.TabIndex = 19;
            this.Bttn_LimpiarTodo.Text = "Limpiar";
            this.Bttn_LimpiarTodo.UseVisualStyleBackColor = true;
            // 
            // Bttn_Guardar
            // 
            this.Bttn_Guardar.Location = new System.Drawing.Point(347, 586);
            this.Bttn_Guardar.Name = "Bttn_Guardar";
            this.Bttn_Guardar.Size = new System.Drawing.Size(167, 60);
            this.Bttn_Guardar.TabIndex = 20;
            this.Bttn_Guardar.Text = "Guardar";
            this.Bttn_Guardar.UseVisualStyleBackColor = true;
            // 
            // Bttn_AgregarADataGriew
            // 
            this.Bttn_AgregarADataGriew.Location = new System.Drawing.Point(138, 103);
            this.Bttn_AgregarADataGriew.Name = "Bttn_AgregarADataGriew";
            this.Bttn_AgregarADataGriew.Size = new System.Drawing.Size(110, 33);
            this.Bttn_AgregarADataGriew.TabIndex = 21;
            this.Bttn_AgregarADataGriew.Text = "Agregar";
            this.Bttn_AgregarADataGriew.UseVisualStyleBackColor = true;
            // 
            // Bttn_LimpiarDeSeleccion
            // 
            this.Bttn_LimpiarDeSeleccion.Location = new System.Drawing.Point(266, 103);
            this.Bttn_LimpiarDeSeleccion.Name = "Bttn_LimpiarDeSeleccion";
            this.Bttn_LimpiarDeSeleccion.Size = new System.Drawing.Size(110, 33);
            this.Bttn_LimpiarDeSeleccion.TabIndex = 22;
            this.Bttn_LimpiarDeSeleccion.Text = "Limpiar";
            this.Bttn_LimpiarDeSeleccion.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Bttn_GenerarInformacion);
            this.groupBox3.Controls.Add(this.Txt_TotalAPagarPorFactura);
            this.groupBox3.Controls.Add(this.Bttn_AgregarADataGriew);
            this.groupBox3.Controls.Add(this.Bttn_LimpiarDeSeleccion);
            this.groupBox3.Controls.Add(this.Txt_Busqueda_MontoTOTALFactura);
            this.groupBox3.Controls.Add(this.Txt_Busqueda_TotalCargos);
            this.groupBox3.Controls.Add(this.Txt_Busqueda_FechaRealizacion);
            this.groupBox3.Controls.Add(this.Txt_Buscar_MontoFactura);
            this.groupBox3.Controls.Add(this.Txt_Busqueda_CodigoFactura);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(17, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(833, 142);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de Factura";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Txt_TotalAPagarPorFactura
            // 
            this.Txt_TotalAPagarPorFactura.Location = new System.Drawing.Point(663, 61);
            this.Txt_TotalAPagarPorFactura.Name = "Txt_TotalAPagarPorFactura";
            this.Txt_TotalAPagarPorFactura.Size = new System.Drawing.Size(133, 22);
            this.Txt_TotalAPagarPorFactura.TabIndex = 20;
            // 
            // Txt_Busqueda_MontoTOTALFactura
            // 
            this.Txt_Busqueda_MontoTOTALFactura.Enabled = false;
            this.Txt_Busqueda_MontoTOTALFactura.Location = new System.Drawing.Point(663, 35);
            this.Txt_Busqueda_MontoTOTALFactura.Name = "Txt_Busqueda_MontoTOTALFactura";
            this.Txt_Busqueda_MontoTOTALFactura.Size = new System.Drawing.Size(133, 22);
            this.Txt_Busqueda_MontoTOTALFactura.TabIndex = 19;
            // 
            // Txt_Busqueda_TotalCargos
            // 
            this.Txt_Busqueda_TotalCargos.Enabled = false;
            this.Txt_Busqueda_TotalCargos.Location = new System.Drawing.Point(384, 33);
            this.Txt_Busqueda_TotalCargos.Name = "Txt_Busqueda_TotalCargos";
            this.Txt_Busqueda_TotalCargos.Size = new System.Drawing.Size(113, 22);
            this.Txt_Busqueda_TotalCargos.TabIndex = 18;
            // 
            // Txt_Busqueda_FechaRealizacion
            // 
            this.Txt_Busqueda_FechaRealizacion.Enabled = false;
            this.Txt_Busqueda_FechaRealizacion.Location = new System.Drawing.Point(138, 61);
            this.Txt_Busqueda_FechaRealizacion.Name = "Txt_Busqueda_FechaRealizacion";
            this.Txt_Busqueda_FechaRealizacion.Size = new System.Drawing.Size(113, 22);
            this.Txt_Busqueda_FechaRealizacion.TabIndex = 17;
            // 
            // Txt_Buscar_MontoFactura
            // 
            this.Txt_Buscar_MontoFactura.Enabled = false;
            this.Txt_Buscar_MontoFactura.Location = new System.Drawing.Point(384, 61);
            this.Txt_Buscar_MontoFactura.Name = "Txt_Buscar_MontoFactura";
            this.Txt_Buscar_MontoFactura.Size = new System.Drawing.Size(113, 22);
            this.Txt_Buscar_MontoFactura.TabIndex = 16;
            // 
            // Txt_Busqueda_CodigoFactura
            // 
            this.Txt_Busqueda_CodigoFactura.Location = new System.Drawing.Point(138, 33);
            this.Txt_Busqueda_CodigoFactura.Name = "Txt_Busqueda_CodigoFactura";
            this.Txt_Busqueda_CodigoFactura.Size = new System.Drawing.Size(113, 22);
            this.Txt_Busqueda_CodigoFactura.TabIndex = 14;
            // 
            // Txt_FechaRealizacion
            // 
            this.Txt_FechaRealizacion.Enabled = false;
            this.Txt_FechaRealizacion.Location = new System.Drawing.Point(17, 13);
            this.Txt_FechaRealizacion.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_FechaRealizacion.Name = "Txt_FechaRealizacion";
            this.Txt_FechaRealizacion.Size = new System.Drawing.Size(148, 22);
            this.Txt_FechaRealizacion.TabIndex = 0;
            // 
            // Bttn_GenerarInformacion
            // 
            this.Bttn_GenerarInformacion.Location = new System.Drawing.Point(8, 103);
            this.Bttn_GenerarInformacion.Name = "Bttn_GenerarInformacion";
            this.Bttn_GenerarInformacion.Size = new System.Drawing.Size(110, 33);
            this.Bttn_GenerarInformacion.TabIndex = 23;
            this.Bttn_GenerarInformacion.Text = "Generar";
            this.Bttn_GenerarInformacion.UseVisualStyleBackColor = true;
            // 
            // Form_Credito_CobroCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(861, 649);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Bttn_Guardar);
            this.Controls.Add(this.Bttn_LimpiarTodo);
            this.Controls.Add(this.Bttn_Salir);
            this.Controls.Add(this.Bttn_Ayuda);
            this.Controls.Add(this.Bttn_LimpiaLista);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DataGriew_DatosFactura);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Txt_NombreEmpleado);
            this.Controls.Add(this.Txt_CodigoDeRecibo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_FechaRealizacion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Credito_CobroCredito";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Cobro de Credito a Cliente";
            this.Load += new System.EventHandler(this.Form_Credito_CobroCredito_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriew_DatosFactura)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_CodigoDeRecibo;
        private System.Windows.Forms.TextBox Txt_NombreEmpleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Check_Correo;
        private System.Windows.Forms.CheckBox Check_Impresion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_InformacionClienteGenerado;
        private System.Windows.Forms.TextBox Txt_Filtros_Cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Check_RepresentaEmpresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DataGriew_DatosFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_FechaRealizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_TotalPorCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_MontoAPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Estado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Bttn_LimpiaLista;
        private System.Windows.Forms.Button Bttn_Ayuda;
        private System.Windows.Forms.Button Bttn_Salir;
        private System.Windows.Forms.Button Bttn_LimpiarTodo;
        private System.Windows.Forms.Button Bttn_Guardar;
        private System.Windows.Forms.Button Bttn_AgregarADataGriew;
        private System.Windows.Forms.Button Bttn_LimpiarDeSeleccion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Txt_TotalAPagarPorFactura;
        private System.Windows.Forms.TextBox Txt_Busqueda_MontoTOTALFactura;
        private System.Windows.Forms.TextBox Txt_Busqueda_TotalCargos;
        private System.Windows.Forms.TextBox Txt_Busqueda_FechaRealizacion;
        private System.Windows.Forms.TextBox Txt_Buscar_MontoFactura;
        private System.Windows.Forms.TextBox Txt_Busqueda_CodigoFactura;
        private System.Windows.Forms.Button Bttn_GenerarInformacion;
        private System.Windows.Forms.TextBox Txt_FechaRealizacion;
    }
}
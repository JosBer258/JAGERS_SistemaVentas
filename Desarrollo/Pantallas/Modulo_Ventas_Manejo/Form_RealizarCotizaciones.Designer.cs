namespace Desarrollo.Pantallas.Modulo_Ventas_Manejo
{
    partial class Form_RealizarCotizaciones
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
            this.Label_Total = new System.Windows.Forms.Label();
            this.lb_Total = new System.Windows.Forms.Label();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_DescartarProducto = new System.Windows.Forms.Button();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gb_Cotizacion = new System.Windows.Forms.GroupBox();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Text_Modelo = new System.Windows.Forms.TextBox();
            this.Text_Marca = new System.Windows.Forms.TextBox();
            this.Text_Precio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_Descripcion = new System.Windows.Forms.Label();
            this.ComBox_DescripcionProducto = new System.Windows.Forms.ComboBox();
            this.lb_Nombre2 = new System.Windows.Forms.Label();
            this.txt_Nombre2 = new System.Windows.Forms.TextBox();
            this.gb_DatosCliente = new System.Windows.Forms.GroupBox();
            this.Check_RepresentarEmpresa = new System.Windows.Forms.CheckBox();
            this.Combo_NombreCliente = new System.Windows.Forms.ComboBox();
            this.lb_Nombre1 = new System.Windows.Forms.Label();
            this.txt_Nombre1 = new System.Windows.Forms.TextBox();
            this.lb_NombreEmpleado = new System.Windows.Forms.Label();
            this.Txt_NombreEmpleado = new System.Windows.Forms.TextBox();
            this.lb_FechaRealizacion = new System.Windows.Forms.Label();
            this.Date_Fecha = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Date_FechaLimite = new System.Windows.Forms.DateTimePicker();
            this.DataGrid_NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid_PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_Cotizacion.SuspendLayout();
            this.gb_DatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Total
            // 
            this.Label_Total.AutoSize = true;
            this.Label_Total.Location = new System.Drawing.Point(85, 537);
            this.Label_Total.Name = "Label_Total";
            this.Label_Total.Size = new System.Drawing.Size(32, 13);
            this.Label_Total.TabIndex = 49;
            this.Label_Total.Text = "0.00";
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Location = new System.Drawing.Point(17, 537);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(62, 13);
            this.lb_Total.TabIndex = 46;
            this.lb_Total.Text = "Total: Lp.";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(325, 584);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(168, 64);
            this.btn_Limpiar.TabIndex = 43;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(661, 584);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(154, 64);
            this.btn_Guardar.TabIndex = 42;
            this.btn_Guardar.Text = "Imprimir";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(488, 584);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(177, 64);
            this.btn_Salir.TabIndex = 41;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_DescartarProducto
            // 
            this.btn_DescartarProducto.Location = new System.Drawing.Point(159, 584);
            this.btn_DescartarProducto.Name = "btn_DescartarProducto";
            this.btn_DescartarProducto.Size = new System.Drawing.Size(168, 64);
            this.btn_DescartarProducto.TabIndex = 40;
            this.btn_DescartarProducto.Text = "Descartar Producto";
            this.btn_DescartarProducto.UseVisualStyleBackColor = true;
            this.btn_DescartarProducto.Click += new System.EventHandler(this.btn_DescartarProducto_Click);
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.Location = new System.Drawing.Point(-3, 584);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(168, 64);
            this.btn_Ayuda.TabIndex = 39;
            this.btn_Ayuda.Text = "Ayuda";
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGrid_NombreProducto,
            this.DataGrid_PrecioVenta,
            this.DG_Cantidad,
            this.DG_Total});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(13, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(788, 278);
            this.dataGridView1.TabIndex = 38;
            // 
            // gb_Cotizacion
            // 
            this.gb_Cotizacion.Controls.Add(this.Txt_Cantidad);
            this.gb_Cotizacion.Controls.Add(this.label1);
            this.gb_Cotizacion.Controls.Add(this.button1);
            this.gb_Cotizacion.Controls.Add(this.Text_Modelo);
            this.gb_Cotizacion.Controls.Add(this.Text_Marca);
            this.gb_Cotizacion.Controls.Add(this.Text_Precio);
            this.gb_Cotizacion.Controls.Add(this.label7);
            this.gb_Cotizacion.Controls.Add(this.btn_Agregar);
            this.gb_Cotizacion.Controls.Add(this.label6);
            this.gb_Cotizacion.Controls.Add(this.label5);
            this.gb_Cotizacion.Controls.Add(this.lb_Descripcion);
            this.gb_Cotizacion.Controls.Add(this.ComBox_DescripcionProducto);
            this.gb_Cotizacion.Controls.Add(this.lb_Nombre2);
            this.gb_Cotizacion.Controls.Add(this.txt_Nombre2);
            this.gb_Cotizacion.Location = new System.Drawing.Point(13, 136);
            this.gb_Cotizacion.Name = "gb_Cotizacion";
            this.gb_Cotizacion.Size = new System.Drawing.Size(786, 104);
            this.gb_Cotizacion.TabIndex = 37;
            this.gb_Cotizacion.TabStop = false;
            this.gb_Cotizacion.Text = "Cotizacion";
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Location = new System.Drawing.Point(466, 73);
            this.Txt_Cantidad.MaxLength = 5;
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(126, 20);
            this.Txt_Cantidad.TabIndex = 27;
            this.Txt_Cantidad.Text = "0";
            this.Txt_Cantidad.TextChanged += new System.EventHandler(this.Txt_Cantidad_TextChanged);
            this.Txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cantidad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Cantidad:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 41);
            this.button1.TabIndex = 25;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Text_Modelo
            // 
            this.Text_Modelo.Enabled = false;
            this.Text_Modelo.Location = new System.Drawing.Point(167, 71);
            this.Text_Modelo.Name = "Text_Modelo";
            this.Text_Modelo.Size = new System.Drawing.Size(194, 20);
            this.Text_Modelo.TabIndex = 24;
            // 
            // Text_Marca
            // 
            this.Text_Marca.Enabled = false;
            this.Text_Marca.Location = new System.Drawing.Point(466, 20);
            this.Text_Marca.Name = "Text_Marca";
            this.Text_Marca.Size = new System.Drawing.Size(126, 20);
            this.Text_Marca.TabIndex = 23;
            // 
            // Text_Precio
            // 
            this.Text_Precio.Enabled = false;
            this.Text_Precio.Location = new System.Drawing.Point(466, 47);
            this.Text_Precio.Name = "Text_Precio";
            this.Text_Precio.Size = new System.Drawing.Size(126, 20);
            this.Text_Precio.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Modelo:";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(648, 12);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(131, 42);
            this.btn_Agregar.TabIndex = 16;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Marca:\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Precio:\r\n";
            // 
            // lb_Descripcion
            // 
            this.lb_Descripcion.AutoSize = true;
            this.lb_Descripcion.Location = new System.Drawing.Point(48, 49);
            this.lb_Descripcion.Name = "lb_Descripcion";
            this.lb_Descripcion.Size = new System.Drawing.Size(78, 13);
            this.lb_Descripcion.TabIndex = 15;
            this.lb_Descripcion.Text = "Descripcion:";
            // 
            // ComBox_DescripcionProducto
            // 
            this.ComBox_DescripcionProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBox_DescripcionProducto.FormattingEnabled = true;
            this.ComBox_DescripcionProducto.Location = new System.Drawing.Point(167, 44);
            this.ComBox_DescripcionProducto.Name = "ComBox_DescripcionProducto";
            this.ComBox_DescripcionProducto.Size = new System.Drawing.Size(194, 21);
            this.ComBox_DescripcionProducto.TabIndex = 14;
            this.ComBox_DescripcionProducto.SelectedIndexChanged += new System.EventHandler(this.ComBox_DescripcionProducto_SelectedIndexChanged);
            // 
            // lb_Nombre2
            // 
            this.lb_Nombre2.AutoSize = true;
            this.lb_Nombre2.Location = new System.Drawing.Point(48, 23);
            this.lb_Nombre2.Name = "lb_Nombre2";
            this.lb_Nombre2.Size = new System.Drawing.Size(113, 13);
            this.lb_Nombre2.TabIndex = 5;
            this.lb_Nombre2.Text = "Filtro de Busqueda";
            // 
            // txt_Nombre2
            // 
            this.txt_Nombre2.Location = new System.Drawing.Point(167, 20);
            this.txt_Nombre2.MaxLength = 30;
            this.txt_Nombre2.Name = "txt_Nombre2";
            this.txt_Nombre2.Size = new System.Drawing.Size(194, 20);
            this.txt_Nombre2.TabIndex = 4;
            this.txt_Nombre2.TextChanged += new System.EventHandler(this.txt_Nombre2_TextChanged);
            this.txt_Nombre2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre2_KeyPress);
            // 
            // gb_DatosCliente
            // 
            this.gb_DatosCliente.Controls.Add(this.Check_RepresentarEmpresa);
            this.gb_DatosCliente.Controls.Add(this.Combo_NombreCliente);
            this.gb_DatosCliente.Controls.Add(this.lb_Nombre1);
            this.gb_DatosCliente.Controls.Add(this.txt_Nombre1);
            this.gb_DatosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DatosCliente.Location = new System.Drawing.Point(462, 15);
            this.gb_DatosCliente.Name = "gb_DatosCliente";
            this.gb_DatosCliente.Size = new System.Drawing.Size(339, 115);
            this.gb_DatosCliente.TabIndex = 36;
            this.gb_DatosCliente.TabStop = false;
            this.gb_DatosCliente.Text = "Datos del Cliente";
            // 
            // Check_RepresentarEmpresa
            // 
            this.Check_RepresentarEmpresa.AutoSize = true;
            this.Check_RepresentarEmpresa.Location = new System.Drawing.Point(48, 22);
            this.Check_RepresentarEmpresa.Name = "Check_RepresentarEmpresa";
            this.Check_RepresentarEmpresa.Size = new System.Drawing.Size(245, 20);
            this.Check_RepresentarEmpresa.TabIndex = 15;
            this.Check_RepresentarEmpresa.Text = "Representa a alguna empresa?\r\n";
            this.Check_RepresentarEmpresa.UseVisualStyleBackColor = true;
            // 
            // Combo_NombreCliente
            // 
            this.Combo_NombreCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_NombreCliente.FormattingEnabled = true;
            this.Combo_NombreCliente.Location = new System.Drawing.Point(48, 77);
            this.Combo_NombreCliente.Name = "Combo_NombreCliente";
            this.Combo_NombreCliente.Size = new System.Drawing.Size(246, 24);
            this.Combo_NombreCliente.TabIndex = 14;
            // 
            // lb_Nombre1
            // 
            this.lb_Nombre1.AutoSize = true;
            this.lb_Nombre1.Location = new System.Drawing.Point(45, 55);
            this.lb_Nombre1.Name = "lb_Nombre1";
            this.lb_Nombre1.Size = new System.Drawing.Size(67, 16);
            this.lb_Nombre1.TabIndex = 5;
            this.lb_Nombre1.Text = "Nombre:";
            // 
            // txt_Nombre1
            // 
            this.txt_Nombre1.Location = new System.Drawing.Point(118, 52);
            this.txt_Nombre1.MaxLength = 40;
            this.txt_Nombre1.Name = "txt_Nombre1";
            this.txt_Nombre1.Size = new System.Drawing.Size(176, 22);
            this.txt_Nombre1.TabIndex = 4;
            this.txt_Nombre1.TextChanged += new System.EventHandler(this.txt_Nombre1_TextChanged);
            this.txt_Nombre1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre1_KeyPress);
            // 
            // lb_NombreEmpleado
            // 
            this.lb_NombreEmpleado.AutoSize = true;
            this.lb_NombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NombreEmpleado.Location = new System.Drawing.Point(10, 42);
            this.lb_NombreEmpleado.Name = "lb_NombreEmpleado";
            this.lb_NombreEmpleado.Size = new System.Drawing.Size(155, 15);
            this.lb_NombreEmpleado.TabIndex = 35;
            this.lb_NombreEmpleado.Text = "Nombre del Empleado:";
            // 
            // Txt_NombreEmpleado
            // 
            this.Txt_NombreEmpleado.Enabled = false;
            this.Txt_NombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NombreEmpleado.Location = new System.Drawing.Point(180, 42);
            this.Txt_NombreEmpleado.Name = "Txt_NombreEmpleado";
            this.Txt_NombreEmpleado.Size = new System.Drawing.Size(261, 21);
            this.Txt_NombreEmpleado.TabIndex = 34;
            // 
            // lb_FechaRealizacion
            // 
            this.lb_FechaRealizacion.AutoSize = true;
            this.lb_FechaRealizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FechaRealizacion.Location = new System.Drawing.Point(10, 15);
            this.lb_FechaRealizacion.Name = "lb_FechaRealizacion";
            this.lb_FechaRealizacion.Size = new System.Drawing.Size(150, 15);
            this.lb_FechaRealizacion.TabIndex = 33;
            this.lb_FechaRealizacion.Text = "Fecha de Realizacion:";
            // 
            // Date_Fecha
            // 
            this.Date_Fecha.Enabled = false;
            this.Date_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Fecha.Location = new System.Drawing.Point(180, 15);
            this.Date_Fecha.Name = "Date_Fecha";
            this.Date_Fecha.Size = new System.Drawing.Size(261, 21);
            this.Date_Fecha.TabIndex = 51;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 52;
            this.label3.Text = "Fecha Limite:";
            // 
            // Date_FechaLimite
            // 
            this.Date_FechaLimite.Location = new System.Drawing.Point(180, 71);
            this.Date_FechaLimite.MinDate = new System.DateTime(2017, 11, 29, 0, 0, 0, 0);
            this.Date_FechaLimite.Name = "Date_FechaLimite";
            this.Date_FechaLimite.Size = new System.Drawing.Size(261, 20);
            this.Date_FechaLimite.TabIndex = 53;
            this.Date_FechaLimite.Value = new System.DateTime(2017, 11, 29, 12, 45, 35, 0);
            // 
            // DataGrid_NombreProducto
            // 
            this.DataGrid_NombreProducto.FillWeight = 228.1524F;
            this.DataGrid_NombreProducto.HeaderText = "Informacion de Producto";
            this.DataGrid_NombreProducto.Name = "DataGrid_NombreProducto";
            this.DataGrid_NombreProducto.ReadOnly = true;
            // 
            // DataGrid_PrecioVenta
            // 
            this.DataGrid_PrecioVenta.FillWeight = 73.63128F;
            this.DataGrid_PrecioVenta.HeaderText = "Precio Unitario";
            this.DataGrid_PrecioVenta.Name = "DataGrid_PrecioVenta";
            this.DataGrid_PrecioVenta.ReadOnly = true;
            // 
            // DG_Cantidad
            // 
            this.DG_Cantidad.FillWeight = 60.9137F;
            this.DG_Cantidad.HeaderText = "Cantidad";
            this.DG_Cantidad.Name = "DG_Cantidad";
            this.DG_Cantidad.ReadOnly = true;
            // 
            // DG_Total
            // 
            this.DG_Total.FillWeight = 37.30265F;
            this.DG_Total.HeaderText = "Total";
            this.DG_Total.Name = "DG_Total";
            this.DG_Total.ReadOnly = true;
            // 
            // Form_RealizarCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(814, 646);
            this.ControlBox = false;
            this.Controls.Add(this.Date_FechaLimite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Date_Fecha);
            this.Controls.Add(this.Label_Total);
            this.Controls.Add(this.lb_Total);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_DescartarProducto);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gb_Cotizacion);
            this.Controls.Add(this.gb_DatosCliente);
            this.Controls.Add(this.lb_NombreEmpleado);
            this.Controls.Add(this.Txt_NombreEmpleado);
            this.Controls.Add(this.lb_FechaRealizacion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_RealizarCotizaciones";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Realizar Cotizaciones";
            this.Load += new System.EventHandler(this.Form_RealizarCotizaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_Cotizacion.ResumeLayout(false);
            this.gb_Cotizacion.PerformLayout();
            this.gb_DatosCliente.ResumeLayout(false);
            this.gb_DatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_Total;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_DescartarProducto;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gb_Cotizacion;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lb_Descripcion;
        private System.Windows.Forms.ComboBox ComBox_DescripcionProducto;
        private System.Windows.Forms.Label lb_Nombre2;
        private System.Windows.Forms.TextBox txt_Nombre2;
        private System.Windows.Forms.GroupBox gb_DatosCliente;
        private System.Windows.Forms.ComboBox Combo_NombreCliente;
        private System.Windows.Forms.Label lb_Nombre1;
        private System.Windows.Forms.TextBox txt_Nombre1;
        private System.Windows.Forms.Label lb_NombreEmpleado;
        private System.Windows.Forms.TextBox Txt_NombreEmpleado;
        private System.Windows.Forms.Label lb_FechaRealizacion;
        private System.Windows.Forms.TextBox Text_Modelo;
        private System.Windows.Forms.TextBox Text_Marca;
        private System.Windows.Forms.TextBox Text_Precio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Check_RepresentarEmpresa;
        private System.Windows.Forms.DateTimePicker Date_Fecha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Date_FechaLimite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGrid_NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGrid_PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Total;
    }
}
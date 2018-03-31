namespace Desarrollo.Pantallas.Modulo_Ventas_Manejo
{
    partial class Form_MantenimientoImpuestos
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
            this.btn_Salir = new System.Windows.Forms.Button();
            this.date_FechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.gb_ModificarImpuesto = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.date_FechaIngresoImp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.lb_CodigoMod = new System.Windows.Forms.Label();
            this.txt_CodigoModificarImp = new System.Windows.Forms.TextBox();
            this.lb_Estado = new System.Windows.Forms.Label();
            this.lb_Porcentaje = new System.Windows.Forms.Label();
            this.txt_Porcentaje = new System.Windows.Forms.TextBox();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.lb_ValorImpuestoActual = new System.Windows.Forms.Label();
            this.txt_ValorImpuestoActual = new System.Windows.Forms.TextBox();
            this.lb_FechaIngreso = new System.Windows.Forms.Label();
            this.lb_Codigo1 = new System.Windows.Forms.Label();
            this.txt_CodigoNuevoImp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Fecha_Inicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RadioB_ModificarImpuesto = new System.Windows.Forms.RadioButton();
            this.RadioB_AgregarImpuesto = new System.Windows.Forms.RadioButton();
            this.ventasAutoPartesDataSet = new Desarrollo.VentasAutoPartesDataSet();
            this.ventasAutoPartesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gb_ModificarImpuesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(588, 538);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(149, 40);
            this.btn_Salir.TabIndex = 33;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // date_FechaIngreso
            // 
            this.date_FechaIngreso.Enabled = false;
            this.date_FechaIngreso.Location = new System.Drawing.Point(464, 35);
            this.date_FechaIngreso.Name = "date_FechaIngreso";
            this.date_FechaIngreso.Size = new System.Drawing.Size(245, 20);
            this.date_FechaIngreso.TabIndex = 32;
            // 
            // gb_ModificarImpuesto
            // 
            this.gb_ModificarImpuesto.Controls.Add(this.dataGridView1);
            this.gb_ModificarImpuesto.Controls.Add(this.label3);
            this.gb_ModificarImpuesto.Controls.Add(this.dateTimePicker1);
            this.gb_ModificarImpuesto.Controls.Add(this.comboBoxEstado);
            this.gb_ModificarImpuesto.Controls.Add(this.date_FechaIngresoImp);
            this.gb_ModificarImpuesto.Controls.Add(this.label1);
            this.gb_ModificarImpuesto.Controls.Add(this.btn_Aceptar);
            this.gb_ModificarImpuesto.Controls.Add(this.lb_CodigoMod);
            this.gb_ModificarImpuesto.Controls.Add(this.txt_CodigoModificarImp);
            this.gb_ModificarImpuesto.Controls.Add(this.lb_Estado);
            this.gb_ModificarImpuesto.Controls.Add(this.lb_Porcentaje);
            this.gb_ModificarImpuesto.Controls.Add(this.txt_Porcentaje);
            this.gb_ModificarImpuesto.Location = new System.Drawing.Point(21, 215);
            this.gb_ModificarImpuesto.Name = "gb_ModificarImpuesto";
            this.gb_ModificarImpuesto.Size = new System.Drawing.Size(723, 317);
            this.gb_ModificarImpuesto.TabIndex = 30;
            this.gb_ModificarImpuesto.TabStop = false;
            this.gb_ModificarImpuesto.Text = "Modificar Impuesto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(709, 169);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fecha de Modificacion";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(317, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(238, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(317, 82);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(147, 21);
            this.comboBoxEstado.TabIndex = 20;
            // 
            // date_FechaIngresoImp
            // 
            this.date_FechaIngresoImp.Location = new System.Drawing.Point(317, 30);
            this.date_FechaIngresoImp.MinDate = new System.DateTime(2018, 3, 3, 0, 0, 0, 0);
            this.date_FechaIngresoImp.Name = "date_FechaIngresoImp";
            this.date_FechaIngresoImp.Size = new System.Drawing.Size(238, 20);
            this.date_FechaIngresoImp.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fecha de Inicio";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(561, 30);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(149, 40);
            this.btn_Aceptar.TabIndex = 17;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // lb_CodigoMod
            // 
            this.lb_CodigoMod.AutoSize = true;
            this.lb_CodigoMod.Location = new System.Drawing.Point(9, 36);
            this.lb_CodigoMod.Name = "lb_CodigoMod";
            this.lb_CodigoMod.Size = new System.Drawing.Size(46, 13);
            this.lb_CodigoMod.TabIndex = 11;
            this.lb_CodigoMod.Text = "Codigo";
            // 
            // txt_CodigoModificarImp
            // 
            this.txt_CodigoModificarImp.Location = new System.Drawing.Point(94, 33);
            this.txt_CodigoModificarImp.Name = "txt_CodigoModificarImp";
            this.txt_CodigoModificarImp.Size = new System.Drawing.Size(75, 20);
            this.txt_CodigoModificarImp.TabIndex = 10;
            // 
            // lb_Estado
            // 
            this.lb_Estado.AutoSize = true;
            this.lb_Estado.Location = new System.Drawing.Point(175, 87);
            this.lb_Estado.Name = "lb_Estado";
            this.lb_Estado.Size = new System.Drawing.Size(46, 13);
            this.lb_Estado.TabIndex = 9;
            this.lb_Estado.Text = "Estado";
            // 
            // lb_Porcentaje
            // 
            this.lb_Porcentaje.AutoSize = true;
            this.lb_Porcentaje.Location = new System.Drawing.Point(9, 65);
            this.lb_Porcentaje.Name = "lb_Porcentaje";
            this.lb_Porcentaje.Size = new System.Drawing.Size(85, 13);
            this.lb_Porcentaje.TabIndex = 13;
            this.lb_Porcentaje.Text = "Porcentaje(%)";
            // 
            // txt_Porcentaje
            // 
            this.txt_Porcentaje.Enabled = false;
            this.txt_Porcentaje.Location = new System.Drawing.Point(94, 61);
            this.txt_Porcentaje.Name = "txt_Porcentaje";
            this.txt_Porcentaje.Size = new System.Drawing.Size(75, 20);
            this.txt_Porcentaje.TabIndex = 12;
            this.txt_Porcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Porcentaje_KeyPress);
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Location = new System.Drawing.Point(560, 99);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(149, 39);
            this.btn_Ingresar.TabIndex = 29;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // lb_ValorImpuestoActual
            // 
            this.lb_ValorImpuestoActual.AutoSize = true;
            this.lb_ValorImpuestoActual.Location = new System.Drawing.Point(7, 64);
            this.lb_ValorImpuestoActual.Name = "lb_ValorImpuestoActual";
            this.lb_ValorImpuestoActual.Size = new System.Drawing.Size(173, 13);
            this.lb_ValorImpuestoActual.TabIndex = 28;
            this.lb_ValorImpuestoActual.Text = "Valor del Impuesto Actual (%)";
            // 
            // txt_ValorImpuestoActual
            // 
            this.txt_ValorImpuestoActual.Location = new System.Drawing.Point(186, 61);
            this.txt_ValorImpuestoActual.Name = "txt_ValorImpuestoActual";
            this.txt_ValorImpuestoActual.Size = new System.Drawing.Size(143, 20);
            this.txt_ValorImpuestoActual.TabIndex = 27;
            this.txt_ValorImpuestoActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ValorImpuestoActual_KeyPress);
            // 
            // lb_FechaIngreso
            // 
            this.lb_FechaIngreso.AutoSize = true;
            this.lb_FechaIngreso.Location = new System.Drawing.Point(335, 38);
            this.lb_FechaIngreso.Name = "lb_FechaIngreso";
            this.lb_FechaIngreso.Size = new System.Drawing.Size(110, 13);
            this.lb_FechaIngreso.TabIndex = 26;
            this.lb_FechaIngreso.Text = "Fecha de Ingreso:";
            // 
            // lb_Codigo1
            // 
            this.lb_Codigo1.AutoSize = true;
            this.lb_Codigo1.Location = new System.Drawing.Point(9, 34);
            this.lb_Codigo1.Name = "lb_Codigo1";
            this.lb_Codigo1.Size = new System.Drawing.Size(50, 13);
            this.lb_Codigo1.TabIndex = 25;
            this.lb_Codigo1.Text = "Codigo:";
            // 
            // txt_CodigoNuevoImp
            // 
            this.txt_CodigoNuevoImp.Location = new System.Drawing.Point(65, 31);
            this.txt_CodigoNuevoImp.Name = "txt_CodigoNuevoImp";
            this.txt_CodigoNuevoImp.Size = new System.Drawing.Size(57, 20);
            this.txt_CodigoNuevoImp.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Ingresar);
            this.groupBox1.Controls.Add(this.Fecha_Inicial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.date_FechaIngreso);
            this.groupBox1.Controls.Add(this.txt_CodigoNuevoImp);
            this.groupBox1.Controls.Add(this.lb_Codigo1);
            this.groupBox1.Controls.Add(this.lb_FechaIngreso);
            this.groupBox1.Controls.Add(this.txt_ValorImpuestoActual);
            this.groupBox1.Controls.Add(this.lb_ValorImpuestoActual);
            this.groupBox1.Location = new System.Drawing.Point(21, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 144);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Impuesto";
            // 
            // Fecha_Inicial
            // 
            this.Fecha_Inicial.Location = new System.Drawing.Point(464, 65);
            this.Fecha_Inicial.MinDate = new System.DateTime(2017, 12, 3, 0, 0, 0, 0);
            this.Fecha_Inicial.Name = "Fecha_Inicial";
            this.Fecha_Inicial.Size = new System.Drawing.Size(245, 20);
            this.Fecha_Inicial.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Fecha de Iniciacion:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadioB_ModificarImpuesto);
            this.groupBox2.Controls.Add(this.RadioB_AgregarImpuesto);
            this.groupBox2.Location = new System.Drawing.Point(21, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 47);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manejo de Impuesto";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // RadioB_ModificarImpuesto
            // 
            this.RadioB_ModificarImpuesto.AutoSize = true;
            this.RadioB_ModificarImpuesto.Location = new System.Drawing.Point(434, 19);
            this.RadioB_ModificarImpuesto.Name = "RadioB_ModificarImpuesto";
            this.RadioB_ModificarImpuesto.Size = new System.Drawing.Size(132, 17);
            this.RadioB_ModificarImpuesto.TabIndex = 1;
            this.RadioB_ModificarImpuesto.Text = "Modificar Impuesto";
            this.RadioB_ModificarImpuesto.UseVisualStyleBackColor = true;
            this.RadioB_ModificarImpuesto.CheckedChanged += new System.EventHandler(this.RadioB_ModificarImpuesto_CheckedChanged);
            // 
            // RadioB_AgregarImpuesto
            // 
            this.RadioB_AgregarImpuesto.AutoSize = true;
            this.RadioB_AgregarImpuesto.Location = new System.Drawing.Point(89, 19);
            this.RadioB_AgregarImpuesto.Name = "RadioB_AgregarImpuesto";
            this.RadioB_AgregarImpuesto.Size = new System.Drawing.Size(165, 17);
            this.RadioB_AgregarImpuesto.TabIndex = 0;
            this.RadioB_AgregarImpuesto.Text = "Agregar Nuevo Impuesto";
            this.RadioB_AgregarImpuesto.UseVisualStyleBackColor = true;
            this.RadioB_AgregarImpuesto.CheckedChanged += new System.EventHandler(this.RadioB_AgregarImpuesto_CheckedChanged);
            // 
            // ventasAutoPartesDataSet
            // 
            this.ventasAutoPartesDataSet.DataSetName = "VentasAutoPartesDataSet";
            this.ventasAutoPartesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventasAutoPartesDataSetBindingSource
            // 
            this.ventasAutoPartesDataSetBindingSource.DataSource = this.ventasAutoPartesDataSet;
            this.ventasAutoPartesDataSetBindingSource.Position = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_MantenimientoImpuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(762, 590);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.gb_ModificarImpuesto);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_MantenimientoImpuestos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Mantenimiento del Impuesto";
            this.Load += new System.EventHandler(this.Form_MantenimientoImpuestos_Load);
            this.gb_ModificarImpuesto.ResumeLayout(false);
            this.gb_ModificarImpuesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DateTimePicker date_FechaIngreso;
        private System.Windows.Forms.GroupBox gb_ModificarImpuesto;
        private System.Windows.Forms.DateTimePicker date_FechaIngresoImp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label lb_CodigoMod;
        private System.Windows.Forms.TextBox txt_CodigoModificarImp;
        private System.Windows.Forms.Label lb_Estado;
        private System.Windows.Forms.Label lb_Porcentaje;
        private System.Windows.Forms.TextBox txt_Porcentaje;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.Label lb_ValorImpuestoActual;
        private System.Windows.Forms.TextBox txt_ValorImpuestoActual;
        private System.Windows.Forms.Label lb_FechaIngreso;
        private System.Windows.Forms.Label lb_Codigo1;
        private System.Windows.Forms.TextBox txt_CodigoNuevoImp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RadioB_ModificarImpuesto;
        private System.Windows.Forms.RadioButton RadioB_AgregarImpuesto;
        private VentasAutoPartesDataSet ventasAutoPartesDataSet;
        private System.Windows.Forms.BindingSource ventasAutoPartesDataSetBindingSource;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.DateTimePicker Fecha_Inicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
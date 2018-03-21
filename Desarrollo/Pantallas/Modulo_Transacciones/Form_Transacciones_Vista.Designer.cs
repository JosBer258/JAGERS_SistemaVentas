namespace Desarrollo.Pantallas.Modulo_Transacciones
{
    partial class Form_Transacciones_Vista
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
            this.transaccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasAutoPartesDataSet = new Desarrollo.VentasAutoPartesDataSet();
            this.DGV_Transacciones = new System.Windows.Forms.DataGridView();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.btnAplicarMora = new System.Windows.Forms.Button();
            this.btnLimpiarManejo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodTrans = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioTodas = new System.Windows.Forms.RadioButton();
            this.cmbBxTipoDoc = new System.Windows.Forms.ComboBox();
            this.DATE_FiltroFecha = new System.Windows.Forms.DateTimePicker();
            this.radioFechaVen = new System.Windows.Forms.RadioButton();
            this.radioTipoDoc = new System.Windows.Forms.RadioButton();
            this.cmbBxTipos = new System.Windows.Forms.ComboBox();
            this.radioTipos = new System.Windows.Forms.RadioButton();
            this.cmbBxEstados = new System.Windows.Forms.ComboBox();
            this.radioEstados = new System.Windows.Forms.RadioButton();
            this.transaccionesTableAdapter = new Desarrollo.VentasAutoPartesDataSetTableAdapters.TransaccionesTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DATE_FechaTransaccion = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DATE_FechaActual = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Transacciones)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // transaccionesBindingSource
            // 
            this.transaccionesBindingSource.DataMember = "Transacciones";
            this.transaccionesBindingSource.DataSource = this.ventasAutoPartesDataSet;
            // 
            // ventasAutoPartesDataSet
            // 
            this.ventasAutoPartesDataSet.DataSetName = "VentasAutoPartesDataSet";
            this.ventasAutoPartesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DGV_Transacciones
            // 
            this.DGV_Transacciones.AllowUserToAddRows = false;
            this.DGV_Transacciones.AllowUserToDeleteRows = false;
            this.DGV_Transacciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Transacciones.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGV_Transacciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV_Transacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Transacciones.Location = new System.Drawing.Point(12, 203);
            this.DGV_Transacciones.Name = "DGV_Transacciones";
            this.DGV_Transacciones.ReadOnly = true;
            this.DGV_Transacciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Transacciones.Size = new System.Drawing.Size(1076, 431);
            this.DGV_Transacciones.TabIndex = 28;
            this.DGV_Transacciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Transacciones_CellClick);
            this.DGV_Transacciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Transacciones_CellContentClick);
            this.DGV_Transacciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Transacciones_CellDoubleClick);
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Location = new System.Drawing.Point(107, 58);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(99, 21);
            this.txtMonto.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Monto L.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Numero de Documento";
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Enabled = false;
            this.txtNumDoc.Location = new System.Drawing.Point(221, 58);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(141, 21);
            this.txtNumDoc.TabIndex = 12;
            // 
            // btnAplicarMora
            // 
            this.btnAplicarMora.Location = new System.Drawing.Point(473, 57);
            this.btnAplicarMora.Name = "btnAplicarMora";
            this.btnAplicarMora.Size = new System.Drawing.Size(86, 30);
            this.btnAplicarMora.TabIndex = 11;
            this.btnAplicarMora.Text = "Aplicar Mora";
            this.btnAplicarMora.UseVisualStyleBackColor = true;
            this.btnAplicarMora.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLimpiarManejo
            // 
            this.btnLimpiarManejo.Location = new System.Drawing.Point(473, 20);
            this.btnLimpiarManejo.Name = "btnLimpiarManejo";
            this.btnLimpiarManejo.Size = new System.Drawing.Size(86, 30);
            this.btnLimpiarManejo.TabIndex = 10;
            this.btnLimpiarManejo.Text = "Limpiar";
            this.btnLimpiarManejo.UseVisualStyleBackColor = true;
            this.btnLimpiarManejo.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Transaccion";
            // 
            // txtCodTrans
            // 
            this.txtCodTrans.Enabled = false;
            this.txtCodTrans.Location = new System.Drawing.Point(14, 58);
            this.txtCodTrans.Name = "txtCodTrans";
            this.txtCodTrans.Size = new System.Drawing.Size(82, 21);
            this.txtCodTrans.TabIndex = 2;
            this.txtCodTrans.TextChanged += new System.EventHandler(this.txtCodTrans_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(984, 640);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 43);
            this.button3.TabIndex = 1;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.radioTodas);
            this.groupBox2.Controls.Add(this.cmbBxTipoDoc);
            this.groupBox2.Controls.Add(this.DATE_FiltroFecha);
            this.groupBox2.Controls.Add(this.radioFechaVen);
            this.groupBox2.Controls.Add(this.radioTipoDoc);
            this.groupBox2.Controls.Add(this.cmbBxTipos);
            this.groupBox2.Controls.Add(this.radioTipos);
            this.groupBox2.Controls.Add(this.cmbBxEstados);
            this.groupBox2.Controls.Add(this.radioEstados);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 138);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aplicar Filtros de Busqueda";
            // 
            // radioTodas
            // 
            this.radioTodas.AutoSize = true;
            this.radioTodas.Checked = true;
            this.radioTodas.Location = new System.Drawing.Point(20, 35);
            this.radioTodas.Name = "radioTodas";
            this.radioTodas.Size = new System.Drawing.Size(167, 17);
            this.radioTodas.TabIndex = 10;
            this.radioTodas.TabStop = true;
            this.radioTodas.Text = "Todas las Transacciones";
            this.radioTodas.UseVisualStyleBackColor = true;
            this.radioTodas.CheckedChanged += new System.EventHandler(this.radioTodas_CheckedChanged);
            // 
            // cmbBxTipoDoc
            // 
            this.cmbBxTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxTipoDoc.Enabled = false;
            this.cmbBxTipoDoc.FormattingEnabled = true;
            this.cmbBxTipoDoc.Location = new System.Drawing.Point(396, 91);
            this.cmbBxTipoDoc.Name = "cmbBxTipoDoc";
            this.cmbBxTipoDoc.Size = new System.Drawing.Size(99, 21);
            this.cmbBxTipoDoc.TabIndex = 7;
            this.cmbBxTipoDoc.SelectedIndexChanged += new System.EventHandler(this.cmbBxTipoDoc_SelectedIndexChanged);
            // 
            // DATE_FiltroFecha
            // 
            this.DATE_FiltroFecha.Enabled = false;
            this.DATE_FiltroFecha.Location = new System.Drawing.Point(230, 64);
            this.DATE_FiltroFecha.Name = "DATE_FiltroFecha";
            this.DATE_FiltroFecha.Size = new System.Drawing.Size(265, 20);
            this.DATE_FiltroFecha.TabIndex = 6;
            this.DATE_FiltroFecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // radioFechaVen
            // 
            this.radioFechaVen.AutoSize = true;
            this.radioFechaVen.Location = new System.Drawing.Point(230, 41);
            this.radioFechaVen.Name = "radioFechaVen";
            this.radioFechaVen.Size = new System.Drawing.Size(151, 17);
            this.radioFechaVen.TabIndex = 5;
            this.radioFechaVen.Text = "Fecha de Vencimiento";
            this.radioFechaVen.UseVisualStyleBackColor = true;
            this.radioFechaVen.CheckedChanged += new System.EventHandler(this.radioFechaVen_CheckedChanged);
            // 
            // radioTipoDoc
            // 
            this.radioTipoDoc.AutoSize = true;
            this.radioTipoDoc.Location = new System.Drawing.Point(230, 92);
            this.radioTipoDoc.Name = "radioTipoDoc";
            this.radioTipoDoc.Size = new System.Drawing.Size(160, 17);
            this.radioTipoDoc.TabIndex = 4;
            this.radioTipoDoc.Text = "Tipo de Documentacion";
            this.radioTipoDoc.UseVisualStyleBackColor = true;
            this.radioTipoDoc.CheckedChanged += new System.EventHandler(this.radioTipoDoc_CheckedChanged);
            // 
            // cmbBxTipos
            // 
            this.cmbBxTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxTipos.Enabled = false;
            this.cmbBxTipos.FormattingEnabled = true;
            this.cmbBxTipos.Location = new System.Drawing.Point(102, 61);
            this.cmbBxTipos.Name = "cmbBxTipos";
            this.cmbBxTipos.Size = new System.Drawing.Size(99, 21);
            this.cmbBxTipos.TabIndex = 3;
            this.cmbBxTipos.SelectedIndexChanged += new System.EventHandler(this.cmbBxTipos_SelectedIndexChanged);
            // 
            // radioTipos
            // 
            this.radioTipos.AutoSize = true;
            this.radioTipos.Location = new System.Drawing.Point(20, 63);
            this.radioTipos.Name = "radioTipos";
            this.radioTipos.Size = new System.Drawing.Size(56, 17);
            this.radioTipos.TabIndex = 2;
            this.radioTipos.Text = "Tipos";
            this.radioTipos.UseVisualStyleBackColor = true;
            this.radioTipos.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cmbBxEstados
            // 
            this.cmbBxEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxEstados.Enabled = false;
            this.cmbBxEstados.FormattingEnabled = true;
            this.cmbBxEstados.Location = new System.Drawing.Point(102, 91);
            this.cmbBxEstados.Name = "cmbBxEstados";
            this.cmbBxEstados.Size = new System.Drawing.Size(99, 21);
            this.cmbBxEstados.TabIndex = 1;
            this.cmbBxEstados.SelectedIndexChanged += new System.EventHandler(this.cmbBxEstados_SelectedIndexChanged);
            // 
            // radioEstados
            // 
            this.radioEstados.AutoSize = true;
            this.radioEstados.Location = new System.Drawing.Point(20, 93);
            this.radioEstados.Name = "radioEstados";
            this.radioEstados.Size = new System.Drawing.Size(70, 17);
            this.radioEstados.TabIndex = 0;
            this.radioEstados.Text = "Estados";
            this.radioEstados.UseVisualStyleBackColor = true;
            this.radioEstados.CheckedChanged += new System.EventHandler(this.radioEstados_CheckedChanged);
            // 
            // transaccionesTableAdapter
            // 
            this.transaccionesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DATE_FechaTransaccion);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtCodTrans);
            this.groupBox3.Controls.Add(this.btnLimpiarManejo);
            this.groupBox3.Controls.Add(this.btnAplicarMora);
            this.groupBox3.Controls.Add(this.txtMonto);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtNumDoc);
            this.groupBox3.Location = new System.Drawing.Point(523, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(565, 138);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manejo de Transacciones";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // DATE_FechaTransaccion
            // 
            this.DATE_FechaTransaccion.Enabled = false;
            this.DATE_FechaTransaccion.Location = new System.Drawing.Point(15, 103);
            this.DATE_FechaTransaccion.Name = "DATE_FechaTransaccion";
            this.DATE_FechaTransaccion.Size = new System.Drawing.Size(283, 21);
            this.DATE_FechaTransaccion.TabIndex = 30;
            this.DATE_FechaTransaccion.ValueChanged += new System.EventHandler(this.DATE_FechaTransaccion_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Fecha de Realizacion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 30);
            this.button1.TabIndex = 28;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DATE_FechaActual
            // 
            this.DATE_FechaActual.Location = new System.Drawing.Point(12, 22);
            this.DATE_FechaActual.Name = "DATE_FechaActual";
            this.DATE_FechaActual.Size = new System.Drawing.Size(291, 21);
            this.DATE_FechaActual.TabIndex = 29;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_Transacciones_Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1100, 695);
            this.ControlBox = false;
            this.Controls.Add(this.DATE_FechaActual);
            this.Controls.Add(this.DGV_Transacciones);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_Transacciones_Vista";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Busqueda de Transacciones";
            this.Load += new System.EventHandler(this.Form_Transacciones_Vista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Transacciones)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbBxTipos;
        private System.Windows.Forms.RadioButton radioTipos;
        private System.Windows.Forms.ComboBox cmbBxEstados;
        private System.Windows.Forms.RadioButton radioEstados;
        private VentasAutoPartesDataSet ventasAutoPartesDataSet;
        private System.Windows.Forms.BindingSource transaccionesBindingSource;
        private VentasAutoPartesDataSetTableAdapters.TransaccionesTableAdapter transaccionesTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.Button btnAplicarMora;
        private System.Windows.Forms.Button btnLimpiarManejo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodTrans;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmbBxTipoDoc;
        private System.Windows.Forms.DateTimePicker DATE_FiltroFecha;
        private System.Windows.Forms.RadioButton radioFechaVen;
        private System.Windows.Forms.RadioButton radioTipoDoc;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DGV_Transacciones;
        private System.Windows.Forms.RadioButton radioTodas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DATE_FechaActual;
        private System.Windows.Forms.DateTimePicker DATE_FechaTransaccion;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
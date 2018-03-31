namespace Desarrollo.Pantallas.Modulo_Transacciones
{
    partial class Form_MantenimientoTransacciones
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
            this.Grupo_Transacciones = new System.Windows.Forms.GroupBox();
            this.Txt_NaturalezaTransacciones = new System.Windows.Forms.TextBox();
            this.Txt_DescripcionTransacciones = new System.Windows.Forms.TextBox();
            this.Txt_CodigoTransacciones = new System.Windows.Forms.TextBox();
            this.Bttn_Limpiar = new System.Windows.Forms.Button();
            this.Bttn_Aceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Radio_AgregarTransacciones = new System.Windows.Forms.RadioButton();
            this.Radio_ActualizarTransacciones = new System.Windows.Forms.RadioButton();
            this.DaraGriew_Transacciones = new System.Windows.Forms.DataGridView();
            this.codigoTipoTransaccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naturalezaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoTransaccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasAutoPartesDataSet = new Desarrollo.VentasAutoPartesDataSet();
            this.tipo_TransaccionTableAdapter = new Desarrollo.VentasAutoPartesDataSetTableAdapters.Tipo_TransaccionTableAdapter();
            this.Grupo_Documentacion = new System.Windows.Forms.GroupBox();
            this.Txt_EstadoDocumentacion = new System.Windows.Forms.ComboBox();
            this.Txt_DescripcionDocumentacion = new System.Windows.Forms.TextBox();
            this.Txt_CodigoDocumentacion = new System.Windows.Forms.TextBox();
            this.Bttn_LimpiaDocumentacion = new System.Windows.Forms.Button();
            this.Bttn_AceptarDocumentacion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Radio_AgregarDocumentos = new System.Windows.Forms.RadioButton();
            this.Radio_ActDocumentos = new System.Windows.Forms.RadioButton();
            this.DaraGriew_Documentacion = new System.Windows.Forms.DataGridView();
            this.tiposDocumentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipos_DocumentosTableAdapter = new Desarrollo.VentasAutoPartesDataSetTableAdapters.Tipos_DocumentosTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Grupo_Transacciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaraGriew_Transacciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTransaccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet)).BeginInit();
            this.Grupo_Documentacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaraGriew_Documentacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDocumentosBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grupo_Transacciones
            // 
            this.Grupo_Transacciones.Controls.Add(this.Txt_NaturalezaTransacciones);
            this.Grupo_Transacciones.Controls.Add(this.Txt_DescripcionTransacciones);
            this.Grupo_Transacciones.Controls.Add(this.Txt_CodigoTransacciones);
            this.Grupo_Transacciones.Controls.Add(this.Bttn_Limpiar);
            this.Grupo_Transacciones.Controls.Add(this.Bttn_Aceptar);
            this.Grupo_Transacciones.Controls.Add(this.label3);
            this.Grupo_Transacciones.Controls.Add(this.label2);
            this.Grupo_Transacciones.Controls.Add(this.label1);
            this.Grupo_Transacciones.Controls.Add(this.Radio_AgregarTransacciones);
            this.Grupo_Transacciones.Controls.Add(this.Radio_ActualizarTransacciones);
            this.Grupo_Transacciones.Location = new System.Drawing.Point(16, 32);
            this.Grupo_Transacciones.Name = "Grupo_Transacciones";
            this.Grupo_Transacciones.Size = new System.Drawing.Size(533, 159);
            this.Grupo_Transacciones.TabIndex = 0;
            this.Grupo_Transacciones.TabStop = false;
            this.Grupo_Transacciones.Text = "Manejo de Transacciones";
            this.Grupo_Transacciones.Enter += new System.EventHandler(this.Grupo_Transacciones_Enter);
            // 
            // Txt_NaturalezaTransacciones
            // 
            this.Txt_NaturalezaTransacciones.Location = new System.Drawing.Point(114, 117);
            this.Txt_NaturalezaTransacciones.MaxLength = 23;
            this.Txt_NaturalezaTransacciones.Name = "Txt_NaturalezaTransacciones";
            this.Txt_NaturalezaTransacciones.Size = new System.Drawing.Size(201, 21);
            this.Txt_NaturalezaTransacciones.TabIndex = 11;
            this.Txt_NaturalezaTransacciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NaturalezaTransacciones_KeyPress);
            // 
            // Txt_DescripcionTransacciones
            // 
            this.Txt_DescripcionTransacciones.Location = new System.Drawing.Point(114, 90);
            this.Txt_DescripcionTransacciones.MaxLength = 54;
            this.Txt_DescripcionTransacciones.Name = "Txt_DescripcionTransacciones";
            this.Txt_DescripcionTransacciones.Size = new System.Drawing.Size(201, 21);
            this.Txt_DescripcionTransacciones.TabIndex = 10;
            this.Txt_DescripcionTransacciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_DescripcionTransacciones_KeyPress);
            // 
            // Txt_CodigoTransacciones
            // 
            this.Txt_CodigoTransacciones.Enabled = false;
            this.Txt_CodigoTransacciones.Location = new System.Drawing.Point(114, 66);
            this.Txt_CodigoTransacciones.Name = "Txt_CodigoTransacciones";
            this.Txt_CodigoTransacciones.Size = new System.Drawing.Size(201, 21);
            this.Txt_CodigoTransacciones.TabIndex = 9;
            // 
            // Bttn_Limpiar
            // 
            this.Bttn_Limpiar.Location = new System.Drawing.Point(394, 86);
            this.Bttn_Limpiar.Name = "Bttn_Limpiar";
            this.Bttn_Limpiar.Size = new System.Drawing.Size(118, 53);
            this.Bttn_Limpiar.TabIndex = 8;
            this.Bttn_Limpiar.Text = "Limpiar";
            this.Bttn_Limpiar.UseVisualStyleBackColor = true;
            this.Bttn_Limpiar.Click += new System.EventHandler(this.Bttn_Limpiar_Click);
            // 
            // Bttn_Aceptar
            // 
            this.Bttn_Aceptar.Location = new System.Drawing.Point(394, 27);
            this.Bttn_Aceptar.Name = "Bttn_Aceptar";
            this.Bttn_Aceptar.Size = new System.Drawing.Size(118, 53);
            this.Bttn_Aceptar.TabIndex = 7;
            this.Bttn_Aceptar.Text = "Aceptar";
            this.toolTip1.SetToolTip(this.Bttn_Aceptar, "Dele \"Aceptar\" para cargar \r\nlos datos al sistema");
            this.Bttn_Aceptar.UseVisualStyleBackColor = true;
            this.Bttn_Aceptar.Click += new System.EventHandler(this.Bttn_Aceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Naturaleza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo";
            // 
            // Radio_AgregarTransacciones
            // 
            this.Radio_AgregarTransacciones.AutoSize = true;
            this.Radio_AgregarTransacciones.Location = new System.Drawing.Point(188, 29);
            this.Radio_AgregarTransacciones.Name = "Radio_AgregarTransacciones";
            this.Radio_AgregarTransacciones.Size = new System.Drawing.Size(75, 19);
            this.Radio_AgregarTransacciones.TabIndex = 3;
            this.Radio_AgregarTransacciones.TabStop = true;
            this.Radio_AgregarTransacciones.Text = "Agregar";
            this.Radio_AgregarTransacciones.UseVisualStyleBackColor = true;
            // 
            // Radio_ActualizarTransacciones
            // 
            this.Radio_ActualizarTransacciones.AutoSize = true;
            this.Radio_ActualizarTransacciones.Location = new System.Drawing.Point(28, 29);
            this.Radio_ActualizarTransacciones.Name = "Radio_ActualizarTransacciones";
            this.Radio_ActualizarTransacciones.Size = new System.Drawing.Size(88, 19);
            this.Radio_ActualizarTransacciones.TabIndex = 2;
            this.Radio_ActualizarTransacciones.TabStop = true;
            this.Radio_ActualizarTransacciones.Text = "Actualizar";
            this.Radio_ActualizarTransacciones.UseVisualStyleBackColor = true;
            this.Radio_ActualizarTransacciones.CheckedChanged += new System.EventHandler(this.Radio_ActualizarTransacciones_CheckedChanged);
            // 
            // DaraGriew_Transacciones
            // 
            this.DaraGriew_Transacciones.AllowUserToAddRows = false;
            this.DaraGriew_Transacciones.AutoGenerateColumns = false;
            this.DaraGriew_Transacciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DaraGriew_Transacciones.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DaraGriew_Transacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaraGriew_Transacciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTipoTransaccionDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.naturalezaDataGridViewTextBoxColumn});
            this.DaraGriew_Transacciones.DataSource = this.tipoTransaccionBindingSource;
            this.DaraGriew_Transacciones.Location = new System.Drawing.Point(16, 211);
            this.DaraGriew_Transacciones.Name = "DaraGriew_Transacciones";
            this.DaraGriew_Transacciones.ReadOnly = true;
            this.DaraGriew_Transacciones.Size = new System.Drawing.Size(533, 165);
            this.DaraGriew_Transacciones.TabIndex = 0;
            this.DaraGriew_Transacciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DaraGriew_Transacciones_CellContentClick);
            this.DaraGriew_Transacciones.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DaraGriew_Transacciones_CellContentDoubleClick);
            this.DaraGriew_Transacciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DaraGriew_Transacciones_CellDoubleClick);
            // 
            // codigoTipoTransaccionDataGridViewTextBoxColumn
            // 
            this.codigoTipoTransaccionDataGridViewTextBoxColumn.DataPropertyName = "Codigo_TipoTransaccion";
            this.codigoTipoTransaccionDataGridViewTextBoxColumn.HeaderText = "Codigo del Tipo";
            this.codigoTipoTransaccionDataGridViewTextBoxColumn.Name = "codigoTipoTransaccionDataGridViewTextBoxColumn";
            this.codigoTipoTransaccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // naturalezaDataGridViewTextBoxColumn
            // 
            this.naturalezaDataGridViewTextBoxColumn.DataPropertyName = "Naturaleza";
            this.naturalezaDataGridViewTextBoxColumn.HeaderText = "Naturaleza";
            this.naturalezaDataGridViewTextBoxColumn.Name = "naturalezaDataGridViewTextBoxColumn";
            this.naturalezaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoTransaccionBindingSource
            // 
            this.tipoTransaccionBindingSource.DataMember = "Tipo_Transaccion";
            this.tipoTransaccionBindingSource.DataSource = this.ventasAutoPartesDataSet;
            // 
            // ventasAutoPartesDataSet
            // 
            this.ventasAutoPartesDataSet.DataSetName = "VentasAutoPartesDataSet";
            this.ventasAutoPartesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipo_TransaccionTableAdapter
            // 
            this.tipo_TransaccionTableAdapter.ClearBeforeFill = true;
            // 
            // Grupo_Documentacion
            // 
            this.Grupo_Documentacion.Controls.Add(this.Txt_EstadoDocumentacion);
            this.Grupo_Documentacion.Controls.Add(this.Txt_DescripcionDocumentacion);
            this.Grupo_Documentacion.Controls.Add(this.Txt_CodigoDocumentacion);
            this.Grupo_Documentacion.Controls.Add(this.Bttn_LimpiaDocumentacion);
            this.Grupo_Documentacion.Controls.Add(this.Bttn_AceptarDocumentacion);
            this.Grupo_Documentacion.Controls.Add(this.label4);
            this.Grupo_Documentacion.Controls.Add(this.label5);
            this.Grupo_Documentacion.Controls.Add(this.label6);
            this.Grupo_Documentacion.Controls.Add(this.Radio_AgregarDocumentos);
            this.Grupo_Documentacion.Controls.Add(this.Radio_ActDocumentos);
            this.Grupo_Documentacion.Location = new System.Drawing.Point(16, 30);
            this.Grupo_Documentacion.Name = "Grupo_Documentacion";
            this.Grupo_Documentacion.Size = new System.Drawing.Size(533, 163);
            this.Grupo_Documentacion.TabIndex = 12;
            this.Grupo_Documentacion.TabStop = false;
            this.Grupo_Documentacion.Text = "Manejo de Documentos";
            // 
            // Txt_EstadoDocumentacion
            // 
            this.Txt_EstadoDocumentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Txt_EstadoDocumentacion.FormattingEnabled = true;
            this.Txt_EstadoDocumentacion.Location = new System.Drawing.Point(114, 118);
            this.Txt_EstadoDocumentacion.Name = "Txt_EstadoDocumentacion";
            this.Txt_EstadoDocumentacion.Size = new System.Drawing.Size(202, 23);
            this.Txt_EstadoDocumentacion.TabIndex = 11;
            // 
            // Txt_DescripcionDocumentacion
            // 
            this.Txt_DescripcionDocumentacion.Location = new System.Drawing.Point(114, 93);
            this.Txt_DescripcionDocumentacion.MaxLength = 39;
            this.Txt_DescripcionDocumentacion.Name = "Txt_DescripcionDocumentacion";
            this.Txt_DescripcionDocumentacion.Size = new System.Drawing.Size(202, 21);
            this.Txt_DescripcionDocumentacion.TabIndex = 10;
            this.Txt_DescripcionDocumentacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_DescripcionDocumentacion_KeyPress);
            // 
            // Txt_CodigoDocumentacion
            // 
            this.Txt_CodigoDocumentacion.Enabled = false;
            this.Txt_CodigoDocumentacion.Location = new System.Drawing.Point(114, 69);
            this.Txt_CodigoDocumentacion.Name = "Txt_CodigoDocumentacion";
            this.Txt_CodigoDocumentacion.Size = new System.Drawing.Size(202, 21);
            this.Txt_CodigoDocumentacion.TabIndex = 9;
            // 
            // Bttn_LimpiaDocumentacion
            // 
            this.Bttn_LimpiaDocumentacion.Location = new System.Drawing.Point(394, 88);
            this.Bttn_LimpiaDocumentacion.Name = "Bttn_LimpiaDocumentacion";
            this.Bttn_LimpiaDocumentacion.Size = new System.Drawing.Size(118, 53);
            this.Bttn_LimpiaDocumentacion.TabIndex = 8;
            this.Bttn_LimpiaDocumentacion.Text = "Limpiar";
            this.Bttn_LimpiaDocumentacion.UseVisualStyleBackColor = true;
            this.Bttn_LimpiaDocumentacion.Click += new System.EventHandler(this.Bttn_LimpiaDocumentacion_Click);
            // 
            // Bttn_AceptarDocumentacion
            // 
            this.Bttn_AceptarDocumentacion.Location = new System.Drawing.Point(394, 28);
            this.Bttn_AceptarDocumentacion.Name = "Bttn_AceptarDocumentacion";
            this.Bttn_AceptarDocumentacion.Size = new System.Drawing.Size(118, 53);
            this.Bttn_AceptarDocumentacion.TabIndex = 7;
            this.Bttn_AceptarDocumentacion.Text = "Aceptar";
            this.toolTip1.SetToolTip(this.Bttn_AceptarDocumentacion, "Dele \"Aceptar\" para cargar \r\nlos datos al sistema");
            this.Bttn_AceptarDocumentacion.UseVisualStyleBackColor = true;
            this.Bttn_AceptarDocumentacion.Click += new System.EventHandler(this.Bttn_AceptarDocumentacion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Codigo";
            // 
            // Radio_AgregarDocumentos
            // 
            this.Radio_AgregarDocumentos.AutoSize = true;
            this.Radio_AgregarDocumentos.Location = new System.Drawing.Point(188, 31);
            this.Radio_AgregarDocumentos.Name = "Radio_AgregarDocumentos";
            this.Radio_AgregarDocumentos.Size = new System.Drawing.Size(75, 19);
            this.Radio_AgregarDocumentos.TabIndex = 3;
            this.Radio_AgregarDocumentos.TabStop = true;
            this.Radio_AgregarDocumentos.Text = "Agregar";
            this.Radio_AgregarDocumentos.UseVisualStyleBackColor = true;
            this.Radio_AgregarDocumentos.CheckedChanged += new System.EventHandler(this.Radio_AgregarDocumentos_CheckedChanged);
            // 
            // Radio_ActDocumentos
            // 
            this.Radio_ActDocumentos.AutoSize = true;
            this.Radio_ActDocumentos.Location = new System.Drawing.Point(28, 31);
            this.Radio_ActDocumentos.Name = "Radio_ActDocumentos";
            this.Radio_ActDocumentos.Size = new System.Drawing.Size(88, 19);
            this.Radio_ActDocumentos.TabIndex = 2;
            this.Radio_ActDocumentos.TabStop = true;
            this.Radio_ActDocumentos.Text = "Actualizar";
            this.Radio_ActDocumentos.UseVisualStyleBackColor = true;
            this.Radio_ActDocumentos.CheckedChanged += new System.EventHandler(this.Radio_ActDocumentos_CheckedChanged);
            // 
            // DaraGriew_Documentacion
            // 
            this.DaraGriew_Documentacion.AllowUserToAddRows = false;
            this.DaraGriew_Documentacion.AllowUserToDeleteRows = false;
            this.DaraGriew_Documentacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DaraGriew_Documentacion.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DaraGriew_Documentacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaraGriew_Documentacion.Location = new System.Drawing.Point(16, 210);
            this.DaraGriew_Documentacion.Name = "DaraGriew_Documentacion";
            this.DaraGriew_Documentacion.ReadOnly = true;
            this.DaraGriew_Documentacion.Size = new System.Drawing.Size(533, 150);
            this.DaraGriew_Documentacion.TabIndex = 12;
            this.DaraGriew_Documentacion.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DaraGriew_Documentacion_CellContentDoubleClick);
            this.DaraGriew_Documentacion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DaraGriew_Documentacion_CellDoubleClick);
            // 
            // tiposDocumentosBindingSource
            // 
            this.tiposDocumentosBindingSource.DataMember = "Tipos_Documentos";
            this.tiposDocumentosBindingSource.DataSource = this.ventasAutoPartesDataSet;
            // 
            // tipos_DocumentosTableAdapter
            // 
            this.tipos_DocumentosTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(444, 451);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 57);
            this.button5.TabIndex = 13;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(579, 433);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Grupo_Transacciones);
            this.tabPage1.Controls.Add(this.DaraGriew_Transacciones);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(571, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tipo de Transaccion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DaraGriew_Documentacion);
            this.tabPage2.Controls.Add(this.Grupo_Documentacion);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(571, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tipo de Documento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_MantenimientoTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(598, 518);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_MantenimientoTransacciones";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Mantenimiento a Caracteristicas de Transacciones";
            this.Load += new System.EventHandler(this.Form_MantenimientoTransacciones_Load);
            this.Grupo_Transacciones.ResumeLayout(false);
            this.Grupo_Transacciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaraGriew_Transacciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTransaccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet)).EndInit();
            this.Grupo_Documentacion.ResumeLayout(false);
            this.Grupo_Documentacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaraGriew_Documentacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDocumentosBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grupo_Transacciones;
        private System.Windows.Forms.TextBox Txt_DescripcionTransacciones;
        private System.Windows.Forms.TextBox Txt_CodigoTransacciones;
        private System.Windows.Forms.Button Bttn_Limpiar;
        private System.Windows.Forms.Button Bttn_Aceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Radio_AgregarTransacciones;
        private System.Windows.Forms.RadioButton Radio_ActualizarTransacciones;
        private System.Windows.Forms.DataGridView DaraGriew_Transacciones;
        private VentasAutoPartesDataSet ventasAutoPartesDataSet;
        private System.Windows.Forms.BindingSource tipoTransaccionBindingSource;
        private VentasAutoPartesDataSetTableAdapters.Tipo_TransaccionTableAdapter tipo_TransaccionTableAdapter;
        private System.Windows.Forms.GroupBox Grupo_Documentacion;
        private System.Windows.Forms.ComboBox Txt_EstadoDocumentacion;
        private System.Windows.Forms.TextBox Txt_DescripcionDocumentacion;
        private System.Windows.Forms.TextBox Txt_CodigoDocumentacion;
        private System.Windows.Forms.Button Bttn_LimpiaDocumentacion;
        private System.Windows.Forms.Button Bttn_AceptarDocumentacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton Radio_ActDocumentos;
        private System.Windows.Forms.BindingSource tiposDocumentosBindingSource;
        private VentasAutoPartesDataSetTableAdapters.Tipos_DocumentosTableAdapter tipos_DocumentosTableAdapter;
        private System.Windows.Forms.TextBox Txt_NaturalezaTransacciones;
        private System.Windows.Forms.DataGridView DaraGriew_Documentacion;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTipoTransaccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naturalezaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton Radio_AgregarDocumentos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
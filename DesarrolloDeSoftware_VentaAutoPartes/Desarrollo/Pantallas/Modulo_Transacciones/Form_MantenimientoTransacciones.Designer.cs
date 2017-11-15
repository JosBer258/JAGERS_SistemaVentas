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
            this.Radio_BusquedaTransacciones = new System.Windows.Forms.RadioButton();
            this.DaraGriew_Transacciones = new System.Windows.Forms.DataGridView();
            this.tipoTransaccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasAutoPartesDataSet = new Desarrollo.VentasAutoPartesDataSet();
            this.Grupo_OpcionManejo = new System.Windows.Forms.GroupBox();
            this.Radio_ManejoDocumentacion = new System.Windows.Forms.RadioButton();
            this.Radio_ManejoTransacciones = new System.Windows.Forms.RadioButton();
            this.tipo_TransaccionTableAdapter = new Desarrollo.VentasAutoPartesDataSetTableAdapters.Tipo_TransaccionTableAdapter();
            this.Grupo_Documentacion = new System.Windows.Forms.GroupBox();
            this.DaraGriew_Documentacion = new System.Windows.Forms.DataGridView();
            this.tiposDocumentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Txt_EstadoDocumentacion = new System.Windows.Forms.ComboBox();
            this.Txt_DescripcionDocumentacion = new System.Windows.Forms.TextBox();
            this.Txt_CodigoDocumentacion = new System.Windows.Forms.TextBox();
            this.Bttn_LimpiaDocumentacion = new System.Windows.Forms.Button();
            this.Bttn_AceptarDocumentacion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Radio_AgregarDocumentos = new System.Windows.Forms.RadioButton();
            this.Radio_BusquedaDocumentos = new System.Windows.Forms.RadioButton();
            this.tipos_DocumentosTableAdapter = new Desarrollo.VentasAutoPartesDataSetTableAdapters.Tipos_DocumentosTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.codigoTipoTransaccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naturalezaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTipoDeDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo_Transacciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaraGriew_Transacciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTransaccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet)).BeginInit();
            this.Grupo_OpcionManejo.SuspendLayout();
            this.Grupo_Documentacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaraGriew_Documentacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDocumentosBindingSource)).BeginInit();
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
            this.Grupo_Transacciones.Controls.Add(this.Radio_BusquedaTransacciones);
            this.Grupo_Transacciones.Controls.Add(this.DaraGriew_Transacciones);
            this.Grupo_Transacciones.Location = new System.Drawing.Point(12, 131);
            this.Grupo_Transacciones.Name = "Grupo_Transacciones";
            this.Grupo_Transacciones.Size = new System.Drawing.Size(697, 149);
            this.Grupo_Transacciones.TabIndex = 0;
            this.Grupo_Transacciones.TabStop = false;
            this.Grupo_Transacciones.Text = "Manejo de Transacciones";
            // 
            // Txt_NaturalezaTransacciones
            // 
            this.Txt_NaturalezaTransacciones.Location = new System.Drawing.Point(114, 117);
            this.Txt_NaturalezaTransacciones.Name = "Txt_NaturalezaTransacciones";
            this.Txt_NaturalezaTransacciones.Size = new System.Drawing.Size(128, 21);
            this.Txt_NaturalezaTransacciones.TabIndex = 11;
            // 
            // Txt_DescripcionTransacciones
            // 
            this.Txt_DescripcionTransacciones.Location = new System.Drawing.Point(114, 90);
            this.Txt_DescripcionTransacciones.Name = "Txt_DescripcionTransacciones";
            this.Txt_DescripcionTransacciones.Size = new System.Drawing.Size(128, 21);
            this.Txt_DescripcionTransacciones.TabIndex = 10;
            // 
            // Txt_CodigoTransacciones
            // 
            this.Txt_CodigoTransacciones.Location = new System.Drawing.Point(114, 66);
            this.Txt_CodigoTransacciones.Name = "Txt_CodigoTransacciones";
            this.Txt_CodigoTransacciones.Size = new System.Drawing.Size(87, 21);
            this.Txt_CodigoTransacciones.TabIndex = 9;
            // 
            // Bttn_Limpiar
            // 
            this.Bttn_Limpiar.Location = new System.Drawing.Point(278, 105);
            this.Bttn_Limpiar.Name = "Bttn_Limpiar";
            this.Bttn_Limpiar.Size = new System.Drawing.Size(75, 30);
            this.Bttn_Limpiar.TabIndex = 8;
            this.Bttn_Limpiar.Text = "Limpiar";
            this.Bttn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // Bttn_Aceptar
            // 
            this.Bttn_Aceptar.Location = new System.Drawing.Point(278, 66);
            this.Bttn_Aceptar.Name = "Bttn_Aceptar";
            this.Bttn_Aceptar.Size = new System.Drawing.Size(75, 30);
            this.Bttn_Aceptar.TabIndex = 7;
            this.Bttn_Aceptar.Text = "Aceptar";
            this.Bttn_Aceptar.UseVisualStyleBackColor = true;
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
            // Radio_BusquedaTransacciones
            // 
            this.Radio_BusquedaTransacciones.AutoSize = true;
            this.Radio_BusquedaTransacciones.Location = new System.Drawing.Point(28, 29);
            this.Radio_BusquedaTransacciones.Name = "Radio_BusquedaTransacciones";
            this.Radio_BusquedaTransacciones.Size = new System.Drawing.Size(89, 19);
            this.Radio_BusquedaTransacciones.TabIndex = 2;
            this.Radio_BusquedaTransacciones.TabStop = true;
            this.Radio_BusquedaTransacciones.Text = "Busqueda";
            this.Radio_BusquedaTransacciones.UseVisualStyleBackColor = true;
            // 
            // DaraGriew_Transacciones
            // 
            this.DaraGriew_Transacciones.AutoGenerateColumns = false;
            this.DaraGriew_Transacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaraGriew_Transacciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTipoTransaccionDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.naturalezaDataGridViewTextBoxColumn});
            this.DaraGriew_Transacciones.DataSource = this.tipoTransaccionBindingSource;
            this.DaraGriew_Transacciones.Location = new System.Drawing.Point(376, 15);
            this.DaraGriew_Transacciones.Name = "DaraGriew_Transacciones";
            this.DaraGriew_Transacciones.Size = new System.Drawing.Size(315, 120);
            this.DaraGriew_Transacciones.TabIndex = 0;
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
            // Grupo_OpcionManejo
            // 
            this.Grupo_OpcionManejo.Controls.Add(this.Radio_ManejoDocumentacion);
            this.Grupo_OpcionManejo.Controls.Add(this.Radio_ManejoTransacciones);
            this.Grupo_OpcionManejo.Location = new System.Drawing.Point(12, 22);
            this.Grupo_OpcionManejo.Name = "Grupo_OpcionManejo";
            this.Grupo_OpcionManejo.Size = new System.Drawing.Size(277, 94);
            this.Grupo_OpcionManejo.TabIndex = 1;
            this.Grupo_OpcionManejo.TabStop = false;
            this.Grupo_OpcionManejo.Text = "Opciones de Manejo";
            this.Grupo_OpcionManejo.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Radio_ManejoDocumentacion
            // 
            this.Radio_ManejoDocumentacion.AutoSize = true;
            this.Radio_ManejoDocumentacion.Location = new System.Drawing.Point(28, 58);
            this.Radio_ManejoDocumentacion.Name = "Radio_ManejoDocumentacion";
            this.Radio_ManejoDocumentacion.Size = new System.Drawing.Size(229, 19);
            this.Radio_ManejoDocumentacion.TabIndex = 1;
            this.Radio_ManejoDocumentacion.TabStop = true;
            this.Radio_ManejoDocumentacion.Text = "Manejo de Tipo de Documentos";
            this.Radio_ManejoDocumentacion.UseVisualStyleBackColor = true;
            this.Radio_ManejoDocumentacion.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Radio_ManejoTransacciones
            // 
            this.Radio_ManejoTransacciones.AutoSize = true;
            this.Radio_ManejoTransacciones.Location = new System.Drawing.Point(28, 33);
            this.Radio_ManejoTransacciones.Name = "Radio_ManejoTransacciones";
            this.Radio_ManejoTransacciones.Size = new System.Drawing.Size(238, 19);
            this.Radio_ManejoTransacciones.TabIndex = 0;
            this.Radio_ManejoTransacciones.TabStop = true;
            this.Radio_ManejoTransacciones.Text = "Manejo de tipo de Transacciones";
            this.Radio_ManejoTransacciones.UseVisualStyleBackColor = true;
            // 
            // tipo_TransaccionTableAdapter
            // 
            this.tipo_TransaccionTableAdapter.ClearBeforeFill = true;
            // 
            // Grupo_Documentacion
            // 
            this.Grupo_Documentacion.Controls.Add(this.DaraGriew_Documentacion);
            this.Grupo_Documentacion.Controls.Add(this.Txt_EstadoDocumentacion);
            this.Grupo_Documentacion.Controls.Add(this.Txt_DescripcionDocumentacion);
            this.Grupo_Documentacion.Controls.Add(this.Txt_CodigoDocumentacion);
            this.Grupo_Documentacion.Controls.Add(this.Bttn_LimpiaDocumentacion);
            this.Grupo_Documentacion.Controls.Add(this.Bttn_AceptarDocumentacion);
            this.Grupo_Documentacion.Controls.Add(this.label4);
            this.Grupo_Documentacion.Controls.Add(this.label5);
            this.Grupo_Documentacion.Controls.Add(this.label6);
            this.Grupo_Documentacion.Controls.Add(this.Radio_AgregarDocumentos);
            this.Grupo_Documentacion.Controls.Add(this.Radio_BusquedaDocumentos);
            this.Grupo_Documentacion.Location = new System.Drawing.Point(12, 296);
            this.Grupo_Documentacion.Name = "Grupo_Documentacion";
            this.Grupo_Documentacion.Size = new System.Drawing.Size(697, 149);
            this.Grupo_Documentacion.TabIndex = 12;
            this.Grupo_Documentacion.TabStop = false;
            this.Grupo_Documentacion.Text = "Manejo de Documentos";
            // 
            // DaraGriew_Documentacion
            // 
            this.DaraGriew_Documentacion.AutoGenerateColumns = false;
            this.DaraGriew_Documentacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaraGriew_Documentacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTipoDeDocumentoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn1,
            this.codigoEstadoDataGridViewTextBoxColumn});
            this.DaraGriew_Documentacion.DataSource = this.tiposDocumentosBindingSource;
            this.DaraGriew_Documentacion.Location = new System.Drawing.Point(376, 14);
            this.DaraGriew_Documentacion.Name = "DaraGriew_Documentacion";
            this.DaraGriew_Documentacion.Size = new System.Drawing.Size(315, 123);
            this.DaraGriew_Documentacion.TabIndex = 12;
            // 
            // tiposDocumentosBindingSource
            // 
            this.tiposDocumentosBindingSource.DataMember = "Tipos_Documentos";
            this.tiposDocumentosBindingSource.DataSource = this.ventasAutoPartesDataSet;
            // 
            // Txt_EstadoDocumentacion
            // 
            this.Txt_EstadoDocumentacion.FormattingEnabled = true;
            this.Txt_EstadoDocumentacion.Location = new System.Drawing.Point(114, 115);
            this.Txt_EstadoDocumentacion.Name = "Txt_EstadoDocumentacion";
            this.Txt_EstadoDocumentacion.Size = new System.Drawing.Size(128, 23);
            this.Txt_EstadoDocumentacion.TabIndex = 11;
            // 
            // Txt_DescripcionDocumentacion
            // 
            this.Txt_DescripcionDocumentacion.Location = new System.Drawing.Point(114, 90);
            this.Txt_DescripcionDocumentacion.Name = "Txt_DescripcionDocumentacion";
            this.Txt_DescripcionDocumentacion.Size = new System.Drawing.Size(128, 21);
            this.Txt_DescripcionDocumentacion.TabIndex = 10;
            // 
            // Txt_CodigoDocumentacion
            // 
            this.Txt_CodigoDocumentacion.Location = new System.Drawing.Point(114, 66);
            this.Txt_CodigoDocumentacion.Name = "Txt_CodigoDocumentacion";
            this.Txt_CodigoDocumentacion.Size = new System.Drawing.Size(87, 21);
            this.Txt_CodigoDocumentacion.TabIndex = 9;
            // 
            // Bttn_LimpiaDocumentacion
            // 
            this.Bttn_LimpiaDocumentacion.Location = new System.Drawing.Point(278, 105);
            this.Bttn_LimpiaDocumentacion.Name = "Bttn_LimpiaDocumentacion";
            this.Bttn_LimpiaDocumentacion.Size = new System.Drawing.Size(75, 30);
            this.Bttn_LimpiaDocumentacion.TabIndex = 8;
            this.Bttn_LimpiaDocumentacion.Text = "Limpiar";
            this.Bttn_LimpiaDocumentacion.UseVisualStyleBackColor = true;
            // 
            // Bttn_AceptarDocumentacion
            // 
            this.Bttn_AceptarDocumentacion.Location = new System.Drawing.Point(278, 66);
            this.Bttn_AceptarDocumentacion.Name = "Bttn_AceptarDocumentacion";
            this.Bttn_AceptarDocumentacion.Size = new System.Drawing.Size(75, 30);
            this.Bttn_AceptarDocumentacion.TabIndex = 7;
            this.Bttn_AceptarDocumentacion.Text = "Aceptar";
            this.Bttn_AceptarDocumentacion.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Codigo";
            // 
            // Radio_AgregarDocumentos
            // 
            this.Radio_AgregarDocumentos.AutoSize = true;
            this.Radio_AgregarDocumentos.Location = new System.Drawing.Point(188, 29);
            this.Radio_AgregarDocumentos.Name = "Radio_AgregarDocumentos";
            this.Radio_AgregarDocumentos.Size = new System.Drawing.Size(75, 19);
            this.Radio_AgregarDocumentos.TabIndex = 3;
            this.Radio_AgregarDocumentos.TabStop = true;
            this.Radio_AgregarDocumentos.Text = "Agregar";
            this.Radio_AgregarDocumentos.UseVisualStyleBackColor = true;
            // 
            // Radio_BusquedaDocumentos
            // 
            this.Radio_BusquedaDocumentos.AutoSize = true;
            this.Radio_BusquedaDocumentos.Location = new System.Drawing.Point(28, 29);
            this.Radio_BusquedaDocumentos.Name = "Radio_BusquedaDocumentos";
            this.Radio_BusquedaDocumentos.Size = new System.Drawing.Size(89, 19);
            this.Radio_BusquedaDocumentos.TabIndex = 2;
            this.Radio_BusquedaDocumentos.TabStop = true;
            this.Radio_BusquedaDocumentos.Text = "Busqueda";
            this.Radio_BusquedaDocumentos.UseVisualStyleBackColor = true;
            // 
            // tipos_DocumentosTableAdapter
            // 
            this.tipos_DocumentosTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(562, 455);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 57);
            this.button5.TabIndex = 13;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            // 
            // naturalezaDataGridViewTextBoxColumn
            // 
            this.naturalezaDataGridViewTextBoxColumn.DataPropertyName = "Naturaleza";
            this.naturalezaDataGridViewTextBoxColumn.HeaderText = "Naturaleza";
            this.naturalezaDataGridViewTextBoxColumn.Name = "naturalezaDataGridViewTextBoxColumn";
            // 
            // codigoTipoDeDocumentoDataGridViewTextBoxColumn
            // 
            this.codigoTipoDeDocumentoDataGridViewTextBoxColumn.DataPropertyName = "Codigo_TipoDeDocumento";
            this.codigoTipoDeDocumentoDataGridViewTextBoxColumn.HeaderText = "Codigo del Tipo";
            this.codigoTipoDeDocumentoDataGridViewTextBoxColumn.Name = "codigoTipoDeDocumentoDataGridViewTextBoxColumn";
            this.codigoTipoDeDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn1
            // 
            this.descripcionDataGridViewTextBoxColumn1.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn1.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn1.Name = "descripcionDataGridViewTextBoxColumn1";
            // 
            // codigoEstadoDataGridViewTextBoxColumn
            // 
            this.codigoEstadoDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Estado";
            this.codigoEstadoDataGridViewTextBoxColumn.HeaderText = "Codigo del Estado";
            this.codigoEstadoDataGridViewTextBoxColumn.Name = "codigoEstadoDataGridViewTextBoxColumn";
            // 
            // Form_MantenimientoTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(718, 524);
            this.ControlBox = false;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Grupo_Documentacion);
            this.Controls.Add(this.Grupo_Transacciones);
            this.Controls.Add(this.Grupo_OpcionManejo);
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
            this.Grupo_OpcionManejo.ResumeLayout(false);
            this.Grupo_OpcionManejo.PerformLayout();
            this.Grupo_Documentacion.ResumeLayout(false);
            this.Grupo_Documentacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaraGriew_Documentacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDocumentosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grupo_Transacciones;
        private System.Windows.Forms.GroupBox Grupo_OpcionManejo;
        private System.Windows.Forms.RadioButton Radio_ManejoDocumentacion;
        private System.Windows.Forms.RadioButton Radio_ManejoTransacciones;
        private System.Windows.Forms.TextBox Txt_DescripcionTransacciones;
        private System.Windows.Forms.TextBox Txt_CodigoTransacciones;
        private System.Windows.Forms.Button Bttn_Limpiar;
        private System.Windows.Forms.Button Bttn_Aceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Radio_AgregarTransacciones;
        private System.Windows.Forms.RadioButton Radio_BusquedaTransacciones;
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
        private System.Windows.Forms.RadioButton Radio_AgregarDocumentos;
        private System.Windows.Forms.RadioButton Radio_BusquedaDocumentos;
        private System.Windows.Forms.BindingSource tiposDocumentosBindingSource;
        private VentasAutoPartesDataSetTableAdapters.Tipos_DocumentosTableAdapter tipos_DocumentosTableAdapter;
        private System.Windows.Forms.TextBox Txt_NaturalezaTransacciones;
        private System.Windows.Forms.DataGridView DaraGriew_Documentacion;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTipoTransaccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naturalezaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTipoDeDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEstadoDataGridViewTextBoxColumn;
    }
}
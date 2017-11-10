namespace Desarrollo.Pantallas.Estados
{
    partial class Form_MantenimientoEstados
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
            this.Bttn_Salir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ventasAutoPartesDataSet = new Desarrollo.VentasAutoPartesDataSet();
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadosTableAdapter = new Desarrollo.VentasAutoPartesDataSetTableAdapters.EstadosTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_CodigoTipo = new System.Windows.Forms.TextBox();
            this.Txt_CodigoEstado = new System.Windows.Forms.TextBox();
            this.Txt_CodigoDescripcion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Radio_Agregar = new System.Windows.Forms.RadioButton();
            this.Radio_Manejo = new System.Windows.Forms.RadioButton();
            this.Radio_Busqueda = new System.Windows.Forms.RadioButton();
            this.codigoTipoEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bttn_Salir
            // 
            this.Bttn_Salir.Location = new System.Drawing.Point(422, 366);
            this.Bttn_Salir.Name = "Bttn_Salir";
            this.Bttn_Salir.Size = new System.Drawing.Size(136, 50);
            this.Bttn_Salir.TabIndex = 0;
            this.Bttn_Salir.Text = "Salir";
            this.Bttn_Salir.UseVisualStyleBackColor = true;
            this.Bttn_Salir.Click += new System.EventHandler(this.Bttn_Salir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTipoEstadoDataGridViewTextBoxColumn,
            this.codigoEstadoDataGridViewTextBoxColumn,
            this.descripcionEstadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.estadosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 170);
            this.dataGridView1.TabIndex = 1;
            // 
            // ventasAutoPartesDataSet
            // 
            this.ventasAutoPartesDataSet.DataSetName = "VentasAutoPartesDataSet";
            this.ventasAutoPartesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataMember = "Estados";
            this.estadosBindingSource.DataSource = this.ventasAutoPartesDataSet;
            // 
            // estadosTableAdapter
            // 
            this.estadosTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Radio_Busqueda);
            this.groupBox1.Controls.Add(this.Radio_Manejo);
            this.groupBox1.Controls.Add(this.Radio_Agregar);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Manejo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.Txt_CodigoDescripcion);
            this.groupBox2.Controls.Add(this.Txt_CodigoEstado);
            this.groupBox2.Controls.Add(this.Txt_CodigoTipo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(14, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 91);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manejo de Estados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo de Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion de Estado";
            // 
            // Txt_CodigoTipo
            // 
            this.Txt_CodigoTipo.Location = new System.Drawing.Point(141, 23);
            this.Txt_CodigoTipo.MaxLength = 2;
            this.Txt_CodigoTipo.Name = "Txt_CodigoTipo";
            this.Txt_CodigoTipo.Size = new System.Drawing.Size(67, 20);
            this.Txt_CodigoTipo.TabIndex = 3;
            // 
            // Txt_CodigoEstado
            // 
            this.Txt_CodigoEstado.Location = new System.Drawing.Point(141, 50);
            this.Txt_CodigoEstado.MaxLength = 2;
            this.Txt_CodigoEstado.Name = "Txt_CodigoEstado";
            this.Txt_CodigoEstado.Size = new System.Drawing.Size(67, 20);
            this.Txt_CodigoEstado.TabIndex = 4;
            // 
            // Txt_CodigoDescripcion
            // 
            this.Txt_CodigoDescripcion.Location = new System.Drawing.Point(356, 23);
            this.Txt_CodigoDescripcion.MaxLength = 30;
            this.Txt_CodigoDescripcion.Name = "Txt_CodigoDescripcion";
            this.Txt_CodigoDescripcion.Size = new System.Drawing.Size(181, 20);
            this.Txt_CodigoDescripcion.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Radio_Agregar
            // 
            this.Radio_Agregar.AutoSize = true;
            this.Radio_Agregar.Location = new System.Drawing.Point(27, 19);
            this.Radio_Agregar.Name = "Radio_Agregar";
            this.Radio_Agregar.Size = new System.Drawing.Size(69, 17);
            this.Radio_Agregar.TabIndex = 0;
            this.Radio_Agregar.TabStop = true;
            this.Radio_Agregar.Text = "Agregar";
            this.Radio_Agregar.UseVisualStyleBackColor = true;
            // 
            // Radio_Manejo
            // 
            this.Radio_Manejo.AutoSize = true;
            this.Radio_Manejo.Location = new System.Drawing.Point(27, 43);
            this.Radio_Manejo.Name = "Radio_Manejo";
            this.Radio_Manejo.Size = new System.Drawing.Size(66, 17);
            this.Radio_Manejo.TabIndex = 1;
            this.Radio_Manejo.TabStop = true;
            this.Radio_Manejo.Text = "Manejo";
            this.Radio_Manejo.UseVisualStyleBackColor = true;
            // 
            // Radio_Busqueda
            // 
            this.Radio_Busqueda.AutoSize = true;
            this.Radio_Busqueda.Location = new System.Drawing.Point(119, 19);
            this.Radio_Busqueda.Name = "Radio_Busqueda";
            this.Radio_Busqueda.Size = new System.Drawing.Size(81, 17);
            this.Radio_Busqueda.TabIndex = 2;
            this.Radio_Busqueda.TabStop = true;
            this.Radio_Busqueda.Text = "Busqueda";
            this.Radio_Busqueda.UseVisualStyleBackColor = true;
            // 
            // codigoTipoEstadoDataGridViewTextBoxColumn
            // 
            this.codigoTipoEstadoDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Tipo_Estado";
            this.codigoTipoEstadoDataGridViewTextBoxColumn.HeaderText = "Codigo Tipo de Estado";
            this.codigoTipoEstadoDataGridViewTextBoxColumn.Name = "codigoTipoEstadoDataGridViewTextBoxColumn";
            // 
            // codigoEstadoDataGridViewTextBoxColumn
            // 
            this.codigoEstadoDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Estado";
            this.codigoEstadoDataGridViewTextBoxColumn.HeaderText = "Codigo de Estado";
            this.codigoEstadoDataGridViewTextBoxColumn.Name = "codigoEstadoDataGridViewTextBoxColumn";
            // 
            // descripcionEstadoDataGridViewTextBoxColumn
            // 
            this.descripcionEstadoDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Estado";
            this.descripcionEstadoDataGridViewTextBoxColumn.HeaderText = "Descripcion de Estado";
            this.descripcionEstadoDataGridViewTextBoxColumn.Name = "descripcionEstadoDataGridViewTextBoxColumn";
            // 
            // Form_MantenimientoEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 428);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Bttn_Salir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_MantenimientoEstados";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Mantenimiento de Estados";
            this.Load += new System.EventHandler(this.Form_MantenimientoEstados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bttn_Salir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VentasAutoPartesDataSet ventasAutoPartesDataSet;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private VentasAutoPartesDataSetTableAdapters.EstadosTableAdapter estadosTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Radio_Busqueda;
        private System.Windows.Forms.RadioButton Radio_Manejo;
        private System.Windows.Forms.RadioButton Radio_Agregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Txt_CodigoDescripcion;
        private System.Windows.Forms.TextBox Txt_CodigoEstado;
        private System.Windows.Forms.TextBox Txt_CodigoTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTipoEstadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEstadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionEstadoDataGridViewTextBoxColumn;
    }
}
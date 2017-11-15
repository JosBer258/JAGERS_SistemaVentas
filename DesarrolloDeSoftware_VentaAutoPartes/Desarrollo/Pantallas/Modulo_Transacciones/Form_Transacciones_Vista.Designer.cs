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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.RadioOpcion_Tipo = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RadioOpcion_Estado = new System.Windows.Forms.RadioButton();
            this.transaccionesTableAdapter = new Desarrollo.VentasAutoPartesDataSetTableAdapters.TransaccionesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DG_CodigoTransaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_CodigoDeDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_TipoTransaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_TipoDocumentaciom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_FechaRealizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_ID_Padre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_PorMora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(9, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 484);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manejo de Transacciones";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(353, 28);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(106, 21);
            this.textBox8.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Monto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Numero de Documento";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(175, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(106, 21);
            this.textBox2.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(493, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 44);
            this.button4.TabIndex = 11;
            this.button4.Text = "Aplicar Mora";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(603, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 44);
            this.button5.TabIndex = 10;
            this.button5.Text = "Limpiar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo de Transaccion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 21);
            this.textBox1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(612, 435);
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
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.RadioOpcion_Tipo);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.RadioOpcion_Estado);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(722, 86);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aplicar Filtros de Busqueda";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(641, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(560, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(237, 45);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(99, 21);
            this.comboBox3.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(403, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(403, 26);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(151, 17);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Fecha de Vencimiento";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(237, 26);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(160, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Tipo de Documentacion";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(125, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(99, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // RadioOpcion_Tipo
            // 
            this.RadioOpcion_Tipo.AutoSize = true;
            this.RadioOpcion_Tipo.Location = new System.Drawing.Point(128, 28);
            this.RadioOpcion_Tipo.Name = "RadioOpcion_Tipo";
            this.RadioOpcion_Tipo.Size = new System.Drawing.Size(56, 17);
            this.RadioOpcion_Tipo.TabIndex = 2;
            this.RadioOpcion_Tipo.TabStop = true;
            this.RadioOpcion_Tipo.Text = "Tipos";
            this.RadioOpcion_Tipo.UseVisualStyleBackColor = true;
            this.RadioOpcion_Tipo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // RadioOpcion_Estado
            // 
            this.RadioOpcion_Estado.AutoSize = true;
            this.RadioOpcion_Estado.Location = new System.Drawing.Point(10, 28);
            this.RadioOpcion_Estado.Name = "RadioOpcion_Estado";
            this.RadioOpcion_Estado.Size = new System.Drawing.Size(70, 17);
            this.RadioOpcion_Estado.TabIndex = 0;
            this.RadioOpcion_Estado.TabStop = true;
            this.RadioOpcion_Estado.Text = "Estados";
            this.RadioOpcion_Estado.UseVisualStyleBackColor = true;
            // 
            // transaccionesTableAdapter
            // 
            this.transaccionesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DG_CodigoTransaccion,
            this.DG_CodigoDeDocumento,
            this.DG_TipoTransaccion,
            this.DG_TipoDocumentaciom,
            this.DG_FechaRealizacion,
            this.DG_Monto,
            this.DG_Cliente,
            this.DG_FechaVencimiento,
            this.DG_ID_Padre,
            this.DG_PorMora});
            this.dataGridView1.Location = new System.Drawing.Point(9, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 324);
            this.dataGridView1.TabIndex = 28;
            // 
            // DG_CodigoTransaccion
            // 
            this.DG_CodigoTransaccion.HeaderText = "Codigo de Transaccion";
            this.DG_CodigoTransaccion.Name = "DG_CodigoTransaccion";
            this.DG_CodigoTransaccion.ReadOnly = true;
            // 
            // DG_CodigoDeDocumento
            // 
            this.DG_CodigoDeDocumento.HeaderText = "N. de Documento";
            this.DG_CodigoDeDocumento.Name = "DG_CodigoDeDocumento";
            this.DG_CodigoDeDocumento.ReadOnly = true;
            // 
            // DG_TipoTransaccion
            // 
            this.DG_TipoTransaccion.HeaderText = "Tipo de Transaccion";
            this.DG_TipoTransaccion.Name = "DG_TipoTransaccion";
            this.DG_TipoTransaccion.ReadOnly = true;
            // 
            // DG_TipoDocumentaciom
            // 
            this.DG_TipoDocumentaciom.HeaderText = "Tipo de Documentacion";
            this.DG_TipoDocumentaciom.Name = "DG_TipoDocumentaciom";
            this.DG_TipoDocumentaciom.ReadOnly = true;
            // 
            // DG_FechaRealizacion
            // 
            this.DG_FechaRealizacion.HeaderText = "Fecha de Realizacion";
            this.DG_FechaRealizacion.Name = "DG_FechaRealizacion";
            this.DG_FechaRealizacion.ReadOnly = true;
            // 
            // DG_Monto
            // 
            this.DG_Monto.HeaderText = "Monto Total";
            this.DG_Monto.Name = "DG_Monto";
            this.DG_Monto.ReadOnly = true;
            // 
            // DG_Cliente
            // 
            this.DG_Cliente.HeaderText = "Nombre del Cliente";
            this.DG_Cliente.Name = "DG_Cliente";
            this.DG_Cliente.ReadOnly = true;
            // 
            // DG_FechaVencimiento
            // 
            this.DG_FechaVencimiento.HeaderText = "Fecha de Vencimiento";
            this.DG_FechaVencimiento.Name = "DG_FechaVencimiento";
            this.DG_FechaVencimiento.ReadOnly = true;
            // 
            // DG_ID_Padre
            // 
            this.DG_ID_Padre.HeaderText = "ID de Transaccion Padre";
            this.DG_ID_Padre.Name = "DG_ID_Padre";
            this.DG_ID_Padre.ReadOnly = true;
            // 
            // DG_PorMora
            // 
            this.DG_PorMora.HeaderText = "Porcentaje de Mora";
            this.DG_PorMora.Name = "DG_PorMora";
            this.DG_PorMora.ReadOnly = true;
            // 
            // Form_Transacciones_Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(739, 604);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_Transacciones_Vista";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form_Transacciones_Vista";
            this.Load += new System.EventHandler(this.Form_Transacciones_Vista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RadioButton RadioOpcion_Tipo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton RadioOpcion_Estado;
        private VentasAutoPartesDataSet ventasAutoPartesDataSet;
        private System.Windows.Forms.BindingSource transaccionesBindingSource;
        private VentasAutoPartesDataSetTableAdapters.TransaccionesTableAdapter transaccionesTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_CodigoTransaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_CodigoDeDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_TipoTransaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_TipoDocumentaciom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_FechaRealizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_FechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_ID_Padre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_PorMora;
    }
}
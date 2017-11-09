namespace Desarrollo.Pantallas.Modulo__Empleados
{
    partial class Form_ManejoRoles
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.ventasAutoPartesDataSet = new Desarrollo.VentasAutoPartesDataSet();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolTableAdapter = new Desarrollo.VentasAutoPartesDataSetTableAdapters.RolTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.fKEmpleadosRolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new Desarrollo.VentasAutoPartesDataSetTableAdapters.EmpleadosTableAdapter();
            this.rolBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.codigoRolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmpleadosRolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoRolDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rolBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(347, 108);
            this.dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Guardar);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 83);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar Rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(49, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(45, 20);
            this.textBox3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Codigo";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(170, 19);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(171, 20);
            this.textBox4.TabIndex = 9;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(267, 45);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(74, 31);
            this.Guardar.TabIndex = 9;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            // 
            // ventasAutoPartesDataSet
            // 
            this.ventasAutoPartesDataSet.DataSetName = "VentasAutoPartesDataSet";
            this.ventasAutoPartesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataMember = "Rol";
            this.rolBindingSource.DataSource = this.ventasAutoPartesDataSet;
            // 
            // rolTableAdapter
            // 
            this.rolTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(12, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 80);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones de Manejo";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Agregar";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Modificar";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // fKEmpleadosRolBindingSource
            // 
            this.fKEmpleadosRolBindingSource.DataMember = "FK_Empleados_Rol";
            this.fKEmpleadosRolBindingSource.DataSource = this.rolBindingSource;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // rolBindingSource1
            // 
            this.rolBindingSource1.DataMember = "Rol";
            this.rolBindingSource1.DataSource = this.ventasAutoPartesDataSet;
            // 
            // codigoRolDataGridViewTextBoxColumn
            // 
            this.codigoRolDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Rol";
            this.codigoRolDataGridViewTextBoxColumn.HeaderText = "Codigo de Rol";
            this.codigoRolDataGridViewTextBoxColumn.Name = "codigoRolDataGridViewTextBoxColumn";
            this.codigoRolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form_ManejoRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(372, 348);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_ManejoRoles";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Manejo de Roles";
            this.Load += new System.EventHandler(this.Form_ManejoRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmpleadosRolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private VentasAutoPartesDataSet ventasAutoPartesDataSet;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private VentasAutoPartesDataSetTableAdapters.RolTableAdapter rolTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.BindingSource fKEmpleadosRolBindingSource;
        private VentasAutoPartesDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoRolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rolBindingSource1;
    }
}
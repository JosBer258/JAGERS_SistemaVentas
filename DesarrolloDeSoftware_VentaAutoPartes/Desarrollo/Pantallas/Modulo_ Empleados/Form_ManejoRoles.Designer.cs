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
            this.DataG_ManejoRol = new System.Windows.Forms.DataGridView();
            this.codigoRolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ventasAutoPartesDataSet = new Desarrollo.VentasAutoPartesDataSet();
            this.Bttn_Salir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bttn_Guardar = new System.Windows.Forms.Button();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolTableAdapter = new Desarrollo.VentasAutoPartesDataSetTableAdapters.RolTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Radio_Modificar = new System.Windows.Forms.RadioButton();
            this.Radio_Agregar = new System.Windows.Forms.RadioButton();
            this.fKEmpleadosRolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new Desarrollo.VentasAutoPartesDataSetTableAdapters.EmpleadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataG_ManejoRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmpleadosRolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataG_ManejoRol
            // 
            this.DataG_ManejoRol.AutoGenerateColumns = false;
            this.DataG_ManejoRol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataG_ManejoRol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataG_ManejoRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataG_ManejoRol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoRolDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.DataG_ManejoRol.DataSource = this.rolBindingSource1;
            this.DataG_ManejoRol.Location = new System.Drawing.Point(14, 187);
            this.DataG_ManejoRol.Name = "DataG_ManejoRol";
            this.DataG_ManejoRol.ReadOnly = true;
            this.DataG_ManejoRol.Size = new System.Drawing.Size(405, 108);
            this.DataG_ManejoRol.TabIndex = 0;
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
            // rolBindingSource1
            // 
            this.rolBindingSource1.DataMember = "Rol";
            this.rolBindingSource1.DataSource = this.ventasAutoPartesDataSet;
            // 
            // ventasAutoPartesDataSet
            // 
            this.ventasAutoPartesDataSet.DataSetName = "VentasAutoPartesDataSet";
            this.ventasAutoPartesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Bttn_Salir
            // 
            this.Bttn_Salir.Location = new System.Drawing.Point(310, 301);
            this.Bttn_Salir.Name = "Bttn_Salir";
            this.Bttn_Salir.Size = new System.Drawing.Size(108, 35);
            this.Bttn_Salir.TabIndex = 2;
            this.Bttn_Salir.Text = "Salir";
            this.Bttn_Salir.UseVisualStyleBackColor = true;
            this.Bttn_Salir.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Bttn_Guardar);
            this.groupBox1.Controls.Add(this.Txt_Descripcion);
            this.groupBox1.Controls.Add(this.Txt_Codigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(14, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 83);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de Datos";
            // 
            // Bttn_Guardar
            // 
            this.Bttn_Guardar.Location = new System.Drawing.Point(311, 45);
            this.Bttn_Guardar.Name = "Bttn_Guardar";
            this.Bttn_Guardar.Size = new System.Drawing.Size(86, 31);
            this.Bttn_Guardar.TabIndex = 9;
            this.Bttn_Guardar.Text = "Guardar";
            this.Bttn_Guardar.UseVisualStyleBackColor = true;
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(198, 19);
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(199, 20);
            this.Txt_Descripcion.TabIndex = 9;
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(57, 19);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(52, 20);
            this.Txt_Codigo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Codigo";
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
            this.groupBox2.Controls.Add(this.Radio_Modificar);
            this.groupBox2.Controls.Add(this.Radio_Agregar);
            this.groupBox2.Location = new System.Drawing.Point(14, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 80);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones de Manejo";
            // 
            // Radio_Modificar
            // 
            this.Radio_Modificar.AutoSize = true;
            this.Radio_Modificar.Location = new System.Drawing.Point(19, 49);
            this.Radio_Modificar.Name = "Radio_Modificar";
            this.Radio_Modificar.Size = new System.Drawing.Size(77, 17);
            this.Radio_Modificar.TabIndex = 1;
            this.Radio_Modificar.TabStop = true;
            this.Radio_Modificar.Text = "Modificar";
            this.Radio_Modificar.UseVisualStyleBackColor = true;
            // 
            // Radio_Agregar
            // 
            this.Radio_Agregar.AutoSize = true;
            this.Radio_Agregar.Location = new System.Drawing.Point(19, 26);
            this.Radio_Agregar.Name = "Radio_Agregar";
            this.Radio_Agregar.Size = new System.Drawing.Size(69, 17);
            this.Radio_Agregar.TabIndex = 0;
            this.Radio_Agregar.TabStop = true;
            this.Radio_Agregar.Text = "Agregar";
            this.Radio_Agregar.UseVisualStyleBackColor = true;
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
            // Form_ManejoRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(434, 348);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Bttn_Salir);
            this.Controls.Add(this.DataG_ManejoRol);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_ManejoRoles";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Manejo de Roles";
            this.Load += new System.EventHandler(this.Form_ManejoRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataG_ManejoRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmpleadosRolBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataG_ManejoRol;
        private System.Windows.Forms.Button Bttn_Salir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Bttn_Guardar;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private VentasAutoPartesDataSet ventasAutoPartesDataSet;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private VentasAutoPartesDataSetTableAdapters.RolTableAdapter rolTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Radio_Modificar;
        private System.Windows.Forms.RadioButton Radio_Agregar;
        private System.Windows.Forms.BindingSource fKEmpleadosRolBindingSource;
        private VentasAutoPartesDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoRolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rolBindingSource1;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ManejoRoles));
            this.Bttn_Salir = new System.Windows.Forms.Button();
            this.Grupo_IngresoDatos = new System.Windows.Forms.GroupBox();
            this.Bttn_Guardar = new System.Windows.Forms.Button();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Grupo_OpcionesManejo = new System.Windows.Forms.GroupBox();
            this.Radio_Modificar = new System.Windows.Forms.RadioButton();
            this.Radio_Agregar = new System.Windows.Forms.RadioButton();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasAutoPartesDataSet = new Desarrollo.VentasAutoPartesDataSet();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rolTableAdapter = new Desarrollo.VentasAutoPartesDataSetTableAdapters.RolTableAdapter();
            this.empleadosTableAdapter = new Desarrollo.VentasAutoPartesDataSetTableAdapters.EmpleadosTableAdapter();
            this.rolBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comprasTableAdapter = new Desarrollo.VentasAutoPartesDataSetTableAdapters.ComprasTableAdapter();
            this.DataGriew_MuestraDatos = new System.Windows.Forms.DataGridView();
            this.rolBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.ventasAutoPartesDataSet1 = new Desarrollo.VentasAutoPartesDataSet();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Imagen_1 = new System.Windows.Forms.PictureBox();
            this.fKEmpleadosRolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Grupo_IngresoDatos.SuspendLayout();
            this.Grupo_OpcionesManejo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriew_MuestraDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmpleadosRolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Bttn_Salir
            // 
            this.Bttn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttn_Salir.Location = new System.Drawing.Point(318, 394);
            this.Bttn_Salir.Name = "Bttn_Salir";
            this.Bttn_Salir.Size = new System.Drawing.Size(108, 35);
            this.Bttn_Salir.TabIndex = 2;
            this.Bttn_Salir.Text = "Salir";
            this.Bttn_Salir.UseVisualStyleBackColor = true;
            this.Bttn_Salir.Click += new System.EventHandler(this.button2_Click);
            // 
            // Grupo_IngresoDatos
            // 
            this.Grupo_IngresoDatos.Controls.Add(this.Bttn_Guardar);
            this.Grupo_IngresoDatos.Controls.Add(this.Txt_Descripcion);
            this.Grupo_IngresoDatos.Controls.Add(this.Txt_Codigo);
            this.Grupo_IngresoDatos.Controls.Add(this.label2);
            this.Grupo_IngresoDatos.Controls.Add(this.label3);
            this.Grupo_IngresoDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo_IngresoDatos.Location = new System.Drawing.Point(14, 94);
            this.Grupo_IngresoDatos.Name = "Grupo_IngresoDatos";
            this.Grupo_IngresoDatos.Size = new System.Drawing.Size(412, 95);
            this.Grupo_IngresoDatos.TabIndex = 5;
            this.Grupo_IngresoDatos.TabStop = false;
            this.Grupo_IngresoDatos.Text = "Ingreso de Datos";
            // 
            // Bttn_Guardar
            // 
            this.Bttn_Guardar.Location = new System.Drawing.Point(285, 54);
            this.Bttn_Guardar.Name = "Bttn_Guardar";
            this.Bttn_Guardar.Size = new System.Drawing.Size(108, 35);
            this.Bttn_Guardar.TabIndex = 9;
            this.Bttn_Guardar.Text = "Guardar";
            this.Bttn_Guardar.UseVisualStyleBackColor = true;
            this.Bttn_Guardar.Click += new System.EventHandler(this.Bttn_Guardar_Click);
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Descripcion.Location = new System.Drawing.Point(226, 26);
            this.Txt_Descripcion.MaxLength = 15;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(167, 21);
            this.Txt_Descripcion.TabIndex = 9;
            this.Txt_Descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Descripcion_KeyPress);
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Codigo.Location = new System.Drawing.Point(63, 26);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(52, 21);
            this.Txt_Codigo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Codigo";
            // 
            // Grupo_OpcionesManejo
            // 
            this.Grupo_OpcionesManejo.Controls.Add(this.Radio_Modificar);
            this.Grupo_OpcionesManejo.Controls.Add(this.Radio_Agregar);
            this.Grupo_OpcionesManejo.Location = new System.Drawing.Point(14, 7);
            this.Grupo_OpcionesManejo.Name = "Grupo_OpcionesManejo";
            this.Grupo_OpcionesManejo.Size = new System.Drawing.Size(160, 80);
            this.Grupo_OpcionesManejo.TabIndex = 9;
            this.Grupo_OpcionesManejo.TabStop = false;
            this.Grupo_OpcionesManejo.Text = "Opciones de Manejo";
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
            this.Radio_Agregar.CheckedChanged += new System.EventHandler(this.Radio_Agregar_CheckedChanged);
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataMember = "Rol";
            this.rolBindingSource.DataSource = this.ventasAutoPartesDataSet;
            // 
            // ventasAutoPartesDataSet
            // 
            this.ventasAutoPartesDataSet.DataSetName = "VentasAutoPartesDataSet";
            this.ventasAutoPartesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.ventasAutoPartesDataSet;
            // 
            // rolBindingSource1
            // 
            this.rolBindingSource1.DataMember = "Rol";
            this.rolBindingSource1.DataSource = this.ventasAutoPartesDataSet;
            // 
            // rolTableAdapter
            // 
            this.rolTableAdapter.ClearBeforeFill = true;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // rolBindingSource2
            // 
            this.rolBindingSource2.DataMember = "Rol";
            this.rolBindingSource2.DataSource = this.ventasAutoPartesDataSet;
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataMember = "Compras";
            this.comprasBindingSource.DataSource = this.ventasAutoPartesDataSet;
            // 
            // comprasTableAdapter
            // 
            this.comprasTableAdapter.ClearBeforeFill = true;
            // 
            // DataGriew_MuestraDatos
            // 
            this.DataGriew_MuestraDatos.AllowUserToAddRows = false;
            this.DataGriew_MuestraDatos.AllowUserToDeleteRows = false;
            this.DataGriew_MuestraDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGriew_MuestraDatos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGriew_MuestraDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGriew_MuestraDatos.Location = new System.Drawing.Point(14, 206);
            this.DataGriew_MuestraDatos.Name = "DataGriew_MuestraDatos";
            this.DataGriew_MuestraDatos.ReadOnly = true;
            this.DataGriew_MuestraDatos.Size = new System.Drawing.Size(412, 161);
            this.DataGriew_MuestraDatos.TabIndex = 10;
            this.DataGriew_MuestraDatos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGriew_MuestraDatos_CellContentDoubleClick);
            // 
            // rolBindingSource3
            // 
            this.rolBindingSource3.DataMember = "Rol";
            this.rolBindingSource3.DataSource = this.ventasAutoPartesDataSet1;
            // 
            // ventasAutoPartesDataSet1
            // 
            this.ventasAutoPartesDataSet1.DataSetName = "VentasAutoPartesDataSet";
            this.ventasAutoPartesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.Transparent;
            this.Picture.Image = ((System.Drawing.Image)(resources.GetObject("Picture.Image")));
            this.Picture.Location = new System.Drawing.Point(23, 210);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(14, 15);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 12;
            this.Picture.TabStop = false;
            this.toolTip1.SetToolTip(this.Picture, "Dele doble clic al Código \r\ndel Rol que usted desea Modificar\r\n");
            // 
            // Imagen_1
            // 
            this.Imagen_1.Image = ((System.Drawing.Image)(resources.GetObject("Imagen_1.Image")));
            this.Imagen_1.Location = new System.Drawing.Point(335, 7);
            this.Imagen_1.Name = "Imagen_1";
            this.Imagen_1.Size = new System.Drawing.Size(91, 89);
            this.Imagen_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen_1.TabIndex = 11;
            this.Imagen_1.TabStop = false;
            // 
            // fKEmpleadosRolBindingSource
            // 
            this.fKEmpleadosRolBindingSource.DataMember = "FK_Empleados_Rol";
            this.fKEmpleadosRolBindingSource.DataSource = this.rolBindingSource;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_ManejoRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(448, 463);
            this.ControlBox = false;
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.Imagen_1);
            this.Controls.Add(this.DataGriew_MuestraDatos);
            this.Controls.Add(this.Grupo_OpcionesManejo);
            this.Controls.Add(this.Grupo_IngresoDatos);
            this.Controls.Add(this.Bttn_Salir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_ManejoRoles";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Manejo de Roles";
            this.Load += new System.EventHandler(this.Form_ManejoRoles_Load);
            this.Grupo_IngresoDatos.ResumeLayout(false);
            this.Grupo_IngresoDatos.PerformLayout();
            this.Grupo_OpcionesManejo.ResumeLayout(false);
            this.Grupo_OpcionesManejo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriew_MuestraDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmpleadosRolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Bttn_Salir;
        private System.Windows.Forms.GroupBox Grupo_IngresoDatos;
        private System.Windows.Forms.Button Bttn_Guardar;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private VentasAutoPartesDataSet ventasAutoPartesDataSet;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private VentasAutoPartesDataSetTableAdapters.RolTableAdapter rolTableAdapter;
        private System.Windows.Forms.GroupBox Grupo_OpcionesManejo;
        private System.Windows.Forms.RadioButton Radio_Modificar;
        private System.Windows.Forms.RadioButton Radio_Agregar;
        private System.Windows.Forms.BindingSource fKEmpleadosRolBindingSource;
        private VentasAutoPartesDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.BindingSource rolBindingSource1;
        private System.Windows.Forms.BindingSource rolBindingSource2;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private VentasAutoPartesDataSetTableAdapters.ComprasTableAdapter comprasTableAdapter;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private System.Windows.Forms.DataGridView DataGriew_MuestraDatos;
        private VentasAutoPartesDataSet ventasAutoPartesDataSet1;
        private System.Windows.Forms.BindingSource rolBindingSource3;
        private System.Windows.Forms.PictureBox Imagen_1;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
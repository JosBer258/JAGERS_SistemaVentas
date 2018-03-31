namespace Desarrollo.Pantallas.Modulo_Ventas_Manejo
{
    partial class Form_MantenimientoCai
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
            this.dataGrid_VentasCai = new System.Windows.Forms.DataGridView();
            this.caiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasAutoPartesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasAutoPartesDataSet = new Desarrollo.VentasAutoPartesDataSet();
            this.gb_ModificarCai = new System.Windows.Forms.GroupBox();
            this.lb_FechaLimite = new System.Windows.Forms.Label();
            this.date_FechaLimite = new System.Windows.Forms.DateTimePicker();
            this.lb_RangoFinal = new System.Windows.Forms.Label();
            this.txt_RangoFinal = new System.Windows.Forms.TextBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lb_RangoInicial = new System.Windows.Forms.Label();
            this.txt_RangoInicial = new System.Windows.Forms.TextBox();
            this.lb_ClaveCai = new System.Windows.Forms.Label();
            this.txt_ClaveCai = new System.Windows.Forms.TextBox();
            this.lb_Codigo = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.rb_BuscarDatosCod = new System.Windows.Forms.RadioButton();
            this.rb_AgregarCodigoCai = new System.Windows.Forms.RadioButton();
            this.caiTableAdapter = new Desarrollo.VentasAutoPartesDataSetTableAdapters.CaiTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_VentasCai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet)).BeginInit();
            this.gb_ModificarCai.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(12, 402);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(153, 47);
            this.btn_Salir.TabIndex = 26;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // dataGrid_VentasCai
            // 
            this.dataGrid_VentasCai.AllowUserToAddRows = false;
            this.dataGrid_VentasCai.AllowUserToDeleteRows = false;
            this.dataGrid_VentasCai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_VentasCai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_VentasCai.Location = new System.Drawing.Point(12, 210);
            this.dataGrid_VentasCai.Name = "dataGrid_VentasCai";
            this.dataGrid_VentasCai.ReadOnly = true;
            this.dataGrid_VentasCai.Size = new System.Drawing.Size(763, 186);
            this.dataGrid_VentasCai.TabIndex = 25;
            this.dataGrid_VentasCai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_VentasCai_CellContentClick_1);
            // 
            // caiBindingSource
            // 
            this.caiBindingSource.DataMember = "Cai";
            this.caiBindingSource.DataSource = this.ventasAutoPartesDataSetBindingSource;
            // 
            // ventasAutoPartesDataSetBindingSource
            // 
            this.ventasAutoPartesDataSetBindingSource.DataSource = this.ventasAutoPartesDataSet;
            this.ventasAutoPartesDataSetBindingSource.Position = 0;
            // 
            // ventasAutoPartesDataSet
            // 
            this.ventasAutoPartesDataSet.DataSetName = "VentasAutoPartesDataSet";
            this.ventasAutoPartesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gb_ModificarCai
            // 
            this.gb_ModificarCai.Controls.Add(this.lb_FechaLimite);
            this.gb_ModificarCai.Controls.Add(this.date_FechaLimite);
            this.gb_ModificarCai.Controls.Add(this.lb_RangoFinal);
            this.gb_ModificarCai.Controls.Add(this.txt_RangoFinal);
            this.gb_ModificarCai.Controls.Add(this.btn_Agregar);
            this.gb_ModificarCai.Controls.Add(this.lb_RangoInicial);
            this.gb_ModificarCai.Controls.Add(this.txt_RangoInicial);
            this.gb_ModificarCai.Controls.Add(this.lb_ClaveCai);
            this.gb_ModificarCai.Controls.Add(this.txt_ClaveCai);
            this.gb_ModificarCai.Controls.Add(this.lb_Codigo);
            this.gb_ModificarCai.Controls.Add(this.txt_Codigo);
            this.gb_ModificarCai.Location = new System.Drawing.Point(12, 48);
            this.gb_ModificarCai.Name = "gb_ModificarCai";
            this.gb_ModificarCai.Size = new System.Drawing.Size(562, 146);
            this.gb_ModificarCai.TabIndex = 24;
            this.gb_ModificarCai.TabStop = false;
            this.gb_ModificarCai.Text = "Agregar Cai";
            // 
            // lb_FechaLimite
            // 
            this.lb_FechaLimite.AutoSize = true;
            this.lb_FechaLimite.Location = new System.Drawing.Point(21, 115);
            this.lb_FechaLimite.Name = "lb_FechaLimite";
            this.lb_FechaLimite.Size = new System.Drawing.Size(83, 13);
            this.lb_FechaLimite.TabIndex = 11;
            this.lb_FechaLimite.Text = "Fecha Limite:";
            // 
            // date_FechaLimite
            // 
            this.date_FechaLimite.Location = new System.Drawing.Point(121, 108);
            this.date_FechaLimite.Name = "date_FechaLimite";
            this.date_FechaLimite.Size = new System.Drawing.Size(131, 20);
            this.date_FechaLimite.TabIndex = 10;
            this.date_FechaLimite.ValueChanged += new System.EventHandler(this.date_FechaLimite_ValueChanged);
            // 
            // lb_RangoFinal
            // 
            this.lb_RangoFinal.AutoSize = true;
            this.lb_RangoFinal.Location = new System.Drawing.Point(306, 69);
            this.lb_RangoFinal.Name = "lb_RangoFinal";
            this.lb_RangoFinal.Size = new System.Drawing.Size(79, 13);
            this.lb_RangoFinal.TabIndex = 9;
            this.lb_RangoFinal.Text = "Rango Final:";
            // 
            // txt_RangoFinal
            // 
            this.txt_RangoFinal.Location = new System.Drawing.Point(413, 66);
            this.txt_RangoFinal.MaxLength = 9;
            this.txt_RangoFinal.Name = "txt_RangoFinal";
            this.txt_RangoFinal.Size = new System.Drawing.Size(131, 20);
            this.txt_RangoFinal.TabIndex = 8;
            this.txt_RangoFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_RangoFinal_KeyPress);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(413, 92);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(132, 36);
            this.btn_Agregar.TabIndex = 15;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lb_RangoInicial
            // 
            this.lb_RangoInicial.AutoSize = true;
            this.lb_RangoInicial.Location = new System.Drawing.Point(306, 35);
            this.lb_RangoInicial.Name = "lb_RangoInicial";
            this.lb_RangoInicial.Size = new System.Drawing.Size(86, 13);
            this.lb_RangoInicial.TabIndex = 7;
            this.lb_RangoInicial.Text = "Rango Inicial:";
            // 
            // txt_RangoInicial
            // 
            this.txt_RangoInicial.Location = new System.Drawing.Point(413, 35);
            this.txt_RangoInicial.MaxLength = 9;
            this.txt_RangoInicial.Name = "txt_RangoInicial";
            this.txt_RangoInicial.Size = new System.Drawing.Size(131, 20);
            this.txt_RangoInicial.TabIndex = 6;
            this.txt_RangoInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_RangoInicial_KeyPress);
            // 
            // lb_ClaveCai
            // 
            this.lb_ClaveCai.AutoSize = true;
            this.lb_ClaveCai.Location = new System.Drawing.Point(21, 69);
            this.lb_ClaveCai.Name = "lb_ClaveCai";
            this.lb_ClaveCai.Size = new System.Drawing.Size(83, 13);
            this.lb_ClaveCai.TabIndex = 5;
            this.lb_ClaveCai.Text = "Clave de Cai:";
            // 
            // txt_ClaveCai
            // 
            this.txt_ClaveCai.Location = new System.Drawing.Point(121, 66);
            this.txt_ClaveCai.MaxLength = 70;
            this.txt_ClaveCai.Name = "txt_ClaveCai";
            this.txt_ClaveCai.Size = new System.Drawing.Size(131, 20);
            this.txt_ClaveCai.TabIndex = 4;
            this.txt_ClaveCai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ClaveCai_KeyPress);
            // 
            // lb_Codigo
            // 
            this.lb_Codigo.AutoSize = true;
            this.lb_Codigo.Location = new System.Drawing.Point(21, 35);
            this.lb_Codigo.Name = "lb_Codigo";
            this.lb_Codigo.Size = new System.Drawing.Size(50, 13);
            this.lb_Codigo.TabIndex = 1;
            this.lb_Codigo.Text = "Codigo:";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Enabled = false;
            this.txt_Codigo.Location = new System.Drawing.Point(121, 32);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.ReadOnly = true;
            this.txt_Codigo.Size = new System.Drawing.Size(131, 20);
            this.txt_Codigo.TabIndex = 0;
            this.txt_Codigo.TextChanged += new System.EventHandler(this.txt_Codigo_TextChanged);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(10, 69);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(131, 20);
            this.txt_buscar.TabIndex = 17;
            this.txt_buscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Busqueda Codigo:";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(580, 156);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(195, 36);
            this.btn_Limpiar.TabIndex = 14;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // rb_BuscarDatosCod
            // 
            this.rb_BuscarDatosCod.AutoSize = true;
            this.rb_BuscarDatosCod.Location = new System.Drawing.Point(285, 25);
            this.rb_BuscarDatosCod.Name = "rb_BuscarDatosCod";
            this.rb_BuscarDatosCod.Size = new System.Drawing.Size(169, 17);
            this.rb_BuscarDatosCod.TabIndex = 23;
            this.rb_BuscarDatosCod.TabStop = true;
            this.rb_BuscarDatosCod.Text = "Busqueda Por Codigo Cai";
            this.rb_BuscarDatosCod.UseVisualStyleBackColor = true;
            this.rb_BuscarDatosCod.CheckedChanged += new System.EventHandler(this.rb_BuscarDatosCod_CheckedChanged);
            // 
            // rb_AgregarCodigoCai
            // 
            this.rb_AgregarCodigoCai.AutoSize = true;
            this.rb_AgregarCodigoCai.Location = new System.Drawing.Point(130, 25);
            this.rb_AgregarCodigoCai.Name = "rb_AgregarCodigoCai";
            this.rb_AgregarCodigoCai.Size = new System.Drawing.Size(134, 17);
            this.rb_AgregarCodigoCai.TabIndex = 22;
            this.rb_AgregarCodigoCai.TabStop = true;
            this.rb_AgregarCodigoCai.Text = "Agregar Codigo Cai";
            this.rb_AgregarCodigoCai.UseVisualStyleBackColor = true;
            this.rb_AgregarCodigoCai.CheckedChanged += new System.EventHandler(this.rb_AgregarCodigoCai_CheckedChanged);
            // 
            // caiTableAdapter
            // 
            this.caiTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_buscar);
            this.groupBox1.Location = new System.Drawing.Point(580, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 102);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_MantenimientoCai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(788, 461);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.dataGrid_VentasCai);
            this.Controls.Add(this.gb_ModificarCai);
            this.Controls.Add(this.rb_BuscarDatosCod);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.rb_AgregarCodigoCai);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_MantenimientoCai";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Mantenimiento de Cai";
            this.Load += new System.EventHandler(this.Form_MantenimientoCai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_VentasCai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet)).EndInit();
            this.gb_ModificarCai.ResumeLayout(false);
            this.gb_ModificarCai.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DataGridView dataGrid_VentasCai;
        private System.Windows.Forms.GroupBox gb_ModificarCai;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Label lb_FechaLimite;
        private System.Windows.Forms.DateTimePicker date_FechaLimite;
        private System.Windows.Forms.Label lb_RangoFinal;
        private System.Windows.Forms.TextBox txt_RangoFinal;
        private System.Windows.Forms.Label lb_RangoInicial;
        private System.Windows.Forms.TextBox txt_RangoInicial;
        private System.Windows.Forms.Label lb_ClaveCai;
        private System.Windows.Forms.TextBox txt_ClaveCai;
        private System.Windows.Forms.Label lb_Codigo;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.RadioButton rb_BuscarDatosCod;
        private System.Windows.Forms.RadioButton rb_AgregarCodigoCai;
        private System.Windows.Forms.BindingSource ventasAutoPartesDataSetBindingSource;
        private VentasAutoPartesDataSet ventasAutoPartesDataSet;
        private System.Windows.Forms.BindingSource caiBindingSource;
        private VentasAutoPartesDataSetTableAdapters.CaiTableAdapter caiTableAdapter;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
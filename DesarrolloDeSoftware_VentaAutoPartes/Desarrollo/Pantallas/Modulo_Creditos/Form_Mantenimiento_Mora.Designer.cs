namespace Desarrollo.Pantallas.Modulo_Creditos
{
    partial class Form_Mantenimiento_Mora
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
            this.DataGriw_Moras = new System.Windows.Forms.DataGridView();
            this.moraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasAutoPartesDataSet = new Desarrollo.VentasAutoPartesDataSet();
            this.moraTableAdapter = new Desarrollo.VentasAutoPartesDataSetTableAdapters.MoraTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_CodigoNuevaMora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_NuevaMora = new System.Windows.Forms.TextBox();
            this.Bttn_Agregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboBox_Estados = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Bttn_Limpiar = new System.Windows.Forms.Button();
            this.Bttn_Aceptar = new System.Windows.Forms.Button();
            this.Txt_PorcentajeMora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_CodigoMora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Bttn_Salir = new System.Windows.Forms.Button();
            this.codigoMoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeMoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codEstadoMoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriw_Moras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGriw_Moras
            // 
            this.DataGriw_Moras.AutoGenerateColumns = false;
            this.DataGriw_Moras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGriw_Moras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGriw_Moras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoMoraDataGridViewTextBoxColumn,
            this.porcentajeMoraDataGridViewTextBoxColumn,
            this.codEstadoMoraDataGridViewTextBoxColumn});
            this.DataGriw_Moras.DataSource = this.moraBindingSource;
            this.DataGriw_Moras.Location = new System.Drawing.Point(12, 212);
            this.DataGriw_Moras.Name = "DataGriw_Moras";
            this.DataGriw_Moras.Size = new System.Drawing.Size(457, 150);
            this.DataGriw_Moras.TabIndex = 0;
            // 
            // moraBindingSource
            // 
            this.moraBindingSource.DataMember = "Mora";
            this.moraBindingSource.DataSource = this.ventasAutoPartesDataSet;
            // 
            // ventasAutoPartesDataSet
            // 
            this.ventasAutoPartesDataSet.DataSetName = "VentasAutoPartesDataSet";
            this.ventasAutoPartesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moraTableAdapter
            // 
            this.moraTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cod";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_CodigoNuevaMora
            // 
            this.Txt_CodigoNuevaMora.Enabled = false;
            this.Txt_CodigoNuevaMora.Location = new System.Drawing.Point(50, 17);
            this.Txt_CodigoNuevaMora.MaxLength = 10000;
            this.Txt_CodigoNuevaMora.Name = "Txt_CodigoNuevaMora";
            this.Txt_CodigoNuevaMora.Size = new System.Drawing.Size(100, 21);
            this.Txt_CodigoNuevaMora.TabIndex = 2;
            this.Txt_CodigoNuevaMora.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nuevo Porcentaje de Mora";
            // 
            // Txt_NuevaMora
            // 
            this.Txt_NuevaMora.Location = new System.Drawing.Point(195, 59);
            this.Txt_NuevaMora.MaxLength = 10;
            this.Txt_NuevaMora.Name = "Txt_NuevaMora";
            this.Txt_NuevaMora.Size = new System.Drawing.Size(151, 21);
            this.Txt_NuevaMora.TabIndex = 4;
            // 
            // Bttn_Agregar
            // 
            this.Bttn_Agregar.Location = new System.Drawing.Point(365, 54);
            this.Bttn_Agregar.Name = "Bttn_Agregar";
            this.Bttn_Agregar.Size = new System.Drawing.Size(104, 32);
            this.Bttn_Agregar.TabIndex = 5;
            this.Bttn_Agregar.Text = "Agregar";
            this.Bttn_Agregar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComboBox_Estados);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Bttn_Limpiar);
            this.groupBox1.Controls.Add(this.Bttn_Aceptar);
            this.groupBox1.Controls.Add(this.Txt_PorcentajeMora);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txt_CodigoMora);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar Porcentaje de Mora";
            // 
            // ComboBox_Estados
            // 
            this.ComboBox_Estados.FormattingEnabled = true;
            this.ComboBox_Estados.Location = new System.Drawing.Point(217, 42);
            this.ComboBox_Estados.Name = "ComboBox_Estados";
            this.ComboBox_Estados.Size = new System.Drawing.Size(94, 23);
            this.ComboBox_Estados.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Estado";
            // 
            // Bttn_Limpiar
            // 
            this.Bttn_Limpiar.Location = new System.Drawing.Point(344, 60);
            this.Bttn_Limpiar.Name = "Bttn_Limpiar";
            this.Bttn_Limpiar.Size = new System.Drawing.Size(104, 32);
            this.Bttn_Limpiar.TabIndex = 9;
            this.Bttn_Limpiar.Text = "Limpiar";
            this.Bttn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // Bttn_Aceptar
            // 
            this.Bttn_Aceptar.Location = new System.Drawing.Point(344, 23);
            this.Bttn_Aceptar.Name = "Bttn_Aceptar";
            this.Bttn_Aceptar.Size = new System.Drawing.Size(104, 32);
            this.Bttn_Aceptar.TabIndex = 7;
            this.Bttn_Aceptar.Text = "Aceptar";
            this.Bttn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // Txt_PorcentajeMora
            // 
            this.Txt_PorcentajeMora.Location = new System.Drawing.Point(81, 44);
            this.Txt_PorcentajeMora.MaxLength = 10;
            this.Txt_PorcentajeMora.Name = "Txt_PorcentajeMora";
            this.Txt_PorcentajeMora.Size = new System.Drawing.Size(130, 21);
            this.Txt_PorcentajeMora.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Porcentaje de Mora";
            // 
            // Txt_CodigoMora
            // 
            this.Txt_CodigoMora.Location = new System.Drawing.Point(8, 44);
            this.Txt_CodigoMora.MaxLength = 10000;
            this.Txt_CodigoMora.Name = "Txt_CodigoMora";
            this.Txt_CodigoMora.Size = new System.Drawing.Size(52, 21);
            this.Txt_CodigoMora.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cod";
            // 
            // Bttn_Salir
            // 
            this.Bttn_Salir.Location = new System.Drawing.Point(341, 368);
            this.Bttn_Salir.Name = "Bttn_Salir";
            this.Bttn_Salir.Size = new System.Drawing.Size(128, 56);
            this.Bttn_Salir.TabIndex = 7;
            this.Bttn_Salir.Text = "Salir";
            this.Bttn_Salir.UseVisualStyleBackColor = true;
            this.Bttn_Salir.Click += new System.EventHandler(this.Bttn_Salir_Click);
            // 
            // codigoMoraDataGridViewTextBoxColumn
            // 
            this.codigoMoraDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Mora";
            this.codigoMoraDataGridViewTextBoxColumn.HeaderText = "Codigo de la Mora";
            this.codigoMoraDataGridViewTextBoxColumn.Name = "codigoMoraDataGridViewTextBoxColumn";
            this.codigoMoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // porcentajeMoraDataGridViewTextBoxColumn
            // 
            this.porcentajeMoraDataGridViewTextBoxColumn.DataPropertyName = "Porcentaje_Mora";
            this.porcentajeMoraDataGridViewTextBoxColumn.HeaderText = "Porcentaje";
            this.porcentajeMoraDataGridViewTextBoxColumn.Name = "porcentajeMoraDataGridViewTextBoxColumn";
            // 
            // codEstadoMoraDataGridViewTextBoxColumn
            // 
            this.codEstadoMoraDataGridViewTextBoxColumn.DataPropertyName = "CodEstado_Mora";
            this.codEstadoMoraDataGridViewTextBoxColumn.HeaderText = "Codigo del Estado";
            this.codEstadoMoraDataGridViewTextBoxColumn.Name = "codEstadoMoraDataGridViewTextBoxColumn";
            // 
            // Form_Mantenimiento_Mora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(477, 434);
            this.ControlBox = false;
            this.Controls.Add(this.Bttn_Salir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Bttn_Agregar);
            this.Controls.Add(this.Txt_NuevaMora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_CodigoNuevaMora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGriw_Moras);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_Mantenimiento_Mora";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Mantenimiento de Porcentaje de Mora";
            this.Load += new System.EventHandler(this.Form_Mantenimiento_Mora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGriw_Moras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGriw_Moras;
        private VentasAutoPartesDataSet ventasAutoPartesDataSet;
        private System.Windows.Forms.BindingSource moraBindingSource;
        private VentasAutoPartesDataSetTableAdapters.MoraTableAdapter moraTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_CodigoNuevaMora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_NuevaMora;
        private System.Windows.Forms.Button Bttn_Agregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComboBox_Estados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Bttn_Limpiar;
        private System.Windows.Forms.Button Bttn_Aceptar;
        private System.Windows.Forms.TextBox Txt_PorcentajeMora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_CodigoMora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bttn_Salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoMoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeMoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEstadoMoraDataGridViewTextBoxColumn;
    }
}
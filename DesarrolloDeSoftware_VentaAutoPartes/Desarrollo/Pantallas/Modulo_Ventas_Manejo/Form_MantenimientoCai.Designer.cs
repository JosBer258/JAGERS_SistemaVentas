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
            this.btn_Salir = new System.Windows.Forms.Button();
            this.dataGrid_VentasCai = new System.Windows.Forms.DataGridView();
            this.DataGrid_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid_Clave_Cai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid__Fecha_Lim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid_Rango_Inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid_Rango_Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid_Correlativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid_Codigo_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_ModificarCai = new System.Windows.Forms.GroupBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.cmb_Estado = new System.Windows.Forms.ComboBox();
            this.lb_Estado = new System.Windows.Forms.Label();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.lb_FechaLimite = new System.Windows.Forms.Label();
            this.date_FechaLimite = new System.Windows.Forms.DateTimePicker();
            this.lb_RangoFinal = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lb_RangoInicial = new System.Windows.Forms.Label();
            this.txt_RangoInicial = new System.Windows.Forms.TextBox();
            this.lb_ClaveCai = new System.Windows.Forms.Label();
            this.txt_ClaveCai = new System.Windows.Forms.TextBox();
            this.lb_Correlativo = new System.Windows.Forms.Label();
            this.txt_Correlativo = new System.Windows.Forms.TextBox();
            this.lb_Codigo = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.rb_ModificarDatosCod = new System.Windows.Forms.RadioButton();
            this.rb_AgregarCodigoCai = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_VentasCai)).BeginInit();
            this.gb_ModificarCai.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(27, 402);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(128, 36);
            this.btn_Salir.TabIndex = 26;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            // 
            // dataGrid_VentasCai
            // 
            this.dataGrid_VentasCai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_VentasCai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGrid_Codigo,
            this.DataGrid_Clave_Cai,
            this.DataGrid__Fecha_Lim,
            this.DataGrid_Rango_Inicial,
            this.DataGrid_Rango_Final,
            this.DataGrid_Correlativo,
            this.DataGrid_Codigo_Estado});
            this.dataGrid_VentasCai.Location = new System.Drawing.Point(27, 232);
            this.dataGrid_VentasCai.Name = "dataGrid_VentasCai";
            this.dataGrid_VentasCai.Size = new System.Drawing.Size(645, 150);
            this.dataGrid_VentasCai.TabIndex = 25;
            // 
            // DataGrid_Codigo
            // 
            this.DataGrid_Codigo.HeaderText = "Columna";
            this.DataGrid_Codigo.Name = "DataGrid_Codigo";
            // 
            // DataGrid_Clave_Cai
            // 
            this.DataGrid_Clave_Cai.HeaderText = "Clave de Cai";
            this.DataGrid_Clave_Cai.Name = "DataGrid_Clave_Cai";
            // 
            // DataGrid__Fecha_Lim
            // 
            this.DataGrid__Fecha_Lim.HeaderText = "Fecha Limite";
            this.DataGrid__Fecha_Lim.Name = "DataGrid__Fecha_Lim";
            // 
            // DataGrid_Rango_Inicial
            // 
            this.DataGrid_Rango_Inicial.HeaderText = "Rango Inicial";
            this.DataGrid_Rango_Inicial.Name = "DataGrid_Rango_Inicial";
            // 
            // DataGrid_Rango_Final
            // 
            this.DataGrid_Rango_Final.HeaderText = "Rango Final";
            this.DataGrid_Rango_Final.Name = "DataGrid_Rango_Final";
            // 
            // DataGrid_Correlativo
            // 
            this.DataGrid_Correlativo.HeaderText = "Correlativo";
            this.DataGrid_Correlativo.Name = "DataGrid_Correlativo";
            // 
            // DataGrid_Codigo_Estado
            // 
            this.DataGrid_Codigo_Estado.HeaderText = "Codigo de Estado";
            this.DataGrid_Codigo_Estado.Name = "DataGrid_Codigo_Estado";
            // 
            // gb_ModificarCai
            // 
            this.gb_ModificarCai.Controls.Add(this.btn_Agregar);
            this.gb_ModificarCai.Controls.Add(this.cmb_Estado);
            this.gb_ModificarCai.Controls.Add(this.lb_Estado);
            this.gb_ModificarCai.Controls.Add(this.btn_Limpiar);
            this.gb_ModificarCai.Controls.Add(this.lb_FechaLimite);
            this.gb_ModificarCai.Controls.Add(this.date_FechaLimite);
            this.gb_ModificarCai.Controls.Add(this.lb_RangoFinal);
            this.gb_ModificarCai.Controls.Add(this.textBox5);
            this.gb_ModificarCai.Controls.Add(this.lb_RangoInicial);
            this.gb_ModificarCai.Controls.Add(this.txt_RangoInicial);
            this.gb_ModificarCai.Controls.Add(this.lb_ClaveCai);
            this.gb_ModificarCai.Controls.Add(this.txt_ClaveCai);
            this.gb_ModificarCai.Controls.Add(this.lb_Correlativo);
            this.gb_ModificarCai.Controls.Add(this.txt_Correlativo);
            this.gb_ModificarCai.Controls.Add(this.lb_Codigo);
            this.gb_ModificarCai.Controls.Add(this.txt_Codigo);
            this.gb_ModificarCai.Location = new System.Drawing.Point(27, 67);
            this.gb_ModificarCai.Name = "gb_ModificarCai";
            this.gb_ModificarCai.Size = new System.Drawing.Size(645, 146);
            this.gb_ModificarCai.TabIndex = 24;
            this.gb_ModificarCai.TabStop = false;
            this.gb_ModificarCai.Text = "Modificar Cai";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(511, 57);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(128, 36);
            this.btn_Agregar.TabIndex = 15;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // cmb_Estado
            // 
            this.cmb_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Estado.FormattingEnabled = true;
            this.cmb_Estado.Location = new System.Drawing.Point(354, 118);
            this.cmb_Estado.Name = "cmb_Estado";
            this.cmb_Estado.Size = new System.Drawing.Size(113, 21);
            this.cmb_Estado.TabIndex = 13;
            // 
            // lb_Estado
            // 
            this.lb_Estado.AutoSize = true;
            this.lb_Estado.Location = new System.Drawing.Point(265, 121);
            this.lb_Estado.Name = "lb_Estado";
            this.lb_Estado.Size = new System.Drawing.Size(43, 13);
            this.lb_Estado.TabIndex = 12;
            this.lb_Estado.Text = "Estado:";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(511, 102);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(128, 36);
            this.btn_Limpiar.TabIndex = 14;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // lb_FechaLimite
            // 
            this.lb_FechaLimite.AutoSize = true;
            this.lb_FechaLimite.Location = new System.Drawing.Point(265, 29);
            this.lb_FechaLimite.Name = "lb_FechaLimite";
            this.lb_FechaLimite.Size = new System.Drawing.Size(70, 13);
            this.lb_FechaLimite.TabIndex = 11;
            this.lb_FechaLimite.Text = "Fecha Limite:";
            // 
            // date_FechaLimite
            // 
            this.date_FechaLimite.Location = new System.Drawing.Point(354, 29);
            this.date_FechaLimite.Name = "date_FechaLimite";
            this.date_FechaLimite.Size = new System.Drawing.Size(113, 20);
            this.date_FechaLimite.TabIndex = 10;
            // 
            // lb_RangoFinal
            // 
            this.lb_RangoFinal.AutoSize = true;
            this.lb_RangoFinal.Location = new System.Drawing.Point(262, 95);
            this.lb_RangoFinal.Name = "lb_RangoFinal";
            this.lb_RangoFinal.Size = new System.Drawing.Size(67, 13);
            this.lb_RangoFinal.TabIndex = 9;
            this.lb_RangoFinal.Text = "Rango Final:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(354, 88);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(113, 20);
            this.textBox5.TabIndex = 8;
            // 
            // lb_RangoInicial
            // 
            this.lb_RangoInicial.AutoSize = true;
            this.lb_RangoInicial.Location = new System.Drawing.Point(262, 60);
            this.lb_RangoInicial.Name = "lb_RangoInicial";
            this.lb_RangoInicial.Size = new System.Drawing.Size(72, 13);
            this.lb_RangoInicial.TabIndex = 7;
            this.lb_RangoInicial.Text = "Rango Inicial:";
            // 
            // txt_RangoInicial
            // 
            this.txt_RangoInicial.Location = new System.Drawing.Point(354, 57);
            this.txt_RangoInicial.Name = "txt_RangoInicial";
            this.txt_RangoInicial.Size = new System.Drawing.Size(113, 20);
            this.txt_RangoInicial.TabIndex = 6;
            // 
            // lb_ClaveCai
            // 
            this.lb_ClaveCai.AutoSize = true;
            this.lb_ClaveCai.Location = new System.Drawing.Point(15, 121);
            this.lb_ClaveCai.Name = "lb_ClaveCai";
            this.lb_ClaveCai.Size = new System.Drawing.Size(70, 13);
            this.lb_ClaveCai.TabIndex = 5;
            this.lb_ClaveCai.Text = "Clave de Cai:";
            // 
            // txt_ClaveCai
            // 
            this.txt_ClaveCai.Location = new System.Drawing.Point(104, 118);
            this.txt_ClaveCai.Name = "txt_ClaveCai";
            this.txt_ClaveCai.Size = new System.Drawing.Size(113, 20);
            this.txt_ClaveCai.TabIndex = 4;
            // 
            // lb_Correlativo
            // 
            this.lb_Correlativo.AutoSize = true;
            this.lb_Correlativo.Location = new System.Drawing.Point(15, 95);
            this.lb_Correlativo.Name = "lb_Correlativo";
            this.lb_Correlativo.Size = new System.Drawing.Size(60, 13);
            this.lb_Correlativo.TabIndex = 3;
            this.lb_Correlativo.Text = "Correlativo:";
            // 
            // txt_Correlativo
            // 
            this.txt_Correlativo.Location = new System.Drawing.Point(104, 92);
            this.txt_Correlativo.Name = "txt_Correlativo";
            this.txt_Correlativo.Size = new System.Drawing.Size(113, 20);
            this.txt_Correlativo.TabIndex = 2;
            // 
            // lb_Codigo
            // 
            this.lb_Codigo.AutoSize = true;
            this.lb_Codigo.Location = new System.Drawing.Point(18, 35);
            this.lb_Codigo.Name = "lb_Codigo";
            this.lb_Codigo.Size = new System.Drawing.Size(43, 13);
            this.lb_Codigo.TabIndex = 1;
            this.lb_Codigo.Text = "Codigo:";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(104, 32);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(113, 20);
            this.txt_Codigo.TabIndex = 0;
            // 
            // rb_ModificarDatosCod
            // 
            this.rb_ModificarDatosCod.AutoSize = true;
            this.rb_ModificarDatosCod.Location = new System.Drawing.Point(180, 25);
            this.rb_ModificarDatosCod.Name = "rb_ModificarDatosCod";
            this.rb_ModificarDatosCod.Size = new System.Drawing.Size(150, 17);
            this.rb_ModificarDatosCod.TabIndex = 23;
            this.rb_ModificarDatosCod.TabStop = true;
            this.rb_ModificarDatosCod.Text = "Modificar Datos de Codigo";
            this.rb_ModificarDatosCod.UseVisualStyleBackColor = true;
            // 
            // rb_AgregarCodigoCai
            // 
            this.rb_AgregarCodigoCai.AutoSize = true;
            this.rb_AgregarCodigoCai.Location = new System.Drawing.Point(27, 25);
            this.rb_AgregarCodigoCai.Name = "rb_AgregarCodigoCai";
            this.rb_AgregarCodigoCai.Size = new System.Drawing.Size(116, 17);
            this.rb_AgregarCodigoCai.TabIndex = 22;
            this.rb_AgregarCodigoCai.TabStop = true;
            this.rb_AgregarCodigoCai.Text = "Agregar Codigo Cai";
            this.rb_AgregarCodigoCai.UseVisualStyleBackColor = true;
            // 
            // Form_MantenimientoCai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 461);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.dataGrid_VentasCai);
            this.Controls.Add(this.gb_ModificarCai);
            this.Controls.Add(this.rb_ModificarDatosCod);
            this.Controls.Add(this.rb_AgregarCodigoCai);
            this.Name = "Form_MantenimientoCai";
            this.Text = "Form_MantenimientoCai";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_VentasCai)).EndInit();
            this.gb_ModificarCai.ResumeLayout(false);
            this.gb_ModificarCai.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DataGridView dataGrid_VentasCai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGrid_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGrid_Clave_Cai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGrid__Fecha_Lim;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGrid_Rango_Inicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGrid_Rango_Final;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGrid_Correlativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGrid_Codigo_Estado;
        private System.Windows.Forms.GroupBox gb_ModificarCai;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.ComboBox cmb_Estado;
        private System.Windows.Forms.Label lb_Estado;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Label lb_FechaLimite;
        private System.Windows.Forms.DateTimePicker date_FechaLimite;
        private System.Windows.Forms.Label lb_RangoFinal;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lb_RangoInicial;
        private System.Windows.Forms.TextBox txt_RangoInicial;
        private System.Windows.Forms.Label lb_ClaveCai;
        private System.Windows.Forms.TextBox txt_ClaveCai;
        private System.Windows.Forms.Label lb_Correlativo;
        private System.Windows.Forms.TextBox txt_Correlativo;
        private System.Windows.Forms.Label lb_Codigo;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.RadioButton rb_ModificarDatosCod;
        private System.Windows.Forms.RadioButton rb_AgregarCodigoCai;
    }
}
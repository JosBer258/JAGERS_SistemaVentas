namespace Desarrollo.Pantallas.Modulo_Ventas_Manejo
{
    partial class Form_MantenimientoImpuestos
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
            this.date_FechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataGrid_FechaCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid_ValorImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_ModificarImpuesto = new System.Windows.Forms.GroupBox();
            this.date_FechaIngresoImp = new System.Windows.Forms.DateTimePicker();
            this.ComBox_Estado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.lb_CodigoMod = new System.Windows.Forms.Label();
            this.txt_CodigoModificarImp = new System.Windows.Forms.TextBox();
            this.lb_Estado = new System.Windows.Forms.Label();
            this.lb_Porcentaje = new System.Windows.Forms.Label();
            this.txt_Porcentaje = new System.Windows.Forms.TextBox();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.lb_ValorImpuestoActual = new System.Windows.Forms.Label();
            this.txt_ValorImpuestoActual = new System.Windows.Forms.TextBox();
            this.lb_FechaIngreso = new System.Windows.Forms.Label();
            this.lb_Codigo1 = new System.Windows.Forms.Label();
            this.txt_CodigoNuevoImp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_ModificarImpuesto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(98, 386);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(128, 40);
            this.btn_Salir.TabIndex = 33;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            // 
            // date_FechaIngreso
            // 
            this.date_FechaIngreso.Location = new System.Drawing.Point(495, 52);
            this.date_FechaIngreso.Name = "date_FechaIngreso";
            this.date_FechaIngreso.Size = new System.Drawing.Size(123, 20);
            this.date_FechaIngreso.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGrid_FechaCambio,
            this.DataGrid_Codigo,
            this.DataGrid_ValorImpuesto,
            this.DataGrid_Estado});
            this.dataGridView1.Location = new System.Drawing.Point(98, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(614, 128);
            this.dataGridView1.TabIndex = 31;
            // 
            // DataGrid_FechaCambio
            // 
            this.DataGrid_FechaCambio.HeaderText = "Fecha de Cambio";
            this.DataGrid_FechaCambio.Name = "DataGrid_FechaCambio";
            this.DataGrid_FechaCambio.Width = 145;
            // 
            // DataGrid_Codigo
            // 
            this.DataGrid_Codigo.HeaderText = "Codigo";
            this.DataGrid_Codigo.Name = "DataGrid_Codigo";
            this.DataGrid_Codigo.Width = 145;
            // 
            // DataGrid_ValorImpuesto
            // 
            this.DataGrid_ValorImpuesto.HeaderText = "Valor del Impuesto";
            this.DataGrid_ValorImpuesto.Name = "DataGrid_ValorImpuesto";
            this.DataGrid_ValorImpuesto.Width = 138;
            // 
            // DataGrid_Estado
            // 
            this.DataGrid_Estado.HeaderText = "Estado";
            this.DataGrid_Estado.Name = "DataGrid_Estado";
            this.DataGrid_Estado.Width = 139;
            // 
            // gb_ModificarImpuesto
            // 
            this.gb_ModificarImpuesto.Controls.Add(this.date_FechaIngresoImp);
            this.gb_ModificarImpuesto.Controls.Add(this.ComBox_Estado);
            this.gb_ModificarImpuesto.Controls.Add(this.label1);
            this.gb_ModificarImpuesto.Controls.Add(this.btn_Aceptar);
            this.gb_ModificarImpuesto.Controls.Add(this.lb_CodigoMod);
            this.gb_ModificarImpuesto.Controls.Add(this.txt_CodigoModificarImp);
            this.gb_ModificarImpuesto.Controls.Add(this.lb_Estado);
            this.gb_ModificarImpuesto.Controls.Add(this.lb_Porcentaje);
            this.gb_ModificarImpuesto.Controls.Add(this.txt_Porcentaje);
            this.gb_ModificarImpuesto.Location = new System.Drawing.Point(98, 146);
            this.gb_ModificarImpuesto.Name = "gb_ModificarImpuesto";
            this.gb_ModificarImpuesto.Size = new System.Drawing.Size(614, 100);
            this.gb_ModificarImpuesto.TabIndex = 30;
            this.gb_ModificarImpuesto.TabStop = false;
            this.gb_ModificarImpuesto.Text = "Modificar Impuesto";
            // 
            // date_FechaIngresoImp
            // 
            this.date_FechaIngresoImp.Location = new System.Drawing.Point(128, 55);
            this.date_FechaIngresoImp.Name = "date_FechaIngresoImp";
            this.date_FechaIngresoImp.Size = new System.Drawing.Size(97, 20);
            this.date_FechaIngresoImp.TabIndex = 18;
            // 
            // ComBox_Estado
            // 
            this.ComBox_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBox_Estado.Enabled = false;
            this.ComBox_Estado.FormattingEnabled = true;
            this.ComBox_Estado.Location = new System.Drawing.Point(353, 53);
            this.ComBox_Estado.Name = "ComBox_Estado";
            this.ComBox_Estado.Size = new System.Drawing.Size(97, 21);
            this.ComBox_Estado.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fecha Ingreso";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(480, 35);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(128, 40);
            this.btn_Aceptar.TabIndex = 17;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // lb_CodigoMod
            // 
            this.lb_CodigoMod.AutoSize = true;
            this.lb_CodigoMod.Location = new System.Drawing.Point(30, 38);
            this.lb_CodigoMod.Name = "lb_CodigoMod";
            this.lb_CodigoMod.Size = new System.Drawing.Size(40, 13);
            this.lb_CodigoMod.TabIndex = 11;
            this.lb_CodigoMod.Text = "Codigo";
            // 
            // txt_CodigoModificarImp
            // 
            this.txt_CodigoModificarImp.Location = new System.Drawing.Point(6, 55);
            this.txt_CodigoModificarImp.Name = "txt_CodigoModificarImp";
            this.txt_CodigoModificarImp.Size = new System.Drawing.Size(97, 20);
            this.txt_CodigoModificarImp.TabIndex = 10;
            // 
            // lb_Estado
            // 
            this.lb_Estado.AutoSize = true;
            this.lb_Estado.Location = new System.Drawing.Point(375, 37);
            this.lb_Estado.Name = "lb_Estado";
            this.lb_Estado.Size = new System.Drawing.Size(40, 13);
            this.lb_Estado.TabIndex = 9;
            this.lb_Estado.Text = "Estado";
            // 
            // lb_Porcentaje
            // 
            this.lb_Porcentaje.AutoSize = true;
            this.lb_Porcentaje.Location = new System.Drawing.Point(255, 38);
            this.lb_Porcentaje.Name = "lb_Porcentaje";
            this.lb_Porcentaje.Size = new System.Drawing.Size(58, 13);
            this.lb_Porcentaje.TabIndex = 13;
            this.lb_Porcentaje.Text = "Porcentaje";
            // 
            // txt_Porcentaje
            // 
            this.txt_Porcentaje.Location = new System.Drawing.Point(238, 54);
            this.txt_Porcentaje.Name = "txt_Porcentaje";
            this.txt_Porcentaje.Size = new System.Drawing.Size(97, 20);
            this.txt_Porcentaje.TabIndex = 12;
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Location = new System.Drawing.Point(584, 101);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(128, 39);
            this.btn_Ingresar.TabIndex = 29;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            // 
            // lb_ValorImpuestoActual
            // 
            this.lb_ValorImpuestoActual.AutoSize = true;
            this.lb_ValorImpuestoActual.Location = new System.Drawing.Point(95, 95);
            this.lb_ValorImpuestoActual.Name = "lb_ValorImpuestoActual";
            this.lb_ValorImpuestoActual.Size = new System.Drawing.Size(127, 13);
            this.lb_ValorImpuestoActual.TabIndex = 28;
            this.lb_ValorImpuestoActual.Text = "Valor del Impuesto Actual";
            // 
            // txt_ValorImpuestoActual
            // 
            this.txt_ValorImpuestoActual.Location = new System.Drawing.Point(253, 92);
            this.txt_ValorImpuestoActual.Name = "txt_ValorImpuestoActual";
            this.txt_ValorImpuestoActual.Size = new System.Drawing.Size(123, 20);
            this.txt_ValorImpuestoActual.TabIndex = 27;
            // 
            // lb_FechaIngreso
            // 
            this.lb_FechaIngreso.AutoSize = true;
            this.lb_FechaIngreso.Location = new System.Drawing.Point(379, 54);
            this.lb_FechaIngreso.Name = "lb_FechaIngreso";
            this.lb_FechaIngreso.Size = new System.Drawing.Size(93, 13);
            this.lb_FechaIngreso.TabIndex = 26;
            this.lb_FechaIngreso.Text = "Fecha de Ingreso:";
            // 
            // lb_Codigo1
            // 
            this.lb_Codigo1.AutoSize = true;
            this.lb_Codigo1.Location = new System.Drawing.Point(95, 55);
            this.lb_Codigo1.Name = "lb_Codigo1";
            this.lb_Codigo1.Size = new System.Drawing.Size(43, 13);
            this.lb_Codigo1.TabIndex = 25;
            this.lb_Codigo1.Text = "Codigo:";
            // 
            // txt_CodigoNuevoImp
            // 
            this.txt_CodigoNuevoImp.Location = new System.Drawing.Point(253, 55);
            this.txt_CodigoNuevoImp.Name = "txt_CodigoNuevoImp";
            this.txt_CodigoNuevoImp.Size = new System.Drawing.Size(123, 20);
            this.txt_CodigoNuevoImp.TabIndex = 24;
            // 
            // Form_MantenimientoImpuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 479);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.date_FechaIngreso);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gb_ModificarImpuesto);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.lb_ValorImpuestoActual);
            this.Controls.Add(this.txt_ValorImpuestoActual);
            this.Controls.Add(this.lb_FechaIngreso);
            this.Controls.Add(this.lb_Codigo1);
            this.Controls.Add(this.txt_CodigoNuevoImp);
            this.Name = "Form_MantenimientoImpuestos";
            this.Text = "Form_MantenimientoImpuestos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_ModificarImpuesto.ResumeLayout(false);
            this.gb_ModificarImpuesto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DateTimePicker date_FechaIngreso;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGrid_FechaCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGrid_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGrid_ValorImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGrid_Estado;
        private System.Windows.Forms.GroupBox gb_ModificarImpuesto;
        private System.Windows.Forms.DateTimePicker date_FechaIngresoImp;
        private System.Windows.Forms.ComboBox ComBox_Estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label lb_CodigoMod;
        private System.Windows.Forms.TextBox txt_CodigoModificarImp;
        private System.Windows.Forms.Label lb_Estado;
        private System.Windows.Forms.Label lb_Porcentaje;
        private System.Windows.Forms.TextBox txt_Porcentaje;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.Label lb_ValorImpuestoActual;
        private System.Windows.Forms.TextBox txt_ValorImpuestoActual;
        private System.Windows.Forms.Label lb_FechaIngreso;
        private System.Windows.Forms.Label lb_Codigo1;
        private System.Windows.Forms.TextBox txt_CodigoNuevoImp;
    }
}
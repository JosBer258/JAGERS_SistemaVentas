namespace Desarrollo.Pantallas.Modulo_Creditos
{
    partial class Form_Creditos_CargarMora
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
            this.Text_Fecha_Mora = new System.Windows.Forms.TextBox();
            this.Txt_NombreClientes = new System.Windows.Forms.TextBox();
            this.Txt_Codigo_Transaccion = new System.Windows.Forms.TextBox();
            this.Text_Nombre_Empleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Group_DatosMora = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_CodigoTransaccionMora = new System.Windows.Forms.TextBox();
            this.Txt_FechaRealizacionTransaccionMora = new System.Windows.Forms.TextBox();
            this.Txt_TotalAAplicar = new System.Windows.Forms.TextBox();
            this.Txt_MontoTotalDeFactura = new System.Windows.Forms.TextBox();
            this.Txt_PorcentajeDeMora = new System.Windows.Forms.TextBox();
            this.Txt_FechaLimiteTransaccionMora = new System.Windows.Forms.TextBox();
            this.Bttn_Ayuda = new System.Windows.Forms.Button();
            this.Bttn_Guardar = new System.Windows.Forms.Button();
            this.Bttn_Salir = new System.Windows.Forms.Button();
            this.Group_DatosMora.SuspendLayout();
            this.SuspendLayout();
            // 
            // Text_Fecha_Mora
            // 
            this.Text_Fecha_Mora.Enabled = false;
            this.Text_Fecha_Mora.Location = new System.Drawing.Point(18, 14);
            this.Text_Fecha_Mora.Name = "Text_Fecha_Mora";
            this.Text_Fecha_Mora.Size = new System.Drawing.Size(139, 21);
            this.Text_Fecha_Mora.TabIndex = 0;
            // 
            // Txt_NombreClientes
            // 
            this.Txt_NombreClientes.Enabled = false;
            this.Txt_NombreClientes.Location = new System.Drawing.Point(182, 117);
            this.Txt_NombreClientes.Name = "Txt_NombreClientes";
            this.Txt_NombreClientes.Size = new System.Drawing.Size(134, 21);
            this.Txt_NombreClientes.TabIndex = 1;
            this.Txt_NombreClientes.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Txt_Codigo_Transaccion
            // 
            this.Txt_Codigo_Transaccion.Enabled = false;
            this.Txt_Codigo_Transaccion.Location = new System.Drawing.Point(184, 58);
            this.Txt_Codigo_Transaccion.Name = "Txt_Codigo_Transaccion";
            this.Txt_Codigo_Transaccion.Size = new System.Drawing.Size(132, 21);
            this.Txt_Codigo_Transaccion.TabIndex = 2;
            // 
            // Text_Nombre_Empleado
            // 
            this.Text_Nombre_Empleado.Enabled = false;
            this.Text_Nombre_Empleado.Location = new System.Drawing.Point(182, 86);
            this.Text_Nombre_Empleado.Name = "Text_Nombre_Empleado";
            this.Text_Nombre_Empleado.Size = new System.Drawing.Size(134, 21);
            this.Text_Nombre_Empleado.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo de Transaccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre del Empleado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre del Cliente";
            // 
            // Group_DatosMora
            // 
            this.Group_DatosMora.Controls.Add(this.label9);
            this.Group_DatosMora.Controls.Add(this.label8);
            this.Group_DatosMora.Controls.Add(this.label7);
            this.Group_DatosMora.Controls.Add(this.label6);
            this.Group_DatosMora.Controls.Add(this.label5);
            this.Group_DatosMora.Controls.Add(this.label4);
            this.Group_DatosMora.Controls.Add(this.Txt_CodigoTransaccionMora);
            this.Group_DatosMora.Controls.Add(this.Txt_FechaRealizacionTransaccionMora);
            this.Group_DatosMora.Controls.Add(this.Txt_TotalAAplicar);
            this.Group_DatosMora.Controls.Add(this.Txt_MontoTotalDeFactura);
            this.Group_DatosMora.Controls.Add(this.Txt_PorcentajeDeMora);
            this.Group_DatosMora.Controls.Add(this.Txt_FechaLimiteTransaccionMora);
            this.Group_DatosMora.Location = new System.Drawing.Point(18, 161);
            this.Group_DatosMora.Name = "Group_DatosMora";
            this.Group_DatosMora.Size = new System.Drawing.Size(338, 254);
            this.Group_DatosMora.TabIndex = 7;
            this.Group_DatosMora.TabStop = false;
            this.Group_DatosMora.Text = "Datos de Transaccion para Aplicar Mora";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Total a Aplicar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Codigo de Transaccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Monto Total de Factura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha de Realizacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha Limite";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Porcentaje de Mora";
            // 
            // Txt_CodigoTransaccionMora
            // 
            this.Txt_CodigoTransaccionMora.Enabled = false;
            this.Txt_CodigoTransaccionMora.Location = new System.Drawing.Point(197, 38);
            this.Txt_CodigoTransaccionMora.Name = "Txt_CodigoTransaccionMora";
            this.Txt_CodigoTransaccionMora.Size = new System.Drawing.Size(104, 21);
            this.Txt_CodigoTransaccionMora.TabIndex = 9;
            // 
            // Txt_FechaRealizacionTransaccionMora
            // 
            this.Txt_FechaRealizacionTransaccionMora.Enabled = false;
            this.Txt_FechaRealizacionTransaccionMora.Location = new System.Drawing.Point(197, 70);
            this.Txt_FechaRealizacionTransaccionMora.Name = "Txt_FechaRealizacionTransaccionMora";
            this.Txt_FechaRealizacionTransaccionMora.Size = new System.Drawing.Size(104, 21);
            this.Txt_FechaRealizacionTransaccionMora.TabIndex = 8;
            // 
            // Txt_TotalAAplicar
            // 
            this.Txt_TotalAAplicar.Enabled = false;
            this.Txt_TotalAAplicar.Location = new System.Drawing.Point(197, 215);
            this.Txt_TotalAAplicar.Name = "Txt_TotalAAplicar";
            this.Txt_TotalAAplicar.Size = new System.Drawing.Size(104, 21);
            this.Txt_TotalAAplicar.TabIndex = 6;
            // 
            // Txt_MontoTotalDeFactura
            // 
            this.Txt_MontoTotalDeFactura.Enabled = false;
            this.Txt_MontoTotalDeFactura.Location = new System.Drawing.Point(197, 143);
            this.Txt_MontoTotalDeFactura.Name = "Txt_MontoTotalDeFactura";
            this.Txt_MontoTotalDeFactura.Size = new System.Drawing.Size(104, 21);
            this.Txt_MontoTotalDeFactura.TabIndex = 7;
            // 
            // Txt_PorcentajeDeMora
            // 
            this.Txt_PorcentajeDeMora.Enabled = false;
            this.Txt_PorcentajeDeMora.Location = new System.Drawing.Point(197, 178);
            this.Txt_PorcentajeDeMora.Name = "Txt_PorcentajeDeMora";
            this.Txt_PorcentajeDeMora.Size = new System.Drawing.Size(104, 21);
            this.Txt_PorcentajeDeMora.TabIndex = 5;
            // 
            // Txt_FechaLimiteTransaccionMora
            // 
            this.Txt_FechaLimiteTransaccionMora.Enabled = false;
            this.Txt_FechaLimiteTransaccionMora.Location = new System.Drawing.Point(197, 100);
            this.Txt_FechaLimiteTransaccionMora.Name = "Txt_FechaLimiteTransaccionMora";
            this.Txt_FechaLimiteTransaccionMora.Size = new System.Drawing.Size(104, 21);
            this.Txt_FechaLimiteTransaccionMora.TabIndex = 4;
            // 
            // Bttn_Ayuda
            // 
            this.Bttn_Ayuda.Location = new System.Drawing.Point(18, 427);
            this.Bttn_Ayuda.Name = "Bttn_Ayuda";
            this.Bttn_Ayuda.Size = new System.Drawing.Size(110, 48);
            this.Bttn_Ayuda.TabIndex = 8;
            this.Bttn_Ayuda.Text = "Ayuda";
            this.Bttn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // Bttn_Guardar
            // 
            this.Bttn_Guardar.Location = new System.Drawing.Point(250, 427);
            this.Bttn_Guardar.Name = "Bttn_Guardar";
            this.Bttn_Guardar.Size = new System.Drawing.Size(106, 48);
            this.Bttn_Guardar.TabIndex = 9;
            this.Bttn_Guardar.Text = "Aplicar";
            this.Bttn_Guardar.UseVisualStyleBackColor = true;
            // 
            // Bttn_Salir
            // 
            this.Bttn_Salir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bttn_Salir.Location = new System.Drawing.Point(134, 427);
            this.Bttn_Salir.Name = "Bttn_Salir";
            this.Bttn_Salir.Size = new System.Drawing.Size(110, 48);
            this.Bttn_Salir.TabIndex = 10;
            this.Bttn_Salir.Text = "Salir";
            this.Bttn_Salir.UseVisualStyleBackColor = true;
            this.Bttn_Salir.Click += new System.EventHandler(this.Bttn_Salir_Click);
            // 
            // Form_Creditos_CargarMora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(368, 487);
            this.ControlBox = false;
            this.Controls.Add(this.Bttn_Salir);
            this.Controls.Add(this.Bttn_Guardar);
            this.Controls.Add(this.Bttn_Ayuda);
            this.Controls.Add(this.Group_DatosMora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Text_Nombre_Empleado);
            this.Controls.Add(this.Txt_Codigo_Transaccion);
            this.Controls.Add(this.Txt_NombreClientes);
            this.Controls.Add(this.Text_Fecha_Mora);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_Creditos_CargarMora";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Cargar Mora a Factura de Credito";
            this.Group_DatosMora.ResumeLayout(false);
            this.Group_DatosMora.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_Fecha_Mora;
        private System.Windows.Forms.TextBox Txt_NombreClientes;
        private System.Windows.Forms.TextBox Txt_Codigo_Transaccion;
        private System.Windows.Forms.TextBox Text_Nombre_Empleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Group_DatosMora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_CodigoTransaccionMora;
        private System.Windows.Forms.TextBox Txt_FechaRealizacionTransaccionMora;
        private System.Windows.Forms.TextBox Txt_MontoTotalDeFactura;
        private System.Windows.Forms.TextBox Txt_TotalAAplicar;
        private System.Windows.Forms.TextBox Txt_PorcentajeDeMora;
        private System.Windows.Forms.TextBox Txt_FechaLimiteTransaccionMora;
        private System.Windows.Forms.Button Bttn_Ayuda;
        private System.Windows.Forms.Button Bttn_Guardar;
        private System.Windows.Forms.Button Bttn_Salir;
    }
}
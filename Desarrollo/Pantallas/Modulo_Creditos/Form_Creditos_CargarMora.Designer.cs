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
            this.Txt_NombreClientes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_CodigoTransaccionMora = new System.Windows.Forms.TextBox();
            this.Bttn_Ayuda = new System.Windows.Forms.Button();
            this.Bttn_Guardar = new System.Windows.Forms.Button();
            this.Bttn_Salir = new System.Windows.Forms.Button();
            this.DATE_FechaActual = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_TotalMorasAplica = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DATE_FechaUltimaMora = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_MontoNuevo = new System.Windows.Forms.TextBox();
            this.Txt_PorcentajeMora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_MontoActual = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Txt_TotalAProporcional = new System.Windows.Forms.TextBox();
            this.Txt_FechaVencimientoFactura = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Txt_MontoOriginal = new System.Windows.Forms.TextBox();
            this.Txt_FechaRealizacionFactura = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Txt_NumeroFactura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_NombreEmpleado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_NombreClientes
            // 
            this.Txt_NombreClientes.Enabled = false;
            this.Txt_NombreClientes.Location = new System.Drawing.Point(210, 98);
            this.Txt_NombreClientes.Name = "Txt_NombreClientes";
            this.Txt_NombreClientes.Size = new System.Drawing.Size(200, 21);
            this.Txt_NombreClientes.TabIndex = 1;
            this.Txt_NombreClientes.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero de Factura";
            // 
            // Txt_CodigoTransaccionMora
            // 
            this.Txt_CodigoTransaccionMora.Enabled = false;
            this.Txt_CodigoTransaccionMora.Location = new System.Drawing.Point(210, 44);
            this.Txt_CodigoTransaccionMora.Name = "Txt_CodigoTransaccionMora";
            this.Txt_CodigoTransaccionMora.Size = new System.Drawing.Size(148, 21);
            this.Txt_CodigoTransaccionMora.TabIndex = 9;
            // 
            // Bttn_Ayuda
            // 
            this.Bttn_Ayuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttn_Ayuda.Location = new System.Drawing.Point(303, 570);
            this.Bttn_Ayuda.Name = "Bttn_Ayuda";
            this.Bttn_Ayuda.Size = new System.Drawing.Size(162, 67);
            this.Bttn_Ayuda.TabIndex = 8;
            this.Bttn_Ayuda.Text = "Ayuda";
            this.Bttn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // Bttn_Guardar
            // 
            this.Bttn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttn_Guardar.Location = new System.Drawing.Point(-1, 570);
            this.Bttn_Guardar.Name = "Bttn_Guardar";
            this.Bttn_Guardar.Size = new System.Drawing.Size(162, 67);
            this.Bttn_Guardar.TabIndex = 9;
            this.Bttn_Guardar.Text = "Aplicar";
            this.Bttn_Guardar.UseVisualStyleBackColor = true;
            this.Bttn_Guardar.Click += new System.EventHandler(this.Bttn_Guardar_Click);
            // 
            // Bttn_Salir
            // 
            this.Bttn_Salir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bttn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttn_Salir.Location = new System.Drawing.Point(150, 570);
            this.Bttn_Salir.Name = "Bttn_Salir";
            this.Bttn_Salir.Size = new System.Drawing.Size(162, 67);
            this.Bttn_Salir.TabIndex = 10;
            this.Bttn_Salir.Text = "Salir";
            this.Bttn_Salir.UseVisualStyleBackColor = true;
            this.Bttn_Salir.Click += new System.EventHandler(this.Bttn_Salir_Click);
            // 
            // DATE_FechaActual
            // 
            this.DATE_FechaActual.Checked = false;
            this.DATE_FechaActual.Enabled = false;
            this.DATE_FechaActual.Location = new System.Drawing.Point(12, 12);
            this.DATE_FechaActual.Name = "DATE_FechaActual";
            this.DATE_FechaActual.Size = new System.Drawing.Size(261, 21);
            this.DATE_FechaActual.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 30);
            this.label10.TabIndex = 17;
            this.label10.Text = "Numero de moras \r\naplicadas";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Txt_TotalMorasAplica
            // 
            this.Txt_TotalMorasAplica.Enabled = false;
            this.Txt_TotalMorasAplica.Location = new System.Drawing.Point(168, 33);
            this.Txt_TotalMorasAplica.Name = "Txt_TotalMorasAplica";
            this.Txt_TotalMorasAplica.Size = new System.Drawing.Size(148, 21);
            this.Txt_TotalMorasAplica.TabIndex = 16;
            this.Txt_TotalMorasAplica.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 30);
            this.label11.TabIndex = 19;
            this.label11.Text = "Fecha de ultima mora \r\naplicada";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DATE_FechaUltimaMora);
            this.groupBox1.Controls.Add(this.Txt_TotalMorasAplica);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(42, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 116);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historial de aplicacion de mora";
            // 
            // DATE_FechaUltimaMora
            // 
            this.DATE_FechaUltimaMora.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATE_FechaUltimaMora.Enabled = false;
            this.DATE_FechaUltimaMora.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DATE_FechaUltimaMora.Location = new System.Drawing.Point(168, 68);
            this.DATE_FechaUltimaMora.Name = "DATE_FechaUltimaMora";
            this.DATE_FechaUltimaMora.Size = new System.Drawing.Size(148, 21);
            this.DATE_FechaUltimaMora.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Txt_MontoNuevo);
            this.groupBox2.Controls.Add(this.Txt_PorcentajeMora);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Txt_MontoActual);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.Txt_TotalAProporcional);
            this.groupBox2.Controls.Add(this.Txt_FechaVencimientoFactura);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.Txt_MontoOriginal);
            this.groupBox2.Controls.Add(this.Txt_FechaRealizacionFactura);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(42, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 252);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Monto nuevo L.";
            // 
            // Txt_MontoNuevo
            // 
            this.Txt_MontoNuevo.Enabled = false;
            this.Txt_MontoNuevo.Location = new System.Drawing.Point(168, 215);
            this.Txt_MontoNuevo.Name = "Txt_MontoNuevo";
            this.Txt_MontoNuevo.Size = new System.Drawing.Size(148, 21);
            this.Txt_MontoNuevo.TabIndex = 32;
            // 
            // Txt_PorcentajeMora
            // 
            this.Txt_PorcentajeMora.Enabled = false;
            this.Txt_PorcentajeMora.Location = new System.Drawing.Point(168, 145);
            this.Txt_PorcentajeMora.Name = "Txt_PorcentajeMora";
            this.Txt_PorcentajeMora.Size = new System.Drawing.Size(148, 21);
            this.Txt_PorcentajeMora.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Porcentaje de Mora";
            // 
            // Txt_MontoActual
            // 
            this.Txt_MontoActual.Enabled = false;
            this.Txt_MontoActual.Location = new System.Drawing.Point(168, 116);
            this.Txt_MontoActual.Name = "Txt_MontoActual";
            this.Txt_MontoActual.Size = new System.Drawing.Size(148, 21);
            this.Txt_MontoActual.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 116);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 15);
            this.label16.TabIndex = 27;
            this.label16.Text = "Monto Actual L.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 172);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 15);
            this.label17.TabIndex = 29;
            this.label17.Text = "Total a aplicar  L.";
            // 
            // Txt_TotalAProporcional
            // 
            this.Txt_TotalAProporcional.Enabled = false;
            this.Txt_TotalAProporcional.Location = new System.Drawing.Point(168, 172);
            this.Txt_TotalAProporcional.Name = "Txt_TotalAProporcional";
            this.Txt_TotalAProporcional.Size = new System.Drawing.Size(148, 21);
            this.Txt_TotalAProporcional.TabIndex = 28;
            // 
            // Txt_FechaVencimientoFactura
            // 
            this.Txt_FechaVencimientoFactura.Enabled = false;
            this.Txt_FechaVencimientoFactura.Location = new System.Drawing.Point(168, 61);
            this.Txt_FechaVencimientoFactura.Name = "Txt_FechaVencimientoFactura";
            this.Txt_FechaVencimientoFactura.Size = new System.Drawing.Size(148, 21);
            this.Txt_FechaVencimientoFactura.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 15);
            this.label14.TabIndex = 23;
            this.label14.Text = "Fecha de vencimiento";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 15);
            this.label15.TabIndex = 25;
            this.label15.Text = "Monto Original L.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "Fecha de realizacion";
            // 
            // Txt_MontoOriginal
            // 
            this.Txt_MontoOriginal.Enabled = false;
            this.Txt_MontoOriginal.Location = new System.Drawing.Point(168, 88);
            this.Txt_MontoOriginal.Name = "Txt_MontoOriginal";
            this.Txt_MontoOriginal.Size = new System.Drawing.Size(148, 21);
            this.Txt_MontoOriginal.TabIndex = 24;
            // 
            // Txt_FechaRealizacionFactura
            // 
            this.Txt_FechaRealizacionFactura.Enabled = false;
            this.Txt_FechaRealizacionFactura.Location = new System.Drawing.Point(168, 34);
            this.Txt_FechaRealizacionFactura.Name = "Txt_FechaRealizacionFactura";
            this.Txt_FechaRealizacionFactura.Size = new System.Drawing.Size(148, 21);
            this.Txt_FechaRealizacionFactura.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "Codigo de Transaccion";
            // 
            // Txt_NumeroFactura
            // 
            this.Txt_NumeroFactura.Enabled = false;
            this.Txt_NumeroFactura.Location = new System.Drawing.Point(210, 71);
            this.Txt_NumeroFactura.Name = "Txt_NumeroFactura";
            this.Txt_NumeroFactura.Size = new System.Drawing.Size(148, 21);
            this.Txt_NumeroFactura.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nombre del Cliente\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Nombre del Empleado";
            // 
            // Txt_NombreEmpleado
            // 
            this.Txt_NombreEmpleado.Enabled = false;
            this.Txt_NombreEmpleado.Location = new System.Drawing.Point(210, 125);
            this.Txt_NombreEmpleado.Name = "Txt_NombreEmpleado";
            this.Txt_NombreEmpleado.Size = new System.Drawing.Size(200, 21);
            this.Txt_NombreEmpleado.TabIndex = 24;
            // 
            // Form_Creditos_CargarMora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(460, 636);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_NombreEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_NumeroFactura);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DATE_FechaActual);
            this.Controls.Add(this.Bttn_Salir);
            this.Controls.Add(this.Bttn_Guardar);
            this.Controls.Add(this.Bttn_Ayuda);
            this.Controls.Add(this.Txt_CodigoTransaccionMora);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_NombreClientes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_Creditos_CargarMora";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Cargar Mora a Factura de Credito";
            this.Load += new System.EventHandler(this.Form_Creditos_CargarMora_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bttn_Ayuda;
        private System.Windows.Forms.Button Bttn_Guardar;
        private System.Windows.Forms.Button Bttn_Salir;
        public System.Windows.Forms.TextBox Txt_NombreClientes;
        public System.Windows.Forms.TextBox Txt_CodigoTransaccionMora;
        private System.Windows.Forms.DateTimePicker DATE_FechaActual;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox Txt_TotalMorasAplica;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox Txt_FechaVencimientoFactura;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox Txt_MontoOriginal;
        public System.Windows.Forms.TextBox Txt_FechaRealizacionFactura;
        public System.Windows.Forms.TextBox Txt_MontoActual;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox Txt_TotalAProporcional;
        public System.Windows.Forms.TextBox Txt_NumeroFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox Txt_NombreEmpleado;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Txt_MontoNuevo;
        public System.Windows.Forms.TextBox Txt_PorcentajeMora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DATE_FechaUltimaMora;
    }
}
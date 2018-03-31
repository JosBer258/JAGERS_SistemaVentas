namespace Desarrollo.Pantallas.Modulo_Ventas_Manejo.Modulo_ArqueodeCaja
{
    partial class Form_PantallaDeArqueo
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
            this.Radii_BuscarTransaccionesMesActaul = new System.Windows.Forms.RadioButton();
            this.Radii_BuscarTransaccionesMesOtro = new System.Windows.Forms.RadioButton();
            this.ComBox_Mess = new System.Windows.Forms.ComboBox();
            this.ComBox_Año = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transaccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasAutoPartesDataSet = new Desarrollo.VentasAutoPartesDataSet();
            this.transaccionesTableAdapter = new Desarrollo.VentasAutoPartesDataSetTableAdapters.TransaccionesTableAdapter();
            this.Grupo_Busqueda = new System.Windows.Forms.GroupBox();
            this.Bttn_Generar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_TotalEfectivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_PorTargetas = new System.Windows.Forms.TextBox();
            this.Txt_Creditos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_NumTotalVentas = new System.Windows.Forms.TextBox();
            this.Bttn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet)).BeginInit();
            this.Grupo_Busqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // Radii_BuscarTransaccionesMesActaul
            // 
            this.Radii_BuscarTransaccionesMesActaul.AutoSize = true;
            this.Radii_BuscarTransaccionesMesActaul.Location = new System.Drawing.Point(15, 35);
            this.Radii_BuscarTransaccionesMesActaul.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Radii_BuscarTransaccionesMesActaul.Name = "Radii_BuscarTransaccionesMesActaul";
            this.Radii_BuscarTransaccionesMesActaul.Size = new System.Drawing.Size(272, 19);
            this.Radii_BuscarTransaccionesMesActaul.TabIndex = 0;
            this.Radii_BuscarTransaccionesMesActaul.TabStop = true;
            this.Radii_BuscarTransaccionesMesActaul.Text = "Buscar las Transacciones de Este Mes";
            this.Radii_BuscarTransaccionesMesActaul.UseVisualStyleBackColor = true;
            this.Radii_BuscarTransaccionesMesActaul.CheckedChanged += new System.EventHandler(this.Radii_BuscarTransaccionesMesActaul_CheckedChanged);
            // 
            // Radii_BuscarTransaccionesMesOtro
            // 
            this.Radii_BuscarTransaccionesMesOtro.AutoSize = true;
            this.Radii_BuscarTransaccionesMesOtro.Location = new System.Drawing.Point(15, 65);
            this.Radii_BuscarTransaccionesMesOtro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Radii_BuscarTransaccionesMesOtro.Name = "Radii_BuscarTransaccionesMesOtro";
            this.Radii_BuscarTransaccionesMesOtro.Size = new System.Drawing.Size(208, 19);
            this.Radii_BuscarTransaccionesMesOtro.TabIndex = 1;
            this.Radii_BuscarTransaccionesMesOtro.TabStop = true;
            this.Radii_BuscarTransaccionesMesOtro.Text = "Busqueda por Mes Diferente";
            this.Radii_BuscarTransaccionesMesOtro.UseVisualStyleBackColor = true;
            this.Radii_BuscarTransaccionesMesOtro.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // ComBox_Mess
            // 
            this.ComBox_Mess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBox_Mess.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBox_Mess.FormattingEnabled = true;
            this.ComBox_Mess.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Noviembre",
            "Diciembre"});
            this.ComBox_Mess.Location = new System.Drawing.Point(281, 64);
            this.ComBox_Mess.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComBox_Mess.Name = "ComBox_Mess";
            this.ComBox_Mess.Size = new System.Drawing.Size(90, 20);
            this.ComBox_Mess.TabIndex = 2;
            // 
            // ComBox_Año
            // 
            this.ComBox_Año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBox_Año.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBox_Año.FormattingEnabled = true;
            this.ComBox_Año.Location = new System.Drawing.Point(416, 65);
            this.ComBox_Año.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComBox_Año.Name = "ComBox_Año";
            this.ComBox_Año.Size = new System.Drawing.Size(85, 20);
            this.ComBox_Año.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 127);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 207);
            this.dataGridView1.TabIndex = 4;
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
            // transaccionesTableAdapter
            // 
            this.transaccionesTableAdapter.ClearBeforeFill = true;
            // 
            // Grupo_Busqueda
            // 
            this.Grupo_Busqueda.Controls.Add(this.Bttn_Generar);
            this.Grupo_Busqueda.Controls.Add(this.label2);
            this.Grupo_Busqueda.Controls.Add(this.label1);
            this.Grupo_Busqueda.Controls.Add(this.Radii_BuscarTransaccionesMesActaul);
            this.Grupo_Busqueda.Controls.Add(this.Radii_BuscarTransaccionesMesOtro);
            this.Grupo_Busqueda.Controls.Add(this.ComBox_Mess);
            this.Grupo_Busqueda.Controls.Add(this.ComBox_Año);
            this.Grupo_Busqueda.Location = new System.Drawing.Point(10, 12);
            this.Grupo_Busqueda.Name = "Grupo_Busqueda";
            this.Grupo_Busqueda.Size = new System.Drawing.Size(638, 100);
            this.Grupo_Busqueda.TabIndex = 5;
            this.Grupo_Busqueda.TabStop = false;
            this.Grupo_Busqueda.Text = "Opciones de Busqueda de Transacciones ";
            this.Grupo_Busqueda.Enter += new System.EventHandler(this.Grupo_Busqueda_Enter);
            // 
            // Bttn_Generar
            // 
            this.Bttn_Generar.Location = new System.Drawing.Point(533, 52);
            this.Bttn_Generar.Name = "Bttn_Generar";
            this.Bttn_Generar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Bttn_Generar.Size = new System.Drawing.Size(99, 42);
            this.Bttn_Generar.TabIndex = 6;
            this.Bttn_Generar.Text = "Generar";
            this.Bttn_Generar.UseVisualStyleBackColor = true;
            this.Bttn_Generar.Click += new System.EventHandler(this.Bttn_Generar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Año";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mes";
            // 
            // Txt_TotalEfectivo
            // 
            this.Txt_TotalEfectivo.Enabled = false;
            this.Txt_TotalEfectivo.Location = new System.Drawing.Point(129, 351);
            this.Txt_TotalEfectivo.Name = "Txt_TotalEfectivo";
            this.Txt_TotalEfectivo.Size = new System.Drawing.Size(137, 21);
            this.Txt_TotalEfectivo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total en Efectivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total por Tarjeta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total al Credito";
            // 
            // Txt_PorTargetas
            // 
            this.Txt_PorTargetas.Enabled = false;
            this.Txt_PorTargetas.Location = new System.Drawing.Point(129, 386);
            this.Txt_PorTargetas.Name = "Txt_PorTargetas";
            this.Txt_PorTargetas.Size = new System.Drawing.Size(137, 21);
            this.Txt_PorTargetas.TabIndex = 10;
            // 
            // Txt_Creditos
            // 
            this.Txt_Creditos.Enabled = false;
            this.Txt_Creditos.Location = new System.Drawing.Point(129, 426);
            this.Txt_Creditos.Name = "Txt_Creditos";
            this.Txt_Creditos.Size = new System.Drawing.Size(137, 21);
            this.Txt_Creditos.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Num. Total de Ventas";
            // 
            // Txt_NumTotalVentas
            // 
            this.Txt_NumTotalVentas.Enabled = false;
            this.Txt_NumTotalVentas.Location = new System.Drawing.Point(513, 348);
            this.Txt_NumTotalVentas.Name = "Txt_NumTotalVentas";
            this.Txt_NumTotalVentas.Size = new System.Drawing.Size(137, 21);
            this.Txt_NumTotalVentas.TabIndex = 12;
            // 
            // Bttn_salir
            // 
            this.Bttn_salir.Location = new System.Drawing.Point(551, 432);
            this.Bttn_salir.Name = "Bttn_salir";
            this.Bttn_salir.Size = new System.Drawing.Size(99, 42);
            this.Bttn_salir.TabIndex = 16;
            this.Bttn_salir.Text = "Salir";
            this.Bttn_salir.UseVisualStyleBackColor = true;
            this.Bttn_salir.Click += new System.EventHandler(this.Bttn_salir_Click);
            // 
            // Form_PantallaDeArqueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(660, 483);
            this.ControlBox = false;
            this.Controls.Add(this.Bttn_salir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_NumTotalVentas);
            this.Controls.Add(this.Txt_Creditos);
            this.Controls.Add(this.Txt_PorTargetas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_TotalEfectivo);
            this.Controls.Add(this.Grupo_Busqueda);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_PantallaDeArqueo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arqueo de Caja";
            this.Load += new System.EventHandler(this.Form_PantallaDeArqueo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet)).EndInit();
            this.Grupo_Busqueda.ResumeLayout(false);
            this.Grupo_Busqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Radii_BuscarTransaccionesMesActaul;
        private System.Windows.Forms.RadioButton Radii_BuscarTransaccionesMesOtro;
        private System.Windows.Forms.ComboBox ComBox_Mess;
        private System.Windows.Forms.ComboBox ComBox_Año;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VentasAutoPartesDataSet ventasAutoPartesDataSet;
        private System.Windows.Forms.BindingSource transaccionesBindingSource;
        private VentasAutoPartesDataSetTableAdapters.TransaccionesTableAdapter transaccionesTableAdapter;
        private System.Windows.Forms.GroupBox Grupo_Busqueda;
        private System.Windows.Forms.Button Bttn_Generar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_TotalEfectivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_PorTargetas;
        private System.Windows.Forms.TextBox Txt_Creditos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_NumTotalVentas;
        private System.Windows.Forms.Button Bttn_salir;
    }
}
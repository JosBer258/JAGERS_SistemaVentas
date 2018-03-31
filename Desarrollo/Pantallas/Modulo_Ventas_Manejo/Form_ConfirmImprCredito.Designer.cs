namespace Desarrollo.Pantallas.Modulo_Ventas_Manejo
{
    partial class Form_ConfirmImprCredito
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
            this.DGV_Datos = new System.Windows.Forms.DataGridView();
            this.DGV_Col_NoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Col_TotalAPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Col_Restante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bttn_Salir = new System.Windows.Forms.Button();
            this.Bttn_Generar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Date_Hoy = new System.Windows.Forms.DateTimePicker();
            this.Var_NomEmp = new System.Windows.Forms.Label();
            this.Var_Cliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Datos
            // 
            this.DGV_Datos.AllowUserToAddRows = false;
            this.DGV_Datos.AllowUserToDeleteRows = false;
            this.DGV_Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_Col_NoDocumento,
            this.DGV_Col_TotalAPagar,
            this.DGV_Col_Restante});
            this.DGV_Datos.Location = new System.Drawing.Point(12, 101);
            this.DGV_Datos.Name = "DGV_Datos";
            this.DGV_Datos.Size = new System.Drawing.Size(569, 209);
            this.DGV_Datos.TabIndex = 0;
            // 
            // DGV_Col_NoDocumento
            // 
            this.DGV_Col_NoDocumento.HeaderText = "Numero de Factura";
            this.DGV_Col_NoDocumento.Name = "DGV_Col_NoDocumento";
            this.DGV_Col_NoDocumento.ReadOnly = true;
            // 
            // DGV_Col_TotalAPagar
            // 
            this.DGV_Col_TotalAPagar.HeaderText = "Total pagado";
            this.DGV_Col_TotalAPagar.Name = "DGV_Col_TotalAPagar";
            this.DGV_Col_TotalAPagar.ReadOnly = true;
            // 
            // DGV_Col_Restante
            // 
            this.DGV_Col_Restante.HeaderText = "Monto Faltante";
            this.DGV_Col_Restante.Name = "DGV_Col_Restante";
            this.DGV_Col_Restante.ReadOnly = true;
            // 
            // Bttn_Salir
            // 
            this.Bttn_Salir.Location = new System.Drawing.Point(438, 331);
            this.Bttn_Salir.Name = "Bttn_Salir";
            this.Bttn_Salir.Size = new System.Drawing.Size(143, 52);
            this.Bttn_Salir.TabIndex = 1;
            this.Bttn_Salir.Text = "Salir";
            this.Bttn_Salir.UseVisualStyleBackColor = true;
            this.Bttn_Salir.Click += new System.EventHandler(this.Bttn_Salir_Click);
            // 
            // Bttn_Generar
            // 
            this.Bttn_Generar.Location = new System.Drawing.Point(234, 331);
            this.Bttn_Generar.Name = "Bttn_Generar";
            this.Bttn_Generar.Size = new System.Drawing.Size(143, 52);
            this.Bttn_Generar.TabIndex = 2;
            this.Bttn_Generar.Text = "Generar";
            this.Bttn_Generar.UseVisualStyleBackColor = true;
            this.Bttn_Generar.Click += new System.EventHandler(this.Bttn_Generar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del Empleado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre del Cliente:";
            // 
            // Date_Hoy
            // 
            this.Date_Hoy.Enabled = false;
            this.Date_Hoy.Location = new System.Drawing.Point(15, 12);
            this.Date_Hoy.Name = "Date_Hoy";
            this.Date_Hoy.Size = new System.Drawing.Size(247, 20);
            this.Date_Hoy.TabIndex = 5;
            // 
            // Var_NomEmp
            // 
            this.Var_NomEmp.AutoSize = true;
            this.Var_NomEmp.Location = new System.Drawing.Point(146, 49);
            this.Var_NomEmp.Name = "Var_NomEmp";
            this.Var_NomEmp.Size = new System.Drawing.Size(50, 13);
            this.Var_NomEmp.TabIndex = 6;
            this.Var_NomEmp.Text = "Nombre";
            // 
            // Var_Cliente
            // 
            this.Var_Cliente.AutoSize = true;
            this.Var_Cliente.Location = new System.Drawing.Point(149, 73);
            this.Var_Cliente.Name = "Var_Cliente";
            this.Var_Cliente.Size = new System.Drawing.Size(46, 13);
            this.Var_Cliente.TabIndex = 7;
            this.Var_Cliente.Text = "Cliente";
            // 
            // Form_ConfirmImprCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(596, 399);
            this.ControlBox = false;
            this.Controls.Add(this.Var_Cliente);
            this.Controls.Add(this.Var_NomEmp);
            this.Controls.Add(this.Date_Hoy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bttn_Generar);
            this.Controls.Add(this.Bttn_Salir);
            this.Controls.Add(this.DGV_Datos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_ConfirmImprCredito";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Confirmacion de pago de credito";
            this.Load += new System.EventHandler(this.Form_ConfirmImprCredito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Col_NoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Col_TotalAPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Col_Restante;
        private System.Windows.Forms.Button Bttn_Salir;
        private System.Windows.Forms.Button Bttn_Generar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Date_Hoy;
        public System.Windows.Forms.Label Var_NomEmp;
        public System.Windows.Forms.Label Var_Cliente;
        public System.Windows.Forms.DataGridView DGV_Datos;
    }
}
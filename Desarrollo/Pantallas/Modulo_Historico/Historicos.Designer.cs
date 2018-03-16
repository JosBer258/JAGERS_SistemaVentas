namespace Desarrollo.Pantallas.Modulo_Historicos
{
    partial class Historicos
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
            this.Pest1_Grupo_Busqueda = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusquedaNombre = new System.Windows.Forms.TextBox();
            this.Radio_Producto = new System.Windows.Forms.RadioButton();
            this.Pest1_Btn_Limpiar = new System.Windows.Forms.Button();
            this.Radio_Cliente = new System.Windows.Forms.RadioButton();
            this.Radio_Empleado = new System.Windows.Forms.RadioButton();
            this.Radio_Proveedor = new System.Windows.Forms.RadioButton();
            this.DataGriew_Historicos = new System.Windows.Forms.DataGridView();
            this.Bttn_Salir = new System.Windows.Forms.Button();
            this.Pest1_Grupo_Busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriew_Historicos)).BeginInit();
            this.SuspendLayout();
            // 
            // Pest1_Grupo_Busqueda
            // 
            this.Pest1_Grupo_Busqueda.Controls.Add(this.label1);
            this.Pest1_Grupo_Busqueda.Controls.Add(this.txtBusquedaNombre);
            this.Pest1_Grupo_Busqueda.Controls.Add(this.Radio_Producto);
            this.Pest1_Grupo_Busqueda.Controls.Add(this.Pest1_Btn_Limpiar);
            this.Pest1_Grupo_Busqueda.Controls.Add(this.Radio_Cliente);
            this.Pest1_Grupo_Busqueda.Controls.Add(this.Radio_Empleado);
            this.Pest1_Grupo_Busqueda.Controls.Add(this.Radio_Proveedor);
            this.Pest1_Grupo_Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest1_Grupo_Busqueda.Location = new System.Drawing.Point(12, 10);
            this.Pest1_Grupo_Busqueda.Margin = new System.Windows.Forms.Padding(1);
            this.Pest1_Grupo_Busqueda.Name = "Pest1_Grupo_Busqueda";
            this.Pest1_Grupo_Busqueda.Padding = new System.Windows.Forms.Padding(1);
            this.Pest1_Grupo_Busqueda.Size = new System.Drawing.Size(932, 101);
            this.Pest1_Grupo_Busqueda.TabIndex = 3;
            this.Pest1_Grupo_Busqueda.TabStop = false;
            this.Pest1_Grupo_Busqueda.Text = "Búsqueda Historica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filtro Nombre:";
            // 
            // txtBusquedaNombre
            // 
            this.txtBusquedaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaNombre.Location = new System.Drawing.Point(516, 42);
            this.txtBusquedaNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusquedaNombre.MaxLength = 38;
            this.txtBusquedaNombre.Name = "txtBusquedaNombre";
            this.txtBusquedaNombre.Size = new System.Drawing.Size(194, 24);
            this.txtBusquedaNombre.TabIndex = 7;
            this.txtBusquedaNombre.TextChanged += new System.EventHandler(this.txtBusquedaNombre_TextChanged);
            this.txtBusquedaNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusquedaNombre_KeyPress);
            // 
            // Radio_Producto
            // 
            this.Radio_Producto.AutoSize = true;
            this.Radio_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio_Producto.Location = new System.Drawing.Point(182, 32);
            this.Radio_Producto.Margin = new System.Windows.Forms.Padding(1);
            this.Radio_Producto.Name = "Radio_Producto";
            this.Radio_Producto.Size = new System.Drawing.Size(103, 20);
            this.Radio_Producto.TabIndex = 6;
            this.Radio_Producto.Text = "Producto";
            this.Radio_Producto.UseVisualStyleBackColor = true;
            this.Radio_Producto.CheckedChanged += new System.EventHandler(this.Radio_Producto_CheckedChanged);
            // 
            // Pest1_Btn_Limpiar
            // 
            this.Pest1_Btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest1_Btn_Limpiar.Location = new System.Drawing.Point(734, 29);
            this.Pest1_Btn_Limpiar.Margin = new System.Windows.Forms.Padding(1);
            this.Pest1_Btn_Limpiar.Name = "Pest1_Btn_Limpiar";
            this.Pest1_Btn_Limpiar.Size = new System.Drawing.Size(190, 45);
            this.Pest1_Btn_Limpiar.TabIndex = 5;
            this.Pest1_Btn_Limpiar.Text = "Limpiar";
            this.Pest1_Btn_Limpiar.UseVisualStyleBackColor = true;
            this.Pest1_Btn_Limpiar.Click += new System.EventHandler(this.Pest1_Btn_Limpiar_Click);
            // 
            // Radio_Cliente
            // 
            this.Radio_Cliente.AutoSize = true;
            this.Radio_Cliente.Checked = true;
            this.Radio_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio_Cliente.Location = new System.Drawing.Point(24, 32);
            this.Radio_Cliente.Margin = new System.Windows.Forms.Padding(1);
            this.Radio_Cliente.Name = "Radio_Cliente";
            this.Radio_Cliente.Size = new System.Drawing.Size(86, 20);
            this.Radio_Cliente.TabIndex = 2;
            this.Radio_Cliente.TabStop = true;
            this.Radio_Cliente.Text = "Cliente";
            this.Radio_Cliente.UseVisualStyleBackColor = true;
            this.Radio_Cliente.CheckedChanged += new System.EventHandler(this.Radio_Cliente_CheckedChanged);
            // 
            // Radio_Empleado
            // 
            this.Radio_Empleado.AutoSize = true;
            this.Radio_Empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio_Empleado.Location = new System.Drawing.Point(24, 66);
            this.Radio_Empleado.Margin = new System.Windows.Forms.Padding(1);
            this.Radio_Empleado.Name = "Radio_Empleado";
            this.Radio_Empleado.Size = new System.Drawing.Size(113, 20);
            this.Radio_Empleado.TabIndex = 1;
            this.Radio_Empleado.Text = "Empleado";
            this.Radio_Empleado.UseVisualStyleBackColor = true;
            this.Radio_Empleado.CheckedChanged += new System.EventHandler(this.Radio_Empleado_CheckedChanged);
            // 
            // Radio_Proveedor
            // 
            this.Radio_Proveedor.AutoSize = true;
            this.Radio_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio_Proveedor.Location = new System.Drawing.Point(182, 66);
            this.Radio_Proveedor.Margin = new System.Windows.Forms.Padding(1);
            this.Radio_Proveedor.Name = "Radio_Proveedor";
            this.Radio_Proveedor.Size = new System.Drawing.Size(115, 20);
            this.Radio_Proveedor.TabIndex = 0;
            this.Radio_Proveedor.Text = "Proveedor";
            this.Radio_Proveedor.UseVisualStyleBackColor = true;
            this.Radio_Proveedor.CheckedChanged += new System.EventHandler(this.Radio_Proveedor_CheckedChanged);
            // 
            // DataGriew_Historicos
            // 
            this.DataGriew_Historicos.AllowUserToAddRows = false;
            this.DataGriew_Historicos.AllowUserToDeleteRows = false;
            this.DataGriew_Historicos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGriew_Historicos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGriew_Historicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGriew_Historicos.Location = new System.Drawing.Point(12, 113);
            this.DataGriew_Historicos.Margin = new System.Windows.Forms.Padding(1);
            this.DataGriew_Historicos.Name = "DataGriew_Historicos";
            this.DataGriew_Historicos.ReadOnly = true;
            this.DataGriew_Historicos.RowTemplate.Height = 28;
            this.DataGriew_Historicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGriew_Historicos.Size = new System.Drawing.Size(932, 226);
            this.DataGriew_Historicos.TabIndex = 2;
            // 
            // Bttn_Salir
            // 
            this.Bttn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttn_Salir.Location = new System.Drawing.Point(754, 343);
            this.Bttn_Salir.Margin = new System.Windows.Forms.Padding(1);
            this.Bttn_Salir.Name = "Bttn_Salir";
            this.Bttn_Salir.Size = new System.Drawing.Size(190, 45);
            this.Bttn_Salir.TabIndex = 9;
            this.Bttn_Salir.Text = "Salir";
            this.Bttn_Salir.UseVisualStyleBackColor = true;
            this.Bttn_Salir.Click += new System.EventHandler(this.Bttn_Salir_Click);
            // 
            // Historicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(955, 398);
            this.ControlBox = false;
            this.Controls.Add(this.Bttn_Salir);
            this.Controls.Add(this.Pest1_Grupo_Busqueda);
            this.Controls.Add(this.DataGriew_Historicos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Historicos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Historicos";
            this.Load += new System.EventHandler(this.Historicos_Load);
            this.Pest1_Grupo_Busqueda.ResumeLayout(false);
            this.Pest1_Grupo_Busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriew_Historicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Pest1_Grupo_Busqueda;
        private System.Windows.Forms.RadioButton Radio_Producto;
        private System.Windows.Forms.Button Pest1_Btn_Limpiar;
        private System.Windows.Forms.RadioButton Radio_Cliente;
        private System.Windows.Forms.RadioButton Radio_Empleado;
        private System.Windows.Forms.RadioButton Radio_Proveedor;
        private System.Windows.Forms.DataGridView DataGriew_Historicos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusquedaNombre;
        private System.Windows.Forms.Button Bttn_Salir;
    }
}
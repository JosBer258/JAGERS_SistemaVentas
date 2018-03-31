namespace Desarrollo.Pantallas.Estados
{
    partial class Form_Localidades
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
            this.button1 = new System.Windows.Forms.Button();
            this.DataGriew_Localidades = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBoz_Estados = new System.Windows.Forms.ComboBox();
            this.Txt_Direccion = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Radio_Nueva = new System.Windows.Forms.RadioButton();
            this.Radio_Actualizar = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGriew_Localidades)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataGriew_Localidades
            // 
            this.DataGriew_Localidades.AllowUserToAddRows = false;
            this.DataGriew_Localidades.AllowUserToDeleteRows = false;
            this.DataGriew_Localidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGriew_Localidades.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGriew_Localidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGriew_Localidades.Location = new System.Drawing.Point(14, 137);
            this.DataGriew_Localidades.Name = "DataGriew_Localidades";
            this.DataGriew_Localidades.ReadOnly = true;
            this.DataGriew_Localidades.Size = new System.Drawing.Size(546, 153);
            this.DataGriew_Localidades.TabIndex = 1;
            this.DataGriew_Localidades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGriew_Localidades_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ComboBoz_Estados);
            this.groupBox1.Controls.Add(this.Txt_Direccion);
            this.groupBox1.Controls.Add(this.Txt_Nombre);
            this.groupBox1.Controls.Add(this.Txt_Codigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(14, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manejo de Localidades";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Estado";
            // 
            // ComboBoz_Estados
            // 
            this.ComboBoz_Estados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoz_Estados.FormattingEnabled = true;
            this.ComboBoz_Estados.Location = new System.Drawing.Point(284, 47);
            this.ComboBoz_Estados.Name = "ComboBoz_Estados";
            this.ComboBoz_Estados.Size = new System.Drawing.Size(140, 21);
            this.ComboBoz_Estados.TabIndex = 8;
            // 
            // Txt_Direccion
            // 
            this.Txt_Direccion.Location = new System.Drawing.Point(284, 19);
            this.Txt_Direccion.MaxLength = 90;
            this.Txt_Direccion.Multiline = true;
            this.Txt_Direccion.Name = "Txt_Direccion";
            this.Txt_Direccion.Size = new System.Drawing.Size(140, 22);
            this.Txt_Direccion.TabIndex = 7;
            this.Txt_Direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Direccion_KeyPress);
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(85, 49);
            this.Txt_Nombre.MaxLength = 35;
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(116, 20);
            this.Txt_Nombre.TabIndex = 6;
            this.Txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nombre_KeyPress);
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Enabled = false;
            this.Txt_Codigo.Location = new System.Drawing.Point(85, 22);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(116, 20);
            this.Txt_Codigo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 45);
            this.button2.TabIndex = 0;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Radio_Nueva
            // 
            this.Radio_Nueva.AutoSize = true;
            this.Radio_Nueva.Location = new System.Drawing.Point(148, 17);
            this.Radio_Nueva.Name = "Radio_Nueva";
            this.Radio_Nueva.Size = new System.Drawing.Size(121, 17);
            this.Radio_Nueva.TabIndex = 3;
            this.Radio_Nueva.TabStop = true;
            this.Radio_Nueva.Text = "Nueva Localidad";
            this.Radio_Nueva.UseVisualStyleBackColor = true;
            this.Radio_Nueva.CheckedChanged += new System.EventHandler(this.Radio_Nueva_CheckedChanged);
            // 
            // Radio_Actualizar
            // 
            this.Radio_Actualizar.AutoSize = true;
            this.Radio_Actualizar.Location = new System.Drawing.Point(287, 17);
            this.Radio_Actualizar.Name = "Radio_Actualizar";
            this.Radio_Actualizar.Size = new System.Drawing.Size(101, 17);
            this.Radio_Actualizar.TabIndex = 4;
            this.Radio_Actualizar.TabStop = true;
            this.Radio_Actualizar.Text = "Actualizacion";
            this.Radio_Actualizar.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_Localidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(574, 371);
            this.ControlBox = false;
            this.Controls.Add(this.Radio_Actualizar);
            this.Controls.Add(this.Radio_Nueva);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DataGriew_Localidades);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_Localidades";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Localidades";
            this.Load += new System.EventHandler(this.Form_Localidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGriew_Localidades)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DataGriew_Localidades;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboBoz_Estados;
        private System.Windows.Forms.TextBox Txt_Direccion;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton Radio_Nueva;
        private System.Windows.Forms.RadioButton Radio_Actualizar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
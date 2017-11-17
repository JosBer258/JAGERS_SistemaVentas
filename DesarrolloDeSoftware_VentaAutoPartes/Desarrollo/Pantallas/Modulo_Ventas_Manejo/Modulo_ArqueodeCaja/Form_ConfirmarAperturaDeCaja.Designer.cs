namespace Desarrollo.Pantallas.Modulo_Ventas_Manejo.Modulo_ArqueodeCaja
{
    partial class Form_ConfirmarAperturaDeCaja
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
            this.Bttn_Aceptar = new System.Windows.Forms.Button();
            this.Bttn_Cancelar = new System.Windows.Forms.Button();
            this.Txt_COntraseñaCOnfirmacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Bttn_Rechazar = new System.Windows.Forms.Button();
            this.Label_DineroRecibido = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Bttn_Aceptar
            // 
            this.Bttn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttn_Aceptar.Location = new System.Drawing.Point(111, 200);
            this.Bttn_Aceptar.Name = "Bttn_Aceptar";
            this.Bttn_Aceptar.Size = new System.Drawing.Size(88, 41);
            this.Bttn_Aceptar.TabIndex = 23;
            this.Bttn_Aceptar.Text = "Aceptar";
            this.Bttn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // Bttn_Cancelar
            // 
            this.Bttn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttn_Cancelar.Location = new System.Drawing.Point(210, 200);
            this.Bttn_Cancelar.Name = "Bttn_Cancelar";
            this.Bttn_Cancelar.Size = new System.Drawing.Size(88, 41);
            this.Bttn_Cancelar.TabIndex = 22;
            this.Bttn_Cancelar.Text = "Cancelar";
            this.Bttn_Cancelar.UseVisualStyleBackColor = true;
            this.Bttn_Cancelar.Click += new System.EventHandler(this.Bttn_Cancelar_Click);
            // 
            // Txt_COntraseñaCOnfirmacion
            // 
            this.Txt_COntraseñaCOnfirmacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_COntraseñaCOnfirmacion.Location = new System.Drawing.Point(7, 29);
            this.Txt_COntraseñaCOnfirmacion.Name = "Txt_COntraseñaCOnfirmacion";
            this.Txt_COntraseñaCOnfirmacion.Size = new System.Drawing.Size(268, 21);
            this.Txt_COntraseñaCOnfirmacion.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total de efectivo recibido: Lps.\r\n";
            // 
            // Bttn_Rechazar
            // 
            this.Bttn_Rechazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttn_Rechazar.Location = new System.Drawing.Point(12, 200);
            this.Bttn_Rechazar.Name = "Bttn_Rechazar";
            this.Bttn_Rechazar.Size = new System.Drawing.Size(88, 41);
            this.Bttn_Rechazar.TabIndex = 24;
            this.Bttn_Rechazar.Text = "Rechazar";
            this.Bttn_Rechazar.UseVisualStyleBackColor = true;
            // 
            // Label_DineroRecibido
            // 
            this.Label_DineroRecibido.AutoSize = true;
            this.Label_DineroRecibido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DineroRecibido.Location = new System.Drawing.Point(251, 74);
            this.Label_DineroRecibido.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label_DineroRecibido.Name = "Label_DineroRecibido";
            this.Label_DineroRecibido.Size = new System.Drawing.Size(36, 16);
            this.Label_DineroRecibido.TabIndex = 25;
            this.Label_DineroRecibido.Text = "0.00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_COntraseñaCOnfirmacion);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 68);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese su Contraseña para confirmar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Image = global::Desarrollo.Properties.Resources._1;
            this.label6.Location = new System.Drawing.Point(14, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Confirmacion de Apertura de Caja\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Desarrollo.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 62);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form_ConfirmarAperturaDeCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(323, 256);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Label_DineroRecibido);
            this.Controls.Add(this.Bttn_Rechazar);
            this.Controls.Add(this.Bttn_Aceptar);
            this.Controls.Add(this.Bttn_Cancelar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form_ConfirmarAperturaDeCaja";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmacion de Apertura de Caja";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bttn_Aceptar;
        private System.Windows.Forms.Button Bttn_Cancelar;
        private System.Windows.Forms.TextBox Txt_COntraseñaCOnfirmacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bttn_Rechazar;
        private System.Windows.Forms.Label Label_DineroRecibido;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
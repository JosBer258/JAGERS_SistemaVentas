﻿namespace Desarrollo.Pantallas.Modulo_Ventas_Manejo.Modulo_ArqueodeCaja
{
    partial class Form_PantallCierreConfirmacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Text_TotalEfectivoCaja = new System.Windows.Forms.TextBox();
            this.Txt_TotalTarjeta = new System.Windows.Forms.TextBox();
            this.Txt_TotalCredito = new System.Windows.Forms.TextBox();
            this.Txt_COntraseñaCOnfirmacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Bttn_Cancelar = new System.Windows.Forms.Button();
            this.Bttn_Aceptar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Text_TotalEfectivoVenta = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto total en Caja ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total con Tarjeta de Credito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total a Credito";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Desarrollo.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 70);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Image = global::Desarrollo.Properties.Resources._1;
            this.label6.Location = new System.Drawing.Point(25, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(342, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Confirmacion de Cierre de Caja";
            // 
            // Text_TotalEfectivoCaja
            // 
            this.Text_TotalEfectivoCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_TotalEfectivoCaja.Location = new System.Drawing.Point(274, 83);
            this.Text_TotalEfectivoCaja.MaxLength = 10;
            this.Text_TotalEfectivoCaja.Name = "Text_TotalEfectivoCaja";
            this.Text_TotalEfectivoCaja.Size = new System.Drawing.Size(208, 22);
            this.Text_TotalEfectivoCaja.TabIndex = 7;
            this.Text_TotalEfectivoCaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_TotalEfectivoCaja_KeyPress);
            // 
            // Txt_TotalTarjeta
            // 
            this.Txt_TotalTarjeta.Enabled = false;
            this.Txt_TotalTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TotalTarjeta.Location = new System.Drawing.Point(274, 141);
            this.Txt_TotalTarjeta.Name = "Txt_TotalTarjeta";
            this.Txt_TotalTarjeta.Size = new System.Drawing.Size(208, 22);
            this.Txt_TotalTarjeta.TabIndex = 8;
            // 
            // Txt_TotalCredito
            // 
            this.Txt_TotalCredito.Enabled = false;
            this.Txt_TotalCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TotalCredito.Location = new System.Drawing.Point(274, 172);
            this.Txt_TotalCredito.Name = "Txt_TotalCredito";
            this.Txt_TotalCredito.Size = new System.Drawing.Size(208, 22);
            this.Txt_TotalCredito.TabIndex = 9;
            // 
            // Txt_COntraseñaCOnfirmacion
            // 
            this.Txt_COntraseñaCOnfirmacion.Location = new System.Drawing.Point(119, 282);
            this.Txt_COntraseñaCOnfirmacion.MaxLength = 25;
            this.Txt_COntraseñaCOnfirmacion.Name = "Txt_COntraseñaCOnfirmacion";
            this.Txt_COntraseñaCOnfirmacion.Size = new System.Drawing.Size(260, 24);
            this.Txt_COntraseñaCOnfirmacion.TabIndex = 12;
            this.Txt_COntraseñaCOnfirmacion.UseSystemPasswordChar = true;
            this.Txt_COntraseñaCOnfirmacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_COntraseñaCOnfirmacion_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(104, 247);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(295, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Contraseña de Usuario para confirmación\r\n\r\n";
            // 
            // Bttn_Cancelar
            // 
            this.Bttn_Cancelar.Location = new System.Drawing.Point(28, 340);
            this.Bttn_Cancelar.Name = "Bttn_Cancelar";
            this.Bttn_Cancelar.Size = new System.Drawing.Size(169, 41);
            this.Bttn_Cancelar.TabIndex = 14;
            this.Bttn_Cancelar.Text = "Cancelar";
            this.Bttn_Cancelar.UseVisualStyleBackColor = true;
            this.Bttn_Cancelar.Click += new System.EventHandler(this.Bttn_Cancelar_Click);
            // 
            // Bttn_Aceptar
            // 
            this.Bttn_Aceptar.Location = new System.Drawing.Point(313, 340);
            this.Bttn_Aceptar.Name = "Bttn_Aceptar";
            this.Bttn_Aceptar.Size = new System.Drawing.Size(169, 41);
            this.Bttn_Aceptar.TabIndex = 15;
            this.Bttn_Aceptar.Text = "Aceptar";
            this.Bttn_Aceptar.UseVisualStyleBackColor = true;
            this.Bttn_Aceptar.Click += new System.EventHandler(this.Bttn_Aceptar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total con Efectivo";
            // 
            // Text_TotalEfectivoVenta
            // 
            this.Text_TotalEfectivoVenta.Enabled = false;
            this.Text_TotalEfectivoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_TotalEfectivoVenta.Location = new System.Drawing.Point(274, 112);
            this.Text_TotalEfectivoVenta.Name = "Text_TotalEfectivoVenta";
            this.Text_TotalEfectivoVenta.Size = new System.Drawing.Size(208, 22);
            this.Text_TotalEfectivoVenta.TabIndex = 17;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_PantallCierreConfirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(502, 390);
            this.ControlBox = false;
            this.Controls.Add(this.Text_TotalEfectivoVenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Bttn_Aceptar);
            this.Controls.Add(this.Bttn_Cancelar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_COntraseñaCOnfirmacion);
            this.Controls.Add(this.Txt_TotalCredito);
            this.Controls.Add(this.Txt_TotalTarjeta);
            this.Controls.Add(this.Text_TotalEfectivoCaja);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form_PantallCierreConfirmacion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmacion de Cierre de Caja";
            this.Load += new System.EventHandler(this.Form_PantallCierreConfirmacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Text_TotalEfectivoCaja;
        private System.Windows.Forms.TextBox Txt_TotalTarjeta;
        private System.Windows.Forms.TextBox Txt_TotalCredito;
        private System.Windows.Forms.TextBox Txt_COntraseñaCOnfirmacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Bttn_Cancelar;
        private System.Windows.Forms.Button Bttn_Aceptar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Text_TotalEfectivoVenta;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
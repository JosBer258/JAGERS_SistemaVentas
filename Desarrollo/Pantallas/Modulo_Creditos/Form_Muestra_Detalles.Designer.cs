namespace Desarrollo.Pantallas.Modulo_Creditos
{
    partial class Form_Muestra_Detalles
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
            this.Bttn_Salir = new System.Windows.Forms.Button();
            this.DGV_Detalles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Detalles)).BeginInit();
            this.SuspendLayout();
            // 
            // Bttn_Salir
            // 
            this.Bttn_Salir.Location = new System.Drawing.Point(455, 287);
            this.Bttn_Salir.Name = "Bttn_Salir";
            this.Bttn_Salir.Size = new System.Drawing.Size(153, 58);
            this.Bttn_Salir.TabIndex = 0;
            this.Bttn_Salir.Text = "Aceptar";
            this.Bttn_Salir.UseVisualStyleBackColor = true;
            this.Bttn_Salir.Click += new System.EventHandler(this.Bttn_Salir_Click);
            // 
            // DGV_Detalles
            // 
            this.DGV_Detalles.AllowUserToAddRows = false;
            this.DGV_Detalles.AllowUserToDeleteRows = false;
            this.DGV_Detalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Detalles.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGV_Detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Detalles.Location = new System.Drawing.Point(12, 12);
            this.DGV_Detalles.Name = "DGV_Detalles";
            this.DGV_Detalles.ReadOnly = true;
            this.DGV_Detalles.Size = new System.Drawing.Size(596, 269);
            this.DGV_Detalles.TabIndex = 1;
            // 
            // Form_Muestra_Detalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(621, 357);
            this.ControlBox = false;
            this.Controls.Add(this.DGV_Detalles);
            this.Controls.Add(this.Bttn_Salir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_Muestra_Detalles";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Muestra de detalles";
            this.Load += new System.EventHandler(this.Form_Muestra_Detalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Detalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bttn_Salir;
        private System.Windows.Forms.DataGridView DGV_Detalles;
    }
}
namespace Desarrollo.Pantallas.Modulo__Ingreso_al_sistema
{
    partial class Form_Desbloqueo_De_Usuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Txt_Password_Primera = new System.Windows.Forms.TextBox();
            this.Txt_UserID = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.Txt_Password_Primera);
            this.panel1.Controls.Add(this.Txt_UserID);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 128);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(185, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Acceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(12, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Txt_Password_Primera
            // 
            this.Txt_Password_Primera.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Txt_Password_Primera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Password_Primera.ForeColor = System.Drawing.SystemColors.Info;
            this.Txt_Password_Primera.Location = new System.Drawing.Point(69, 75);
            this.Txt_Password_Primera.Margin = new System.Windows.Forms.Padding(7);
            this.Txt_Password_Primera.MaxLength = 15;
            this.Txt_Password_Primera.Name = "Txt_Password_Primera";
            this.Txt_Password_Primera.Size = new System.Drawing.Size(220, 26);
            this.Txt_Password_Primera.TabIndex = 26;
            this.Txt_Password_Primera.UseSystemPasswordChar = true;
            // 
            // Txt_UserID
            // 
            this.Txt_UserID.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Txt_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_UserID.ForeColor = System.Drawing.SystemColors.Info;
            this.Txt_UserID.Location = new System.Drawing.Point(69, 30);
            this.Txt_UserID.Margin = new System.Windows.Forms.Padding(7);
            this.Txt_UserID.MaxLength = 15;
            this.Txt_UserID.Name = "Txt_UserID";
            this.Txt_UserID.Size = new System.Drawing.Size(220, 26);
            this.Txt_UserID.TabIndex = 25;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::Desarrollo.Properties.Resources._2;
            this.pictureBox5.Image = global::Desarrollo.Properties.Resources.corbata;
            this.pictureBox5.Location = new System.Drawing.Point(15, 18);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(44, 43);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::Desarrollo.Properties.Resources._2;
            this.pictureBox6.Image = global::Desarrollo.Properties.Resources.candado;
            this.pictureBox6.Location = new System.Drawing.Point(15, 68);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(44, 43);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 24;
            this.pictureBox6.TabStop = false;
            // 
            // Form_Desbloqueo_De_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Desarrollo.Properties.Resources.rayos_azules_51b330b6e7aaa;
            this.ClientSize = new System.Drawing.Size(327, 234);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Desbloqueo_De_Usuario";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Desbloqueo del Sistema";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Txt_Password_Primera;
        private System.Windows.Forms.TextBox Txt_UserID;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}
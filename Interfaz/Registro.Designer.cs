namespace Hackaton_Frontasks.Interfaz
{
    partial class Registro
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
            this.TbName = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.TbMail = new System.Windows.Forms.TextBox();
            this.TbLastName = new System.Windows.Forms.TextBox();
            this.BtRegistrar = new System.Windows.Forms.Button();
            this.LinkIniciar = new System.Windows.Forms.LinkLabel();
            this.TbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(263, 308);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(373, 22);
            this.TbName.TabIndex = 0;
            this.TbName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(263, 425);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(373, 22);
            this.TbPassword.TabIndex = 1;
            // 
            // TbMail
            // 
            this.TbMail.Location = new System.Drawing.Point(263, 385);
            this.TbMail.Name = "TbMail";
            this.TbMail.Size = new System.Drawing.Size(373, 22);
            this.TbMail.TabIndex = 2;
            // 
            // TbLastName
            // 
            this.TbLastName.Location = new System.Drawing.Point(263, 347);
            this.TbLastName.Name = "TbLastName";
            this.TbLastName.Size = new System.Drawing.Size(373, 22);
            this.TbLastName.TabIndex = 3;
            this.TbLastName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // BtRegistrar
            // 
            this.BtRegistrar.Location = new System.Drawing.Point(66, 481);
            this.BtRegistrar.Name = "BtRegistrar";
            this.BtRegistrar.Size = new System.Drawing.Size(672, 38);
            this.BtRegistrar.TabIndex = 4;
            this.BtRegistrar.Text = "Registrarse";
            this.BtRegistrar.UseVisualStyleBackColor = true;
            this.BtRegistrar.Click += new System.EventHandler(this.BtRegistrar_Click);
            // 
            // LinkIniciar
            // 
            this.LinkIniciar.AutoSize = true;
            this.LinkIniciar.Location = new System.Drawing.Point(318, 537);
            this.LinkIniciar.Name = "LinkIniciar";
            this.LinkIniciar.Size = new System.Drawing.Size(191, 16);
            this.LinkIniciar.TabIndex = 5;
            this.LinkIniciar.TabStop = true;
            this.LinkIniciar.Text = "ya tienes cuenta?, inicia secion";
            this.LinkIniciar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkIniciar_LinkClicked);
            // 
            // TbId
            // 
            this.TbId.Location = new System.Drawing.Point(263, 268);
            this.TbId.Name = "TbId";
            this.TbId.Size = new System.Drawing.Size(373, 22);
            this.TbId.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Hackaton_Frontasks.Properties.Resources.ImgLogoFront;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(249, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 208);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(837, 578);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbId);
            this.Controls.Add(this.LinkIniciar);
            this.Controls.Add(this.BtRegistrar);
            this.Controls.Add(this.TbLastName);
            this.Controls.Add(this.TbMail);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbName);
            this.Name = "Registro";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.TextBox TbMail;
        private System.Windows.Forms.TextBox TbLastName;
        private System.Windows.Forms.Button BtRegistrar;
        private System.Windows.Forms.LinkLabel LinkIniciar;
        private System.Windows.Forms.TextBox TbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
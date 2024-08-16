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
            this.SuspendLayout();
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(169, 121);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(359, 22);
            this.TbName.TabIndex = 0;
            this.TbName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(169, 238);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(359, 22);
            this.TbPassword.TabIndex = 1;
            // 
            // TbMail
            // 
            this.TbMail.Location = new System.Drawing.Point(169, 198);
            this.TbMail.Name = "TbMail";
            this.TbMail.Size = new System.Drawing.Size(359, 22);
            this.TbMail.TabIndex = 2;
            // 
            // TbLastName
            // 
            this.TbLastName.Location = new System.Drawing.Point(169, 160);
            this.TbLastName.Name = "TbLastName";
            this.TbLastName.Size = new System.Drawing.Size(359, 22);
            this.TbLastName.TabIndex = 3;
            this.TbLastName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // BtRegistrar
            // 
            this.BtRegistrar.Location = new System.Drawing.Point(272, 294);
            this.BtRegistrar.Name = "BtRegistrar";
            this.BtRegistrar.Size = new System.Drawing.Size(110, 23);
            this.BtRegistrar.TabIndex = 4;
            this.BtRegistrar.Text = "Registrarse";
            this.BtRegistrar.UseVisualStyleBackColor = true;
            this.BtRegistrar.Click += new System.EventHandler(this.BtRegistrar_Click);
            // 
            // LinkIniciar
            // 
            this.LinkIniciar.AutoSize = true;
            this.LinkIniciar.Location = new System.Drawing.Point(245, 342);
            this.LinkIniciar.Name = "LinkIniciar";
            this.LinkIniciar.Size = new System.Drawing.Size(191, 16);
            this.LinkIniciar.TabIndex = 5;
            this.LinkIniciar.TabStop = true;
            this.LinkIniciar.Text = "ya tienes cuenta?, inicia secion";
            this.LinkIniciar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkIniciar_LinkClicked);
            // 
            // TbId
            // 
            this.TbId.Location = new System.Drawing.Point(169, 81);
            this.TbId.Name = "TbId";
            this.TbId.Size = new System.Drawing.Size(359, 22);
            this.TbId.TabIndex = 6;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbId);
            this.Controls.Add(this.LinkIniciar);
            this.Controls.Add(this.BtRegistrar);
            this.Controls.Add(this.TbLastName);
            this.Controls.Add(this.TbMail);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbName);
            this.Name = "Registro";
            this.Text = "Form1";
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
    }
}
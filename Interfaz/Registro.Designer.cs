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
            this.SuspendLayout();
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(12, 207);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(359, 22);
            this.TbName.TabIndex = 0;
            this.TbName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(12, 324);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(359, 22);
            this.TbPassword.TabIndex = 1;
            // 
            // TbMail
            // 
            this.TbMail.Location = new System.Drawing.Point(12, 284);
            this.TbMail.Name = "TbMail";
            this.TbMail.Size = new System.Drawing.Size(359, 22);
            this.TbMail.TabIndex = 2;
            // 
            // TbLastName
            // 
            this.TbLastName.Location = new System.Drawing.Point(12, 246);
            this.TbLastName.Name = "TbLastName";
            this.TbLastName.Size = new System.Drawing.Size(359, 22);
            this.TbLastName.TabIndex = 3;
            this.TbLastName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbLastName);
            this.Controls.Add(this.TbMail);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.TextBox TbMail;
        private System.Windows.Forms.TextBox TbLastName;
    }
}
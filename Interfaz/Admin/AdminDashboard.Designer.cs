namespace Hackaton_Frontasks.Interfaz.Admin
{
    partial class AdminDashboard
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
            this.t = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtListUsuarios = new System.Windows.Forms.Button();
            this.BtCerrarSesion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.t.Location = new System.Drawing.Point(30, 20);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(147, 26);
            this.t.TabIndex = 0;
            this.t.Text = "Administrador";
            this.t.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtListUsuarios);
            this.panel1.Controls.Add(this.t);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 450);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtListUsuarios
            // 
            this.BtListUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtListUsuarios.Location = new System.Drawing.Point(1, 70);
            this.BtListUsuarios.Name = "BtListUsuarios";
            this.BtListUsuarios.Size = new System.Drawing.Size(203, 64);
            this.BtListUsuarios.TabIndex = 1;
            this.BtListUsuarios.Text = "Usuarios";
            this.BtListUsuarios.UseVisualStyleBackColor = true;
            this.BtListUsuarios.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtCerrarSesion
            // 
            this.BtCerrarSesion.BackgroundImage = global::Hackaton_Frontasks.Properties.Resources.logout_1;
            this.BtCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCerrarSesion.Location = new System.Drawing.Point(740, 11);
            this.BtCerrarSesion.Name = "BtCerrarSesion";
            this.BtCerrarSesion.Size = new System.Drawing.Size(48, 48);
            this.BtCerrarSesion.TabIndex = 2;
            this.BtCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtCerrarSesion);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtListUsuarios;
        private System.Windows.Forms.Button BtCerrarSesion;
    }
}
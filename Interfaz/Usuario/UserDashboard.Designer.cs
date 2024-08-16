namespace Hackaton_Frontasks.Interfaz.Usuario
{
    partial class UserDashboard
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
            this.BtListaCompletadas = new System.Windows.Forms.Button();
            this.BtTareasAtrasadas = new System.Windows.Forms.Button();
            this.BtListPendientes = new System.Windows.Forms.Button();
            this.BtNuevaTarea = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtListTareas = new System.Windows.Forms.Button();
            this.t = new System.Windows.Forms.Label();
            this.idUsuario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtListaCompletadas);
            this.panel1.Controls.Add(this.BtTareasAtrasadas);
            this.panel1.Controls.Add(this.BtListPendientes);
            this.panel1.Controls.Add(this.BtNuevaTarea);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtListTareas);
            this.panel1.Controls.Add(this.t);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 450);
            this.panel1.TabIndex = 2;
            // 
            // BtListaCompletadas
            // 
            this.BtListaCompletadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtListaCompletadas.Location = new System.Drawing.Point(3, 300);
            this.BtListaCompletadas.Name = "BtListaCompletadas";
            this.BtListaCompletadas.Size = new System.Drawing.Size(203, 44);
            this.BtListaCompletadas.TabIndex = 6;
            this.BtListaCompletadas.Text = "Completadas";
            this.BtListaCompletadas.UseVisualStyleBackColor = true;
            this.BtListaCompletadas.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtTareasAtrasadas
            // 
            this.BtTareasAtrasadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtTareasAtrasadas.Location = new System.Drawing.Point(-1, 250);
            this.BtTareasAtrasadas.Name = "BtTareasAtrasadas";
            this.BtTareasAtrasadas.Size = new System.Drawing.Size(203, 44);
            this.BtTareasAtrasadas.TabIndex = 5;
            this.BtTareasAtrasadas.Text = "Atrasadas";
            this.BtTareasAtrasadas.UseVisualStyleBackColor = true;
            // 
            // BtListPendientes
            // 
            this.BtListPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtListPendientes.Location = new System.Drawing.Point(0, 200);
            this.BtListPendientes.Name = "BtListPendientes";
            this.BtListPendientes.Size = new System.Drawing.Size(203, 44);
            this.BtListPendientes.TabIndex = 4;
            this.BtListPendientes.Text = "Pendientes";
            this.BtListPendientes.UseVisualStyleBackColor = true;
            // 
            // BtNuevaTarea
            // 
            this.BtNuevaTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.BtNuevaTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtNuevaTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtNuevaTarea.ForeColor = System.Drawing.Color.White;
            this.BtNuevaTarea.Location = new System.Drawing.Point(0, 78);
            this.BtNuevaTarea.Name = "BtNuevaTarea";
            this.BtNuevaTarea.Size = new System.Drawing.Size(203, 44);
            this.BtNuevaTarea.TabIndex = 3;
            this.BtNuevaTarea.Text = "Nueva Tarea";
            this.BtNuevaTarea.UseVisualStyleBackColor = false;
            this.BtNuevaTarea.Click += new System.EventHandler(this.BtNuevaTarea_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtListTareas
            // 
            this.BtListTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtListTareas.Location = new System.Drawing.Point(0, 150);
            this.BtListTareas.Name = "BtListTareas";
            this.BtListTareas.Size = new System.Drawing.Size(203, 44);
            this.BtListTareas.TabIndex = 1;
            this.BtListTareas.Text = "Tareas";
            this.BtListTareas.UseVisualStyleBackColor = true;
            this.BtListTareas.Click += new System.EventHandler(this.BtListTareas_Click);
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.t.Location = new System.Drawing.Point(59, 9);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(87, 26);
            this.t.TabIndex = 0;
            this.t.Text = "Usuario";
            this.t.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idUsuario
            // 
            this.idUsuario.AutoSize = true;
            this.idUsuario.Location = new System.Drawing.Point(225, 422);
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.Size = new System.Drawing.Size(0, 16);
            this.idUsuario.TabIndex = 3;
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idUsuario);
            this.Controls.Add(this.panel1);
            this.Name = "UserDashboard";
            this.Text = "UserDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtNuevaTarea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtListTareas;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Button BtListPendientes;
        private System.Windows.Forms.Button BtListaCompletadas;
        private System.Windows.Forms.Button BtTareasAtrasadas;
        public System.Windows.Forms.Label idUsuario;
    }
}
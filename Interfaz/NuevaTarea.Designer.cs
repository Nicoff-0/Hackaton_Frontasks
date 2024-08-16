namespace Hackaton_Frontasks.Interfaz
{
    partial class NuevaTarea
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.CbPrioridad = new System.Windows.Forms.ComboBox();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TbTitulo = new System.Windows.Forms.TextBox();
            this.TbDescripcion = new System.Windows.Forms.TextBox();
            this.DtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.BtAceptar = new System.Windows.Forms.Button();
            this.BtSubtarea = new System.Windows.Forms.Button();
            this.IdUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha fin";
            // 
            // CbPrioridad
            // 
            this.CbPrioridad.FormattingEnabled = true;
            this.CbPrioridad.Items.AddRange(new object[] {
            "Alta",
            "Media",
            "Baja"});
            this.CbPrioridad.Location = new System.Drawing.Point(193, 195);
            this.CbPrioridad.Name = "CbPrioridad";
            this.CbPrioridad.Size = new System.Drawing.Size(121, 24);
            this.CbPrioridad.TabIndex = 3;
            // 
            // CbEstado
            // 
            this.CbEstado.FormattingEnabled = true;
            this.CbEstado.Items.AddRange(new object[] {
            "Completado",
            "No completado",
            "Atrasado"});
            this.CbEstado.Location = new System.Drawing.Point(193, 237);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(121, 24);
            this.CbEstado.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prioridad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Estado";
            // 
            // TbTitulo
            // 
            this.TbTitulo.Location = new System.Drawing.Point(193, 73);
            this.TbTitulo.Name = "TbTitulo";
            this.TbTitulo.Size = new System.Drawing.Size(100, 22);
            this.TbTitulo.TabIndex = 7;
            // 
            // TbDescripcion
            // 
            this.TbDescripcion.Location = new System.Drawing.Point(193, 113);
            this.TbDescripcion.Name = "TbDescripcion";
            this.TbDescripcion.Size = new System.Drawing.Size(100, 22);
            this.TbDescripcion.TabIndex = 8;
            // 
            // DtpFechaFin
            // 
            this.DtpFechaFin.Location = new System.Drawing.Point(527, 84);
            this.DtpFechaFin.Name = "DtpFechaFin";
            this.DtpFechaFin.Size = new System.Drawing.Size(200, 22);
            this.DtpFechaFin.TabIndex = 9;
            // 
            // BtAceptar
            // 
            this.BtAceptar.Location = new System.Drawing.Point(68, 404);
            this.BtAceptar.Name = "BtAceptar";
            this.BtAceptar.Size = new System.Drawing.Size(104, 23);
            this.BtAceptar.TabIndex = 10;
            this.BtAceptar.Text = "Crear tarea";
            this.BtAceptar.UseVisualStyleBackColor = true;
            this.BtAceptar.Click += new System.EventHandler(this.BtAceptar_Click);
            // 
            // BtSubtarea
            // 
            this.BtSubtarea.Location = new System.Drawing.Point(268, 404);
            this.BtSubtarea.Name = "BtSubtarea";
            this.BtSubtarea.Size = new System.Drawing.Size(75, 23);
            this.BtSubtarea.TabIndex = 11;
            this.BtSubtarea.Text = "Subtareas";
            this.BtSubtarea.UseVisualStyleBackColor = true;
            // 
            // IdUsuario
            // 
            this.IdUsuario.AutoSize = true;
            this.IdUsuario.Location = new System.Drawing.Point(661, 469);
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.Size = new System.Drawing.Size(0, 16);
            this.IdUsuario.TabIndex = 12;
            // 
            // NuevaTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 509);
            this.Controls.Add(this.IdUsuario);
            this.Controls.Add(this.BtSubtarea);
            this.Controls.Add(this.BtAceptar);
            this.Controls.Add(this.DtpFechaFin);
            this.Controls.Add(this.TbDescripcion);
            this.Controls.Add(this.TbTitulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbEstado);
            this.Controls.Add(this.CbPrioridad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NuevaTarea";
            this.Text = "NuevaTarea";
            this.Load += new System.EventHandler(this.NuevaTarea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbPrioridad;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbTitulo;
        private System.Windows.Forms.TextBox TbDescripcion;
        private System.Windows.Forms.DateTimePicker DtpFechaFin;
        private System.Windows.Forms.Button BtAceptar;
        private System.Windows.Forms.Button BtSubtarea;
        public System.Windows.Forms.Label IdUsuario;
    }
}
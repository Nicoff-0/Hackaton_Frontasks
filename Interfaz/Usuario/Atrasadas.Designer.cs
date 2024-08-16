namespace Hackaton_Frontasks.Interfaz.Usuario
{
    partial class Atrasadas
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
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ultima_Modificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsusario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTareas
            // 
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Estado,
            this.Fecha_Fin,
            this.Prioridad,
            this.Ultima_Modificacion});
            this.dgvTareas.Location = new System.Drawing.Point(45, 64);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.RowHeadersWidth = 51;
            this.dgvTareas.RowTemplate.Height = 24;
            this.dgvTareas.Size = new System.Drawing.Size(680, 165);
            this.dgvTareas.TabIndex = 6;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // Fecha_Fin
            // 
            this.Fecha_Fin.HeaderText = "Fecha_fin";
            this.Fecha_Fin.MinimumWidth = 6;
            this.Fecha_Fin.Name = "Fecha_Fin";
            this.Fecha_Fin.Width = 125;
            // 
            // Prioridad
            // 
            this.Prioridad.HeaderText = "Prioridad";
            this.Prioridad.MinimumWidth = 6;
            this.Prioridad.Name = "Prioridad";
            this.Prioridad.Width = 125;
            // 
            // Ultima_Modificacion
            // 
            this.Ultima_Modificacion.HeaderText = "FechaModificacion";
            this.Ultima_Modificacion.MinimumWidth = 6;
            this.Ultima_Modificacion.Name = "Ultima_Modificacion";
            this.Ultima_Modificacion.Width = 125;
            // 
            // IdUsusario
            // 
            this.IdUsusario.AutoSize = true;
            this.IdUsusario.Location = new System.Drawing.Point(281, 343);
            this.IdUsusario.Name = "IdUsusario";
            this.IdUsusario.Size = new System.Drawing.Size(0, 16);
            this.IdUsusario.TabIndex = 7;
            // 
            // Atrasadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IdUsusario);
            this.Controls.Add(this.dgvTareas);
            this.Name = "Atrasadas";
            this.Text = "Atrasadas";
            this.Load += new System.EventHandler(this.Atrasadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ultima_Modificacion;
        public System.Windows.Forms.Label IdUsusario;
    }
}
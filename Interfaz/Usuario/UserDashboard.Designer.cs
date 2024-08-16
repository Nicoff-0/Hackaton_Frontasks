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
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.BtCompletar = new System.Windows.Forms.Button();
            this.IdTarea = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ultima_Modificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LDescripcion = new System.Windows.Forms.Label();
            this.TbTitulo = new System.Windows.Forms.TextBox();
            this.TbDescripcion = new System.Windows.Forms.TextBox();
            this.BtModificar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
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
            this.BtTareasAtrasadas.Click += new System.EventHandler(this.BtTareasAtrasadas_Click);
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
            this.BtListPendientes.Click += new System.EventHandler(this.BtListPendientes_Click);
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
            // dgvTareas
            // 
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Estado,
            this.Fecha_Fin,
            this.Prioridad,
            this.Ultima_Modificacion,
            this.id});
            this.dgvTareas.Location = new System.Drawing.Point(243, 34);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.RowHeadersWidth = 51;
            this.dgvTareas.RowTemplate.Height = 24;
            this.dgvTareas.Size = new System.Drawing.Size(680, 234);
            this.dgvTareas.TabIndex = 4;
            this.dgvTareas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvTareas.SelectionChanged += new System.EventHandler(this.dgvTareas_SelectionChanged);
            // 
            // BtCompletar
            // 
            this.BtCompletar.Location = new System.Drawing.Point(243, 274);
            this.BtCompletar.Name = "BtCompletar";
            this.BtCompletar.Size = new System.Drawing.Size(227, 31);
            this.BtCompletar.TabIndex = 5;
            this.BtCompletar.Text = "Marcar como completado";
            this.BtCompletar.UseVisualStyleBackColor = true;
            this.BtCompletar.Click += new System.EventHandler(this.BtCompletar_Click);
            // 
            // IdTarea
            // 
            this.IdTarea.AutoSize = true;
            this.IdTarea.Location = new System.Drawing.Point(625, 382);
            this.IdTarea.Name = "IdTarea";
            this.IdTarea.Size = new System.Drawing.Size(0, 16);
            this.IdTarea.TabIndex = 6;
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
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // BtEliminar
            // 
            this.BtEliminar.Location = new System.Drawing.Point(490, 274);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(154, 31);
            this.BtEliminar.TabIndex = 7;
            this.BtEliminar.Text = "Eliminar tarea";
            this.BtEliminar.UseVisualStyleBackColor = true;
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Location = new System.Drawing.Point(243, 327);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(40, 16);
            this.LTitulo.TabIndex = 8;
            this.LTitulo.Text = "Titulo";
            // 
            // LDescripcion
            // 
            this.LDescripcion.AutoSize = true;
            this.LDescripcion.Location = new System.Drawing.Point(246, 358);
            this.LDescripcion.Name = "LDescripcion";
            this.LDescripcion.Size = new System.Drawing.Size(79, 16);
            this.LDescripcion.TabIndex = 9;
            this.LDescripcion.Text = "Descripcion";
            // 
            // TbTitulo
            // 
            this.TbTitulo.Location = new System.Drawing.Point(357, 321);
            this.TbTitulo.Name = "TbTitulo";
            this.TbTitulo.Size = new System.Drawing.Size(100, 22);
            this.TbTitulo.TabIndex = 10;
            // 
            // TbDescripcion
            // 
            this.TbDescripcion.Location = new System.Drawing.Point(357, 351);
            this.TbDescripcion.Name = "TbDescripcion";
            this.TbDescripcion.Size = new System.Drawing.Size(100, 22);
            this.TbDescripcion.TabIndex = 11;
            // 
            // BtModificar
            // 
            this.BtModificar.Location = new System.Drawing.Point(357, 382);
            this.BtModificar.Name = "BtModificar";
            this.BtModificar.Size = new System.Drawing.Size(75, 23);
            this.BtModificar.TabIndex = 12;
            this.BtModificar.Text = "Modificar";
            this.BtModificar.UseVisualStyleBackColor = true;
            this.BtModificar.Click += new System.EventHandler(this.BtModificar_Click);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 450);
            this.Controls.Add(this.BtModificar);
            this.Controls.Add(this.TbDescripcion);
            this.Controls.Add(this.TbTitulo);
            this.Controls.Add(this.LDescripcion);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.BtEliminar);
            this.Controls.Add(this.IdTarea);
            this.Controls.Add(this.BtCompletar);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.idUsuario);
            this.Controls.Add(this.panel1);
            this.Name = "UserDashboard";
            this.Text = "UserDashboard";
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.Button BtCompletar;
        private System.Windows.Forms.Label IdTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ultima_Modificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LDescripcion;
        private System.Windows.Forms.TextBox TbTitulo;
        private System.Windows.Forms.TextBox TbDescripcion;
        private System.Windows.Forms.Button BtModificar;
    }
}
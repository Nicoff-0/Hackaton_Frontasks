namespace Hackaton_Frontasks.Interfaz.Usuario
{
    partial class HistoryTask
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
            this.BtTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtTitle
            // 
            this.BtTitle.AutoSize = true;
            this.BtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BtTitle.Location = new System.Drawing.Point(12, 9);
            this.BtTitle.Name = "BtTitle";
            this.BtTitle.Size = new System.Drawing.Size(253, 36);
            this.BtTitle.TabIndex = 1;
            this.BtTitle.Text = "Historial de tareas";
            // 
            // HistoryTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 528);
            this.Controls.Add(this.BtTitle);
            this.Name = "HistoryTask";
            this.Text = "HistoryTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BtTitle;
    }
}
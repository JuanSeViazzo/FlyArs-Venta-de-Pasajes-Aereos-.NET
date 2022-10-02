namespace Vista
{
    partial class FrmMostrarHorasDeVueloPorAvion
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
            this.dtgAvionesPorHora = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAvionesPorHora)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgAvionesPorHora
            // 
            this.dtgAvionesPorHora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAvionesPorHora.Location = new System.Drawing.Point(12, 262);
            this.dtgAvionesPorHora.Name = "dtgAvionesPorHora";
            this.dtgAvionesPorHora.ReadOnly = true;
            this.dtgAvionesPorHora.RowTemplate.Height = 25;
            this.dtgAvionesPorHora.Size = new System.Drawing.Size(880, 238);
            this.dtgAvionesPorHora.TabIndex = 0;
            // 
            // FrmMostrarEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 512);
            this.Controls.Add(this.dtgAvionesPorHora);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMostrarEstadistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horas de Vuelo por Avion";
            this.Load += new System.EventHandler(this.FrmMostrarEstadistica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAvionesPorHora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgAvionesPorHora;
    }
}
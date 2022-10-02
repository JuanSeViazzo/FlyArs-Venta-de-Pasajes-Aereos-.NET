namespace Vista
{
    partial class FrmDestinoPorFacturacion
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
            this.dgvDestinosPorFacturacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinosPorFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDestinosPorFacturacion
            // 
            this.dgvDestinosPorFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestinosPorFacturacion.Location = new System.Drawing.Point(12, 250);
            this.dgvDestinosPorFacturacion.Name = "dgvDestinosPorFacturacion";
            this.dgvDestinosPorFacturacion.RowTemplate.Height = 25;
            this.dgvDestinosPorFacturacion.Size = new System.Drawing.Size(1007, 255);
            this.dgvDestinosPorFacturacion.TabIndex = 0;
            // 
            // FrmDestinoPorFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 517);
            this.Controls.Add(this.dgvDestinosPorFacturacion);
            this.Name = "FrmDestinoPorFacturacion";
            this.Text = "DestinoPorFacturacion";
            this.Load += new System.EventHandler(this.FrmDestinoPorFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinosPorFacturacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDestinosPorFacturacion;
    }
}
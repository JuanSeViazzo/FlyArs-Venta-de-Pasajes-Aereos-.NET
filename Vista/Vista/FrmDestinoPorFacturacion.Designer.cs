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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDestinoPorFacturacion));
            this.dgvDestinosPorFacturacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinosPorFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDestinosPorFacturacion
            // 
            this.dgvDestinosPorFacturacion.BackgroundColor = System.Drawing.Color.White;
            this.dgvDestinosPorFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestinosPorFacturacion.Location = new System.Drawing.Point(11, 159);
            this.dgvDestinosPorFacturacion.Name = "dgvDestinosPorFacturacion";
            this.dgvDestinosPorFacturacion.ReadOnly = true;
            this.dgvDestinosPorFacturacion.RowTemplate.Height = 25;
            this.dgvDestinosPorFacturacion.Size = new System.Drawing.Size(978, 232);
            this.dgvDestinosPorFacturacion.TabIndex = 0;
            // 
            // FrmDestinoPorFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1001, 517);
            this.Controls.Add(this.dgvDestinosPorFacturacion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDestinoPorFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Facturacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDestinoPorFacturacion_FormClosing);
            this.Load += new System.EventHandler(this.FrmDestinoPorFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinosPorFacturacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDestinosPorFacturacion;
    }
}
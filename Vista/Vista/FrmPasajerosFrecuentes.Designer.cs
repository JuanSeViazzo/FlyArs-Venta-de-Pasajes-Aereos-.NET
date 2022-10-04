namespace Vista
{
    partial class FrmPasajerosFrecuentes
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
            this.dgvDestinosPorFacturacion.BackgroundColor = System.Drawing.Color.White;
            this.dgvDestinosPorFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestinosPorFacturacion.GridColor = System.Drawing.Color.Black;
            this.dgvDestinosPorFacturacion.Location = new System.Drawing.Point(30, 183);
            this.dgvDestinosPorFacturacion.Name = "dgvDestinosPorFacturacion";
            this.dgvDestinosPorFacturacion.ReadOnly = true;
            this.dgvDestinosPorFacturacion.RowTemplate.Height = 25;
            this.dgvDestinosPorFacturacion.Size = new System.Drawing.Size(1007, 255);
            this.dgvDestinosPorFacturacion.TabIndex = 1;
            // 
            // FrmPasajerosFrecuentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.logo_menu_ventas;
            this.ClientSize = new System.Drawing.Size(1116, 450);
            this.Controls.Add(this.dgvDestinosPorFacturacion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPasajerosFrecuentes";
            this.Text = "Pasajeros Frecuentes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPasajerosFrecuentes_FormClosing);
            this.Load += new System.EventHandler(this.FrmPasajerosFrecuentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinosPorFacturacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDestinosPorFacturacion;
    }
}
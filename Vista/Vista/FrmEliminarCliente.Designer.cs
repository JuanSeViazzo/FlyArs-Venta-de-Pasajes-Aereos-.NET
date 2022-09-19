namespace Vista
{
    partial class FrmEliminarCliente
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
            this.rtbPasajeroAEliminar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbPasajeroAEliminar
            // 
            this.rtbPasajeroAEliminar.Location = new System.Drawing.Point(248, 41);
            this.rtbPasajeroAEliminar.Name = "rtbPasajeroAEliminar";
            this.rtbPasajeroAEliminar.Size = new System.Drawing.Size(305, 369);
            this.rtbPasajeroAEliminar.TabIndex = 1;
            this.rtbPasajeroAEliminar.Text = "";
            // 
            // FrmEliminarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 487);
            this.Controls.Add(this.rtbPasajeroAEliminar);
            this.Name = "FrmEliminarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEliminarCliente";
            this.Load += new System.EventHandler(this.FrmEliminarCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbPasajeroAEliminar;
    }
}
namespace Vista
{
    partial class FrmModificarPasajero
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
            this.rtb_PasajeroAModificar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtb_PasajeroAModificar
            // 
            this.rtb_PasajeroAModificar.Location = new System.Drawing.Point(446, 27);
            this.rtb_PasajeroAModificar.Name = "rtb_PasajeroAModificar";
            this.rtb_PasajeroAModificar.Size = new System.Drawing.Size(305, 369);
            this.rtb_PasajeroAModificar.TabIndex = 0;
            this.rtb_PasajeroAModificar.Text = "";
            // 
            // ModificarPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtb_PasajeroAModificar);
            this.Name = "ModificarPasajero";
            this.Text = "ModificarPasajero";
            this.Load += new System.EventHandler(this.ModificarPasajero_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_PasajeroAModificar;
    }
}
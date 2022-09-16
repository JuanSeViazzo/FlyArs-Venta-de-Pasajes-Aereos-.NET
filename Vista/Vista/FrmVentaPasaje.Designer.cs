namespace Vista
{
    partial class FrmVentaPasaje
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
            this.btn_VenderPasaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_VenderPasaje
            // 
            this.btn_VenderPasaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_VenderPasaje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VenderPasaje.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_VenderPasaje.Location = new System.Drawing.Point(12, 62);
            this.btn_VenderPasaje.Name = "btn_VenderPasaje";
            this.btn_VenderPasaje.Size = new System.Drawing.Size(132, 61);
            this.btn_VenderPasaje.TabIndex = 5;
            this.btn_VenderPasaje.Text = "Cargar Cliente";
            this.btn_VenderPasaje.UseVisualStyleBackColor = true;
            this.btn_VenderPasaje.Click += new System.EventHandler(this.btn_VenderPasaje_Click);
            // 
            // FrmVentaPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 584);
            this.Controls.Add(this.btn_VenderPasaje);
            this.Name = "FrmVentaPasaje";
            this.Text = "FrmVentaPasaje";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_VenderPasaje;
    }
}
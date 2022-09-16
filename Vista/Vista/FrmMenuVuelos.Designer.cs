namespace Vista
{
    partial class FrmMenuVuelos
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_CrearVuelo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(12, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 61);
            this.button2.TabIndex = 10;
            this.button2.Text = "Anular \r\nVuelo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_AceptarPasajero
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 113);
            this.button1.Name = "btn_AceptarPasajero";
            this.button1.Size = new System.Drawing.Size(132, 61);
            this.button1.TabIndex = 9;
            this.button1.Text = "Modificar Vuelo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_CrearVuelo
            // 
            this.btn_CrearVuelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CrearVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CrearVuelo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CrearVuelo.Location = new System.Drawing.Point(12, 34);
            this.btn_CrearVuelo.Name = "btn_CrearVuelo";
            this.btn_CrearVuelo.Size = new System.Drawing.Size(132, 61);
            this.btn_CrearVuelo.TabIndex = 8;
            this.btn_CrearVuelo.Text = "Crear \r\nVuelo";
            this.btn_CrearVuelo.UseVisualStyleBackColor = true;
            // 
            // FrmMenuVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_CrearVuelo);
            this.Name = "FrmMenuVuelos";
            this.Text = "FrmMenuVuelos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_CrearVuelo;
    }
}
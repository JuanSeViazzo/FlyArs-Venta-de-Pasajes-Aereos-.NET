namespace Vista
{
    partial class FrmVenderPasaje
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
            this.btnTraerCliente = new System.Windows.Forms.Button();
            this.rtbCliente = new System.Windows.Forms.RichTextBox();
            this.btnElegirVuelo = new System.Windows.Forms.Button();
            this.rtbVuelo = new System.Windows.Forms.RichTextBox();
            this.btnCrearPasajero = new System.Windows.Forms.Button();
            this.rtbPasajero = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnTraerCliente
            // 
            this.btnTraerCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraerCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTraerCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTraerCliente.Location = new System.Drawing.Point(91, 89);
            this.btnTraerCliente.Name = "btnTraerCliente";
            this.btnTraerCliente.Size = new System.Drawing.Size(132, 61);
            this.btnTraerCliente.TabIndex = 6;
            this.btnTraerCliente.Text = "Buscar Cliente";
            this.btnTraerCliente.UseVisualStyleBackColor = true;
            this.btnTraerCliente.Click += new System.EventHandler(this.btnTraerCliente_Click);
            // 
            // rtbCliente
            // 
            this.rtbCliente.Location = new System.Drawing.Point(12, 156);
            this.rtbCliente.Name = "rtbCliente";
            this.rtbCliente.Size = new System.Drawing.Size(302, 261);
            this.rtbCliente.TabIndex = 17;
            this.rtbCliente.Text = "";
            // 
            // btnElegirVuelo
            // 
            this.btnElegirVuelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElegirVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElegirVuelo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnElegirVuelo.Location = new System.Drawing.Point(412, 89);
            this.btnElegirVuelo.Name = "btnElegirVuelo";
            this.btnElegirVuelo.Size = new System.Drawing.Size(132, 61);
            this.btnElegirVuelo.TabIndex = 18;
            this.btnElegirVuelo.Text = "Buscar Vuelo";
            this.btnElegirVuelo.UseVisualStyleBackColor = true;
            this.btnElegirVuelo.Click += new System.EventHandler(this.btnElegirVuelo_Click);
            // 
            // rtbVuelo
            // 
            this.rtbVuelo.Location = new System.Drawing.Point(320, 156);
            this.rtbVuelo.Name = "rtbVuelo";
            this.rtbVuelo.Size = new System.Drawing.Size(302, 261);
            this.rtbVuelo.TabIndex = 19;
            this.rtbVuelo.Text = "";
            // 
            // btnCrearPasajero
            // 
            this.btnCrearPasajero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearPasajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearPasajero.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCrearPasajero.Location = new System.Drawing.Point(698, 89);
            this.btnCrearPasajero.Name = "btnCrearPasajero";
            this.btnCrearPasajero.Size = new System.Drawing.Size(132, 61);
            this.btnCrearPasajero.TabIndex = 20;
            this.btnCrearPasajero.Text = "Cargar Pasajero";
            this.btnCrearPasajero.UseVisualStyleBackColor = true;
            this.btnCrearPasajero.Click += new System.EventHandler(this.btnCrearPasajero_Click);
            // 
            // rtbPasajero
            // 
            this.rtbPasajero.Location = new System.Drawing.Point(628, 156);
            this.rtbPasajero.Name = "rtbPasajero";
            this.rtbPasajero.Size = new System.Drawing.Size(302, 261);
            this.rtbPasajero.TabIndex = 21;
            this.rtbPasajero.Text = "";
            // 
            // FrmVenderPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 649);
            this.Controls.Add(this.rtbPasajero);
            this.Controls.Add(this.btnCrearPasajero);
            this.Controls.Add(this.rtbVuelo);
            this.Controls.Add(this.btnElegirVuelo);
            this.Controls.Add(this.rtbCliente);
            this.Controls.Add(this.btnTraerCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVenderPasaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVentaPasaje";
            this.Load += new System.EventHandler(this.FrmVentaPasaje_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTraerCliente;
        private System.Windows.Forms.RichTextBox rtbCliente;
        private System.Windows.Forms.Button btnElegirVuelo;
        private System.Windows.Forms.RichTextBox rtbVuelo;
        private System.Windows.Forms.Button btnCrearPasajero;
        private System.Windows.Forms.RichTextBox rtbPasajero;
    }
}
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
            this.btnTraerCliente = new System.Windows.Forms.Button();
            this.rtbPasajero = new System.Windows.Forms.RichTextBox();
            this.btnElegirVuelo = new System.Windows.Forms.Button();
            this.rtbVuelo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_VenderPasaje
            // 
            this.btn_VenderPasaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_VenderPasaje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VenderPasaje.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_VenderPasaje.Location = new System.Drawing.Point(22, 59);
            this.btn_VenderPasaje.Name = "btn_VenderPasaje";
            this.btn_VenderPasaje.Size = new System.Drawing.Size(132, 61);
            this.btn_VenderPasaje.TabIndex = 5;
            this.btn_VenderPasaje.Text = "Cargar Cliente";
            this.btn_VenderPasaje.UseVisualStyleBackColor = true;
            this.btn_VenderPasaje.Click += new System.EventHandler(this.btn_VenderPasaje_Click);
            // 
            // btnTraerCliente
            // 
            this.btnTraerCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraerCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTraerCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTraerCliente.Location = new System.Drawing.Point(214, 59);
            this.btnTraerCliente.Name = "btnTraerCliente";
            this.btnTraerCliente.Size = new System.Drawing.Size(132, 61);
            this.btnTraerCliente.TabIndex = 6;
            this.btnTraerCliente.Text = "Elegir Cliente";
            this.btnTraerCliente.UseVisualStyleBackColor = true;
            this.btnTraerCliente.Click += new System.EventHandler(this.btnTraerCliente_Click);
            // 
            // rtbPasajero
            // 
            this.rtbPasajero.Location = new System.Drawing.Point(214, 156);
            this.rtbPasajero.Name = "rtbPasajero";
            this.rtbPasajero.Size = new System.Drawing.Size(302, 261);
            this.rtbPasajero.TabIndex = 17;
            this.rtbPasajero.Text = "";
            // 
            // btnElegirVuelo
            // 
            this.btnElegirVuelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElegirVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElegirVuelo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnElegirVuelo.Location = new System.Drawing.Point(22, 170);
            this.btnElegirVuelo.Name = "btnElegirVuelo";
            this.btnElegirVuelo.Size = new System.Drawing.Size(132, 61);
            this.btnElegirVuelo.TabIndex = 18;
            this.btnElegirVuelo.Text = "Buscar";
            this.btnElegirVuelo.UseVisualStyleBackColor = true;
            this.btnElegirVuelo.Click += new System.EventHandler(this.btnElegirVuelo_Click);
            // 
            // rtbVuelo
            // 
            this.rtbVuelo.Location = new System.Drawing.Point(569, 156);
            this.rtbVuelo.Name = "rtbVuelo";
            this.rtbVuelo.Size = new System.Drawing.Size(302, 261);
            this.rtbVuelo.TabIndex = 19;
            this.rtbVuelo.Text = "";
            // 
            // FrmVentaPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 584);
            this.Controls.Add(this.rtbVuelo);
            this.Controls.Add(this.btnElegirVuelo);
            this.Controls.Add(this.rtbPasajero);
            this.Controls.Add(this.btnTraerCliente);
            this.Controls.Add(this.btn_VenderPasaje);
            this.Name = "FrmVentaPasaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVentaPasaje";
            this.Load += new System.EventHandler(this.FrmVentaPasaje_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_VenderPasaje;
        private System.Windows.Forms.Button btnTraerCliente;
        private System.Windows.Forms.RichTextBox rtbPasajero;
        private System.Windows.Forms.Button btnElegirVuelo;
        private System.Windows.Forms.RichTextBox rtbVuelo;
    }
}
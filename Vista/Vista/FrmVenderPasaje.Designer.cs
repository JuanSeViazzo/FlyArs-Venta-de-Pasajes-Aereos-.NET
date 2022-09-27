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
            this.btnElegirVuelo = new System.Windows.Forms.Button();
            this.rtbVuelo = new System.Windows.Forms.RichTextBox();
            this.btnCargarPasajero = new System.Windows.Forms.Button();
            this.rtbPasajero = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rtbEquipaje = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnElegirVuelo
            // 
            this.btnElegirVuelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElegirVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElegirVuelo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnElegirVuelo.Location = new System.Drawing.Point(12, 108);
            this.btnElegirVuelo.Name = "btnElegirVuelo";
            this.btnElegirVuelo.Size = new System.Drawing.Size(302, 42);
            this.btnElegirVuelo.TabIndex = 18;
            this.btnElegirVuelo.Text = "Buscar Vuelo";
            this.btnElegirVuelo.UseVisualStyleBackColor = true;
            this.btnElegirVuelo.Click += new System.EventHandler(this.btnElegirVuelo_Click);
            // 
            // rtbVuelo
            // 
            this.rtbVuelo.Location = new System.Drawing.Point(12, 156);
            this.rtbVuelo.Name = "rtbVuelo";
            this.rtbVuelo.Size = new System.Drawing.Size(302, 261);
            this.rtbVuelo.TabIndex = 19;
            this.rtbVuelo.Text = "";
            // 
            // btnCargarPasajero
            // 
            this.btnCargarPasajero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarPasajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarPasajero.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCargarPasajero.Location = new System.Drawing.Point(320, 108);
            this.btnCargarPasajero.Name = "btnCargarPasajero";
            this.btnCargarPasajero.Size = new System.Drawing.Size(302, 42);
            this.btnCargarPasajero.TabIndex = 20;
            this.btnCargarPasajero.Text = "Cargar Pasajero";
            this.btnCargarPasajero.UseVisualStyleBackColor = true;
            this.btnCargarPasajero.Click += new System.EventHandler(this.btnCargarPasajero_Click);
            // 
            // rtbPasajero
            // 
            this.rtbPasajero.Location = new System.Drawing.Point(320, 156);
            this.rtbPasajero.Name = "rtbPasajero";
            this.rtbPasajero.Size = new System.Drawing.Size(302, 261);
            this.rtbPasajero.TabIndex = 21;
            this.rtbPasajero.Text = "";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(628, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 42);
            this.button1.TabIndex = 22;
            this.button1.Text = "Cargar Equipaje";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rtbEquipaje
            // 
            this.rtbEquipaje.Location = new System.Drawing.Point(628, 156);
            this.rtbEquipaje.Name = "rtbEquipaje";
            this.rtbEquipaje.Size = new System.Drawing.Size(302, 261);
            this.rtbEquipaje.TabIndex = 23;
            this.rtbEquipaje.Text = "";
            // 
            // FrmVenderPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 649);
            this.Controls.Add(this.rtbEquipaje);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbPasajero);
            this.Controls.Add(this.btnCargarPasajero);
            this.Controls.Add(this.rtbVuelo);
            this.Controls.Add(this.btnElegirVuelo);
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
        private System.Windows.Forms.Button btnElegirVuelo;
        private System.Windows.Forms.RichTextBox rtbVuelo;
        private System.Windows.Forms.Button btnCargarPasajero;
        private System.Windows.Forms.RichTextBox rtbPasajero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtbEquipaje;
    }
}
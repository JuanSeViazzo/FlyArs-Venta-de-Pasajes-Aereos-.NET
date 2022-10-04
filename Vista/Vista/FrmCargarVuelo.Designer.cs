namespace Vista
{
    partial class FrmCargarVuelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargarVuelo));
            this.cmbAvion = new System.Windows.Forms.ComboBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.mncFechaDePartida = new System.Windows.Forms.MonthCalendar();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptarCargaVuelo = new System.Windows.Forms.Button();
            this.chkWifi = new System.Windows.Forms.CheckBox();
            this.chkComida = new System.Windows.Forms.CheckBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.rtbVuelo = new System.Windows.Forms.RichTextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbAvion
            // 
            this.cmbAvion.FormattingEnabled = true;
            this.cmbAvion.Location = new System.Drawing.Point(12, 54);
            this.cmbAvion.Name = "cmbAvion";
            this.cmbAvion.Size = new System.Drawing.Size(248, 23);
            this.cmbAvion.TabIndex = 0;
            this.cmbAvion.Text = "Avion";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(285, 54);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(121, 23);
            this.cmbOrigen.TabIndex = 1;
            this.cmbOrigen.Text = "Origen";
            this.cmbOrigen.SelectionChangeCommitted += new System.EventHandler(this.cmbOrigen_SelectionChangeCommitted);
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(285, 84);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(121, 23);
            this.cmbDestino.TabIndex = 2;
            this.cmbDestino.Text = "Destino";
            // 
            // mncFechaDePartida
            // 
            this.mncFechaDePartida.Location = new System.Drawing.Point(12, 103);
            this.mncFechaDePartida.Name = "mncFechaDePartida";
            this.mncFechaDePartida.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(12, 518);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 38);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptarCargaVuelo
            // 
            this.btnAceptarCargaVuelo.BackColor = System.Drawing.Color.White;
            this.btnAceptarCargaVuelo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptarCargaVuelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAceptarCargaVuelo.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptarCargaVuelo.Image")));
            this.btnAceptarCargaVuelo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptarCargaVuelo.Location = new System.Drawing.Point(285, 518);
            this.btnAceptarCargaVuelo.Name = "btnAceptarCargaVuelo";
            this.btnAceptarCargaVuelo.Size = new System.Drawing.Size(113, 38);
            this.btnAceptarCargaVuelo.TabIndex = 29;
            this.btnAceptarCargaVuelo.Text = "Aceptar";
            this.btnAceptarCargaVuelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptarCargaVuelo.UseVisualStyleBackColor = false;
            this.btnAceptarCargaVuelo.Click += new System.EventHandler(this.btnAceptarCargaVuelo_Click);
            // 
            // chkWifi
            // 
            this.chkWifi.AutoSize = true;
            this.chkWifi.Location = new System.Drawing.Point(285, 113);
            this.chkWifi.Name = "chkWifi";
            this.chkWifi.Size = new System.Drawing.Size(47, 19);
            this.chkWifi.TabIndex = 31;
            this.chkWifi.Text = "Wifi";
            this.chkWifi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkWifi.UseVisualStyleBackColor = true;
            // 
            // chkComida
            // 
            this.chkComida.AutoSize = true;
            this.chkComida.Location = new System.Drawing.Point(285, 138);
            this.chkComida.Name = "chkComida";
            this.chkComida.Size = new System.Drawing.Size(68, 19);
            this.chkComida.TabIndex = 32;
            this.chkComida.Text = "Comida";
            this.chkComida.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.White;
            this.btnCargar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCargar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCargar.Image = ((System.Drawing.Image)(resources.GetObject("btnCargar.Image")));
            this.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargar.Location = new System.Drawing.Point(285, 227);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(113, 38);
            this.btnCargar.TabIndex = 33;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // rtbVuelo
            // 
            this.rtbVuelo.BackColor = System.Drawing.Color.White;
            this.rtbVuelo.Location = new System.Drawing.Point(12, 319);
            this.rtbVuelo.Name = "rtbVuelo";
            this.rtbVuelo.ReadOnly = true;
            this.rtbVuelo.Size = new System.Drawing.Size(394, 182);
            this.rtbVuelo.TabIndex = 34;
            this.rtbVuelo.Text = "";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(272, 189);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 14);
            this.lblError.TabIndex = 35;
            // 
            // FrmCargarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(416, 579);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.rtbVuelo);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.chkComida);
            this.Controls.Add(this.chkWifi);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptarCargaVuelo);
            this.Controls.Add(this.mncFechaDePartida);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.cmbOrigen);
            this.Controls.Add(this.cmbAvion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCargarVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Vuelo";
            this.Load += new System.EventHandler(this.FrmCargarVuelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAvion;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.MonthCalendar mncFechaDePartida;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptarCargaVuelo;
        private System.Windows.Forms.CheckBox chkWifi;
        private System.Windows.Forms.CheckBox chkComida;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.RichTextBox rtbVuelo;
        private System.Windows.Forms.Label lblError;
    }
}
namespace Vista
{
    partial class frmCargarPasajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargarPasajero));
            this.rtbCliente = new System.Windows.Forms.RichTextBox();
            this.btnTraerCliente = new System.Windows.Forms.Button();
            this.btnCancelarModificacion = new System.Windows.Forms.Button();
            this.btnAceptarCargaDePasajero = new System.Windows.Forms.Button();
            this.btnCargarPasajero = new System.Windows.Forms.Button();
            this.rdbPremium = new System.Windows.Forms.RadioButton();
            this.rdbTurista = new System.Windows.Forms.RadioButton();
            this.rtbPasajero = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbCliente
            // 
            this.rtbCliente.BackColor = System.Drawing.Color.White;
            this.rtbCliente.Location = new System.Drawing.Point(12, 194);
            this.rtbCliente.Name = "rtbCliente";
            this.rtbCliente.ReadOnly = true;
            this.rtbCliente.Size = new System.Drawing.Size(277, 193);
            this.rtbCliente.TabIndex = 19;
            this.rtbCliente.Text = "";
            // 
            // btnTraerCliente
            // 
            this.btnTraerCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraerCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTraerCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTraerCliente.Location = new System.Drawing.Point(12, 393);
            this.btnTraerCliente.Name = "btnTraerCliente";
            this.btnTraerCliente.Size = new System.Drawing.Size(277, 39);
            this.btnTraerCliente.TabIndex = 18;
            this.btnTraerCliente.Text = "Buscar Cliente";
            this.btnTraerCliente.UseVisualStyleBackColor = true;
            this.btnTraerCliente.Click += new System.EventHandler(this.btnTraerCliente_Click);
            // 
            // btnCancelarModificacion
            // 
            this.btnCancelarModificacion.BackColor = System.Drawing.Color.White;
            this.btnCancelarModificacion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarModificacion.ForeColor = System.Drawing.Color.Red;
            this.btnCancelarModificacion.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarModificacion.Image")));
            this.btnCancelarModificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarModificacion.Location = new System.Drawing.Point(12, 459);
            this.btnCancelarModificacion.Name = "btnCancelarModificacion";
            this.btnCancelarModificacion.Size = new System.Drawing.Size(113, 38);
            this.btnCancelarModificacion.TabIndex = 28;
            this.btnCancelarModificacion.Text = "Cancelar";
            this.btnCancelarModificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarModificacion.UseVisualStyleBackColor = false;
            // 
            // btnAceptarCargaDePasajero
            // 
            this.btnAceptarCargaDePasajero.BackColor = System.Drawing.Color.White;
            this.btnAceptarCargaDePasajero.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptarCargaDePasajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAceptarCargaDePasajero.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptarCargaDePasajero.Image")));
            this.btnAceptarCargaDePasajero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptarCargaDePasajero.Location = new System.Drawing.Point(459, 459);
            this.btnAceptarCargaDePasajero.Name = "btnAceptarCargaDePasajero";
            this.btnAceptarCargaDePasajero.Size = new System.Drawing.Size(113, 38);
            this.btnAceptarCargaDePasajero.TabIndex = 27;
            this.btnAceptarCargaDePasajero.Text = "Cargar";
            this.btnAceptarCargaDePasajero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptarCargaDePasajero.UseVisualStyleBackColor = false;
            this.btnAceptarCargaDePasajero.Click += new System.EventHandler(this.btnAceptarCargaDePasajero_Click);
            // 
            // btnCargarPasajero
            // 
            this.btnCargarPasajero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarPasajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarPasajero.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCargarPasajero.Location = new System.Drawing.Point(306, 393);
            this.btnCargarPasajero.Name = "btnCargarPasajero";
            this.btnCargarPasajero.Size = new System.Drawing.Size(277, 39);
            this.btnCargarPasajero.TabIndex = 29;
            this.btnCargarPasajero.Text = "Cargar Pasajero";
            this.btnCargarPasajero.UseVisualStyleBackColor = true;
            this.btnCargarPasajero.Click += new System.EventHandler(this.btnCargarPasajero_Click);
            // 
            // rdbPremium
            // 
            this.rdbPremium.AutoSize = true;
            this.rdbPremium.BackColor = System.Drawing.Color.Transparent;
            this.rdbPremium.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbPremium.Location = new System.Drawing.Point(12, 170);
            this.rdbPremium.Name = "rdbPremium";
            this.rdbPremium.Size = new System.Drawing.Size(124, 18);
            this.rdbPremium.TabIndex = 1;
            this.rdbPremium.TabStop = true;
            this.rdbPremium.Text = "Clase Premium";
            this.rdbPremium.UseVisualStyleBackColor = false;
            // 
            // rdbTurista
            // 
            this.rdbTurista.AutoSize = true;
            this.rdbTurista.BackColor = System.Drawing.Color.Transparent;
            this.rdbTurista.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbTurista.Location = new System.Drawing.Point(178, 170);
            this.rdbTurista.Name = "rdbTurista";
            this.rdbTurista.Size = new System.Drawing.Size(111, 18);
            this.rdbTurista.TabIndex = 0;
            this.rdbTurista.TabStop = true;
            this.rdbTurista.Text = "Clase Turista";
            this.rdbTurista.UseVisualStyleBackColor = false;
            // 
            // rtbPasajero
            // 
            this.rtbPasajero.BackColor = System.Drawing.Color.White;
            this.rtbPasajero.Location = new System.Drawing.Point(306, 194);
            this.rtbPasajero.Name = "rtbPasajero";
            this.rtbPasajero.ReadOnly = true;
            this.rtbPasajero.Size = new System.Drawing.Size(277, 193);
            this.rtbPasajero.TabIndex = 30;
            this.rtbPasajero.Text = "";
            // 
            // frmCargarPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Vista.Properties.Resources.pasajeros;
            this.ClientSize = new System.Drawing.Size(600, 509);
            this.Controls.Add(this.rtbPasajero);
            this.Controls.Add(this.rdbPremium);
            this.Controls.Add(this.rdbTurista);
            this.Controls.Add(this.btnCargarPasajero);
            this.Controls.Add(this.btnCancelarModificacion);
            this.Controls.Add(this.btnAceptarCargaDePasajero);
            this.Controls.Add(this.rtbCliente);
            this.Controls.Add(this.btnTraerCliente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCargarPasajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Pasajero";
            this.Load += new System.EventHandler(this.frmCargarPasajero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbCliente;
        private System.Windows.Forms.Button btnTraerCliente;
        private System.Windows.Forms.Button btnCancelarModificacion;
        private System.Windows.Forms.Button btnAceptarCargaDePasajero;
        private System.Windows.Forms.Button btnCargarPasajero;
        private System.Windows.Forms.RadioButton rdbPremium;
        private System.Windows.Forms.RadioButton rdbTurista;
        private System.Windows.Forms.RichTextBox rtbPasajero;
    }
}
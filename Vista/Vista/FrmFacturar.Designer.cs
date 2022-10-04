namespace Vista
{
    partial class FrmFacturar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturar));
            this.btnCancelarModificacion = new System.Windows.Forms.Button();
            this.btnAceptarModificacion = new System.Windows.Forms.Button();
            this.lblMensajeDescuento = new System.Windows.Forms.Label();
            this.btnAplicarDescuento = new System.Windows.Forms.Button();
            this.rtbPasajero = new System.Windows.Forms.RichTextBox();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.rtbFacturacion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCancelarModificacion
            // 
            this.btnCancelarModificacion.BackColor = System.Drawing.Color.White;
            this.btnCancelarModificacion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarModificacion.ForeColor = System.Drawing.Color.Red;
            this.btnCancelarModificacion.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarModificacion.Image")));
            this.btnCancelarModificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarModificacion.Location = new System.Drawing.Point(184, 401);
            this.btnCancelarModificacion.Name = "btnCancelarModificacion";
            this.btnCancelarModificacion.Size = new System.Drawing.Size(113, 38);
            this.btnCancelarModificacion.TabIndex = 53;
            this.btnCancelarModificacion.Text = "Cancelar";
            this.btnCancelarModificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarModificacion.UseVisualStyleBackColor = false;
            this.btnCancelarModificacion.Click += new System.EventHandler(this.btnCancelarModificacion_Click);
            // 
            // btnAceptarModificacion
            // 
            this.btnAceptarModificacion.BackColor = System.Drawing.Color.White;
            this.btnAceptarModificacion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptarModificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAceptarModificacion.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptarModificacion.Image")));
            this.btnAceptarModificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptarModificacion.Location = new System.Drawing.Point(329, 401);
            this.btnAceptarModificacion.Name = "btnAceptarModificacion";
            this.btnAceptarModificacion.Size = new System.Drawing.Size(113, 38);
            this.btnAceptarModificacion.TabIndex = 52;
            this.btnAceptarModificacion.Text = "Cargar";
            this.btnAceptarModificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptarModificacion.UseVisualStyleBackColor = false;
            this.btnAceptarModificacion.Click += new System.EventHandler(this.btnAceptarModificacion_Click);
            // 
            // lblMensajeDescuento
            // 
            this.lblMensajeDescuento.AutoSize = true;
            this.lblMensajeDescuento.Location = new System.Drawing.Point(297, 104);
            this.lblMensajeDescuento.Name = "lblMensajeDescuento";
            this.lblMensajeDescuento.Size = new System.Drawing.Size(0, 15);
            this.lblMensajeDescuento.TabIndex = 54;
            // 
            // btnAplicarDescuento
            // 
            this.btnAplicarDescuento.BackColor = System.Drawing.Color.White;
            this.btnAplicarDescuento.Location = new System.Drawing.Point(297, 126);
            this.btnAplicarDescuento.Name = "btnAplicarDescuento";
            this.btnAplicarDescuento.Size = new System.Drawing.Size(145, 23);
            this.btnAplicarDescuento.TabIndex = 55;
            this.btnAplicarDescuento.Text = "Aplicar Descuento";
            this.btnAplicarDescuento.UseVisualStyleBackColor = false;
            this.btnAplicarDescuento.Click += new System.EventHandler(this.btnAplicarDescuento_Click);
            // 
            // rtbPasajero
            // 
            this.rtbPasajero.BackColor = System.Drawing.Color.White;
            this.rtbPasajero.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbPasajero.ForeColor = System.Drawing.Color.Black;
            this.rtbPasajero.Location = new System.Drawing.Point(47, 78);
            this.rtbPasajero.Name = "rtbPasajero";
            this.rtbPasajero.ReadOnly = true;
            this.rtbPasajero.Size = new System.Drawing.Size(244, 249);
            this.rtbPasajero.TabIndex = 56;
            this.rtbPasajero.Text = "";
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.White;
            this.btnFacturar.Location = new System.Drawing.Point(297, 155);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(145, 23);
            this.btnFacturar.TabIndex = 57;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // rtbFacturacion
            // 
            this.rtbFacturacion.BackColor = System.Drawing.Color.White;
            this.rtbFacturacion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbFacturacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rtbFacturacion.Location = new System.Drawing.Point(297, 184);
            this.rtbFacturacion.Name = "rtbFacturacion";
            this.rtbFacturacion.ReadOnly = true;
            this.rtbFacturacion.Size = new System.Drawing.Size(145, 143);
            this.rtbFacturacion.TabIndex = 58;
            this.rtbFacturacion.Text = "";
            // 
            // FrmFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Vista.Properties.Resources.logo_menu_ventas;
            this.ClientSize = new System.Drawing.Size(471, 520);
            this.Controls.Add(this.rtbFacturacion);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.rtbPasajero);
            this.Controls.Add(this.btnAplicarDescuento);
            this.Controls.Add(this.lblMensajeDescuento);
            this.Controls.Add(this.btnCancelarModificacion);
            this.Controls.Add(this.btnAceptarModificacion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFacturar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.FrmFacturar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarModificacion;
        private System.Windows.Forms.Button btnAceptarModificacion;
        private System.Windows.Forms.Label lblMensajeDescuento;
        private System.Windows.Forms.Button btnAplicarDescuento;
        private System.Windows.Forms.RichTextBox rtbPasajero;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.RichTextBox rtbFacturacion;
    }
}
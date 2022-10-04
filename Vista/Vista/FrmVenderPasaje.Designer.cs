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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenderPasaje));
            this.btnElegirVuelo = new System.Windows.Forms.Button();
            this.rtbVuelo = new System.Windows.Forms.RichTextBox();
            this.btnCargarPasajero = new System.Windows.Forms.Button();
            this.rtbPasajero = new System.Windows.Forms.RichTextBox();
            this.btnCargarEquipaje = new System.Windows.Forms.Button();
            this.rtbEquipaje = new System.Windows.Forms.RichTextBox();
            this.btnCancelarModificacion = new System.Windows.Forms.Button();
            this.btnAceptarModificacion = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.rtbFacturacion = new System.Windows.Forms.RichTextBox();
            this.btnSubirPasajero = new System.Windows.Forms.Button();
            this.btnCargarOtroPasajero = new System.Windows.Forms.Button();
            this.dgvListaDePasajes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDePasajes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnElegirVuelo
            // 
            this.btnElegirVuelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElegirVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElegirVuelo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnElegirVuelo.Location = new System.Drawing.Point(12, 151);
            this.btnElegirVuelo.Name = "btnElegirVuelo";
            this.btnElegirVuelo.Size = new System.Drawing.Size(302, 42);
            this.btnElegirVuelo.TabIndex = 18;
            this.btnElegirVuelo.Text = "Buscar Vuelo";
            this.btnElegirVuelo.UseVisualStyleBackColor = true;
            this.btnElegirVuelo.Click += new System.EventHandler(this.btnElegirVuelo_Click);
            // 
            // rtbVuelo
            // 
            this.rtbVuelo.Location = new System.Drawing.Point(12, 199);
            this.rtbVuelo.Name = "rtbVuelo";
            this.rtbVuelo.Size = new System.Drawing.Size(302, 244);
            this.rtbVuelo.TabIndex = 19;
            this.rtbVuelo.Text = "";
            // 
            // btnCargarPasajero
            // 
            this.btnCargarPasajero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarPasajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarPasajero.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCargarPasajero.Location = new System.Drawing.Point(320, 151);
            this.btnCargarPasajero.Name = "btnCargarPasajero";
            this.btnCargarPasajero.Size = new System.Drawing.Size(302, 42);
            this.btnCargarPasajero.TabIndex = 20;
            this.btnCargarPasajero.Text = "Cargar Pasajero";
            this.btnCargarPasajero.UseVisualStyleBackColor = true;
            this.btnCargarPasajero.Click += new System.EventHandler(this.btnCargarPasajero_Click);
            // 
            // rtbPasajero
            // 
            this.rtbPasajero.Location = new System.Drawing.Point(320, 199);
            this.rtbPasajero.Name = "rtbPasajero";
            this.rtbPasajero.Size = new System.Drawing.Size(302, 244);
            this.rtbPasajero.TabIndex = 21;
            this.rtbPasajero.Text = "";
            // 
            // btnCargarEquipaje
            // 
            this.btnCargarEquipaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarEquipaje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarEquipaje.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCargarEquipaje.Location = new System.Drawing.Point(628, 152);
            this.btnCargarEquipaje.Name = "btnCargarEquipaje";
            this.btnCargarEquipaje.Size = new System.Drawing.Size(302, 42);
            this.btnCargarEquipaje.TabIndex = 22;
            this.btnCargarEquipaje.Text = "Cargar Equipaje";
            this.btnCargarEquipaje.UseVisualStyleBackColor = true;
            this.btnCargarEquipaje.Click += new System.EventHandler(this.btnCargarEquipaje_Click);
            // 
            // rtbEquipaje
            // 
            this.rtbEquipaje.Location = new System.Drawing.Point(628, 199);
            this.rtbEquipaje.Name = "rtbEquipaje";
            this.rtbEquipaje.Size = new System.Drawing.Size(302, 244);
            this.rtbEquipaje.TabIndex = 23;
            this.rtbEquipaje.Text = "";
            // 
            // btnCancelarModificacion
            // 
            this.btnCancelarModificacion.BackColor = System.Drawing.Color.White;
            this.btnCancelarModificacion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarModificacion.ForeColor = System.Drawing.Color.Red;
            this.btnCancelarModificacion.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarModificacion.Image")));
            this.btnCancelarModificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarModificacion.Location = new System.Drawing.Point(919, 700);
            this.btnCancelarModificacion.Name = "btnCancelarModificacion";
            this.btnCancelarModificacion.Size = new System.Drawing.Size(164, 38);
            this.btnCancelarModificacion.TabIndex = 30;
            this.btnCancelarModificacion.Text = "Cancelar Venta";
            this.btnCancelarModificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarModificacion.UseVisualStyleBackColor = false;
            // 
            // btnAceptarModificacion
            // 
            this.btnAceptarModificacion.BackColor = System.Drawing.Color.White;
            this.btnAceptarModificacion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptarModificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAceptarModificacion.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptarModificacion.Image")));
            this.btnAceptarModificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptarModificacion.Location = new System.Drawing.Point(1095, 700);
            this.btnAceptarModificacion.Name = "btnAceptarModificacion";
            this.btnAceptarModificacion.Size = new System.Drawing.Size(143, 38);
            this.btnAceptarModificacion.TabIndex = 29;
            this.btnAceptarModificacion.Text = "Cerrar Venta";
            this.btnAceptarModificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptarModificacion.UseVisualStyleBackColor = false;
            this.btnAceptarModificacion.Click += new System.EventHandler(this.btnAceptarModificacion_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFacturar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFacturar.Location = new System.Drawing.Point(936, 151);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(302, 42);
            this.btnFacturar.TabIndex = 31;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // rtbFacturacion
            // 
            this.rtbFacturacion.Location = new System.Drawing.Point(936, 199);
            this.rtbFacturacion.Name = "rtbFacturacion";
            this.rtbFacturacion.Size = new System.Drawing.Size(302, 244);
            this.rtbFacturacion.TabIndex = 32;
            this.rtbFacturacion.Text = "";
            // 
            // btnSubirPasajero
            // 
            this.btnSubirPasajero.BackColor = System.Drawing.Color.White;
            this.btnSubirPasajero.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubirPasajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSubirPasajero.Image = ((System.Drawing.Image)(resources.GetObject("btnSubirPasajero.Image")));
            this.btnSubirPasajero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubirPasajero.Location = new System.Drawing.Point(12, 700);
            this.btnSubirPasajero.Name = "btnSubirPasajero";
            this.btnSubirPasajero.Size = new System.Drawing.Size(241, 38);
            this.btnSubirPasajero.TabIndex = 34;
            this.btnSubirPasajero.Text = "Subir Pasajero";
            this.btnSubirPasajero.UseVisualStyleBackColor = false;
            this.btnSubirPasajero.Click += new System.EventHandler(this.btnSubirPasajero_Click);
            // 
            // btnCargarOtroPasajero
            // 
            this.btnCargarOtroPasajero.BackColor = System.Drawing.Color.White;
            this.btnCargarOtroPasajero.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCargarOtroPasajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCargarOtroPasajero.Location = new System.Drawing.Point(259, 700);
            this.btnCargarOtroPasajero.Name = "btnCargarOtroPasajero";
            this.btnCargarOtroPasajero.Size = new System.Drawing.Size(241, 37);
            this.btnCargarOtroPasajero.TabIndex = 35;
            this.btnCargarOtroPasajero.Text = "Cargar otro Pasajero";
            this.btnCargarOtroPasajero.UseVisualStyleBackColor = false;
            this.btnCargarOtroPasajero.Click += new System.EventHandler(this.btnCargarOtroPasajero_Click);
            // 
            // dgvListaDePasajes
            // 
            this.dgvListaDePasajes.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaDePasajes.GridColor = System.Drawing.Color.Black;
            this.dgvListaDePasajes.Location = new System.Drawing.Point(12, 449);
            this.dgvListaDePasajes.Name = "dgvListaDePasajes";
            this.dgvListaDePasajes.ReadOnly = true;
            this.dgvListaDePasajes.RowTemplate.Height = 25;
            this.dgvListaDePasajes.Size = new System.Drawing.Size(1226, 245);
            this.dgvListaDePasajes.TabIndex = 36;
            // 
            // FrmVenderPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Vista.Properties.Resources.logo_menu_ventas;
            this.ClientSize = new System.Drawing.Size(1272, 755);
            this.Controls.Add(this.dgvListaDePasajes);
            this.Controls.Add(this.btnCargarOtroPasajero);
            this.Controls.Add(this.btnSubirPasajero);
            this.Controls.Add(this.rtbFacturacion);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnCancelarModificacion);
            this.Controls.Add(this.btnAceptarModificacion);
            this.Controls.Add(this.rtbEquipaje);
            this.Controls.Add(this.btnCargarEquipaje);
            this.Controls.Add(this.rtbPasajero);
            this.Controls.Add(this.btnCargarPasajero);
            this.Controls.Add(this.rtbVuelo);
            this.Controls.Add(this.btnElegirVuelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVenderPasaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta de Pasajes";
            this.Load += new System.EventHandler(this.FrmVentaPasaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDePasajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnElegirVuelo;
        private System.Windows.Forms.RichTextBox rtbVuelo;
        private System.Windows.Forms.Button btnCargarPasajero;
        private System.Windows.Forms.RichTextBox rtbPasajero;
        private System.Windows.Forms.Button btnCargarEquipaje;
        private System.Windows.Forms.RichTextBox rtbEquipaje;
        private System.Windows.Forms.Button btnCancelarModificacion;
        private System.Windows.Forms.Button btnAceptarModificacion;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.RichTextBox rtbFacturacion;
        private System.Windows.Forms.Button btnSubirPasajero;
        private System.Windows.Forms.Button btnCargarOtroPasajero;
        private System.Windows.Forms.DataGridView dgvListaDePasajes;
    }
}
namespace Vista
{
    partial class FrmAbmDestinos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbmDestinos));
            this.btnCancelarModificacion = new System.Windows.Forms.Button();
            this.btnAceptarModificacion = new System.Windows.Forms.Button();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.txtAlta = new System.Windows.Forms.TextBox();
            this.cmbBoolNacOInt = new System.Windows.Forms.ComboBox();
            this.lblDestinoBajaModificacion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAlta = new System.Windows.Forms.Label();
            this.txtModificacion = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarModificacion
            // 
            this.btnCancelarModificacion.BackColor = System.Drawing.Color.White;
            this.btnCancelarModificacion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarModificacion.ForeColor = System.Drawing.Color.Red;
            this.btnCancelarModificacion.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarModificacion.Image")));
            this.btnCancelarModificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarModificacion.Location = new System.Drawing.Point(37, 285);
            this.btnCancelarModificacion.Name = "btnCancelarModificacion";
            this.btnCancelarModificacion.Size = new System.Drawing.Size(114, 38);
            this.btnCancelarModificacion.TabIndex = 6;
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
            this.btnAceptarModificacion.Location = new System.Drawing.Point(226, 285);
            this.btnAceptarModificacion.Name = "btnAceptarModificacion";
            this.btnAceptarModificacion.Size = new System.Drawing.Size(114, 38);
            this.btnAceptarModificacion.TabIndex = 7;
            this.btnAceptarModificacion.Text = "Aceptar";
            this.btnAceptarModificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptarModificacion.UseVisualStyleBackColor = false;
            this.btnAceptarModificacion.Click += new System.EventHandler(this.btnAceptarModificacion_Click);
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(127, 76);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(121, 23);
            this.cmbDestino.TabIndex = 2;
            this.cmbDestino.SelectedIndexChanged += new System.EventHandler(this.cmbDestino_SelectedIndexChanged);
            // 
            // txtAlta
            // 
            this.txtAlta.Location = new System.Drawing.Point(127, 163);
            this.txtAlta.Name = "txtAlta";
            this.txtAlta.PlaceholderText = "Nuevo Destino";
            this.txtAlta.Size = new System.Drawing.Size(121, 23);
            this.txtAlta.TabIndex = 5;
            // 
            // cmbBoolNacOInt
            // 
            this.cmbBoolNacOInt.FormattingEnabled = true;
            this.cmbBoolNacOInt.Location = new System.Drawing.Point(127, 47);
            this.cmbBoolNacOInt.Name = "cmbBoolNacOInt";
            this.cmbBoolNacOInt.Size = new System.Drawing.Size(121, 23);
            this.cmbBoolNacOInt.TabIndex = 1;
            this.cmbBoolNacOInt.SelectedIndexChanged += new System.EventHandler(this.cmbBoolNacOInt_SelectedIndexChanged);
            // 
            // lblDestinoBajaModificacion
            // 
            this.lblDestinoBajaModificacion.AutoSize = true;
            this.lblDestinoBajaModificacion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDestinoBajaModificacion.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblDestinoBajaModificacion.Location = new System.Drawing.Point(98, 205);
            this.lblDestinoBajaModificacion.Name = "lblDestinoBajaModificacion";
            this.lblDestinoBajaModificacion.Size = new System.Drawing.Size(0, 18);
            this.lblDestinoBajaModificacion.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.destinos1;
            this.pictureBox1.Location = new System.Drawing.Point(-10, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // lblAlta
            // 
            this.lblAlta.AutoSize = true;
            this.lblAlta.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlta.ForeColor = System.Drawing.Color.Red;
            this.lblAlta.Location = new System.Drawing.Point(92, 220);
            this.lblAlta.Name = "lblAlta";
            this.lblAlta.Size = new System.Drawing.Size(0, 16);
            this.lblAlta.TabIndex = 38;
            // 
            // txtModificacion
            // 
            this.txtModificacion.Location = new System.Drawing.Point(127, 105);
            this.txtModificacion.Name = "txtModificacion";
            this.txtModificacion.Size = new System.Drawing.Size(121, 23);
            this.txtModificacion.TabIndex = 3;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(127, 134);
            this.txtPais.Name = "txtPais";
            this.txtPais.PlaceholderText = "Ingrese Pais";
            this.txtPais.Size = new System.Drawing.Size(121, 23);
            this.txtPais.TabIndex = 4;
            // 
            // FrmAbmDestinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(407, 349);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtModificacion);
            this.Controls.Add(this.lblAlta);
            this.Controls.Add(this.lblDestinoBajaModificacion);
            this.Controls.Add(this.cmbBoolNacOInt);
            this.Controls.Add(this.txtAlta);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.btnCancelarModificacion);
            this.Controls.Add(this.btnAceptarModificacion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmAbmDestinos";
            this.Text = "ABM Destino";
            this.Load += new System.EventHandler(this.AbmDestinos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarModificacion;
        private System.Windows.Forms.Button btnAceptarModificacion;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.TextBox txtAlta;
        private System.Windows.Forms.ComboBox cmbBoolNacOInt;
        private System.Windows.Forms.Label lblDestinoBajaModificacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAlta;
        private System.Windows.Forms.TextBox txtModificacion;
        private System.Windows.Forms.TextBox txtPais;
    }
}
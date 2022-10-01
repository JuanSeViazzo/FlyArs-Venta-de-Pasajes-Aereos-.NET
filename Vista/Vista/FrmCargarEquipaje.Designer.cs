namespace Vista
{
    partial class FrmCargarEquipaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargarEquipaje));
            this.nmrSegundoEquipaje = new System.Windows.Forms.NumericUpDown();
            this.nmrPrimerEquipaje = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrDeMano = new System.Windows.Forms.NumericUpDown();
            this.rtbCliente = new System.Windows.Forms.RichTextBox();
            this.btnCancelarModificacion = new System.Windows.Forms.Button();
            this.btnAceptarModificacion = new System.Windows.Forms.Button();
            this.btnConfirmarCarga = new System.Windows.Forms.Button();
            this.lstEquipaje = new System.Windows.Forms.ListBox();
            this.lblMaximo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSegundoEquipaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrimerEquipaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDeMano)).BeginInit();
            this.SuspendLayout();
            // 
            // nmrSegundoEquipaje
            // 
            this.nmrSegundoEquipaje.BackColor = System.Drawing.Color.White;
            this.nmrSegundoEquipaje.Location = new System.Drawing.Point(345, 228);
            this.nmrSegundoEquipaje.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.nmrSegundoEquipaje.Name = "nmrSegundoEquipaje";
            this.nmrSegundoEquipaje.Size = new System.Drawing.Size(39, 23);
            this.nmrSegundoEquipaje.TabIndex = 47;
            // 
            // nmrPrimerEquipaje
            // 
            this.nmrPrimerEquipaje.BackColor = System.Drawing.Color.White;
            this.nmrPrimerEquipaje.Location = new System.Drawing.Point(345, 175);
            this.nmrPrimerEquipaje.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.nmrPrimerEquipaje.Name = "nmrPrimerEquipaje";
            this.nmrPrimerEquipaje.Size = new System.Drawing.Size(39, 23);
            this.nmrPrimerEquipaje.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "2do Equipaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "1er Equipaje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "Equipaje de Mano";
            // 
            // nmrDeMano
            // 
            this.nmrDeMano.BackColor = System.Drawing.Color.White;
            this.nmrDeMano.Location = new System.Drawing.Point(345, 119);
            this.nmrDeMano.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrDeMano.Name = "nmrDeMano";
            this.nmrDeMano.Size = new System.Drawing.Size(39, 23);
            this.nmrDeMano.TabIndex = 42;
            // 
            // rtbCliente
            // 
            this.rtbCliente.Location = new System.Drawing.Point(31, 98);
            this.rtbCliente.Name = "rtbCliente";
            this.rtbCliente.Size = new System.Drawing.Size(277, 246);
            this.rtbCliente.TabIndex = 48;
            this.rtbCliente.Text = "";
            // 
            // btnCancelarModificacion
            // 
            this.btnCancelarModificacion.BackColor = System.Drawing.Color.White;
            this.btnCancelarModificacion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarModificacion.ForeColor = System.Drawing.Color.Red;
            this.btnCancelarModificacion.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarModificacion.Image")));
            this.btnCancelarModificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarModificacion.Location = new System.Drawing.Point(422, 457);
            this.btnCancelarModificacion.Name = "btnCancelarModificacion";
            this.btnCancelarModificacion.Size = new System.Drawing.Size(113, 38);
            this.btnCancelarModificacion.TabIndex = 51;
            this.btnCancelarModificacion.Text = "Cancelar";
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
            this.btnAceptarModificacion.Location = new System.Drawing.Point(586, 457);
            this.btnAceptarModificacion.Name = "btnAceptarModificacion";
            this.btnAceptarModificacion.Size = new System.Drawing.Size(113, 38);
            this.btnAceptarModificacion.TabIndex = 50;
            this.btnAceptarModificacion.Text = "Cargar";
            this.btnAceptarModificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptarModificacion.UseVisualStyleBackColor = false;
            this.btnAceptarModificacion.Click += new System.EventHandler(this.btnAceptarModificacion_Click);
            // 
            // btnConfirmarCarga
            // 
            this.btnConfirmarCarga.BackColor = System.Drawing.Color.White;
            this.btnConfirmarCarga.Location = new System.Drawing.Point(422, 350);
            this.btnConfirmarCarga.Name = "btnConfirmarCarga";
            this.btnConfirmarCarga.Size = new System.Drawing.Size(277, 23);
            this.btnConfirmarCarga.TabIndex = 52;
            this.btnConfirmarCarga.Text = "Registrar Equipaje";
            this.btnConfirmarCarga.UseVisualStyleBackColor = false;
            this.btnConfirmarCarga.Click += new System.EventHandler(this.btnConfirmarCarga_Click);
            // 
            // lstEquipaje
            // 
            this.lstEquipaje.FormattingEnabled = true;
            this.lstEquipaje.ItemHeight = 15;
            this.lstEquipaje.Location = new System.Drawing.Point(422, 98);
            this.lstEquipaje.Name = "lstEquipaje";
            this.lstEquipaje.Size = new System.Drawing.Size(277, 244);
            this.lstEquipaje.TabIndex = 53;
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.BackColor = System.Drawing.Color.White;
            this.lblMaximo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaximo.ForeColor = System.Drawing.Color.Red;
            this.lblMaximo.Location = new System.Drawing.Point(422, 390);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(95, 18);
            this.lblMaximo.TabIndex = 54;
            this.lblMaximo.Text = "lblMaximo";
            // 
            // FrmCargarEquipaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 507);
            this.Controls.Add(this.lblMaximo);
            this.Controls.Add(this.lstEquipaje);
            this.Controls.Add(this.btnConfirmarCarga);
            this.Controls.Add(this.btnCancelarModificacion);
            this.Controls.Add(this.btnAceptarModificacion);
            this.Controls.Add(this.rtbCliente);
            this.Controls.Add(this.nmrSegundoEquipaje);
            this.Controls.Add(this.nmrPrimerEquipaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmrDeMano);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCargarEquipaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCargarEquipaje";
            this.Load += new System.EventHandler(this.FrmCargarEquipaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrSegundoEquipaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrimerEquipaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDeMano)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmrSegundoEquipaje;
        private System.Windows.Forms.NumericUpDown nmrPrimerEquipaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrDeMano;
        private System.Windows.Forms.RichTextBox rtbCliente;
        private System.Windows.Forms.Button btnCancelarModificacion;
        private System.Windows.Forms.Button btnAceptarModificacion;
        private System.Windows.Forms.Button btnConfirmarCarga;
        private System.Windows.Forms.ListBox lstEquipaje;
        private System.Windows.Forms.Label lblMaximo;
    }
}
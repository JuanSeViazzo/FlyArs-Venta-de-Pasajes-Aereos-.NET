namespace Vista
{
    partial class FrmAltaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaCliente));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.cmb_tipoDeDocumento = new System.Windows.Forms.ComboBox();
            this.Txt_numeroDeDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptarModificacion = new System.Windows.Forms.Button();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.Edad = new System.Windows.Forms.Label();
            this.rtbPasajero = new System.Windows.Forms.RichTextBox();
            this.calMyDate = new System.Windows.Forms.MonthCalendar();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.lbl_errorExcep = new System.Windows.Forms.Label();
            this.lbl_ExceptionErrorApellido = new System.Windows.Forms.Label();
            this.grpSex = new System.Windows.Forms.GroupBox();
            this.radSexMasc = new System.Windows.Forms.RadioButton();
            this.radSexFem = new System.Windows.Forms.RadioButton();
            this.btnCancelarModificacion = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(44, 129);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "1er Nombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(389, 55);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "Apellido";
            this.txtApellido.Size = new System.Drawing.Size(250, 23);
            this.txtApellido.TabIndex = 3;
            // 
            // cmb_tipoDeDocumento
            // 
            this.cmb_tipoDeDocumento.FormattingEnabled = true;
            this.cmb_tipoDeDocumento.Location = new System.Drawing.Point(389, 186);
            this.cmb_tipoDeDocumento.Name = "cmb_tipoDeDocumento";
            this.cmb_tipoDeDocumento.Size = new System.Drawing.Size(100, 23);
            this.cmb_tipoDeDocumento.TabIndex = 6;
            this.cmb_tipoDeDocumento.Text = "Tipo de Documento";
            // 
            // Txt_numeroDeDocumento
            // 
            this.Txt_numeroDeDocumento.Location = new System.Drawing.Point(495, 186);
            this.Txt_numeroDeDocumento.Name = "Txt_numeroDeDocumento";
            this.Txt_numeroDeDocumento.PlaceholderText = "N° de Documento";
            this.Txt_numeroDeDocumento.Size = new System.Drawing.Size(144, 23);
            this.Txt_numeroDeDocumento.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha de Nacimiento";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(192, 381);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.PlaceholderText = "Nacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(100, 23);
            this.txtNacionalidad.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nacionalidad";
            // 
            // btnAceptarModificacion
            // 
            this.btnAceptarModificacion.BackColor = System.Drawing.Color.White;
            this.btnAceptarModificacion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptarModificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAceptarModificacion.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptarModificacion.Image")));
            this.btnAceptarModificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptarModificacion.Location = new System.Drawing.Point(105, 410);
            this.btnAceptarModificacion.Name = "btnAceptarModificacion";
            this.btnAceptarModificacion.Size = new System.Drawing.Size(121, 38);
            this.btnAceptarModificacion.TabIndex = 13;
            this.btnAceptarModificacion.Text = "Cargar";
            this.btnAceptarModificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptarModificacion.UseVisualStyleBackColor = false;
            this.btnAceptarModificacion.Click += new System.EventHandler(this.btn_aceptarPasajero_Click);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(44, 381);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(47, 23);
            this.txtEdad.TabIndex = 14;
            // 
            // Edad
            // 
            this.Edad.AutoSize = true;
            this.Edad.Location = new System.Drawing.Point(44, 363);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(33, 15);
            this.Edad.TabIndex = 15;
            this.Edad.Text = "Edad";
            // 
            // rtbPasajero
            // 
            this.rtbPasajero.BackColor = System.Drawing.Color.White;
            this.rtbPasajero.Location = new System.Drawing.Point(389, 228);
            this.rtbPasajero.Name = "rtbPasajero";
            this.rtbPasajero.ReadOnly = true;
            this.rtbPasajero.Size = new System.Drawing.Size(250, 261);
            this.rtbPasajero.TabIndex = 16;
            this.rtbPasajero.Text = "";
            // 
            // calMyDate
            // 
            this.calMyDate.Location = new System.Drawing.Point(44, 192);
            this.calMyDate.Name = "calMyDate";
            this.calMyDate.TabIndex = 19;
            // 
            // lbl_errorExcep
            // 
            this.lbl_errorExcep.AutoSize = true;
            this.lbl_errorExcep.BackColor = System.Drawing.Color.Red;
            this.lbl_errorExcep.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_errorExcep.Location = new System.Drawing.Point(415, 451);
            this.lbl_errorExcep.Name = "lbl_errorExcep";
            this.lbl_errorExcep.Size = new System.Drawing.Size(0, 16);
            this.lbl_errorExcep.TabIndex = 22;
            // 
            // lbl_ExceptionErrorApellido
            // 
            this.lbl_ExceptionErrorApellido.AutoSize = true;
            this.lbl_ExceptionErrorApellido.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ExceptionErrorApellido.Location = new System.Drawing.Point(184, 156);
            this.lbl_ExceptionErrorApellido.Name = "lbl_ExceptionErrorApellido";
            this.lbl_ExceptionErrorApellido.Size = new System.Drawing.Size(0, 13);
            this.lbl_ExceptionErrorApellido.TabIndex = 23;
            // 
            // grpSex
            // 
            this.grpSex.BackColor = System.Drawing.Color.White;
            this.grpSex.Controls.Add(this.radSexMasc);
            this.grpSex.Controls.Add(this.radSexFem);
            this.grpSex.Location = new System.Drawing.Point(389, 94);
            this.grpSex.Name = "grpSex";
            this.grpSex.Size = new System.Drawing.Size(241, 76);
            this.grpSex.TabIndex = 24;
            this.grpSex.TabStop = false;
            // 
            // radSexMasc
            // 
            this.radSexMasc.AutoSize = true;
            this.radSexMasc.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radSexMasc.Location = new System.Drawing.Point(125, 35);
            this.radSexMasc.Name = "radSexMasc";
            this.radSexMasc.Size = new System.Drawing.Size(89, 20);
            this.radSexMasc.TabIndex = 1;
            this.radSexMasc.TabStop = true;
            this.radSexMasc.Text = "Masculino";
            this.radSexMasc.UseVisualStyleBackColor = true;
            // 
            // radSexFem
            // 
            this.radSexFem.AutoSize = true;
            this.radSexFem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radSexFem.Location = new System.Drawing.Point(6, 34);
            this.radSexFem.Name = "radSexFem";
            this.radSexFem.Size = new System.Drawing.Size(87, 20);
            this.radSexFem.TabIndex = 0;
            this.radSexFem.TabStop = true;
            this.radSexFem.Text = "Femenino";
            this.radSexFem.UseVisualStyleBackColor = true;
            // 
            // btnCancelarModificacion
            // 
            this.btnCancelarModificacion.BackColor = System.Drawing.Color.White;
            this.btnCancelarModificacion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarModificacion.ForeColor = System.Drawing.Color.Red;
            this.btnCancelarModificacion.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarModificacion.Image")));
            this.btnCancelarModificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarModificacion.Location = new System.Drawing.Point(42, 451);
            this.btnCancelarModificacion.Name = "btnCancelarModificacion";
            this.btnCancelarModificacion.Size = new System.Drawing.Size(121, 38);
            this.btnCancelarModificacion.TabIndex = 26;
            this.btnCancelarModificacion.Text = "Cancelar";
            this.btnCancelarModificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarModificacion.UseVisualStyleBackColor = false;
            this.btnCancelarModificacion.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(173, 451);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 38);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Vista.Properties.Resources.pasajeros;
            this.ClientSize = new System.Drawing.Size(654, 509);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelarModificacion);
            this.Controls.Add(this.grpSex);
            this.Controls.Add(this.lbl_ExceptionErrorApellido);
            this.Controls.Add(this.lbl_errorExcep);
            this.Controls.Add(this.calMyDate);
            this.Controls.Add(this.rtbPasajero);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.btnAceptarModificacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_numeroDeDocumento);
            this.Controls.Add(this.cmb_tipoDeDocumento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAltaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Cliente";
            this.Load += new System.EventHandler(this.FrmAltaCliente_Load);
            this.grpSex.ResumeLayout(false);
            this.grpSex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox cmb_tipoDeDocumento;
        private System.Windows.Forms.TextBox Txt_numeroDeDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptarModificacion;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label Edad;
        private System.Windows.Forms.RichTextBox rtbPasajero;
        private System.Windows.Forms.MonthCalendar calMyDate;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label lbl_errorExcep;
        private System.Windows.Forms.Label lbl_ExceptionErrorApellido;
        private System.Windows.Forms.GroupBox grpSex;
        private System.Windows.Forms.RadioButton radSexMasc;
        private System.Windows.Forms.RadioButton radSexFem;
        private System.Windows.Forms.Button btnCancelarModificacion;
        private System.Windows.Forms.Button btnGuardar;
    }
}
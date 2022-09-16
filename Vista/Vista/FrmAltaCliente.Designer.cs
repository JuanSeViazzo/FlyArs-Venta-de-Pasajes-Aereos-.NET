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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.Txt_apellido = new System.Windows.Forms.TextBox();
            this.cmb_tipoDeDocumento = new System.Windows.Forms.ComboBox();
            this.Txt_numeroDeDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nacionalidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_aceptarPasajero = new System.Windows.Forms.Button();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.Edad = new System.Windows.Forms.Label();
            this.rtb_DatosDelCliente = new System.Windows.Forms.RichTextBox();
            this.calendar_nacimiento = new System.Windows.Forms.MonthCalendar();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.lbl_errorExcep = new System.Windows.Forms.Label();
            this.lbl_ExceptionErrorApellido = new System.Windows.Forms.Label();
            this.grp_Sexo = new System.Windows.Forms.GroupBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdFemenino = new System.Windows.Forms.RadioButton();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.grp_Sexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(76, 55);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PlaceholderText = "Nombre";
            this.txt_nombre.Size = new System.Drawing.Size(250, 23);
            this.txt_nombre.TabIndex = 2;
            // 
            // Txt_apellido
            // 
            this.Txt_apellido.Location = new System.Drawing.Point(389, 55);
            this.Txt_apellido.Name = "Txt_apellido";
            this.Txt_apellido.PlaceholderText = "Apellido";
            this.Txt_apellido.Size = new System.Drawing.Size(250, 23);
            this.Txt_apellido.TabIndex = 3;
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
            this.label1.Location = new System.Drawing.Point(78, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha de Nacimiento";
            // 
            // txt_nacionalidad
            // 
            this.txt_nacionalidad.Location = new System.Drawing.Point(226, 307);
            this.txt_nacionalidad.Name = "txt_nacionalidad";
            this.txt_nacionalidad.PlaceholderText = "Nacionalidad";
            this.txt_nacionalidad.Size = new System.Drawing.Size(100, 23);
            this.txt_nacionalidad.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nacionalidad";
            // 
            // btn_aceptarPasajero
            // 
            this.btn_aceptarPasajero.BackColor = System.Drawing.Color.White;
            this.btn_aceptarPasajero.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_aceptarPasajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_aceptarPasajero.Image = ((System.Drawing.Image)(resources.GetObject("btn_aceptarPasajero.Image")));
            this.btn_aceptarPasajero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_aceptarPasajero.Location = new System.Drawing.Point(213, 510);
            this.btn_aceptarPasajero.Name = "btn_aceptarPasajero";
            this.btn_aceptarPasajero.Size = new System.Drawing.Size(113, 38);
            this.btn_aceptarPasajero.TabIndex = 13;
            this.btn_aceptarPasajero.Text = "Cargar";
            this.btn_aceptarPasajero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_aceptarPasajero.UseVisualStyleBackColor = false;
            this.btn_aceptarPasajero.Click += new System.EventHandler(this.btn_aceptarPasajero_Click);
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(78, 307);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(47, 23);
            this.txt_edad.TabIndex = 14;
            // 
            // Edad
            // 
            this.Edad.AutoSize = true;
            this.Edad.Location = new System.Drawing.Point(78, 289);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(33, 15);
            this.Edad.TabIndex = 15;
            this.Edad.Text = "Edad";
            // 
            // rtb_DatosDelCliente
            // 
            this.rtb_DatosDelCliente.Location = new System.Drawing.Point(389, 228);
            this.rtb_DatosDelCliente.Name = "rtb_DatosDelCliente";
            this.rtb_DatosDelCliente.Size = new System.Drawing.Size(250, 320);
            this.rtb_DatosDelCliente.TabIndex = 16;
            this.rtb_DatosDelCliente.Text = "";
            // 
            // calendar_nacimiento
            // 
            this.calendar_nacimiento.Location = new System.Drawing.Point(78, 118);
            this.calendar_nacimiento.Name = "calendar_nacimiento";
            this.calendar_nacimiento.TabIndex = 19;
            // 
            // lbl_errorExcep
            // 
            this.lbl_errorExcep.AutoSize = true;
            this.lbl_errorExcep.BackColor = System.Drawing.Color.Red;
            this.lbl_errorExcep.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_errorExcep.Location = new System.Drawing.Point(197, 491);
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
            // grp_Sexo
            // 
            this.grp_Sexo.Controls.Add(this.rdbMasculino);
            this.grp_Sexo.Controls.Add(this.rdFemenino);
            this.grp_Sexo.Location = new System.Drawing.Point(389, 94);
            this.grp_Sexo.Name = "grp_Sexo";
            this.grp_Sexo.Size = new System.Drawing.Size(241, 76);
            this.grp_Sexo.TabIndex = 24;
            this.grp_Sexo.TabStop = false;
            this.grp_Sexo.Text = "groupBox1";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbMasculino.Location = new System.Drawing.Point(125, 35);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(87, 20);
            this.rdbMasculino.TabIndex = 1;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Femenino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdFemenino
            // 
            this.rdFemenino.AutoSize = true;
            this.rdFemenino.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdFemenino.Location = new System.Drawing.Point(6, 34);
            this.rdFemenino.Name = "rdFemenino";
            this.rdFemenino.Size = new System.Drawing.Size(89, 20);
            this.rdFemenino.TabIndex = 0;
            this.rdFemenino.TabStop = true;
            this.rdFemenino.Text = "Masculino";
            this.rdFemenino.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.White;
            this.btn_Cancelar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Red;
            this.btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Image")));
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.Location = new System.Drawing.Point(78, 510);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(113, 38);
            this.btn_Cancelar.TabIndex = 26;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // FrmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(669, 566);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.grp_Sexo);
            this.Controls.Add(this.lbl_ExceptionErrorApellido);
            this.Controls.Add(this.lbl_errorExcep);
            this.Controls.Add(this.calendar_nacimiento);
            this.Controls.Add(this.rtb_DatosDelCliente);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.btn_aceptarPasajero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nacionalidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_numeroDeDocumento);
            this.Controls.Add(this.cmb_tipoDeDocumento);
            this.Controls.Add(this.Txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Name = "FrmAltaCliente";
            this.Text = "FrmAltaCliente";
            this.Load += new System.EventHandler(this.FrmAltaCliente_Load);
            this.grp_Sexo.ResumeLayout(false);
            this.grp_Sexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox Txt_apellido;
        private System.Windows.Forms.ComboBox cmb_tipoDeDocumento;
        private System.Windows.Forms.TextBox Txt_numeroDeDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nacionalidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_aceptarPasajero;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label Edad;
        private System.Windows.Forms.RichTextBox rtb_DatosDelCliente;
        private System.Windows.Forms.MonthCalendar calendar_nacimiento;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label lbl_errorExcep;
        private System.Windows.Forms.Label lbl_ExceptionErrorApellido;
        private System.Windows.Forms.GroupBox grp_Sexo;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdFemenino;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}
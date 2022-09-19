namespace Vista
{
    partial class FrmModificarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarCliente));
            this.rtb_PasajeroAModificar = new System.Windows.Forms.RichTextBox();
            this.calMyDate = new System.Windows.Forms.MonthCalendar();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.grp_Sexo = new System.Windows.Forms.GroupBox();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btn_ModificarPasajero = new System.Windows.Forms.Button();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.cmbTipoDeDocumento = new System.Windows.Forms.ComboBox();
            this.Edad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_errorExcep = new System.Windows.Forms.Label();
            this.grp_Sexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_PasajeroAModificar
            // 
            this.rtb_PasajeroAModificar.Location = new System.Drawing.Point(323, 176);
            this.rtb_PasajeroAModificar.Name = "rtb_PasajeroAModificar";
            this.rtb_PasajeroAModificar.Size = new System.Drawing.Size(305, 369);
            this.rtb_PasajeroAModificar.TabIndex = 0;
            this.rtb_PasajeroAModificar.Text = "";
            // 
            // calMyDate
            // 
            this.calMyDate.Location = new System.Drawing.Point(67, 79);
            this.calMyDate.Name = "calMyDate";
            this.calMyDate.TabIndex = 34;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(378, 16);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "Apellido";
            this.txtApellido.Size = new System.Drawing.Size(250, 23);
            this.txtApellido.TabIndex = 28;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(65, 16);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 23);
            this.txtNombre.TabIndex = 27;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbMasculino.Location = new System.Drawing.Point(6, 34);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(89, 20);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // grp_Sexo
            // 
            this.grp_Sexo.Controls.Add(this.rdbFemenino);
            this.grp_Sexo.Controls.Add(this.rdbMasculino);
            this.grp_Sexo.Location = new System.Drawing.Point(378, 55);
            this.grp_Sexo.Name = "grp_Sexo";
            this.grp_Sexo.Size = new System.Drawing.Size(241, 76);
            this.grp_Sexo.TabIndex = 35;
            this.grp_Sexo.TabStop = false;
            this.grp_Sexo.Text = "groupBox1";
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbFemenino.Location = new System.Drawing.Point(106, 34);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(87, 20);
            this.rdbFemenino.TabIndex = 1;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.White;
            this.btn_Cancelar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Red;
            this.btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Image")));
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.Location = new System.Drawing.Point(65, 507);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(113, 38);
            this.btn_Cancelar.TabIndex = 36;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(67, 268);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(47, 23);
            this.txtEdad.TabIndex = 33;
            // 
            // btn_ModificarPasajero
            // 
            this.btn_ModificarPasajero.BackColor = System.Drawing.Color.White;
            this.btn_ModificarPasajero.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ModificarPasajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ModificarPasajero.Image = ((System.Drawing.Image)(resources.GetObject("btn_ModificarPasajero.Image")));
            this.btn_ModificarPasajero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ModificarPasajero.Location = new System.Drawing.Point(202, 507);
            this.btn_ModificarPasajero.Name = "btn_ModificarPasajero";
            this.btn_ModificarPasajero.Size = new System.Drawing.Size(113, 38);
            this.btn_ModificarPasajero.TabIndex = 32;
            this.btn_ModificarPasajero.Text = "Cargar";
            this.btn_ModificarPasajero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ModificarPasajero.UseVisualStyleBackColor = false;
            this.btn_ModificarPasajero.Click += new System.EventHandler(this.btn_ModificarPasajero_Click);
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(215, 268);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.PlaceholderText = "Nacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(100, 23);
            this.txtNacionalidad.TabIndex = 31;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(484, 147);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.PlaceholderText = "N° de Documento";
            this.txtDocumento.Size = new System.Drawing.Size(144, 23);
            this.txtDocumento.TabIndex = 30;
            // 
            // cmbTipoDeDocumento
            // 
            this.cmbTipoDeDocumento.FormattingEnabled = true;
            this.cmbTipoDeDocumento.Location = new System.Drawing.Point(323, 147);
            this.cmbTipoDeDocumento.Name = "cmbTipoDeDocumento";
            this.cmbTipoDeDocumento.Size = new System.Drawing.Size(100, 23);
            this.cmbTipoDeDocumento.TabIndex = 29;
            this.cmbTipoDeDocumento.Text = "Tipo de Documento";
            // 
            // Edad
            // 
            this.Edad.AutoSize = true;
            this.Edad.Location = new System.Drawing.Point(67, 250);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(33, 15);
            this.Edad.TabIndex = 39;
            this.Edad.Text = "Edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nacionalidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "Fecha de Nacimiento";
            // 
            // lbl_errorExcep
            // 
            this.lbl_errorExcep.AutoSize = true;
            this.lbl_errorExcep.BackColor = System.Drawing.Color.Red;
            this.lbl_errorExcep.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_errorExcep.Location = new System.Drawing.Point(178, 479);
            this.lbl_errorExcep.Name = "lbl_errorExcep";
            this.lbl_errorExcep.Size = new System.Drawing.Size(0, 16);
            this.lbl_errorExcep.TabIndex = 40;
            // 
            // FrmModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 584);
            this.Controls.Add(this.lbl_errorExcep);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calMyDate);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.grp_Sexo);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.btn_ModificarPasajero);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.cmbTipoDeDocumento);
            this.Controls.Add(this.rtb_PasajeroAModificar);
            this.Name = "FrmModificarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ModificarPasajero";
            this.Load += new System.EventHandler(this.ModificarPasajero_Load);
            this.grp_Sexo.ResumeLayout(false);
            this.grp_Sexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_PasajeroAModificar;
        private System.Windows.Forms.MonthCalendar calMyDate;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.GroupBox grp_Sexo;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btn_ModificarPasajero;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.ComboBox cmbTipoDeDocumento;
        private System.Windows.Forms.Label Edad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_errorExcep;
    }
}
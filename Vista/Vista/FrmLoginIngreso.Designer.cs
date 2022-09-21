namespace Vista
{
    partial class FrmLoginIngreso
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
            this.pc_LoginOk = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pc_LoginNo = new System.Windows.Forms.PictureBox();
            this.pb_avionFrontal = new System.Windows.Forms.PictureBox();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.lbl_IngresoOkNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pc_LoginOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_LoginNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_avionFrontal)).BeginInit();
            this.SuspendLayout();
            // 
            // pc_LoginOk
            // 
            this.pc_LoginOk.Image = global::Vista.Properties.Resources.dedo_ok;
            this.pc_LoginOk.Location = new System.Drawing.Point(231, 396);
            this.pc_LoginOk.Name = "pc_LoginOk";
            this.pc_LoginOk.Size = new System.Drawing.Size(50, 50);
            this.pc_LoginOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pc_LoginOk.TabIndex = 0;
            this.pc_LoginOk.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Vista.Properties.Resources.FLYARG;
            this.pictureBox2.Location = new System.Drawing.Point(-48, -136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(600, 600);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pc_LoginNo
            // 
            this.pc_LoginNo.Image = global::Vista.Properties.Resources.dedo_no;
            this.pc_LoginNo.Location = new System.Drawing.Point(231, 396);
            this.pc_LoginNo.Name = "pc_LoginNo";
            this.pc_LoginNo.Size = new System.Drawing.Size(50, 50);
            this.pc_LoginNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pc_LoginNo.TabIndex = 2;
            this.pc_LoginNo.TabStop = false;
            // 
            // pb_avionFrontal
            // 
            this.pb_avionFrontal.Image = global::Vista.Properties.Resources.avion2;
            this.pb_avionFrontal.Location = new System.Drawing.Point(-2, -10);
            this.pb_avionFrontal.Name = "pb_avionFrontal";
            this.pb_avionFrontal.Size = new System.Drawing.Size(715, 474);
            this.pb_avionFrontal.TabIndex = 3;
            this.pb_avionFrontal.TabStop = false;
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Hora.Location = new System.Drawing.Point(30, 396);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(45, 16);
            this.lbl_Hora.TabIndex = 4;
            this.lbl_Hora.Text = "label1";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Fecha.Location = new System.Drawing.Point(30, 430);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(45, 16);
            this.lbl_Fecha.TabIndex = 5;
            this.lbl_Fecha.Text = "label2";
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.BackColor = System.Drawing.Color.White;
            this.btn_Ingresar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Ingresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Ingresar.Image = global::Vista.Properties.Resources.check_ok1;
            this.btn_Ingresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ingresar.Location = new System.Drawing.Point(223, 253);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(132, 43);
            this.btn_Ingresar.TabIndex = 6;
            this.btn_Ingresar.Text = "Confirmar";
            this.btn_Ingresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Ingresar.UseVisualStyleBackColor = false;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(223, 224);
            this.tb_password.Name = "tb_password";
            this.tb_password.PlaceholderText = "Ingrese contraseña";
            this.tb_password.Size = new System.Drawing.Size(132, 23);
            this.tb_password.TabIndex = 7;
            this.tb_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_password_KeyDown);
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(223, 195);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.PlaceholderText = "Ingrese usuario";
            this.tb_usuario.Size = new System.Drawing.Size(132, 23);
            this.tb_usuario.TabIndex = 8;
            // 
            // lbl_IngresoOkNo
            // 
            this.lbl_IngresoOkNo.AutoSize = true;
            this.lbl_IngresoOkNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_IngresoOkNo.Location = new System.Drawing.Point(297, 410);
            this.lbl_IngresoOkNo.Name = "lbl_IngresoOkNo";
            this.lbl_IngresoOkNo.Size = new System.Drawing.Size(58, 18);
            this.lbl_IngresoOkNo.TabIndex = 9;
            this.lbl_IngresoOkNo.Text = "label1";
            // 
            // FrmLoginIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(543, 457);
            this.Controls.Add(this.pb_avionFrontal);
            this.Controls.Add(this.lbl_IngresoOkNo);
            this.Controls.Add(this.pc_LoginNo);
            this.Controls.Add(this.pc_LoginOk);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLoginIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            this.Load += new System.EventHandler(this.FrmLoginIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pc_LoginOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_LoginNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_avionFrontal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion

        private System.Windows.Forms.PictureBox pc_LoginOk;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pc_LoginNo;
        private System.Windows.Forms.PictureBox pb_avionFrontal;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.Label lbl_IngresoOkNo;
    }
}
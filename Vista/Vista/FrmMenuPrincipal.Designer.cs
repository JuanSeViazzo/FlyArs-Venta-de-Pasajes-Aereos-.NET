namespace Vista
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_MenuPasajes = new System.Windows.Forms.Button();
            this.btn_MenuVuelos = new System.Windows.Forms.Button();
            this.btn_Estadisticas = new System.Windows.Forms.Button();
            this.btnMenuClientes = new System.Windows.Forms.Button();
            this.btnDestinos = new System.Windows.Forms.Button();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_HoraActualMenuPrincipal = new System.Windows.Forms.Label();
            this.btnSoporte = new System.Windows.Forms.Button();
            this.txtSoporte = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(150, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Salir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.Location = new System.Drawing.Point(665, 356);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(132, 61);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_MenuPasajes
            // 
            this.btn_MenuPasajes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MenuPasajes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_MenuPasajes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MenuPasajes.Location = new System.Drawing.Point(12, 46);
            this.btn_MenuPasajes.Name = "btn_MenuPasajes";
            this.btn_MenuPasajes.Size = new System.Drawing.Size(132, 61);
            this.btn_MenuPasajes.TabIndex = 8;
            this.btn_MenuPasajes.Text = "Menu Pasajes";
            this.btn_MenuPasajes.UseVisualStyleBackColor = true;
            this.btn_MenuPasajes.Click += new System.EventHandler(this.btn_MenuPasajes_Click);
            // 
            // btn_MenuVuelos
            // 
            this.btn_MenuVuelos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MenuVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_MenuVuelos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MenuVuelos.Location = new System.Drawing.Point(663, 59);
            this.btn_MenuVuelos.Name = "btn_MenuVuelos";
            this.btn_MenuVuelos.Size = new System.Drawing.Size(132, 61);
            this.btn_MenuVuelos.TabIndex = 9;
            this.btn_MenuVuelos.Text = "Menu Vuelos";
            this.btn_MenuVuelos.UseVisualStyleBackColor = true;
            this.btn_MenuVuelos.Click += new System.EventHandler(this.btn_MenuVuelos_Click);
            // 
            // btn_Estadisticas
            // 
            this.btn_Estadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Estadisticas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Estadisticas.Location = new System.Drawing.Point(665, 196);
            this.btn_Estadisticas.Name = "btn_Estadisticas";
            this.btn_Estadisticas.Size = new System.Drawing.Size(132, 61);
            this.btn_Estadisticas.TabIndex = 10;
            this.btn_Estadisticas.Text = "Estadisticas";
            this.btn_Estadisticas.UseVisualStyleBackColor = true;
            this.btn_Estadisticas.Click += new System.EventHandler(this.btn_Estadisticas_Click);
            // 
            // btnMenuClientes
            // 
            this.btnMenuClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenuClientes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenuClientes.Location = new System.Drawing.Point(12, 196);
            this.btnMenuClientes.Name = "btnMenuClientes";
            this.btnMenuClientes.Size = new System.Drawing.Size(132, 61);
            this.btnMenuClientes.TabIndex = 13;
            this.btnMenuClientes.Text = "Menu Clientes";
            this.btnMenuClientes.UseVisualStyleBackColor = true;
            this.btnMenuClientes.Click += new System.EventHandler(this.btnMenuClientes_Click);
            // 
            // btnDestinos
            // 
            this.btnDestinos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDestinos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDestinos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDestinos.Location = new System.Drawing.Point(12, 356);
            this.btnDestinos.Name = "btnDestinos";
            this.btnDestinos.Size = new System.Drawing.Size(132, 61);
            this.btnDestinos.TabIndex = 14;
            this.btnDestinos.Text = "Destinos";
            this.btnDestinos.UseVisualStyleBackColor = true;
            this.btnDestinos.Click += new System.EventHandler(this.btnDestinos_Click);
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Usuario.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_Usuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Usuario.Location = new System.Drawing.Point(194, 420);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(107, 20);
            this.lbl_Usuario.TabIndex = 16;
            this.lbl_Usuario.Text = "Bienvenido:";
            // 
            // lbl_HoraActualMenuPrincipal
            // 
            this.lbl_HoraActualMenuPrincipal.AutoSize = true;
            this.lbl_HoraActualMenuPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_HoraActualMenuPrincipal.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl_HoraActualMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_HoraActualMenuPrincipal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_HoraActualMenuPrincipal.Location = new System.Drawing.Point(432, 420);
            this.lbl_HoraActualMenuPrincipal.Name = "lbl_HoraActualMenuPrincipal";
            this.lbl_HoraActualMenuPrincipal.Size = new System.Drawing.Size(120, 20);
            this.lbl_HoraActualMenuPrincipal.TabIndex = 17;
            this.lbl_HoraActualMenuPrincipal.Text = "Fecha actual:";
            // 
            // btnSoporte
            // 
            this.btnSoporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSoporte.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSoporte.Location = new System.Drawing.Point(326, 460);
            this.btnSoporte.Name = "btnSoporte";
            this.btnSoporte.Size = new System.Drawing.Size(132, 61);
            this.btnSoporte.TabIndex = 18;
            this.btnSoporte.Text = "Soporte";
            this.btnSoporte.UseVisualStyleBackColor = true;
            this.btnSoporte.MouseLeave += new System.EventHandler(this.btnSoporte_MouseLeave);
            this.btnSoporte.MouseHover += new System.EventHandler(this.btnSoporte_MouseHover);
            // 
            // txtSoporte
            // 
            this.txtSoporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSoporte.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSoporte.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtSoporte.Location = new System.Drawing.Point(223, 131);
            this.txtSoporte.Multiline = true;
            this.txtSoporte.Name = "txtSoporte";
            this.txtSoporte.ReadOnly = true;
            this.txtSoporte.Size = new System.Drawing.Size(348, 190);
            this.txtSoporte.TabIndex = 19;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(807, 533);
            this.Controls.Add(this.txtSoporte);
            this.Controls.Add(this.btnSoporte);
            this.Controls.Add(this.lbl_HoraActualMenuPrincipal);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.btnDestinos);
            this.Controls.Add(this.btnMenuClientes);
            this.Controls.Add(this.btn_Estadisticas);
            this.Controls.Add(this.btn_MenuVuelos);
            this.Controls.Add(this.btn_MenuPasajes);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_MenuPasajes;
        private System.Windows.Forms.Button btn_MenuVuelos;
        private System.Windows.Forms.Button btn_Estadisticas;
        private System.Windows.Forms.Button btnMenuClientes;
        private System.Windows.Forms.Button btnDestinos;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_HoraActualMenuPrincipal;
        private System.Windows.Forms.Button btnSoporte;
        private System.Windows.Forms.TextBox txtSoporte;
    }
}
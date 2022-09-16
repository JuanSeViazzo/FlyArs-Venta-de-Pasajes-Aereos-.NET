namespace Vista
{
    partial class FrmMenuPasajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPasajes));
            this.btn_AnularPasaje = new System.Windows.Forms.Button();
            this.btn_ModificarPasaje = new System.Windows.Forms.Button();
            this.btn_VenderPasaje = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AnularPasaje
            // 
            this.btn_AnularPasaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AnularPasaje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AnularPasaje.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AnularPasaje.Location = new System.Drawing.Point(12, 305);
            this.btn_AnularPasaje.Name = "btn_AnularPasaje";
            this.btn_AnularPasaje.Size = new System.Drawing.Size(132, 61);
            this.btn_AnularPasaje.TabIndex = 6;
            this.btn_AnularPasaje.Text = "Anular \r\nPasaje";
            this.btn_AnularPasaje.UseVisualStyleBackColor = true;
            // 
            // btn_ModificarPasaje
            // 
            this.btn_ModificarPasaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ModificarPasaje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ModificarPasaje.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ModificarPasaje.Location = new System.Drawing.Point(12, 161);
            this.btn_ModificarPasaje.Name = "btn_ModificarPasaje";
            this.btn_ModificarPasaje.Size = new System.Drawing.Size(132, 61);
            this.btn_ModificarPasaje.TabIndex = 5;
            this.btn_ModificarPasaje.Text = "Modificar Pasaje";
            this.btn_ModificarPasaje.UseVisualStyleBackColor = true;
            // 
            // btn_VenderPasaje
            // 
            this.btn_VenderPasaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_VenderPasaje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VenderPasaje.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_VenderPasaje.Location = new System.Drawing.Point(12, 12);
            this.btn_VenderPasaje.Name = "btn_VenderPasaje";
            this.btn_VenderPasaje.Size = new System.Drawing.Size(132, 61);
            this.btn_VenderPasaje.TabIndex = 4;
            this.btn_VenderPasaje.Text = "Vender Pasajes";
            this.btn_VenderPasaje.UseVisualStyleBackColor = true;
            this.btn_VenderPasaje.Click += new System.EventHandler(this.btn_VenderPasaje_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Salir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.Location = new System.Drawing.Point(12, 441);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(132, 61);
            this.btn_Salir.TabIndex = 8;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 490);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenuPasajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(762, 524);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_AnularPasaje);
            this.Controls.Add(this.btn_ModificarPasaje);
            this.Controls.Add(this.btn_VenderPasaje);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmMenuPasajes";
            this.Text = "FrmMenuPasajes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AnularPasaje;
        private System.Windows.Forms.Button btn_ModificarPasaje;
        private System.Windows.Forms.Button btn_VenderPasaje;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
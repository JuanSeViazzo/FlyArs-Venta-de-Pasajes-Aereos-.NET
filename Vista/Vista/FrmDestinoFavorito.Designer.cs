namespace Vista
{
    partial class FrmDestinoFavorito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDestinoFavorito));
            this.dgvDestinosFavoritos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinosFavoritos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDestinosFavoritos
            // 
            this.dgvDestinosFavoritos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDestinosFavoritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestinosFavoritos.Location = new System.Drawing.Point(52, 183);
            this.dgvDestinosFavoritos.Name = "dgvDestinosFavoritos";
            this.dgvDestinosFavoritos.ReadOnly = true;
            this.dgvDestinosFavoritos.RowTemplate.Height = 25;
            this.dgvDestinosFavoritos.Size = new System.Drawing.Size(1007, 255);
            this.dgvDestinosFavoritos.TabIndex = 1;
            // 
            // FrmDestinoFavorito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1129, 450);
            this.Controls.Add(this.dgvDestinosFavoritos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDestinoFavorito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Destinos y Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDestinoFavorito_FormClosing);
            this.Load += new System.EventHandler(this.FrmDestinoFavorito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinosFavoritos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDestinosFavoritos;
    }
}
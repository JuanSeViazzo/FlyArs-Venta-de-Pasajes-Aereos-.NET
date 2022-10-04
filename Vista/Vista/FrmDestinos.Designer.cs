namespace Vista
{
    partial class FrmDestinos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDestinos));
            this.mstAbmDestinos = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDestinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDestinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionDestinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstAbmDestinos.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstAbmDestinos
            // 
            this.mstAbmDestinos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mstAbmDestinos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.mstAbmDestinos.Location = new System.Drawing.Point(0, 0);
            this.mstAbmDestinos.Name = "mstAbmDestinos";
            this.mstAbmDestinos.Size = new System.Drawing.Size(613, 24);
            this.mstAbmDestinos.TabIndex = 0;
            this.mstAbmDestinos.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDestinoToolStripMenuItem,
            this.bajaDestinoToolStripMenuItem,
            this.modificacionDestinoToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // altaDestinoToolStripMenuItem
            // 
            this.altaDestinoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.altaDestinoToolStripMenuItem.Name = "altaDestinoToolStripMenuItem";
            this.altaDestinoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.altaDestinoToolStripMenuItem.Text = "Alta Destino";
            this.altaDestinoToolStripMenuItem.Click += new System.EventHandler(this.altaDestinoToolStripMenuItem_Click);
            // 
            // bajaDestinoToolStripMenuItem
            // 
            this.bajaDestinoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bajaDestinoToolStripMenuItem.Name = "bajaDestinoToolStripMenuItem";
            this.bajaDestinoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.bajaDestinoToolStripMenuItem.Text = "Baja Destino";
            this.bajaDestinoToolStripMenuItem.Click += new System.EventHandler(this.bajaDestinoToolStripMenuItem_Click);
            // 
            // modificacionDestinoToolStripMenuItem
            // 
            this.modificacionDestinoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.modificacionDestinoToolStripMenuItem.Name = "modificacionDestinoToolStripMenuItem";
            this.modificacionDestinoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.modificacionDestinoToolStripMenuItem.Text = "Modificacion Destino";
            this.modificacionDestinoToolStripMenuItem.Click += new System.EventHandler(this.modificacionDestinoToolStripMenuItem_Click);
            // 
            // FrmDestinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(613, 514);
            this.Controls.Add(this.mstAbmDestinos);
            this.MainMenuStrip = this.mstAbmDestinos;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDestinos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Destinos";
            this.mstAbmDestinos.ResumeLayout(false);
            this.mstAbmDestinos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstAbmDestinos;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDestinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaDestinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionDestinoToolStripMenuItem;
    }
}
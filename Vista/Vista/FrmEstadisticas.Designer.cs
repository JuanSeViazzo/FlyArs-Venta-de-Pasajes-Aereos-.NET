namespace Vista
{
    partial class FrmEstadisticas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.horasDeVueloPorAvionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destinosPorFacturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDePasajerosFrecuentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gananciasTotalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horaDeVueloDeCadaAeronaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horasDeVueloPorAvionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horasDeVueloPorAvionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1115, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // horasDeVueloPorAvionToolStripMenuItem
            // 
            this.horasDeVueloPorAvionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.destinosPorFacturacionToolStripMenuItem,
            this.listaDePasajerosFrecuentesToolStripMenuItem,
            this.gananciasTotalesToolStripMenuItem,
            this.horaDeVueloDeCadaAeronaveToolStripMenuItem,
            this.horasDeVueloPorAvionToolStripMenuItem1});
            this.horasDeVueloPorAvionToolStripMenuItem.Name = "horasDeVueloPorAvionToolStripMenuItem";
            this.horasDeVueloPorAvionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.horasDeVueloPorAvionToolStripMenuItem.Text = "Estadisticas";
            // 
            // destinosPorFacturacionToolStripMenuItem
            // 
            this.destinosPorFacturacionToolStripMenuItem.Name = "destinosPorFacturacionToolStripMenuItem";
            this.destinosPorFacturacionToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.destinosPorFacturacionToolStripMenuItem.Text = "Destinos por Facturacion";
            this.destinosPorFacturacionToolStripMenuItem.Click += new System.EventHandler(this.destinosPorFacturacionToolStripMenuItem_Click);
            // 
            // listaDePasajerosFrecuentesToolStripMenuItem
            // 
            this.listaDePasajerosFrecuentesToolStripMenuItem.Name = "listaDePasajerosFrecuentesToolStripMenuItem";
            this.listaDePasajerosFrecuentesToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.listaDePasajerosFrecuentesToolStripMenuItem.Text = "Lista de Pasajeros Frecuentes";
            // 
            // gananciasTotalesToolStripMenuItem
            // 
            this.gananciasTotalesToolStripMenuItem.Name = "gananciasTotalesToolStripMenuItem";
            this.gananciasTotalesToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.gananciasTotalesToolStripMenuItem.Text = "Ganancias Totales";
            // 
            // horaDeVueloDeCadaAeronaveToolStripMenuItem
            // 
            this.horaDeVueloDeCadaAeronaveToolStripMenuItem.Name = "horaDeVueloDeCadaAeronaveToolStripMenuItem";
            this.horaDeVueloDeCadaAeronaveToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.horaDeVueloDeCadaAeronaveToolStripMenuItem.Text = "Hora de Vuelo de cada aeronave";
            // 
            // horasDeVueloPorAvionToolStripMenuItem1
            // 
            this.horasDeVueloPorAvionToolStripMenuItem1.Name = "horasDeVueloPorAvionToolStripMenuItem1";
            this.horasDeVueloPorAvionToolStripMenuItem1.Size = new System.Drawing.Size(244, 22);
            this.horasDeVueloPorAvionToolStripMenuItem1.Text = "Horas De Vuelo por Avion";
            this.horasDeVueloPorAvionToolStripMenuItem1.Click += new System.EventHandler(this.horasDeVueloPorAvionToolStripMenuItem1_Click);
            // 
            // FrmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 548);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEstadisticas";
            this.Load += new System.EventHandler(this.FrmEstadisticas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem horasDeVueloPorAvionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destinosPorFacturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDePasajerosFrecuentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gananciasTotalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horaDeVueloDeCadaAeronaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horasDeVueloPorAvionToolStripMenuItem1;
    }
}
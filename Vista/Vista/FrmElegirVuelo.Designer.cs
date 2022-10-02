namespace Vista
{
    partial class FrmElegirVuelo
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
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.dgv_vuelos = new System.Windows.Forms.DataGridView();
            this.txtFiltroOrigen = new System.Windows.Forms.TextBox();
            this.txtFiltroDestino = new System.Windows.Forms.TextBox();
            this.txtFiltroFecha = new System.Windows.Forms.TextBox();
            this.btnSeleccionarVuelo = new System.Windows.Forms.Button();
            this.lblFechaDePartida = new System.Windows.Forms.Label();
            this.btnCargarVuelo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(12, 290);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(38, 15);
            this.lblOrigen.TabIndex = 3;
            this.lblOrigen.Text = "label1";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(208, 290);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(38, 15);
            this.lblDestino.TabIndex = 4;
            this.lblDestino.Text = "label2";
            // 
            // dgv_vuelos
            // 
            this.dgv_vuelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_vuelos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_vuelos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_vuelos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_vuelos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_vuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vuelos.GridColor = System.Drawing.Color.Red;
            this.dgv_vuelos.Location = new System.Drawing.Point(12, 337);
            this.dgv_vuelos.Name = "dgv_vuelos";
            this.dgv_vuelos.ReadOnly = true;
            this.dgv_vuelos.RowTemplate.Height = 25;
            this.dgv_vuelos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_vuelos.Size = new System.Drawing.Size(1455, 251);
            this.dgv_vuelos.TabIndex = 5;
            this.dgv_vuelos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellContentDoubleClick);
            // 
            // txtFiltroOrigen
            // 
            this.txtFiltroOrigen.Location = new System.Drawing.Point(12, 308);
            this.txtFiltroOrigen.Name = "txtFiltroOrigen";
            this.txtFiltroOrigen.Size = new System.Drawing.Size(190, 23);
            this.txtFiltroOrigen.TabIndex = 6;
            this.txtFiltroOrigen.TextChanged += new System.EventHandler(this.txtFiltroOrigen_TextChanged);
            // 
            // txtFiltroDestino
            // 
            this.txtFiltroDestino.Location = new System.Drawing.Point(208, 308);
            this.txtFiltroDestino.Name = "txtFiltroDestino";
            this.txtFiltroDestino.Size = new System.Drawing.Size(190, 23);
            this.txtFiltroDestino.TabIndex = 7;
            this.txtFiltroDestino.TextChanged += new System.EventHandler(this.txtFiltroOrigen_TextChanged);
            // 
            // txtFiltroFecha
            // 
            this.txtFiltroFecha.Location = new System.Drawing.Point(404, 308);
            this.txtFiltroFecha.Name = "txtFiltroFecha";
            this.txtFiltroFecha.Size = new System.Drawing.Size(190, 23);
            this.txtFiltroFecha.TabIndex = 8;
            this.txtFiltroFecha.TextChanged += new System.EventHandler(this.txtFiltroOrigen_TextChanged);
            // 
            // btnSeleccionarVuelo
            // 
            this.btnSeleccionarVuelo.Location = new System.Drawing.Point(600, 307);
            this.btnSeleccionarVuelo.Name = "btnSeleccionarVuelo";
            this.btnSeleccionarVuelo.Size = new System.Drawing.Size(108, 23);
            this.btnSeleccionarVuelo.TabIndex = 9;
            this.btnSeleccionarVuelo.Text = "Seleccionar Vuelo";
            this.btnSeleccionarVuelo.UseVisualStyleBackColor = true;
            this.btnSeleccionarVuelo.Click += new System.EventHandler(this.btnSeleccionarVuelo_Click_1);
            // 
            // lblFechaDePartida
            // 
            this.lblFechaDePartida.AutoSize = true;
            this.lblFechaDePartida.Location = new System.Drawing.Point(404, 290);
            this.lblFechaDePartida.Name = "lblFechaDePartida";
            this.lblFechaDePartida.Size = new System.Drawing.Size(38, 15);
            this.lblFechaDePartida.TabIndex = 12;
            this.lblFechaDePartida.Text = "label3";
            // 
            // btnCargarVuelo
            // 
            this.btnCargarVuelo.Location = new System.Drawing.Point(600, 307);
            this.btnCargarVuelo.Name = "btnCargarVuelo";
            this.btnCargarVuelo.Size = new System.Drawing.Size(108, 23);
            this.btnCargarVuelo.TabIndex = 13;
            this.btnCargarVuelo.Text = "Cargar Vuelo";
            this.btnCargarVuelo.UseVisualStyleBackColor = true;
            this.btnCargarVuelo.Click += new System.EventHandler(this.btnCargarVuelo_Click);
            // 
            // FrmElegirVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 600);
            this.Controls.Add(this.btnCargarVuelo);
            this.Controls.Add(this.lblFechaDePartida);
            this.Controls.Add(this.btnSeleccionarVuelo);
            this.Controls.Add(this.txtFiltroFecha);
            this.Controls.Add(this.txtFiltroDestino);
            this.Controls.Add(this.txtFiltroOrigen);
            this.Controls.Add(this.dgv_vuelos);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblOrigen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmElegirVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elegir Vuelo";
            this.Load += new System.EventHandler(this.FrmElegirVuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.DataGridView dgv_vuelos;
        private System.Windows.Forms.TextBox txtFiltroOrigen;
        private System.Windows.Forms.TextBox txtFiltroDestino;
        private System.Windows.Forms.TextBox txtFiltroFecha;
        private System.Windows.Forms.Button btnSeleccionarVuelo;
        private System.Windows.Forms.Label lblFechaDePartida;
        private System.Windows.Forms.Button btnCargarVuelo;
    }
}
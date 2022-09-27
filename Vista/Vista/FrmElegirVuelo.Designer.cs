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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.txtFiltroOrigen = new System.Windows.Forms.TextBox();
            this.txtFiltroDestino = new System.Windows.Forms.TextBox();
            this.txtFiltroFecha = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_clientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_clientes.BackgroundColor = System.Drawing.Color.White;
            this.dgv_clientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.GridColor = System.Drawing.Color.Red;
            this.dgv_clientes.Location = new System.Drawing.Point(12, 337);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.RowTemplate.Height = 25;
            this.dgv_clientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_clientes.Size = new System.Drawing.Size(1455, 251);
            this.dgv_clientes.TabIndex = 5;
            this.dgv_clientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellContentDoubleClick);
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
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(714, 307);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(108, 23);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Seleccionar Vuelo";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Limpiar Filtro";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmElegirVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtFiltroFecha);
            this.Controls.Add(this.txtFiltroDestino);
            this.Controls.Add(this.txtFiltroOrigen);
            this.Controls.Add(this.dgv_clientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmElegirVuelo";
            this.Text = "FrmElegirVuelo";
            this.Load += new System.EventHandler(this.FrmElegirVuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.TextBox txtFiltroOrigen;
        private System.Windows.Forms.TextBox txtFiltroDestino;
        private System.Windows.Forms.TextBox txtFiltroFecha;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button button1;
    }
}
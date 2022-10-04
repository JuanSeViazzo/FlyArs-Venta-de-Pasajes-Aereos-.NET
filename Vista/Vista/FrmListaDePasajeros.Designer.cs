namespace Vista
{
    partial class FrmListaDePasajeros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaDePasajeros));
            this.dgvPasajeros = new System.Windows.Forms.DataGridView();
            this.txt_filtroNombre = new System.Windows.Forms.TextBox();
            this.txt_FiltroDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPasajeros
            // 
            this.dgvPasajeros.BackgroundColor = System.Drawing.Color.White;
            this.dgvPasajeros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPasajeros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasajeros.GridColor = System.Drawing.Color.Red;
            this.dgvPasajeros.Location = new System.Drawing.Point(12, 343);
            this.dgvPasajeros.Name = "dgvPasajeros";
            this.dgvPasajeros.ReadOnly = true;
            this.dgvPasajeros.RowTemplate.Height = 25;
            this.dgvPasajeros.Size = new System.Drawing.Size(1076, 277);
            this.dgvPasajeros.TabIndex = 0;
            this.dgvPasajeros.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellContentDoubleClick);
            // 
            // txt_filtroNombre
            // 
            this.txt_filtroNombre.Location = new System.Drawing.Point(438, 314);
            this.txt_filtroNombre.Name = "txt_filtroNombre";
            this.txt_filtroNombre.Size = new System.Drawing.Size(129, 23);
            this.txt_filtroNombre.TabIndex = 2;
            this.txt_filtroNombre.TextChanged += new System.EventHandler(this.txt_filtroNombre_TextChanged);
            // 
            // txt_FiltroDNI
            // 
            this.txt_FiltroDNI.Location = new System.Drawing.Point(613, 314);
            this.txt_FiltroDNI.Name = "txt_FiltroDNI";
            this.txt_FiltroDNI.Size = new System.Drawing.Size(129, 23);
            this.txt_FiltroDNI.TabIndex = 3;
            this.txt_FiltroDNI.TextChanged += new System.EventHandler(this.txt_FiltroDNI_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(627, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Busqueda por DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Busqueda por Nacionalidad";
            // 
            // FrmListaDePasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1100, 661);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_FiltroDNI);
            this.Controls.Add(this.txt_filtroNombre);
            this.Controls.Add(this.dgvPasajeros);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListaDePasajeros";
            this.Text = "Listado de Pasajeros";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPasajeros;
        private System.Windows.Forms.TextBox txt_filtroNombre;
        private System.Windows.Forms.TextBox txt_FiltroDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
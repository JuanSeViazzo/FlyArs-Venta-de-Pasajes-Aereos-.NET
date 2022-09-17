namespace Vista
{
    partial class FrmClientes
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
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.txt_filtroNombre = new System.Windows.Forms.TextBox();
            this.txt_FiltroDNI = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.BackgroundColor = System.Drawing.Color.White;
            this.dgv_clientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.GridColor = System.Drawing.Color.Red;
            this.dgv_clientes.Location = new System.Drawing.Point(2, 307);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.RowTemplate.Height = 25;
            this.dgv_clientes.Size = new System.Drawing.Size(1097, 354);
            this.dgv_clientes.TabIndex = 0;
            this.dgv_clientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellContentDoubleClick);
            // 
            // txt_filtroNombre
            // 
            this.txt_filtroNombre.Location = new System.Drawing.Point(706, 278);
            this.txt_filtroNombre.Name = "txt_filtroNombre";
            this.txt_filtroNombre.Size = new System.Drawing.Size(129, 23);
            this.txt_filtroNombre.TabIndex = 2;
            this.txt_filtroNombre.TextChanged += new System.EventHandler(this.txt_filtroNombre_TextChanged);
            // 
            // txt_FiltroDNI
            // 
            this.txt_FiltroDNI.Location = new System.Drawing.Point(959, 278);
            this.txt_FiltroDNI.Name = "txt_FiltroDNI";
            this.txt_FiltroDNI.Size = new System.Drawing.Size(129, 23);
            this.txt_FiltroDNI.TabIndex = 3;
            this.txt_FiltroDNI.TextChanged += new System.EventHandler(this.txt_FiltroDNI_TextChanged);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 661);
            this.Controls.Add(this.txt_FiltroDNI);
            this.Controls.Add(this.txt_filtroNombre);
            this.Controls.Add(this.dgv_clientes);
            this.Name = "FrmClientes";
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.TextBox txt_filtroNombre;
        private System.Windows.Forms.TextBox txt_FiltroDNI;
    }
}
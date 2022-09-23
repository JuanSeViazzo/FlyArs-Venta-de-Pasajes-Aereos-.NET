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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVenderPasaje = new System.Windows.Forms.Button();
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
            this.txt_FiltroDNI.Location = new System.Drawing.Point(922, 277);
            this.txt_FiltroDNI.Name = "txt_FiltroDNI";
            this.txt_FiltroDNI.Size = new System.Drawing.Size(129, 23);
            this.txt_FiltroDNI.TabIndex = 3;
            this.txt_FiltroDNI.TextChanged += new System.EventHandler(this.txt_FiltroDNI_TextChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(12, 277);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(93, 277);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(922, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Busqueda por DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(706, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Busqueda por Nacionalidad";
            // 
            // btnVenderPasaje
            // 
            this.btnVenderPasaje.BackColor = System.Drawing.Color.White;
            this.btnVenderPasaje.Location = new System.Drawing.Point(174, 278);
            this.btnVenderPasaje.Name = "btnVenderPasaje";
            this.btnVenderPasaje.Size = new System.Drawing.Size(91, 23);
            this.btnVenderPasaje.TabIndex = 8;
            this.btnVenderPasaje.Text = "Vender Pasaje";
            this.btnVenderPasaje.UseVisualStyleBackColor = false;
            this.btnVenderPasaje.Click += new System.EventHandler(this.btnVenderPasaje_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 661);
            this.Controls.Add(this.btnVenderPasaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
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
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVenderPasaje;
    }
}
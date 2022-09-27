namespace Vista
{
    partial class FrmCargarEquipaje
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
            this.nmrSegundoEquipaje = new System.Windows.Forms.NumericUpDown();
            this.nmrPrimerEquipaje = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrDeMano = new System.Windows.Forms.NumericUpDown();
            this.rtbCliente = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSegundoEquipaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrimerEquipaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDeMano)).BeginInit();
            this.SuspendLayout();
            // 
            // nmrSegundoEquipaje
            // 
            this.nmrSegundoEquipaje.BackColor = System.Drawing.Color.White;
            this.nmrSegundoEquipaje.Location = new System.Drawing.Point(392, 228);
            this.nmrSegundoEquipaje.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nmrSegundoEquipaje.Name = "nmrSegundoEquipaje";
            this.nmrSegundoEquipaje.Size = new System.Drawing.Size(39, 23);
            this.nmrSegundoEquipaje.TabIndex = 47;
            // 
            // nmrPrimerEquipaje
            // 
            this.nmrPrimerEquipaje.BackColor = System.Drawing.Color.White;
            this.nmrPrimerEquipaje.Location = new System.Drawing.Point(392, 175);
            this.nmrPrimerEquipaje.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nmrPrimerEquipaje.Name = "nmrPrimerEquipaje";
            this.nmrPrimerEquipaje.Size = new System.Drawing.Size(39, 23);
            this.nmrPrimerEquipaje.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "2do Equipaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "1er Equipaje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "Equipaje de Mano";
            // 
            // nmrDeMano
            // 
            this.nmrDeMano.BackColor = System.Drawing.Color.White;
            this.nmrDeMano.Location = new System.Drawing.Point(392, 119);
            this.nmrDeMano.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrDeMano.Name = "nmrDeMano";
            this.nmrDeMano.Size = new System.Drawing.Size(39, 23);
            this.nmrDeMano.TabIndex = 42;
            // 
            // rtbCliente
            // 
            this.rtbCliente.Location = new System.Drawing.Point(12, 98);
            this.rtbCliente.Name = "rtbCliente";
            this.rtbCliente.Size = new System.Drawing.Size(277, 246);
            this.rtbCliente.TabIndex = 48;
            this.rtbCliente.Text = "";
            // 
            // FrmCargarEquipaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbCliente);
            this.Controls.Add(this.nmrSegundoEquipaje);
            this.Controls.Add(this.nmrPrimerEquipaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmrDeMano);
            this.Name = "FrmCargarEquipaje";
            this.Text = "FrmCargarEquipaje";
            ((System.ComponentModel.ISupportInitialize)(this.nmrSegundoEquipaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrimerEquipaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDeMano)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmrSegundoEquipaje;
        private System.Windows.Forms.NumericUpDown nmrPrimerEquipaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrDeMano;
        private System.Windows.Forms.RichTextBox rtbCliente;
    }
}
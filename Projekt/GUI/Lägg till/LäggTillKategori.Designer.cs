namespace GUI
{
    partial class LäggTillKategori
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
            this.txtLäggTillKategori = new System.Windows.Forms.TextBox();
            this.btnLäggTillKategori = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLäggTillKategori
            // 
            this.txtLäggTillKategori.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtLäggTillKategori.Location = new System.Drawing.Point(13, 39);
            this.txtLäggTillKategori.Name = "txtLäggTillKategori";
            this.txtLäggTillKategori.Size = new System.Drawing.Size(182, 20);
            this.txtLäggTillKategori.TabIndex = 0;
            // 
            // btnLäggTillKategori
            // 
            this.btnLäggTillKategori.Location = new System.Drawing.Point(215, 37);
            this.btnLäggTillKategori.Name = "btnLäggTillKategori";
            this.btnLäggTillKategori.Size = new System.Drawing.Size(87, 23);
            this.btnLäggTillKategori.TabIndex = 1;
            this.btnLäggTillKategori.Text = "Lägg till";
            this.btnLäggTillKategori.UseVisualStyleBackColor = true;
            this.btnLäggTillKategori.Click += new System.EventHandler(this.btnLäggTillKategori_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lägg till kategori:";
            // 
            // LäggTillKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(318, 92);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLäggTillKategori);
            this.Controls.Add(this.txtLäggTillKategori);
            this.Name = "LäggTillKategori";
            this.Text = "Lägg till kategori";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLäggTillKategori;
        private System.Windows.Forms.Button btnLäggTillKategori;
        private System.Windows.Forms.Label label1;
    }
}
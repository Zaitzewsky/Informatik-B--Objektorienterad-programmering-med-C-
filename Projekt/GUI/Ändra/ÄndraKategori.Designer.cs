namespace GUI
{
    partial class ÄndraKategori
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
            this.cbKategorier = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnÄndraKategori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbKategorier
            // 
            this.cbKategorier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategorier.FormattingEnabled = true;
            this.cbKategorier.Location = new System.Drawing.Point(12, 33);
            this.cbKategorier.Name = "cbKategorier";
            this.cbKategorier.Size = new System.Drawing.Size(200, 21);
            this.cbKategorier.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Välj kategori:";
            // 
            // txtKategori
            // 
            this.txtKategori.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtKategori.Location = new System.Drawing.Point(16, 92);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(196, 20);
            this.txtKategori.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ändra kategori:";
            // 
            // btnÄndraKategori
            // 
            this.btnÄndraKategori.Location = new System.Drawing.Point(136, 130);
            this.btnÄndraKategori.Name = "btnÄndraKategori";
            this.btnÄndraKategori.Size = new System.Drawing.Size(75, 23);
            this.btnÄndraKategori.TabIndex = 4;
            this.btnÄndraKategori.Text = "Ändra";
            this.btnÄndraKategori.UseVisualStyleBackColor = true;
            this.btnÄndraKategori.Click += new System.EventHandler(this.btnÄndraKategori_Click);
            // 
            // ÄndraKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(231, 227);
            this.Controls.Add(this.btnÄndraKategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKategorier);
            this.Name = "ÄndraKategori";
            this.Text = "Ändra kategori";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKategorier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnÄndraKategori;
    }
}
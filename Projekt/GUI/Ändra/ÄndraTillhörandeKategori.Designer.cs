namespace GUI
{
    partial class ÄndraTillhörandeKategori
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
            this.btnUppdatera = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPodcast = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.cbNyKategori = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnUppdatera
            // 
            this.btnUppdatera.Location = new System.Drawing.Point(131, 186);
            this.btnUppdatera.Name = "btnUppdatera";
            this.btnUppdatera.Size = new System.Drawing.Size(75, 23);
            this.btnUppdatera.TabIndex = 13;
            this.btnUppdatera.Text = "Uppdatera";
            this.btnUppdatera.UseVisualStyleBackColor = true;
            this.btnUppdatera.Click += new System.EventHandler(this.btnUppdatera_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ny kategori:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Välj podcast:";
            // 
            // cbPodcast
            // 
            this.cbPodcast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPodcast.FormattingEnabled = true;
            this.cbPodcast.Location = new System.Drawing.Point(12, 95);
            this.cbPodcast.Name = "cbPodcast";
            this.cbPodcast.Size = new System.Drawing.Size(194, 21);
            this.cbPodcast.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Välj kategori:";
            // 
            // cbKategori
            // 
            this.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(12, 39);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(194, 21);
            this.cbKategori.TabIndex = 7;
            this.cbKategori.SelectedIndexChanged += new System.EventHandler(this.cbKategori_SelectedIndexChanged);
            // 
            // cbNyKategori
            // 
            this.cbNyKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNyKategori.FormattingEnabled = true;
            this.cbNyKategori.Location = new System.Drawing.Point(12, 145);
            this.cbNyKategori.Name = "cbNyKategori";
            this.cbNyKategori.Size = new System.Drawing.Size(194, 21);
            this.cbNyKategori.TabIndex = 14;
            // 
            // ÄndraTillhörandeKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(219, 239);
            this.Controls.Add(this.cbNyKategori);
            this.Controls.Add(this.btnUppdatera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPodcast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKategori);
            this.Name = "ÄndraTillhörandeKategori";
            this.Text = "Ändra kategori";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUppdatera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPodcast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.ComboBox cbNyKategori;
    }
}
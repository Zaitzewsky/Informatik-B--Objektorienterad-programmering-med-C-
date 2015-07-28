namespace GUI
{
    partial class ÄndraURL
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
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPodcast = new System.Windows.Forms.ComboBox();
            this.txtNyUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUppdatera = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbIntervall = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbKategori
            // 
            this.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(12, 28);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(194, 21);
            this.cbKategori.TabIndex = 0;
            this.cbKategori.SelectedIndexChanged += new System.EventHandler(this.cbKategori_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Välj kategori:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Välj podcast:";
            // 
            // cbPodcast
            // 
            this.cbPodcast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPodcast.FormattingEnabled = true;
            this.cbPodcast.Location = new System.Drawing.Point(12, 84);
            this.cbPodcast.Name = "cbPodcast";
            this.cbPodcast.Size = new System.Drawing.Size(194, 21);
            this.cbPodcast.TabIndex = 2;
            // 
            // txtNyUrl
            // 
            this.txtNyUrl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNyUrl.Location = new System.Drawing.Point(13, 132);
            this.txtNyUrl.Name = "txtNyUrl";
            this.txtNyUrl.Size = new System.Drawing.Size(193, 20);
            this.txtNyUrl.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ny url:";
            // 
            // btnUppdatera
            // 
            this.btnUppdatera.Location = new System.Drawing.Point(131, 223);
            this.btnUppdatera.Name = "btnUppdatera";
            this.btnUppdatera.Size = new System.Drawing.Size(75, 23);
            this.btnUppdatera.TabIndex = 6;
            this.btnUppdatera.Text = "Uppdatera";
            this.btnUppdatera.UseVisualStyleBackColor = true;
            this.btnUppdatera.Click += new System.EventHandler(this.btnUppdatera_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ny intervall:";
            // 
            // cbIntervall
            // 
            this.cbIntervall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIntervall.FormattingEnabled = true;
            this.cbIntervall.Location = new System.Drawing.Point(12, 185);
            this.cbIntervall.Name = "cbIntervall";
            this.cbIntervall.Size = new System.Drawing.Size(194, 21);
            this.cbIntervall.TabIndex = 7;
            // 
            // ÄndraURL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(236, 286);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbIntervall);
            this.Controls.Add(this.btnUppdatera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNyUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPodcast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKategori);
            this.Name = "ÄndraURL";
            this.Text = "Ändra URL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPodcast;
        private System.Windows.Forms.TextBox txtNyUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUppdatera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbIntervall;
    }
}
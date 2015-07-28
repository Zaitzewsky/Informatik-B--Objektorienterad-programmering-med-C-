namespace GUI
{
    partial class LäggTillPodcast
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
            this.txtLäggTillKategori = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.btnSkapaPrenumeration = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBekräfta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbIntervall = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbKategorier
            // 
            this.cbKategorier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategorier.FormattingEnabled = true;
            this.cbKategorier.Location = new System.Drawing.Point(105, 69);
            this.cbKategorier.Name = "cbKategorier";
            this.cbKategorier.Size = new System.Drawing.Size(237, 21);
            this.cbKategorier.TabIndex = 0;
            // 
            // txtLäggTillKategori
            // 
            this.txtLäggTillKategori.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtLäggTillKategori.Location = new System.Drawing.Point(105, 38);
            this.txtLäggTillKategori.Name = "txtLäggTillKategori";
            this.txtLäggTillKategori.Size = new System.Drawing.Size(237, 20);
            this.txtLäggTillKategori.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lägg till kategori:";
            // 
            // txtUrl
            // 
            this.txtUrl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtUrl.Location = new System.Drawing.Point(105, 12);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(340, 20);
            this.txtUrl.TabIndex = 4;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(38, 12);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(58, 13);
            this.lblUrl.TabIndex = 5;
            this.lblUrl.Text = "RSS-flöde:";
            // 
            // btnSkapaPrenumeration
            // 
            this.btnSkapaPrenumeration.Location = new System.Drawing.Point(105, 141);
            this.btnSkapaPrenumeration.Name = "btnSkapaPrenumeration";
            this.btnSkapaPrenumeration.Size = new System.Drawing.Size(237, 93);
            this.btnSkapaPrenumeration.TabIndex = 10;
            this.btnSkapaPrenumeration.Text = "Skapa prenumeration";
            this.btnSkapaPrenumeration.UseVisualStyleBackColor = true;
            this.btnSkapaPrenumeration.Click += new System.EventHandler(this.btnSkapaPrenumeration_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Välj kategori:";
            // 
            // btnBekräfta
            // 
            this.btnBekräfta.Location = new System.Drawing.Point(348, 38);
            this.btnBekräfta.Name = "btnBekräfta";
            this.btnBekräfta.Size = new System.Drawing.Size(97, 23);
            this.btnBekräfta.TabIndex = 12;
            this.btnBekräfta.Text = "Bekräfta";
            this.btnBekräfta.UseVisualStyleBackColor = true;
            this.btnBekräfta.Click += new System.EventHandler(this.btnBekräfta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Intervall:";
            // 
            // cbIntervall
            // 
            this.cbIntervall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIntervall.FormattingEnabled = true;
            this.cbIntervall.Location = new System.Drawing.Point(105, 103);
            this.cbIntervall.Name = "cbIntervall";
            this.cbIntervall.Size = new System.Drawing.Size(237, 21);
            this.cbIntervall.TabIndex = 15;
            // 
            // LäggTillPodcast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(473, 289);
            this.Controls.Add(this.cbIntervall);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBekräfta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSkapaPrenumeration);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLäggTillKategori);
            this.Controls.Add(this.cbKategorier);
            this.Name = "LäggTillPodcast";
            this.Text = "Lägg till podcast";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKategorier;
        private System.Windows.Forms.TextBox txtLäggTillKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Button btnSkapaPrenumeration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBekräfta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbIntervall;
    }
}
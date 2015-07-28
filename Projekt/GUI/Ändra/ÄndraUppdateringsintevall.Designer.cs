namespace GUI
{
    partial class ÄndraUppdateringsintevall
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
            this.cbNyIntervall = new System.Windows.Forms.ComboBox();
            this.btnUppdatera = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPodcast = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbNyIntervall
            // 
            this.cbNyIntervall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNyIntervall.FormattingEnabled = true;
            this.cbNyIntervall.Location = new System.Drawing.Point(12, 142);
            this.cbNyIntervall.Name = "cbNyIntervall";
            this.cbNyIntervall.Size = new System.Drawing.Size(194, 21);
            this.cbNyIntervall.TabIndex = 21;
            // 
            // btnUppdatera
            // 
            this.btnUppdatera.Location = new System.Drawing.Point(131, 183);
            this.btnUppdatera.Name = "btnUppdatera";
            this.btnUppdatera.Size = new System.Drawing.Size(75, 23);
            this.btnUppdatera.TabIndex = 20;
            this.btnUppdatera.Text = "Uppdatera";
            this.btnUppdatera.UseVisualStyleBackColor = true;
            this.btnUppdatera.Click += new System.EventHandler(this.btnUppdatera_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Välj ny intervall:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Välj podcast:";
            // 
            // cbPodcast
            // 
            this.cbPodcast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPodcast.FormattingEnabled = true;
            this.cbPodcast.Location = new System.Drawing.Point(12, 92);
            this.cbPodcast.Name = "cbPodcast";
            this.cbPodcast.Size = new System.Drawing.Size(194, 21);
            this.cbPodcast.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Välj kategori:";
            // 
            // cbKategori
            // 
            this.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(12, 36);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(194, 21);
            this.cbKategori.TabIndex = 15;
            this.cbKategori.SelectedIndexChanged += new System.EventHandler(this.cbKategori_SelectedIndexChanged);
            // 
            // ÄndraUppdateringsintevall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(220, 235);
            this.Controls.Add(this.cbNyIntervall);
            this.Controls.Add(this.btnUppdatera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPodcast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKategori);
            this.Name = "ÄndraUppdateringsintevall";
            this.Text = "Ändra intevall";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNyIntervall;
        private System.Windows.Forms.Button btnUppdatera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPodcast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKategori;

    }
}
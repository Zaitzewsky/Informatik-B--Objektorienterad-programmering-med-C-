namespace GUI
{
    partial class TaBortPodcast
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbPodcasts = new System.Windows.Forms.ComboBox();
            this.btnTaBortPodcast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbKategorier
            // 
            this.cbKategorier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategorier.FormattingEnabled = true;
            this.cbKategorier.Location = new System.Drawing.Point(12, 26);
            this.cbKategorier.Name = "cbKategorier";
            this.cbKategorier.Size = new System.Drawing.Size(179, 21);
            this.cbKategorier.TabIndex = 0;
            this.cbKategorier.SelectedIndexChanged += new System.EventHandler(this.cbKategorier_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Välj kategori:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Välj podcast:";
            // 
            // cbPodcasts
            // 
            this.cbPodcasts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPodcasts.FormattingEnabled = true;
            this.cbPodcasts.Location = new System.Drawing.Point(12, 83);
            this.cbPodcasts.Name = "cbPodcasts";
            this.cbPodcasts.Size = new System.Drawing.Size(179, 21);
            this.cbPodcasts.TabIndex = 2;
            // 
            // btnTaBortPodcast
            // 
            this.btnTaBortPodcast.Location = new System.Drawing.Point(83, 127);
            this.btnTaBortPodcast.Name = "btnTaBortPodcast";
            this.btnTaBortPodcast.Size = new System.Drawing.Size(108, 23);
            this.btnTaBortPodcast.TabIndex = 4;
            this.btnTaBortPodcast.Text = "Ta bort podcast";
            this.btnTaBortPodcast.UseVisualStyleBackColor = true;
            this.btnTaBortPodcast.Click += new System.EventHandler(this.btnTaBortPodcast_Click);
            // 
            // TaBortPodcast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(211, 248);
            this.Controls.Add(this.btnTaBortPodcast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPodcasts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKategorier);
            this.Name = "TaBortPodcast";
            this.Text = "Ta bort podcast";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKategorier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPodcasts;
        private System.Windows.Forms.Button btnTaBortPodcast;
    }
}
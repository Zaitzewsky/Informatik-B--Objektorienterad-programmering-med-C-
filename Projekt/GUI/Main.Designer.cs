namespace GUI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lbPodcasts = new System.Windows.Forms.ListBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.cbKategorier = new System.Windows.Forms.ComboBox();
            this.cbPodcasts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLäggTillPodcast = new System.Windows.Forms.Button();
            this.btnLäggTillKategori = new System.Windows.Forms.Button();
            this.btnTaBortPodcast = new System.Windows.Forms.Button();
            this.btnÄndraKategori = new System.Windows.Forms.Button();
            this.btnÄndraPodcast = new System.Windows.Forms.Button();
            this.btnTaBortKategori = new System.Windows.Forms.Button();
            this.btnBeskrivning = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPodcasts
            // 
            this.lbPodcasts.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbPodcasts.FormattingEnabled = true;
            this.lbPodcasts.Location = new System.Drawing.Point(12, 30);
            this.lbPodcasts.Name = "lbPodcasts";
            this.lbPodcasts.Size = new System.Drawing.Size(258, 199);
            this.lbPodcasts.TabIndex = 3;
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPause.BackgroundImage")));
            this.btnPause.Location = new System.Drawing.Point(157, 267);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(113, 65);
            this.btnPause.TabIndex = 7;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(12, 233);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(139, 99);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // cbKategorier
            // 
            this.cbKategorier.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbKategorier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategorier.FormattingEnabled = true;
            this.cbKategorier.Location = new System.Drawing.Point(312, 29);
            this.cbKategorier.Name = "cbKategorier";
            this.cbKategorier.Size = new System.Drawing.Size(169, 21);
            this.cbKategorier.TabIndex = 9;
            this.cbKategorier.SelectedIndexChanged += new System.EventHandler(this.cbKategorier_SelectedIndexChanged);
            // 
            // cbPodcasts
            // 
            this.cbPodcasts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPodcasts.FormattingEnabled = true;
            this.cbPodcasts.Location = new System.Drawing.Point(312, 76);
            this.cbPodcasts.Name = "cbPodcasts";
            this.cbPodcasts.Size = new System.Drawing.Size(169, 21);
            this.cbPodcasts.TabIndex = 10;
            this.cbPodcasts.SelectedIndexChanged += new System.EventHandler(this.cbPodcasts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Avsnitt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kategorier:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Podcasts:";
            // 
            // btnLäggTillPodcast
            // 
            this.btnLäggTillPodcast.Location = new System.Drawing.Point(312, 117);
            this.btnLäggTillPodcast.Name = "btnLäggTillPodcast";
            this.btnLäggTillPodcast.Size = new System.Drawing.Size(72, 45);
            this.btnLäggTillPodcast.TabIndex = 14;
            this.btnLäggTillPodcast.Text = "Lägg till podcast";
            this.btnLäggTillPodcast.UseVisualStyleBackColor = true;
            this.btnLäggTillPodcast.Click += new System.EventHandler(this.btnLäggTillPodcast_Click);
            // 
            // btnLäggTillKategori
            // 
            this.btnLäggTillKategori.Location = new System.Drawing.Point(410, 117);
            this.btnLäggTillKategori.Name = "btnLäggTillKategori";
            this.btnLäggTillKategori.Size = new System.Drawing.Size(71, 45);
            this.btnLäggTillKategori.TabIndex = 15;
            this.btnLäggTillKategori.Text = "Lägg till kategori";
            this.btnLäggTillKategori.UseVisualStyleBackColor = true;
            this.btnLäggTillKategori.Click += new System.EventHandler(this.btnLäggTillKategori_Click);
            // 
            // btnTaBortPodcast
            // 
            this.btnTaBortPodcast.Location = new System.Drawing.Point(315, 250);
            this.btnTaBortPodcast.Name = "btnTaBortPodcast";
            this.btnTaBortPodcast.Size = new System.Drawing.Size(72, 45);
            this.btnTaBortPodcast.TabIndex = 16;
            this.btnTaBortPodcast.Text = "Ta bort podcast";
            this.btnTaBortPodcast.UseVisualStyleBackColor = true;
            this.btnTaBortPodcast.Click += new System.EventHandler(this.btnTaBortPodcast_Click);
            // 
            // btnÄndraKategori
            // 
            this.btnÄndraKategori.Location = new System.Drawing.Point(410, 183);
            this.btnÄndraKategori.Name = "btnÄndraKategori";
            this.btnÄndraKategori.Size = new System.Drawing.Size(72, 45);
            this.btnÄndraKategori.TabIndex = 17;
            this.btnÄndraKategori.Text = "Ändra kategori";
            this.btnÄndraKategori.UseVisualStyleBackColor = true;
            this.btnÄndraKategori.Click += new System.EventHandler(this.btnÄndraKategori_Click);
            // 
            // btnÄndraPodcast
            // 
            this.btnÄndraPodcast.Location = new System.Drawing.Point(315, 183);
            this.btnÄndraPodcast.Name = "btnÄndraPodcast";
            this.btnÄndraPodcast.Size = new System.Drawing.Size(72, 45);
            this.btnÄndraPodcast.TabIndex = 18;
            this.btnÄndraPodcast.Text = "Ändra podcast";
            this.btnÄndraPodcast.UseVisualStyleBackColor = true;
            this.btnÄndraPodcast.Click += new System.EventHandler(this.btnÄndraPodcast_Click);
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Location = new System.Drawing.Point(410, 250);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(72, 45);
            this.btnTaBortKategori.TabIndex = 19;
            this.btnTaBortKategori.Text = "Ta bort kategori";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            this.btnTaBortKategori.Click += new System.EventHandler(this.btnTaBortKategori_Click);
            // 
            // btnBeskrivning
            // 
            this.btnBeskrivning.Location = new System.Drawing.Point(157, 235);
            this.btnBeskrivning.Name = "btnBeskrivning";
            this.btnBeskrivning.Size = new System.Drawing.Size(113, 23);
            this.btnBeskrivning.TabIndex = 21;
            this.btnBeskrivning.Text = "Beskrivning";
            this.btnBeskrivning.UseVisualStyleBackColor = true;
            this.btnBeskrivning.Click += new System.EventHandler(this.btnBeskrivning_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(500, 343);
            this.Controls.Add(this.btnBeskrivning);
            this.Controls.Add(this.btnTaBortKategori);
            this.Controls.Add(this.btnÄndraPodcast);
            this.Controls.Add(this.btnÄndraKategori);
            this.Controls.Add(this.btnTaBortPodcast);
            this.Controls.Add(this.btnLäggTillKategori);
            this.Controls.Add(this.btnLäggTillPodcast);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPodcasts);
            this.Controls.Add(this.cbKategorier);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lbPodcasts);
            this.Name = "Main";
            this.Text = "Podcastspelare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPodcasts;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ComboBox cbKategorier;
        private System.Windows.Forms.ComboBox cbPodcasts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLäggTillPodcast;
        private System.Windows.Forms.Button btnLäggTillKategori;
        private System.Windows.Forms.Button btnTaBortPodcast;
        private System.Windows.Forms.Button btnÄndraKategori;
        private System.Windows.Forms.Button btnÄndraPodcast;
        private System.Windows.Forms.Button btnTaBortKategori;
        private System.Windows.Forms.Button btnBeskrivning;
    }
}


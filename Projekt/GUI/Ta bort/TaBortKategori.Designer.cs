namespace GUI
{
    partial class TaBortKategori
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
            this.btnTaBort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbKategorier
            // 
            this.cbKategorier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategorier.FormattingEnabled = true;
            this.cbKategorier.Location = new System.Drawing.Point(12, 36);
            this.cbKategorier.Name = "cbKategorier";
            this.cbKategorier.Size = new System.Drawing.Size(171, 21);
            this.cbKategorier.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Välj kategori:";
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(189, 34);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(75, 23);
            this.btnTaBort.TabIndex = 2;
            this.btnTaBort.Text = "Ta bort";
            this.btnTaBort.UseVisualStyleBackColor = true;
            this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click);
            // 
            // TaBortKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(282, 85);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKategorier);
            this.Name = "TaBortKategori";
            this.Text = "Ta bort kategori";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKategorier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTaBort;
    }
}
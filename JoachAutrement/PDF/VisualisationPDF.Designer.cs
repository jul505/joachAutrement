namespace JoachAutrement.Activités
{
    partial class VisualisationPDF
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
            this.WBaffichagepdf = new System.Windows.Forms.WebBrowser();
            this.chargementPDF = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // WBaffichagepdf
            // 
            this.WBaffichagepdf.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.WBaffichagepdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WBaffichagepdf.Location = new System.Drawing.Point(0, 32);
            this.WBaffichagepdf.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBaffichagepdf.Name = "WBaffichagepdf";
            this.WBaffichagepdf.Size = new System.Drawing.Size(948, 481);
            this.WBaffichagepdf.TabIndex = 0;
            this.WBaffichagepdf.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WBaffichagepdf_DocumentCompleted);
            // 
            // chargementPDF
            // 
            this.chargementPDF.Location = new System.Drawing.Point(357, 210);
            this.chargementPDF.Name = "chargementPDF";
            this.chargementPDF.Size = new System.Drawing.Size(218, 41);
            this.chargementPDF.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.chargementPDF.TabIndex = 1;
            // 
            // VisualisationPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(948, 504);
            this.Controls.Add(this.chargementPDF);
            this.Controls.Add(this.WBaffichagepdf);
            this.Name = "VisualisationPDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VisualisationPDF";
            this.Load += new System.EventHandler(this.VisualisationPDF_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WBaffichagepdf;
        private System.Windows.Forms.ProgressBar chargementPDF;
    }
}
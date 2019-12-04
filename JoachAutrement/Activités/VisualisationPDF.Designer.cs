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
            this.SuspendLayout();
            // 
            // WBaffichagepdf
            // 
            this.WBaffichagepdf.AllowNavigation = false;
            this.WBaffichagepdf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WBaffichagepdf.Location = new System.Drawing.Point(0, 0);
            this.WBaffichagepdf.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBaffichagepdf.Name = "WBaffichagepdf";
            this.WBaffichagepdf.Size = new System.Drawing.Size(948, 472);
            this.WBaffichagepdf.TabIndex = 0;
            this.WBaffichagepdf.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WBaffichagepdf_DocumentCompleted);
            // 
            // VisualisationPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 472);
            this.Controls.Add(this.WBaffichagepdf);
            this.Name = "VisualisationPDF";
            this.Text = "VisualisationPDF";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VisualisationPDF_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WBaffichagepdf;
    }
}
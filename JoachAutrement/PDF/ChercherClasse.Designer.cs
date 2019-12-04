namespace JoachAutrement.PDF
{
    partial class ChercherClasse
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
            this.components = new System.ComponentModel.Container();
            this.LB_classe = new System.Windows.Forms.ListBox();
            this.label_classe = new System.Windows.Forms.Label();
            this.TB_classe = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // LB_classe
            // 
            this.LB_classe.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.LB_classe.FormattingEnabled = true;
            this.LB_classe.ItemHeight = 28;
            this.LB_classe.Location = new System.Drawing.Point(99, 96);
            this.LB_classe.Margin = new System.Windows.Forms.Padding(4);
            this.LB_classe.Name = "LB_classe";
            this.LB_classe.Size = new System.Drawing.Size(707, 312);
            this.LB_classe.TabIndex = 0;
            this.LB_classe.DoubleClick += new System.EventHandler(this.LB_classe_DoubleClick);
            // 
            // label_classe
            // 
            this.label_classe.AutoSize = true;
            this.label_classe.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label_classe.Location = new System.Drawing.Point(95, 46);
            this.label_classe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_classe.Name = "label_classe";
            this.label_classe.Size = new System.Drawing.Size(82, 28);
            this.label_classe.TabIndex = 1;
            this.label_classe.Text = "Classe :";
            // 
            // TB_classe
            // 
            this.TB_classe.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.TB_classe.Location = new System.Drawing.Point(185, 43);
            this.TB_classe.Margin = new System.Windows.Forms.Padding(4);
            this.TB_classe.Name = "TB_classe";
            this.TB_classe.Size = new System.Drawing.Size(363, 35);
            this.TB_classe.TabIndex = 2;
            this.toolTip1.SetToolTip(this.TB_classe, "Recherche par nom de classe");
            this.TB_classe.TextChanged += new System.EventHandler(this.TB_classe_TextChanged);
            // 
            // ChercherClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 505);
            this.Controls.Add(this.TB_classe);
            this.Controls.Add(this.label_classe);
            this.Controls.Add(this.LB_classe);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChercherClasse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ChercherClasse";
            this.Load += new System.EventHandler(this.ChercherClasse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_classe;
        private System.Windows.Forms.Label label_classe;
        private System.Windows.Forms.TextBox TB_classe;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
namespace JoachAutrement.Eleve
{
    partial class RetirerActivite
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
            this.btnRetirer = new System.Windows.Forms.Button();
            this.comboBoxListActivite = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnRetirer
            // 
            this.btnRetirer.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnRetirer.Location = new System.Drawing.Point(124, 310);
            this.btnRetirer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRetirer.Name = "btnRetirer";
            this.btnRetirer.Size = new System.Drawing.Size(348, 69);
            this.btnRetirer.TabIndex = 1;
            this.btnRetirer.Text = "Se retirer de l\'activité";
            this.btnRetirer.UseVisualStyleBackColor = true;
            this.btnRetirer.Click += new System.EventHandler(this.btnRetirer_Click);
            // 
            // comboBoxListActivite
            // 
            this.comboBoxListActivite.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.comboBoxListActivite.FormattingEnabled = true;
            this.comboBoxListActivite.Location = new System.Drawing.Point(124, 167);
            this.comboBoxListActivite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxListActivite.Name = "comboBoxListActivite";
            this.comboBoxListActivite.Size = new System.Drawing.Size(348, 36);
            this.comboBoxListActivite.TabIndex = 2;
            this.toolTip1.SetToolTip(this.comboBoxListActivite, "Sélectionner l\'activité à supprimer de votre programme");
            // 
            // RetirerActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 481);
            this.Controls.Add(this.comboBoxListActivite);
            this.Controls.Add(this.btnRetirer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RetirerActivite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RetirerActivite";
            this.Load += new System.EventHandler(this.RetirerActivite_Load);
            this.Shown += new System.EventHandler(this.RetirerActivite_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetirer;
        private System.Windows.Forms.ComboBox comboBoxListActivite;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
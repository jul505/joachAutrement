namespace JoachAutrement
{
    partial class AjouterIntervenant
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
            this.Btn_Creer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Professon = new System.Windows.Forms.TextBox();
            this.TB_NOM = new System.Windows.Forms.TextBox();
            this.TB_Prenom = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Btn_Creer
            // 
            this.Btn_Creer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Creer.Location = new System.Drawing.Point(500, 409);
            this.Btn_Creer.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Creer.Name = "Btn_Creer";
            this.Btn_Creer.Size = new System.Drawing.Size(156, 70);
            this.Btn_Creer.TabIndex = 13;
            this.Btn_Creer.Text = "Sauvegarder";
            this.Btn_Creer.UseVisualStyleBackColor = true;
            this.Btn_Creer.Click += new System.EventHandler(this.Btn_Creer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(396, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Profession :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Prénom :";
            // 
            // TB_Professon
            // 
            this.TB_Professon.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Professon.Location = new System.Drawing.Point(563, 268);
            this.TB_Professon.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Professon.Name = "TB_Professon";
            this.TB_Professon.Size = new System.Drawing.Size(193, 35);
            this.TB_Professon.TabIndex = 9;
            // 
            // TB_NOM
            // 
            this.TB_NOM.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NOM.Location = new System.Drawing.Point(563, 85);
            this.TB_NOM.Margin = new System.Windows.Forms.Padding(4);
            this.TB_NOM.Name = "TB_NOM";
            this.TB_NOM.Size = new System.Drawing.Size(193, 35);
            this.TB_NOM.TabIndex = 7;
            // 
            // TB_Prenom
            // 
            this.TB_Prenom.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Prenom.Location = new System.Drawing.Point(563, 175);
            this.TB_Prenom.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Prenom.Name = "TB_Prenom";
            this.TB_Prenom.Size = new System.Drawing.Size(193, 35);
            this.TB_Prenom.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(469, 354);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(193, 28);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Intervenant externe\r\n";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // AjouterIntervenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 528);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Btn_Creer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Professon);
            this.Controls.Add(this.TB_NOM);
            this.Controls.Add(this.TB_Prenom);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AjouterIntervenant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ajouter un Intervenant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Creer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Professon;
        private System.Windows.Forms.TextBox TB_NOM;
        private System.Windows.Forms.TextBox TB_Prenom;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
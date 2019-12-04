namespace JoachAutrement
{
    partial class AjouterProf
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.radioButtonID2 = new System.Windows.Forms.RadioButton();
            this.radioButtonID3 = new System.Windows.Forms.RadioButton();
            this.radioButtonID4 = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMdp = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label3.Location = new System.Drawing.Point(76, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label2.Location = new System.Drawing.Point(101, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nom";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.textBoxNom.Location = new System.Drawing.Point(161, 73);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(207, 35);
            this.textBoxNom.TabIndex = 20;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.textBoxPrenom.Location = new System.Drawing.Point(161, 34);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(207, 35);
            this.textBoxPrenom.TabIndex = 19;
            // 
            // radioButtonID2
            // 
            this.radioButtonID2.AutoSize = true;
            this.radioButtonID2.Location = new System.Drawing.Point(35, 19);
            this.radioButtonID2.Name = "radioButtonID2";
            this.radioButtonID2.Size = new System.Drawing.Size(136, 32);
            this.radioButtonID2.TabIndex = 23;
            this.radioButtonID2.TabStop = true;
            this.radioButtonID2.Text = "Professeur";
            this.radioButtonID2.UseVisualStyleBackColor = true;
            // 
            // radioButtonID3
            // 
            this.radioButtonID3.AutoSize = true;
            this.radioButtonID3.Location = new System.Drawing.Point(35, 46);
            this.radioButtonID3.Name = "radioButtonID3";
            this.radioButtonID3.Size = new System.Drawing.Size(372, 32);
            this.radioButtonID3.TabIndex = 24;
            this.radioButtonID3.TabStop = true;
            this.radioButtonID3.Text = "Professeur avec droits d\'impression";
            this.radioButtonID3.UseVisualStyleBackColor = true;
            // 
            // radioButtonID4
            // 
            this.radioButtonID4.AutoSize = true;
            this.radioButtonID4.Location = new System.Drawing.Point(35, 73);
            this.radioButtonID4.Name = "radioButtonID4";
            this.radioButtonID4.Size = new System.Drawing.Size(155, 32);
            this.radioButtonID4.TabIndex = 25;
            this.radioButtonID4.TabStop = true;
            this.radioButtonID4.Text = "Organisateur";
            this.radioButtonID4.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.buttonSave.Location = new System.Drawing.Point(411, 138);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(300, 54);
            this.buttonSave.TabIndex = 26;
            this.buttonSave.Text = "Sauvegarder";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonID4);
            this.groupBox1.Controls.Add(this.radioButtonID2);
            this.groupBox1.Controls.Add(this.radioButtonID3);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.groupBox1.Location = new System.Drawing.Point(411, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 109);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label1.Location = new System.Drawing.Point(94, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label4.Location = new System.Drawing.Point(19, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 28);
            this.label4.TabIndex = 30;
            this.label4.Text = "Mot de passe";
            // 
            // textBoxMdp
            // 
            this.textBoxMdp.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.textBoxMdp.Location = new System.Drawing.Point(161, 153);
            this.textBoxMdp.Name = "textBoxMdp";
            this.textBoxMdp.Size = new System.Drawing.Size(207, 35);
            this.textBoxMdp.TabIndex = 29;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.textBoxLogin.Location = new System.Drawing.Point(161, 114);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(207, 35);
            this.textBoxLogin.TabIndex = 28;
            // 
            // AjouterProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 225);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMdp);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxPrenom);
            this.Name = "AjouterProf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AjouterProf";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxNom;
        public System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.RadioButton radioButtonID2;
        private System.Windows.Forms.RadioButton radioButtonID3;
        private System.Windows.Forms.RadioButton radioButtonID4;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxMdp;
        public System.Windows.Forms.TextBox textBoxLogin;
    }
}
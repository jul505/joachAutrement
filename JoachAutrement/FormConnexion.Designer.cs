namespace JoachAutrement
{
    partial class FormConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnexion));
            this.PB_JoachAutrement = new System.Windows.Forms.PictureBox();
            this.Lbl_Mdp = new System.Windows.Forms.Label();
            this.Btn_Connexion = new System.Windows.Forms.Button();
            this.TB_Mdp = new System.Windows.Forms.TextBox();
            this.TB_Login = new System.Windows.Forms.TextBox();
            this.Lbl_Login = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_JoachAutrement)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_JoachAutrement
            // 
            this.PB_JoachAutrement.Image = ((System.Drawing.Image)(resources.GetObject("PB_JoachAutrement.Image")));
            this.PB_JoachAutrement.Location = new System.Drawing.Point(59, 27);
            this.PB_JoachAutrement.Margin = new System.Windows.Forms.Padding(4);
            this.PB_JoachAutrement.Name = "PB_JoachAutrement";
            this.PB_JoachAutrement.Size = new System.Drawing.Size(332, 198);
            this.PB_JoachAutrement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB_JoachAutrement.TabIndex = 12;
            this.PB_JoachAutrement.TabStop = false;
            // 
            // Lbl_Mdp
            // 
            this.Lbl_Mdp.AutoSize = true;
            this.Lbl_Mdp.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mdp.Location = new System.Drawing.Point(84, 351);
            this.Lbl_Mdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Mdp.Name = "Lbl_Mdp";
            this.Lbl_Mdp.Size = new System.Drawing.Size(148, 28);
            this.Lbl_Mdp.TabIndex = 11;
            this.Lbl_Mdp.Text = "Mot de passe :";
            // 
            // Btn_Connexion
            // 
            this.Btn_Connexion.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Connexion.Location = new System.Drawing.Point(175, 418);
            this.Btn_Connexion.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Connexion.Name = "Btn_Connexion";
            this.Btn_Connexion.Size = new System.Drawing.Size(172, 50);
            this.Btn_Connexion.TabIndex = 10;
            this.Btn_Connexion.Text = "Connexion";
            this.Btn_Connexion.UseVisualStyleBackColor = true;
            this.Btn_Connexion.Click += new System.EventHandler(this.Btn_Connexion_Click);
            // 
            // TB_Mdp
            // 
            this.TB_Mdp.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.TB_Mdp.Location = new System.Drawing.Point(254, 348);
            this.TB_Mdp.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Mdp.Name = "TB_Mdp";
            this.TB_Mdp.Size = new System.Drawing.Size(189, 35);
            this.TB_Mdp.TabIndex = 9;
            this.TB_Mdp.UseSystemPasswordChar = true;
            // 
            // TB_Login
            // 
            this.TB_Login.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.TB_Login.Location = new System.Drawing.Point(254, 286);
            this.TB_Login.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Login.Name = "TB_Login";
            this.TB_Login.Size = new System.Drawing.Size(189, 35);
            this.TB_Login.TabIndex = 8;
            // 
            // Lbl_Login
            // 
            this.Lbl_Login.AutoSize = true;
            this.Lbl_Login.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Login.Location = new System.Drawing.Point(35, 289);
            this.Lbl_Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Login.Name = "Lbl_Login";
            this.Lbl_Login.Size = new System.Drawing.Size(186, 28);
            this.Lbl_Login.TabIndex = 7;
            this.Lbl_Login.Text = "Nom d\'utilisateur :";
            // 
            // FormConnexion
            // 
            this.AcceptButton = this.Btn_Connexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 543);
            this.Controls.Add(this.PB_JoachAutrement);
            this.Controls.Add(this.Lbl_Mdp);
            this.Controls.Add(this.Btn_Connexion);
            this.Controls.Add(this.TB_Mdp);
            this.Controls.Add(this.TB_Login);
            this.Controls.Add(this.Lbl_Login);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenue";
            ((System.ComponentModel.ISupportInitialize)(this.PB_JoachAutrement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_JoachAutrement;
        private System.Windows.Forms.Label Lbl_Mdp;
        private System.Windows.Forms.Button Btn_Connexion;
        private System.Windows.Forms.TextBox TB_Mdp;
        private System.Windows.Forms.TextBox TB_Login;
        private System.Windows.Forms.Label Lbl_Login;
    }
}


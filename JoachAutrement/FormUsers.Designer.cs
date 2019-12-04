namespace JoachAutrement
{
    partial class FormUsers
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consulterLesActivitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creerSonPlanningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDuneActivitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retirerUneActivitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirSonProgrammeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerMonPlanningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesElevesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscrireDesElevesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retirerDesElevesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterPasseportDunÉlèveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impressionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFActivitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFListeActivitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFListeSimplifiéDesActivitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFListeElevesNonInscritsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFListeElevesInscritToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFListeIntervenantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFEleveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionComptesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionIntervenantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionProfsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionElevesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesActivitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterDesActivitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierOuSupprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attributionDuneSalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.générerLaListeDesActivitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterLesActivitésToolStripMenuItem,
            this.creerSonPlanningToolStripMenuItem,
            this.gestionDesElevesToolStripMenuItem,
            this.impressionsToolStripMenuItem,
            this.gestionComptesToolStripMenuItem,
            this.gestionDesActivitésToolStripMenuItem,
            this.administrateurToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1809, 45);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consulterLesActivitésToolStripMenuItem
            // 
            this.consulterLesActivitésToolStripMenuItem.Name = "consulterLesActivitésToolStripMenuItem";
            this.consulterLesActivitésToolStripMenuItem.Size = new System.Drawing.Size(284, 41);
            this.consulterLesActivitésToolStripMenuItem.Text = "Consulter les activités";
            this.consulterLesActivitésToolStripMenuItem.Click += new System.EventHandler(this.consulterLesActivitésToolStripMenuItem_Click);
            // 
            // creerSonPlanningToolStripMenuItem
            // 
            this.creerSonPlanningToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutDuneActivitéToolStripMenuItem,
            this.retirerUneActivitéToolStripMenuItem,
            this.voirSonProgrammeToolStripMenuItem,
            this.imprimerMonPlanningToolStripMenuItem});
            this.creerSonPlanningToolStripMenuItem.Name = "creerSonPlanningToolStripMenuItem";
            this.creerSonPlanningToolStripMenuItem.Size = new System.Drawing.Size(196, 41);
            this.creerSonPlanningToolStripMenuItem.Text = "Mon planning";
            // 
            // ajoutDuneActivitéToolStripMenuItem
            // 
            this.ajoutDuneActivitéToolStripMenuItem.Name = "ajoutDuneActivitéToolStripMenuItem";
            this.ajoutDuneActivitéToolStripMenuItem.Size = new System.Drawing.Size(494, 42);
            this.ajoutDuneActivitéToolStripMenuItem.Text = "Ajout d\'une activité";
            this.ajoutDuneActivitéToolStripMenuItem.Click += new System.EventHandler(this.ajoutDuneActivitéToolStripMenuItem_Click);
            // 
            // retirerUneActivitéToolStripMenuItem
            // 
            this.retirerUneActivitéToolStripMenuItem.Name = "retirerUneActivitéToolStripMenuItem";
            this.retirerUneActivitéToolStripMenuItem.Size = new System.Drawing.Size(494, 42);
            this.retirerUneActivitéToolStripMenuItem.Text = "Retirer une activité";
            this.retirerUneActivitéToolStripMenuItem.Click += new System.EventHandler(this.retirerUneActivitéToolStripMenuItem_Click);
            // 
            // voirSonProgrammeToolStripMenuItem
            // 
            this.voirSonProgrammeToolStripMenuItem.Name = "voirSonProgrammeToolStripMenuItem";
            this.voirSonProgrammeToolStripMenuItem.Size = new System.Drawing.Size(494, 42);
            this.voirSonProgrammeToolStripMenuItem.Text = "Consulter mon planning";
            this.voirSonProgrammeToolStripMenuItem.Click += new System.EventHandler(this.voirSonProgrammeToolStripMenuItem_Click);
            // 
            // imprimerMonPlanningToolStripMenuItem
            // 
            this.imprimerMonPlanningToolStripMenuItem.Name = "imprimerMonPlanningToolStripMenuItem";
            this.imprimerMonPlanningToolStripMenuItem.Size = new System.Drawing.Size(494, 42);
            this.imprimerMonPlanningToolStripMenuItem.Text = "Valider et imprimer mon planning";
            this.imprimerMonPlanningToolStripMenuItem.Click += new System.EventHandler(this.imprimerMonPlanningToolStripMenuItem_Click);
            // 
            // gestionDesElevesToolStripMenuItem
            // 
            this.gestionDesElevesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscrireDesElevesToolStripMenuItem,
            this.retirerDesElevesToolStripMenuItem,
            this.consulterPasseportDunÉlèveToolStripMenuItem});
            this.gestionDesElevesToolStripMenuItem.Name = "gestionDesElevesToolStripMenuItem";
            this.gestionDesElevesToolStripMenuItem.Size = new System.Drawing.Size(248, 41);
            this.gestionDesElevesToolStripMenuItem.Text = "Gestion des élèves";
            // 
            // inscrireDesElevesToolStripMenuItem
            // 
            this.inscrireDesElevesToolStripMenuItem.Name = "inscrireDesElevesToolStripMenuItem";
            this.inscrireDesElevesToolStripMenuItem.Size = new System.Drawing.Size(458, 42);
            this.inscrireDesElevesToolStripMenuItem.Text = "Inscrire des élèves";
            this.inscrireDesElevesToolStripMenuItem.Click += new System.EventHandler(this.inscrireDesElevesToolStripMenuItem_Click);
            // 
            // retirerDesElevesToolStripMenuItem
            // 
            this.retirerDesElevesToolStripMenuItem.Name = "retirerDesElevesToolStripMenuItem";
            this.retirerDesElevesToolStripMenuItem.Size = new System.Drawing.Size(458, 42);
            this.retirerDesElevesToolStripMenuItem.Text = "Retirer des élèves";
            this.retirerDesElevesToolStripMenuItem.Click += new System.EventHandler(this.retirerDesElevesToolStripMenuItem_Click);
            // 
            // consulterPasseportDunÉlèveToolStripMenuItem
            // 
            this.consulterPasseportDunÉlèveToolStripMenuItem.Name = "consulterPasseportDunÉlèveToolStripMenuItem";
            this.consulterPasseportDunÉlèveToolStripMenuItem.Size = new System.Drawing.Size(458, 42);
            this.consulterPasseportDunÉlèveToolStripMenuItem.Text = "Consulter passeport d\'un élève";
            this.consulterPasseportDunÉlèveToolStripMenuItem.Click += new System.EventHandler(this.consulterPasseportDunÉlèveToolStripMenuItem_Click);
            // 
            // impressionsToolStripMenuItem
            // 
            this.impressionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDFActivitésToolStripMenuItem,
            this.pDFListeActivitésToolStripMenuItem,
            this.pDFListeSimplifiéDesActivitésToolStripMenuItem,
            this.pDFListeElevesNonInscritsToolStripMenuItem,
            this.pDFListeElevesInscritToolStripMenuItem,
            this.pDFListeIntervenantToolStripMenuItem,
            this.pDFEleveToolStripMenuItem});
            this.impressionsToolStripMenuItem.Name = "impressionsToolStripMenuItem";
            this.impressionsToolStripMenuItem.Size = new System.Drawing.Size(169, 41);
            this.impressionsToolStripMenuItem.Text = "Impressions";
            // 
            // pDFActivitésToolStripMenuItem
            // 
            this.pDFActivitésToolStripMenuItem.Name = "pDFActivitésToolStripMenuItem";
            this.pDFActivitésToolStripMenuItem.Size = new System.Drawing.Size(578, 42);
            this.pDFActivitésToolStripMenuItem.Text = "PDF liste élèves pour une activité";
            this.pDFActivitésToolStripMenuItem.Click += new System.EventHandler(this.pDFActivitésToolStripMenuItem_Click);
            // 
            // pDFListeActivitésToolStripMenuItem
            // 
            this.pDFListeActivitésToolStripMenuItem.Name = "pDFListeActivitésToolStripMenuItem";
            this.pDFListeActivitésToolStripMenuItem.Size = new System.Drawing.Size(578, 42);
            this.pDFListeActivitésToolStripMenuItem.Text = "PDF liste complète des activités";
            this.pDFListeActivitésToolStripMenuItem.Click += new System.EventHandler(this.pDFListeActivitésToolStripMenuItem_Click);
            // 
            // pDFListeSimplifiéDesActivitésToolStripMenuItem
            // 
            this.pDFListeSimplifiéDesActivitésToolStripMenuItem.Name = "pDFListeSimplifiéDesActivitésToolStripMenuItem";
            this.pDFListeSimplifiéDesActivitésToolStripMenuItem.Size = new System.Drawing.Size(578, 42);
            this.pDFListeSimplifiéDesActivitésToolStripMenuItem.Text = "PDF liste simplifiée des activités";
            this.pDFListeSimplifiéDesActivitésToolStripMenuItem.Click += new System.EventHandler(this.pDFListeSimplifiéDesActivitésToolStripMenuItem_Click);
            // 
            // pDFListeElevesNonInscritsToolStripMenuItem
            // 
            this.pDFListeElevesNonInscritsToolStripMenuItem.Name = "pDFListeElevesNonInscritsToolStripMenuItem";
            this.pDFListeElevesNonInscritsToolStripMenuItem.Size = new System.Drawing.Size(578, 42);
            this.pDFListeElevesNonInscritsToolStripMenuItem.Text = "PDF liste élèves non validés";
            this.pDFListeElevesNonInscritsToolStripMenuItem.Click += new System.EventHandler(this.pDFListeElevesNonInscritsToolStripMenuItem_Click_1);
            // 
            // pDFListeElevesInscritToolStripMenuItem
            // 
            this.pDFListeElevesInscritToolStripMenuItem.Name = "pDFListeElevesInscritToolStripMenuItem";
            this.pDFListeElevesInscritToolStripMenuItem.Size = new System.Drawing.Size(578, 42);
            this.pDFListeElevesInscritToolStripMenuItem.Text = "PDF liste élèves validés ou non par classe";
            this.pDFListeElevesInscritToolStripMenuItem.Click += new System.EventHandler(this.pDFListeElevesInscritToolStripMenuItem_Click);
            // 
            // pDFListeIntervenantToolStripMenuItem
            // 
            this.pDFListeIntervenantToolStripMenuItem.Name = "pDFListeIntervenantToolStripMenuItem";
            this.pDFListeIntervenantToolStripMenuItem.Size = new System.Drawing.Size(578, 42);
            this.pDFListeIntervenantToolStripMenuItem.Text = "PDF liste des intervenants";
            this.pDFListeIntervenantToolStripMenuItem.Click += new System.EventHandler(this.pDFListeIntervenantToolStripMenuItem_Click);
            // 
            // pDFEleveToolStripMenuItem
            // 
            this.pDFEleveToolStripMenuItem.Name = "pDFEleveToolStripMenuItem";
            this.pDFEleveToolStripMenuItem.Size = new System.Drawing.Size(578, 42);
            this.pDFEleveToolStripMenuItem.Text = "PDF passeport élèves";
            this.pDFEleveToolStripMenuItem.Click += new System.EventHandler(this.pDFEleveToolStripMenuItem_Click_1);
            // 
            // gestionComptesToolStripMenuItem
            // 
            this.gestionComptesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionIntervenantsToolStripMenuItem,
            this.gestionProfsToolStripMenuItem,
            this.gestionElevesToolStripMenuItem});
            this.gestionComptesToolStripMenuItem.Name = "gestionComptesToolStripMenuItem";
            this.gestionComptesToolStripMenuItem.Size = new System.Drawing.Size(276, 41);
            this.gestionComptesToolStripMenuItem.Text = "Gestion des comptes";
            // 
            // gestionIntervenantsToolStripMenuItem
            // 
            this.gestionIntervenantsToolStripMenuItem.Name = "gestionIntervenantsToolStripMenuItem";
            this.gestionIntervenantsToolStripMenuItem.Size = new System.Drawing.Size(456, 42);
            this.gestionIntervenantsToolStripMenuItem.Text = "Gestion des intervenants";
            this.gestionIntervenantsToolStripMenuItem.Click += new System.EventHandler(this.gestionIntervenantsToolStripMenuItem_Click);
            // 
            // gestionProfsToolStripMenuItem
            // 
            this.gestionProfsToolStripMenuItem.Name = "gestionProfsToolStripMenuItem";
            this.gestionProfsToolStripMenuItem.Size = new System.Drawing.Size(456, 42);
            this.gestionProfsToolStripMenuItem.Text = "Gérer des comptes professeurs";
            this.gestionProfsToolStripMenuItem.Click += new System.EventHandler(this.gestionProfsToolStripMenuItem_Click);
            // 
            // gestionElevesToolStripMenuItem
            // 
            this.gestionElevesToolStripMenuItem.Name = "gestionElevesToolStripMenuItem";
            this.gestionElevesToolStripMenuItem.Size = new System.Drawing.Size(456, 42);
            this.gestionElevesToolStripMenuItem.Text = "Gérer des comptes élèves";
            this.gestionElevesToolStripMenuItem.Click += new System.EventHandler(this.gestionElevesToolStripMenuItem_Click);
            // 
            // gestionDesActivitésToolStripMenuItem
            // 
            this.gestionDesActivitésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterDesActivitésToolStripMenuItem,
            this.modifierOuSupprimerToolStripMenuItem,
            this.attributionDuneSalleToolStripMenuItem,
            this.générerLaListeDesActivitésToolStripMenuItem});
            this.gestionDesActivitésToolStripMenuItem.Name = "gestionDesActivitésToolStripMenuItem";
            this.gestionDesActivitésToolStripMenuItem.Size = new System.Drawing.Size(271, 41);
            this.gestionDesActivitésToolStripMenuItem.Text = "Gestion des activités";
            // 
            // ajouterDesActivitésToolStripMenuItem
            // 
            this.ajouterDesActivitésToolStripMenuItem.Name = "ajouterDesActivitésToolStripMenuItem";
            this.ajouterDesActivitésToolStripMenuItem.Size = new System.Drawing.Size(422, 42);
            this.ajouterDesActivitésToolStripMenuItem.Text = "Ajouter des activités";
            this.ajouterDesActivitésToolStripMenuItem.Click += new System.EventHandler(this.ajouterDesActivitésToolStripMenuItem_Click);
            // 
            // modifierOuSupprimerToolStripMenuItem
            // 
            this.modifierOuSupprimerToolStripMenuItem.Name = "modifierOuSupprimerToolStripMenuItem";
            this.modifierOuSupprimerToolStripMenuItem.Size = new System.Drawing.Size(422, 42);
            this.modifierOuSupprimerToolStripMenuItem.Text = "Modifier ou supprimer";
            this.modifierOuSupprimerToolStripMenuItem.Click += new System.EventHandler(this.modifierOuSupprimerToolStripMenuItem_Click);
            // 
            // attributionDuneSalleToolStripMenuItem
            // 
            this.attributionDuneSalleToolStripMenuItem.Name = "attributionDuneSalleToolStripMenuItem";
            this.attributionDuneSalleToolStripMenuItem.Size = new System.Drawing.Size(422, 42);
            this.attributionDuneSalleToolStripMenuItem.Text = "Attribution d\'une salle";
            this.attributionDuneSalleToolStripMenuItem.Click += new System.EventHandler(this.attributionDuneSalleToolStripMenuItem_Click);
            // 
            // générerLaListeDesActivitésToolStripMenuItem
            // 
            this.générerLaListeDesActivitésToolStripMenuItem.Name = "générerLaListeDesActivitésToolStripMenuItem";
            this.générerLaListeDesActivitésToolStripMenuItem.Size = new System.Drawing.Size(422, 42);
            this.générerLaListeDesActivitésToolStripMenuItem.Text = "Générer la liste des activités";
            this.générerLaListeDesActivitésToolStripMenuItem.Click += new System.EventHandler(this.générerLaListeDesActivitésToolStripMenuItem_Click);
            // 
            // administrateurToolStripMenuItem
            // 
            this.administrateurToolStripMenuItem.Name = "administrateurToolStripMenuItem";
            this.administrateurToolStripMenuItem.Size = new System.Drawing.Size(204, 41);
            this.administrateurToolStripMenuItem.Text = "Administrateur";
            this.administrateurToolStripMenuItem.Click += new System.EventHandler(this.administrateurToolStripMenuItem_Click);
            // 
            // FormUsers
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1809, 574);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUsers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUsers_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem consulterLesActivitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creerSonPlanningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesElevesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impressionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesActivitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDuneActivitéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retirerUneActivitéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirSonProgrammeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscrireDesElevesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retirerDesElevesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFActivitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFListeActivitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFListeElevesNonInscritsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFListeElevesInscritToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterDesActivitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierOuSupprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFListeIntervenantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFEleveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFListeSimplifiéDesActivitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attributionDuneSalleToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consulterPasseportDunÉlèveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem générerLaListeDesActivitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionComptesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionIntervenantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionProfsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionElevesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerMonPlanningToolStripMenuItem;
    }
}
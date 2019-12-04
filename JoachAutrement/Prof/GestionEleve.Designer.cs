namespace JoachAutrement.Prof
{
    partial class GestionEleve
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
            this.label_prenom = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_classe = new System.Windows.Forms.Label();
            this.TB_prenom = new System.Windows.Forms.TextBox();
            this.TB_nom = new System.Windows.Forms.TextBox();
            this.CB_classe = new System.Windows.Forms.ComboBox();
            this.GB_selecteleve = new System.Windows.Forms.GroupBox();
            this.LB_selecteleve = new System.Windows.Forms.CheckedListBox();
            this.label_date = new System.Windows.Forms.Label();
            this.label_code = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.CB_type = new System.Windows.Forms.ComboBox();
            this.CB_date = new System.Windows.Forms.ComboBox();
            this.TB_code = new System.Windows.Forms.TextBox();
            this.GB_selectactivite = new System.Windows.Forms.GroupBox();
            this.LB_selectactivite = new System.Windows.Forms.ListBox();
            this.btn_inscrire = new System.Windows.Forms.Button();
            this.CB_touseleve = new System.Windows.Forms.CheckBox();
            this.label_nbeleve = new System.Windows.Forms.Label();
            this.label_nb = new System.Windows.Forms.Label();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.GB_Detail = new System.Windows.Forms.GroupBox();
            this.TB_DetailSalle = new System.Windows.Forms.TextBox();
            this.TB_DetailPlace = new System.Windows.Forms.TextBox();
            this.TB_DetailHeureFin = new System.Windows.Forms.TextBox();
            this.TB_DetailHeureDebut = new System.Windows.Forms.TextBox();
            this.TB_DetailDate = new System.Windows.Forms.TextBox();
            this.TB_DetailIntervenant = new System.Windows.Forms.TextBox();
            this.TB_DetailType = new System.Windows.Forms.TextBox();
            this.TB_DetailTitre = new System.Windows.Forms.TextBox();
            this.Lbl_DetailSalle = new System.Windows.Forms.Label();
            this.Lbl_DetailPlace = new System.Windows.Forms.Label();
            this.Lbl_DetailHeureFin = new System.Windows.Forms.Label();
            this.Lbl_DetailHeureDebut = new System.Windows.Forms.Label();
            this.Lbl_DetailDate = new System.Windows.Forms.Label();
            this.Lbl_DetailIntervenant = new System.Windows.Forms.Label();
            this.Lbl_DetailType = new System.Windows.Forms.Label();
            this.Lbl_DetailTitre = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GB_selecteleve.SuspendLayout();
            this.GB_selectactivite.SuspendLayout();
            this.GB_Detail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_prenom
            // 
            this.label_prenom.AutoSize = true;
            this.label_prenom.Location = new System.Drawing.Point(7, 39);
            this.label_prenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_prenom.Name = "label_prenom";
            this.label_prenom.Size = new System.Drawing.Size(91, 28);
            this.label_prenom.TabIndex = 0;
            this.label_prenom.Text = "Prénom :";
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Location = new System.Drawing.Point(32, 86);
            this.label_nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(66, 28);
            this.label_nom.TabIndex = 1;
            this.label_nom.Text = "Nom :";
            // 
            // label_classe
            // 
            this.label_classe.AutoSize = true;
            this.label_classe.Location = new System.Drawing.Point(16, 128);
            this.label_classe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_classe.Name = "label_classe";
            this.label_classe.Size = new System.Drawing.Size(82, 28);
            this.label_classe.TabIndex = 2;
            this.label_classe.Text = "Classe :";
            // 
            // TB_prenom
            // 
            this.TB_prenom.Location = new System.Drawing.Point(120, 37);
            this.TB_prenom.Margin = new System.Windows.Forms.Padding(4);
            this.TB_prenom.Name = "TB_prenom";
            this.TB_prenom.Size = new System.Drawing.Size(235, 35);
            this.TB_prenom.TabIndex = 3;
            this.TB_prenom.TextChanged += new System.EventHandler(this.TB_prenom_TextChanged);
            // 
            // TB_nom
            // 
            this.TB_nom.Location = new System.Drawing.Point(120, 82);
            this.TB_nom.Margin = new System.Windows.Forms.Padding(4);
            this.TB_nom.Name = "TB_nom";
            this.TB_nom.Size = new System.Drawing.Size(235, 35);
            this.TB_nom.TabIndex = 4;
            this.TB_nom.TextChanged += new System.EventHandler(this.TB_nom_TextChanged);
            // 
            // CB_classe
            // 
            this.CB_classe.FormattingEnabled = true;
            this.CB_classe.Location = new System.Drawing.Point(120, 128);
            this.CB_classe.Margin = new System.Windows.Forms.Padding(4);
            this.CB_classe.Name = "CB_classe";
            this.CB_classe.Size = new System.Drawing.Size(235, 36);
            this.CB_classe.TabIndex = 5;
            this.CB_classe.DropDown += new System.EventHandler(this.CB_classe_DropDown);
            this.CB_classe.TextChanged += new System.EventHandler(this.CB_classe_TextChanged);
            // 
            // GB_selecteleve
            // 
            this.GB_selecteleve.Controls.Add(this.LB_selecteleve);
            this.GB_selecteleve.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.GB_selecteleve.Location = new System.Drawing.Point(997, 271);
            this.GB_selecteleve.Margin = new System.Windows.Forms.Padding(4);
            this.GB_selecteleve.Name = "GB_selecteleve";
            this.GB_selecteleve.Padding = new System.Windows.Forms.Padding(4);
            this.GB_selecteleve.Size = new System.Drawing.Size(555, 358);
            this.GB_selecteleve.TabIndex = 6;
            this.GB_selecteleve.TabStop = false;
            this.GB_selecteleve.Text = "Sélection élève";
            // 
            // LB_selecteleve
            // 
            this.LB_selecteleve.FormattingEnabled = true;
            this.LB_selecteleve.Location = new System.Drawing.Point(21, 36);
            this.LB_selecteleve.Margin = new System.Windows.Forms.Padding(4);
            this.LB_selecteleve.Name = "LB_selecteleve";
            this.LB_selecteleve.Size = new System.Drawing.Size(519, 274);
            this.LB_selecteleve.TabIndex = 0;
            this.toolTip1.SetToolTip(this.LB_selecteleve, "Cochez simplement les élèves à inscrire");
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(29, 38);
            this.label_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(67, 28);
            this.label_date.TabIndex = 7;
            this.label_date.Text = "Date :";
            // 
            // label_code
            // 
            this.label_code.AutoSize = true;
            this.label_code.Location = new System.Drawing.Point(29, 129);
            this.label_code.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_code.Name = "label_code";
            this.label_code.Size = new System.Drawing.Size(70, 28);
            this.label_code.TabIndex = 8;
            this.label_code.Text = "Code :";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(29, 84);
            this.label_type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(70, 28);
            this.label_type.TabIndex = 9;
            this.label_type.Text = "Type :";
            // 
            // CB_type
            // 
            this.CB_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_type.FormattingEnabled = true;
            this.CB_type.Location = new System.Drawing.Point(105, 81);
            this.CB_type.Margin = new System.Windows.Forms.Padding(4);
            this.CB_type.Name = "CB_type";
            this.CB_type.Size = new System.Drawing.Size(235, 36);
            this.CB_type.TabIndex = 10;
            this.CB_type.SelectedIndexChanged += new System.EventHandler(this.CB_type_SelectedIndexChanged);
            // 
            // CB_date
            // 
            this.CB_date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_date.FormattingEnabled = true;
            this.CB_date.Location = new System.Drawing.Point(105, 34);
            this.CB_date.Margin = new System.Windows.Forms.Padding(4);
            this.CB_date.Name = "CB_date";
            this.CB_date.Size = new System.Drawing.Size(235, 36);
            this.CB_date.TabIndex = 11;
            this.CB_date.SelectedIndexChanged += new System.EventHandler(this.CB_date_SelectedIndexChanged);
            // 
            // TB_code
            // 
            this.TB_code.Location = new System.Drawing.Point(105, 126);
            this.TB_code.Margin = new System.Windows.Forms.Padding(4);
            this.TB_code.Name = "TB_code";
            this.TB_code.Size = new System.Drawing.Size(235, 35);
            this.TB_code.TabIndex = 12;
            this.TB_code.TextChanged += new System.EventHandler(this.TB_code_TextChanged);
            // 
            // GB_selectactivite
            // 
            this.GB_selectactivite.Controls.Add(this.LB_selectactivite);
            this.GB_selectactivite.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.GB_selectactivite.Location = new System.Drawing.Point(13, 265);
            this.GB_selectactivite.Margin = new System.Windows.Forms.Padding(4);
            this.GB_selectactivite.Name = "GB_selectactivite";
            this.GB_selectactivite.Padding = new System.Windows.Forms.Padding(4);
            this.GB_selectactivite.Size = new System.Drawing.Size(563, 364);
            this.GB_selectactivite.TabIndex = 13;
            this.GB_selectactivite.TabStop = false;
            this.GB_selectactivite.Text = "Sélection activité";
            // 
            // LB_selectactivite
            // 
            this.LB_selectactivite.FormattingEnabled = true;
            this.LB_selectactivite.ItemHeight = 28;
            this.LB_selectactivite.Location = new System.Drawing.Point(20, 32);
            this.LB_selectactivite.Margin = new System.Windows.Forms.Padding(4);
            this.LB_selectactivite.Name = "LB_selectactivite";
            this.LB_selectactivite.Size = new System.Drawing.Size(516, 284);
            this.LB_selectactivite.TabIndex = 0;
            this.toolTip1.SetToolTip(this.LB_selectactivite, "Sélectionner l\'activité à laquelle vous voulez inscrire un ou plusieurs élèves");
            this.LB_selectactivite.SelectedIndexChanged += new System.EventHandler(this.LB_selectactivite_SelectedIndexChanged);
            // 
            // btn_inscrire
            // 
            this.btn_inscrire.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btn_inscrire.Location = new System.Drawing.Point(668, 500);
            this.btn_inscrire.Margin = new System.Windows.Forms.Padding(4);
            this.btn_inscrire.Name = "btn_inscrire";
            this.btn_inscrire.Size = new System.Drawing.Size(243, 41);
            this.btn_inscrire.TabIndex = 14;
            this.btn_inscrire.Text = "Inscrire";
            this.btn_inscrire.UseVisualStyleBackColor = true;
            this.btn_inscrire.Click += new System.EventHandler(this.btn_inscrire_Click);
            // 
            // CB_touseleve
            // 
            this.CB_touseleve.AutoSize = true;
            this.CB_touseleve.Location = new System.Drawing.Point(99, 182);
            this.CB_touseleve.Margin = new System.Windows.Forms.Padding(4);
            this.CB_touseleve.Name = "CB_touseleve";
            this.CB_touseleve.Size = new System.Drawing.Size(287, 32);
            this.CB_touseleve.TabIndex = 15;
            this.CB_touseleve.Text = "Tous les élèves de la classe";
            this.CB_touseleve.UseVisualStyleBackColor = true;
            this.CB_touseleve.Visible = false;
            this.CB_touseleve.CheckedChanged += new System.EventHandler(this.CB_touseleve_CheckedChanged);
            // 
            // label_nbeleve
            // 
            this.label_nbeleve.AutoSize = true;
            this.label_nbeleve.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label_nbeleve.Location = new System.Drawing.Point(1051, 239);
            this.label_nbeleve.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nbeleve.Name = "label_nbeleve";
            this.label_nbeleve.Size = new System.Drawing.Size(173, 28);
            this.label_nbeleve.TabIndex = 16;
            this.label_nbeleve.Text = "Nombre d\'élève :";
            this.label_nbeleve.Visible = false;
            // 
            // label_nb
            // 
            this.label_nb.AutoSize = true;
            this.label_nb.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label_nb.Location = new System.Drawing.Point(1231, 239);
            this.label_nb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nb.Name = "label_nb";
            this.label_nb.Size = new System.Drawing.Size(0, 28);
            this.label_nb.TabIndex = 17;
            this.label_nb.Visible = false;
            // 
            // btn_annuler
            // 
            this.btn_annuler.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btn_annuler.Location = new System.Drawing.Point(668, 409);
            this.btn_annuler.Margin = new System.Windows.Forms.Padding(4);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(241, 41);
            this.btn_annuler.TabIndex = 18;
            this.btn_annuler.Text = "Annuler la recherche";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // GB_Detail
            // 
            this.GB_Detail.Controls.Add(this.TB_DetailSalle);
            this.GB_Detail.Controls.Add(this.TB_DetailPlace);
            this.GB_Detail.Controls.Add(this.TB_DetailHeureFin);
            this.GB_Detail.Controls.Add(this.TB_DetailHeureDebut);
            this.GB_Detail.Controls.Add(this.TB_DetailDate);
            this.GB_Detail.Controls.Add(this.TB_DetailIntervenant);
            this.GB_Detail.Controls.Add(this.TB_DetailType);
            this.GB_Detail.Controls.Add(this.TB_DetailTitre);
            this.GB_Detail.Controls.Add(this.Lbl_DetailSalle);
            this.GB_Detail.Controls.Add(this.Lbl_DetailPlace);
            this.GB_Detail.Controls.Add(this.Lbl_DetailHeureFin);
            this.GB_Detail.Controls.Add(this.Lbl_DetailHeureDebut);
            this.GB_Detail.Controls.Add(this.Lbl_DetailDate);
            this.GB_Detail.Controls.Add(this.Lbl_DetailIntervenant);
            this.GB_Detail.Controls.Add(this.Lbl_DetailType);
            this.GB_Detail.Controls.Add(this.Lbl_DetailTitre);
            this.GB_Detail.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.GB_Detail.Location = new System.Drawing.Point(603, 15);
            this.GB_Detail.Margin = new System.Windows.Forms.Padding(4);
            this.GB_Detail.Name = "GB_Detail";
            this.GB_Detail.Padding = new System.Windows.Forms.Padding(4);
            this.GB_Detail.Size = new System.Drawing.Size(347, 386);
            this.GB_Detail.TabIndex = 20;
            this.GB_Detail.TabStop = false;
            this.GB_Detail.Text = "Détails";
            this.toolTip1.SetToolTip(this.GB_Detail, "Affiche le détail de toutes les activités");
            // 
            // TB_DetailSalle
            // 
            this.TB_DetailSalle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_DetailSalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TB_DetailSalle.Location = new System.Drawing.Point(80, 330);
            this.TB_DetailSalle.Margin = new System.Windows.Forms.Padding(4);
            this.TB_DetailSalle.Name = "TB_DetailSalle";
            this.TB_DetailSalle.ReadOnly = true;
            this.TB_DetailSalle.Size = new System.Drawing.Size(227, 30);
            this.TB_DetailSalle.TabIndex = 17;
            // 
            // TB_DetailPlace
            // 
            this.TB_DetailPlace.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_DetailPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TB_DetailPlace.Location = new System.Drawing.Point(175, 293);
            this.TB_DetailPlace.Margin = new System.Windows.Forms.Padding(4);
            this.TB_DetailPlace.Name = "TB_DetailPlace";
            this.TB_DetailPlace.ReadOnly = true;
            this.TB_DetailPlace.Size = new System.Drawing.Size(132, 30);
            this.TB_DetailPlace.TabIndex = 16;
            // 
            // TB_DetailHeureFin
            // 
            this.TB_DetailHeureFin.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_DetailHeureFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TB_DetailHeureFin.Location = new System.Drawing.Point(143, 250);
            this.TB_DetailHeureFin.Margin = new System.Windows.Forms.Padding(4);
            this.TB_DetailHeureFin.Name = "TB_DetailHeureFin";
            this.TB_DetailHeureFin.ReadOnly = true;
            this.TB_DetailHeureFin.Size = new System.Drawing.Size(163, 30);
            this.TB_DetailHeureFin.TabIndex = 15;
            // 
            // TB_DetailHeureDebut
            // 
            this.TB_DetailHeureDebut.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_DetailHeureDebut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TB_DetailHeureDebut.Location = new System.Drawing.Point(165, 203);
            this.TB_DetailHeureDebut.Margin = new System.Windows.Forms.Padding(4);
            this.TB_DetailHeureDebut.Name = "TB_DetailHeureDebut";
            this.TB_DetailHeureDebut.ReadOnly = true;
            this.TB_DetailHeureDebut.Size = new System.Drawing.Size(140, 30);
            this.TB_DetailHeureDebut.TabIndex = 14;
            // 
            // TB_DetailDate
            // 
            this.TB_DetailDate.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_DetailDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TB_DetailDate.Location = new System.Drawing.Point(75, 162);
            this.TB_DetailDate.Margin = new System.Windows.Forms.Padding(4);
            this.TB_DetailDate.Name = "TB_DetailDate";
            this.TB_DetailDate.ReadOnly = true;
            this.TB_DetailDate.Size = new System.Drawing.Size(231, 30);
            this.TB_DetailDate.TabIndex = 13;
            // 
            // TB_DetailIntervenant
            // 
            this.TB_DetailIntervenant.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_DetailIntervenant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TB_DetailIntervenant.Location = new System.Drawing.Point(132, 118);
            this.TB_DetailIntervenant.Margin = new System.Windows.Forms.Padding(4);
            this.TB_DetailIntervenant.Name = "TB_DetailIntervenant";
            this.TB_DetailIntervenant.ReadOnly = true;
            this.TB_DetailIntervenant.Size = new System.Drawing.Size(173, 30);
            this.TB_DetailIntervenant.TabIndex = 12;
            // 
            // TB_DetailType
            // 
            this.TB_DetailType.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_DetailType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TB_DetailType.Location = new System.Drawing.Point(80, 78);
            this.TB_DetailType.Margin = new System.Windows.Forms.Padding(4);
            this.TB_DetailType.Name = "TB_DetailType";
            this.TB_DetailType.ReadOnly = true;
            this.TB_DetailType.Size = new System.Drawing.Size(225, 30);
            this.TB_DetailType.TabIndex = 11;
            // 
            // TB_DetailTitre
            // 
            this.TB_DetailTitre.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_DetailTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TB_DetailTitre.Location = new System.Drawing.Point(79, 37);
            this.TB_DetailTitre.Margin = new System.Windows.Forms.Padding(4);
            this.TB_DetailTitre.Name = "TB_DetailTitre";
            this.TB_DetailTitre.ReadOnly = true;
            this.TB_DetailTitre.Size = new System.Drawing.Size(227, 30);
            this.TB_DetailTitre.TabIndex = 10;
            // 
            // Lbl_DetailSalle
            // 
            this.Lbl_DetailSalle.AutoSize = true;
            this.Lbl_DetailSalle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DetailSalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lbl_DetailSalle.Location = new System.Drawing.Point(9, 330);
            this.Lbl_DetailSalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_DetailSalle.Name = "Lbl_DetailSalle";
            this.Lbl_DetailSalle.Size = new System.Drawing.Size(52, 24);
            this.Lbl_DetailSalle.TabIndex = 8;
            this.Lbl_DetailSalle.Text = "Lieu :";
            // 
            // Lbl_DetailPlace
            // 
            this.Lbl_DetailPlace.AutoSize = true;
            this.Lbl_DetailPlace.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DetailPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lbl_DetailPlace.Location = new System.Drawing.Point(9, 297);
            this.Lbl_DetailPlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_DetailPlace.Name = "Lbl_DetailPlace";
            this.Lbl_DetailPlace.Size = new System.Drawing.Size(153, 24);
            this.Lbl_DetailPlace.TabIndex = 7;
            this.Lbl_DetailPlace.Text = "Nombre de place :";
            // 
            // Lbl_DetailHeureFin
            // 
            this.Lbl_DetailHeureFin.AutoSize = true;
            this.Lbl_DetailHeureFin.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DetailHeureFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lbl_DetailHeureFin.Location = new System.Drawing.Point(8, 254);
            this.Lbl_DetailHeureFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_DetailHeureFin.Name = "Lbl_DetailHeureFin";
            this.Lbl_DetailHeureFin.Size = new System.Drawing.Size(120, 24);
            this.Lbl_DetailHeureFin.TabIndex = 6;
            this.Lbl_DetailHeureFin.Text = "Heure de fin :";
            // 
            // Lbl_DetailHeureDebut
            // 
            this.Lbl_DetailHeureDebut.AutoSize = true;
            this.Lbl_DetailHeureDebut.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DetailHeureDebut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lbl_DetailHeureDebut.Location = new System.Drawing.Point(8, 207);
            this.Lbl_DetailHeureDebut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_DetailHeureDebut.Name = "Lbl_DetailHeureDebut";
            this.Lbl_DetailHeureDebut.Size = new System.Drawing.Size(143, 24);
            this.Lbl_DetailHeureDebut.TabIndex = 5;
            this.Lbl_DetailHeureDebut.Text = "Heure de début :";
            // 
            // Lbl_DetailDate
            // 
            this.Lbl_DetailDate.AutoSize = true;
            this.Lbl_DetailDate.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DetailDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lbl_DetailDate.Location = new System.Drawing.Point(8, 166);
            this.Lbl_DetailDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_DetailDate.Name = "Lbl_DetailDate";
            this.Lbl_DetailDate.Size = new System.Drawing.Size(58, 24);
            this.Lbl_DetailDate.TabIndex = 4;
            this.Lbl_DetailDate.Text = "Date :";
            // 
            // Lbl_DetailIntervenant
            // 
            this.Lbl_DetailIntervenant.AutoSize = true;
            this.Lbl_DetailIntervenant.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DetailIntervenant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lbl_DetailIntervenant.Location = new System.Drawing.Point(8, 122);
            this.Lbl_DetailIntervenant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_DetailIntervenant.Name = "Lbl_DetailIntervenant";
            this.Lbl_DetailIntervenant.Size = new System.Drawing.Size(115, 24);
            this.Lbl_DetailIntervenant.TabIndex = 3;
            this.Lbl_DetailIntervenant.Text = "Intervenant :";
            // 
            // Lbl_DetailType
            // 
            this.Lbl_DetailType.AutoSize = true;
            this.Lbl_DetailType.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DetailType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lbl_DetailType.Location = new System.Drawing.Point(9, 78);
            this.Lbl_DetailType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_DetailType.Name = "Lbl_DetailType";
            this.Lbl_DetailType.Size = new System.Drawing.Size(59, 24);
            this.Lbl_DetailType.TabIndex = 2;
            this.Lbl_DetailType.Text = "Type :";
            // 
            // Lbl_DetailTitre
            // 
            this.Lbl_DetailTitre.AutoSize = true;
            this.Lbl_DetailTitre.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DetailTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lbl_DetailTitre.Location = new System.Drawing.Point(8, 41);
            this.Lbl_DetailTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_DetailTitre.Name = "Lbl_DetailTitre";
            this.Lbl_DetailTitre.Size = new System.Drawing.Size(62, 24);
            this.Lbl_DetailTitre.TabIndex = 1;
            this.Lbl_DetailTitre.Text = "Titre :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_date);
            this.groupBox1.Controls.Add(this.label_date);
            this.groupBox1.Controls.Add(this.label_code);
            this.groupBox1.Controls.Add(this.label_type);
            this.groupBox1.Controls.Add(this.CB_type);
            this.groupBox1.Controls.Add(this.TB_code);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.groupBox1.Location = new System.Drawing.Point(87, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(365, 204);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chercher une activité";
            this.toolTip1.SetToolTip(this.groupBox1, "Permet de chercher une activité par son code, sa date et/ou son type");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TB_prenom);
            this.groupBox2.Controls.Add(this.label_prenom);
            this.groupBox2.Controls.Add(this.label_nom);
            this.groupBox2.Controls.Add(this.label_classe);
            this.groupBox2.Controls.Add(this.TB_nom);
            this.groupBox2.Controls.Add(this.CB_classe);
            this.groupBox2.Controls.Add(this.CB_touseleve);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.groupBox2.Location = new System.Drawing.Point(1019, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(405, 222);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chercher un élève et/ou une classe";
            this.toolTip1.SetToolTip(this.groupBox2, "Permet de chercher un élève en fonction de sa classe, son nom et/ou son prenom");
            // 
            // GestionEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 745);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GB_Detail);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.label_nb);
            this.Controls.Add(this.label_nbeleve);
            this.Controls.Add(this.btn_inscrire);
            this.Controls.Add(this.GB_selectactivite);
            this.Controls.Add(this.GB_selecteleve);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestionEleve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "d";
            this.Load += new System.EventHandler(this.InscrireEleve_Load);
            this.GB_selecteleve.ResumeLayout(false);
            this.GB_selectactivite.ResumeLayout(false);
            this.GB_Detail.ResumeLayout(false);
            this.GB_Detail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_prenom;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_classe;
        private System.Windows.Forms.TextBox TB_prenom;
        private System.Windows.Forms.TextBox TB_nom;
        private System.Windows.Forms.ComboBox CB_classe;
        private System.Windows.Forms.GroupBox GB_selecteleve;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_code;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.ComboBox CB_type;
        private System.Windows.Forms.ComboBox CB_date;
        private System.Windows.Forms.TextBox TB_code;
        private System.Windows.Forms.GroupBox GB_selectactivite;
        private System.Windows.Forms.ListBox LB_selectactivite;
        private System.Windows.Forms.Button btn_inscrire;
        private System.Windows.Forms.CheckBox CB_touseleve;
        private System.Windows.Forms.Label label_nbeleve;
        private System.Windows.Forms.Label label_nb;
        private System.Windows.Forms.CheckedListBox LB_selecteleve;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.GroupBox GB_Detail;
        private System.Windows.Forms.TextBox TB_DetailSalle;
        private System.Windows.Forms.TextBox TB_DetailPlace;
        private System.Windows.Forms.TextBox TB_DetailHeureFin;
        private System.Windows.Forms.TextBox TB_DetailHeureDebut;
        private System.Windows.Forms.TextBox TB_DetailDate;
        private System.Windows.Forms.TextBox TB_DetailIntervenant;
        private System.Windows.Forms.TextBox TB_DetailType;
        private System.Windows.Forms.TextBox TB_DetailTitre;
        private System.Windows.Forms.Label Lbl_DetailSalle;
        private System.Windows.Forms.Label Lbl_DetailPlace;
        private System.Windows.Forms.Label Lbl_DetailHeureFin;
        private System.Windows.Forms.Label Lbl_DetailHeureDebut;
        private System.Windows.Forms.Label Lbl_DetailDate;
        private System.Windows.Forms.Label Lbl_DetailIntervenant;
        private System.Windows.Forms.Label Lbl_DetailType;
        private System.Windows.Forms.Label Lbl_DetailTitre;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
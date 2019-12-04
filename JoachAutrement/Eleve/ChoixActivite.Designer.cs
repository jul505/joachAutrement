namespace JoachAutrement.Eleve
{
    partial class ChoixActivite
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
            this.Btn_Valider = new System.Windows.Forms.Button();
            this.GB_Detail = new System.Windows.Forms.GroupBox();
            this.RTB_DetailDescription = new System.Windows.Forms.RichTextBox();
            this.TB_DetailSalle = new System.Windows.Forms.TextBox();
            this.TB_DetailPlace = new System.Windows.Forms.TextBox();
            this.TB_DetailHeureFin = new System.Windows.Forms.TextBox();
            this.TB_DetailHeureDebut = new System.Windows.Forms.TextBox();
            this.TB_DetailDate = new System.Windows.Forms.TextBox();
            this.TB_DetailIntervenant = new System.Windows.Forms.TextBox();
            this.TB_DetailType = new System.Windows.Forms.TextBox();
            this.TB_DetailTitre = new System.Windows.Forms.TextBox();
            this.Lbl_DetailDescription = new System.Windows.Forms.Label();
            this.Lbl_DetailSalle = new System.Windows.Forms.Label();
            this.Lbl_DetailPlace = new System.Windows.Forms.Label();
            this.Lbl_DetailHeureFin = new System.Windows.Forms.Label();
            this.Lbl_DetailHeureDebut = new System.Windows.Forms.Label();
            this.Lbl_DetailDate = new System.Windows.Forms.Label();
            this.Lbl_DetailIntervenant = new System.Windows.Forms.Label();
            this.Lbl_DetailType = new System.Windows.Forms.Label();
            this.Lbl_DetailTitre = new System.Windows.Forms.Label();
            this.Lbl_ListeActivité = new System.Windows.Forms.Label();
            this.LB_Activité = new System.Windows.Forms.ListBox();
            this.CB_Type = new System.Windows.Forms.ComboBox();
            this.CB_Date = new System.Windows.Forms.ComboBox();
            this.Lbl_Code = new System.Windows.Forms.Label();
            this.Lbl_Type = new System.Windows.Forms.Label();
            this.Lbl_Date = new System.Windows.Forms.Label();
            this.TB_Code = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GB_Detail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Valider
            // 
            this.Btn_Valider.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Valider.Location = new System.Drawing.Point(293, 513);
            this.Btn_Valider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Valider.Name = "Btn_Valider";
            this.Btn_Valider.Size = new System.Drawing.Size(363, 41);
            this.Btn_Valider.TabIndex = 20;
            this.Btn_Valider.Text = "S\'inscrire à cette activité";
            this.Btn_Valider.UseVisualStyleBackColor = true;
            this.Btn_Valider.Click += new System.EventHandler(this.Btn_Valider_Click);
            // 
            // GB_Detail
            // 
            this.GB_Detail.Controls.Add(this.RTB_DetailDescription);
            this.GB_Detail.Controls.Add(this.TB_DetailSalle);
            this.GB_Detail.Controls.Add(this.TB_DetailPlace);
            this.GB_Detail.Controls.Add(this.TB_DetailHeureFin);
            this.GB_Detail.Controls.Add(this.TB_DetailHeureDebut);
            this.GB_Detail.Controls.Add(this.TB_DetailDate);
            this.GB_Detail.Controls.Add(this.TB_DetailIntervenant);
            this.GB_Detail.Controls.Add(this.TB_DetailType);
            this.GB_Detail.Controls.Add(this.TB_DetailTitre);
            this.GB_Detail.Controls.Add(this.Lbl_DetailDescription);
            this.GB_Detail.Controls.Add(this.Lbl_DetailSalle);
            this.GB_Detail.Controls.Add(this.Lbl_DetailPlace);
            this.GB_Detail.Controls.Add(this.Lbl_DetailHeureFin);
            this.GB_Detail.Controls.Add(this.Lbl_DetailHeureDebut);
            this.GB_Detail.Controls.Add(this.Lbl_DetailDate);
            this.GB_Detail.Controls.Add(this.Lbl_DetailIntervenant);
            this.GB_Detail.Controls.Add(this.Lbl_DetailType);
            this.GB_Detail.Controls.Add(this.Lbl_DetailTitre);
            this.GB_Detail.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Detail.Location = new System.Drawing.Point(693, 206);
            this.GB_Detail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GB_Detail.Name = "GB_Detail";
            this.GB_Detail.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GB_Detail.Size = new System.Drawing.Size(721, 308);
            this.GB_Detail.TabIndex = 19;
            this.GB_Detail.TabStop = false;
            this.GB_Detail.Text = "Détails";
            this.toolTip1.SetToolTip(this.GB_Detail, "Affiche le détail de toutes les activités");
            // 
            // RTB_DetailDescription
            // 
            this.RTB_DetailDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB_DetailDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RTB_DetailDescription.Location = new System.Drawing.Point(385, 137);
            this.RTB_DetailDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RTB_DetailDescription.Name = "RTB_DetailDescription";
            this.RTB_DetailDescription.ReadOnly = true;
            this.RTB_DetailDescription.Size = new System.Drawing.Size(313, 144);
            this.RTB_DetailDescription.TabIndex = 18;
            this.RTB_DetailDescription.Text = "";
            // 
            // TB_DetailSalle
            // 
            this.TB_DetailSalle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_DetailSalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TB_DetailSalle.Location = new System.Drawing.Point(452, 74);
            this.TB_DetailSalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_DetailSalle.Name = "TB_DetailSalle";
            this.TB_DetailSalle.ReadOnly = true;
            this.TB_DetailSalle.Size = new System.Drawing.Size(227, 30);
            this.TB_DetailSalle.TabIndex = 17;
            // 
            // TB_DetailPlace
            // 
            this.TB_DetailPlace.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_DetailPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TB_DetailPlace.Location = new System.Drawing.Point(547, 37);
            this.TB_DetailPlace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.TB_DetailHeureFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.TB_DetailHeureDebut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.TB_DetailDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.TB_DetailIntervenant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.TB_DetailType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.TB_DetailTitre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_DetailTitre.Name = "TB_DetailTitre";
            this.TB_DetailTitre.ReadOnly = true;
            this.TB_DetailTitre.Size = new System.Drawing.Size(227, 30);
            this.TB_DetailTitre.TabIndex = 10;
            // 
            // Lbl_DetailDescription
            // 
            this.Lbl_DetailDescription.AutoSize = true;
            this.Lbl_DetailDescription.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DetailDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lbl_DetailDescription.Location = new System.Drawing.Point(381, 110);
            this.Lbl_DetailDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_DetailDescription.Name = "Lbl_DetailDescription";
            this.Lbl_DetailDescription.Size = new System.Drawing.Size(102, 24);
            this.Lbl_DetailDescription.TabIndex = 9;
            this.Lbl_DetailDescription.Text = "Descriptif :";
            // 
            // Lbl_DetailSalle
            // 
            this.Lbl_DetailSalle.AutoSize = true;
            this.Lbl_DetailSalle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DetailSalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lbl_DetailSalle.Location = new System.Drawing.Point(381, 74);
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
            this.Lbl_DetailPlace.Location = new System.Drawing.Point(381, 41);
            this.Lbl_DetailPlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_DetailPlace.Name = "Lbl_DetailPlace";
            this.Lbl_DetailPlace.Size = new System.Drawing.Size(161, 24);
            this.Lbl_DetailPlace.TabIndex = 7;
            this.Lbl_DetailPlace.Text = "Nombre de places :";
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
            // Lbl_ListeActivité
            // 
            this.Lbl_ListeActivité.AutoSize = true;
            this.Lbl_ListeActivité.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ListeActivité.Location = new System.Drawing.Point(205, 182);
            this.Lbl_ListeActivité.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ListeActivité.Name = "Lbl_ListeActivité";
            this.Lbl_ListeActivité.Size = new System.Drawing.Size(211, 24);
            this.Lbl_ListeActivité.TabIndex = 18;
            this.Lbl_ListeActivité.Text = "Liste des Activités triées";
            // 
            // LB_Activité
            // 
            this.LB_Activité.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Activité.FormattingEnabled = true;
            this.LB_Activité.HorizontalScrollbar = true;
            this.LB_Activité.ItemHeight = 26;
            this.LB_Activité.Location = new System.Drawing.Point(209, 210);
            this.LB_Activité.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LB_Activité.Name = "LB_Activité";
            this.LB_Activité.Size = new System.Drawing.Size(463, 238);
            this.LB_Activité.TabIndex = 17;
            this.LB_Activité.SelectedIndexChanged += new System.EventHandler(this.LB_Activité_SelectedIndexChanged);
            // 
            // CB_Type
            // 
            this.CB_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Type.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Type.FormattingEnabled = true;
            this.CB_Type.Location = new System.Drawing.Point(251, 89);
            this.CB_Type.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CB_Type.Name = "CB_Type";
            this.CB_Type.Size = new System.Drawing.Size(313, 31);
            this.CB_Type.Sorted = true;
            this.CB_Type.TabIndex = 15;
            this.toolTip1.SetToolTip(this.CB_Type, "Permet de filtrer les activités en fonctions  sélectionné");
            this.CB_Type.SelectedIndexChanged += new System.EventHandler(this.CB_Type_SelectedIndexChanged);
            // 
            // CB_Date
            // 
            this.CB_Date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Date.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Date.FormattingEnabled = true;
            this.CB_Date.Location = new System.Drawing.Point(251, 27);
            this.CB_Date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CB_Date.Name = "CB_Date";
            this.CB_Date.Size = new System.Drawing.Size(313, 31);
            this.CB_Date.Sorted = true;
            this.CB_Date.TabIndex = 14;
            this.toolTip1.SetToolTip(this.CB_Date, "Permet de filtrer les activités en fonctions de la date sélectionné");
            this.CB_Date.SelectedIndexChanged += new System.EventHandler(this.CB_Date_SelectedIndexChanged);
            // 
            // Lbl_Code
            // 
            this.Lbl_Code.AutoSize = true;
            this.Lbl_Code.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Code.Location = new System.Drawing.Point(681, 37);
            this.Lbl_Code.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Code.Name = "Lbl_Code";
            this.Lbl_Code.Size = new System.Drawing.Size(187, 28);
            this.Lbl_Code.TabIndex = 13;
            this.Lbl_Code.Text = "Code de l\'activité :";
            // 
            // Lbl_Type
            // 
            this.Lbl_Type.AutoSize = true;
            this.Lbl_Type.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Type.Location = new System.Drawing.Point(37, 92);
            this.Lbl_Type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Type.Name = "Lbl_Type";
            this.Lbl_Type.Size = new System.Drawing.Size(187, 28);
            this.Lbl_Type.TabIndex = 12;
            this.Lbl_Type.Text = "Type de l\'activité :";
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.AutoSize = true;
            this.Lbl_Date.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Date.Location = new System.Drawing.Point(37, 31);
            this.Lbl_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(184, 28);
            this.Lbl_Date.TabIndex = 11;
            this.Lbl_Date.Text = "Date de l\'activité :";
            // 
            // TB_Code
            // 
            this.TB_Code.Location = new System.Drawing.Point(672, 69);
            this.TB_Code.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_Code.Name = "TB_Code";
            this.TB_Code.Size = new System.Drawing.Size(231, 35);
            this.TB_Code.TabIndex = 22;
            this.toolTip1.SetToolTip(this.TB_Code, "Permet de filtrer les activités en fonctions du code recherché\r\n");
            this.TB_Code.TextChanged += new System.EventHandler(this.TB_Code_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(209, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 95);
            this.button1.TabIndex = 23;
            this.button1.Text = "Rechercher à l\'aide de filtres\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbl_Date);
            this.groupBox1.Controls.Add(this.Lbl_Type);
            this.groupBox1.Controls.Add(this.TB_Code);
            this.groupBox1.Controls.Add(this.Lbl_Code);
            this.groupBox1.Controls.Add(this.CB_Date);
            this.groupBox1.Controls.Add(this.CB_Type);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.groupBox1.Location = new System.Drawing.Point(459, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(956, 132);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtres";
            this.groupBox1.Visible = false;
            // 
            // ChoixActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1757, 647);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Valider);
            this.Controls.Add(this.GB_Detail);
            this.Controls.Add(this.Lbl_ListeActivité);
            this.Controls.Add(this.LB_Activité);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChoixActivite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ChoixActivite";
            this.Load += new System.EventHandler(this.ChoixActivite_Load);
            this.GB_Detail.ResumeLayout(false);
            this.GB_Detail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Valider;
        private System.Windows.Forms.GroupBox GB_Detail;
        private System.Windows.Forms.RichTextBox RTB_DetailDescription;
        private System.Windows.Forms.TextBox TB_DetailSalle;
        private System.Windows.Forms.TextBox TB_DetailPlace;
        private System.Windows.Forms.TextBox TB_DetailHeureFin;
        private System.Windows.Forms.TextBox TB_DetailHeureDebut;
        private System.Windows.Forms.TextBox TB_DetailDate;
        private System.Windows.Forms.TextBox TB_DetailIntervenant;
        private System.Windows.Forms.TextBox TB_DetailType;
        private System.Windows.Forms.TextBox TB_DetailTitre;
        private System.Windows.Forms.Label Lbl_DetailDescription;
        private System.Windows.Forms.Label Lbl_DetailSalle;
        private System.Windows.Forms.Label Lbl_DetailPlace;
        private System.Windows.Forms.Label Lbl_DetailHeureFin;
        private System.Windows.Forms.Label Lbl_DetailHeureDebut;
        private System.Windows.Forms.Label Lbl_DetailDate;
        private System.Windows.Forms.Label Lbl_DetailIntervenant;
        private System.Windows.Forms.Label Lbl_DetailType;
        private System.Windows.Forms.Label Lbl_DetailTitre;
        private System.Windows.Forms.Label Lbl_ListeActivité;
        private System.Windows.Forms.ListBox LB_Activité;
        private System.Windows.Forms.ComboBox CB_Type;
        private System.Windows.Forms.ComboBox CB_Date;
        private System.Windows.Forms.Label Lbl_Code;
        private System.Windows.Forms.Label Lbl_Type;
        private System.Windows.Forms.Label Lbl_Date;
        private System.Windows.Forms.TextBox TB_Code;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
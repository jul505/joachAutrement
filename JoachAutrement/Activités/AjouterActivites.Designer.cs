namespace JoachAutrement.Activités
{
    partial class AjouterActivites
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
            this.TextBoxSalle = new System.Windows.Forms.TextBox();
            this.Btn_Intervenant = new System.Windows.Forms.Button();
            this.Lbl_SalleActivite = new System.Windows.Forms.Label();
            this.RichTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.Btn_Ajouter = new System.Windows.Forms.Button();
            this.ComboBoxHeureF = new System.Windows.Forms.ComboBox();
            this.ComboBoxHeureD = new System.Windows.Forms.ComboBox();
            this.ComboBoxDate = new System.Windows.Forms.ComboBox();
            this.Lbl_DescriptionActivite = new System.Windows.Forms.Label();
            this.TextBoxPlaces = new System.Windows.Forms.TextBox();
            this.Lbl_PlaceActivite = new System.Windows.Forms.Label();
            this.lbl_HeureFinActivite = new System.Windows.Forms.Label();
            this.Lbl_HeureDebutActivite = new System.Windows.Forms.Label();
            this.Lbl_DateActivite = new System.Windows.Forms.Label();
            this.Lbl_Intervenant = new System.Windows.Forms.Label();
            this.Lbl_TypeActivite = new System.Windows.Forms.Label();
            this.TextBoxLibelle = new System.Windows.Forms.TextBox();
            this.Lbl_TitreActivite = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.comboBoxIntervenant = new System.Windows.Forms.ComboBox();
            this.richTextBoxEntete = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPublic = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // TextBoxSalle
            // 
            this.TextBoxSalle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSalle.Location = new System.Drawing.Point(275, 705);
            this.TextBoxSalle.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxSalle.Name = "TextBoxSalle";
            this.TextBoxSalle.Size = new System.Drawing.Size(169, 35);
            this.TextBoxSalle.TabIndex = 71;
            this.toolTip1.SetToolTip(this.TextBoxSalle, "peut etre laissé vide");
            // 
            // Btn_Intervenant
            // 
            this.Btn_Intervenant.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Intervenant.Location = new System.Drawing.Point(275, 140);
            this.Btn_Intervenant.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Intervenant.Name = "Btn_Intervenant";
            this.Btn_Intervenant.Size = new System.Drawing.Size(387, 37);
            this.Btn_Intervenant.TabIndex = 68;
            this.Btn_Intervenant.Text = "Ajouter des nouveaux Intervenants";
            this.toolTip1.SetToolTip(this.Btn_Intervenant, "Si l\'intervenant n\'existe pas dans la liste ci dessous, vous pouvez l\'ajouter ici" +
        ".\r\n");
            this.Btn_Intervenant.UseVisualStyleBackColor = true;
            this.Btn_Intervenant.Click += new System.EventHandler(this.Btn_Intervenant_Click);
            // 
            // Lbl_SalleActivite
            // 
            this.Lbl_SalleActivite.AutoSize = true;
            this.Lbl_SalleActivite.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SalleActivite.Location = new System.Drawing.Point(190, 708);
            this.Lbl_SalleActivite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_SalleActivite.Name = "Lbl_SalleActivite";
            this.Lbl_SalleActivite.Size = new System.Drawing.Size(69, 28);
            this.Lbl_SalleActivite.TabIndex = 67;
            this.Lbl_SalleActivite.Text = "Salle :";
            // 
            // RichTextBoxDescription
            // 
            this.RichTextBoxDescription.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RichTextBoxDescription.Location = new System.Drawing.Point(811, 328);
            this.RichTextBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.RichTextBoxDescription.Name = "RichTextBoxDescription";
            this.RichTextBoxDescription.Size = new System.Drawing.Size(593, 435);
            this.RichTextBoxDescription.TabIndex = 66;
            this.RichTextBoxDescription.Text = "";
            // 
            // Btn_Ajouter
            // 
            this.Btn_Ajouter.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ajouter.Location = new System.Drawing.Point(613, 838);
            this.Btn_Ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Ajouter.Name = "Btn_Ajouter";
            this.Btn_Ajouter.Size = new System.Drawing.Size(137, 42);
            this.Btn_Ajouter.TabIndex = 65;
            this.Btn_Ajouter.Text = "Ajouter";
            this.Btn_Ajouter.UseVisualStyleBackColor = true;
            this.Btn_Ajouter.Visible = false;
            // 
            // ComboBoxHeureF
            // 
            this.ComboBoxHeureF.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxHeureF.FormattingEnabled = true;
            this.ComboBoxHeureF.Items.AddRange(new object[] {
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00"});
            this.ComboBoxHeureF.Location = new System.Drawing.Point(277, 476);
            this.ComboBoxHeureF.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxHeureF.Name = "ComboBoxHeureF";
            this.ComboBoxHeureF.Size = new System.Drawing.Size(385, 36);
            this.ComboBoxHeureF.TabIndex = 64;
            this.toolTip1.SetToolTip(this.ComboBoxHeureF, "Vous pouvez taper l\'heure vous même si vous respectez le format => hh:mm");
            // 
            // ComboBoxHeureD
            // 
            this.ComboBoxHeureD.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxHeureD.FormattingEnabled = true;
            this.ComboBoxHeureD.Items.AddRange(new object[] {
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00"});
            this.ComboBoxHeureD.Location = new System.Drawing.Point(277, 409);
            this.ComboBoxHeureD.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxHeureD.Name = "ComboBoxHeureD";
            this.ComboBoxHeureD.Size = new System.Drawing.Size(385, 36);
            this.ComboBoxHeureD.TabIndex = 63;
            this.toolTip1.SetToolTip(this.ComboBoxHeureD, "Vous pouvez taper l\'heure vous même si vous respectez le format => hh:mm");
            // 
            // ComboBoxDate
            // 
            this.ComboBoxDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDate.FormattingEnabled = true;
            this.ComboBoxDate.Location = new System.Drawing.Point(277, 345);
            this.ComboBoxDate.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxDate.Name = "ComboBoxDate";
            this.ComboBoxDate.Size = new System.Drawing.Size(385, 36);
            this.ComboBoxDate.TabIndex = 62;
            // 
            // Lbl_DescriptionActivite
            // 
            this.Lbl_DescriptionActivite.AutoSize = true;
            this.Lbl_DescriptionActivite.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DescriptionActivite.Location = new System.Drawing.Point(894, 288);
            this.Lbl_DescriptionActivite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_DescriptionActivite.Name = "Lbl_DescriptionActivite";
            this.Lbl_DescriptionActivite.Size = new System.Drawing.Size(237, 28);
            this.Lbl_DescriptionActivite.TabIndex = 60;
            this.Lbl_DescriptionActivite.Text = "Descriptif de l\'activité :";
            // 
            // TextBoxPlaces
            // 
            this.TextBoxPlaces.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPlaces.Location = new System.Drawing.Point(275, 634);
            this.TextBoxPlaces.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPlaces.Name = "TextBoxPlaces";
            this.TextBoxPlaces.Size = new System.Drawing.Size(169, 35);
            this.TextBoxPlaces.TabIndex = 59;
            this.toolTip1.SetToolTip(this.TextBoxPlaces, "si vide alors 0 places");
            this.TextBoxPlaces.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPlaces_KeyPress);
            // 
            // Lbl_PlaceActivite
            // 
            this.Lbl_PlaceActivite.AutoSize = true;
            this.Lbl_PlaceActivite.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PlaceActivite.Location = new System.Drawing.Point(69, 637);
            this.Lbl_PlaceActivite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_PlaceActivite.Name = "Lbl_PlaceActivite";
            this.Lbl_PlaceActivite.Size = new System.Drawing.Size(190, 28);
            this.Lbl_PlaceActivite.TabIndex = 58;
            this.Lbl_PlaceActivite.Text = "Nombre de Places :";
            // 
            // lbl_HeureFinActivite
            // 
            this.lbl_HeureFinActivite.AutoSize = true;
            this.lbl_HeureFinActivite.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HeureFinActivite.Location = new System.Drawing.Point(95, 476);
            this.lbl_HeureFinActivite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HeureFinActivite.Name = "lbl_HeureFinActivite";
            this.lbl_HeureFinActivite.Size = new System.Drawing.Size(142, 28);
            this.lbl_HeureFinActivite.TabIndex = 55;
            this.lbl_HeureFinActivite.Text = "Heure de fin :";
            // 
            // Lbl_HeureDebutActivite
            // 
            this.Lbl_HeureDebutActivite.AutoSize = true;
            this.Lbl_HeureDebutActivite.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_HeureDebutActivite.Location = new System.Drawing.Point(69, 409);
            this.Lbl_HeureDebutActivite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_HeureDebutActivite.Name = "Lbl_HeureDebutActivite";
            this.Lbl_HeureDebutActivite.Size = new System.Drawing.Size(169, 28);
            this.Lbl_HeureDebutActivite.TabIndex = 54;
            this.Lbl_HeureDebutActivite.Text = "Heure de début :";
            // 
            // Lbl_DateActivite
            // 
            this.Lbl_DateActivite.AutoSize = true;
            this.Lbl_DateActivite.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DateActivite.Location = new System.Drawing.Point(173, 345);
            this.Lbl_DateActivite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_DateActivite.Name = "Lbl_DateActivite";
            this.Lbl_DateActivite.Size = new System.Drawing.Size(67, 28);
            this.Lbl_DateActivite.TabIndex = 53;
            this.Lbl_DateActivite.Text = "Date :";
            // 
            // Lbl_Intervenant
            // 
            this.Lbl_Intervenant.AutoSize = true;
            this.Lbl_Intervenant.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Intervenant.Location = new System.Drawing.Point(101, 207);
            this.Lbl_Intervenant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Intervenant.Name = "Lbl_Intervenant";
            this.Lbl_Intervenant.Size = new System.Drawing.Size(133, 28);
            this.Lbl_Intervenant.TabIndex = 52;
            this.Lbl_Intervenant.Text = "Intervenant :";
            // 
            // Lbl_TypeActivite
            // 
            this.Lbl_TypeActivite.AutoSize = true;
            this.Lbl_TypeActivite.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TypeActivite.Location = new System.Drawing.Point(41, 275);
            this.Lbl_TypeActivite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_TypeActivite.Name = "Lbl_TypeActivite";
            this.Lbl_TypeActivite.Size = new System.Drawing.Size(187, 28);
            this.Lbl_TypeActivite.TabIndex = 51;
            this.Lbl_TypeActivite.Text = "Type de l\'activité :";
            // 
            // TextBoxLibelle
            // 
            this.TextBoxLibelle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLibelle.Location = new System.Drawing.Point(277, 57);
            this.TextBoxLibelle.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxLibelle.Name = "TextBoxLibelle";
            this.TextBoxLibelle.Size = new System.Drawing.Size(1127, 35);
            this.TextBoxLibelle.TabIndex = 50;
            this.toolTip1.SetToolTip(this.TextBoxLibelle, "Ce champ ne doit pas être vide");
            // 
            // Lbl_TitreActivite
            // 
            this.Lbl_TitreActivite.AutoSize = true;
            this.Lbl_TitreActivite.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitreActivite.Location = new System.Drawing.Point(39, 64);
            this.Lbl_TitreActivite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_TitreActivite.Name = "Lbl_TitreActivite";
            this.Lbl_TitreActivite.Size = new System.Drawing.Size(190, 28);
            this.Lbl_TitreActivite.TabIndex = 49;
            this.Lbl_TitreActivite.Text = "Titre de l\'activité :";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(277, 278);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(385, 36);
            this.comboBoxType.TabIndex = 73;
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(504, 671);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(286, 69);
            this.buttonOK.TabIndex = 74;
            this.buttonOK.Text = "Ajouter l\'activité";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // comboBoxIntervenant
            // 
            this.comboBoxIntervenant.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxIntervenant.BackColor = System.Drawing.Color.White;
            this.comboBoxIntervenant.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIntervenant.ForeColor = System.Drawing.Color.Black;
            this.comboBoxIntervenant.FormattingEnabled = true;
            this.comboBoxIntervenant.Location = new System.Drawing.Point(277, 207);
            this.comboBoxIntervenant.Name = "comboBoxIntervenant";
            this.comboBoxIntervenant.Size = new System.Drawing.Size(385, 36);
            this.comboBoxIntervenant.TabIndex = 75;
            this.toolTip1.SetToolTip(this.comboBoxIntervenant, "Si vous vous perdez dans la liste, tapez le nom ou prenom de l\'intervenant que vo" +
        "us rechechez\r\n(une lettre suffit pout filtrer)");
            this.comboBoxIntervenant.DropDown += new System.EventHandler(this.comboBoxIntervenant_DropDown);
            // 
            // richTextBoxEntete
            // 
            this.richTextBoxEntete.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.richTextBoxEntete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBoxEntete.Location = new System.Drawing.Point(811, 150);
            this.richTextBoxEntete.Name = "richTextBoxEntete";
            this.richTextBoxEntete.Size = new System.Drawing.Size(593, 117);
            this.richTextBoxEntete.TabIndex = 76;
            this.richTextBoxEntete.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(894, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 28);
            this.label1.TabIndex = 77;
            this.label1.Text = "Entête de l\'activité :";
            // 
            // comboBoxPublic
            // 
            this.comboBoxPublic.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPublic.FormattingEnabled = true;
            this.comboBoxPublic.Items.AddRange(new object[] {
            "1ères",
            "Terminales",
            "Tout public"});
            this.comboBoxPublic.Location = new System.Drawing.Point(277, 538);
            this.comboBoxPublic.Name = "comboBoxPublic";
            this.comboBoxPublic.Size = new System.Drawing.Size(385, 36);
            this.comboBoxPublic.TabIndex = 78;
            this.comboBoxPublic.Text = "Tout public";
            this.toolTip1.SetToolTip(this.comboBoxPublic, "Tapez ce que vous voulez, ou choisissez dans la liste");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 541);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 79;
            this.label2.Text = "Public :";
            // 
            // AjouterActivites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 790);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPublic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxEntete);
            this.Controls.Add(this.comboBoxIntervenant);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.TextBoxSalle);
            this.Controls.Add(this.Btn_Intervenant);
            this.Controls.Add(this.Lbl_SalleActivite);
            this.Controls.Add(this.RichTextBoxDescription);
            this.Controls.Add(this.Btn_Ajouter);
            this.Controls.Add(this.ComboBoxHeureF);
            this.Controls.Add(this.ComboBoxHeureD);
            this.Controls.Add(this.ComboBoxDate);
            this.Controls.Add(this.Lbl_DescriptionActivite);
            this.Controls.Add(this.TextBoxPlaces);
            this.Controls.Add(this.Lbl_PlaceActivite);
            this.Controls.Add(this.lbl_HeureFinActivite);
            this.Controls.Add(this.Lbl_HeureDebutActivite);
            this.Controls.Add(this.Lbl_DateActivite);
            this.Controls.Add(this.Lbl_Intervenant);
            this.Controls.Add(this.Lbl_TypeActivite);
            this.Controls.Add(this.TextBoxLibelle);
            this.Controls.Add(this.Lbl_TitreActivite);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AjouterActivites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Une Activité";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxSalle;
        private System.Windows.Forms.Button Btn_Intervenant;
        private System.Windows.Forms.Label Lbl_SalleActivite;
        private System.Windows.Forms.RichTextBox RichTextBoxDescription;
        private System.Windows.Forms.Button Btn_Ajouter;
        private System.Windows.Forms.ComboBox ComboBoxHeureF;
        private System.Windows.Forms.ComboBox ComboBoxHeureD;
        private System.Windows.Forms.ComboBox ComboBoxDate;
        private System.Windows.Forms.Label Lbl_DescriptionActivite;
        private System.Windows.Forms.TextBox TextBoxPlaces;
        private System.Windows.Forms.Label Lbl_PlaceActivite;
        private System.Windows.Forms.Label lbl_HeureFinActivite;
        private System.Windows.Forms.Label Lbl_HeureDebutActivite;
        private System.Windows.Forms.Label Lbl_DateActivite;
        private System.Windows.Forms.Label Lbl_Intervenant;
        private System.Windows.Forms.Label Lbl_TypeActivite;
        private System.Windows.Forms.TextBox TextBoxLibelle;
        private System.Windows.Forms.Label Lbl_TitreActivite;
        public System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.RichTextBox richTextBoxEntete;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBoxPublic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.ComboBox comboBoxIntervenant;
    }
}
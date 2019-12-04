namespace JoachAutrement
{
    partial class FormAdministrateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrateur));
            this.dateTimePickerInscriptionProf = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInscriptionEleve = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnValiderDatesInscrit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnValiderDatesEvenement = new System.Windows.Forms.Button();
            this.btnSupprDateProf = new System.Windows.Forms.Button();
            this.btnSupprDateEleve = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonPorfsTertiaires = new System.Windows.Forms.Button();
            this.buttonElevesTertiaires = new System.Windows.Forms.Button();
            this.buttonProfsGeneraux = new System.Windows.Forms.Button();
            this.buttonEleveGeneraux = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonHide = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerInscriptionProf
            // 
            this.dateTimePickerInscriptionProf.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.dateTimePickerInscriptionProf.Location = new System.Drawing.Point(231, 74);
            this.dateTimePickerInscriptionProf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerInscriptionProf.Name = "dateTimePickerInscriptionProf";
            this.dateTimePickerInscriptionProf.Size = new System.Drawing.Size(352, 35);
            this.dateTimePickerInscriptionProf.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dateTimePickerInscriptionProf, "Correspond à la date ou les professeurs pourront commencer à inscrire les élèves");
            this.dateTimePickerInscriptionProf.Value = new System.DateTime(2017, 1, 30, 0, 0, 0, 0);
            // 
            // dateTimePickerInscriptionEleve
            // 
            this.dateTimePickerInscriptionEleve.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.dateTimePickerInscriptionEleve.Location = new System.Drawing.Point(231, 167);
            this.dateTimePickerInscriptionEleve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerInscriptionEleve.Name = "dateTimePickerInscriptionEleve";
            this.dateTimePickerInscriptionEleve.Size = new System.Drawing.Size(352, 35);
            this.dateTimePickerInscriptionEleve.TabIndex = 2;
            this.toolTip1.SetToolTip(this.dateTimePickerInscriptionEleve, "Correspond à la date ou les élèves pourront commencer à s\'inscrire");
            this.dateTimePickerInscriptionEleve.Value = new System.DateTime(2017, 1, 30, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label1.Location = new System.Drawing.Point(125, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date du debut des Inscriptions des Professeurs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label2.Location = new System.Drawing.Point(128, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date du debut des Inscriptions des Elèves";
            // 
            // BtnValiderDatesInscrit
            // 
            this.BtnValiderDatesInscrit.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.BtnValiderDatesInscrit.Location = new System.Drawing.Point(376, 239);
            this.BtnValiderDatesInscrit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnValiderDatesInscrit.Name = "BtnValiderDatesInscrit";
            this.BtnValiderDatesInscrit.Size = new System.Drawing.Size(427, 73);
            this.BtnValiderDatesInscrit.TabIndex = 13;
            this.BtnValiderDatesInscrit.Text = "Valider les dates de debut des inscriptions";
            this.toolTip1.SetToolTip(this.BtnValiderDatesInscrit, "Permet d\'enregistrer les dates de début des inscriptions");
            this.BtnValiderDatesInscrit.UseVisualStyleBackColor = true;
            this.BtnValiderDatesInscrit.Click += new System.EventHandler(this.BtnValiderDatesInscrit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnValiderDatesEvenement
            // 
            this.BtnValiderDatesEvenement.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.BtnValiderDatesEvenement.Location = new System.Drawing.Point(1003, 479);
            this.BtnValiderDatesEvenement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnValiderDatesEvenement.Name = "BtnValiderDatesEvenement";
            this.BtnValiderDatesEvenement.Size = new System.Drawing.Size(412, 72);
            this.BtnValiderDatesEvenement.TabIndex = 16;
            this.BtnValiderDatesEvenement.Text = "Valider les Dates de l\'évènement Joach\'autrement";
            this.BtnValiderDatesEvenement.UseVisualStyleBackColor = true;
            this.BtnValiderDatesEvenement.Click += new System.EventHandler(this.BtnValiderDatesEvenement_Click);
            // 
            // btnSupprDateProf
            // 
            this.btnSupprDateProf.Enabled = false;
            this.btnSupprDateProf.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnSupprDateProf.Location = new System.Drawing.Point(627, 60);
            this.btnSupprDateProf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupprDateProf.Name = "btnSupprDateProf";
            this.btnSupprDateProf.Size = new System.Drawing.Size(243, 66);
            this.btnSupprDateProf.TabIndex = 42;
            this.btnSupprDateProf.Text = "Autoriser les inscriptions maintenant";
            this.toolTip1.SetToolTip(this.btnSupprDateProf, resources.GetString("btnSupprDateProf.ToolTip"));
            this.btnSupprDateProf.UseVisualStyleBackColor = true;
            this.btnSupprDateProf.Click += new System.EventHandler(this.btnSupprDateProf_Click);
            // 
            // btnSupprDateEleve
            // 
            this.btnSupprDateEleve.Enabled = false;
            this.btnSupprDateEleve.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnSupprDateEleve.Location = new System.Drawing.Point(627, 155);
            this.btnSupprDateEleve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupprDateEleve.Name = "btnSupprDateEleve";
            this.btnSupprDateEleve.Size = new System.Drawing.Size(243, 69);
            this.btnSupprDateEleve.TabIndex = 43;
            this.btnSupprDateEleve.Text = "Autoriser les inscriptions maintenant\r\n";
            this.toolTip1.SetToolTip(this.btnSupprDateEleve, resources.GetString("btnSupprDateEleve.ToolTip"));
            this.btnSupprDateEleve.UseVisualStyleBackColor = true;
            this.btnSupprDateEleve.Click += new System.EventHandler(this.btnSupprDateEleve_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(943, 43);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(515, 414);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // buttonPorfsTertiaires
            // 
            this.buttonPorfsTertiaires.Location = new System.Drawing.Point(385, 98);
            this.buttonPorfsTertiaires.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPorfsTertiaires.Name = "buttonPorfsTertiaires";
            this.buttonPorfsTertiaires.Size = new System.Drawing.Size(277, 78);
            this.buttonPorfsTertiaires.TabIndex = 46;
            this.buttonPorfsTertiaires.Text = "Les comptes Professeurs tertiaires";
            this.buttonPorfsTertiaires.UseVisualStyleBackColor = true;
            this.buttonPorfsTertiaires.Click += new System.EventHandler(this.buttonPorfsTertiaires_Click);
            // 
            // buttonElevesTertiaires
            // 
            this.buttonElevesTertiaires.Location = new System.Drawing.Point(51, 98);
            this.buttonElevesTertiaires.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonElevesTertiaires.Name = "buttonElevesTertiaires";
            this.buttonElevesTertiaires.Size = new System.Drawing.Size(297, 78);
            this.buttonElevesTertiaires.TabIndex = 45;
            this.buttonElevesTertiaires.Text = "Les comptes Elèves tertiaires";
            this.buttonElevesTertiaires.UseVisualStyleBackColor = true;
            this.buttonElevesTertiaires.Click += new System.EventHandler(this.buttonElevesTertiaires_Click);
            // 
            // buttonProfsGeneraux
            // 
            this.buttonProfsGeneraux.Location = new System.Drawing.Point(385, 34);
            this.buttonProfsGeneraux.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonProfsGeneraux.Name = "buttonProfsGeneraux";
            this.buttonProfsGeneraux.Size = new System.Drawing.Size(277, 68);
            this.buttonProfsGeneraux.TabIndex = 50;
            this.buttonProfsGeneraux.Text = "Les comptes Professeurs generaux";
            this.buttonProfsGeneraux.UseVisualStyleBackColor = true;
            this.buttonProfsGeneraux.Click += new System.EventHandler(this.buttonProfsGeneraux_Click);
            // 
            // buttonEleveGeneraux
            // 
            this.buttonEleveGeneraux.Location = new System.Drawing.Point(51, 34);
            this.buttonEleveGeneraux.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEleveGeneraux.Name = "buttonEleveGeneraux";
            this.buttonEleveGeneraux.Size = new System.Drawing.Size(297, 68);
            this.buttonEleveGeneraux.TabIndex = 49;
            this.buttonEleveGeneraux.Text = "Les comptes Elèves generaux";
            this.buttonEleveGeneraux.UseVisualStyleBackColor = true;
            this.buttonEleveGeneraux.Click += new System.EventHandler(this.buttonEleveGeneraux_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.buttonProfsGeneraux);
            this.groupBox1.Controls.Add(this.buttonElevesTertiaires);
            this.groupBox1.Controls.Add(this.buttonEleveGeneraux);
            this.groupBox1.Controls.Add(this.buttonPorfsTertiaires);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.groupBox1.Location = new System.Drawing.Point(39, 341);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(703, 291);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Importer des Comptes";
            this.groupBox1.Visible = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(196, 208);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(297, 39);
            this.buttonSave.TabIndex = 51;
            this.buttonSave.Text = "Sauvegarder les Comptes dans la Base";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonHide
            // 
            this.buttonHide.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.buttonHide.Location = new System.Drawing.Point(39, 294);
            this.buttonHide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(253, 41);
            this.buttonHide.TabIndex = 52;
            this.buttonHide.Text = "Importer des comptes";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(196, 252);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(297, 14);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 52;
            this.progressBar1.Visible = false;
            // 
            // FormAdministrateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 655);
            this.Controls.Add(this.buttonHide);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSupprDateEleve);
            this.Controls.Add(this.btnSupprDateProf);
            this.Controls.Add(this.BtnValiderDatesEvenement);
            this.Controls.Add(this.BtnValiderDatesInscrit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerInscriptionEleve);
            this.Controls.Add(this.dateTimePickerInscriptionProf);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAdministrateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Administrateur";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerInscriptionProf;
        private System.Windows.Forms.DateTimePicker dateTimePickerInscriptionEleve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnValiderDatesInscrit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnValiderDatesEvenement;
        private System.Windows.Forms.Button btnSupprDateProf;
        private System.Windows.Forms.Button btnSupprDateEleve;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonPorfsTertiaires;
        private System.Windows.Forms.Button buttonElevesTertiaires;
        private System.Windows.Forms.Button buttonProfsGeneraux;
        private System.Windows.Forms.Button buttonEleveGeneraux;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
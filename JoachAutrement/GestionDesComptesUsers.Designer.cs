namespace JoachAutrement
{
    partial class GestionDesComptesUsers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxClasse = new System.Windows.Forms.ComboBox();
            this.checkBoxId2 = new System.Windows.Forms.CheckBox();
            this.checkBoxId3 = new System.Windows.Forms.CheckBox();
            this.checkBoxId4 = new System.Windows.Forms.CheckBox();
            this.checkBoxexterne = new System.Windows.Forms.CheckBox();
            this.checkBoxinterne = new System.Windows.Forms.CheckBox();
            this.buttonRecherche = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(15, 164);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1223, 536);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 76);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nom";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(103, 74);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(235, 35);
            this.textBoxNom.TabIndex = 10;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(103, 34);
            this.textBoxPrenom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(235, 35);
            this.textBoxPrenom.TabIndex = 9;
            this.textBoxPrenom.TextChanged += new System.EventHandler(this.textBoxPrenom_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Classe";
            // 
            // comboBoxClasse
            // 
            this.comboBoxClasse.FormattingEnabled = true;
            this.comboBoxClasse.Location = new System.Drawing.Point(469, 34);
            this.comboBoxClasse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxClasse.Name = "comboBoxClasse";
            this.comboBoxClasse.Size = new System.Drawing.Size(225, 36);
            this.comboBoxClasse.TabIndex = 7;
            this.comboBoxClasse.SelectedIndexChanged += new System.EventHandler(this.comboBoxClasse_SelectedIndexChanged);
            this.comboBoxClasse.TextChanged += new System.EventHandler(this.comboBoxClasse_TextChanged);
            // 
            // checkBoxId2
            // 
            this.checkBoxId2.AutoSize = true;
            this.checkBoxId2.Checked = true;
            this.checkBoxId2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxId2.Location = new System.Drawing.Point(776, 37);
            this.checkBoxId2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxId2.Name = "checkBoxId2";
            this.checkBoxId2.Size = new System.Drawing.Size(147, 32);
            this.checkBoxId2.TabIndex = 13;
            this.checkBoxId2.Text = "Professeurs";
            this.checkBoxId2.UseVisualStyleBackColor = true;
            this.checkBoxId2.CheckedChanged += new System.EventHandler(this.checkBoxId2_CheckedChanged);
            // 
            // checkBoxId3
            // 
            this.checkBoxId3.AutoSize = true;
            this.checkBoxId3.Checked = true;
            this.checkBoxId3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxId3.Location = new System.Drawing.Point(560, 101);
            this.checkBoxId3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxId3.Name = "checkBoxId3";
            this.checkBoxId3.Size = new System.Drawing.Size(393, 32);
            this.checkBoxId3.TabIndex = 14;
            this.checkBoxId3.Text = "Professeurs avec droits d\'impressions";
            this.checkBoxId3.UseVisualStyleBackColor = true;
            this.checkBoxId3.CheckedChanged += new System.EventHandler(this.checkBoxId3_CheckedChanged);
            // 
            // checkBoxId4
            // 
            this.checkBoxId4.AutoSize = true;
            this.checkBoxId4.Checked = true;
            this.checkBoxId4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxId4.Location = new System.Drawing.Point(776, 72);
            this.checkBoxId4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxId4.Name = "checkBoxId4";
            this.checkBoxId4.Size = new System.Drawing.Size(166, 32);
            this.checkBoxId4.TabIndex = 15;
            this.checkBoxId4.Text = "Organisateurs";
            this.checkBoxId4.UseVisualStyleBackColor = true;
            this.checkBoxId4.CheckedChanged += new System.EventHandler(this.checkBoxId4_CheckedChanged);
            // 
            // checkBoxexterne
            // 
            this.checkBoxexterne.AutoSize = true;
            this.checkBoxexterne.Checked = true;
            this.checkBoxexterne.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxexterne.Location = new System.Drawing.Point(259, 109);
            this.checkBoxexterne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxexterne.Name = "checkBoxexterne";
            this.checkBoxexterne.Size = new System.Drawing.Size(242, 32);
            this.checkBoxexterne.TabIndex = 16;
            this.checkBoxexterne.Text = "Intervenants externes";
            this.checkBoxexterne.UseVisualStyleBackColor = true;
            this.checkBoxexterne.CheckedChanged += new System.EventHandler(this.checkBoxexterne_CheckedChanged);
            // 
            // checkBoxinterne
            // 
            this.checkBoxinterne.AutoSize = true;
            this.checkBoxinterne.Checked = true;
            this.checkBoxinterne.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxinterne.Location = new System.Drawing.Point(6, 107);
            this.checkBoxinterne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxinterne.Name = "checkBoxinterne";
            this.checkBoxinterne.Size = new System.Drawing.Size(235, 32);
            this.checkBoxinterne.TabIndex = 17;
            this.checkBoxinterne.Text = "Intervenants internes\r\n";
            this.checkBoxinterne.UseVisualStyleBackColor = true;
            this.checkBoxinterne.CheckedChanged += new System.EventHandler(this.checkBoxinterne_CheckedChanged);
            // 
            // buttonRecherche
            // 
            this.buttonRecherche.BackColor = System.Drawing.Color.White;
            this.buttonRecherche.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.buttonRecherche.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonRecherche.Location = new System.Drawing.Point(35, 28);
            this.buttonRecherche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRecherche.Name = "buttonRecherche";
            this.buttonRecherche.Size = new System.Drawing.Size(177, 85);
            this.buttonRecherche.TabIndex = 21;
            this.buttonRecherche.Text = "Rechercher à l\'aide de filtres\r\n";
            this.buttonRecherche.UseVisualStyleBackColor = false;
            this.buttonRecherche.Click += new System.EventHandler(this.buttonRecherche_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNom);
            this.groupBox1.Controls.Add(this.comboBoxClasse);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBoxinterne);
            this.groupBox1.Controls.Add(this.textBoxPrenom);
            this.groupBox1.Controls.Add(this.checkBoxexterne);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBoxId4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBoxId3);
            this.groupBox1.Controls.Add(this.checkBoxId2);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.groupBox1.Location = new System.Drawing.Point(229, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(975, 149);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche par filtres :";
            this.groupBox1.Visible = false;
            // 
            // GestionDesComptesUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 713);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonRecherche);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GestionDesComptesUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GestionDesComptesUsers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxClasse;
        private System.Windows.Forms.CheckBox checkBoxId2;
        private System.Windows.Forms.CheckBox checkBoxId3;
        private System.Windows.Forms.CheckBox checkBoxId4;
        private System.Windows.Forms.CheckBox checkBoxexterne;
        private System.Windows.Forms.CheckBox checkBoxinterne;
        private System.Windows.Forms.Button buttonRecherche;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
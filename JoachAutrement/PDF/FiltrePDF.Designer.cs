﻿namespace JoachAutrement
{
    partial class FiltrePDF
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
            this.listBoxActivite = new System.Windows.Forms.ListBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLibelle = new System.Windows.Forms.TextBox();
            this.comboBoxTypeActivite = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxActivite
            // 
            this.listBoxActivite.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.listBoxActivite.FormattingEnabled = true;
            this.listBoxActivite.ItemHeight = 28;
            this.listBoxActivite.Location = new System.Drawing.Point(84, 149);
            this.listBoxActivite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxActivite.Name = "listBoxActivite";
            this.listBoxActivite.Size = new System.Drawing.Size(1273, 452);
            this.listBoxActivite.TabIndex = 0;
            this.listBoxActivite.DoubleClick += new System.EventHandler(this.listBoxActivite_DoubleClick);
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(37, 69);
            this.textBoxCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(247, 35);
            this.textBoxCode.TabIndex = 1;
            this.textBoxCode.TextChanged += new System.EventHandler(this.textBoxCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code de l\'activité";
            // 
            // textBoxLibelle
            // 
            this.textBoxLibelle.Location = new System.Drawing.Point(331, 69);
            this.textBoxLibelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLibelle.Name = "textBoxLibelle";
            this.textBoxLibelle.Size = new System.Drawing.Size(380, 35);
            this.textBoxLibelle.TabIndex = 3;
            this.textBoxLibelle.TextChanged += new System.EventHandler(this.textBoxLibelle_TextChanged);
            // 
            // comboBoxTypeActivite
            // 
            this.comboBoxTypeActivite.FormattingEnabled = true;
            this.comboBoxTypeActivite.Location = new System.Drawing.Point(761, 68);
            this.comboBoxTypeActivite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTypeActivite.Name = "comboBoxTypeActivite";
            this.comboBoxTypeActivite.Size = new System.Drawing.Size(247, 36);
            this.comboBoxTypeActivite.TabIndex = 4;
            this.toolTip1.SetToolTip(this.comboBoxTypeActivite, "Vous pouvez chercher un type dans la liste ou tapez vous même son type\r\n(même le " +
        "premier caractère du nom du type permettra de reduire la liste)");
            this.comboBoxTypeActivite.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeActivite_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Titre de l\'activité";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(768, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type de l\'activité";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.button1.Location = new System.Drawing.Point(69, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 94);
            this.button1.TabIndex = 7;
            this.button1.Text = "Rechercher à l\'aide de filtres\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxLibelle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxTypeActivite);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.groupBox1.Location = new System.Drawing.Point(343, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1013, 119);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtres";
            this.toolTip1.SetToolTip(this.groupBox1, "Permet de chercher une activité par son code, son titre et son type");
            this.groupBox1.Visible = false;
            // 
            // FiltrePDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 651);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxActivite);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FiltrePDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FiltrePDF";
            this.Load += new System.EventHandler(this.FiltrePDF_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxActivite;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLibelle;
        private System.Windows.Forms.ComboBox comboBoxTypeActivite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JoachAutrement.Intervenant;
using JoachAutrement.Eleve;

namespace JoachAutrement
{
    public partial class GestionDesComptesUsers : Form
    {

        int indiceType;
        private BindingSource bindingSource1;

        Classe uneClasse;
        List<Classe> lesClasses;

        public GestionDesComptesUsers(int id) // 1 pour intervenant , 2 pour prof et 3 pour eleve
        {
            InitializeComponent();
            indiceType = id;
            bindingSource1 = new BindingSource();
            switch (id)
            {
                case 1:
                    chargerIntervenants();
                    comboBoxClasse.Enabled = false;
                    checkBoxId2.Enabled = false;
                    checkBoxId3.Enabled = false;
                    checkBoxId4.Enabled = false;
                    break;
                case 2:
                    chargerProfs();
                    comboBoxClasse.Enabled = false;
                    checkBoxexterne.Enabled = false;
                    checkBoxinterne.Enabled = false;
                    break;
                case 3:
                    chargerEleves();
                    checkBoxexterne.Enabled = false;
                    checkBoxinterne.Enabled = false;
                    checkBoxId2.Enabled = false;
                    checkBoxId3.Enabled = false;
                    checkBoxId4.Enabled = false;
                    chargerClasses();
                    break;
                default:
                    MessageBox.Show("id introuvable (Erreur dans le code)", "Erreur");
                    break;
            }
        }

        public void chargerClasses()
        {
            uneClasse = new Classe();
            lesClasses = uneClasse.InitClasse();
            foreach (Classe c in lesClasses)
            {
                comboBoxClasse.Items.Add(c.Libelle);
            }
        }


        public void chargerIntervenants()
        {
            Controleur.Vmodele.charger_intervenantsgestion();
            if (Controleur.Vmodele.Chargement)
            {
                bindingSource1.DataSource = Controleur.Vmodele.DTintervenantsgestion;
                dataGridView1.DataSource = bindingSource1;
                dataGridView1.Columns["IDI"].Visible = false;
                dataGridView1.Columns["NOMI"].HeaderText = "Nom";
                dataGridView1.Columns["PRENOMI"].HeaderText = "Prenom";
                dataGridView1.Columns["PROFESSIONI"].HeaderText = "Profession";
                dataGridView1.Columns["EXTERIEUR"].Visible = false;
            }
        }

        public void chargerProfs()
        {
            Controleur.Vmodele.charger_tous_Professeurs();
            if (Controleur.Vmodele.Chargement)
            {
                bindingSource1 = new BindingSource();
                bindingSource1.DataSource = Controleur.Vmodele.DTprof;
                dataGridView1.DataSource = bindingSource1;
                dataGridView1.Columns["IDU"].Visible = false;
                dataGridView1.Columns["NOMU"].HeaderText = "Nom";
                dataGridView1.Columns["PRENOMU"].HeaderText = "Prenom";
                dataGridView1.Columns["LIBELLEP"].HeaderText = "Permission";
                dataGridView1.Columns["IDP"].Visible = false;
            }
        }

        public void chargerEleves()
        {
            Controleur.Vmodele.charger_eleves_Classe();
            if (Controleur.Vmodele.Chargement)
            {
                bindingSource1 = new BindingSource();
                bindingSource1.DataSource = Controleur.Vmodele.DTeleveclasse;
                dataGridView1.DataSource = bindingSource1;
                dataGridView1.Columns["IDU"].Visible = false;
                dataGridView1.Columns["NOMU"].HeaderText = "Nom";
                dataGridView1.Columns["PRENOMU"].HeaderText = "Prenom";
                dataGridView1.Columns["LIBELLEC"].HeaderText = "Classe";
                dataGridView1.Columns["IDC"].Visible = false;
                dataGridView1.Columns["VALIDE"].HeaderText = "Inscription Validé";
            }
        }

        private void textBoxPrenom_TextChanged(object sender, EventArgs e)
        {
            filtrer();
        }
        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            filtrer();
        }
        private void comboBoxClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrer();
        }
        private void comboBoxClasse_TextChanged(object sender, EventArgs e)
        {
            filtrer();
        }
        private void checkBoxId2_CheckedChanged(object sender, EventArgs e)
        {
            filtrer();
        }
        private void checkBoxId3_CheckedChanged(object sender, EventArgs e)
        {
            filtrer();
        }
        private void checkBoxId4_CheckedChanged(object sender, EventArgs e)
        {
            filtrer();
        }
        private void checkBoxexterne_CheckedChanged(object sender, EventArgs e)
        {
            filtrer();
        }
        private void checkBoxinterne_CheckedChanged(object sender, EventArgs e)
        {
            filtrer();
        }
    

        public void filtrer()
        {
 
            int nbRequete = 0;
            string requeteNomPrenom = "";

            switch (indiceType)
            {
                case 1: //intervenants

                    requeteNomPrenom = "PRENOMI LIKE '%" + textBoxPrenom.Text + "%' AND NOMI LIKE '%" + textBoxNom.Text + "%'";

                    string or = "";
                    string requeteExterne = "";
                    string requeteInterne = "";
                    if (checkBoxexterne.Checked == true)
                    {
                        requeteExterne = " AND EXTERIEUR = true";  
                        nbRequete++;
                    }
                    if (checkBoxinterne.Checked == true)
                    {
                        if (nbRequete == 1) { or += " OR " + requeteNomPrenom; nbRequete--; }
                        requeteInterne += " AND EXTERIEUR = false";
                        nbRequete++;
                    }

                    
                    bindingSource1.Filter = requeteNomPrenom + requeteExterne + or + requeteInterne;
                    break;

                case 2: // profs


                    string requete2 = "";
                    string requete3 = "";
                    string requete4 = "";
                    string or1 = "";
                    string or2 = "";
                    requeteNomPrenom = "PRENOMU LIKE '%" + textBoxPrenom.Text + "%' AND NOMU LIKE '%" + textBoxNom.Text + "%'";

                    if (checkBoxId2.Checked == true)
                    {
                        requete2 = " AND IDP = 2";
                        nbRequete++;
                    }
                    if (checkBoxId3.Checked == true)
                    {
                        if (nbRequete == 1) { or1 += " OR " + requeteNomPrenom; nbRequete--; }
                        requete3 = " AND IDP = 3";
                        nbRequete++;
                    }
                    if (checkBoxId4.Checked == true)
                    {
                        if (nbRequete == 1) { or2 += " OR " + requeteNomPrenom; nbRequete--; }
                        requete4 = " AND IDP = 4";
                        nbRequete++;
                    }

                    bindingSource1.Filter = requeteNomPrenom + requete2 + or1 + requete3 + or2 + requete4;

                    break;

                case 3: // eleves

                    bindingSource1.Filter = "PRENOMU LIKE '%" + textBoxPrenom.Text + "%' AND NOMU LIKE '%" + textBoxNom.Text + "%' AND LIBELLEC LIKE '%" + comboBoxClasse.Text.ToString() + "%'";
                    
                    break;
                default:
                    MessageBox.Show("id introuvable (Erreur dans le code)", "Erreur");
                    break;
            }


        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (indiceType)
            {
                case 1:
                    AjouterIntervenant formAjoutIntervenant = new AjouterIntervenant();
                    formAjoutIntervenant.Text = "Ajout d'un intervenant";
                    formAjoutIntervenant.ShowDialog();
                    chargerIntervenants();
                    break;
                case 2:
                    AjouterProf formAjoutProf = new AjouterProf();
                    formAjoutProf.Text = "Ajout d'un professeur";
                    formAjoutProf.ShowDialog();
                    chargerProfs();
                    break;
                case 3:
                    AjouterEleve formAjoutEleve = new AjouterEleve();
                    formAjoutEleve.Text = "Ajout d'un elève";
                    formAjoutEleve.ShowDialog();
                    chargerEleves();
                    break;
                default:

                    break;
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                switch (indiceType)
                {
                    case 1:
                        int idi = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDI"].Value);
                        string nomi = dataGridView1.CurrentRow.Cells["NOMI"].Value.ToString();
                        string prenomi = dataGridView1.CurrentRow.Cells["PRENOMI"].Value.ToString();
                        string profession = dataGridView1.CurrentRow.Cells["PROFESSIONI"].Value.ToString();
                        bool externe = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["EXTERIEUR"].Value);

                        AjouterIntervenant formAjoutIntervenant = new AjouterIntervenant(idi, nomi, prenomi, profession, externe);
                        formAjoutIntervenant.Text = "Modifier un Intervenant";
                        formAjoutIntervenant.ShowDialog();
                        chargerIntervenants();
                        break;

                    case 2:
                        int idp = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDU"].Value);
                        string nomp = dataGridView1.CurrentRow.Cells["NOMU"].Value.ToString();
                        string prenomp = dataGridView1.CurrentRow.Cells["PRENOMU"].Value.ToString();
                        int idPerm = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDP"].Value);

                        AjouterProf formAjoutProf = new AjouterProf(idp, nomp, prenomp, idPerm);
                        formAjoutProf.Text = "Modifier un Professeur";
                        formAjoutProf.ShowDialog();
                        chargerProfs();
                        break;

                    case 3:
                        int ide = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDU"].Value);
                        string nome = dataGridView1.CurrentRow.Cells["NOMU"].Value.ToString();
                        string prenome = dataGridView1.CurrentRow.Cells["PRENOMU"].Value.ToString();
                        string classe = dataGridView1.CurrentRow.Cells["LIBELLEC"].Value.ToString();
                        bool valide = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["VALIDE"].Value);

                        AjouterEleve formAjoutEleve = new AjouterEleve(ide, nome, prenome, classe, valide);
                        formAjoutEleve.Text = "Modifier un Eleve";
                        formAjoutEleve.ShowDialog();
                        chargerEleves();
                        break;
                    default:

                        break;
                }
            }
            else
                MessageBox.Show("Sélectionner une ligne à modifier");
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int idSupprimer = 0;
                DialogResult rep = DialogResult.No;
                switch (indiceType)
                {

                    case 1:
                        idSupprimer = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDI"].Value);
                        rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce compte " + dataGridView1.CurrentRow.Cells["PRENOMI"].Value.ToString()
                        + "  " + dataGridView1.CurrentRow.Cells["NOMI"].Value.ToString() + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rep == DialogResult.Yes)
                        {
                            Controleur.supprimerIntervenants(idSupprimer);
                            chargerIntervenants();
                        }
                        break;
                    case 2:
                        idSupprimer = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDU"].Value);
                        rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce compte " + dataGridView1.CurrentRow.Cells["PRENOMU"].Value.ToString()
                        + "  " + dataGridView1.CurrentRow.Cells["NOMU"].Value.ToString() + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rep == DialogResult.Yes)
                        {
                            Controleur.supprimerUsers(idSupprimer);
                            chargerProfs();
                        }
                        break;
                    case 3:
                        idSupprimer = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDU"].Value);
                        rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce compte " + dataGridView1.CurrentRow.Cells["PRENOMU"].Value.ToString()
                        + "  " + dataGridView1.CurrentRow.Cells["NOMU"].Value.ToString() + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rep == DialogResult.Yes)
                        {
                            Controleur.supprimerUsers(idSupprimer);
                            chargerEleves();
                        }
                        break;
                    default:

                        break;
                }
            }
            else
                MessageBox.Show("Sélectionner une ligne à supprimer");
        }

        private void buttonRecherche_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == false)
            {
                groupBox1.Visible = true;
                buttonRecherche.Text = "Annuler la recherche";
            }

            else
            {
                groupBox1.Visible = false;
                buttonRecherche.Text = "Rechercher à l'aide de filtre";
                textBoxNom.Text = "";
                textBoxPrenom.Text = "";
                comboBoxClasse.Text = "";
                checkBoxId2.Checked = true;
                checkBoxId3.Checked = true;
                checkBoxId4.Checked = true;
                checkBoxinterne.Checked = true;
                checkBoxexterne.Checked = true;
            }
        }

        void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCell cell = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            cell.ToolTipText = "Cliquez en haut des colonnes pour ordonner le tableau.";
        }

    }
}

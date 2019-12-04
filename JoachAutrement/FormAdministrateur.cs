using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using JoachAutrement.Eleve;

namespace JoachAutrement
{
    public partial class FormAdministrateur : Form
    {
        private BindingSource bindingSource1;

        List<Utilisateur> ListProfs = new List<Utilisateur>();
        List<Utilisateur> ListEleves = new List<Utilisateur>();
        public FormAdministrateur()
        {
            InitializeComponent();
            dateTimePickerInscriptionEleve.Value = DateTime.Today;
            dateTimePickerInscriptionProf.Value = DateTime.Today;
            chargerDatesEvenement();
            chargerDatesInscriptions();
        }

        public void chargerDatesEvenement()
        {
            bindingSource1 = new BindingSource();
            Controleur.Vmodele.charger_datejoachEvenement();
            if (Controleur.Vmodele.DTdatejoachEvenement.Rows.Count == 0)
            {
                DateTime d = new DateTime();
                d = DateTime.Now;
                Controleur.ajouterDate(d, false, false);
            }
            Controleur.Vmodele.charger_datejoachEvenement();

            bindingSource1.DataSource = Controleur.Vmodele.DTdatejoachEvenement;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Columns["IDD"].Visible = false;
            dataGridView1.Columns["DATEEVENEMENT"].HeaderText = "Date";
            dataGridView1.Columns["ESTINSCRITPROF"].Visible = false;
            dataGridView1.Columns["ESTINSCRITELEVE"].Visible = false;
            dataGridView1.Columns["MATIN"].HeaderText = "Matin";
            dataGridView1.Columns["APRESMIDI"].HeaderText = "Après-Midi";
                
        }
        public void chargerDatesInscriptions()
        {
            Controleur.Vmodele.charger_datejoachInscriptions();
            if (Controleur.Vmodele.DTdatejoachInscriptions.Rows.Count != 0)
            {
                for(int i = 0; i < Controleur.Vmodele.DTdatejoachInscriptions.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(Controleur.Vmodele.DTdatejoachInscriptions.Rows[i]["ESTINSCRITPROF"]) == true)
                    {
                        dateTimePickerInscriptionProf.Value = Convert.ToDateTime(Controleur.Vmodele.DTdatejoachInscriptions.Rows[i]["DATEEVENEMENT"]);
                        btnSupprDateProf.Enabled = true;
                    }
                    if (Convert.ToBoolean(Controleur.Vmodele.DTdatejoachInscriptions.Rows[i]["ESTINSCRITELEVE"]) == true)
                    {
                        dateTimePickerInscriptionEleve.Value = Convert.ToDateTime(Controleur.Vmodele.DTdatejoachInscriptions.Rows[i]["DATEEVENEMENT"]);
                        btnSupprDateEleve.Enabled = true;
                    }
                }
            }
        }
        private void BtnValiderDatesEvenement_Click(object sender, EventArgs e)
        {
            try
            {
                Controleur.Vmodele.DAdatejoachEvenement.Update(Controleur.Vmodele.DTdatejoachEvenement);
                MessageBox.Show("Dates de l'événement enregistrées");
                chargerDatesEvenement();
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur lors de l'ajout de la date, code d'erreur : " + err.ToString());
            }
        }
        private void BtnValiderDatesInscrit_Click(object sender, EventArgs e)
            {
            Controleur.Vmodele.charger_datejoachInscriptions();

            bool existeProf = false;
            bool existeEleve = false;

            if (Controleur.Vmodele.DTdatejoachInscriptions.Rows.Count != 0)
            {
                for (int i = 0; i < Controleur.Vmodele.DTdatejoachInscriptions.Rows.Count; i++)
                {

                    if (Convert.ToBoolean(Controleur.Vmodele.DTdatejoachInscriptions.Rows[i]["ESTINSCRITPROF"]) == true)
                    {
                        Controleur.Vmodele.DTdatejoachInscriptions.Rows[i]["DATEEVENEMENT"] = dateTimePickerInscriptionProf.Value;
                        existeProf = true;
                    }

                    if (Convert.ToBoolean(Controleur.Vmodele.DTdatejoachInscriptions.Rows[i]["ESTINSCRITELEVE"]) == true)
                    {
                        Controleur.Vmodele.DTdatejoachInscriptions.Rows[i]["DATEEVENEMENT"] = dateTimePickerInscriptionEleve.Value;
                        existeEleve = true;
                    }
                }
            }
            if (existeProf == false)
                Controleur.ajouterDate(dateTimePickerInscriptionProf.Value, true, false); btnSupprDateProf.Enabled = true;
                    
            if(existeEleve == false)
                Controleur.ajouterDate(dateTimePickerInscriptionEleve.Value, false, true); btnSupprDateEleve.Enabled = true;


            MessageBox.Show("Dates enregistrées");
        }
        private void btnSupprDateProf_Click(object sender, EventArgs e)
                        {
            DialogResult dialog = MessageBox.Show("Voulez vous vraiment supprimer la date de debut d'inscription des Professeurs ?", "Attention", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Controleur.Vmodele.charger_datejoachInscriptions();
                if (Controleur.Vmodele.DTdatejoachInscriptions.Rows.Count != 0)
                {
                    for (int i = 0; i < Controleur.Vmodele.DTdatejoachInscriptions.Rows.Count; i++)
                    {
                        if (Convert.ToBoolean(Controleur.Vmodele.DTdatejoachInscriptions.Rows[i]["ESTINSCRITPROF"]) == true)
                        {
                            Controleur.Vmodele.DTdatejoachInscriptions.Rows[i].Delete();
                            Controleur.Vmodele.DAdatejoachInscriptions.Update(Controleur.Vmodele.DTdatejoachInscriptions);
                            btnSupprDateProf.Enabled = false;
                            MessageBox.Show("Date d'inscription des professeurs supprimé");
                        }
                    }
                }
            }
        }
        private void btnSupprDateEleve_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Voulez vous vraiment supprimer la date de debut d'inscription des Eleves ?", "Attention", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Controleur.Vmodele.charger_datejoachInscriptions();
                if (Controleur.Vmodele.DTdatejoachInscriptions.Rows.Count != 0)
                {
                    for (int i = 0; i < Controleur.Vmodele.DTdatejoachInscriptions.Rows.Count; i++)
                    {
                        if (Convert.ToBoolean(Controleur.Vmodele.DTdatejoachInscriptions.Rows[i]["ESTINSCRITELEVE"]) == true)
                        {
                            Controleur.Vmodele.DTdatejoachInscriptions.Rows[i].Delete();
                            Controleur.Vmodele.DAdatejoachInscriptions.Update(Controleur.Vmodele.DTdatejoachInscriptions);
                            btnSupprDateEleve.Enabled = false;
                            MessageBox.Show("Date d'inscription des eleves supprimé");
                        }
                    }
                }
            }
        }



        private void buttonHide_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == false)
            {
                DialogResult dialog = MessageBox.Show("Cette fonctionnalité permet d'ajouter des comptes Eleves et Professeurs depuis les fichiers CSV,"
                    + "\nIl doit y avoir 4 fichiers CSV, issus de l'active directory du lycée Joachim du Bellay :"
                    + "\nUn fichier contenant les élèves du tertiaire, les élèves de l'enseignement général,"
                    + "\nles professeurs du tertiaire et un dernier contenant les professeurs de l'enseignement général."
                    + "\n\nSi c'est la première fois que vous utilisez cette fonctionnalité, dans un souci d'ordonnancement des utilisateurs dans la Base de Donnée, "
                    + "veuillez importer les 4 fichiers avec les 4 boutons prévus à cet effet avant de fermer la fenêtre."
                    + "\nSi vous n'avez pas les 4 fichiers avec vous cliquez sur \"Annuler\", merci de votre comprehension."
                    , "Attention", MessageBoxButtons.OKCancel);
                if (dialog == System.Windows.Forms.DialogResult.OK)
                {
                    groupBox1.Visible = true;
                    buttonHide.Text = "Annuler";
                } 
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Cette action annule l'import des comptes,\nVoulez vous continuer ?", "", MessageBoxButtons.YesNo);
                if (dialog == System.Windows.Forms.DialogResult.Yes)
                {
                    groupBox1.Visible = false;
                    buttonHide.Text = "Importer des comptes";
                    ListEleves.Clear();
                    ListProfs.Clear();
                }
            }
        }
        private void buttonEleveGeneraux_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.csv)|*.csv"; // filtre, permet de viser uniquement les fichiers csv

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                recupEleves();

                buttonEleveGeneraux.BackColor = Color.Green;
                        }
                    }
        private void buttonElevesTertiaires_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.csv)|*.csv"; // filtre, permet de viser uniquement les fichiers csv

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                recupEleves();

                buttonElevesTertiaires.BackColor = Color.Green;

                }
            }
        private void buttonProfsGeneraux_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.csv)|*.csv";
            
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                recupProfs();
                buttonProfsGeneraux.BackColor = Color.Green;
            }
        }
        private void buttonPorfsTertiaires_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.csv)|*.csv";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                recupProfs();
                buttonPorfsTertiaires.BackColor = Color.Green;
            }
        }


        public void recupEleves()
        {
                StreamReader st = new StreamReader(openFileDialog1.FileName, System.Text.Encoding.Default);

            string line;
            string[] donnes = new string[5];

            while ((line = st.ReadLine()) != null) //recuperation des lignes du fichier csv
            {
                donnes = line.Split(';'); // séparation des données entre


                string nomU = donnes[0];
                string prenomU = donnes[1];
                string classe = donnes[2];
                string iden = donnes[3];
                string mdp = donnes[4];

                Utilisateur user = new Utilisateur(nomU, prenomU, classe, iden, mdp);
                bool exist = false;
                if (ListEleves.Count != 0)
                {
                    foreach (Utilisateur u in ListEleves)
                    {
                        if (u.Iden == user.Iden && u.Mdp == user.Mdp)
                            exist = true;
                    }
                }
                if (exist == false)
                {
                    ListEleves.Add(user);
                }
            }
            st.Close();
        }
        public void recupProfs()
        {
            StreamReader st = new StreamReader(openFileDialog1.FileName, System.Text.Encoding.Default);

                string line;
                string[] donnes = new string[4];

                while ((line = st.ReadLine()) != null)
                {
                    
                    donnes = line.Split(';');


                    string nomU = donnes[0];
                    string prenomU = donnes[1];
                    string iden = donnes[2];
                    string mdp = donnes[3];

                Utilisateur user = new Utilisateur(nomU, prenomU, "", iden, mdp);
                bool exist = false;
                if (ListProfs.Count != 0)
                {
                    foreach (Utilisateur u in ListProfs)
                    {
                        if (u.Iden == user.Iden && u.Mdp == user.Mdp)
                            exist = true;
                    }
                }
                if (exist == false)
                {
                    ListProfs.Add(user);
                }
            }
            st.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette opération va prendre un peu de temps, attendez le prochain message avant de faire quoi que ce soit", "Attention");
            progressBar1.Maximum = ListProfs.Count + ListEleves.Count;
            progressBar1.Visible = true;
            #region Save des prof
                    Controleur.Vmodele.charger_utilisateursupdate();

            ListProfs = ListProfs.OrderBy(x => x.NomU).ThenBy(x => x.PrenomU).ToList();
            foreach (Utilisateur u in ListProfs)
            {
                bool verif = true;
                for (int i = 0; i < Controleur.Vmodele.DTusersupdate.Rows.Count; i++)
                {
                if (Controleur.Vmodele.DTusersupdate.Rows[i]["LOGINU"].ToString() == u.Iden)
                    {
                        verif = false;
                    }
                }
                if (verif == true) 
                { 
                    Controleur.ajouterProf(u.NomU, u.PrenomU, 2, u.Iden, u.Mdp);
                    progressBar1.Value++;
                } 
            }
        
            #endregion

            #region Save des Eleves 

            Controleur.Vmodele.charger_classe();
            Controleur.Vmodele.charger_eleves();

            ListEleves = ListEleves.OrderBy(x => x.NomU).ThenBy(x => x.PrenomU).ToList();
        
            foreach (Utilisateur u in ListEleves)
            {
                bool existant = false;
                int idClasse = 0;

                for (int i = 0; i < Controleur.Vmodele.DTclasse.Rows.Count; i++)
                {// permet de tester si la classe existe deja
                    if (Controleur.Vmodele.DTclasse.Rows[i]["LIBELLEC"].ToString() == u.Classe)
                    {
                        existant = true;
                        idClasse = Convert.ToInt32(Controleur.Vmodele.DTclasse.Rows[i]["IDC"]);
                    }
                }

                if (existant == false) // si elle n'existe pas
                {
                    Controleur.ajouterClasse(u.Classe); // on ajoute son nom

                    Controleur.Vmodele.charger_classe();

                    // et on cherche l'id de la classe que la BDD lui a attribué (autoIncrement)
                    for (int i = 0; i < Controleur.Vmodele.DTclasse.Rows.Count; i++)
                    {
                        if (Controleur.Vmodele.DTclasse.Rows[i]["LIBELLEC"].ToString() == u.Classe)
                        {
                            idClasse = Convert.ToInt32(Controleur.Vmodele.DTclasse.Rows[i]["IDC"]);
                        }
                    }
                }

                // on finit pas ajouter l'eleve 


                bool verif = true;
                for (int i = 0; i < Controleur.Vmodele.DTeleve.Rows.Count; i++)
                { // test qui permet de verifier si un eleve est deja créer
                    if (Controleur.Vmodele.DTeleve.Rows[i]["LOGINU"].ToString() == u.Iden)
                    {
                        verif = false;
                    }
                }
                if (verif == true)
                {
                    Controleur.ajouterEleve(u.NomU, u.PrenomU, idClasse, u.Iden, u.Mdp);
                    progressBar1.Value++;
                }

            }
            #endregion

            MessageBox.Show("Sauvegarde des comptes dans la Base de Données réussie");
            groupBox1.Visible = false;
            buttonHide.Text = "Importer des comptes";
        }

        void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCell cell = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            cell.ToolTipText = "Cliquez en haut des colonnes pour ordonner le tableau.\nAu préalable, pensez à bien supprimer les activités liées aux dates que vous voulez supprimer.";
        }

    }
}

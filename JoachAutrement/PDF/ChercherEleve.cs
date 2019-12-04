using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JoachAutrement.Eleve;
using JoachAutrement.Activités;

namespace JoachAutrement.PDF
{
    public partial class ChercherEleve : Form
    {

        string nomdupdf;
        Utilisateur user;
        Classe uneClasse;
        
        List<Utilisateur> lesEleves;

        VisualisationPDF visuPDF;

        public ChercherEleve(string nompdf)
        {
            InitializeComponent();
            nomdupdf = nompdf;
            user = new Utilisateur();
            uneClasse = new Classe();
            lesEleves = new List<Utilisateur>();
            user.InitEleve();
            uneClasse.InitClasse();
            foreach(Utilisateur u in user.lesEleves)
            {
                listBoxEleves.Items.Add(u.IDU + " -> " + u.NomU + " " + u.PrenomU + " de la classe " + uneClasse.getLibelleClasse(u.IDC));
            }
            foreach(Classe c in uneClasse.lesClasses)
            {
                comboBoxClasse.Items.Add(c.Libelle);
            }
            
        }


        public void ChargerDonnes()
        {
            listBoxEleves.Items.Clear();
            bool filtrecode = true;
            bool filtrelibelle = true;
            bool filtretype = true;
            string l = comboBoxClasse.Text;
            List<int> liste = new List<int>();
            foreach (Classe c in uneClasse.lesClasses)
            {
                if (c.Libelle.StartsWith(l))
                {
                    liste.Add(c.Id);
                }
            }

            foreach (Utilisateur u in user.lesEleves)
            {
                if (textBoxNom.Text != "")
                {
                    filtrecode = u.NomU.StartsWith(textBoxNom.Text);
                }
                if (textBoxPrenom.Text != "")
                {
                    filtrelibelle = u.PrenomU.StartsWith(textBoxPrenom.Text);
                }
                if (comboBoxClasse.Text != "")
                {
                    filtretype = false;
                    foreach (int i in liste)
                    {
                        if (u.IDC == i)
                            filtretype = true;
                    }
                }
                if (filtrecode == true && filtrelibelle == true && filtretype == true)
                {
                    listBoxEleves.Items.Add(u.IDU + " -> " + u.NomU + " " + u.PrenomU + " de la Classe " + uneClasse.getLibelleClasse(u.IDC));
                }
            }
        }

        private void comboBoxClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargerDonnes();
        }

        private void textBoxPrenom_TextChanged(object sender, EventArgs e)
        {
            ChargerDonnes();
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            ChargerDonnes();
        }

        private void listBoxEleves_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxEleves.SelectedItems.Count == 1)
            {
                // test a faire si un selected index est passé en parametre
                string w = listBoxEleves.SelectedItem.ToString();
                string x = "";

                foreach (char caractere in w)
                {
                    try
                    {
                        //Cherche si un caractère saisit est un chiffre//
                        int.Parse(caractere.ToString());
                        x += caractere;
                    }
                    catch
                    { break; }
                }

                int nbr = Convert.ToInt32(x);

                visuPDF = new VisualisationPDF(nomdupdf, nbr);
                visuPDF.ShowDialog();
            }

        }


        private void comboBoxClasse_TextChanged(object sender, EventArgs e)
        {
            ChargerDonnes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == false)
            {
                groupBox1.Visible = true;
                button1.Text = "Annuler la recherche";
            }

            else
            {
                groupBox1.Visible = false;
                button1.Text = "Rechercher à l'aide de filtre";
                textBoxNom.Text = "";
                textBoxPrenom.Text = "";
                comboBoxClasse.Text = "";
            }
        }


    }
}

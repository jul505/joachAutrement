using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoachAutrement.Eleve
{
    public partial class AjouterEleve : Form
    {
        string nom;
        string prenom;
        int idClasse;
        string login;
        string mdp;

        int idEleve = 0;

        Classe uneClasse;
        List<Classe> lesClasses;

        public AjouterEleve()
        {

            InitializeComponent();

            chargerClasses();
        }

        public AjouterEleve(int idEl, string n, string p, string cl, bool val)
        {
            idEleve = idEl;

            InitializeComponent();

            checkBox1.Visible = true;
            chargerClasses();

            textBoxNom.Text = n;
            textBoxPrenom.Text = p;
            comboBoxClasse.Text = cl;
            checkBox1.Checked = val;

            textBoxLogin.Visible = false;
            textBoxLogin.Enabled = false;

            textBoxMdp.Visible = false;
            textBoxMdp.Enabled = false;

            label5.Visible = false;
            label4.Visible = false;
            
        }

        public void chargerClasses()
        {
            uneClasse = new Classe();
            lesClasses = new List<Classe>();
            lesClasses = uneClasse.InitClasse();
            foreach (Classe c in lesClasses)
            {
                comboBoxClasse.Items.Add(c.Libelle);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (idEleve == 0)
            {
                if (textBoxNom.Text != "" && textBoxPrenom.Text != "" && comboBoxClasse.Text != "" && textBoxLogin.Text != "" && textBoxMdp.Text != "")
                {
                    nom = textBoxNom.Text;
                    prenom = textBoxPrenom.Text;
                    idClasse = uneClasse.getIdClasse(comboBoxClasse.Text);
                    login = textBoxLogin.Text;
                    mdp = textBoxMdp.Text;

                    Controleur.Vmodele.charger_eleves();
                    bool verif = true;
                    for (int i = 0; i < Controleur.Vmodele.DTeleve.Rows.Count; i++)
                    { // test qui permet de verifier si un eleve est deja créer
                        if (Controleur.Vmodele.DTeleve.Rows[i]["LOGINU"].ToString() == login)
                        {
                            verif = false;
                        }
                    }
                    if (verif == true)
                    {

                        Controleur.ajouterEleve(nom, prenom, idClasse, login, mdp);

                        MessageBox.Show("ajout de l'élève : " + nom + " " + prenom + " effectué");
                        textBoxNom.Text = "";
                        textBoxPrenom.Text = "";
                        comboBoxClasse.Text = "";
                        textBoxLogin.Text = "";
                        textBoxMdp.Text = "";
                    }
                }
            }
            else
            {
                if (textBoxNom.Text != "" && textBoxPrenom.Text != "" && comboBoxClasse.Text != "")
                {
                    nom = textBoxNom.Text;
                    prenom = textBoxPrenom.Text;
                    idClasse = uneClasse.getIdClasse(comboBoxClasse.Text);
                    bool valide = checkBox1.Checked;
                    Controleur.modifierEleve(idEleve, nom, prenom, idClasse, valide);
                }
            }
        }
    }
}

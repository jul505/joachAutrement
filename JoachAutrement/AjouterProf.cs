using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoachAutrement
{
    public partial class AjouterProf : Form
    {
        string nom;
        string prenom;
        int idPermission;
        string login;
        string mdp;

        int idProf = 0;

        public AjouterProf()
        {

            InitializeComponent();

            radioButtonID2.Checked = true;
        }
        public AjouterProf(int idp, string n, string p, int idpermi)
        {
            idProf = idp;
            idPermission = idpermi;

            InitializeComponent();

            textBoxNom.Text = n;
            textBoxPrenom.Text = p;

            if (idPermission == 2) { radioButtonID2.Checked = true; }
            if (idPermission == 3) { radioButtonID3.Checked = true; }
            if (idPermission == 4) { radioButtonID4.Checked = true; }

            textBoxLogin.Visible = false;
            textBoxLogin.Enabled = false;

            textBoxMdp.Visible = false;
            textBoxMdp.Enabled = false;

            label1.Visible = false;
            label4.Visible = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (idProf == 0)
            {
                if (textBoxNom.Text != "" && textBoxPrenom.Text != "" && textBoxLogin.Text != "" && textBoxMdp.Text != "")
                {
                    nom = textBoxNom.Text;
                    prenom = textBoxPrenom.Text;
                    login = textBoxLogin.Text;
                    mdp = textBoxMdp.Text;

                    if (radioButtonID2.Checked == true) idPermission = 2;
                    if (radioButtonID3.Checked == true) idPermission = 3;
                    if (radioButtonID4.Checked == true) idPermission = 4;


                    Controleur.Vmodele.charger_tous_Professeurs();
                    bool verif = true;
                    for (int i = 0; i < Controleur.Vmodele.DTprof.Rows.Count; i++)
                    { // test qui permet de verifier si un eleve est deja créer
                        if (Controleur.Vmodele.DTprof.Rows[i]["LOGINU"].ToString() == login)
                        {
                            verif = false;
                        }
                    }
                    if (verif == true)
                    {

                        Controleur.ajouterProf(nom, prenom, idPermission, login, mdp);
                        MessageBox.Show("ajout du professeur " + nom + " " + prenom + " réussi");
                        textBoxNom.Text = "";
                        textBoxPrenom.Text = "";
                        textBoxLogin.Text = "";
                        textBoxMdp.Text = "";
                    }
                    else
                        MessageBox.Show("identifiant déja existant","Erreur");
                }
            }
            else
            {
                if (textBoxNom.Text != "" && textBoxPrenom.Text != "")
                {
                    nom = textBoxNom.Text;
                    prenom = textBoxPrenom.Text;
                    if (radioButtonID2.Checked == true) idPermission = 2;
                    if (radioButtonID3.Checked == true) idPermission = 3;
                    if (radioButtonID4.Checked == true) idPermission = 4;

                    Controleur.modifierProf(idProf, nom, prenom, idPermission);
                    this.Close();
                }
            }
            

            
        }
    }
}

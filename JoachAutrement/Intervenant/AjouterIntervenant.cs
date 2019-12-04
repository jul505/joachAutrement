using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using JoachAutrement.Intervenant;

namespace JoachAutrement
{
    public partial class AjouterIntervenant : Form
    {
        string nom;
        string prenom;
        string profession;
        bool externe = false;

        bool ajout; // verifit si l'ajout de l'intervenant c'est bien deroullé

        ClassIntervenant Interv;  // permet de faire le lien avec la classe

        int idIntervenant = 0;  // l'id de l'intervenant passé en parametre d'il sagit d'un modification

        public AjouterIntervenant()
        {

            InitializeComponent();
            Interv = new ClassIntervenant();
        }

        public AjouterIntervenant(int idInterv, string n, string p, string pro, bool ext)
        {
            idIntervenant = idInterv;

            InitializeComponent();
            Interv = new ClassIntervenant();

            TB_NOM.Text = n;
            TB_Prenom.Text = p;
            TB_Professon.Text = pro;
            if (ext == true)
                checkBox1.Checked = true;
        }

        private void Btn_Creer_Click(object sender, EventArgs e)
        {
            if (TB_NOM.Text != "" && TB_Prenom.Text != "" && TB_Professon.Text != "")
            {
                if (idIntervenant == 0) // si ajout
                {
                    nom = TB_NOM.Text;
                    prenom = TB_Prenom.Text;
                    profession = TB_Professon.Text;
                    if (checkBox1.Checked)
                        externe = true; // si intervenant externe = true, si intervenant interne = false;

                    ajout = Interv.AjouterIntervenant(nom, prenom, profession, externe);
                    if (ajout == true) // si le test est vrai
                    {
                        TB_NOM.Text = "";
                        TB_Prenom.Text = "";
                        TB_Professon.Text = ""; // et on reinitialise la forme
                        checkBox1.Checked = false;

                        Controleur.ajouterIntervenants(nom, prenom, profession, externe);
                        // permet l'ajout sur la BDD


                    }
                    else MessageBox.Show("Intervenant déja créé", "Erreur"); // on previent que l'ajout ne s'est pas effectué

                }
                else
                {
                    nom = TB_NOM.Text;
                    prenom = TB_Prenom.Text;
                    profession = TB_Professon.Text;
                    if (checkBox1.Checked)
                        externe = true; // si intervenant externe = true, si intervenant interne = false;

                    Controleur.modifierIntervenant(idIntervenant, nom, prenom, profession, externe);
                }
            }
            else
                MessageBox.Show("Veuillez remplir tous les champs", "Erreur");
        }

    }
}

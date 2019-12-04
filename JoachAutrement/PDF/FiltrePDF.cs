using JoachAutrement.Activités;
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
    public partial class FiltrePDF : Form
    {
        Activite ClassActivite;
        Type ClassType;
        List<Activite> lesActivites;
        List<Type> lesTypes;
        int indexActSelect;
        Dictionary<int, Activite> dicoactivites = new Dictionary<int, Activite>();

        public FiltrePDF()
        {
            try
            {
                InitializeComponent();
                ClassActivite = new Activite();
                ClassType = new Type();
                lesActivites = ClassActivite.InitActivite();
                lesTypes = ClassType.InitType();

                foreach (Type t in lesTypes)
                {
                    comboBoxTypeActivite.Items.Add(t.Libelle);
                }
            }
            catch (System.Exception err)// gestion des erreurs
            {
                MessageBox.Show("Erreur pdf: " + err, "PBS connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ChargerDonnes() // Permet de remplir la listbox
        {
            listBoxActivite.Items.Clear();
            dicoactivites.Clear();
            int clerechercher = 0;
            int cledico = 0;
            bool filtrecode = true;
            bool filtrelibelle = true;
            bool filtretype = true;
            List<Activite> listeActiviteok = new List<Activite>();
            foreach (Activite act in lesActivites)
            {
                if (textBoxCode.Text != "")
                {
                    filtrecode = act.Code.StartsWith(textBoxCode.Text);
                }
                if (textBoxLibelle.Text != "")
                {
                    filtrelibelle = act.Libelle.StartsWith(textBoxLibelle.Text);
                }
                if (comboBoxTypeActivite.Text != "")
                {
                    filtretype = act.IdType == getIdType(comboBoxTypeActivite.Text);
                }
                if (filtrecode == true && filtrelibelle == true && filtretype == true)
                {
                    cledico++;
                    dicoactivites.Add(cledico, act);
                }
            }
            foreach (KeyValuePair<int,Activite> dico in dicoactivites)
            {
                clerechercher++;
                listBoxActivite.Items.Add(dico.Value.Code + "-" + dico.Value.Libelle + " Heure de début : " + dico.Value.Heuredebut.ToLongTimeString() + " Heure de fin : " + dico.Value.Heurefin.ToLongTimeString());
            }
        }
        #region Méthode retour donnée
        public int getIdType(string libelle)
        {
            int id = 0;
            foreach(Type t in lesTypes)
            {
                if (t.Libelle == libelle)
                    id = t.Id;
            }

            return id;
        }

        public string getLibelleType(int id)
        {
            string libelle = "";
            foreach (Type t in lesTypes)
            {
                if (t.Id == id)
                    libelle = t.Libelle;
            }

            return libelle;
        }

        #endregion
        private void listBoxActivite_DoubleClick(object sender, EventArgs e)
        {
            foreach(KeyValuePair<int,Activite> dicoact in dicoactivites)
            {
                if (dicoact.Key == listBoxActivite.SelectedIndex + 1)
                {
                    indexActSelect = dicoact.Value.Id;
                    break;
                }
            }
            VisualisationPDF FormVisualisationPDF = new VisualisationPDF("listeelevesactivite",indexActSelect);
            FormVisualisationPDF.Show();
        }

        private void textBoxCode_TextChanged(object sender, EventArgs e)
        {
            ChargerDonnes();
        }

        private void textBoxLibelle_TextChanged(object sender, EventArgs e)
        {
            ChargerDonnes();
        }

        private void comboBoxTypeActivite_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargerDonnes();
        }

        private void FiltrePDF_Load(object sender, EventArgs e)
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
                textBoxCode.Text = "";
                textBoxLibelle.Text = "";
                comboBoxTypeActivite.Text = "";
            }
        }

    }
}

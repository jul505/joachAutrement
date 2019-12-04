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

namespace JoachAutrement.Eleve
{
    public partial class RetirerActivite : Form
    {
        int idA;
        int idE;
        Activite act = new Activite();
        List<Activite> lesActivites;
        Inscrit linscrit = new Inscrit();
        public RetirerActivite(int ideleve)
        {
            InitializeComponent();
            idE = ideleve;
           
        }

        private void RetirerActivite_Load(object sender, EventArgs e)
        {
            lesActivites = act.initActivitesEleve(idE);
            foreach (Activite a in lesActivites)
            {
                comboBoxListActivite.Items.Add(a.Code + " - " + a.Libelle);
            }
        }

        private void btnRetirer_Click(object sender, EventArgs e)
        {
            if (comboBoxListActivite.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionnez une activité pour suppression");
            }
            else
            {
                linscrit.initInscritEleve(idE);
                int idact = 0;
                foreach (Activite act in lesActivites)
                {
                    if (idact == comboBoxListActivite.SelectedIndex)
                        idA = act.Id;
                    idact++;
                }
                Controleur.retirerActivite(idA, idE);
                lesActivites.RemoveAt(comboBoxListActivite.SelectedIndex);
                comboBoxListActivite.Items.RemoveAt(comboBoxListActivite.SelectedIndex);
                comboBoxListActivite.Text = "";
            }
            noactivite();
        }
        private void noactivite()
        {
            if (comboBoxListActivite.Items.Count == 0)
            {
                MessageBox.Show("Aucune activité dans votre programme");
                this.Close();
            }
        }

        private void RetirerActivite_Shown(object sender, EventArgs e)
        {
            noactivite();
        }
    }
}

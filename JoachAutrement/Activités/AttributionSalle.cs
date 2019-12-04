using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoachAutrement.Activités
{
    public partial class AttributionSalle : Form
    {
        Activite act;
        Type typeActivite;
        List<Activite> lesActiviteSansSalle;
        List<Activite> lesActivites;
        List<Activite> lesActivitesSave;

        Activite a;

        public AttributionSalle()
        {
            InitializeComponent();
            lesActiviteSansSalle = new List<Activite>();
            lesActivitesSave = new List<Activite>();
            act = new Activite();
            typeActivite = new Type();
            lesActivites = new List<Activite>();
            lesActivites = act.InitActivite();
            typeActivite.InitListeType();

            foreach (Activite a in lesActivites)
            {
                if (string.IsNullOrEmpty(a.Salle))
                    lesActiviteSansSalle.Add(a);
            }
            lesActiviteSansSalle = lesActiviteSansSalle.OrderBy(o => o.Heuredebut).ToList();
            MessageBox.Show("Vous allez attribuer des salles aux activités", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            changerActivite();
        }




        public void changerActivite()
        {
            LabelNbrActivite.Text = Convert.ToString(lesActiviteSansSalle.Count);
            if (lesActiviteSansSalle.Count != 0)
            {
                a = new Activite();
                a = lesActiviteSansSalle.First();
                TB_Date.Text = a.Heuredebut.ToLongDateString();
                TB_Heure.Text = a.Heuredebut.ToShortTimeString();
                TB_Libelle.Text = a.Libelle;
                TB_NbrPlace.Text = Convert.ToString(a.Nombreplaces);
                TB_Type.Text = typeActivite.getLibelleType(a.IdType); // recupere le libelle avec la methode de la classe Type
                TB_Salle.Text = "";
            }
            else
            {
                MessageBox.Show("Toutes les activités ont maintenant une salle !"," ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sauvegarde();
                this.Close();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (TB_Salle.Text != "")
            {
                a.Salle = TB_Salle.Text;
                lesActivitesSave.Add(a);
                lesActiviteSansSalle.Remove(a);
                changerActivite();
            }
            else
            {
                DialogResult choix = MessageBox.Show("Vous n'avez pas rentré de salle,\npasser à la suivante quand même ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (choix == DialogResult.Yes)
                {
                    lesActiviteSansSalle.Remove(a);
                    changerActivite();
                }

            }
        }

        public void sauvegarde()
        {
            foreach(Activite a in lesActivitesSave)
            {
                Controleur.sauvegardeSalles(a.Id, a.Salle);
            }
            MessageBox.Show("Toutes les salles ajoutées sont maintenant sauvegardées", "Sauvegarde");
        }

        private void AttributionSalle_FormClosing(object sender, FormClosingEventArgs e)
        {
            sauvegarde();
        }



    }
}

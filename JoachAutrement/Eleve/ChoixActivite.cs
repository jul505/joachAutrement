using JoachAutrement.Activités;
using JoachAutrement.Intervenant;
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
    public partial class ChoixActivite : Form
    {
        int ideleve;
        Type type = new Type();
        DateJoach ladate = new DateJoach();
        ClassIntervenant intervenant = new ClassIntervenant();
        List<Activite> lesActivites = new List<Activite>();
        List<ClassIntervenant> lesIntervenants = new List<ClassIntervenant>();
        Dictionary<int, Activite> dico = new Dictionary<int, Activite>();
        public ChoixActivite(int ideleve)
        {
            InitializeComponent();
            this.ideleve = ideleve;
        }

        private void ChoixActivite_Load(object sender, EventArgs e)
        {
            lesActivites= Initactivitesnoninscrit(ideleve);
            lesActivites = lesActivites.OrderBy(x => x.Heuredebut).ToList();
            List<DateJoach> lesdates = ladate.initDateJoach(); // Récupère toutes les dates grâce à la méthode dans la classe DateJoach
            foreach(DateJoach d in lesdates)
            {
                if(Convert.ToBoolean(d.Inscriteleve) == false && Convert.ToBoolean(d.Inscritprof) == false)
                    CB_Date.Items.Add(d.Dateevenement.ToLongDateString());
            }
            List<Type> lestypes = type.InitType(); // Récupère tous les types grâce à la méthode dans la classe Type
            foreach(Type t in lestypes)
            {
                CB_Type.Items.Add(t.Libelle);
            }
            lesIntervenants = intervenant.InitIntervenant();
            Controleur.Vmodele.charger_anime();
            filtrer();
        }
        private List<Activite> Initactivitesnoninscrit(int ideleve)
        {
            List<Activite> lesActivites = new List<Activite>();
            Controleur.Vmodele.charger_activites_noninscrit_eleve(ideleve);
            for (int i =0; i < Controleur.Vmodele.DTactivitesnoninscriteleve.Rows.Count; i++)
            {
                int id = Convert.ToInt32(Controleur.Vmodele.DTactivitesnoninscriteleve.Rows[i][0]);
                int idtype = Convert.ToInt32(Controleur.Vmodele.DTactivitesnoninscriteleve.Rows[i][1]);
                string libelle = Controleur.Vmodele.DTactivitesnoninscriteleve.Rows[i][2].ToString();
                string description = Controleur.Vmodele.DTactivitesnoninscriteleve.Rows[i][3].ToString();
                DateTime Heuredebut = Convert.ToDateTime(Controleur.Vmodele.DTactivitesnoninscriteleve.Rows[i][4].ToString());
                DateTime Heurefin = Convert.ToDateTime(Controleur.Vmodele.DTactivitesnoninscriteleve.Rows[i][5].ToString());
                int nbplace = Convert.ToInt32(Controleur.Vmodele.DTactivitesnoninscriteleve.Rows[i][6]);
                string salle = Controleur.Vmodele.DTactivitesnoninscriteleve.Rows[i][7].ToString();
                string code = Controleur.Vmodele.DTactivitesnoninscriteleve.Rows[i][8].ToString();
                Activite act = new Activite(id, idtype,libelle, description, Heuredebut, Heurefin, nbplace, salle, code);
                lesActivites.Add(act);
            }
            return lesActivites;

        }
        private void filtrer()
        {
            int cledico = 0;
            int clerechercher = 0;
            bool filtredate = true;
            bool filtretype = true;
            bool filtrecode = true;
            dico.Clear();
            foreach (Activite act in lesActivites)
            {
                if (CB_Date.Text != "")
                {
                    filtredate = act.Heuredebut.ToLongDateString().Equals(CB_Date.Text);
                }
                if(CB_Type.Text != "")
                {
                    filtretype = type.getLibelleType(act.IdType) == CB_Type.Text;// Permet de tester avec la méthode de classe type si le type choisi (string) correspond au type de la classe.
                }
                if(TB_Code.Text != "")
                {
                    filtrecode = act.Code.StartsWith(TB_Code.Text);
                }
                if(filtredate == true && filtretype == true && filtrecode == true)
                {
                    cledico++;
                    dico.Add(cledico, act);
                }
            }
            LB_Activité.Items.Clear();
            foreach (KeyValuePair<int, Activite> act in dico)
            {
                clerechercher++;
                LB_Activité.Items.Add(act.Value.Code + " - " + act.Value.Libelle);
            }
        }
        private void vider()
        {
            TB_DetailTitre.Text = "";
            TB_DetailType.Text = "";
            
            TB_DetailIntervenant.Text = "";
            TB_DetailDate.Text = "";
            TB_DetailHeureDebut.Text = "";
            TB_DetailHeureFin.Text = "";
            TB_DetailPlace.Text = "";
            TB_DetailSalle.Text = "";
            RTB_DetailDescription.Text = "";
        }
        private void CB_Date_SelectedIndexChanged(object sender, EventArgs e)
        {
            vider();
            filtrer();
        }

        private void CB_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            vider();
            filtrer();
        }

        private void TB_Code_TextChanged(object sender, EventArgs e)
        {
            vider();
            filtrer();
        }

        private void LB_Activité_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassIntervenant interv = new ClassIntervenant();
            int j = LB_Activité.SelectedIndex + 1;
            foreach(KeyValuePair<int,Activite> actrechercher in dico)
            {
                if(actrechercher.Key == j)
                {
                    TB_DetailTitre.Text = actrechercher.Value.Libelle;
                    TB_DetailType.Text = type.getLibelleType(actrechercher.Value.IdType);
                    interv = getIntervenant(actrechercher.Value.Id);
                    if (interv != null)
                        TB_DetailIntervenant.Text = interv.Nom + " " + interv.Prenom;
                    else
                        TB_DetailIntervenant.Text = "aucun intervenant";
                    TB_DetailDate.Text = actrechercher.Value.Heuredebut.ToLongDateString();
                    TB_DetailHeureDebut.Text = actrechercher.Value.Heuredebut.ToShortTimeString();
                    TB_DetailHeureFin.Text = actrechercher.Value.Heurefin.ToShortTimeString();
                    TB_DetailPlace.Text = actrechercher.Value.Nombreplaces.ToString();
                    TB_DetailSalle.Text = actrechercher.Value.Salle;
                    RTB_DetailDescription.Text = actrechercher.Value.Description;
                }
            }
        }
        private ClassIntervenant getIntervenant(int ida)
        {
            for(int i =0; i < Controleur.Vmodele.DTanime.Rows.Count; i++)
            {
                if (Controleur.Vmodele.DTanime.Rows[i][1].Equals(ida))
                {
                    foreach (ClassIntervenant interv in lesIntervenants)
                    {
                        if (interv.Id == Convert.ToInt32(Controleur.Vmodele.DTanime.Rows[i][0]))
                            return interv;
                    }
                }
            }
            return null;
        }
        private void Btn_Valider_Click(object sender, EventArgs e)
        {
            bool pasdeplace = false;
            bool adejaspectacle = false;
            Activite acti = new Activite();
            List<Activite> lesactivitesinscrit = acti.initActivitesEleve(ideleve);
            bool adejaactivite = false; //Si true alors l'élève a déja une activité pendant cette période
            int idremove = 0;
            if (LB_Activité.SelectedIndex + 1 > 0)
            {
                int idA = 0;
                int j = LB_Activité.SelectedIndex + 1;
                foreach (KeyValuePair<int, Activite> actrechercher in dico)
                {
                    if (actrechercher.Key == j)
                    {
                        Controleur.Vmodele.charger_nbinscrit_activite(actrechercher.Value.Id);
                        int nbplace = Convert.ToInt32(Controleur.Vmodele.DTnbinscritactivite.Rows[0][0]);
                        if (actrechercher.Value.Nombreplaces - nbplace < 1)
                        {
                            MessageBox.Show("Il n'y a plus de place disponible pour cette activité");
                            pasdeplace = true;
                            break;
                        }
                        if (lesactivitesinscrit.Count == 0)
                            idA = actrechercher.Value.Id;
                        else
                        {
                            foreach (Activite activite in lesactivitesinscrit)
                            {
                                if (type.getLibelleType(activite.IdType) == "Spectacle" && type.getLibelleType(actrechercher.Value.IdType) == "Spectacle")
                                {
                                    MessageBox.Show("Vous êtes déja inscrit à un spectacle", "Impossible de vous inscrire");
                                    adejaspectacle = true;
                                    break;
                                }
                            }
                            foreach (Activite activite in lesactivitesinscrit)
                            {
                                if (adejaspectacle == true)
                                    break;
                                if (activite.Heuredebut < actrechercher.Value.Heurefin && activite.Heurefin < actrechercher.Value.Heuredebut || activite.Heuredebut > actrechercher.Value.Heurefin && activite.Heurefin > actrechercher.Value.Heuredebut)
                                    idA = actrechercher.Value.Id;
                                else
                                {
                                    MessageBox.Show("Vous avez déja une activité pendant l'horaire de l'activité sélectionnée", "Impossible de vous inscrire");
                                    adejaactivite = true;
                                    break;
                                }
                            }
                        }
                        idremove = actrechercher.Key;
                    }
                }
                if (adejaactivite != true && adejaspectacle != true && pasdeplace != true)
                {
                    Controleur.ajouterEleveActivite(idA, ideleve);
                    foreach (KeyValuePair<int,Activite> act in dico)
                    {
                        if (LB_Activité.SelectedIndex + 1 == act.Key)
                        {
                            lesActivites.Remove(act.Value);
                            break;
                        }
                    }
                    dico.Remove(idremove);
                    filtrer();
                }
            }
            else
                MessageBox.Show("Veuillez sélectionner une activité", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                CB_Date.SelectedIndex = -1;
                CB_Type.SelectedIndex = -1;
                TB_Code.Text = "";
                LB_Activité.SelectedIndex = -1;
                vider();
            }
        }
    }
}

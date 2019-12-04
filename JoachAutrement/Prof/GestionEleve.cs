using JoachAutrement.Activités;
using JoachAutrement.Eleve;
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

namespace JoachAutrement.Prof
{
    public partial class GestionEleve : Form
    {
        bool inscription = false;
        DateJoach ladate = new DateJoach();
        List<DateJoach> lesdates;
        Activite lactivite = new Activite();
        List<Activite> lesactivites;
        Dictionary<int, Activite> dicoactivites = new Dictionary<int, Activite>();
        Utilisateur lutilisateur = new Utilisateur();
        List<Utilisateur> lesutilisateurs;
        Dictionary<int, Utilisateur> dicoutilisateurs = new Dictionary<int, Utilisateur>();
        Classe laclasse = new Classe();
        List<Classe> lesclasses;
        Type letype = new Type();
        List<Type> lestypes;
        Inscrit linscrit = new Inscrit();
        List<Inscrit> lesinscrits = new List<Inscrit>();
        ClassIntervenant lintervenant = new ClassIntervenant();
        List<ClassIntervenant> lesIntervenants = new List<ClassIntervenant>();
        public GestionEleve(string typegestion)
        {
            InitializeComponent();
            if (typegestion == "inscription")
                inscription = true;
        }

        private void InscrireEleve_Load(object sender, EventArgs e)
        {
            if (inscription == false)
            {
                btn_inscrire.Text = "Retirer de l'activité";
                CB_touseleve.Visible = false;
            }
            lesdates = ladate.initDateJoach();
            lesactivites = lactivite.InitActivite();
            lesactivites = lesactivites.OrderBy(x => x.Heuredebut).ToList();
            lutilisateur.InitEleve();
            lesutilisateurs = lutilisateur.lesEleves;
            lesclasses = laclasse.InitClasse();
            lestypes = letype.InitType();
            lesIntervenants = lintervenant.InitIntervenant();
            Controleur.Vmodele.charger_anime();
            foreach (DateJoach dat in lesdates)
            {
                if (Convert.ToBoolean(dat.Inscriteleve) == false && Convert.ToBoolean(dat.Inscritprof) == false)
                    CB_date.Items.Add(dat.Dateevenement.ToLongDateString());
            }
            chargerClasses("");
            foreach(Type typ in lestypes)
            {
                CB_type.Items.Add(typ.Libelle);
            }
            filtrerEleve();
            filtrerActivite();
        }

        public void chargerClasses(string libelle)
        {
            CB_classe.Items.Clear();
            foreach (Classe cla in lesclasses)
            {
                if (cla.Libelle.StartsWith(libelle))
                {
                    CB_classe.Items.Add(cla.Libelle);
                }
            }
        }
        private void filtrerEleve()
        {
            int clerechercher = 0;
            int cledico = 0;
            bool filtreeleve = true;
            bool filtrenom = true;
            bool filtreclasse = true;
            dicoutilisateurs.Clear();
            foreach (Utilisateur eleve in lesutilisateurs)
            {
                if (TB_prenom.Text != "")
                    filtreeleve = eleve.PrenomU.Contains(TB_prenom.Text);
                if (TB_nom.Text != "")
                    filtrenom = eleve.NomU.Contains(TB_nom.Text);
                if (CB_classe.Text != "")
                    filtreclasse = laclasse.getLibelleClasse(eleve.IDC).Contains(CB_classe.Text);
                if(filtreeleve == true && filtrenom == true && filtreclasse == true)
                {
                    cledico++;
                    dicoutilisateurs.Add(cledico, eleve);
                }
            }
            LB_selecteleve.Items.Clear();
            foreach(KeyValuePair<int,Utilisateur> dico in dicoutilisateurs)
            {
                clerechercher++;
                LB_selecteleve.Items.Add(dico.Value.NomU + " " + dico.Value.PrenomU);
            }
            label_nb.Text = dicoutilisateurs.Values.Count.ToString();
        }
        private void filtrerActivite()
        {
            int clerechercher = 0;
            int cledico = 0;
            bool filtredate = true;
            bool filtretype = true;
            bool filtrecode = true;
            dicoactivites.Clear();
            foreach (Activite act in lesactivites)
            {
                if (CB_date.Text != "")
                    filtredate = act.Heuredebut.ToLongDateString().Equals(CB_date.Text);
                if (CB_type.Text != "")
                    filtretype = act.IdType == letype.getIdType(CB_type.Text);
                if (TB_code.Text != "")
                    filtrecode = act.Code.StartsWith(TB_code.Text);
                if (filtredate == true && filtretype == true && filtrecode == true)
                {
                    cledico++;
                    dicoactivites.Add(cledico, act);
                }
            }
            LB_selectactivite.Items.Clear();
            foreach (KeyValuePair<int, Activite> dico in dicoactivites)
            {
                clerechercher++;
                LB_selectactivite.Items.Add(dico.Value.Code + " - " + dico.Value.Libelle);
            }
        }
        private void btn_inscrire_Click(object sender, EventArgs e)
        {
            bool adejaactivite = false;
            bool adejaspectacle = false;
            int idA = 0;
            int cledicoselect = -1;
            Activite acti = new Activite();
            List<Utilisateur> lesusersdejapris = new List<Utilisateur>();
            List<Utilisateur> lesusersdejaspectacle = new List<Utilisateur>();
            foreach (KeyValuePair<int, Activite> activite in dicoactivites) // Permet de trouver l'id de l'activité sélectionnée
            {
                if (activite.Key == LB_selectactivite.SelectedIndex + 1)
                {
                    idA = activite.Value.Id;
                    cledicoselect = LB_selectactivite.SelectedIndex + 1;
                    break;
                }
            }
            if (LB_selecteleve.CheckedItems.Count == 0) // Test si il y a au moins un élève de sélectionné
                MessageBox.Show("Veuillez sélectionner un élève ou une classe", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (LB_selectactivite.SelectedIndex == -1) // Test si il y a une activité de sélectionnée
                MessageBox.Show("Veuillez sélectionner une activité", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (inscription == false) // Test si il ne s'agit pas de la fonctionnalité retrait d'un élève
            {
                if (LB_selecteleve.CheckedItems.Count == 1)
                {
                    Controleur.retirerActivite(trouverIdActivite(), trouverIdEleve());
                    filtrerActivite();
                }
                else
                {
                    if (LB_selecteleve.CheckedItems.Count == LB_selecteleve.Items.Count)
                    {
                        List<int> leseleves = new List<int>();
                        foreach (KeyValuePair<int, Utilisateur> eleve in dicoutilisateurs)
                        {
                            leseleves.Add(eleve.Value.IDU);
                        }
                        Controleur.retirerActivite(trouverIdActivite(), leseleves);
                    }
                    else
                    {
                        List<int> leseleves = new List<int>();
                        for (int i = 0; i < LB_selecteleve.Items.Count; i++)
                        {
                            if (LB_selecteleve.GetItemChecked(i))
                            {
                                foreach(KeyValuePair<int,Utilisateur> user in dicoutilisateurs)
                                {
                                    if (user.Key == i + 1)
                                    {
                                        leseleves.Add(user.Value.IDU);
                                    }
                                }
                            }
                        }
                        Controleur.retirerActivite(trouverIdActivite(),leseleves);
                    }
                }
                
            }
            else if (nbplaceok(LB_selecteleve.CheckedItems.Count, idA) == false)
                MessageBox.Show("Pas assez de place(s) dans l'activité", "Inscription impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (LB_selecteleve.CheckedItems.Count > 1)
                {
                    List<int> lesids = new List<int>();
                    if (LB_selecteleve.CheckedItems.Count == LB_selecteleve.Items.Count) //Si tous les élèves dans la listbox sont sélectionnés
                    {
                        foreach (KeyValuePair<int, Utilisateur> eleve in dicoutilisateurs)
                        {
                            lesids.Add(eleve.Value.IDU);
                        }
                        foreach (int i in lesids)
                        {
                            bool elevepris = false; // Si l'élève à une activité pendant cette période (empêcher les doublons lors des messages d'erreur)
                            List<Activite> lesactivitesinscrit = acti.initActivitesEleve(i);
                            foreach (Activite activite in lesactivitesinscrit)
                            {
                                MessageBox.Show("date : " + activite.Heuredebut.ToLongDateString());
                                if (activite.Heuredebut.ToLongDateString() == dicoactivites[cledicoselect].Heuredebut.ToLongDateString())
                                {
                                    
                                    if ((activite.Heuredebut < dicoactivites[cledicoselect].Heurefin && activite.Heurefin < dicoactivites[cledicoselect].Heuredebut) || (activite.Heuredebut > dicoactivites[cledicoselect].Heurefin && activite.Heurefin > dicoactivites[cledicoselect].Heuredebut))
                                    { }
                                    else
                                    { 
                                        adejaactivite = true;
                                        foreach (KeyValuePair<int, Utilisateur> eleve in dicoutilisateurs)
                                        {
                                            if (eleve.Value.IDU == i)
                                            {
                                                lesusersdejapris.Add(eleve.Value);
                                                elevepris = true;
                                                break;
                                            }
                                        }

                                    }
                                }
                                if (letype.getLibelleType(activite.IdType) == "Spectacle" && letype.getLibelleType(dicoactivites[cledicoselect].IdType) == "Spectacle")
                                {
                                    adejaspectacle = true;
                                    foreach (KeyValuePair<int, Utilisateur> eleve in dicoutilisateurs)
                                    {
                                        if (eleve.Value.IDU == i)
                                        {
                                            lesusersdejaspectacle.Add(eleve.Value);
                                        }
                                    }
                                }
                                if (elevepris == true)
                                {
                                    break;
                            }
                        }
                        }
                        if (adejaactivite == true)
                        {
                            string listelevedejapris = "";
                            foreach (Utilisateur u in lesusersdejapris)
                            {
                                listelevedejapris += "\n" + u.NomU + " " + u.PrenomU;
                            }
                            MessageBox.Show("Parmi le ou les élève(s) sélectionné(s), il y a un ou plusieurs élève(s) qui a ou ont déja une activité pendant cet horaire :" + listelevedejapris, "Inscription impossible");
                        }
                        if (adejaspectacle == true)
                        {
                            string listelevespectacle = "";
                            foreach (Utilisateur u in lesusersdejaspectacle)
                            {
                                listelevespectacle += "\n" + u.NomU + " " + u.PrenomU;
                            }
                            MessageBox.Show("Parmi le ou les élève(s) sélectionné(s), il y a un ou plusieurs élève(s) qui a ou ont déja un spectacle :" + listelevespectacle, "Inscription impossible");
                        }
                        if (adejaactivite != true && adejaspectacle != true)
                            Controleur.ajouterElevesActivite(lesids, idA);
                    }
                    else
                    {
                        for (int i = 0; i < LB_selecteleve.Items.Count; i++)
                        {
                            if (LB_selecteleve.GetItemChecked(i) == true)
                            {
                                foreach (KeyValuePair<int, Utilisateur> y in dicoutilisateurs)
                                {
                                    i++;
                                    if (i == y.Key)
                                    {
                                        lesids.Add(y.Value.IDU);
                                    }
                                    i--;
                                }
                            }
                        }
                        foreach (int i in lesids)
                        {
                            bool elevepris = false; // Si l'élève à une activité pendant cette période (empêcher les doublons lors des messages d'erreur)
                            List<Activite> lesactivitesinscrit = acti.initActivitesEleve(i);
                                    foreach (Activite activite in lesactivitesinscrit)
                                    {
                                        if (activite.Heuredebut.ToLongDateString() == dicoactivites[cledicoselect].Heuredebut.ToLongDateString())
                                        {
                                    if ((activite.Heuredebut < dicoactivites[cledicoselect].Heurefin && activite.Heurefin < dicoactivites[cledicoselect].Heuredebut) || (activite.Heuredebut > dicoactivites[cledicoselect].Heurefin && activite.Heurefin > dicoactivites[cledicoselect].Heuredebut))
                                            { }
                                            else
                                            { 
                                                adejaactivite = true;
                                        foreach (KeyValuePair<int, Utilisateur> eleve in dicoutilisateurs)
                                        {
                                            if (eleve.Value.IDU == i)
                                            {
                                                lesusersdejapris.Add(eleve.Value);
                                                elevepris = true;
                                                break;
                                            }
                                        }

                                            }
                                        }
                                        if (letype.getLibelleType(activite.IdType) == "Spectacle" && letype.getLibelleType(dicoactivites[cledicoselect].IdType) == "Spectacle")
                                        {
                                            adejaspectacle = true;
                                    foreach (KeyValuePair<int, Utilisateur> eleve in dicoutilisateurs)
                                    {
                                        if (eleve.Value.IDU == i)
                                        {
                                            lesusersdejaspectacle.Add(eleve.Value);
                                        }
                                    }
                                }
                                if (elevepris == true)
                                    break;
                            }
                        }
                        if (adejaactivite == true)
                        {
                            string listelevedejapris = "";
                            foreach (Utilisateur u in lesusersdejapris)
                            {
                                listelevedejapris += "\n" + u.NomU + " " + u.PrenomU;
                            }
                            MessageBox.Show("Parmi le ou les élève(s) sélectionné(s), il y a un ou plusieurs élève(s) qui a ou ont déja une activité pendant cet horaire :" + listelevedejapris, "Inscription impossible");
                        }
                        if (adejaspectacle == true)
                        {
                            string listelevespectacle = "";
                            foreach (Utilisateur u in lesusersdejaspectacle)
                            {
                                listelevespectacle += "\n" + u.NomU + " " + u.PrenomU;
                            }
                            MessageBox.Show("Parmi le ou les élève(s) sélectionné(s), il y a un ou plusieurs élève(s) qui a ou ont déja un spectacle :" + listelevespectacle, "Inscription impossible");
                        }
                        if (adejaactivite != true && adejaspectacle != true)
                            Controleur.ajouterElevesActivite(lesids, trouverIdActivite());
                    }
                }
                else
                {
                    bool estdejainscrit = false;
                    List<Activite> lesactivitesinscrit = acti.initActivitesEleve(trouverIdEleve());
                    foreach (Activite activite in lesactivitesinscrit)
                    {
                        if (activite.Heuredebut < dicoactivites[cledicoselect].Heurefin && activite.Heurefin < dicoactivites[cledicoselect].Heuredebut || activite.Heuredebut > dicoactivites[cledicoselect].Heurefin && activite.Heurefin > dicoactivites[cledicoselect].Heuredebut)
                        { }
                        else
                            estdejainscrit = true;
                        if (letype.getLibelleType(activite.IdType) == "Spectacle" && letype.getLibelleType(dicoactivites[cledicoselect].IdType) == "Spectacle")
                            adejaspectacle = true;
                    }
                    if (estdejainscrit != true && adejaspectacle != true)
                        Controleur.ajouterEleveActivite(trouverIdActivite(), trouverIdEleve());
                    else if (estdejainscrit == true)
                        MessageBox.Show("Eleve déja inscrit à une activité pendant cette période", "Inscription impossible");
                    else if (adejaspectacle == true)
                        MessageBox.Show("L'élève sélectionné est déja inscrit un spectacle", "Inscription impossible");
                }
            }
        }

        #region Evénement changement de valeur dans les filtres
        private void TB_prenom_TextChanged(object sender, EventArgs e)
        {
            filtrerEleve();
        }

        private void TB_nom_TextChanged(object sender, EventArgs e)
        {
            filtrerEleve();
        }

        private void CB_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrerActivite();
            vider();
        }

        private void CB_type_SelectedIndexChanged(object sender, EventArgs e)
        { 
            filtrerActivite();
            vider();
        }

        private void TB_code_TextChanged(object sender, EventArgs e)
        {
            filtrerActivite();
            vider();
        }

        private void CB_classe_TextChanged(object sender, EventArgs e)
        {
            if (CB_classe.Text != "")
                CB_touseleve.Visible = true;
            filtrerEleve();
        }

        private void LB_selecteleve_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrerActivite();
        }
        #endregion

        private int trouverIdEleve()
        {
            int indicecocher = 0;
            for (int i = 0; i < LB_selecteleve.Items.Count; i++)
            {
                if (LB_selecteleve.GetItemChecked(i))
                {
                    indicecocher = i;
                }
            }
            foreach (KeyValuePair<int, Utilisateur> eleve in dicoutilisateurs)
            {
                
                if (eleve.Key == indicecocher + 1)
                    return eleve.Value.IDU;
            }
            return 0;
        }
        private int trouverIdActivite()
        {
            foreach (KeyValuePair<int, Activite> activite in dicoactivites)
            {
                if (activite.Key == LB_selectactivite.SelectedIndex + 1)
                    return activite.Value.Id;
            }
            return 0;
        }
        private bool nbplaceok (int nb, int idActivite)
        {
            int nbplacerestante = 0;
            Controleur.Vmodele.charger_nbinscrit_activite(idActivite);
            foreach (Activite act in lesactivites)
            {
                if(act.Id == idActivite)
                    nbplacerestante = act.Nombreplaces - Convert.ToInt32(Controleur.Vmodele.DTnbinscritactivite.Rows[0][0]);
            }
            if (nbplacerestante < nb)
                return false;
            else
                return true;
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            CB_classe.SelectedIndex = -1;
            CB_classe.Text = "";
            CB_date.SelectedIndex = -1;
            CB_type.SelectedIndex = -1;
            CB_touseleve.Checked = false;
            CB_touseleve.Visible = false;
            TB_code.Text = "";
            TB_nom.Text = "";
            TB_prenom.Text = "";
            LB_selectactivite.SelectedIndex = -1;
            vider();
        }

        private void CB_touseleve_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_touseleve.Checked == true)
            {
                TB_prenom.Clear();
                TB_prenom.Enabled = false;
                TB_nom.Clear();
                TB_nom.Enabled = false;
                label_nbeleve.Visible = true;
                label_nb.Visible = true;
                for (int i = 0; i < LB_selecteleve.Items.Count; i++)
                {
                    LB_selecteleve.SetItemChecked(i, true);
                }
            }
            else
            {
                TB_prenom.Enabled = true;
                TB_nom.Enabled = true;
                label_nbeleve.Visible = false;
                label_nb.Visible = false;
                for (int i = 0; i < LB_selecteleve.Items.Count; i++)
                {
                    LB_selecteleve.SetItemChecked(i, false);
                }
            }
        }

        private void LB_selectactivite_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassIntervenant interv = new ClassIntervenant();
            int j = LB_selectactivite.SelectedIndex + 1;
            foreach (KeyValuePair<int, Activite> actrechercher in dicoactivites)
            {
                if (actrechercher.Key == j)
                {
                    TB_DetailTitre.Text = actrechercher.Value.Libelle;
                    TB_DetailType.Text = letype.getLibelleType(actrechercher.Value.IdType);
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
                }
            }
        }
        private ClassIntervenant getIntervenant(int ida)
        {
            for (int i = 0; i < Controleur.Vmodele.DTanime.Rows.Count; i++)
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
        public void vider()
        {
            TB_DetailTitre.Text = "";
            TB_DetailType.Text = "";
            TB_DetailIntervenant.Text = "";
            TB_DetailDate.Text = "";
            TB_DetailHeureDebut.Text = "";
            TB_DetailHeureFin.Text = "";
            TB_DetailPlace.Text = "";
            TB_DetailSalle.Text = "";
        }

        private void CB_classe_DropDown(object sender, EventArgs e)
        {
            chargerClasses(CB_classe.Text);
        }

    }
}

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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using JoachAutrement.Eleve;
using JoachAutrement.PDF;
using JoachAutrement.Prof;
using MySql.Data.MySqlClient;

namespace JoachAutrement
{
    public partial class FormUsers : Form
    {
        Utilisateur User1;

        GestionActivites FormGestionActivite;
        AjouterActivites FormAjoutActivite;
        ChoixActivite FormChoix;
        FiltrePDF FormFiltrePDF;
        AttributionSalle FormAtributionSalle;
        ChercherEleve FormChercherEleve;
        GestionEleve inscrieleveprof;
        GestionEleve retirerinscrieleveprof;
        GestionDesComptesUsers GestionComptes;
        RetirerActivite FormRetirerActiviter;
        ChercherClasse FormChercherClasse;
        FormAdministrateur FormAdmin;
        DateJoach date;

        public FormUsers(Utilisateur user)
        {
            bool verif = true;
            date = new DateJoach();
            User1 = user;
            InitializeComponent();
            #region Gestion niveau de permission
            switch (User1.IDP)
            {
                case 1: // permissions pour les eleves
                    gestionDesElevesToolStripMenuItem.Enabled = false;
                    gestionDesElevesToolStripMenuItem.Visible = false;

                    gestionComptesToolStripMenuItem.Enabled = false;
                    gestionComptesToolStripMenuItem.Visible = false;

                    gestionDesActivitésToolStripMenuItem.Enabled = false;
                    gestionDesActivitésToolStripMenuItem.Visible = false;

                    impressionsToolStripMenuItem.Enabled = false;
                    impressionsToolStripMenuItem.Visible = false;

                    administrateurToolStripMenuItem.Enabled = false;
                    administrateurToolStripMenuItem.Visible = false;

                    if (User1.Valide == true)
                    {
                        ajoutDuneActivitéToolStripMenuItem.Enabled = false;
                        retirerUneActivitéToolStripMenuItem.Enabled = false;
                    }
                    verif = date.testerDateEleve();
                    creerSonPlanningToolStripMenuItem.Enabled = verif;
                    if (verif == false) { MessageBox.Show("Vous ne pouvez pas encore vous inscrire"); }
                    break;

                case 2: // permissions pour les professeurs
                    creerSonPlanningToolStripMenuItem.Enabled = false;
                    creerSonPlanningToolStripMenuItem.Visible = false;

                    gestionDesActivitésToolStripMenuItem.Enabled = false;
                    gestionDesActivitésToolStripMenuItem.Visible = false;

                    gestionComptesToolStripMenuItem.Enabled = false;
                    gestionComptesToolStripMenuItem.Visible = false;

                    impressionsToolStripMenuItem.Enabled = false;
                    impressionsToolStripMenuItem.Visible = false;

                    administrateurToolStripMenuItem.Visible = false;
                    administrateurToolStripMenuItem.Enabled = false;

                    verif = date.testerDateProf();
                    gestionDesElevesToolStripMenuItem.Enabled = verif;
                    if (verif == false) { MessageBox.Show("Vous ne pouvez pas encore inscrire des élèves"); }

                    break;

                case 3: // permissions pour professeur avec impressions
                    creerSonPlanningToolStripMenuItem.Enabled = false;
                    creerSonPlanningToolStripMenuItem.Visible = false;

                    gestionDesActivitésToolStripMenuItem.Enabled = false;
                    gestionDesActivitésToolStripMenuItem.Visible = false;

                    gestionComptesToolStripMenuItem.Enabled = false;
                    gestionComptesToolStripMenuItem.Visible = false;

                    administrateurToolStripMenuItem.Visible = false;
                    administrateurToolStripMenuItem.Enabled = false;

                    verif = date.testerDateProf();
                    gestionDesElevesToolStripMenuItem.Enabled = verif;
                    if (verif == false) { MessageBox.Show("Vous ne pouvez pas encore inscrire des élèves"); }
                    break;

                case 4: // permissions pour les organisateurs
                    creerSonPlanningToolStripMenuItem.Enabled = false;
                    creerSonPlanningToolStripMenuItem.Visible = false;

                    administrateurToolStripMenuItem.Visible = false;
                    administrateurToolStripMenuItem.Enabled = false;

                    gestionProfsToolStripMenuItem.Visible = false;
                    gestionProfsToolStripMenuItem.Enabled = false;

                    verif = date.testerDateProf();
                    gestionDesElevesToolStripMenuItem.Enabled = verif;
                    if (verif == false) { MessageBox.Show("Vous ne pouvez pas encore inscrire des élèves"); }
                    break;

                case 5: // permissions administrateur
                    creerSonPlanningToolStripMenuItem.Enabled = false;
                    creerSonPlanningToolStripMenuItem.Visible = false;

                    verif = date.testerDateProf();
                    gestionDesElevesToolStripMenuItem.Enabled = verif;
                    if (verif == false) { MessageBox.Show("Vous ne pouvez pas encore inscrire des élèves"); }
                    break;

                default:
                    MessageBox.Show("Erreur", "Erreur de Permission");
                    break;
            }
            this.Text = "" + User1.NomU + "  " + User1.PrenomU + "  Bienvenue.";
        }// permet de gerer les permissions lors du log de l'utilisateur
        #endregion

        private void ajouterDesActivitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutActivite = new AjouterActivites();
            fermerFormFille();
            FormAjoutActivite.Text = "Ajouter une Activité";
            FormAjoutActivite.MdiParent = this;
            FormAjoutActivite.Show();
        }

        private void modifierOuSupprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Attention de ne pas modifier ou supprimer d'activité lors des inscriptions des élèves ou des professeurs"
                + "\nSi vous devez effectuer une opération après le debut des inscriptions, attendre une période creuse (le soir ou le matin)",
                "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            FormGestionActivite = new GestionActivites();
            fermerFormFille();
            FormGestionActivite.Text = "Modifier une Activité";
            FormGestionActivite.MdiParent = this;
            FormGestionActivite.Show();
        }

        private void consulterLesActivitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualisationPDF FormVisualisationPDF = new VisualisationPDF("listeactivitelecture");
            fermerFormFille();
            FormVisualisationPDF.MdiParent = this;
            FormVisualisationPDF.Show();
        }

        private void ajoutDuneActivitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChoix = new ChoixActivite(User1.IDU);
            fermerFormFille();
            FormChoix.Text = "Ajouter une activité";
            FormChoix.MdiParent = this;
            FormChoix.Show();

        }

        private void retirerDesElevesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            retirerinscrieleveprof = new GestionEleve("retirer");
            fermerFormFille();
            retirerinscrieleveprof.Text = "Retirer des eleves d'une activité";
            retirerinscrieleveprof.MdiParent = this;
            retirerinscrieleveprof.Show();
        }

        private void pDFActivitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFiltrePDF = new FiltrePDF();
            fermerFormFille();
            FormFiltrePDF.Text = "Chercher une activité";
            FormFiltrePDF.MdiParent = this;
            FormFiltrePDF.Show();
        }

        private void pDFListeIntervenantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualisationPDF FormVisualisationPDF = new VisualisationPDF("listeintervenant");
            fermerFormFille();
            FormVisualisationPDF.MdiParent = this;
            FormVisualisationPDF.Show();
        }

        private void voirSonProgrammeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermerFormFille();
            try
            {
                VisualisationPDF VisuPDF = new VisualisationPDF("listeactiviteselevep", User1.IDU);
                VisuPDF.MdiParent = this;
                VisuPDF.Show();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message.ToString());
            }
        }

        private void fermerFormFille()
        {
            if(this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
        }

        private void pDFListeActivitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualisationPDF FormVisualisationPDF = new VisualisationPDF("listeactiviteimpression");
            fermerFormFille();
            FormVisualisationPDF.MdiParent = this;
            FormVisualisationPDF.Show();
        }

        private void attributionDuneSalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Activite> lesActiviteSansSalle = new List<Activite>();
            Activite act = new Activite();
            List<Activite> lesActivites = new List<Activite>();
            lesActivites = act.InitActivite();

            foreach (Activite a in lesActivites)
            {
                if (string.IsNullOrEmpty(a.Salle))
                    lesActiviteSansSalle.Add(a);
            }

            if (lesActiviteSansSalle.Count != 0)
            {
                FormAtributionSalle = new AttributionSalle();
                fermerFormFille();
                FormAtributionSalle.Text = "Attribuer une salle";
                FormAtributionSalle.MdiParent = this;
                FormAtributionSalle.Show();
            }
            else
                MessageBox.Show("Toutes les activitées ont deja des salles");
        }

        private void FormUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            
        }

        private void retirerUneActivitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRetirerActiviter = new RetirerActivite(User1.IDU);
            fermerFormFille();
            FormRetirerActiviter.Text = "retirer une activité";
            FormRetirerActiviter.MdiParent = this;
            FormRetirerActiviter.Show();

        }

        private void pDFEleveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormChercherEleve = new ChercherEleve("listeactiviteselevei");
            fermerFormFille();
            FormChercherEleve.Text = "Rechercher un eleve";
            FormChercherEleve.MdiParent = this;
            FormChercherEleve.Show();
        }

        private void pDFListeElevesNonInscritsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            VisualisationPDF FormVisualisationPDF = new VisualisationPDF("listeEleveNonValide");
            fermerFormFille();
            FormVisualisationPDF.MdiParent = this;
            FormVisualisationPDF.Show();
        }

        private void pDFListeSimplifiéDesActivitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualisationPDF FormVisualisationpdf = new VisualisationPDF("listeactivitessimplifiées");
            fermerFormFille();
            FormVisualisationpdf.MdiParent = this;
            FormVisualisationpdf.Show();
        }

        private void pDFListeElevesInscritToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChercherClasse = new ChercherClasse();
            fermerFormFille();
            FormChercherClasse.Text = "Rechercher une classe";
            FormChercherClasse.MdiParent = this;
            FormChercherClasse.Show();
        }

        private void gestionIntervenantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionComptes = new GestionDesComptesUsers(1);
            fermerFormFille();
            GestionComptes.Text = "Gestion des Intervenants";
            GestionComptes.MdiParent = this;
            GestionComptes.Show();
        }
        private void gestionProfsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionComptes = new GestionDesComptesUsers(2);
            fermerFormFille();
            GestionComptes.Text = "Gestion des comptes Professeurs";
            GestionComptes.MdiParent = this;
            GestionComptes.Show();
        }

        private void gestionElevesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionComptes = new GestionDesComptesUsers(3);
            fermerFormFille();
            GestionComptes.Text = "Gestion des comptes Eleves";
            GestionComptes.MdiParent = this;
            GestionComptes.Show();
        }

        private void inscrireDesElevesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inscrieleveprof = new GestionEleve("inscription");
            fermerFormFille();
            inscrieleveprof.Text = "Inscrire des Eleves";
            inscrieleveprof.MdiParent = this;
            inscrieleveprof.Show();
        }

        private void consulterPasseportDunÉlèveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChercherEleve = new ChercherEleve("listeactiviteselevep");
            fermerFormFille();
            FormChercherEleve.Text = "Selectionnez l'éleve";
            FormChercherEleve.MdiParent = this;
            FormChercherEleve.Show();
        }

        private void imprimerMonPlanningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ademijournee = true;
            TimeSpan nbheureseleve;
            Utilisateur eleve = User1.InitlEleve(User1.IDU);
            Activite act = new Activite();
            List<DateJoach> lesdates = date.initDateJoach();
            List<Activite> lesactivites = act.initActivitesEleve(User1.IDU);
            TimeSpan matin = new TimeSpan(12,00,00);
            string demijourneenoninscrit = "";
            foreach(DateJoach d in lesdates)
            {
                int casdate = 0;
                bool estmatin = false;
                bool estaprem = false;
                if (d.Inscriteleve != true && d.Inscritprof != true)
                {
                    if (d.Matin == true)
                        casdate += 1;
                    if (d.Aprem == true)
                        casdate += 2;
                }
                foreach (Activite activite in lesactivites)
                {
                    if (activite.Heuredebut.ToShortDateString() == d.Dateevenement.ToShortDateString())
                    {
                        TimeSpan heure = activite.Heuredebut.TimeOfDay;
                        if (heure < matin)
                            estmatin = true;
                        else if (heure > matin)
                            estaprem = true;
                    }
                }
                switch (casdate)
                {
                    case 1:
                        if (estmatin != true)
                        {
                            ademijournee = false;
                            demijourneenoninscrit += "\n" + d.Dateevenement.ToLongDateString() + " - matin";
                            break;
                        }
                        else
                            break;
                    case 2:
                        if (estaprem != true)
                        {
                            ademijournee = false;
                            demijourneenoninscrit += "\n" + d.Dateevenement.ToLongDateString() + " - après-midi";
                            break;
                        }
                        else
                            break;
                    case 3:
                        if (estmatin != true || estaprem != true)
                        {
                            ademijournee = false;
                            if(estmatin != true)
                                demijourneenoninscrit += "\n" + d.Dateevenement.ToLongDateString() + " - matin";
                            if(estaprem != true)
                                demijourneenoninscrit += "\n" + d.Dateevenement.ToLongDateString() + " - après-midi";
                            break;
                        }
                        else
                            break;
                }
            }

            nbheureseleve = act.initTempsActivitesEleve(User1.IDU);
            if (ademijournee == true || eleve.Valide == true)
            {
                if (nbheureseleve.Hours >= 10 || eleve.Valide == true)
                {
                    ajoutDuneActivitéToolStripMenuItem.Enabled = false;
                    retirerUneActivitéToolStripMenuItem.Enabled = false;
                    Controleur.elevevalide();
                    VisualisationPDF Pdfeleve = new VisualisationPDF("listeactiviteselevei", User1.IDU);
                    fermerFormFille();
                    Pdfeleve.MdiParent = this;
                    Pdfeleve.Show();
                }
                else
                {
                    Controleur.Vmodele.charger_temps_eleve(User1.IDU);
                    MessageBox.Show("Il faut un minimum de 10 heures pour pouvoir valider son programme, vous avez : " + nbheureseleve.ToString() + " heure(s)", "Validation impossible");
                }
            }
            else
                MessageBox.Show("Vous n'avez pas une activité pour chaque demi-journée, voici les demi-journées où vous n'êtes pas inscrit : " + demijourneenoninscrit, "Validation impossible");
        }

        private void administrateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmin = new FormAdministrateur();
            fermerFormFille();
            FormAdmin.MdiParent = this;
            FormAdmin.Show();
        }

        private void générerLaListeDesActivitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualisationPDF FormVisualisationPDF = new VisualisationPDF("listeactiviteeleve");
            FormVisualisationPDF = new VisualisationPDF("listeactiviteprof");
            fermerFormFille();
            FormVisualisationPDF.MdiParent = this;
            FormVisualisationPDF.Show();
        }
    }
}


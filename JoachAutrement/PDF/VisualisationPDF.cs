using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using JoachAutrement.Intervenant;
using JoachAutrement.Eleve;


namespace JoachAutrement.Activités

{
    public partial class VisualisationPDF : Form
    {
        Activite activitechoisie = new Activite();
        List<Activite> lesActivites = new List<Activite>();
        DateJoach date = new DateJoach();

        Type type = new Type();
        List<Type> listeType = new List<Type>();
        
        List<DateJoach> lesDatesImport = new List<DateJoach>();
        List<DatePDF> lesDates = new List<DatePDF>();

        string chemin;
        bool afermer = false;
        public VisualisationPDF()
        {
            InitializeComponent();
        }
        public VisualisationPDF(string nomPDF,int id)
        {

            InitializeComponent();
            switch(nomPDF)
            {
                case "listeelevesactivite":
                    creelisteelevesactivite(id);
                    chemin = Properties.Settings.Default["savePDFLocal"] + "listeelevesactivite.pdf";
                    break;
                case "listeactiviteselevep": // Pdf sans impression
                    creerPDFactiviteseleve(id, true);
                    chemin = Properties.Settings.Default["savePDFLocal"] + "listeactiviteselevep.pdf";
                    break;
                case "listeactiviteselevei": // Pdf avec impression
                    creerPDFactiviteseleve(id, false);
                    chemin = Properties.Settings.Default["savePDFLocal"] + "listeactiviteselevei.pdf";
                    break;
                case "listeelevesclasse":
                    creerPDFlisteElevesClasse(id);
                    chemin = Properties.Settings.Default["savePDFLocal"] + "listeelevesclasse.pdf";
                    break;
                case default(string):
                    MessageBox.Show("Erreur lors du chargement du PDF");
                    break;

            }
        }
        public VisualisationPDF(string nomPDF)
        {
            InitializeComponent();
            switch (nomPDF)
            {
                case "listeactivitelecture":
                    chemin = Properties.Settings.Default["savePDFCommun"] + "listeactivitee.pdf";
                    break;
                case "listeactiviteimpression":
                    chemin = Properties.Settings.Default["savePDFCommun"] + "listeactivitep.pdf";
                    break;
                case "listeactiviteeleve":
                    creerPDFlisteactives(true); // PDF avec pas d'impression
                    chemin = Properties.Settings.Default["savePDFCommun"] + "listeactivitee.pdf";
                    break;
                case "listeactiviteprof":
                    creerPDFlisteactives(false); // PDF avec impression
                    chemin = Properties.Settings.Default["savePDFLocal"] + "listeactivitep.pdf";
                    break;
                case "listeintervenant":
                    creerPDFlistesintervenants();
                    chemin = Properties.Settings.Default["savePDFLocal"] + "listeintervenant.pdf";
                    break;
                case "listeEleveNonValide":
                    creerPDFlisteEleveNonValide();
                    chemin = Properties.Settings.Default["savePDFLocal"] + "listeEleveNonValide.pdf";
                    break;
                case "listeactivitessimplifiées":
                    creerPDFlisteactivitessimplifiées();
                    chemin = Properties.Settings.Default["savePDFLocal"] + "listeactivitessimplifées.pdf";
                    break;
                case default(string):
                    MessageBox.Show("Erreur", "Aucun fichier PDF choisi");
                    break;
            }
        }
        private void VisualisationPDF_Load(object sender, EventArgs e)
        {
                WBaffichagepdf.Navigate(chemin);
        }

        private void WBaffichagepdf_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (afermer == true)
                this.Close();
            else
            {
                chargementPDF.Style = ProgressBarStyle.Continuous;
                chargementPDF.MarqueeAnimationSpeed = 0;
                chargementPDF.Hide();
            }
        }
        #region Chargement données des élèves inscrits pour une activité
        private List<Utilisateur> initElevesinscritActivite(int idActivite)
        {
            List<Utilisateur> listeElevesInscritActivite = new List<Utilisateur>();
            try
            {
                Controleur.Vmodele.charger_eleve_activite_inscrits(idActivite);
                if (Controleur.Vmodele.DTeleveinscritactivite.Rows.Count > 0)
                {
                    for (int i = 0; i < Controleur.Vmodele.DTeleveinscritactivite.Rows.Count; i++) // Création d'une liste d'eleve en fonction de l'activité choisi 
                    {
                        int idE = Convert.ToInt32(Controleur.Vmodele.DTeleveinscritactivite.Rows[i]["IDU"]);
                        string nomE = Controleur.Vmodele.DTeleveinscritactivite.Rows[i]["NOMU"].ToString();
                        string prenomE = Controleur.Vmodele.DTeleveinscritactivite.Rows[i]["PRENOMU"].ToString();
                        string classe = Controleur.Vmodele.DTeleveinscritactivite.Rows[i]["LIBELLEC"].ToString();
                        Utilisateur eleve = new Utilisateur(idE, nomE, prenomE, classe);
                        listeElevesInscritActivite.Add(eleve);
                    }
                    string libellea = Controleur.Vmodele.DTeleveinscritactivite.Rows[0]["LIBELLEA"].ToString();
                    DateTime heureDebutA = Convert.ToDateTime((Controleur.Vmodele.DTeleveinscritactivite.Rows[0]["HEUREDEBUTA"]).ToString());
                    DateTime heureFinA = Convert.ToDateTime((Controleur.Vmodele.DTeleveinscritactivite.Rows[0]["HEUREFINA"]).ToString());
                    int nbplace = Convert.ToInt32(Controleur.Vmodele.DTeleveinscritactivite.Rows[0]["NBPLACEA"]);
                    string codeA = Controleur.Vmodele.DTeleveinscritactivite.Rows[0]["CODEA"].ToString();
                    string salle = Controleur.Vmodele.DTeleveinscritactivite.Rows[0]["SALLE"].ToString();
                    activitechoisie = new Activite(libellea, heureDebutA, heureFinA, nbplace, codeA, salle);
                }
            }
            catch (Exception err)// gestion des erreurs
            {
                MessageBox.Show("Erreur récupération données : " + err, "PBS connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listeElevesInscritActivite;
        }
        #endregion

        #region Création du PDF pour la liste des activités
        private void creerPDFlisteactives(bool estprotect)
        {
            
            int i = 0;
            lesActivites = activitechoisie.InitActivite();
            listeType = type.InitType();
            recupDates();

            try
            {
                string nompdf = Properties.Settings.Default["savePDFCommun"].ToString(); // Récupère le chemin
                Document doc = new Document();
                if (estprotect == true)
                    nompdf += "listeactivitee.pdf";
                else
                    nompdf += "listeactivitep.pdf";
                PdfWriter listeActPDF = PdfWriter.GetInstance(doc, new FileStream(nompdf, FileMode.Create, FileAccess.Write));
                if (estprotect == true)
                {
                    System.Text.UTF8Encoding enconding = new System.Text.UTF8Encoding(); // Création du norme d'encodage
                    listeActPDF.SetEncryption(null, enconding.GetBytes("123456789"), PdfWriter.AllowScreenReaders, PdfWriter.STRENGTH128BITS); // Encryptage du fichier PDF qui autorise seulement la lecture de celui-ci
                }
                doc.Open();
                Paragraph paragraph = new Paragraph();
                Phrase titre = new Phrase("Listes des activités de Joach Autrement", FontFactory.GetFont(FontFactory.COURIER, 20));
                paragraph.Alignment = Element.ALIGN_CENTER;
                paragraph.SpacingAfter = 15;
                paragraph.Add(titre);
                doc.Add(paragraph);

                lesDates = lesDates.OrderBy(x => x.Date).ToList();
                foreach (DatePDF d in lesDates)
                {
                    d.LesActivites = d.LesActivites.OrderBy(x => x.IdType).ThenBy(x => x.Heuredebut).ToList();

                    foreach (Type untype in listeType)
                    {
                        Paragraph p = new Paragraph();
                        Phrase t = new Phrase(d.Date.ToLongDateString().ToUpper() + " " + d.Libelle + "\n" + untype.Libelle, FontFactory.GetFont(FontFactory.COURIER, 20));
                        p.Add(t);
                        p.Alignment = Element.ALIGN_CENTER;
                        p.SpacingAfter = 15;
                        doc.NewPage();
                        doc.Add(p);

                        foreach (Activite act in d.LesActivites)
                        {
                            if (act.IdType == untype.Id)
                            {
                                i++;
                                iTextSharp.text.Font gras = new iTextSharp.text.Font();
                                string typeecriture = "bold";
                                gras.SetStyle(typeecriture);
                                iTextSharp.text.Font italique = new iTextSharp.text.Font();
                                typeecriture = "italic";
                                italique.SetStyle(typeecriture);
                                PdfPTable tableactivite = new PdfPTable(2); //Table regroupant toutes les autres tables pour les infos de cette activité
                                float[] taillecolonnetableactivite = { 30, 70 };
                                tableactivite.SetWidths(taillecolonnetableactivite);
                                tableactivite.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                                tableactivite.DefaultCell.BorderWidthTop = 2;
                                tableactivite.DefaultCell.BorderWidthBottom = 2;
                                PdfPTable tablecodeheure = new PdfPTable(1);
                                PdfPTable Colonnedroite = new PdfPTable(1);
                                Colonnedroite.DefaultCell.BorderWidthTop = iTextSharp.text.Rectangle.NO_BORDER;
                                Colonnedroite.DefaultCell.BorderWidthRight = iTextSharp.text.Rectangle.NO_BORDER;
                                Colonnedroite.DefaultCell.BorderWidthBottom = iTextSharp.text.Rectangle.NO_BORDER;
                                PdfPTable tablelibelledescription = new PdfPTable(1);
                                PdfPTable tableinfodivers = new PdfPTable(3);
                                PdfPCell infoCode = new PdfPCell();
                                Phrase infocode = new Phrase(act.Code, gras);
                                infoCode.BorderWidth = PdfPCell.NO_BORDER;
                                infoCode.AddElement(infocode);
                                Phrase infoheures = new Phrase(act.Heuredebut.ToShortTimeString() + " - " + act.Heurefin.ToShortTimeString());
                                infoCode.AddElement(infoheures);
                                tablecodeheure.AddCell(infoCode);
                                tableactivite.AddCell(tablecodeheure);
                                PdfPCell infolibelledescri = new PdfPCell();
                                Phrase infolibelle = new Phrase(act.Libelle, gras);
                                infolibelledescri.BorderWidth = PdfPCell.NO_BORDER;
                                infolibelledescri.AddElement(infolibelle);
                                Phrase infoentetelibelledescri = new Phrase(act.EnteteDescription, FontFactory.GetFont(BaseFont.TIMES_ITALIC));
                                infolibelledescri.AddElement(infoentetelibelledescri);
                                Phrase infodescription = new Phrase(act.Description);
                                infolibelledescri.AddElement(infodescription);
                                tablelibelledescription.AddCell(infolibelledescri);
                                Colonnedroite.AddCell(tablelibelledescription);
                                PdfPCell prerequisclasse = new PdfPCell(new Phrase(act.Restriction));
                                prerequisclasse.BorderWidth = PdfPCell.NO_BORDER;
                                tableinfodivers.AddCell(prerequisclasse);
                                PdfPCell infoNombreeleve = new PdfPCell();
                                Paragraph infonombreelevep = new Paragraph(new Phrase(act.Nombreplaces + " élèves"));
                                infoNombreeleve.BorderWidth = PdfPCell.NO_BORDER;
                                infonombreelevep.Alignment = Element.ALIGN_CENTER;
                                infoNombreeleve.AddElement(infonombreelevep);
                                tableinfodivers.AddCell(infoNombreeleve);
                                PdfPCell infoSalle = new PdfPCell();
                                Paragraph infosallep = new Paragraph(new Phrase(act.Salle));
                                infoSalle.BorderWidth = PdfPCell.NO_BORDER;
                                infosallep.Alignment = Element.ALIGN_CENTER;
                                infoSalle.AddElement(infosallep);
                                tableinfodivers.AddCell(infoSalle);
                                Colonnedroite.AddCell(tableinfodivers);
                                tableactivite.AddCell(Colonnedroite);
                                doc.Add(tableactivite);
                            }
                        }
                    }
                }
                doc.Close();
            }
            catch (System.IO.IOException err)// gestion des erreurs
            {
                MessageBox.Show("Erreur pdf: " + err, "Problème connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void recupDates()
        {
            List<Activite> listeActivites;
            int i = 1;
            lesDatesImport = date.initDateJoach();
            foreach (DateJoach d in lesDatesImport)
            {
                if (d.Inscriteleve == false && d.Inscritprof == false)
                {
                    if (d.Matin == true)
                    {
                        listeActivites = new List<Activite>();
                        foreach (Activite a in lesActivites)
                        {
                            if (a.Heuredebut.Hour < 12 && d.Dateevenement.ToShortDateString() == a.Heuredebut.ToShortDateString())
                            {
                                listeActivites.Add(a);
                            }
                        }
                        lesDates.Add(new DatePDF(i, d.Dateevenement, "Matin", listeActivites));
                        i++;
                    }
                    if (d.Aprem == true)
                    {
                        listeActivites = new List<Activite>();
                        foreach (Activite a in lesActivites)
                        {
                            if (a.Heuredebut.Hour > 12 && d.Dateevenement.ToShortDateString() == a.Heuredebut.ToShortDateString())
                            {
                                listeActivites.Add(a);
                            }
                        }
                        lesDates.Add(new DatePDF(i, d.Dateevenement, "Après midi", listeActivites));
                        i++;
                    }
                }
            }
        }
        #endregion
        #region Création du PDF des élèves inscrits pour une activité
        private void creelisteelevesactivite(int idactivite)
        {
            List<Utilisateur> lesEleves = initElevesinscritActivite(idactivite);
            try
            {
                if (lesEleves.Count() > 0)
                {
                    Header header = new Header("header", "Code de l'activité : " + activitechoisie.Code);
                    Document doc = new Document();
                    PdfWriter listeActPDF = PdfWriter.GetInstance(doc, new FileStream(Properties.Settings.Default["savePDFLocal"] + "listeelevesactivite.pdf", FileMode.Create, FileAccess.Write));
                    doc.Open();
                    Paragraph paragraph = new Paragraph();
                    Phrase titre = new Phrase("Listes des élèves" , FontFactory.GetFont(FontFactory.COURIER, 20));
                    paragraph.Add(titre);
                    paragraph.Alignment = Element.ALIGN_CENTER;
                    doc.Add(paragraph);


                    PdfPTable libelle = new PdfPTable(1);
                    PdfPCell act1 = new PdfPCell(new Phrase("  "));
                    PdfPCell act2 = new PdfPCell(new Phrase("" + activitechoisie.Code + " - " + activitechoisie.Libelle));
                    act1.BorderWidth = 0;
                    act2.BorderWidth = 0;
                    libelle.AddCell(act1);
                    libelle.AddCell(act2);
                    doc.Add(libelle);

                    PdfPTable stats = new PdfPTable(2);
                    act1 = new PdfPCell(new Phrase("Date : " + activitechoisie.Heuredebut.ToLongDateString().ToString()));
                    act2 = new PdfPCell(new Phrase("Heure de début : " + activitechoisie.Heuredebut.ToShortTimeString().ToString()));
                    act1.BorderWidth = 0;
                    act2.BorderWidth = 0;
                    stats.AddCell(act1);
                    stats.AddCell(act2);

                    act1 = new PdfPCell(new Phrase("Salle : " + activitechoisie.Salle));
                    act2 = new PdfPCell(new Phrase("Heure de Fin : " + activitechoisie.Heurefin.ToShortTimeString().ToString()));
                    act1.BorderWidth = 0;
                    act2.BorderWidth = 0;
                    stats.AddCell(act1);
                    stats.AddCell(act2);

                    act1 = new PdfPCell(new Phrase("Nombre de places : " + activitechoisie.Nombreplaces));
                    act2 = new PdfPCell(new Phrase("Nombre d'inscrits : " + lesEleves.Count));
                    act1.BorderWidth = 0;
                    act2.BorderWidth = 0;
                    stats.AddCell(act1);
                    stats.AddCell(act2);

                    
                    doc.Add(stats);

                    Paragraph p = new Paragraph();
                    Phrase espace = new Phrase("Bravo vous avez trouvé une ligne cachée", FontFactory.GetFont(FontFactory.COURIER, 20, BaseColor.WHITE));
                    p.Add(espace);
                    doc.Add(p);

                    PdfPTable listeEleve = new PdfPTable(3);

                    PdfPCell nomeleve = new PdfPCell(new Phrase("Nom"));
                    PdfPCell prenomeleve = new PdfPCell(new Phrase("Prenom"));
                    PdfPCell classeeleve = new PdfPCell(new Phrase("Classe"));
                    listeEleve.AddCell(nomeleve);
                    listeEleve.AddCell(prenomeleve);
                    listeEleve.AddCell(classeeleve);

                    foreach (Utilisateur eleve in lesEleves) // Ajoute les élèves inscrits au tableau de l'activité
                    {
                        nomeleve = new PdfPCell(new Phrase(eleve.NomU));
                        prenomeleve = new PdfPCell(new Phrase(eleve.PrenomU));
                        classeeleve = new PdfPCell(new Phrase(eleve.Classe));
                        listeEleve.AddCell(nomeleve);
                        listeEleve.AddCell(prenomeleve);
                        listeEleve.AddCell(classeeleve);
                    }
                    doc.Add(listeEleve);
                    doc.Close();
                }
                else
                {
                    MessageBox.Show("Aucun élève dans l'activité sélectionnée","Erreur", MessageBoxButtons.OK);
                    afermer = true;
                }
            }
            catch (System.IO.IOException err)// gestion des erreurs
            {
                MessageBox.Show("Erreur pdf: " + err, "PBS connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Création du PDF pour la liste des intervenants
        private void creerPDFlistesintervenants()
        {
            ClassIntervenant lintervenant = new ClassIntervenant();
            Dictionary<int,ClassIntervenant> lesIntervenants = lintervenant.InitIntervenantdateheure();
            try
            {
                Document doc = new Document();
                PdfWriter listeIntPDF = PdfWriter.GetInstance(doc, new FileStream(Properties.Settings.Default["savePDFLocal"] + "listeintervenant.pdf", FileMode.Create, FileAccess.Write));
                doc.Open();
                Paragraph paragraph = new Paragraph();
                Phrase titre = new Phrase("Listes des intervenants de Joach Autrement", FontFactory.GetFont(FontFactory.COURIER, 20));
                paragraph.Add(titre);
                doc.Add(paragraph);

                /*
                Paragraph p = new Paragraph();
                Phrase espace = new Phrase("Bravo vous avez trouvé une ligne cachée", FontFactory.GetFont(FontFactory.COURIER, 20, BaseColor.WHITE));
                p.Add(espace);
                doc.Add(p);
                 * */
                
                PdfPTable tableauintervenant = new PdfPTable(6);
                tableauintervenant.HorizontalAlignment = 0;
                tableauintervenant.TotalWidth = 500f;
                tableauintervenant.LockedWidth = true;
                float[] widths = new float[] { 80f, 80f, 100f, 80f, 40f, 40f };
                tableauintervenant.SetWidths(widths);
                tableauintervenant.SpacingBefore = 15;

                foreach (KeyValuePair<int,ClassIntervenant> inter in lesIntervenants)
                {
                    PdfPCell infoNom = new PdfPCell(new Phrase(inter.Value.Nom));
                    infoNom.BorderWidth = 0;
                    infoNom.BorderWidthTop = 1;
                    PdfPCell infoPrenom = new PdfPCell(new Phrase(inter.Value.Prenom));
                    infoPrenom.BorderWidth = 0;
                    infoPrenom.BorderWidthTop = 1;
                    PdfPCell infoprofession = new PdfPCell(new Phrase(inter.Value.Profession));
                    infoprofession.BorderWidth = 0;
                    infoprofession.BorderWidthTop = 1;
                    tableauintervenant.AddCell(infoNom);
                    tableauintervenant.AddCell(infoPrenom);
                    tableauintervenant.AddCell(infoprofession);
                    PdfPCell infodate = new PdfPCell(new Phrase(inter.Value.Heuredebut[0].ToShortDateString()));
                    infodate.BorderWidth = 0;
                    infodate.BorderWidthTop = 1;
                    PdfPCell infoheuredebut = new PdfPCell(new Phrase(inter.Value.Heuredebut[0].ToShortTimeString()));
                    infoheuredebut.BorderWidth = 0;
                    infoheuredebut.BorderWidthTop = 1;
                    PdfPCell infoheurefin = new PdfPCell(new Phrase(inter.Value.Heurefin[0].ToShortTimeString()));
                    infoheurefin.BorderWidth = 0;
                    infoheurefin.BorderWidthTop = 1;
                    tableauintervenant.AddCell(infodate);
                    tableauintervenant.AddCell(infoheuredebut);
                    tableauintervenant.AddCell(infoheurefin);
                    if (inter.Value.Heuredebut.Count > 1)
                    {
                        for (int i = 1; i < inter.Value.Heuredebut.Count; i++)
                        {
                            PdfPCell trou1 = new PdfPCell(); //Permet de faire la mise en page pour afficher les heures supplémentaires en dessous des autres
                            trou1.BorderWidth = 0;
                            PdfPCell trou2 = new PdfPCell();
                            trou2.BorderWidth = 0;
                            PdfPCell trou3 = new PdfPCell();
                            trou3.BorderWidth = 0;
                            PdfPCell infoextradate = new PdfPCell(new Phrase(inter.Value.Heuredebut[i].ToShortDateString()));
                            infoextradate.BorderWidth = 0;
                            PdfPCell infoextraheuredebut = new PdfPCell(new Phrase(inter.Value.Heuredebut[i].ToShortTimeString()));
                            infoextraheuredebut.BorderWidth = 0;
                            PdfPCell infoextraheurefin = new PdfPCell(new Phrase(inter.Value.Heurefin[i].ToShortTimeString()));
                            infoextraheurefin.BorderWidth = 0;
                            tableauintervenant.AddCell(trou1);
                            tableauintervenant.AddCell(trou2);
                            tableauintervenant.AddCell(trou3);
                            tableauintervenant.AddCell(infoextradate);
                            tableauintervenant.AddCell(infoextraheuredebut);
                            tableauintervenant.AddCell(infoextraheurefin);
                        }
                    }
                }
                doc.Add(tableauintervenant);
                doc.Close();
            }
            catch (System.IO.IOException err)// gestion des erreurs
            {
                MessageBox.Show("Erreur pdf: " + err, "PBS connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Création du PDF des activites auquelle est inscrit un élève
        private void creerPDFactiviteseleve(int ideleve, bool protect)
        {
            lesActivites = activitechoisie.initActivitesEleve(ideleve);
            lesActivites = lesActivites.OrderBy(o => o.Heuredebut.DayOfYear).ThenBy(x => x.Heuredebut.TimeOfDay).ToList();
            string nompdf;
            if (protect == true)
                nompdf = "listeactiviteselevep";
            else
                nompdf = "listeactiviteselevei";
            if (Controleur.Vmodele.DTactiviteseleve.Rows.Count > 0)
            {
                string nom = Controleur.Vmodele.DTactiviteseleve.Rows[0][0].ToString();
                string prenom = Controleur.Vmodele.DTactiviteseleve.Rows[0][1].ToString();
                try
                {
                    Document doc = new Document();
                    PdfWriter listeactiviteseleve = PdfWriter.GetInstance(doc, new FileStream(Properties.Settings.Default["savePDFLocal"] + nompdf + ".pdf", FileMode.Create, FileAccess.Write));
                    if (protect == true)
                    {
                        System.Text.UTF8Encoding enconding = new System.Text.UTF8Encoding(); // Création du norme d'encodage
                        listeactiviteseleve.SetEncryption(null, enconding.GetBytes("123456789"), PdfWriter.AllowScreenReaders, PdfWriter.STRENGTH128BITS); // Encryptage du fichier PDF qui autorise seulement la lecture de celui-ci
                    }
                    doc.Open();
                    Paragraph paragraph = new Paragraph();
                    paragraph.Alignment = Element.ALIGN_CENTER;
                    Phrase titre = new Phrase("Programme Joach'Autrement", FontFactory.GetFont(FontFactory.COURIER, 20));
                    Phrase eleve = new Phrase("\n" + nom + " " + prenom);
                    paragraph.Add(titre);
                    paragraph.Add(eleve);
                    doc.Add(paragraph);

                    Paragraph activite = new Paragraph();

                    PdfPTable stats = new PdfPTable(2);
                    stats.HorizontalAlignment = 0;
                    stats.TotalWidth = 500f;
                    stats.LockedWidth = true;
                    float[] widths = new float[] { 170f, 330f };
                    stats.SetWidths(widths);
                    stats.SpacingBefore = 15;

                    foreach (Activite act in lesActivites)
                    {
                        PdfPCell act1 = new PdfPCell(new Phrase("" + act.Heuredebut.ToLongDateString().ToString()));
                        PdfPCell act2 = new PdfPCell(new Phrase(act.Code));
                        act1.BorderWidth = 0;
                        act1.BorderWidthTop = 1;
                        act2.BorderWidth = 0;
                        act2.BorderWidthTop = 1;
                        stats.AddCell(act1);
                        stats.AddCell(act2);

                        act1 = new PdfPCell(new Phrase("   Heure de début : " + act.Heuredebut.ToShortTimeString().ToString()));
                        act2 = new PdfPCell(new Phrase(act.Libelle));
                        act1.BorderWidth = 0;
                        act2.BorderWidth = 0;
                        stats.AddCell(act1);
                        stats.AddCell(act2);

                        act1 = new PdfPCell(new Phrase("   Heure de fin : " + act.Heurefin.ToShortTimeString().ToString()));
                        act2 = new PdfPCell(new Phrase("Salle : " + act.Salle));
                        act1.BorderWidth = 0;
                        act2.BorderWidth = 0;
                        stats.AddCell(act1);
                        stats.AddCell(act2);

                        act1 = new PdfPCell(new Phrase(" "));
                        act2 = new PdfPCell(new Phrase(" "));
                        act1.BorderWidth = 0;
                        act2.BorderWidth = 0;
                        
                        stats.AddCell(act1);
                        stats.AddCell(act2); 
                    }
                    activite.Add(stats);
                        doc.Add(activite);
                    doc.Close();
                }

                catch (System.IO.IOException err)// gestion des erreurs
                {
                    MessageBox.Show("Erreur pdf: " + err, "PBS connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Aucune activité pour l'élève sélectionné", "Erreur", MessageBoxButtons.OK);
                afermer = true;
            }
        }
        #endregion
        #region Creation du PDF pour les eleves n'ayant pas valide leur programme 
        private void creerPDFlisteEleveNonValide()
        {
            Utilisateur users = new Utilisateur();
            Classe uneClasse = new Classe();
            List<Classe> lesclasses = uneClasse.InitClasse();
            List<Utilisateur> lesEleves = new List<Utilisateur>();
            lesEleves = users.InitElevesnonvalides();
            try
            {
                Document doc = new Document();
                PdfWriter listeActPDF = PdfWriter.GetInstance(doc, new FileStream(Properties.Settings.Default["savePDFLocal"] + "listeEleveNonValide.pdf", FileMode.Create, FileAccess.Write));
                doc.Open();
                Paragraph paragraph = new Paragraph();
                Phrase titre = new Phrase("Listes des élèves non Validés", FontFactory.GetFont(FontFactory.COURIER, 20));
                paragraph.Alignment = Element.ALIGN_CENTER;
                paragraph.Add(titre);
                Paragraph info = new Paragraph();
                Phrase libelle = new Phrase();
                info.Add(libelle);
                doc.Add(paragraph);
                doc.Add(info);
                PdfPTable listeEleve = new PdfPTable(3);
                listeEleve.SpacingBefore = 15;
                
                foreach (Utilisateur e in lesEleves) // Ajoute les élèves inscrits au tableau de l'activité
                {
                    if (e.Valide == false)
                    {
                        PdfPCell nomeleve = new PdfPCell(new Phrase(e.NomU));
                        PdfPCell prenomeleve = new PdfPCell(new Phrase(e.PrenomU));
                        PdfPCell classeeleve = new PdfPCell();
                        foreach (Classe c in lesclasses)
                        {
                            if (c.Id == e.IDC)
                            {
                                classeeleve.AddElement(new Phrase(c.Libelle));
                            }
                        }
                        listeEleve.AddCell(nomeleve);
                        listeEleve.AddCell(prenomeleve);
                        listeEleve.AddCell(classeeleve);
                    }
                }
                doc.Add(listeEleve);
                doc.Close();
            }
            catch (System.IO.IOException err)// gestion des erreurs
            {
                MessageBox.Show("Erreur pdf: " + err, "PBS connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Creation du PDF pour les eleves selon leur classe
        private void creerPDFlisteElevesClasse(int idclasse)
        {
            Utilisateur users = new Utilisateur();
            List<Utilisateur> lesEleves = new List<Utilisateur>();
            lesEleves = users.InitElevesclasse(idclasse);
            Classe laclasse = new Classe();
            laclasse.InitClasse();
            try
            {
                Document doc = new Document();
                PdfWriter listeActPDF = PdfWriter.GetInstance(doc, new FileStream(Properties.Settings.Default["savePDFLocal"] + "listeelevesclasse.pdf", FileMode.Create, FileAccess.Write));
                doc.Open();
                Phrase titre = new Phrase("Listes des élèves, " + laclasse.getLibelleClasse(idclasse), FontFactory.GetFont(FontFactory.COURIER, 20));
                Paragraph paratitre = new Paragraph();
                paratitre.Add(titre);
                paratitre.Alignment = Element.ALIGN_CENTER;
                Paragraph paragraph = new Paragraph();
                Paragraph info = new Paragraph();
                Phrase libelle = new Phrase();
                info.Add(libelle);
                doc.Add(paratitre);
                doc.Add(paragraph);
                doc.Add(info);
                PdfPTable listeEleve = new PdfPTable(4);
                listeEleve.SpacingBefore = 15;
                PdfPCell colonnenom = new PdfPCell(new Phrase("Nom",FontFactory.GetFont(FontFactory.COURIER_BOLD)));
                PdfPCell colonneprenom = new PdfPCell(new Phrase("Prénom",FontFactory.GetFont(FontFactory.COURIER_BOLD)));
                PdfPCell colonnetemps = new PdfPCell(new Phrase("Temps total",FontFactory.GetFont(FontFactory.COURIER_BOLD)));
                PdfPCell colonnevalide = new PdfPCell(new Phrase("Validé",FontFactory.GetFont(FontFactory.COURIER_BOLD)));
                listeEleve.AddCell(colonnenom);
                listeEleve.AddCell(colonneprenom);
                listeEleve.AddCell(colonnetemps);
                listeEleve.AddCell(colonnevalide);
                foreach (Utilisateur user in lesEleves) // Ajoute les élèves inscrits au tableau de l'activité
                {
                    PdfPCell nomeleve = new PdfPCell(new Phrase(user.NomU));
                    PdfPCell prenomeleve = new PdfPCell(new Phrase(user.PrenomU));
                    PdfPCell tempseleve = new PdfPCell(new Phrase(user.Tempsactivite.ToString()));
                    string valide = "";
                    if (user.Valide == false)
                        valide = "Non";
                    else
                        valide = "Oui";
                    PdfPCell valideeleve = new PdfPCell(new Phrase(valide));
                    listeEleve.AddCell(nomeleve);
                    listeEleve.AddCell(prenomeleve);
                    listeEleve.AddCell(tempseleve);
                    listeEleve.AddCell(valideeleve);
                }
                doc.Add(listeEleve);
                doc.Close();
            }
            catch (System.IO.IOException err)// gestion des erreurs
            {
                MessageBox.Show("Erreur pdf: " + err, "PBS connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Création du PDF pour la liste simplifée des activités
        private void creerPDFlisteactivitessimplifiées()
        {
            Activite act = new Activite();
            List<Activite> lesActivites = act.initActiviteSansDescription();
            Type letype = new Type();
            List<Type> lesTypes = letype.InitType();
            try
            {
                Document doc = new Document();
                doc.SetPageSize(PageSize.A4.Rotate());
                PdfWriter listeIntPDF = PdfWriter.GetInstance(doc, new FileStream(Properties.Settings.Default["savePDFLocal"] + "listeactivitessimplifées.pdf", FileMode.Create, FileAccess.Write));
                doc.Open();
                Paragraph paragraph = new Paragraph();
                Phrase titre = new Phrase("Listes des activités de JoachAutrement", FontFactory.GetFont(FontFactory.COURIER, 20));
                paragraph.Add(titre);
                paragraph.Alignment = Element.ALIGN_CENTER;
                doc.Add(paragraph);
                PdfPTable tableauactivites = new PdfPTable(9);
                tableauactivites.HorizontalAlignment = 0;
                tableauactivites.TotalWidth = 700f;
                tableauactivites.LockedWidth = true;
                float[] widths = new float[] { 230f, 50f, 80f, 80f, 60f, 60f, 50f, 50f, 80f };
                tableauactivites.SetWidths(widths);
                tableauactivites.SpacingBefore = 15;


                PdfPCell infoLibelle = new PdfPCell(new Phrase("Titre", FontFactory.GetFont(FontFactory.COURIER, 12)));
                PdfPCell infoCode = new PdfPCell(new Phrase("Code", FontFactory.GetFont(FontFactory.COURIER, 12)));
                PdfPCell infoDate = new PdfPCell(new Phrase("Date", FontFactory.GetFont(FontFactory.COURIER, 12)));
                PdfPCell infoHeuredebut = new PdfPCell(new Phrase("Debut", FontFactory.GetFont(FontFactory.COURIER, 12)));
                PdfPCell infoHeurefin = new PdfPCell(new Phrase("Fin", FontFactory.GetFont(FontFactory.COURIER, 12)));
                PdfPCell infoNbPlaces = new PdfPCell(new Phrase("Places", FontFactory.GetFont(FontFactory.COURIER, 12)));
                PdfPCell infoSalle = new PdfPCell(new Phrase("Salle", FontFactory.GetFont(FontFactory.COURIER, 12)));
                PdfPCell infoLibelleType = new PdfPCell(new Phrase("Type", FontFactory.GetFont(FontFactory.COURIER, 12)));
                PdfPCell infoPlaceRestant = new PdfPCell(new Phrase("Places Libres", FontFactory.GetFont(FontFactory.COURIER, 12)));

                tableauactivites.AddCell(infoLibelle);
                tableauactivites.AddCell(infoCode);
                tableauactivites.AddCell(infoLibelleType);
                tableauactivites.AddCell(infoDate);
                tableauactivites.AddCell(infoHeuredebut);
                tableauactivites.AddCell(infoHeurefin);
                tableauactivites.AddCell(infoNbPlaces);
                tableauactivites.AddCell(infoPlaceRestant);
                tableauactivites.AddCell(infoSalle);
                


                foreach (Activite activite in lesActivites)
                {
                    Controleur.Vmodele.charger_nbinscrit_activite(activite.Id);
                    
                    infoLibelle = new PdfPCell(new Phrase(activite.Libelle));
                    infoCode = new PdfPCell(new Phrase(activite.Code));
                    infoDate = new PdfPCell(new Phrase(activite.Heuredebut.ToShortDateString()));
                    infoHeuredebut = new PdfPCell(new Phrase(activite.Heuredebut.ToShortTimeString()));
                    infoHeurefin = new PdfPCell(new Phrase(activite.Heurefin.ToShortTimeString()));
                    infoNbPlaces = new PdfPCell(new Phrase(activite.Nombreplaces.ToString()));
                    infoPlaceRestant = new PdfPCell(new Phrase((activite.Nombreplaces - Convert.ToInt32(Controleur.Vmodele.DTnbinscritactivite.Rows[0][0])).ToString()));
                    infoSalle = new PdfPCell();
                    if (activite.Salle != null)
                    {
                        infoSalle = new PdfPCell(new Phrase(activite.Salle));
                    }
                    infoLibelleType = new PdfPCell();
                    foreach(Type t in lesTypes)
                    {
                        if (t.Id == activite.IdType)
                            infoLibelleType = new PdfPCell(new Phrase(t.Libelle));
                    }

                    tableauactivites.AddCell(infoLibelle);
                    tableauactivites.AddCell(infoCode);
                    tableauactivites.AddCell(infoLibelleType);
                    tableauactivites.AddCell(infoDate);
                    tableauactivites.AddCell(infoHeuredebut);
                    tableauactivites.AddCell(infoHeurefin);
                    tableauactivites.AddCell(infoNbPlaces);
                    tableauactivites.AddCell(infoPlaceRestant);
                    tableauactivites.AddCell(infoSalle);
                    
                }
                doc.Add(tableauactivites);
                doc.Close();
            }
            catch (System.IO.IOException err)// gestion des erreurs
            {
                MessageBox.Show("Erreur pdf: " + err, "PBS connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoachAutrement.Activités
{
    public class Activite
    {
        int id;
        int idType;
        int idDate;
        string code;
        string libelle;
        string description;
        DateTime heureDebut;
        DateTime heureFin;
        DateTime date;
        int nbrPlaces;
        string salle;
        string enteteDescription;
        string restriction;
        List<Activite> lesActivites;
        public List<Activite> testNbrAct;
        

        #region accesseur
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int IdType
        {
            get { return idType; }
            set { idType = value; }
        }
        public int IdDate
        {
            get { return idDate; }
            set { idDate = value; }
        }
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public DateTime Heuredebut
        {
            get { return heureDebut; }
            set { heureDebut = value; }
        }
        public DateTime Heurefin
        {
            get { return heureFin; }
            set { heureFin = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public int Nombreplaces
        {
            get { return nbrPlaces; }
            set { nbrPlaces = value; }
        }
        public string Salle
        {
            get { return salle; }
            set { salle = value; }
        }
        public string EnteteDescription
        {
            get { return enteteDescription; }
            set { enteteDescription = value; }
        }
        public string Restriction
        {
            get { return restriction; }
            set { restriction = value; }
        }

        #endregion

        public Activite()
        {
            // constructeur vide
        }
        public Activite(int id, int idType, string code, string libelle, string description, DateTime heureDebut, DateTime heureFin, int nbrPlaces, string salle, string entetedescription, string restriction)
        {
            this.id = id;
            this.idType = idType;
            this.code = code;
            this.libelle = libelle;
            this.description = description;
            this.heureDebut = heureDebut;
            this.heureFin = heureFin;
            this.nbrPlaces = nbrPlaces;
            this.salle = salle;
            this.enteteDescription = entetedescription;
            this.restriction = restriction;
        }
        public Activite(int id, int idType, string libelle, string description, DateTime heureDebut, DateTime heureFin, int nbrPlaces, string salle, string code)
        {
            this.id = id;
            this.idType = idType;
            this.code = code;
            this.libelle = libelle;
            this.description = description;
            this.heureDebut = heureDebut;
            this.heureFin = heureFin;
            this.nbrPlaces = nbrPlaces;
            this.salle = salle;

        }
        public Activite(int id, int idType, string libelle, string code, DateTime heureDebut, DateTime heureFin,int nbplace, string salle)
        {
            this.id = id;
            this.idType = idType;
            this.libelle = libelle;
            this.code = code;
            this.heureDebut = heureDebut;
            this.heureFin = heureFin;
            this.nbrPlaces = nbplace;
            this.salle = salle;
        }
        public Activite(int idType, string libelle, string code, DateTime heureDebut, DateTime heureFin,int nbplace, string salle)
        {
            this.idType = idType;
            this.libelle = libelle;
            this.code = code;
            this.heureDebut = heureDebut;
            this.heureFin = heureFin;
            this.nbrPlaces = nbplace;
            this.salle = salle;
        }
        public Activite(int id, string libelle, string code, DateTime heureDebut, DateTime heureFin, string salle)
        {
            this.id = id;
            this.libelle = libelle;
            this.code = code;
            this.heureDebut = heureDebut;
            this.heureFin = heureFin;
            this.salle = salle;
        }
        public Activite(string libelle, DateTime heureDebut, DateTime heureFin, int nbrPlaces, string codeA, string salle)
        {
            this.libelle = libelle;
            this.heureDebut = heureDebut;
            this.heureFin = heureFin;
            this.nbrPlaces = nbrPlaces;
            this.code = codeA;
            this.salle = salle;
        }
        public Activite(string libelle, string code, DateTime heureDebut, DateTime heureFin, string salle)
        {
            this.libelle = libelle;
            this.code = code;
            this.heureDebut = heureDebut;
            this.heureFin = heureFin;
            this.salle = salle;

        }
        public Activite(int id,DateTime heureDebut, DateTime heureFin)
        {
            this.id = id;
            this.heureDebut = heureDebut;
            this.heureFin = heureFin;
        }
        public List<Activite> InitActivite()
        {
            lesActivites = new List<Activite>();
            lesActivites.Clear();

            Controleur.Vmodele.charger_activites();
            for (int i = 0; i < Controleur.Vmodele.DTactivites.Rows.Count; i++)
            {
                int ida = Convert.ToInt32(Controleur.Vmodele.DTactivites.Rows[i][0]);
                int idt = Convert.ToInt32(Controleur.Vmodele.DTactivites.Rows[i][1]);
                string codea = Controleur.Vmodele.DTactivites.Rows[i][2].ToString();
                string libellea = Controleur.Vmodele.DTactivites.Rows[i][3].ToString();
                string descri = Controleur.Vmodele.DTactivites.Rows[i][4].ToString();
                DateTime heureDebuta = Convert.ToDateTime((Controleur.Vmodele.DTactivites.Rows[i][5]).ToString());
                DateTime heureFina = Convert.ToDateTime((Controleur.Vmodele.DTactivites.Rows[i][6]).ToString());
                int nbrPlacesa = Convert.ToInt32(Controleur.Vmodele.DTactivites.Rows[i][7]);
                string sallea = Controleur.Vmodele.DTactivites.Rows[i][8].ToString();
                string entetedescri = Controleur.Vmodele.DTactivites.Rows[i][9].ToString();
                string restriction = Controleur.Vmodele.DTactivites.Rows[i][10].ToString();

                Activite act1 = new Activite(ida, idt, codea, libellea, descri, heureDebuta, heureFina, nbrPlacesa, sallea, entetedescri, restriction);
                lesActivites.Add(act1);
            }
            return lesActivites;
        }
        public List<Activite> initActivitesEleve(int ideleve)
        {
            List<Activite> listeActivites = new List<Activite>();
            try
            {
                Controleur.Vmodele.charger_activites_eleve(ideleve);
                if (Controleur.Vmodele.DTactiviteseleve.Rows.Count > 0)
                {
                    for (int i = 0; i < Controleur.Vmodele.DTactiviteseleve.Rows.Count; i++) // Création d'une liste d'activites en fonction de l'élève choisi
                    {
                        string libelle = Controleur.Vmodele.DTactiviteseleve.Rows[i]["libelleA"].ToString();
                        string code = Controleur.Vmodele.DTactiviteseleve.Rows[i]["codeA"].ToString();
                        DateTime heuredebut = Convert.ToDateTime(Controleur.Vmodele.DTactiviteseleve.Rows[i]["HEUREDEBUTA"]);
                        DateTime heurefin = Convert.ToDateTime(Controleur.Vmodele.DTactiviteseleve.Rows[i]["HEUREFINA"]);
                        string salle = Controleur.Vmodele.DTactiviteseleve.Rows[i]["salle"].ToString();
                        int id = Convert.ToInt32(Controleur.Vmodele.DTactiviteseleve.Rows[i]["IDA"]);
                        int idt = Convert.ToInt32(Controleur.Vmodele.DTactiviteseleve.Rows[i]["IDT"]);
                        int nbplace = Convert.ToInt32(Controleur.Vmodele.DTactiviteseleve.Rows[i]["NBPLACEA"]);
                        Activite act = new Activite(id, idt, libelle, code, heuredebut, heurefin, nbplace, salle);
                        listeActivites.Add(act);

                    }
                }
            }
            catch (Exception err)// gestion des erreurs
            {
                MessageBox.Show("Erreur récupération données: " + err, "PBS connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listeActivites;
        }
        public TimeSpan initTempsActivitesEleve(int ideleve)
        {
            TimeSpan tempsActivite = new TimeSpan();
            try
            {
                Controleur.Vmodele.charger_temps_eleve(ideleve);
                if (Controleur.Vmodele.DTactiviteseleve.Rows.Count > 0)
                {
                    for (int i = 0; i < Controleur.Vmodele.DTactiviteseleve.Rows.Count; i++) // Création d'une liste d'activites en fonction de l'élève choisi
                    {
                        tempsActivite += TimeSpan.Parse(Controleur.Vmodele.DTactiviteselevetemps.Rows[i]["temps"].ToString());
                    }
                }
            }
            catch (Exception err)// gestion des erreurs
            {
                MessageBox.Show("Erreur récupération données: " + err, "PBS connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tempsActivite;
        }
        public List<Activite> initActiviteSansDescription()
        {
            List<Activite> lesActivites = new List<Activite>();
            Controleur.Vmodele.charger_activites_sansdescription();
            for (int i = 0; i < Controleur.Vmodele.DTactivitesansdescription.Rows.Count; i++)
            {
                int id = Convert.ToInt32(Controleur.Vmodele.DTactivitesansdescription.Rows[i]["IDA"]);
                int idt = Convert.ToInt32(Controleur.Vmodele.DTactivitesansdescription.Rows[i]["IDT"]);
                string libelleA = Controleur.Vmodele.DTactivitesansdescription.Rows[i]["LIBELLEA"].ToString();
                string code = Controleur.Vmodele.DTactivitesansdescription.Rows[i]["CODEA"].ToString();
                DateTime heured = Convert.ToDateTime(Controleur.Vmodele.DTactivitesansdescription.Rows[i]["HEUREDEBUTA"]);
                DateTime heuref = Convert.ToDateTime(Controleur.Vmodele.DTactivitesansdescription.Rows[i]["HEUREFINA"]);
                int NbPlaceA = Convert.ToInt32(Controleur.Vmodele.DTactivitesansdescription.Rows[i]["NBPLACEA"]);
                string Salle = Controleur.Vmodele.DTactivitesansdescription.Rows[i]["SALLE"].ToString();
                Activite act = new Activite(id, idt, libelleA, code, heured, heuref, NbPlaceA, Salle);
                lesActivites.Add(act);
            }
            return lesActivites;
        }

        #region gestion des activités
        public List<Activite> InitActiviteGestion()
        {
            lesActivites = new List<Activite>();
            lesActivites.Clear();

            Controleur.Vmodele.charger_activitesgestion();
            for (int i = 0; i < Controleur.Vmodele.DTactivitesgestion.Rows.Count; i++)
            {
                int ida = Convert.ToInt32(Controleur.Vmodele.DTactivitesgestion.Rows[i]["IDA"]);
                int idt = Convert.ToInt32(Controleur.Vmodele.DTactivitesgestion.Rows[i]["IDT"]);
                int idd = Convert.ToInt32(Controleur.Vmodele.DTactivitesgestion.Rows[i]["IDD"]);
                string codea = Controleur.Vmodele.DTactivitesgestion.Rows[i]["CODEA"].ToString();
                string libellea = Controleur.Vmodele.DTactivitesgestion.Rows[i]["LIBELLEA"].ToString();
                string descri = Controleur.Vmodele.DTactivitesgestion.Rows[i]["DESCRIPTIONA"].ToString();
                DateTime heureDebuta = Convert.ToDateTime((Controleur.Vmodele.DTactivitesgestion.Rows[i]["HEUREDEBUTA"]).ToString());
                DateTime heureFina = Convert.ToDateTime((Controleur.Vmodele.DTactivitesgestion.Rows[i]["HEUREFINA"]).ToString());
                int nbrPlacesa = Convert.ToInt32(Controleur.Vmodele.DTactivitesgestion.Rows[i]["NBPLACEA"]);
                string sallea = Controleur.Vmodele.DTactivitesgestion.Rows[i]["SALLE"].ToString();


                Activite act1 = new Activite(ida, idt, idd, codea, libellea, descri, heureDebuta, heureFina, nbrPlacesa, sallea);
                lesActivites.Add(act1);
            }
            return lesActivites;
        }

        public Activite(int id, int idType,int idDate, string code, string libelle, string description, DateTime heureDebut, DateTime heureFin, int nbrPlaces, string salle)
        {
            this.id = id;
            this.idType = idType;
            this.idDate = idDate;
            this.code = code;
            this.libelle = libelle;
            this.description = description;
            this.heureDebut = heureDebut;
            this.heureFin = heureFin;
            this.nbrPlaces = nbrPlaces;
            this.salle = salle;

        }
        #endregion

        /*
         DateTime.  ToLongDateString()          date(long format)           samedi 8 août 2009
                    ToLongTimeString()          heure(long format)          22:55:37
                    ToShortDateString()         date(court format)          08/08/2009
                    ToShortTimeString()         heure(court format)         22:55
                    ToString()                  date + heure(court format)  08/08/2009 22:55:37
        */

    }
}

using JoachAutrement.Activités;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoachAutrement
{
    public class Utilisateur
    {
        private int iDU, iDP, iDC;
        private TimeSpan tempsActivite;
        private string nomU, prenomU, classe;
        private bool valide;
        private string iden, mdp;


        public List<Utilisateur> lesEleves;
        public List<Utilisateur> uneClasse;


        public Utilisateur(int idU, int idP, string nomU, string prenomU, bool valide)
        {
            iDU = idU;
            iDP = idP;
            this.nomU = nomU;
            this.prenomU = prenomU;
            this.valide = valide;
        }
        public Utilisateur(int idU, string nomU, string prenomU, string classe)
        {
            iDU = idU;
            this.nomU = nomU;
            this.prenomU = prenomU;
            this.classe = classe;
        }


        public Utilisateur(int iDU, string nomU, string prenomU, int iDC, bool valide)
        {
            this.iDU = iDU;
            this.nomU = nomU;
            this.prenomU = prenomU;
            this.iDC = iDC;
            this.valide = valide;
        }
        public Utilisateur(int iDU, string nomU, string prenomU, int iDC,TimeSpan tempsdiff, bool valide)
        {
            this.iDU = iDU;
            this.nomU = nomU;
            this.prenomU = prenomU;
            this.iDC = iDC;
            this.tempsActivite = tempsdiff;
            this.valide = valide;
        }
        public Utilisateur(int iDU, string nomU, string prenomU, int iDC)
        {
            this.iDU = iDU;
            this.nomU = nomU;
            this.prenomU = prenomU;
            this.iDC = iDC;
        }
        public Utilisateur(string nomU, string prenomU, string classe, string iden, string mdp)
        {
            this.nomU = nomU;
            this.prenomU = prenomU;
            this.classe = classe;
            this.iden = iden;
            this.mdp = mdp;
        }

        public Utilisateur()
        {

        }

        #region accesseurs
        public int IDU
        {
            get { return iDU; }
        }
        public int IDP
        {
            get { return iDP; }
            set { iDP = value; }
        }
        public int IDC
        {
            get { return iDC; }
            set { iDC = value; }
        }
        public TimeSpan Tempsactivite
        {
            get { return tempsActivite; }
            set { tempsActivite = value; }
        }
        public string NomU
        {
            get { return nomU; }
            set { nomU = value; }
        }
        public string PrenomU
        {
            get { return prenomU; }
            set { prenomU = value; }
        }
        public string Classe
        {
            get { return classe; }
            set { classe = value; }
        }
        public bool Valide
        {
            get { return valide; }
            set { valide = value; }
        }
        public string Iden
        {
            get { return iden; }
            set { iden = value; }
        }
        public string Mdp
        {
            get { return mdp; }
            set { mdp = value; }
        }
        #endregion
        public void InitEleve()
        {
            lesEleves = new List<Utilisateur>();

            Controleur.Vmodele.charger_eleves();
            for (int i = 0; i < Controleur.Vmodele.DTeleve.Rows.Count; i++)
            {
                int id = Convert.ToInt32(Controleur.Vmodele.DTeleve.Rows[i]["IDU"]);
                int idC = Convert.ToInt32(Controleur.Vmodele.DTeleve.Rows[i]["IDC"]);
                string nom = Controleur.Vmodele.DTeleve.Rows[i]["NOMU"].ToString();
                string prenom = Controleur.Vmodele.DTeleve.Rows[i]["PRENOMU"].ToString();
                bool valide = Convert.ToBoolean(Controleur.Vmodele.DTeleve.Rows[i]["VALIDE"]);


                Utilisateur act1 = new Utilisateur(id, nom, prenom, idC, valide);
                lesEleves.Add(act1);
            }
        }
        public Utilisateur InitlEleve(int ideleve)
        {
            Controleur.Vmodele.charger_eleve(ideleve);
            int id = Convert.ToInt32(Controleur.Vmodele.DTleleve.Rows[0]["IDU"]);
            int idC = Convert.ToInt32(Controleur.Vmodele.DTleleve.Rows[0]["IDC"]);
            string nom = Controleur.Vmodele.DTleleve.Rows[0]["NOMU"].ToString();
            string prenom = Controleur.Vmodele.DTleleve.Rows[0]["PRENOMU"].ToString();
            bool valide = Convert.ToBoolean(Controleur.Vmodele.DTleleve.Rows[0]["VALIDE"]);
            Utilisateur act1 = new Utilisateur(id, nom, prenom, idC, valide);
            return act1;
        }

        public List<Utilisateur> trouverClasse(int idClasse)
        {
            uneClasse = new List<Utilisateur>();
            foreach (Utilisateur e in lesEleves)
            {
                if (e.IDC == idClasse)
                    uneClasse.Add(e);
            }

            return uneClasse;
        }
        public List<Utilisateur> InitElevesnonvalides()
        {
            lesEleves = new List<Utilisateur>();

            Controleur.Vmodele.charger_eleves_nonvalides();
            for (int i = 0; i < Controleur.Vmodele.DTelevesnonvalides.Rows.Count; i++)
            {
                int id = Convert.ToInt32(Controleur.Vmodele.DTelevesnonvalides.Rows[i][0]);
                int idC = Convert.ToInt32(Controleur.Vmodele.DTelevesnonvalides.Rows[i][1]);
                string nom = Controleur.Vmodele.DTelevesnonvalides.Rows[i][3].ToString();
                string prenom = Controleur.Vmodele.DTelevesnonvalides.Rows[i][4].ToString();
                bool valide = Convert.ToBoolean(Controleur.Vmodele.DTelevesnonvalides.Rows[i][7]);
                Utilisateur act1 = new Utilisateur(id, nom, prenom, idC, valide);
                lesEleves.Add(act1);
            }
            return lesEleves;
        }
        public List<Utilisateur> InitElevesclasse(int IDC) //Utilisé pour le PDF elevesclasse
        {
            lesEleves = new List<Utilisateur>();
            List<Utilisateur> lesutilisateurs = new List<Utilisateur>();
            Controleur.Vmodele.charger_eleves_classe(IDC);
            for (int i = 0; i < Controleur.Vmodele.DTelevesclassevalides.Rows.Count; i++)
            {
                TimeSpan letemps = new TimeSpan();
                int id = Convert.ToInt32(Controleur.Vmodele.DTelevesclassevalides.Rows[i]["IDU"]);
                Activite uneA = new Activite();
                uneA.initTempsActivitesEleve(id);
                for (int y = 0; y < Controleur.Vmodele.DTactiviteselevetemps.Rows.Count; y++)
                {
                    letemps += TimeSpan.Parse(Controleur.Vmodele.DTactiviteselevetemps.Rows[y]["temps"].ToString());
                }
                string nom = Controleur.Vmodele.DTelevesclassevalides.Rows[i]["NOMU"].ToString();
                string prenom = Controleur.Vmodele.DTelevesclassevalides.Rows[i]["PRENOMU"].ToString();
                int idC = Convert.ToInt32(Controleur.Vmodele.DTelevesclassevalides.Rows[i]["IDC"]);
                bool valide = Convert.ToBoolean(Controleur.Vmodele.DTelevesclassevalides.Rows[i]["VALIDE"]);
                Utilisateur act1 = new Utilisateur(id, nom, prenom, idC, letemps, valide);
                lesutilisateurs.Add(act1);
            }
            return lesutilisateurs;
        }
    }
}

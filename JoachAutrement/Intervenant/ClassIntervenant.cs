using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoachAutrement.Intervenant
{
    public class ClassIntervenant
    {
        int id;
        string nom;
        string prenom;
        string profession;
        bool externe;
        List<DateTime> heuredebut;
        List<DateTime> heurefin;
        List<ClassIntervenant> lesIntervenants = new List<ClassIntervenant>();

        public ClassIntervenant(int id, string nom, string prenom, string profession, bool externe)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.profession = profession;
            this.externe = externe;
        }

        public ClassIntervenant(string nom, string prenom, string profession, bool externe,List<DateTime> lesdatesdebut, List<DateTime> lesdatesfin)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.profession = profession;
            this.externe = externe;
            this.heuredebut = lesdatesdebut;
            this.heurefin = lesdatesfin;
        }
        public ClassIntervenant(string nom, string prenom, string profession, bool externe)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.profession = profession;
            this.externe = externe;
        }

        public ClassIntervenant()
        {

        }

        #region accesseurs
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }

        public bool Externe
        {
            get { return externe; }
            set { externe = value; }
        }
        public List<DateTime> Heuredebut
        {
            get { return heuredebut; }
            set { heuredebut = value; }
        }
        public List<DateTime> Heurefin
        {
            get { return heurefin; }
            set { heurefin = value; }
        }
        #endregion

        public List<ClassIntervenant> InitIntervenant()
        {

            Controleur.Vmodele.charger_intervenants();
            for (int i = 0; i < Controleur.Vmodele.DTintervenants.Rows.Count; i++)
            {
                int id = Convert.ToInt32(Controleur.Vmodele.DTintervenants.Rows[i][0]);
                string nom = Controleur.Vmodele.DTintervenants.Rows[i][1].ToString();
                string prenom = Controleur.Vmodele.DTintervenants.Rows[i][2].ToString();
                string profession = Controleur.Vmodele.DTintervenants.Rows[i][3].ToString();
                bool externe = Convert.ToBoolean(Controleur.Vmodele.DTintervenants.Rows[i][4]);
                ClassIntervenant act1 = new ClassIntervenant(id, nom, prenom, profession, externe);
                lesIntervenants.Add(act1);
            }
            return lesIntervenants;
        }
        public Dictionary<int,ClassIntervenant> InitIntervenantdateheure()
        {
            Dictionary<int,ClassIntervenant > lesintervenants = new Dictionary<int, ClassIntervenant>();
            Controleur.Vmodele.charger_intervenants_dateheure();
            for (int i = 0; i < Controleur.Vmodele.DTintervenantinfotemps.Rows.Count; i++)
            {
                bool estexistant = false;
                foreach(KeyValuePair<int,ClassIntervenant> dico in lesintervenants)
                {
                    if (dico.Key == Convert.ToInt32(Controleur.Vmodele.DTintervenantinfotemps.Rows[i]["IDI"]))
                    {
                        dico.Value.heuredebut.Add(Convert.ToDateTime(Controleur.Vmodele.DTintervenantinfotemps.Rows[i]["HEUREDEBUTA"].ToString()));
                        dico.Value.heurefin.Add(Convert.ToDateTime(Controleur.Vmodele.DTintervenantinfotemps.Rows[i]["HEUREFINA"].ToString()));
                        estexistant = true;
                        break;
                    }
                }
                if (estexistant == false)
                {
                    string nom = Controleur.Vmodele.DTintervenantinfotemps.Rows[i]["NOMI"].ToString();
                    string prenom = Controleur.Vmodele.DTintervenantinfotemps.Rows[i]["PRENOMI"].ToString();
                    string profession = Controleur.Vmodele.DTintervenantinfotemps.Rows[i]["PROFESSIONI"].ToString();
                    bool externe = Convert.ToBoolean(Controleur.Vmodele.DTintervenantinfotemps.Rows[i]["EXTERIEUR"]);
                    List<DateTime> heuredebut = new List<DateTime>();
                    heuredebut.Add(Convert.ToDateTime(Controleur.Vmodele.DTintervenantinfotemps.Rows[i]["HEUREDEBUTA"].ToString()));
                    List<DateTime> heurefin = new List<DateTime>();
                    heurefin.Add(Convert.ToDateTime(Controleur.Vmodele.DTintervenantinfotemps.Rows[i]["HEUREFINA"].ToString()));
                    ClassIntervenant act1 = new ClassIntervenant(nom, prenom, profession, externe, heuredebut ,heurefin);
                    lesintervenants.Add(Convert.ToInt32(Controleur.Vmodele.DTintervenantinfotemps.Rows[i]["IDI"]),act1);
                }
            }
            return lesintervenants;
        }
        public bool AjouterIntervenant(string nom, string prenom, string profession, bool externe)
        {
            ClassIntervenant act1 = new ClassIntervenant(nom, prenom, profession, externe);
            foreach (ClassIntervenant c in lesIntervenants) 
            {
                if (c.Nom == act1.Nom && c.Prenom == act1.Prenom) // test avec le nom et prenom si l'intervenant existe deja
                    return false;
                else lesIntervenants.Add(act1);
            }
            return true;
        }
    }
}

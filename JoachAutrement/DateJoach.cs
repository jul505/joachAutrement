using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoachAutrement
{
    public class DateJoach
    {
        int id;
        DateTime dateevenement;
        bool inscritprof;
        bool inscriteleve;
        bool matin;
        bool aprem;

        public int Id
        {
            get { return id; }
            set { id = value;}
        }
        public DateTime Dateevenement
        {
            get { return dateevenement; }
            set { dateevenement = value; }
        }
        public bool Inscritprof
        {
            get { return inscritprof; }
            set { inscritprof = value; }
        }
        public bool Inscriteleve
        {
            get { return inscriteleve; }
            set { inscriteleve = value; }
        }
        public bool Matin
        {
            get { return matin; }
            set { matin = value; }
        }
        public bool Aprem
        {
            get { return aprem; }
            set { aprem = value; }
        }
        public DateJoach() { }

        public DateJoach(int id, DateTime dat, bool prof, bool eleve, bool matin, bool aprem)
        {
            this.id = id;
            dateevenement = dat;
            inscritprof = prof;
            inscriteleve = eleve;
            this.matin = matin;
            this.aprem = aprem;
        }
        public DateJoach(DateTime dat, bool matin, bool aprem)
        {
            dateevenement = dat;
            this.matin = matin;
            this.aprem = aprem;
        }

        public List<DateJoach> initDateJoach()
        {
            List<DateJoach> lesdates = new List<DateJoach>();
            Controleur.Vmodele.charger_datejoach();
            for(int i = 0; i < Controleur.Vmodele.DTdatejoach.Rows.Count;i++)
            {
                DateJoach dat;
                int id = Convert.ToInt32(Controleur.Vmodele.DTdatejoach.Rows[i]["IDD"]);
                DateTime dateeve = Convert.ToDateTime(Controleur.Vmodele.DTdatejoach.Rows[i]["DATEEVENEMENT"].ToString());
                bool estprof = Convert.ToBoolean(Controleur.Vmodele.DTdatejoach.Rows[i]["ESTINSCRITPROF"]);
                bool esteleve = Convert.ToBoolean(Controleur.Vmodele.DTdatejoach.Rows[i]["ESTINSCRITELEVE"]);
                bool m = Convert.ToBoolean(Controleur.Vmodele.DTdatejoach.Rows[i]["MATIN"]);
                bool a = Convert.ToBoolean(Controleur.Vmodele.DTdatejoach.Rows[i]["APRESMIDI"]);
                dat = new DateJoach(id, dateeve, estprof, esteleve, m, a);
                lesdates.Add(dat);
            }
            return lesdates;
        }

        public bool testerDateEleve()
        {
            DateTime date = new DateTime();
            bool verif = true;
            Controleur.Vmodele.charger_datejoach();
            if (Controleur.Vmodele.Chargement)
            {
                for (int i = 0; i < Controleur.Vmodele.DTdatejoach.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(Controleur.Vmodele.DTdatejoach.Rows[i]["ESTINSCRITELEVE"]) == true)
                    {
                        date = Convert.ToDateTime(Controleur.Vmodele.DTdatejoach.Rows[i]["DATEEVENEMENT"].ToString());
                    }
                }
            }
            if (DateTime.Today < date == true)
            {
                verif = false;
            }
            return verif;
        }

        public bool testerDateProf()
        {
            DateTime date = new DateTime();
            bool verif = true;
            Controleur.Vmodele.charger_datejoach();
            if (Controleur.Vmodele.Chargement)
            {
                for (int i = 0; i < Controleur.Vmodele.DTdatejoach.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(Controleur.Vmodele.DTdatejoach.Rows[i]["ESTINSCRITPROF"]) == true)
                    {
                        date = Convert.ToDateTime(Controleur.Vmodele.DTdatejoach.Rows[i]["DATEEVENEMENT"].ToString());
                    }
                }
            }
            if (DateTime.Today < date == true)
            {
                verif =  false;
            }
            return verif;
        }
    }
}

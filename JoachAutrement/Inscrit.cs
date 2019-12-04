using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoachAutrement
{
    class Inscrit
    {
        int ideleve;
        int idactivite;
        public int Ideleve
        {
            get { return ideleve; }
            set { ideleve = value; }
        }
        public int Idactivite
        {
            get { return idactivite; }
            set { idactivite = value; }
        }
        public Inscrit() { }
        public Inscrit(int ide, int ida)
        {
            ideleve = ide;
            idactivite = ida;
        }
        public List<Inscrit> initInscritEleve(int ideleve)
        {
            List<Inscrit> lesinscrits = new List<Inscrit>();
            Controleur.Vmodele.charger_inscription_eleve(ideleve);
            for(int i = 0; i < Controleur.Vmodele.DTsuppractiviteeleve.Rows.Count; i++)
            {
                Inscrit ins;
                int ide = Convert.ToInt32(Controleur.Vmodele.DTsuppractiviteeleve.Rows[i][0]);
                int ida = Convert.ToInt32(Controleur.Vmodele.DTsuppractiviteeleve.Rows[i][1]);
                ins = new Inscrit(ide, ida);
                lesinscrits.Add(ins);
            }
            return lesinscrits;
        }
    }
}

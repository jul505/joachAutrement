using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoachAutrement.Eleve
{
    public class Classe
    {
        private int id;
        private string libelle;

        public List<Classe> lesClasses;

        public Classe(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;

        }

        public Classe()
        {

        }

        #region accesseurs

        public string Libelle
           {
               get { return libelle; }
               set { libelle = value; }
           }
        public int Id
           {
               get { return id; }
               set { id = value; }
           }

                
        #endregion

        public List<Classe> InitClasse()
        {
            lesClasses = new List<Classe>();
            
            Controleur.Vmodele.charger_classe();
            for (int i = 0; i < Controleur.Vmodele.DTclasse.Rows.Count; i++)
            {
                int id = Convert.ToInt32(Controleur.Vmodele.DTclasse.Rows[i][0]);
                string libelle = Controleur.Vmodele.DTclasse.Rows[i][1].ToString();
                
                Classe act1 = new Classe(id, libelle);
                lesClasses.Add(act1);
            }
            return lesClasses;
        }



        public int getIdClasse(string libelle)
        {
            int id = 0;
            foreach (Classe c in lesClasses)
            {
                if (c.Libelle == libelle)
                    id = c.Id;
            }

            return id;
        }

        public string getLibelleClasse(int id)
        {
            string libelle = "";
            foreach (Classe c in lesClasses)
            {
                if (c.Id == id)
                    libelle = c.Libelle;
            }

            return libelle;
        }
    }
}

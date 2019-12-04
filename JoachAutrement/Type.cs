using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoachAutrement
{
    public class Type
    {
        int id;
        string libelle;

        List<Type> lesTypes;


        public Type(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public Type()
        {

        }

        #region accesseurs
        public int Id
        {
            get { return id; }
        }
        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }
        #endregion

        public List<Type> InitType()
        {
            lesTypes = new List<Type>();
            lesTypes.Clear();

            Controleur.Vmodele.charger_types();
            for (int i = 0; i < Controleur.Vmodele.DTtype.Rows.Count; i++)
            {
                int idT = Convert.ToInt32(Controleur.Vmodele.DTtype.Rows[i][0]);
                string libelleT = Controleur.Vmodele.DTtype.Rows[i][1].ToString();
                

                Type t = new Type(idT, libelleT);
                lesTypes.Add(t);
            }
            return lesTypes;
        }
        public void InitListeType()
        {
            lesTypes = new List<Type>();
            lesTypes.Clear();

            Controleur.Vmodele.charger_types();
            for (int i = 0; i < Controleur.Vmodele.DTtype.Rows.Count; i++)
            {
                int idT = Convert.ToInt32(Controleur.Vmodele.DTtype.Rows[i][0]);
                string libelleT = Controleur.Vmodele.DTtype.Rows[i][1].ToString();


                Type t = new Type(idT, libelleT);
                lesTypes.Add(t);
            }
        }


        public int getIdType(string libelle)
        {
            int id = 0;
            foreach (Type t in lesTypes)
            {
                if (t.Libelle == libelle)
                    id = t.Id;
            }

            return id;
        }

        public string getLibelleType(int id)
        {
            string libelle = "";
            foreach (Type t in lesTypes)
            {
                if (t.Id == id)
                    libelle = t.Libelle;
            }

            return libelle;
        }
    }
}

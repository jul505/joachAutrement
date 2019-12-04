using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JoachAutrement.Activités;

namespace JoachAutrement
{
    class DatePDF
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        private string libelle;

        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }
        private List<Activite> lesActivites;

        public List<Activite> LesActivites
        {
            get { return lesActivites; }
            set { lesActivites = value; }
        }

        public DatePDF(int id, DateTime date, string libelle, List<Activite> lesAct)
        {
            this.id = id;
            this.date = date;
            this.libelle = libelle;
            lesActivites = lesAct;
        }
    }
}

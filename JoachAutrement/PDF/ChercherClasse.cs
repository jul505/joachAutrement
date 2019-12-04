using JoachAutrement.Activités;
using JoachAutrement.Eleve;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoachAutrement.PDF
{
    public partial class ChercherClasse : Form
    {
        Classe laclasse = new Classe();
        List<Classe> lesclasses = new List<Classe>();
        Dictionary<int, Classe> dicoclasses = new Dictionary<int, Classe>();
        public ChercherClasse()
        {
            InitializeComponent();
            lesclasses = laclasse.InitClasse();
            
        }

        private void TB_classe_TextChanged(object sender, EventArgs e)
        {
            filtrerClasse();
        }
        private void filtrerClasse()
        {
            int cledico = 0;
            dicoclasses.Clear();
            LB_classe.Items.Clear();
            foreach (Classe cla in lesclasses)
            {
                if (cla.Libelle.Contains(TB_classe.Text))
                {
                    cledico++;
                    dicoclasses.Add(cledico, cla);
                }
            }
            foreach (KeyValuePair<int, Classe> dico in dicoclasses)
            {
                LB_classe.Items.Add(dico.Value.Libelle);
            }
        }

        private void ChercherClasse_Load(object sender, EventArgs e)
        {
            filtrerClasse();
        }

        private void LB_classe_DoubleClick(object sender, EventArgs e)
        {
            int clerechercher = 0;
            foreach(KeyValuePair<int,Classe> dico in dicoclasses)
            {
                clerechercher++;
                if(dico.Key == LB_classe.SelectedIndex + 1)
                {
                    VisualisationPDF PDFelevesclasse = new VisualisationPDF("listeelevesclasse", dico.Value.Id);
                    PDFelevesclasse.Show();
                }
            }
        }
    }
}

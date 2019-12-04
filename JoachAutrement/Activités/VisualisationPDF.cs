using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoachAutrement.Activités
{
    public partial class VisualisationPDF : Form
    {
        public VisualisationPDF()
        {
            InitializeComponent();
            
        }

        private void VisualisationPDF_Load(object sender, EventArgs e)
        {
            WBaffichagepdf.Navigate(@"D:\Copie Clé\Ecole\Stage\CV Etienne Soleau stage SIO 2nd année.pdf");
        }

        private void WBaffichagepdf_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}

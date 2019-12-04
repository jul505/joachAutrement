using JoachAutrement.Activités;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoachAutrement
{
    public partial class GestionActivites : Form
    {
        private BindingSource bindingSource1;
        AjouterActivites Form1;

        Type type;
        List<Type> lesTypes;

        public GestionActivites()
        {
            InitializeComponent();
            charger();

            type = new Type();
            lesTypes = new List<Type>();
            lesTypes = type.InitType();
            foreach (Type t in lesTypes)
            {
                comboBoxTypes.Items.Add(t.Libelle);
            }
        }

        public void charger()
        {
            Controleur.Vmodele.charger_afficherActivites();

            if (Controleur.Vmodele.Chargement)
            {
                bindingSource1 = new BindingSource();
                bindingSource1.DataSource = Controleur.Vmodele.DTafficherActivites;
                dataGridView1.DataSource = bindingSource1;
                dataGridView1.Columns["IDA"].Visible = false;
                dataGridView1.Columns["LIBELLEA"].HeaderText = "Titre";
                dataGridView1.Columns["CODEA"].HeaderText = "Code de l'activité";
                dataGridView1.Columns["HEUREDEBUTA"].HeaderText = "Heure de debut";
                dataGridView1.Columns["HEUREFINA"].HeaderText = "Heure de fin";
                dataGridView1.Columns["NBPLACEA"].HeaderText = "Nombre de places";
                dataGridView1.Columns["SALLE"].HeaderText = "Salle";
                dataGridView1.Columns["DATEEVENEMENT"].HeaderText = "Date";
                dataGridView1.Columns["LIBELLET"].HeaderText = "Type";
                dataGridView1.Columns["NOMI"].HeaderText = "Nom de l'intervenant";
                dataGridView1.Columns["PRENOMI"].HeaderText = "Prenom";
                dataGridView1.Columns["DESCRIPTIONA"].HeaderText = "Description";
                dataGridView1.Columns["ENTETEDESCRIPTIONA"].HeaderText = "Entête";
                dataGridView1.Columns["RESTRICTION"].HeaderText = "Public visé";
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DateTime heureDebut = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["HEUREDEBUTA"].Value.ToString());
                DateTime heureFin = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["HEUREFINA"].Value.ToString());
                Form1 = new AjouterActivites
                    (
                    Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDA"].Value),
                    dataGridView1.CurrentRow.Cells["NOMI"].Value.ToString() + " " + dataGridView1.CurrentRow.Cells["PRENOMI"].Value.ToString(),
                    dataGridView1.CurrentRow.Cells["LIBELLET"].Value.ToString(),
                    dataGridView1.CurrentRow.Cells["DATEEVENEMENT"].Value.ToString(),
                    dataGridView1.CurrentRow.Cells["DESCRIPTIONA"].Value.ToString(),
                    dataGridView1.CurrentRow.Cells["LIBELLEA"].Value.ToString(),
                    dataGridView1.CurrentRow.Cells["SALLE"].Value.ToString(),
                    dataGridView1.CurrentRow.Cells["NBPLACEA"].Value.ToString(),
                    heureDebut.ToShortTimeString(),
                    heureFin.ToShortTimeString(),
                    dataGridView1.CurrentRow.Cells["ENTETEDESCRIPTIONA"].Value.ToString(),
                    dataGridView1.CurrentRow.Cells["RESTRICTION"].Value.ToString()
                    );
                Form1.Text = "Modifier une Activite";
                Form1.ShowDialog();
                charger();
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int idSupprimer = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDA"].Value);
                DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer cette activite " + dataGridView1.CurrentRow.Cells["CODEA"].Value.ToString()
                + "  " + dataGridView1.CurrentRow.Cells["LIBELLEA"].Value.ToString() + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    Controleur.supprimerActivite(idSupprimer);
                    charger();
                }
            }
        }

        private void buttonRecherche_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == false)
            {
                groupBox1.Visible = true;
                buttonRecherche.Text = "Annuler la recherche";
            }

            else
            {
                groupBox1.Visible = false;
                buttonRecherche.Text = "Rechercher à l'aide de filtre";
                textBoxCode.Text = "";
                textBoxTitre.Text = "";
                comboBoxTypes.Text = "";
                textBoxSalle.Text = "";
            }
        }

        public void filtrer()
        {
            bindingSource1.Filter = "LIBELLEA LIKE '" + textBoxTitre.Text + "%' AND CODEA LIKE '" + textBoxCode.Text + "%' AND LIBELLET LIKE '" + comboBoxTypes.Text.ToString() + "%' AND SALLE LIKE '" + textBoxSalle.Text + "%'";
        }

        private void textBoxTitre_TextChanged(object sender, EventArgs e)
        {
            filtrer();
        }

        private void textBoxCode_TextChanged(object sender, EventArgs e)
        {
            filtrer();
        }

        private void comboBoxTypes_TextChanged(object sender, EventArgs e)
        {
            filtrer();
        }

        private void textBoxSalle_TextChanged(object sender, EventArgs e)
        {
            filtrer();
        }

        void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCell cell = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            cell.ToolTipText = "Cliquez en haut des colonnes pour ordonner le tableau.";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JoachAutrement.Intervenant;
using JoachAutrement.Activités;
using System.Text.RegularExpressions;

namespace JoachAutrement.Activités
{
    public partial class AjouterActivites : Form
    {
        ClassIntervenant Interv;
        List<ClassIntervenant> lesIntervenants;
        Dictionary<int, ClassIntervenant> DicoIntervenant;

        DateJoach Date;
        List<DateJoach> lesDates;
        Dictionary<int, DateJoach> DicoDate;

        Type type;
        List<Type> lesTypes;

        Activite activite;
        List<Activite> lesActivites;

        int idActivite = 0;
        int idIntervenant = 0;
        int idType = 0;
        int idDate = 0;
        string libelle = "";
        string salle = "";
        string description = "";
        string code = "";
        string entete = "";
        string publ = "";
        int nbrPlaces = 0;
        DateTime heureD = Convert.ToDateTime("00:00:00");
        DateTime heureF = Convert.ToDateTime("00:00:00");


        public AjouterActivites()
        {
            InitializeComponent();

            chargerIntervenant("");
            chargerDate();
            chargerType();

        }

        public AjouterActivites(int idA, string intervenant, string type, string date, string description, string libelle, string salle, string nbrplace, string heured, string heuref, string entete, string pub)
        {
            InitializeComponent();
            idActivite = idA;
            
            
            
            RichTextBoxDescription.Text = description;
            TextBoxLibelle.Text = libelle;
            TextBoxSalle.Text = salle;
            TextBoxPlaces.Text = nbrplace;
            

            chargerIntervenant("");
            chargerDate();
            chargerType();

            comboBoxIntervenant.Text = intervenant;
            ComboBoxHeureD.Text = heured;
            ComboBoxHeureF.Text = heuref;

            comboBoxPublic.Text = pub;
            richTextBoxEntete.Text = entete;

            for (int i = 0; i < lesTypes.Count; i++)
            {
                if (lesTypes[i].Libelle == type)
                    comboBoxType.SelectedIndex = i;
            }
            DateTime d = Convert.ToDateTime(date);
            foreach (KeyValuePair<int, DateJoach> dico in DicoDate)
            {
                if (dico.Value.Dateevenement.ToShortDateString() == d.ToShortDateString())
                {
                    ComboBoxDate.SelectedIndex = dico.Key;
                }
            }
            buttonOK.Text = "Modifier l'activite";
        }

        public void chargerActivite()
        {
            activite = new Activite();
            lesActivites = new List<Activite>();
            lesActivites = activite.InitActiviteGestion();
        }
        public void chargerIntervenant(string nomPrenom)
        {
            DicoIntervenant = new Dictionary<int, ClassIntervenant>();
            comboBoxIntervenant.Items.Clear();
            Interv = new ClassIntervenant();
            lesIntervenants = new List<ClassIntervenant>();
            lesIntervenants = Interv.InitIntervenant();
            int i = 0;
            foreach (ClassIntervenant c in lesIntervenants)
            {
                if (nomPrenom == "" || c.Nom.StartsWith(nomPrenom) || c.Prenom.StartsWith(nomPrenom))
                {
                    comboBoxIntervenant.Items.Add(c.Nom + " " + c.Prenom);
                    DicoIntervenant.Add(i, c);
                    i++;
                }
            }
            
        }
        public int recupIntervenant(int indice)
        {
            int a = 0;
            foreach (KeyValuePair<int, ClassIntervenant> dico in DicoIntervenant)
            {
                if (dico.Key == indice)
                {
                    a = dico.Value.Id;
                    break;
                }
            }
            return a;
        } // recherche via un dico que l'on recharge a chaque filtre
        public void chargerDate()
        {
            DicoDate = new Dictionary<int, DateJoach>();
            Date = new DateJoach();
            lesDates = new List<DateJoach>();
            lesDates = Date.initDateJoach();
            lesDates = lesDates.OrderBy(x => x.Dateevenement).ToList();
            int i = 0;
            foreach (DateJoach d in lesDates)
            {
                if (d.Inscriteleve == false && d.Inscritprof == false && (d.Aprem == true || d.Matin == true))
                {
                    ComboBoxDate.Items.Add(d.Dateevenement.ToLongDateString());
                    DicoDate.Add(i, d);
                    i++;
                }
            }
        }
        public int recupDate(int indice)
        {
            int a = 0;
            foreach (KeyValuePair<int, DateJoach> dico in DicoDate)
            {
                if (dico.Key == indice)
                {
                    a = dico.Value.Id;
                    break;
                }
            }
            return a;
        } // recherche via un dico
        public void chargerType()
        {
            type = new Type();
            lesTypes = new List<Type>();
            lesTypes = type.InitType();
            foreach (Type t in lesTypes)
            {
                comboBoxType.Items.Add(t.Libelle);
            }
        }
        public int recupType(string libelleType)
        {
            int idType = 0;
            foreach (Type t in lesTypes)
            {
                if (libelleType.Equals(t.Libelle))
                {
                    idType = t.Id;
                    break;
                }
            }
            return idType;
        } // methode de recherche sur le libelle
        public string calculCode(int idType, string libelle)
        {
            string code = "";
            int nb = 0;
            chargerActivite();
            foreach (Activite a in lesActivites)
            {
                if (a.IdType == idType)
                {
                    if (Convert.ToInt32((a.Code).Substring(1)) >= nb)
                    {
                        nb = Convert.ToInt32((a.Code).Substring(1));
                        nb++;
                    }
                }
            }
            code = libelle.Substring(0, 1);
            code += nb.ToString();
            return code;
        }
        public bool verifHeure(string heure)
        {
            Regex check = new Regex("^([0-9]|0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$");
            return check.IsMatch(heure);
        }
        public bool verifDemiJourne(int IdDate, TimeSpan heured)
        {
            bool verif = true;
            foreach (DateJoach d in lesDates)
            {
                if (d.Id == IdDate)
                {
                    if (d.Matin == false)
                    {
                        DateTime test1 = Convert.ToDateTime("12:00:00");
                        TimeSpan test2 = new TimeSpan(test1.Hour, test1.Minute, test1.Second);

                        if(heured < (test2))
                        {
                            verif = false;
                            MessageBox.Show("Matinée non autorisée pour cette journée");
                        }
                    }
                    if (d.Aprem == false)
                    {
                        DateTime test1 = Convert.ToDateTime("12:00:00");
                        TimeSpan test2 = new TimeSpan(test1.Hour, test1.Minute, test1.Second);

                        if (heured > (test2))
                        {
                            verif = false;
                            MessageBox.Show("Après midi non autorisé pour cette journée");
                        }
                    }
                }
            }
            return verif;
        }


        AjouterIntervenant Form1;

        private void Btn_Intervenant_Click(object sender, EventArgs e)
        {
            
            Form1 = new AjouterIntervenant();
            Form1.ShowDialog();
            chargerIntervenant("");
            Interv = lesIntervenants.Last();
            comboBoxIntervenant.Text = Interv.Nom + " " + Interv.Prenom;
        }

        public void buttonOK_Click(object sender, EventArgs e)
        { // test si tout les champs sont remplis
            if (TextBoxLibelle.Text != "" && comboBoxIntervenant.Text != "" && comboBoxType.SelectedIndex != -1
                && ComboBoxDate.SelectedIndex != -1 && verifHeure(ComboBoxHeureD.Text) == true && verifHeure(ComboBoxHeureF.Text) == true)
            {
                idIntervenant = recupIntervenant(comboBoxIntervenant.SelectedIndex);
                if (idIntervenant != 0)
                {
                    libelle = TextBoxLibelle.Text;
                    idDate = recupDate(ComboBoxDate.SelectedIndex);
                    idType = recupType(comboBoxType.Text);

                    heureD = Convert.ToDateTime(ComboBoxHeureD.Text + ":00");
                    heureF = Convert.ToDateTime(ComboBoxHeureF.Text + ":00");
                    TimeSpan heureDebut = new TimeSpan(heureD.Hour, heureD.Minute, heureD.Second);
                    TimeSpan heureFin = new TimeSpan(heureF.Hour, heureF.Minute, heureF.Second);

                    if (verifDemiJourne(idDate, heureDebut) == true)
                    {
                        if (heureDebut < heureFin)
                        {
                            if (TextBoxPlaces.Text != "") { nbrPlaces = Convert.ToInt32(TextBoxPlaces.Text); }
                            if (TextBoxSalle.Text != "") { salle = TextBoxSalle.Text; }
                            if (RichTextBoxDescription.Text != "") { description = RichTextBoxDescription.Text; }
                            if (comboBoxPublic.Text != "") { publ = comboBoxPublic.Text; }
                            if (richTextBoxEntete.Text != "") { entete = richTextBoxEntete.Text; }
                            code = calculCode(idType, comboBoxType.Text);

                            if (idActivite == 0)
                            {
                                Controleur.ajouterActivite(idDate, idType, heureDebut, heureFin, libelle, nbrPlaces, salle, description, code, entete, publ);
                                Controleur.ajouterAnime(idIntervenant);
                                comboBoxIntervenant.Text = "";
                                TextBoxLibelle.Text = "";
                                ComboBoxHeureD.Text = "";
                                ComboBoxHeureF.Text = "";
                                TextBoxPlaces.Text = "";
                                TextBoxSalle.Text = "";
                                RichTextBoxDescription.Text = "";
                                comboBoxIntervenant.SelectedIndex = -1;
                                ComboBoxDate.SelectedIndex = -1;
                                richTextBoxEntete.Text = "";
                                comboBoxPublic.Text = "Tout public";
                                TextBoxLibelle.BackColor = Color.White;
                                comboBoxIntervenant.BackColor = Color.White;
                                comboBoxType.BackColor = Color.White;
                                ComboBoxDate.BackColor = Color.White;
                                ComboBoxHeureD.BackColor = Color.White;
                                ComboBoxHeureF.BackColor = Color.White;
                            }
                            else
                            {
                                Controleur.modifierAnime(idActivite, idIntervenant);
                                Controleur.modifierActivite(idActivite, idDate, idType, heureDebut, heureFin, libelle, nbrPlaces, salle, description, code, entete, publ);
                                this.Close();
                            }

                        }
                        else
                            MessageBox.Show("l'heure de debut est après l'heure de fin");
                    }
                }
                else
                    MessageBox.Show("l'intervenant n'existe pas");
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                if (TextBoxLibelle.Text == "") { TextBoxLibelle.BackColor = Color.Red; }
                else { TextBoxLibelle.BackColor = Color.White; }
                if (comboBoxIntervenant.SelectedIndex == -1) { comboBoxIntervenant.BackColor = Color.Red; }
                else { comboBoxIntervenant.BackColor = Color.White; }
                if (comboBoxType.SelectedIndex == -1) { comboBoxType.BackColor = Color.Red; }
                else { comboBoxType.BackColor = Color.White; }
                if (ComboBoxDate.SelectedIndex == -1) { ComboBoxDate.BackColor = Color.Red; }
                else { ComboBoxDate.BackColor = Color.White; }
                if (verifHeure(ComboBoxHeureD.Text) == false) { ComboBoxHeureD.BackColor = Color.Red; }
                else { ComboBoxHeureD.BackColor = Color.White; }
                if (verifHeure(ComboBoxHeureF.Text) == false) { ComboBoxHeureF.BackColor = Color.Red; }
                else { ComboBoxHeureF.BackColor = Color.White; }
            }
        }

        private void comboBoxIntervenant_DropDown(object sender, EventArgs e)
        {
            chargerIntervenant(comboBoxIntervenant.Text);
        }

        private void TextBoxPlaces_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}

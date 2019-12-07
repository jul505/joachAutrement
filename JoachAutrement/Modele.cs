using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace JoachAutrement
{
    public class modele
    {
        #region Propriétés
        private int indice;
        private MySqlConnection myConnection;
        private MySqlDataAdapter dAactivites = new MySqlDataAdapter();
        private MySqlDataAdapter dAintervenants = new MySqlDataAdapter();
        private MySqlDataAdapter dAtype = new MySqlDataAdapter();
        private MySqlDataAdapter dApermission = new MySqlDataAdapter();
        private MySqlDataAdapter dAconnexionUsers = new MySqlDataAdapter();
        private MySqlDataAdapter dAeleveinscritactivite = new MySqlDataAdapter();
        private MySqlDataAdapter dAactiviteseleve = new MySqlDataAdapter();
        private MySqlDataAdapter dAeleve = new MySqlDataAdapter();
        private MySqlDataAdapter dAclasse = new MySqlDataAdapter();
        private MySqlDataAdapter dAsuppractiviteeleve = new MySqlDataAdapter();
        private MySqlDataAdapter dAinscrit = new MySqlDataAdapter();
        private MySqlDataAdapter dAdatejoach = new MySqlDataAdapter();
        private MySqlDataAdapter dAanime = new MySqlDataAdapter();
        private MySqlDataAdapter dAactivitesnoninscriteleve = new MySqlDataAdapter();
        private MySqlDataAdapter dAelevesnonvalides = new MySqlDataAdapter();
        private MySqlDataAdapter dAelevesclassevalides = new MySqlDataAdapter();
        private MySqlDataAdapter dAintervenantinfotemps = new MySqlDataAdapter();
        private MySqlDataAdapter dAactivitesansdescription = new MySqlDataAdapter();
        private MySqlDataAdapter dAleleve = new MySqlDataAdapter();
        private MySqlDataAdapter dAactiviteselevetemps = new MySqlDataAdapter();
        private MySqlDataAdapter dAnbinscritactivite = new MySqlDataAdapter();
        private MySqlDataAdapter dAdatejoachEvenement = new MySqlDataAdapter();
        private MySqlDataAdapter dAdatejoachInscriptions = new MySqlDataAdapter();
        private MySqlDataAdapter dAactivitesgestion = new MySqlDataAdapter();
        private MySqlDataAdapter dAafficherActivites = new MySqlDataAdapter();
        

        private DataTable dTactivites = new DataTable();
        private DataTable dTintervenants = new DataTable();
        private DataTable dTtype = new DataTable();
        private DataTable dTpermission = new DataTable();
        private DataTable dTconnexionUsers = new DataTable();
        private DataTable dTeleveinscritactivite = new DataTable();
        private DataTable dTactiviteseleve = new DataTable();
        private DataTable dTeleve = new DataTable();
        private DataTable dTclasse = new DataTable();
        private DataTable dTsuppractiviteeleve = new DataTable();
        private DataTable dTinscrit = new DataTable();
        private DataTable dTdatejoach = new DataTable();
        private DataTable dTanime = new DataTable();
        private DataTable dTactivitesnoninscriteleve = new DataTable();
        private DataTable dTelevesnonvalides = new DataTable();
        private DataTable dTelevesclassevalides = new DataTable();
        private DataTable dTintervenantinfotemps = new DataTable();
        private DataTable dTactivitesansdescription = new DataTable();
        private DataTable dTleleve = new DataTable();
        private DataTable dTactiviteselevetemps = new DataTable();
        private DataTable dTnbinscritactivite = new DataTable();
        private DataTable dTdatejoachEvenement = new DataTable();
        private DataTable dTdatejoachInscriptions = new DataTable();
        private DataTable dTactivitesgestion = new DataTable();
        private DataTable dTafficherActivites = new DataTable();

        #region update de la forme Gestion compte
        private DataTable dTprof = new DataTable();   //Gestion des comptes professeurs 
        private DataTable dTeleveclasse = new DataTable();//Gestion des comptes eleves
        private DataTable dTintervenantsgestion = new DataTable();//Gestion des intervenants
        private DataTable dTusersupdate = new DataTable();   

        private MySqlDataAdapter dAprof = new MySqlDataAdapter();
        private MySqlDataAdapter dAeleveclasse = new MySqlDataAdapter();
        private MySqlDataAdapter dAintervenantsgestion = new MySqlDataAdapter();
        private MySqlDataAdapter dAusersupdate = new MySqlDataAdapter();
        #endregion

        private bool connopen = false;
        private bool errgrave = false;
        private bool chargement = false;
        #endregion

        #region Accesseurs
        
        public int Indice
        {
            get { return indice; }
            set { indice = value; }
        }
        
         public bool Connopen
        {
            get { return connopen; }
        }

        public bool Errgrave
        {
            get { return errgrave; }
        }
        public bool Chargement
        {
            get { return chargement; }
        }

        #region accesseurs DataTable
        public DataTable DTactivites
        {
            get { return dTactivites; }
            set { dTactivites = value; }
        }
        public DataTable DTintervenants
        {
            get { return dTintervenants; }
            set { dTintervenants = value; }
        }
        public DataTable DTtype
        {
            get { return dTtype; }
            set { dTtype = value; }
        }
        public DataTable DTpermission
        {
            get { return dTpermission; }
            set { dTpermission = value; }
        }
        public DataTable DTeleveinscritactivite
        {
            get { return dTeleveinscritactivite; }
            set { dTeleveinscritactivite = value; }
        }
        public DataTable DTconnexionUsers
        {
            get { return dTconnexionUsers; }
            set { dTconnexionUsers = value; }
        }
        public DataTable DTactiviteseleve
        {
            get { return dTactiviteseleve; }
            set { dTactiviteseleve = value; }
        }
        public DataTable DTeleve
        {
            get { return dTeleve; }
            set { dTeleve = value; }
        }
        public DataTable DTclasse
        {
            get { return dTclasse; }
            set { dTclasse = value; }
        }
        public DataTable DTsuppractiviteeleve
        {
            get { return dTsuppractiviteeleve; }
            set { dTsuppractiviteeleve = value; }
        }
        public DataTable DTactivitesnoninscriteleve
        {
            get { return dTactivitesnoninscriteleve; }
            set { dTactivitesnoninscriteleve = value; }
        }
        public DataTable DTdatejoach
        {
            get { return dTdatejoach; }
            set { dTdatejoach = value; }
        }
        public DataTable DTinscrit
        {
            get { return dTinscrit; }
            set { dTinscrit = value; }
        }

        public DataTable DTanime
        {
            get { return dTanime; }
            set { dTanime = value; }
        }

        public DataTable DTelevesnonvalides
        {
            get { return dTelevesnonvalides; }
            set { dTelevesnonvalides = value; }
        }

        public DataTable DTelevesclassevalides
        {
            get { return dTelevesclassevalides; }
            set { dTelevesclassevalides = value; }
        }
        public DataTable DTintervenantinfotemps
        {
            get { return dTintervenantinfotemps; }
            set { dTintervenantinfotemps = value; }
        }
        public DataTable DTactivitesansdescription
        {
            get { return dTactivitesansdescription; }
            set { dTactivitesansdescription = value; }
        }
        public DataTable DTleleve
        {
            get { return dTleleve; }
            set { dTleleve = value; }
        }
        public DataTable DTactiviteselevetemps
        {
            get { return dTactiviteselevetemps; }
            set { dTactiviteselevetemps = value; }
        }
        public DataTable DTnbinscritactivite
        {
            get { return dTnbinscritactivite; }
            set { dTnbinscritactivite = value; }
        }
        public DataTable DTdatejoachEvenement
        {
            get { return dTdatejoachEvenement; }
            set { dTdatejoachEvenement = value; }
        }
        public DataTable DTdatejoachInscriptions
        {
            get { return dTdatejoachInscriptions; }
            set { dTdatejoachInscriptions = value; }
        }
        public DataTable DTactivitesgestion
        {
            get { return dTactivitesgestion; }
            set { dTactivitesgestion = value; }
        }
        public DataTable DTafficherActivites
        {
            get { return dTafficherActivites; }
            set { dTafficherActivites = value; }
        }
        #region Gestion compte
        public DataTable DTprof
        {
            get { return dTprof; }
            set { dTprof = value; }
        }
        public DataTable DTeleveclasse
        {
            get { return dTeleveclasse; }
            set { dTeleveclasse = value; }
        }
        public DataTable DTintervenantsgestion
        {
            get { return dTintervenantsgestion; }
            set { dTintervenantsgestion = value; }
        }
        public DataTable DTusersupdate
        {
            get { return dTusersupdate; }
            set { dTusersupdate = value; }
        }
        #endregion
        #endregion

        #region accesseurs MySqlDataAdapter
        public MySqlDataAdapter DAactivites
        {
            get { return dAactivites; }
            set { dAactivites = value; }
        }
        public MySqlDataAdapter DAintervenants
        {
            get { return dAintervenants; }
            set { dAintervenants = value; }
        }
        public MySqlDataAdapter DAtype
        {
            get { return dAtype; }
            set { dAtype = value; }
        }
        public MySqlDataAdapter DApermission
        {
            get { return dApermission; }
            set { dApermission = value; }
        }
        public MySqlDataAdapter DAconnexionUser
        {
            get { return dAconnexionUsers; }
            set { dAconnexionUsers = value; }
        }
        public MySqlDataAdapter DAeleveinscritactivite
        {
            get { return dAeleveinscritactivite; }
            set { dAeleveinscritactivite = value; }
        }
        public MySqlDataAdapter DAactiviteseleve
        {
            get { return dAactiviteseleve; }
            set { dAactiviteseleve = value; }
        }
        public MySqlDataAdapter DAeleve
        {
            get { return dAeleve; }
            set { dAeleve = value; }
        }
        public MySqlDataAdapter DAclasse
        {
            get { return dAclasse; }
            set { dAclasse = value; }
        }
        public MySqlDataAdapter DAsuppractiviteeleve
        {
            get { return dAsuppractiviteeleve; }
            set { dAsuppractiviteeleve = value; }
        }
        public MySqlDataAdapter DAinscrit
        {
            get { return dAinscrit; }
            set { dAinscrit = value; }
        }
        public MySqlDataAdapter DAdatejoach
        {
            get { return dAdatejoach; }
            set { dAdatejoach = value; }
        }
        public MySqlDataAdapter DAactivitesnoninscriteleve
        {
            get { return dAactivitesnoninscriteleve; }
            set { dAactivitesnoninscriteleve = value; }
        }
        public MySqlDataAdapter DAanime
        {
            get { return dAanime; }
            set { dAanime = value; }
        }
        public MySqlDataAdapter DAelevesnonvalides
        {
            get { return dAelevesnonvalides; }
            set { dAelevesnonvalides = value; }
        }
        public MySqlDataAdapter DAelevesclassevalides
        {
            get { return dAelevesclassevalides; }
            set { dAelevesclassevalides = value; }
        }
        public MySqlDataAdapter DAintervenantinfotemps
        {
            get { return dAintervenantinfotemps; }
            set { dAintervenantinfotemps = value; }
        }
        public MySqlDataAdapter DAactivitesansdescription
        {
            get { return dAactivitesansdescription; }
            set { dAactivitesansdescription = value; }
        }
        public MySqlDataAdapter DAleleve
        {
            get { return dAleleve; }
            set { dAeleve = value; }
        }
        public MySqlDataAdapter DAactiviteselevetemps
        {
            get { return dAactiviteselevetemps; }
            set { dAactiviteselevetemps = value; }
        }
        public MySqlDataAdapter DAnbinscritactivite
        {
            get { return dAnbinscritactivite; }
            set { dAnbinscritactivite = value; }
        }
        public MySqlDataAdapter DAdatejoachEvenement
        {
            get { return dAdatejoachEvenement; }
            set { dAdatejoachEvenement = value; }
        }
        public MySqlDataAdapter DAdatejoachInscriptions
        {
            get { return dAdatejoachInscriptions; }
            set { dAdatejoachInscriptions = value; }
        }
        public MySqlDataAdapter DAactivitesgestion
        {
            get { return dAactivitesgestion; }
            set { dAactivitesgestion = value; }
        }
        public MySqlDataAdapter DAafficherActivites
        {
            get { return dAafficherActivites; }
            set { dAafficherActivites = value; }
        }
        #region Gestion compte 

        public MySqlDataAdapter DAprof
        {
            get { return dAprof; }
            set { dAprof = value; }
        }
        public MySqlDataAdapter DAeleveclasse
        {
            get { return dAeleveclasse; }
            set { dAeleveclasse = value; }
        }
        public MySqlDataAdapter DAintervenantsgestion
        {
            get { return dAintervenantsgestion; }
            set { dAintervenantsgestion = value; }
        }
        public MySqlDataAdapter DAusersupdate
        {
            get { return dAusersupdate; }
            set { dAusersupdate = value; }
        }
        #endregion
        #endregion

        #endregion
        public modele()
        { }

        #region méthode seconnecter
        public void seconnecter()
        {
            string myConnectionString = ("Database=joachautrement;Data Source=localhost;User Id=root;");
            //string myConnectionString = ("Database=joachautrement;Data Source=localhost;User Id=root;Password=root;");
            myConnection = new MySqlConnection(myConnectionString);
            try // tentative
            {
                myConnection.Open();
                connopen = true;
            }
            catch (Exception err)// gestion des erreurs
            {
                MessageBox.Show("Erreur ouverture base de données : " + err, "Problème connexion", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                connopen = false; errgrave = true;
            }
        }
    
        #endregion
        #region méthode sedeconnecter
        public void sedeconnecter()
        {
            if (!connopen)
                return;
            try
            {
                myConnection.Close();
                myConnection.Dispose();
                connopen = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur fermeture base de données : " + err, "Problème deconnexion", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion

        #region connexion d'un UTILISATEUR

        public void connexionUsers(string login, string mdp)
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAconnexionUsers.SelectCommand = new MySqlCommand("select * from UTILISATEUR where LOGINU Like \"" + login + "\" AND MDPU Like '" + mdp + "' OR UPPER(LOGINU) like \"" + login + "\" AND MDPU Like '" + mdp + "' ;", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAconnexionUsers);
            try
            {
                dTconnexionUsers.Clear();
                dAconnexionUsers.Fill(dTconnexionUsers);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }

        #endregion

        #region Charger les activités
        public void charger_activites()
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAactivites.SelectCommand = new MySqlCommand("select * from activite_concat;", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAactivites);
            try
            {
                dTactivites.Clear();
                dAactivites.Fill(dTactivites);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion
        #region Charger les activités sans la description
        public void charger_activites_sansdescription()
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAactivitesansdescription.SelectCommand = new MySqlCommand("SELECT IDA, IDT, CODEA, LIBELLEA, HEUREDEBUTA, HEUREFINA, NBPLACEA, SALLE from activite_concat ORDER BY HEUREDEBUTA, HEUREFINA", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAactivitesansdescription);
            try
            {
                dTactivitesansdescription.Clear();
                dAactivitesansdescription.Fill(dTactivitesansdescription);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion
        #region Charger les intervenants
        public void charger_intervenants()
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAintervenants.SelectCommand = new MySqlCommand("select * from INTERVENANT;", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAintervenants);
            try
            {
                dTintervenants.Clear();
                dAintervenants.Fill(dTintervenants);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion
        #region Charger les types
        public void charger_types()
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAtype.SelectCommand = new MySqlCommand("select * from TYPE;", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAtype);
            try
            {
                dTtype.Clear();
                dAtype.Fill(dTtype);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion
        #region Charger les permissions
        public void charger_permissions()
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dApermission.SelectCommand = new MySqlCommand("select * from PERMISSION;", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dApermission);
            try
            {
                dTpermission.Clear();
                dApermission.Fill(dTpermission);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion
        #region Charger un élève
        public void charger_eleve(int id)
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAleleve.SelectCommand = new MySqlCommand("select * from UTILISATEUR WHERE IDU = " +  id + ";", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAleleve);
            try
            {
                dTleleve.Clear();
                dAleleve.Fill(dTleleve);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion
        #region Charger le temps total d'activité pour un élève
        public void charger_temps_eleve(int id)
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAactiviteselevetemps.SelectCommand = new MySqlCommand("select TIMEDIFF(HEUREFINA, HEUREDEBUTA) as temps from UTILISATEUR as u INNER JOIN INSCRIT as i ON u.IDU = i.IDU INNER JOIN ACTIVITE as a ON i.IDA = a.IDA WHERE u.IDU = " + id + ";", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAactiviteselevetemps);
            try
            {
                dTactiviteselevetemps.Clear();
                dAactiviteselevetemps.Fill(dTactiviteselevetemps);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion
        #region Charger les eleves
        public void charger_eleves()
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAeleve.SelectCommand = new MySqlCommand("select IDU, IDC, NOMU, PRENOMU, VALIDE, LOGINU, MDPU from UTILISATEUR WHERE IDP = 1;", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAeleve);
            try
            {
                dTeleve.Clear();
                dAeleve.Fill(dTeleve);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion
        #region Charger les classes
        public void charger_classe()
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAclasse.SelectCommand = new MySqlCommand("select * from CLASSE;", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAclasse);
            try
            {
                dTclasse.Clear();
                dAclasse.Fill(dTclasse);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion
        #region Charger les dates
        public void charger_datejoach()
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAdatejoach.SelectCommand = new MySqlCommand("select * from DATEJOACH;", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAdatejoach);
            try
            {
                dTdatejoach.Clear();
                dAdatejoach.Fill(dTdatejoach);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion
        #region Charger la table anime
        public void charger_anime()
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAanime.SelectCommand = new MySqlCommand("select * from ANIME;", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAanime);
            try
            {
                dTanime.Clear();
                dAanime.Fill(dTanime);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion
        #region Charger la table inscrit
        public void charger_inscrit()
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAinscrit.SelectCommand = new MySqlCommand("select * from INSCRIT;", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAinscrit);
            try
            {
                dTinscrit.Clear();
                dAinscrit.Fill(dTinscrit);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion
        #region Charger le nombre d'inscrit à une activité
        public void charger_nbinscrit_activite(int ida)
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAnbinscritactivite.SelectCommand = new MySqlCommand("select COUNT(IDU) from INSCRIT where IDA = " +  ida + ";", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAnbinscritactivite);
            try
            {
                dTnbinscritactivite.Clear();
                dAnbinscritactivite.Fill(dTnbinscritactivite);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion
        #region Charger les activités auxquelles un élève n'est pas inscrit
        public void charger_activites_noninscrit_eleve(int ideleve)
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAactivitesnoninscriteleve.SelectCommand = new MySqlCommand("select a.IDA, a.IDT, a.LIBELLEA, a.DESCRIPTIONA, a.HEUREDEBUTA, a.HEUREFINA, a.NBPLACEA, a.SALLE, a.CODEA From activite_concat as a where IDA NOT IN (Select IDA from INSCRIT where IDU =" + ideleve + ") ;", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAactivitesnoninscriteleve);
            try
            {
                dTactivitesnoninscriteleve.Clear();
                dAactivitesnoninscriteleve.Fill(dTactivitesnoninscriteleve);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion
        #region Charger les élèves en fonction de l'activité
        public void charger_eleve_activite_inscrits(int idactivite)
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAeleveinscritactivite.SelectCommand = new MySqlCommand("select u.IDU, NOMU, PRENOMU, c.LIBELLEC, a.LIBELLEA, a.HEUREDEBUTA, a.HEUREFINA, a.NBPLACEA, a.CODEA, a.SALLE from UTILISATEUR as u INNER JOIN INSCRIT as i ON u.IDU = i.IDU INNER JOIN activite_concat as a ON i.IDA = a.IDA INNER JOIN CLASSE as c ON u.IDC = c.IDC WHERE a.IDA = " + idactivite + ";", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAeleveinscritactivite);
            try
            {
                dTeleveinscritactivite.Clear();
                dAeleveinscritactivite.Fill(dTeleveinscritactivite);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion
        #region Charger les activités d'un élève  //initActiviteEleve de la classe activite
        public void charger_activites_eleve(int ideleve)
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAactiviteseleve.SelectCommand = new MySqlCommand("SELECT NOMU, PRENOMU, LIBELLEA, CODEA, HEUREDEBUTA,HEUREFINA, SALLE, a.IDA, a.IDT, a.NBPLACEA FROM UTILISATEUR as u INNER JOIN INSCRIT as i ON u.IDU = i.IDU INNER JOIN activite_concat as a ON i.IDA = a.IDA WHERE u.IDU = " + ideleve + ";", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAactiviteseleve);
            try
            {
                dTactiviteseleve.Clear();
                dAactiviteseleve.Fill(dTactiviteseleve);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion    
        #region Charger les liens entre les activites et l'eleve  // seulement de la table inscrit
        public void charger_inscription_eleve(int ideleve)
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAsuppractiviteeleve.SelectCommand = new MySqlCommand("SELECT * from INSCRIT WHERE IDU = " + ideleve + ";", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAsuppractiviteeleve);
            try
            {
                dTsuppractiviteeleve.Clear();
                dAsuppractiviteeleve.Fill(dTsuppractiviteeleve);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion 
        #region Charger les élèves qui ne sont pas valides Utilisation : PDFnonvalideleve
        public void charger_eleves_nonvalides()
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAelevesnonvalides.SelectCommand = new MySqlCommand("SELECT * from UTILISATEUR WHERE IDC IS NOT NULL AND Valide = 0;", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAelevesnonvalides);
            try
            {
                dTelevesnonvalides.Clear();
                dAelevesnonvalides.Fill(dTelevesnonvalides);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion 
        #region Charger les élèves d'une classe Utilisation : PDFelevesclasse
        public void charger_eleves_classe(int IDC)
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAelevesclassevalides.SelectCommand = new MySqlCommand("SELECT DISTINCT IDU, NOMU, PRENOMU, IDC, VALIDE from UTILISATEUR WHERE IDC =  " + IDC + ";", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAelevesclassevalides);
            try
            {
                dTelevesclassevalides.Clear();
                dAelevesclassevalides.Fill(dTelevesclassevalides);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion
        #region Charger les intervenants exterieurs avec leurs dates et heures de venues
        public void charger_intervenants_dateheure()
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAintervenantinfotemps.SelectCommand = new MySqlCommand("SELECT i.NOMI, i.PRENOMI, i.PROFESSIONI, i.EXTERIEUR, ac.HEUREDEBUTA, ac.HEUREFINA, i.IDI from INTERVENANT as i INNER JOIN ANIME as an ON i.IDI = an.IDI inner join activite_concat as ac ON an.IDA = ac.IDA WHERE i.EXTERIEUR= 1 ORDER BY ac.HEUREDEBUTA;", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAintervenantinfotemps);
            try
            {
                dTintervenantinfotemps.Clear();
                dAintervenantinfotemps.Fill(dTintervenantinfotemps);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion
        #region form de gestion des comptes 

        #region Charger les Professeurs, les professeurs avec impressions et les organisateurs idPermission = 2,3,4
        public void charger_tous_Professeurs()
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAprof.SelectCommand = new MySqlCommand("select u.IDU, u.NOMU, u.PRENOMU, p.LIBELLEP, u.IDP from UTILISATEUR AS u INNER JOIN PERMISSION AS p ON u.IDP = p.IDP WHERE u.IDP = 2 OR u.IDP = 3 OR u.IDP = 4;", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAprof);
            try
            {
                dTprof.Clear();
                dAprof.Fill(dTprof);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion


        #region Charger les eleves  idPermission = 1
        public void charger_eleves_Classe()
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAeleveclasse.SelectCommand = new MySqlCommand("select u.IDU, u.NOMU, u.PRENOMU, c.LIBELLEC, u.IDC, u.VALIDE from UTILISATEUR AS u INNER JOIN CLASSE as c ON u.IDC = c.IDC WHERE IDP = 1;", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAeleveclasse);
            try
            {
                dTeleveclasse.Clear();
                dAeleveclasse.Fill(dTeleveclasse);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion

        #region Charger les intervenants pour la form Gestion compte
        public void charger_intervenantsgestion()
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAintervenantsgestion.SelectCommand = new MySqlCommand("select IDI, NOMI, PRENOMI, PROFESSIONI, EXTERIEUR from INTERVENANT;", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAintervenantsgestion);
            try
            {
                dTintervenantsgestion.Clear();
                dAintervenantsgestion.Fill(dTintervenantsgestion);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion

        #region Charger tous les utilisateurs pour l'update
        public void charger_utilisateursupdate()
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAusersupdate.SelectCommand = new MySqlCommand("select * from UTILISATEUR", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAusersupdate);
            try
            {
                dTusersupdate.Clear();
                dAusersupdate.Fill(dTusersupdate);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion

        #endregion

        #region Charger les activités pour la gestion des activitées (creation modification et suppression)
        public void charger_activitesgestion()
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAactivitesgestion.SelectCommand = new MySqlCommand("select * from ACTIVITE;", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAactivitesgestion);
            try
            {
                dTactivitesgestion.Clear();
                dAactivitesgestion.Fill(dTactivitesgestion);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion
        #region Charger les activités pour afficher dans le CRUD gestion des activites
        public void charger_afficherActivites()
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAafficherActivites.SelectCommand = new MySqlCommand("select a.IDA, a.CODEA, a.LIBELLEA, a.HEUREDEBUTA, a.HEUREFINA, a.NBPLACEA, a.SALLE, d.DATEEVENEMENT,t.LIBELLET, i.NOMI, i.PRENOMI, a.RESTRICTION, a.DESCRIPTIONA, a.ENTETEDESCRIPTIONA From ACTIVITE as a INNER JOIN DATEJOACH as d ON d.IDD = a.IDD INNER JOIN ANIME ON ANIME.IDA = a.IDA INNER JOIN INTERVENANT as i ON i.IDI = ANIME.IDI INNER JOIN TYPE as t ON t.IDT = a.IDT", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAafficherActivites);
            try
            {
                dTafficherActivites.Clear();
                dAafficherActivites.Fill(dTafficherActivites);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion

        #region Charger les dates de l'evenement joach autrement
        public void charger_datejoachEvenement()
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAdatejoachEvenement.SelectCommand = new MySqlCommand("select * from DATEJOACH WHERE ESTINSCRITPROF = 0 AND ESTINSCRITELEVE = 0;", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAdatejoachEvenement);
            try
            {
                dTdatejoachEvenement.Clear();
                dAdatejoachEvenement.Fill(dTdatejoachEvenement);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion

        #region Charger les dates des Inscriptions
        public void charger_datejoachInscriptions()
        {
            if (!connopen) return; // pour vérifier que la BD est bien ouverte
            dAdatejoachInscriptions.SelectCommand = new MySqlCommand("select * from DATEJOACH WHERE ESTINSCRITPROF = 1 OR ESTINSCRITELEVE = 1;", myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dAdatejoachInscriptions);
            try
            {
                dTdatejoachInscriptions.Clear();
                dAdatejoachInscriptions.Fill(dTdatejoachInscriptions);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "Problème table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion
    }
}



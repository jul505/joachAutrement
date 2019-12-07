using JoachAutrement.Activités;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoachAutrement
{
    public class Controleur
    {
        private static modele vmodele;


        public static modele Vmodele
        {
            get { return vmodele; }
            set { vmodele = value; }
        }



        public static void init()
        {
            Vmodele = new modele();
        }


        public static bool initUsers(string login, string mdp)
        {
            Vmodele.connexionUsers(login, mdp);
            if (Vmodele.DTconnexionUsers.Rows.Count == 1) return true;
            else return false;

        }

        

        public static void retirerActivite(int idA,int idE) //Retirer un seul élève d'une activité Utilisation: Gestion élève
        {
            bool estsupprimer = false;
            int ligneEffacer = 0;
            Vmodele.charger_inscription_eleve(idE);
            for (int j = 0; j < vmodele.DTsuppractiviteeleve.Rows.Count; j++)
            {
                if (idA == Convert.ToInt32(vmodele.DTsuppractiviteeleve.Rows[j][1]) && idE == Convert.ToInt32(vmodele.DTsuppractiviteeleve.Rows[j][0]))
                {
                    estsupprimer = true;
                    vmodele.DTsuppractiviteeleve.Rows[j].Delete();
                    ligneEffacer = j;
                }
            }
            if(estsupprimer == false)
                MessageBox.Show("L'élève sélectionné n'est pas inscrit à cette activité");
            try
            {
                vmodele.DAsuppractiviteeleve.Update(vmodele.DTsuppractiviteeleve);
                MessageBox.Show("Suppression réussie");
            }
            catch(Exception err)
            {
                MessageBox.Show("Erreur lors de la suppression, code d'erreur : " + err.ToString());
            }

        }
        public static void retirerActivite(int idA, List<int> idE) //Retirer plusieurs élèves d'une activité Utilisation: Gestion Eleve
        {
            bool etreinscrit = false;
            bool areussi = true;
            int ligneEffacer = 0;
            List<int> leseleves = new List<int>();
            string eleve = "";
            foreach(int id in idE)
            {
                etreinscrit = false;
                Vmodele.charger_inscription_eleve(id);
                for (int j = 0; j < vmodele.DTsuppractiviteeleve.Rows.Count; j++)
                {
                    if (idA == Convert.ToInt32(vmodele.DTsuppractiviteeleve.Rows[j][1]) && id == Convert.ToInt32(vmodele.DTsuppractiviteeleve.Rows[j][0]))
                    {
                        etreinscrit = true;
                        vmodele.DTsuppractiviteeleve.Rows[j].Delete();
                        ligneEffacer = j;
                        try
                        {
                            vmodele.DAsuppractiviteeleve.Update(vmodele.DTsuppractiviteeleve);
                            break;
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show("Erreur lors de la suppression, code d'erreur : " + err.ToString(),"L'application a rencontré une erreur");
                            areussi = false;
                        }
                    }
                }
                if (etreinscrit == false)
                    leseleves.Add(id);
            }
            if (areussi && leseleves.Count == 0)
                MessageBox.Show("Suppressions réussies");
            else if (leseleves.Count == idE.Count)
                MessageBox.Show("Aucun élève n'est inscrit à cette activité", "Suppression impossible");
            else if(leseleves.Count > 0)
            {
                foreach(int id in leseleves)
                {
                    for(int i =0; i < Vmodele.DTeleve.Rows.Count; i++)
                    {
                        if(id == Convert.ToInt32(Vmodele.DTeleve.Rows[i]["IDU"]))
                        {
                            eleve += "\n" + Vmodele.DTeleve.Rows[i]["NOMU"].ToString() + " " + Vmodele.DTeleve.Rows[i]["PRENOMU"].ToString();
                        }
                    }
                }
                MessageBox.Show("Certains élèves n'étaient pas inscrits, néanmoins les autres élèves ont bien été supprimés de l'activité, liste des élèves n'étant pas inscrits : " + eleve);
            }
        }

        public static void ajouterEleveActivite(int idA, int idE) //Utiliser par ChoixActivite et InscrireEleve
        {
            Vmodele.charger_inscrit();
            DataRow newinscrit = vmodele.DTinscrit.NewRow();
            newinscrit["IDU"] = idE;
            newinscrit["IDA"] = idA;
            vmodele.DTinscrit.Rows.Add(newinscrit);
            try
            {
                vmodele.DAinscrit.Update(vmodele.DTinscrit);
                MessageBox.Show("Inscription réussie");
            }
            catch (MySqlException err)
            {
                MessageBox.Show("Erreur lors de l'inscription, code d'erreur : " + err.ToString());
            }

        }
        #region gestion des comptes

        public static void supprimerUsers(int indice)
        {
            vmodele.charger_utilisateursupdate();
            for (int j = 0; j < vmodele.DTusersupdate.Rows.Count; j++)
            {
                if (indice == Convert.ToInt32(vmodele.DTusersupdate.Rows[j]["IDU"]))
                {
                    try
                    {
                    vmodele.DTusersupdate.Rows[j].Delete();
                        vmodele.DAusersupdate.Update(vmodele.DTusersupdate);
                        MessageBox.Show("Suppression réussie");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Erreur lors de la suppression, code d'erreur : " + err.ToString());
                    }   
                }
            }
        }

        public static void supprimerIntervenants(int indice)
        {
            vmodele.charger_intervenants();
            for (int j = 0; j < vmodele.DTintervenants.Rows.Count; j++)
            {
                if (indice == Convert.ToInt32(vmodele.DTintervenants.Rows[j]["IDI"]))
                {
                    try
                    {
                        vmodele.DTintervenants.Rows[j].Delete();
                        vmodele.DAintervenants.Update(vmodele.DTintervenants);
                        MessageBox.Show("Suppression réussie");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Erreur lors de la suppression, code d'erreur : " + err.ToString());
                    }
                }
            }
        }

        public static void ajouterIntervenants(string nom, string prenom, string profession, bool externe)
        {
            try
            {
                vmodele.charger_intervenants();
                DataRow NouvLigne = Vmodele.DTintervenants.NewRow();
                NouvLigne["NOMI"] = nom;
                NouvLigne["PRENOMI"] = prenom;
                NouvLigne["PROFESSIONI"] = profession;
                NouvLigne["EXTERIEUR"] = externe;
                Vmodele.DTintervenants.Rows.Add(NouvLigne);
                Vmodele.DAintervenants.Update(Vmodele.DTintervenants);
                MessageBox.Show("Ajout de l'intervenant réussi");
        }
            catch (Exception err)
            {
                MessageBox.Show("Erreur lors de l'ajout, code d'erreur : " + err.ToString());
            }
        }

        public static void ajouterEleve(string nom, string prenom, int classe, string identifiant, string mdp)
        {
            try
            {
                vmodele.charger_utilisateursupdate();
                DataRow NouvLigne = Vmodele.DTusersupdate.NewRow();
                NouvLigne["IDC"] = classe;
                NouvLigne["IDP"] = 1;
                NouvLigne["NOMU"] = nom;
                NouvLigne["PRENOMU"] = prenom;
                NouvLigne["VALIDE"] = 0;
                NouvLigne["LOGINU"] = identifiant;
                NouvLigne["MDPU"] = mdp;
                Vmodele.DTusersupdate.Rows.Add(NouvLigne);
                Vmodele.DAusersupdate.Update(Vmodele.DTusersupdate);
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur lors de l'ajout, code d'erreur : " + err.ToString());
            }
        }

        public static void ajouterProf(string nom, string prenom, int permission, string identifiant, string mdp)
        {
            try
            {
                vmodele.charger_utilisateursupdate();
                DataRow NouvLigne = Vmodele.DTusersupdate.NewRow();
                NouvLigne["NOMU"] = nom;
                NouvLigne["PRENOMU"] = prenom;
                NouvLigne["IDP"] = permission;
                NouvLigne["LOGINU"] = identifiant;
                NouvLigne["MDPU"] = mdp;
                Vmodele.DTusersupdate.Rows.Add(NouvLigne);
                Vmodele.DAusersupdate.Update(Vmodele.DTusersupdate);
                
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur lors de l'ajout, code d'erreur : " + err.ToString());
            }
        }

        public static void modifierIntervenant(int idIntervenant, string nom, string prenom, string profession, bool externe)
        {
            try
            {
                vmodele.charger_intervenants();
                for (int j = 0; j < vmodele.DTintervenants.Rows.Count; j++)
                {
                    if (idIntervenant == Convert.ToInt32(vmodele.DTintervenants.Rows[j]["IDI"]))
                    {
                        vmodele.DTintervenants.Rows[j]["NOMI"] = nom;
                        vmodele.DTintervenants.Rows[j]["PRENOMI"] = prenom;
                        vmodele.DTintervenants.Rows[j]["PROFESSIONI"] = profession;
                        vmodele.DTintervenants.Rows[j]["EXTERIEUR"] = externe;
                        vmodele.DAintervenants.Update(vmodele.DTintervenants);
                    }
                }

                //MessageBox.Show("Modification réussie");
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur lors de la modification, code d'erreur : " + err.ToString());
            }

        }

        public static void modifierProf(int idProf, string nom, string prenom, int permission)
        {
            try
            {
                vmodele.charger_utilisateursupdate();
                for (int j = 0; j < vmodele.DTusersupdate.Rows.Count; j++)
                {
                    if (idProf == Convert.ToInt32(vmodele.DTusersupdate.Rows[j]["IDU"]))
                    {
                        vmodele.DTusersupdate.Rows[j]["PRENOMU"] = prenom;
                        vmodele.DTusersupdate.Rows[j]["NOMU"] = nom;
                        vmodele.DTusersupdate.Rows[j]["IDP"] = permission;


                        vmodele.DAusersupdate.Update(vmodele.DTusersupdate);
                    }
                }
                MessageBox.Show("Modification réussie");
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur lors de la modification, code d'erreur : " + err.ToString());
            }
        }

        public static void modifierEleve(int idEleve, string nom, string prenom, int classe, bool valide)
        {
            try
            {
                vmodele.charger_utilisateursupdate();

                for (int j = 0; j < vmodele.DTusersupdate.Rows.Count; j++)
                {
                    if (idEleve == Convert.ToInt32(vmodele.DTusersupdate.Rows[j]["IDU"]))
                    {
                        vmodele.DTusersupdate.Rows[j]["PRENOMU"] = prenom;
                        vmodele.DTusersupdate.Rows[j]["NOMU"] = nom;
                        vmodele.DTusersupdate.Rows[j]["IDC"] = classe;
                        vmodele.DTusersupdate.Rows[j]["VALIDE"] = valide;
                        vmodele.DAusersupdate.Update(vmodele.DTusersupdate);
                    }
                }
                MessageBox.Show("Modification réussie");
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur lors de la modification, code d'erreur : " + err.ToString());
            }

        }

        #endregion


        #region Gestion des activités
        public static void ajouterActivite(int date, int type, TimeSpan heureDebut, TimeSpan heureFin, string libelle, int nbrPlace, string salle, string description, string codeA, string entete, string pub)
        {
            try
            {
                vmodele.charger_activitesgestion();
                DataRow NouvLigne = Vmodele.DTactivitesgestion.NewRow();
                NouvLigne["IDD"] = date;
                NouvLigne["IDT"] = type;
                NouvLigne["LIBELLEA"] = libelle;
                NouvLigne["DESCRIPTIONA"] = description;
                NouvLigne["HEUREDEBUTA"] = heureDebut;
                NouvLigne["HEUREFINA"] = heureFin;
                NouvLigne["NBPLACEA"] = nbrPlace;
                NouvLigne["SALLE"] = salle;
                NouvLigne["CODEA"] = codeA;
                NouvLigne["ENTETEDESCRIPTIONA"] = entete;
                NouvLigne["RESTRICTION"] = pub;

                Vmodele.DTactivitesgestion.Rows.Add(NouvLigne);
                Vmodele.DAactivitesgestion.Update(Vmodele.DTactivitesgestion);

                
                MessageBox.Show("Ajout de l'activité réussi");
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur lors de l'ajout de l'activite, code d'erreur : " + err.ToString());
            }
            
        }
        public static void ajouterAnime(int intervenant)
        {
            int idActi = 0;
            try
            {
                vmodele.charger_activitesgestion();
                for (int i = 0; i < vmodele.DTactivitesgestion.Rows.Count; i++)
                {
                    idActi = Convert.ToInt32(vmodele.DTactivitesgestion.Rows[i]["IDA"]);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur lors de la recherche de l'ID activite, code d'erreur : " + err.ToString());
            }

            try
            {
                vmodele.charger_anime();
                DataRow NouvLigne = Vmodele.DTanime.NewRow();
                NouvLigne["IDA"] = idActi;
                NouvLigne["IDI"] = intervenant;

                Vmodele.DTanime.Rows.Add(NouvLigne);
                Vmodele.DAanime.Update(Vmodele.DTanime);
                //MessageBox.Show("Ajout de l'intervenant réussi");
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur lors de l'ajout de l'intervenant, code d'erreur : " + err.ToString());
            }
        }

        public static void modifierActivite(int id, int date, int type, TimeSpan heureDebut, TimeSpan heureFin, string libelle, int nbrPlace, string salle, string description, string entete, string pub)
        {
            try
            {
                vmodele.charger_activitesgestion();
                for (int i = 0; i < vmodele.DTactivitesgestion.Rows.Count; i++)
                {
                    if (id == Convert.ToInt32(vmodele.DTactivitesgestion.Rows[i]["IDA"]))
                    {
                        vmodele.DTactivitesgestion.Rows[i]["IDD"] = date;
                        vmodele.DTactivitesgestion.Rows[i]["IDT"] = type;
                        vmodele.DTactivitesgestion.Rows[i]["LIBELLEA"] = libelle;
                        vmodele.DTactivitesgestion.Rows[i]["DESCRIPTIONA"] = description;
                        vmodele.DTactivitesgestion.Rows[i]["HEUREDEBUTA"] = heureDebut;
                        vmodele.DTactivitesgestion.Rows[i]["HEUREFINA"] = heureFin;
                        vmodele.DTactivitesgestion.Rows[i]["NBPLACEA"] = nbrPlace;
                        vmodele.DTactivitesgestion.Rows[i]["SALLE"] = salle;
                        vmodele.DTactivitesgestion.Rows[i]["ENTETEDESCRIPTIONA"] = entete;
                        vmodele.DTactivitesgestion.Rows[i]["RESTRICTION"] = pub;
                    }
                }

                Vmodele.DAactivitesgestion.Update(Vmodele.DTactivitesgestion);
                //MessageBox.Show("Modification de l'activité réussie");
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur lors de la modification de l'activite, code d'erreur : " + err.ToString());
            }
        }
        public static void modifierAnime(int id, int intervenant)
        {
            try
            {
                vmodele.charger_anime();

                for (int i = 0; i < vmodele.DTanime.Rows.Count; i++)
                {
                    if (id == Convert.ToInt32(vmodele.DTanime.Rows[i]["IDA"]))
                    {
                        vmodele.DTanime.Rows[i]["IDI"] = intervenant;
                    }
                }


                Vmodele.DAanime.Update(Vmodele.DTanime);
                //MessageBox.Show("Modification de l'intervenant réussi");
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur lors de la modification de l'intervenant, code d'erreur : " + err.ToString());
            }
        }

        public static void supprimerActivite(int id)
        {
            vmodele.charger_anime();
            for (int j = 0; j < vmodele.DTanime.Rows.Count; j++)
            {
                if (id == Convert.ToInt32(vmodele.DTanime.Rows[j]["IDA"]))
                {
                    try
                    {
                        vmodele.DTanime.Rows[j].Delete();
                        vmodele.DAanime.Update(vmodele.DTanime);
                        //MessageBox.Show("Suppression de anime réussi");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Erreur lors de la suppression du lien entre l'activité et l'intervenant, code d'erreur : " + err.ToString());
                    }
                }
            }
            List<int> idEleve = new List<int>();
            vmodele.charger_inscrit();
            for (int j = 0; j < vmodele.DTinscrit.Rows.Count; j++)
            {
                if (id == Convert.ToInt32(vmodele.DTinscrit.Rows[j]["IDA"]))
                {
                    try
                    {
                        idEleve.Add(Convert.ToInt32(vmodele.DTinscrit.Rows[j]["IDU"]));
                        vmodele.DTinscrit.Rows[j].Delete();
                        vmodele.DAinscrit.Update(vmodele.DTinscrit);
                        //MessageBox.Show("Suppression de l'inscrit réussi");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Erreur lors de la suppression du lien entre l'élève et l'activité, code d'erreur : " + err.ToString());
                    }
                }
            }

            vmodele.charger_utilisateursupdate();
            for (int j = 0; j < vmodele.DTusersupdate.Rows.Count; j++)
            {
                foreach (int i in idEleve)
                {
                    if (i == Convert.ToInt32(vmodele.DTusersupdate.Rows[j]["IDU"]))
                    {
                        try
                        {
                            vmodele.DTusersupdate.Rows[j]["VALIDE"] = 0;
                            vmodele.DAusersupdate.Update(vmodele.DTusersupdate);
                            //MessageBox.Show("Update de la table user réussi");
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show("Erreur lors de la mise à jour de l'état de validation de l'élève, code d'erreur : " + err.ToString());
                        }
                    }
                }
            }



            vmodele.charger_activitesgestion();
            for (int j = 0; j < vmodele.DTactivitesgestion.Rows.Count; j++)
            {
                if (id == Convert.ToInt32(vmodele.DTactivitesgestion.Rows[j]["IDA"]))
                {
                    try
                    {
                        vmodele.DTactivitesgestion.Rows[j].Delete();
                        vmodele.DAactivitesgestion.Update(vmodele.DTactivitesgestion);
                        MessageBox.Show("Suppression de l'activité réussie");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Erreur lors de la suppression de l'activité, code d'erreur : " + err.ToString());
                    }
                }
            }


            
        }
        public static void sauvegardeSalles(int indice, string salle)
        {
            for (int j = 0; j < vmodele.DTactivites.Rows.Count; j++)
            {
                int test = Convert.ToInt32(vmodele.DTactivites.Rows[j]["IDA"]);
                if (test == indice)
                {
                    vmodele.DTactivites.Rows[j][8] = salle;
                }
            }
            vmodele.DAactivites.Update(vmodele.DTactivites);
        }
        #endregion


        public static void ajouterElevesActivite(List<int> idseleve, int idA) //Utiliser par InscrireEleve, cas si toute la classe sélectionné ou plusieurs éleves sélectionnés
        {
            Vmodele.charger_inscrit();
            foreach (int i in idseleve)
            {
                DataRow newinscrit = vmodele.DTinscrit.NewRow();
                newinscrit["IDU"] = i;
                newinscrit["IDA"] = idA;
                vmodele.DTinscrit.Rows.Add(newinscrit);
            }
            try
            {
                vmodele.DAinscrit.Update(vmodele.DTinscrit);
                MessageBox.Show("Inscriptions réussies");
            }
            catch (MySqlException err)
            {
                if (err.ErrorCode.ToString() == "-2147467259") //Message d'erreur lors de duplicata de clé
                    MessageBox.Show("Erreur lors de l'inscription d'un/des élève(s), celui/ceux-ci sont déja inscrit(s)");
                else
                    MessageBox.Show("Erreur lors de l'inscription, code d'erreur : " + err.ErrorCode.ToString() + "Erreur : " + err.ToString());
            }

        }
        public static void elevevalide()
        {
            Vmodele.DTleleve.Rows[0]["Valide"] = true;
            try
            {
                vmodele.DAleleve.Update(vmodele.DTleleve);
                MessageBox.Show("Validation réussie");
            }
            catch (MySqlException err)
            {
                MessageBox.Show("Erreur lors de la validation, code d'erreur : " + err.ErrorCode.ToString() + "Erreur : " + err.ToString());
            }
        }

        #region Admin
        public static void ajouterClasse(string libelleClasse)
        {
            try
            {
                vmodele.charger_classe();
                DataRow NouvLigne = Vmodele.DTclasse.NewRow();
                NouvLigne["LIBELLEC"] = libelleClasse;
                Vmodele.DTclasse.Rows.Add(NouvLigne);
                Vmodele.DAclasse.Update(Vmodele.DTclasse);
                //MessageBox.Show("Ajout de la classe réussie");
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur lors de l'ajout de la classe, code d'erreur : " + err.ToString());
            }
        }

        public static void ajouterDate(DateTime date, bool prof, bool eleve)
        {
            try
            {
                vmodele.charger_datejoachInscriptions();
                DataRow NouvLigne = Vmodele.DTdatejoachInscriptions.NewRow();
                NouvLigne["DATEEVENEMENT"] = date;
                NouvLigne["ESTINSCRITPROF"] = prof;
                NouvLigne["ESTINSCRITELEVE"] = eleve;
                NouvLigne["MATIN"] = 0;
                NouvLigne["APRESMIDI"] = 0;
                Vmodele.DTdatejoachInscriptions.Rows.Add(NouvLigne);
                Vmodele.DAdatejoachInscriptions.Update(Vmodele.DTdatejoachInscriptions);
                //MessageBox.Show("Ajout de la date réussie");
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur lors de l'ajout de la date, code d'erreur : " + err.ToString());
            }
        }
        #endregion
    }

}

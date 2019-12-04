using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JoachAutrement // forme appellé en première
{
    public partial class FormConnexion : Form
    {
        BindingSource sourceUser = new BindingSource();
        FormUsers Form1;  // forme principale
        Utilisateur User1;


        public FormConnexion()
        {
            InitializeComponent();
            Controleur.init(); // initialise la classe modele
            Controleur.Vmodele.seconnecter();  // permet la connexion à la BDD
            if (Controleur.Vmodele.Connopen == false) { MessageBox.Show("Erreur dans la connexion"); } // message d'erreur de connexion BDD
            else { MessageBox.Show("BD connectée", "Information BD", MessageBoxButtons.OK, MessageBoxIcon.Information); } // connexion OK
        }

        string id;
        string mdp;
        

        public void Btn_Connexion_Click(object sender, EventArgs e)
        {
            id = TB_Login.Text;
            mdp = TB_Mdp.Text;

            if (Controleur.initUsers(id, mdp) == true)
            {
                
                int idUser = Convert.ToInt32(Controleur.Vmodele.DTconnexionUsers.Rows[0][0]);
                int idPermission = Convert.ToInt32(Controleur.Vmodele.DTconnexionUsers.Rows[0][2]);
                string nomUser = Controleur.Vmodele.DTconnexionUsers.Rows[0][3].ToString();
                string prenomUser = Controleur.Vmodele.DTconnexionUsers.Rows[0][4].ToString();
                bool valide = false;
                if (idPermission == 1)
                {
                    if (Convert.ToInt32(Controleur.Vmodele.DTconnexionUsers.Rows[0][7]) == 1)
                    {
                        valide = true;
                    }
                }
                    


                User1 = new Utilisateur(idUser,idPermission, nomUser, prenomUser, valide);

                TB_Login.Text = "";
                TB_Mdp.Text = "";
                Form1 = new FormUsers(User1);
                Form1.ShowDialog();

            }
            else MessageBox.Show("Mot de passe incorrect", "Erreur");


        }
    }
}

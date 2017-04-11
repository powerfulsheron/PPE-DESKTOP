using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maquette_Belle_Table_Final;
using System.Net.Mail;
using NHibernate;
using NHibernate.Cfg;

namespace Maquette_Belle_Table
{
    public partial class Popup_ModifUser : Form
    {
        private static ISessionFactory sessionFactory = null;

        public Utilisateur utilisateur = new Utilisateur();

        public Popup_ModifUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Popup_ModifUser.ActiveForm.Close();
        }

        private void radioButtonCom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonAdm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonUti_CheckedChanged(object sender, EventArgs e)
        {

        }
       
        private void buttonValCom_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Modifier((TypeUtilisateur)comboBoxTypeUser.SelectedItem, textBoxLog.Text, textBoxNom.Text, textBoxPre.Text,
                    textBoxEm.Text, textBoxTel.Text, textBoxRue.Text, textBoxVille.Text, textBoxCp.Text, textBoxPortefeuille.Text,
                    utilisateur, checkBoxChangeMdp.Checked));
        }

        static string Modifier(TypeUtilisateur unTypeUtilisateur, string loginUtilisateur, string nomUtilisateur, string prenomUtilisateur, 
            string mailUtilisateur, string telUtilisateur, string adresseUtilisateur,string villeUtilisateur, string cpUtilisateur, string libellePortefeuille, 
            Utilisateur utilisateur, bool changePassword)
        {
            string motdepasse="reste le même.";

            sessionFactory = new Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            using (ITransaction transaction = session.BeginTransaction())
            {
                
                if (loginUtilisateur != null) utilisateur.loginUtilisateur = loginUtilisateur; else return "Merci d'entrer un login d'utilisateur";
                if (nomUtilisateur != null) utilisateur.nomUtilisateur = nomUtilisateur; else return "Merci d'entrer un nom d'utilisateur";
                if (prenomUtilisateur != null) utilisateur.prenomUtilisateur = prenomUtilisateur; else return "Merci d'entrer un prénom d'utilisateur";
                if (mailUtilisateur != null) utilisateur.mailUtilisateur = mailUtilisateur; else return "Merci d'entrer un mail d'utilisateur";
                if (telUtilisateur != null) utilisateur.telUtilisateur = telUtilisateur; else return "Merci d'entrer un numéro téléphone d'utilisateur";
                if (adresseUtilisateur != null) utilisateur.adresseUtilisateur = adresseUtilisateur; else return "Merci d'entrer une adresse d'utilisateur";
                if (villeUtilisateur != null) utilisateur.villeUtilisateur = villeUtilisateur; else return "Merci d'entrer une ville d'utilisateur";
                if (cpUtilisateur != null) utilisateur.cpUtilisateur = cpUtilisateur; else return "Merci d'entrer un code postal d'utilisateur";

                //S'il s'agit d'une modifcation pour commercial
                if (unTypeUtilisateur.codeTypeUtilisateur == 3 && libellePortefeuille != "")
                {
                    //si l'utilisateur n'etait pas un commercial avant
                    if (utilisateur.typeUtilisateur.codeTypeUtilisateur != 3)
                    {
                        Planning unNouveauPlanning = new Planning();
                        PorteFeuille unNouveauPortefeuille = new PorteFeuille();
                        unNouveauPlanning.utilisateur = utilisateur;
                        unNouveauPortefeuille.utilisateur = utilisateur;
                        unNouveauPortefeuille.libellePortefeuille = libellePortefeuille;

                        utilisateur.planning = unNouveauPlanning;
                        utilisateur.porteFeuille = unNouveauPortefeuille;
                        
                    }
                    else utilisateur.porteFeuille.libellePortefeuille = libellePortefeuille;

                }
                else if (unTypeUtilisateur.codeTypeUtilisateur == 3 && libellePortefeuille == "") return "Merci de rentrer un nom de portefeuille";

                //Après une migration d'un commercial vers un autre type, on supprime son affectation au planning et portefeuille
                else if (unTypeUtilisateur.codeTypeUtilisateur != 3)
                {
                    utilisateur.porteFeuille = null;
                    utilisateur.planning = null;
                }
                //Une fois tous les tests bons, on peut affecter le type:
                utilisateur.typeUtilisateur = unTypeUtilisateur;

                if (changePassword == true)
                {
                    //-------------------- DEBUT BLOC GENERATION DU MOT DE PASSE DU NOUVEL UTILISATEUR--------------------------
                    //On génère un mot de passe aléatoire pour le nouvel Utilisateur
                    Random random = new Random();
                    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                    motdepasse = new string(Enumerable.Repeat(chars, 10).Select(s => s[random.Next(s.Length)]).ToArray());
                    // on converti la phrase random en md5
                    InterLogin pourMD5 = new InterLogin();
                    //on associe le mot de passe
                    utilisateur.passwordUtilisateur = pourMD5.MD5Hash(motdepasse);
                    //-------------------- FIN BLOC GENERATION DU MOT DE PASSE DU NOUVEL UTILISATEUR--------------------------
                }
                session.SaveOrUpdate(utilisateur);
                transaction.Commit();
                session.Dispose();

            }
           

 

            // Une fois que tous les tests sont validés on envoie le MDP au mail du nouvel utilisateur
            MailMessage mail = new MailMessage();
            mail.Subject = "Utilisateur modifié!";
            mail.Body = "Votre utilisateur a été modifié par l'administrateur" + utilisateur.nomUtilisateur + " " + utilisateur.prenomUtilisateur + 
                "! Votre mot de passe " + motdepasse;
            mail.From = new MailAddress("bot@belletable.com");
            mail.To.Add(utilisateur.mailUtilisateur);

            SmtpClient client = new SmtpClient();
            client.Host = "localhost";
            client.Send(mail);

            return "L'utilisateur a été modifié, un email lui a été envoyé.";


        }

        private void panelTypeP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Popup_ModifUser_Load(object sender, EventArgs e)
        {
            TypeUtilisateur lesTypesUtilisateur = new TypeUtilisateur();
            comboBoxTypeUser.DataSource = lesTypesUtilisateur.GetLesTypesUtilisateur();
        }

        private void Popup_ModifUser_Load_1(object sender, EventArgs e)
        {
           
            TypeUtilisateur lesTypesUtilisateur = new TypeUtilisateur();
            comboBoxTypeUser.DataSource = lesTypesUtilisateur.GetLesTypesUtilisateur();
            comboBoxTypeUser.SelectedItem = comboBoxTypeUser.Items[utilisateur.typeUtilisateur.codeTypeUtilisateur-1];
            
            textBoxLog.Text = utilisateur.loginUtilisateur;
            textBoxCp.Text = utilisateur.cpUtilisateur;
            textBoxEm.Text = utilisateur.mailUtilisateur;
            textBoxNom.Text = utilisateur.nomUtilisateur;
            textBoxPre.Text = utilisateur.prenomUtilisateur;
            textBoxRue.Text = utilisateur.adresseUtilisateur;
            textBoxTel.Text = utilisateur.telUtilisateur;
            textBoxVille.Text = utilisateur.villeUtilisateur;

            
            
        }

        private void comboBoxTypeUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeUtilisateur forCombobox = (TypeUtilisateur)comboBoxTypeUser.SelectedItem;
            if (forCombobox.codeTypeUtilisateur == 3)
            {
                textBoxPortefeuille.Enabled = true;
                labelPortefeuille.Enabled = true;
                textBoxPortefeuille.Text = utilisateur.porteFeuille.libellePortefeuille;
            }
            else
            {
                textBoxPortefeuille.Enabled = false;
                labelPortefeuille.Enabled = false;
                textBoxPortefeuille.Text = "";
            }
        }

        
    }

}

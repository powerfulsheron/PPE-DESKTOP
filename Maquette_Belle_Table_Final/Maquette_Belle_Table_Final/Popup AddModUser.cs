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
    public partial class Popup_AddModUser : Form
    {
        private static ISessionFactory sessionFactory = null;

        public Popup_AddModUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Popup_AddModUser.ActiveForm.Close();
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
        //Bouton Annuler sur Profil Admin


        //Bouton Annuler sur Profil Commercial
       

        //Bouton Valider sur Profil Commercial
        private void buttonValCom_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AjouterUtilisateur((TypeUtilisateur)comboBoxTypeUser.SelectedItem, textBoxLog.Text, textBoxNom.Text, textBoxPre.Text, textBoxEm.Text, textBoxTel.Text, textBoxRue.Text,
                textBoxVille.Text, textBoxCp.Text, textBoxPortefeuille.Text));
        }

        static string AjouterUtilisateur(TypeUtilisateur unTypeUtilisateur, string loginUtilisateur, string nomUtilisateur, string prenomUtilisateur, string mailUtilisateur, string telUtilisateur, string adresseUtilisateur,
            string villeUtilisateur, string cpUtilisateur, string libellePortefeuille)
        {

            sessionFactory = new Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();

            Utilisateur unNouvelUtilisateur = new Utilisateur();
            string motdepasse;

            Planning unNouveauPlanning = new Planning();
            PorteFeuille unNouveauPortefeuille = new PorteFeuille();

            using (ITransaction transaction = session.BeginTransaction())
            {

                unNouvelUtilisateur.typeUtilisateur = unTypeUtilisateur;
                if (loginUtilisateur != null) unNouvelUtilisateur.loginUtilisateur = loginUtilisateur; else return "Merci d'entrer un login d'utilisateur";
                if (nomUtilisateur != null) unNouvelUtilisateur.nomUtilisateur = nomUtilisateur; else return "Merci d'entrer un nom d'utilisateur";
                if (prenomUtilisateur != null) unNouvelUtilisateur.prenomUtilisateur = prenomUtilisateur; else return "Merci d'entrer un prénom d'utilisateur";
                if (mailUtilisateur != null) unNouvelUtilisateur.mailUtilisateur = mailUtilisateur; else return "Merci d'entrer un mail d'utilisateur";
                if (telUtilisateur != null) unNouvelUtilisateur.telUtilisateur = telUtilisateur; else return "Merci d'entrer un numéro téléphone d'utilisateur";
                if (adresseUtilisateur != null) unNouvelUtilisateur.adresseUtilisateur = adresseUtilisateur; else return "Merci d'entrer une adresse d'utilisateur";
                if (villeUtilisateur != null) unNouvelUtilisateur.villeUtilisateur = villeUtilisateur; else return "Merci d'entrer une ville d'utilisateur";
                if (cpUtilisateur != null) unNouvelUtilisateur.cpUtilisateur = cpUtilisateur; else return "Merci d'entrer un code postal d'utilisateur";

                //-------------------- DEBUT BLOC GENERATION DU MOT DE PASSE DU NOUVEL UTILISATEUR--------------------------
                //On génère un mot de passe aléatoire pour le nouvel Utilisateur
                Random random = new Random();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                motdepasse = new string(Enumerable.Repeat(chars, 10).Select(s => s[random.Next(s.Length)]).ToArray());
                // on converti la phrase random en md5
                InterLogin pourMD5 = new InterLogin();
                //on associe le mot de passe
                unNouvelUtilisateur.passwordUtilisateur = pourMD5.MD5Hash(motdepasse);
                //-------------------- FIN BLOC GENERATION DU MOT DE PASSE DU NOUVEL UTILISATEUR--------------------------

                //S'il s'agit d'un commercial:
                if (unNouvelUtilisateur.typeUtilisateur.codeTypeUtilisateur == 3)
                {

                    unNouveauPlanning.utilisateur = unNouvelUtilisateur;
                    unNouveauPortefeuille.utilisateur = unNouvelUtilisateur;
                    unNouveauPortefeuille.libellePortefeuille = libellePortefeuille;

                    unNouvelUtilisateur.planning = unNouveauPlanning;
                    unNouvelUtilisateur.porteFeuille = unNouveauPortefeuille;

                    session.Save(unNouvelUtilisateur);
                    session.Save(unNouveauPlanning);
                    session.Save(unNouveauPortefeuille);


                }
                else
                {
                    //On sauvegarde le nouvel utilisateur
                    session.Save(unNouvelUtilisateur);

                }

                transaction.Commit();
                session.Dispose();

            }

 

            // Une fois que tout fonctionne on envoie le MDP au mail du nouvel utilisateur
            MailMessage mail = new MailMessage();
            mail.Subject = "Nouvel accès à GEPEV!";
            mail.Body = "Bienvenue " + unNouvelUtilisateur.nomUtilisateur + " " + unNouvelUtilisateur.prenomUtilisateur + "! Votre mot de passe est: " + motdepasse;
            mail.From = new MailAddress("bot@belletable.com");
            mail.To.Add(unNouvelUtilisateur.mailUtilisateur);

            SmtpClient client = new SmtpClient();
            client.Host = "localhost";
            client.Send(mail);

            return "L'utilisateur a été crée et un mail lui a été envoyé.";


        }

        private void panelTypeP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Popup_AddModUser_Load(object sender, EventArgs e)
        {
            TypeUtilisateur lesTypesUtilisateur = new TypeUtilisateur();
            comboBoxTypeUser.DataSource = lesTypesUtilisateur.GetLesTypesUtilisateur();
        }

        private void Popup_AddModUser_Load_1(object sender, EventArgs e)
        {
            TypeUtilisateur lesTypesUtilisateur = new TypeUtilisateur();
            comboBoxTypeUser.DataSource = lesTypesUtilisateur.GetLesTypesUtilisateur();
        }

        private void comboBoxTypeUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeUtilisateur forCombobox = (TypeUtilisateur)comboBoxTypeUser.SelectedItem;
            if (forCombobox.codeTypeUtilisateur == 3)
            {
                textBoxPortefeuille.Enabled = true;
                labelPortefeuille.Enabled = true;
            }
            else
            {
                textBoxPortefeuille.Enabled = false;
                labelPortefeuille.Enabled = false;
            }
        }

        
    }

}

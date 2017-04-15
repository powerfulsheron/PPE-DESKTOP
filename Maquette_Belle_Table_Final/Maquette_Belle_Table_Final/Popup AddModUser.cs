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
        // La form parente
        private InterAd interAd = null;
        // L'utilisateur passé dans la form
        public Utilisateur utilisateur = new Utilisateur();
        // Instanciations pour traitement
        public Utilisateur unNouvelUtilisateur = new Utilisateur();
        public PorteFeuille unNouveauPortefeuille = new PorteFeuille();
        public Planning unNouveauPlanning = new Planning();

        public Popup_AddModUser()
        {
            InitializeComponent();
        }

        public Popup_AddModUser(InterAd interAdCall)
        {
            interAd = interAdCall as InterAd;
            InitializeComponent();
        }

        public Popup_AddModUser(InterAd interAdCall, Utilisateur utilisateur)
        {
            interAd = interAdCall as InterAd;
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

        private void buttonValCom_Click(object sender, EventArgs e)
        {
          //  try{
            AjouterUtilisateur((TypeUtilisateur)comboBoxTypeUser.SelectedItem, textBoxLog.Text, textBoxNom.Text, textBoxPre.Text,
                textBoxEm.Text, textBoxTel.Text, textBoxRue.Text, textBoxVille.Text, textBoxCp.Text, textBoxPortefeuille.Text, textBoxPlanning.Text, checkBoxChangeMdp.Checked);
            MessageBox.Show("Opération Réussie");
         //  }catch(Exception ex)
     //       {
      //      MessageBox.Show("Erreur"+ex.Message);
        //    }  
                interAd.ChargerDatagridUti();
                this.Close();
            
        }

        private void AjouterUtilisateur(TypeUtilisateur unTypeUtilisateur, string loginUtilisateur, string nomUtilisateur, string prenomUtilisateur, string mailUtilisateur, string telUtilisateur, string adresseUtilisateur,
            string villeUtilisateur, string cpUtilisateur, string libellePortefeuille, string libellePlanning, bool changePassword)
        {

            sessionFactory = new Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();

            string motdepasse="";
            string erreur = "";
       //     try
     //       {
                // si il s'agit d'une modification
            if (utilisateur.numUtilisateur != unNouvelUtilisateur.numUtilisateur)
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    unNouvelUtilisateur = utilisateur;

                    //S'il s'agit d'une modification en commercial
                    if (unTypeUtilisateur.codeTypeUtilisateur == 3)
                    {
                        //si l'utilisateur n'etait pas un commercial avant
                        if (unNouvelUtilisateur.typeUtilisateur.codeTypeUtilisateur != 3)
                        {
                            Planning unNouveauPlanning = new Planning();
                            unNouveauPlanning.libellePlanning = libellePlanning;
                            unNouveauPlanning.utilisateur = unNouvelUtilisateur;
                            session.SaveOrUpdate(unNouveauPlanning);

                            PorteFeuille unNouveauPortefeuille = new PorteFeuille();
                            unNouveauPortefeuille.libellePortefeuille = libellePortefeuille;
                            unNouveauPortefeuille.utilisateur = unNouvelUtilisateur;
                            session.SaveOrUpdate(unNouveauPortefeuille);

                            unNouvelUtilisateur.planning = unNouveauPlanning;
                            unNouvelUtilisateur.porteFeuille = unNouveauPortefeuille;
                            session.SaveOrUpdate(unNouvelUtilisateur);

                        }
                        // sinon si il etait commercial
                        else
                        {
                            Planning unNouveauPlanning = unNouvelUtilisateur.planning;
                            unNouveauPlanning.libellePlanning = libellePlanning;
                            session.SaveOrUpdate(unNouveauPlanning);

                            PorteFeuille unNouveauPortefeuille = unNouvelUtilisateur.porteFeuille;
                            unNouveauPortefeuille.libellePortefeuille = libellePortefeuille;
                            session.SaveOrUpdate(unNouveauPortefeuille);
                        }

                    }
                    else if (unTypeUtilisateur.codeTypeUtilisateur == 3 && libellePortefeuille == "" || libellePlanning == "") erreur += "\nMerci de rentrer un nom de portefeuille/planning";

                    //Après une migration d'un commercial vers un autre type, on supprime son affectation au planning et portefeuille
                    else if (unTypeUtilisateur.codeTypeUtilisateur != 3)
                    {
                        //On supprime l'idUtilisateur dans la table portefeuille et planning
                        PorteFeuille portefeuille = unNouvelUtilisateur.porteFeuille;
                        Planning planning = utilisateur.planning;
                        portefeuille.utilisateur = null;
                        planning.utilisateur = null;

                        session.SaveOrUpdate(portefeuille);
                        session.SaveOrUpdate(planning);


                        //On supprime l'idPortefeuille/idPlanning dans la table Utilsiateur
                        unNouvelUtilisateur.porteFeuille = null;
                        unNouvelUtilisateur.planning = null;

                    }
                    //Une fois tous les tests bons, on peut affecter le type:
                    unNouvelUtilisateur.typeUtilisateur = unTypeUtilisateur;



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
                        unNouvelUtilisateur.passwordUtilisateur = pourMD5.MD5Hash(motdepasse);
                        //-------------------- FIN BLOC GENERATION DU MOT DE PASSE DU NOUVEL UTILISATEUR--------------------------
                    }
                    session.SaveOrUpdate(unNouvelUtilisateur);
                    transaction.Commit();
                    session.Dispose();
                }
            }
            // Sinon si il s'agit d'un ajout
            else
            {
                using (ITransaction transaction = session.BeginTransaction())
                {

                    unNouvelUtilisateur.typeUtilisateur = unTypeUtilisateur;
                    if (loginUtilisateur != null) unNouvelUtilisateur.loginUtilisateur = loginUtilisateur; else erreur += "\nMerci d'entrer un login d'utilisateur";
                    if (nomUtilisateur != null) unNouvelUtilisateur.nomUtilisateur = nomUtilisateur; else erreur += "\nMerci d'entrer un nom d'utilisateur";
                    if (prenomUtilisateur != null) unNouvelUtilisateur.prenomUtilisateur = prenomUtilisateur; else erreur += "\nMerci d'entrer un prénom d'utilisateur";
                    if (mailUtilisateur != null) unNouvelUtilisateur.mailUtilisateur = mailUtilisateur; else erreur += "\nMerci d'entrer un mail d'utilisateur";
                    if (telUtilisateur != null) unNouvelUtilisateur.telUtilisateur = telUtilisateur; else erreur += "\nMerci d'entrer un numéro téléphone d'utilisateur";
                    if (adresseUtilisateur != null) unNouvelUtilisateur.adresseUtilisateur = adresseUtilisateur; else erreur += "\nMerci d'entrer une adresse d'utilisateur";
                    if (villeUtilisateur != null) unNouvelUtilisateur.villeUtilisateur = villeUtilisateur; else erreur += "\nMerci d'entrer une ville d'utilisateur";
                    if (cpUtilisateur != null) unNouvelUtilisateur.cpUtilisateur = cpUtilisateur; else erreur += "\nMerci d'entrer un code postal d'utilisateur";

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
                    if (unNouvelUtilisateur.typeUtilisateur.codeTypeUtilisateur == 3 && (libellePlanning!=null||libellePortefeuille!=null))
                    {

                        unNouveauPlanning.libellePlanning = libellePlanning;
                        unNouveauPortefeuille.libellePortefeuille = libellePortefeuille;

                        unNouveauPlanning.utilisateur = unNouvelUtilisateur;
                        unNouveauPortefeuille.utilisateur = unNouvelUtilisateur;


                        unNouvelUtilisateur.planning = unNouveauPlanning;
                        unNouvelUtilisateur.porteFeuille = unNouveauPortefeuille;


                        session.SaveOrUpdate(unNouvelUtilisateur);
                        session.SaveOrUpdate(unNouveauPlanning);
                        session.SaveOrUpdate(unNouveauPortefeuille);
                    }
                    else
                    {
                        //On sauvegarde le nouvel utilisateur
                        session.SaveOrUpdate(unNouvelUtilisateur);

                    }

                    transaction.Commit();
                    session.Dispose();

                }
            }
       //     }
     //       catch (Exception ex)
       //    {
        //        MessageBox.Show(ex.Message+erreur);
       //     }

            try{
 

            // Une fois que tout fonctionne on envoie le MDP au mail du nouvel utilisateur
            MailMessage mail = new MailMessage();
            mail.Subject = "Nouvel accès à GEPEV!";
            mail.Body = "Bienvenue " + unNouvelUtilisateur.nomUtilisateur + " " + unNouvelUtilisateur.prenomUtilisateur + "! Votre mot de passe est: " + motdepasse;
            mail.From = new MailAddress("bot@belletable.com");
            mail.To.Add(unNouvelUtilisateur.mailUtilisateur);

            SmtpClient client = new SmtpClient();
            client.Host = "localhost";
            client.Send(mail);

        }catch(Exception ex){
            MessageBox.Show("Erreur" + ex.Message);
        }



        }

        private void panelTypeP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCom_Paint(object sender, PaintEventArgs e)
        {

        }


        private void comboBoxTypeUser_SelectedIndexChanged(object sender, EventArgs e){

            TypeUtilisateur forCombobox = (TypeUtilisateur)comboBoxTypeUser.SelectedItem;
            if (forCombobox.codeTypeUtilisateur == 3)
            {
      
                labelAjouterPlanningPortefeuille.Visible = true;
                radioButtonNon.Visible = true;
                radioButtonOui.Visible = true;
                
            }
            else
            {
                labelAjouterPlanningPortefeuille.Visible = false;
                radioButtonNon.Visible = false;
                radioButtonNon.Visible = false;
            }
        }

        private void Popup_AddModUser_Load_1(object sender, EventArgs e)
        {
            // si c'est une modification
            if (utilisateur.numUtilisateur != unNouvelUtilisateur.numUtilisateur)
            {
                TypeUtilisateur lesTypesUtilisateur = new TypeUtilisateur();
                comboBoxTypeUser.DataSource = lesTypesUtilisateur.GetLesTypesUtilisateur();

                foreach (TypeUtilisateur t in comboBoxTypeUser.Items)
                {
                    if (t.libelleTypeUtilisateur == utilisateur.typeUtilisateur.libelleTypeUtilisateur)
                    {
                        comboBoxTypeUser.SelectedItem = t;
                    }
                }

                textBoxLog.Text = utilisateur.loginUtilisateur;
                textBoxCp.Text = utilisateur.cpUtilisateur;
                textBoxEm.Text = utilisateur.mailUtilisateur;
                textBoxNom.Text = utilisateur.nomUtilisateur;
                textBoxPre.Text = utilisateur.prenomUtilisateur;
                textBoxRue.Text = utilisateur.adresseUtilisateur;
                textBoxTel.Text = utilisateur.telUtilisateur;
                textBoxVille.Text = utilisateur.villeUtilisateur;
                checkBoxChangeMdp.Visible = true;
                
                // si il est commercial
                if (utilisateur.typeUtilisateur.codeTypeUtilisateur == 3)
                {
                    labelAjouterPlanningPortefeuille.Visible = false;
                    radioButtonNon.Visible = false;
                    radioButtonOui.Visible = false;

                    if (utilisateur.planning != null)
                    {
                        textBoxPlanning.Visible = true;
                        labelPlanning.Visible = true;
                        textBoxPlanning.Text = utilisateur.planning.libellePlanning;
                    }
                    if (utilisateur.porteFeuille != null)
                    {
                        textBoxPortefeuille.Visible = true;
                        labelPortefeuille.Visible = true;
                        textBoxPortefeuille.Text = utilisateur.porteFeuille.libellePortefeuille;
                    }
                }
             
            }
            else
            {

                TypeUtilisateur lesTypesUtilisateur = new TypeUtilisateur();
                comboBoxTypeUser.DataSource = lesTypesUtilisateur.GetLesTypesUtilisateur();              
            }
        }

        private void radioButtonOui_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPortefeuille.Visible = true;
            labelPortefeuille.Visible = true;
            textBoxPlanning.Visible = true;
            labelPlanning.Visible = true;
        }

        private void radioButtonNon_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPortefeuille.Visible = false;
            labelPortefeuille.Visible = false;
            textBoxPlanning.Visible = false;
            labelPlanning.Visible = false;
        }


        
    }

}

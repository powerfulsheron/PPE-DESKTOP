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
        
            
                using (ITransaction transaction = session.BeginTransaction())
                {
                    // si c'est une modification
                    if (utilisateur.typeUtilisateur!=null)
                    {
                    //S'il s'agit d'une modification en commercial
                    if (unTypeUtilisateur.codeTypeUtilisateur == 3)
                    {
                        //si l'utilisateur n'etait pas un commercial avant
                        if (utilisateur.typeUtilisateur.codeTypeUtilisateur != 3)
                        {
                            Planning unNouveauPlanning = new Planning();
                            unNouveauPlanning.libellePlanning = libellePlanning;
                            unNouveauPlanning.utilisateur = utilisateur;
                            session.SaveOrUpdate(unNouveauPlanning);

                            PorteFeuille unNouveauPortefeuille = new PorteFeuille();
                            unNouveauPortefeuille.libellePortefeuille = libellePortefeuille;
                            unNouveauPortefeuille.utilisateur = utilisateur;
                            session.SaveOrUpdate(unNouveauPortefeuille);

                            utilisateur.planning = unNouveauPlanning;
                            utilisateur.porteFeuille = unNouveauPortefeuille;
                            session.SaveOrUpdate(utilisateur);

                        }
                        // sinon si il etait commercial
                        else
                        {
                            utilisateur.planning.libellePlanning = libellePlanning;
                            session.SaveOrUpdate(utilisateur.planning);

                            utilisateur.porteFeuille.libellePortefeuille = libellePortefeuille;
                            session.SaveOrUpdate(utilisateur.porteFeuille);                         
                        }

                    }

                    //Après une migration d'un commercial vers un autre type, on supprime son affectation au planning et portefeuille
                     if (unTypeUtilisateur.codeTypeUtilisateur != 3 && utilisateur.typeUtilisateur.codeTypeUtilisateur ==3)
                    {
                        //On supprime l'idUtilisateur dans la table portefeuille et planning
                        utilisateur.porteFeuille.utilisateur = null;
                        utilisateur.planning.utilisateur = null;

                        session.SaveOrUpdate(utilisateur.porteFeuille);
                        session.SaveOrUpdate(utilisateur.planning);


                        //On supprime l'idPortefeuille/idPlanning dans la table Utilsiateur
                        utilisateur.porteFeuille = null;
                        utilisateur.planning = null;

                    }
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

                    if (loginUtilisateur != null) utilisateur.loginUtilisateur = loginUtilisateur; else erreur += "\nMerci d'entrer un login d'utilisateur";
                    if (nomUtilisateur != null) utilisateur.nomUtilisateur = nomUtilisateur; else erreur += "\nMerci d'entrer un nom d'utilisateur";
                    if (prenomUtilisateur != null) utilisateur.prenomUtilisateur = prenomUtilisateur; else erreur += "\nMerci d'entrer un prénom d'utilisateur";
                    if (mailUtilisateur != null) utilisateur.mailUtilisateur = mailUtilisateur; else erreur += "\nMerci d'entrer un mail d'utilisateur";
                    if (telUtilisateur != null) utilisateur.telUtilisateur = telUtilisateur; else erreur += "\nMerci d'entrer un numéro téléphone d'utilisateur";
                    if (adresseUtilisateur != null) utilisateur.adresseUtilisateur = adresseUtilisateur; else erreur += "\nMerci d'entrer une adresse d'utilisateur";
                    if (villeUtilisateur != null) utilisateur.villeUtilisateur = villeUtilisateur; else erreur += "\nMerci d'entrer une ville d'utilisateur";
                    if (cpUtilisateur != null) utilisateur.cpUtilisateur = cpUtilisateur; else erreur += "\nMerci d'entrer un code postal d'utilisateur";


                    bool exist = session.QueryOver<Utilisateur>().Where(x => x.numUtilisateur == utilisateur.numUtilisateur).RowCount() > 0;
                    if(!exist)
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

                    //S'il s'agit d'un commercial:
                    if (utilisateur.typeUtilisateur.codeTypeUtilisateur == 3 && (libellePlanning!=null||libellePortefeuille!=null))
                    {

                        unNouveauPlanning.libellePlanning = libellePlanning;
                        unNouveauPortefeuille.libellePortefeuille = libellePortefeuille;

                        unNouveauPlanning.utilisateur = utilisateur;
                        unNouveauPortefeuille.utilisateur = utilisateur;


                        utilisateur.planning = unNouveauPlanning;
                        utilisateur.porteFeuille = unNouveauPortefeuille;

    
                        session.SaveOrUpdate(unNouveauPlanning);
                        session.SaveOrUpdate(unNouveauPortefeuille);
                    }
                              
                    session.SaveOrUpdate(utilisateur);
                    transaction.Commit();
                    session.Dispose();
                }
            
            try{
 

            // Une fois que tout fonctionne on envoie le MDP au mail du nouvel utilisateur
            MailMessage mail = new MailMessage();
            mail.Subject = "Nouvel accès à GEPEV!";
            mail.Body = "Bienvenue " + utilisateur.nomUtilisateur + " " + utilisateur.prenomUtilisateur + "! Votre mot de passe est: " + motdepasse;
            mail.From = new MailAddress("bot@belletable.com");
            mail.To.Add(utilisateur.mailUtilisateur);

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
                textBoxPlanning.Visible = false;
                textBoxPortefeuille.Visible = false;
                labelPlanning.Visible = false;
                labelPortefeuille.Visible = false;
            }
        }

        private void Popup_AddModUser_Load_1(object sender, EventArgs e)
        {       
                TypeUtilisateur lesTypesUtilisateur = new TypeUtilisateur();
                comboBoxTypeUser.DataSource = lesTypesUtilisateur.GetLesTypesUtilisateur();

                if(utilisateur.typeUtilisateur!=null){
                foreach (TypeUtilisateur t in comboBoxTypeUser.Items)
                {
                    if (t.libelleTypeUtilisateur == utilisateur.typeUtilisateur.libelleTypeUtilisateur)
                    {
                        comboBoxTypeUser.SelectedItem = t;
                    }
                }
                }
        

        if(utilisateur.loginUtilisateur!=null)
                textBoxLog.Text = utilisateur.loginUtilisateur;

        if(utilisateur.cpUtilisateur!=null)
                textBoxCp.Text = utilisateur.cpUtilisateur;

        if(utilisateur.mailUtilisateur!=null)
                textBoxEm.Text = utilisateur.mailUtilisateur;

        if(utilisateur.adresseUtilisateur!=null)
                textBoxRue.Text = utilisateur.adresseUtilisateur;

        if(utilisateur.telUtilisateur!=null)
                textBoxTel.Text = utilisateur.telUtilisateur;

        if(utilisateur.nomUtilisateur!=null)
                textBoxNom.Text = utilisateur.nomUtilisateur;

        if(utilisateur.prenomUtilisateur!=null)
                textBoxPre.Text = utilisateur.prenomUtilisateur;

        if(utilisateur.villeUtilisateur!=null)
                   textBoxVille.Text = utilisateur.villeUtilisateur;
              

                checkBoxChangeMdp.Visible = true;
                if (utilisateur.typeUtilisateur != null)
                {
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

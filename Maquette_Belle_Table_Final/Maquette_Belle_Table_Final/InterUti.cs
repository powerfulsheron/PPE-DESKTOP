using Maquette_Belle_Table;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Linq;

namespace Maquette_Belle_Table_Final
{
    public partial class InterUti : Form
    {
        private static ISessionFactory sessionFactory = new Configuration().Configure().BuildSessionFactory();
    
        public Utilisateur utilisateur { get; set; }
        
   
        public InterUti()
        {
            InitializeComponent();
            Load += new EventHandler(InterUti_Load);         
        }
        public void InterUti_Load(object sender, System.EventArgs e)
        {
            chargerCalendar();
            chargerDatagridInterlocuteurs();
        }

        private void labelFermeture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //---------------------> * Rubrique Planning * <---------------------

        private void buttonNRDV_Click(object sender, EventArgs e)
        {
            //Partie code destiné à ajouter un nouveau RDV
            PopNouveauRDV popNouveauRDV = new PopNouveauRDV();
            popNouveauRDV.utilisateur = utilisateur;
            popNouveauRDV.Show();
        }

        //---------------------> * Fin Rubrique Planning * <---------------------

        //---------------------> * Rubrique Plannification Congés* <---------------------

        private void buttonNPC_Click(object sender, EventArgs e)
        {
            Popup_NewC popupNewC = new Popup_NewC(this);
            popupNewC.utilisateur = utilisateur;
            popupNewC.Show();
        }

        //---------------------> * Fin Rubrique Plannification Congés * <---------------------

        //---------------------> * Rubrique Portefeuille * <---------------------

        private void buttonAddCli_Click(object sender, EventArgs e)
        {
            Popup_NewClient popupNewclient = new Popup_NewClient();
            popupNewclient.utilisateur = utilisateur;
            popupNewclient.interUti = this;
            popupNewclient.Show();
        }

        private void buttonModCli_Click(object sender, EventArgs e)
        {
            Popup_ModifierClient popupModifierClient = new Popup_ModifierClient();
            popupModifierClient.utilisateur = utilisateur;
    
            popupModifierClient.isIndividu = radioButtonIndividu.Checked;

            if (radioButtonInterlocuteurStructure.Checked)
            {
                popupModifierClient.interlocuteur = ((InterlocuteurStructure)dataGridViewInterlocuteurStructure.CurrentRow.DataBoundItem).interlocuteur;
                popupModifierClient.interlocuteurStructure = (InterlocuteurStructure)dataGridViewInterlocuteurStructure.CurrentRow.DataBoundItem;
            }

            if (radioButtonIndividu.Checked)
            {
                popupModifierClient.interlocuteur = ((Individu)dataGridViewPortefeuille.CurrentRow.DataBoundItem).interlocuteur;
                popupModifierClient.individu = (Individu)dataGridViewPortefeuille.CurrentRow.DataBoundItem;
            }

            popupModifierClient.Show();
        }

        private void buttonEnvoiMail_Click(object sender, EventArgs e)
        {
            new Maquette_Belle_Table.Popup_Mail().Show();
            
        }


        //---------------------> * Fin Rubrique Portefeuille * <---------------------

        //---------------------> * Rubrique Mails * <---------------------

        private void buttonEnvoiEmail_Click(object sender, EventArgs e)
        {
            new Maquette_Belle_Table.Popup_Mail().Show();
        }

        private void buttonOuvrirEmail_Click(object sender, EventArgs e)
        {
            Popup_Mail popMail = new Popup_Mail();
            popMail.mail = (Mail)dataGridViewMail.CurrentRow.DataBoundItem;
            popMail.Show();
        }


        //---------------------> * Fin Rubrique Mails * <---------------------

        //---------------------> * Rubrique Changer de mot de passe * <---------------------

        private void buttonValCDMDP_Click(object sender, EventArgs e)
        {
            InterGes pourChangerMDP = new InterGes();
            if (textBoxNewMDP.Text == textBoxNewMDP2.Text)
            {
                if (pourChangerMDP.ChangerMotDePasse(utilisateur, textBoxOldPswd.Text, textBoxNewMDP.Text) == true) MessageBox.Show("Votre mot de passe a été changé.", "Action réussie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else MessageBox.Show("Mauvais mot de passe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Les nouveaux de passe ne correspondent pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    
        //---------------------> * Fin Rubrique Changer de mot de passe * <---------------------
        public void chargerCalendar() 
        {

            List<DateTime> lesDates = new List<DateTime>();
            ISession session = sessionFactory.OpenSession();
            using (ITransaction transaction = session.BeginTransaction())
            {            


                foreach (Conge conge in utilisateur.lesConges)
                {

                    for (DateTime date = conge.dateDebutConge; date <= conge.dateFinConge; date = date.AddDays(1))
                    {
                        lesDates.Add(date);
                    }

                }
                foreach (DateTime date in lesDates)
                {
                    Console.WriteLine(date);
                }
                DateTime[] sourceDate = new DateTime[lesDates.Count()];
                for (int i = 0; i < lesDates.Count(); i++)
                {
                    sourceDate[i] = lesDates[i];
                }
                monthCalendarPlanC.BoldedDates = sourceDate;
                session.Dispose();

            }
        }

        public void chargerDatagridInterlocuteurs()
        {

            ISession session = sessionFactory.OpenSession();
            using (ITransaction transaction = session.BeginTransaction())
            {

                dataGridViewPortefeuille.DataSource = session.CreateQuery(@"select e from Individu e where e.interlocuteur.porteFeuille.idPorteFeuille =:idPorteFeuille").SetInt32("idPorteFeuille", utilisateur.porteFeuille.idPorteFeuille).List<Individu>();
                dataGridViewInterlocuteurStructure.DataSource = session.CreateQuery(@"select e from InterlocuteurStructure e where e.interlocuteur.porteFeuille.idPorteFeuille =:idPorteFeuille").SetInt32("idPorteFeuille", utilisateur.porteFeuille.idPorteFeuille).List<InterlocuteurStructure>();

                //dataGridViewPortefeuille.DataSource = session.CreateQuery(@"select e from Individu where e.interlocuteur.portefeuille.idPorteFeuille=:num").SetInt32("num",utilisateur.porteFeuille.idPorteFeuille).List<Individu>();
                dataGridViewMail.DataSource = utilisateur.lesMails.ToList<Mail>();
                //IList<Mail> test = utilisateur.lesMails.ToList<Mail>();
                /*
                foreach (Mail mail in test)
                {
                    dataGridViewMail.Columns.Add("Expediteur", "Expediteur");
                    dataGridViewMail.Rows.Add(mail.interlocuteur.mailInterlocuteur);
                    dataGridViewMail.Columns.Add("Object", "Object");
                    dataGridViewMail.Rows.Add(mail.objetMail);
                }
                */
             //   session.Dispose();
            }
        }

        private void panelMail_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panelPortefeuille_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewPortefeuille_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dataGridViewInterlocuteurStructure.ClearSelection();

        }

        private void panelPlanning_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewInterlocuteurStructure_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewPortefeuille.ClearSelection();
        }

        private void dataGridViewPortefeuille_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewInterlocuteurStructure.ClearSelection();
        }

        private void dataGridViewPortefeuille_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridViewInterlocuteurStructure.ClearSelection();
        }

        private void dataGridViewInterlocuteurStructure_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridViewPortefeuille.ClearSelection();
        }

        private void radioButtonInterlocuteurStructure_CheckedChanged(object sender, EventArgs e)
        {
            labelParticulier.Visible = false;
            dataGridViewPortefeuille.ClearSelection();
            dataGridViewPortefeuille.Enabled = false;
            dataGridViewPortefeuille.Visible = false;

            labelStracture.Visible = true;
            dataGridViewInterlocuteurStructure.Enabled = true;
            dataGridViewInterlocuteurStructure.Visible = true;
        }

        private void radioButtonIndividu_CheckedChanged(object sender, EventArgs e)
        {
            labelParticulier.Visible = true;
            dataGridViewPortefeuille.Enabled = true;
            dataGridViewPortefeuille.Visible = true;

            labelStracture.Visible = false;
            dataGridViewInterlocuteurStructure.ClearSelection();
            dataGridViewInterlocuteurStructure.Enabled = false;
            dataGridViewInterlocuteurStructure.Visible = false;
            
        }
    }
}

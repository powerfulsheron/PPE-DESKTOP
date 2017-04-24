using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maquette_Belle_Table;

namespace Maquette_Belle_Table_Final
{
    public partial class InterGes : Form
    {
        private static ISessionFactory sessionFactory = new Configuration().Configure().BuildSessionFactory();
       
        PorteFeuille lesPorteFeuilles = new PorteFeuille();
        DataGridView leDataGrid = new DataGridView();
        public Utilisateur utilisateur { get; set; }

        public InterGes()
        {
            InitializeComponent();
        }

        private void labelFermeture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAddCom_Click(object sender, EventArgs e)
        {
            Popup_NewCom Popup_NewCom = new Popup_NewCom();
            Popup_NewCom.utilisateur = utilisateur;
            Popup_NewCom.Show();
            //Bouton Ajouter Commercial
            new Popup_NewCom().Show();
        }

        private void buttonModCom_Click(object sender, EventArgs e)
        {
            //Bouton Modifier Commercial
            new Popup_NewCom().Show();
        }

        private void buttonSupCom_Click(object sender, EventArgs e)
        {
            //Bouton Supprimer Commercial
            dataGridViewCom.Rows.Remove(dataGridViewCom.CurrentRow);
        }

        private void buttonVRDV_Click(object sender, EventArgs e)
        {
            //Bouton Voir RDV Commercial
            new Popup_VoirRDV().Show();
        }

        private void buttonVM_Click(object sender, EventArgs e)
        {
            if (dataGridViewMail.SelectedRows.Count == 1)
            {
                Popup_Mail popMail = new Popup_Mail();
                popMail.mail = (Mail)dataGridViewMail.CurrentRow.DataBoundItem;
                popMail.Show();
            }
            else MessageBox.Show("Merci de selectionner un mail");
        }

        private void buttonCPF_Click(object sender, EventArgs e)
        {
            //Bouton Créer Portefeuille
            new Popup_NewPF().Show();
        }

        private void buttonModPF_Click(object sender, EventArgs e)
        {
            //Bouton Modifier Portefeuille
            new Popup_NewPF().Show();
        }

        private void buttonSupPF_Click(object sender, EventArgs e)
        {
            //Bouton Supprimer Portefeuille
            dataGridViewPF.Rows.Remove(dataGridViewPF.CurrentRow);
        }

        private void buttonModAssoInter_Click(object sender, EventArgs e)
        {
            if(dataGridViewPFIIS.Visible == true)
            {
                leDataGrid = dataGridViewPFIIS;
            }
            if (dataGridViewPFII.Visible == true)
            {
                leDataGrid = dataGridViewPFII;
            }

            if (leDataGrid.SelectedRows.Count == 1)
            {
                MessageBox.Show("Selectionnez le nouveau portefeuille de l'interlocuteur puis validez ou annulez l'action.");
                dataGridViewPFIIS.Visible = false;
                dataGridViewPFII.Visible = false;
                buttonValidAsso.Visible = true;
                buttonAnnuler.Visible = true;
                buttonModAssoInter.Visible = false;
                groupBoxTypeClient.Enabled = false;
            }
            else MessageBox.Show("Merci de sélectionner un interlocuteur");
        }

        private void buttonValidAsso_Click(object sender, EventArgs e)
        {
           if (dataGridViewPFIP.SelectedRows.Count == 1)
            {
                if (radioButtonIndividu.Checked == true)
                {
                    Individu individuModif = (Individu)leDataGrid.CurrentRow.DataBoundItem;
                    MessageBox.Show("Vous allez associer: " + individuModif + " avec " + (PorteFeuille)dataGridViewPFIP.CurrentRow.DataBoundItem);

                    Interlocuteur pourList = new Interlocuteur();
                    IList < Interlocuteur > lesInterlocuteurs = pourList.GetLesInterlocuteurs();

                    foreach(Interlocuteur interlocuteur in lesInterlocuteurs)
                    {
                        if(interlocuteur.idInterlocuteur == individuModif.interlocuteur.idInterlocuteur)
                        {
                            ISession session = sessionFactory.OpenSession();
                            using (ITransaction transaction = session.BeginTransaction())
                            {
                                interlocuteur.porteFeuille = (PorteFeuille)dataGridViewPFIP.CurrentRow.DataBoundItem;
                                session.Update(interlocuteur);
                                transaction.Commit();
                            }
                            MessageBox.Show("Assosiattion réussie.");
                            ChargerDataGridViewPFII();
                            buttonValidAsso.Visible = false;
                            buttonAnnuler.Visible = false;
                            buttonModAssoInter.Visible = true;
                            groupBoxTypeClient.Enabled = true;
                            dataGridViewPFII.Visible = true;
                        }
                    }

                    
                }
                else if(radioButtonInterlocuteurStructure.Checked == true)
                {
                    InterlocuteurStructure interStructModif = (InterlocuteurStructure)leDataGrid.CurrentRow.DataBoundItem;
                    MessageBox.Show("Vous allez associer: " + interStructModif + " avec " + (PorteFeuille)dataGridViewPFIP.CurrentRow.DataBoundItem);

                    Interlocuteur pourList = new Interlocuteur();
                    IList<Interlocuteur> lesInterlocuteurs = pourList.GetLesInterlocuteurs();

                    foreach (Interlocuteur interlocuteur in lesInterlocuteurs)
                    {
                        if (interlocuteur.idInterlocuteur == interStructModif.interlocuteur.idInterlocuteur)
                        {
                            ISession session = sessionFactory.OpenSession();
                            using (ITransaction transaction = session.BeginTransaction())
                            {
                                interlocuteur.porteFeuille = (PorteFeuille)dataGridViewPFIP.CurrentRow.DataBoundItem;
                                session.Update(interlocuteur);
                                transaction.Commit();
                            }
                            MessageBox.Show("Assosiattion réussie.");
                            ChargerDataGridViewPFIIS();
                            buttonValidAsso.Visible = false;
                            buttonAnnuler.Visible = false;
                            buttonModAssoInter.Visible = true;
                            groupBoxTypeClient.Enabled = true;
                            dataGridViewPFIIS.Visible = true;
                        }
                    }

                } 
            }
            else MessageBox.Show("Merci de sélectionner un portefeuille");
        }

        private void buttonModAssCom_Click(object sender, EventArgs e)
        {
            if (dataGridViewCommerciaux.SelectedRows.Count == 1)
            {
                MessageBox.Show("Merci de séléctionner le nouveau portefeuille pour le commercial.");
                dataGridViewCommerciaux.Visible = false;
                buttonAssoCom.Visible = false;
                buttonAssoPortefeuille.Visible = false;
                buttonValidAssoCom.Visible = true;
                buttonCancelAssoCom.Visible = true;
            }
            else MessageBox.Show("Vous devez sélectionner un commercial.");
        }

        private void buttonValidAssoCom_Click(object sender, EventArgs e)
        {
            if (dataGridViewPortefeuilles.SelectedRows.Count == 1)
            {
                PorteFeuille leportefeuille = (PorteFeuille)dataGridViewPortefeuilles.CurrentRow.DataBoundItem;

                if (leportefeuille.utilisateur == null)
                {
                    Utilisateur lutilisateur = (Utilisateur)dataGridViewCommerciaux.CurrentRow.DataBoundItem;

                    MessageBox.Show("Vous allez associer le portefeuille: " + leportefeuille + " à " + lutilisateur);

                    ISession session = sessionFactory.OpenSession();
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        leportefeuille.utilisateur = null;
                        lutilisateur.porteFeuille = leportefeuille;
                        session.Update(leportefeuille);
                        session.Update(lutilisateur);
                        transaction.Commit();
                    }
                    MessageBox.Show("Nouveau portefeuille associé au commercial");
                }
                else if (leportefeuille.utilisateur != null) MessageBox.Show("Portefeuille déjà attribué à " + leportefeuille.utilisateur);
                
            }
            else MessageBox.Show("Merci de séléctionner un nouveau portefeuille à associer");
        }

        private void buttonCancelAssoCom_Click(object sender, EventArgs e)
        {
            dataGridViewCommerciaux.Visible = true;
            buttonAssoCom.Visible = true;
            buttonAssoPortefeuille.Visible = true;
            buttonValidAssoCom.Visible = false;
            buttonCancelAssoCom.Visible = false;
        }
        private void buttonValCDMDP_Click(object sender, EventArgs e)
        {
            
            if (textBoxNewMDP.Text == textBoxNewMDP2.Text)
            {
                if (ChangerMotDePasse(utilisateur, textBoxOldPswd.Text, textBoxNewMDP.Text) == true) MessageBox.Show("Votre mot de passe a été changé.", "Action réussie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else MessageBox.Show("Mauvais mot de passe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Les nouveaux de passe ne correspondent pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public bool ChangerMotDePasse(Utilisateur unUtilisateur, string ancienMotDePasse, string nouveauMotDePasse)
        {
            sessionFactory = new Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            
            using (ITransaction transaction = session.BeginTransaction())
            {

                Utilisateur e = session.Get<Utilisateur>(unUtilisateur.numUtilisateur);
                InterLogin pourMD5 = new InterLogin();
                if (e.passwordUtilisateur == pourMD5.MD5Hash(ancienMotDePasse))
                {
                    e.passwordUtilisateur = pourMD5.MD5Hash(nouveauMotDePasse);
                    unUtilisateur.passwordUtilisateur = pourMD5.MD5Hash(nouveauMotDePasse);
                    session.SaveOrUpdate(e);
                    transaction.Commit();
                    session.Dispose();
                    sessionFactory.Close();
                    return true;
                }
                else return false;
            }
        }

        private void textBoxLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelPlanning_Paint(object sender, PaintEventArgs e)
        {
           dataGridViewCom.DataSource = utilisateur.GetLesUtilisateurs(3);
        }

        private void InterGes_Load(object sender, EventArgs e)
        {
            ChargerDataGridViewCommerciaux(dataGridViewCommerciaux);
            ChargerDataGridViewCommerciaux(dataGridViewCom);
            ChargerDataGridViewPortefeuilles(dataGridViewPortefeuilles);
            ChargerDataGridViewPortefeuilles(dataGridViewPF);

            ISession session = sessionFactory.OpenSession();

            dataGridViewCommerciaux.ClearSelection();
            dataGridViewPortefeuilles.ClearSelection();

            ChargerDataGridViewPFII();
            ChargerDataGridViewPFIIS();
            ChargerDataGridViewPFIP();
        }

        //Pour éviter de répeter les instructions sur différentsataGrid affichant des commerciaux:
        private void ChargerDataGridViewCommerciaux(DataGridView unDataGridViewPourCommerciaux)
        {
            unDataGridViewPourCommerciaux.DataSource = utilisateur.GetLesUtilisateurs(3);
            unDataGridViewPourCommerciaux.Columns[0].Visible = false;
            unDataGridViewPourCommerciaux.Columns[2].Visible = false;
            unDataGridViewPourCommerciaux.Columns[3].Visible = false;
            unDataGridViewPourCommerciaux.Columns[4].Visible = false;
            unDataGridViewPourCommerciaux.Columns[5].Visible = false;
            unDataGridViewPourCommerciaux.Columns[7].Visible = false;
            unDataGridViewPourCommerciaux.Columns[9].Visible = false;
            unDataGridViewPourCommerciaux.Columns[10].Visible = false;
            unDataGridViewPourCommerciaux.Columns[11].Visible = false;
            unDataGridViewPourCommerciaux.Columns[12].Visible = false;
            unDataGridViewPourCommerciaux.Columns[14].Visible = false;
            unDataGridViewPourCommerciaux.Columns[15].Visible = false;
            unDataGridViewPourCommerciaux.Columns[16].Visible = false;
        }

        private void ChargerDataGridViewPortefeuilles(DataGridView unDataGridViewPourPF)
        {
            unDataGridViewPourPF.DataSource = lesPorteFeuilles.GetLesPortefeuilles();
            unDataGridViewPourPF.Columns[2].Visible = false;
            unDataGridViewPourPF.Columns[3].Visible = false;
            unDataGridViewPourPF.Visible = true;
        }

        private void ChargerDataGridViewPFII()
        {
            ISession session = sessionFactory.OpenSession();
            dataGridViewPFII.DataSource = session.CreateQuery(@"select e from Individu e").List<Individu>();
        }

        private void ChargerDataGridViewPFIIS()
        {
            ISession session = sessionFactory.OpenSession();
            dataGridViewPFIIS.DataSource = session.CreateQuery(@"select e from InterlocuteurStructure e").List<InterlocuteurStructure>();
        }

        private void ChargerDataGridViewPFIP()
        {
            dataGridViewPFIP.DataSource = lesPorteFeuilles.GetLesPortefeuilles();
        }
        //dataGridViewCommerciaux:
        private void dataGridViewPFC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //dataGridViewPortefeuilles:
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    
        }

        //dataGridViewPortefeuilles:
        private void dataGridViewPortefeuilles_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void panelPFC_Paint(object sender, PaintEventArgs e)
        {
            //dataGridViewCommerciaux.ClearSelection();
            //dataGridViewPortefeuilles.ClearSelection();
        }

        private void dataGridViewCommerciaux_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridViewPortefeuilles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //la couleur de dataGridViewPortefeuilles devient bleu, la couleur de dataGridViewCommerciaux sera verte
            dataGridViewCommerciaux.DefaultCellStyle.SelectionBackColor = Color.GreenYellow;
            dataGridViewPortefeuilles.DefaultCellStyle.SelectionBackColor = Color.Blue;

            //On charge le portefeuille selectionné dans 'lePortefeuilleSelected'
            PorteFeuille lePortefeuilleSelected = (PorteFeuille)dataGridViewPortefeuilles.CurrentRow.DataBoundItem;

            //On parcours le dataGridViewCommerciaux à la recherche du même 'lePortefeuilleSelected.idPortefeuille' que celui selectionné
            foreach (DataGridViewRow row in dataGridViewCommerciaux.Rows)
            {
                Utilisateur leCommercial = (Utilisateur)row.DataBoundItem;
                //Si on trouve on selectionne le champ correspondant
                if (lePortefeuilleSelected.idPorteFeuille == leCommercial.porteFeuille.idPorteFeuille)
                {
                    row.Selected = true;
                }
                else if (row.Selected == true) row.Selected = false; //sinon on le désélectionne
            }
        }

        private void dataGridViewCommerciaux_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //la couleur de dataGridViewCommerciaux devient bleu, la coleur de dataGridViewPortefeuilles sera verte
            dataGridViewCommerciaux.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridViewPortefeuilles.DefaultCellStyle.SelectionBackColor = Color.GreenYellow;

            //On charge le commercial selectionné dans 'leCommercialSelected'
            Utilisateur leCommercialSelected = (Utilisateur)dataGridViewCommerciaux.CurrentRow.DataBoundItem;

            //On parcours le dataGridViewPortefeuilles à la recherche du même 'leCommercialSelected.numUtilisateur' que celui présent dans portefeuille
            foreach (DataGridViewRow row in dataGridViewPortefeuilles.Rows)
            {
                PorteFeuille lePortefeuille = (PorteFeuille)row.DataBoundItem;
                //Si on trouve on selectionne le champ correspondant
                if (leCommercialSelected.numUtilisateur == lePortefeuille.utilisateur.numUtilisateur)
                {
                    row.Selected = true;
                }
                else if (row.Selected == true) row.Selected = false; //sinon on le désélectionne
            }
        }

        private void radioButtonInterlocuteurStructure_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewPFII.ClearSelection();
            dataGridViewPFII.Enabled = false;
            dataGridViewPFII.Visible = false;
            dataGridViewPFIIS.Enabled = true;
            dataGridViewPFIIS.Visible = true;
            ChargerDataGridViewPFIIS();
        }

        private void radioButtonIndividu_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewPFIIS.ClearSelection();
            dataGridViewPFIIS.Enabled = false;
            dataGridViewPFIIS.Visible = false;
            dataGridViewPFII.Enabled = true;
            dataGridViewPFII.Visible = true;
            ChargerDataGridViewPFII();
        }

        private void dataGridViewPFIP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPFII.Visible == true)
            {
               //On charge le portefeuille selectionné dans 'lePortefeuilleSelected'
                PorteFeuille lePortefeuilleSelected = (PorteFeuille)dataGridViewPFIP.CurrentRow.DataBoundItem;
                ISession session = sessionFactory.OpenSession();
                dataGridViewPFII.DataSource = session.CreateQuery(@"select e from Individu e where e.interlocuteur.porteFeuille.idPorteFeuille =:idPorteFeuille
                ").SetInt32("idPorteFeuille", lePortefeuilleSelected.idPorteFeuille).List<Individu>();

            }
            else if (dataGridViewPFIIS.Visible == true)
            {
              
                //On charge le portefeuille selectionné dans 'lePortefeuilleSelected'
                PorteFeuille lePortefeuilleSelected = (PorteFeuille)dataGridViewPFIP.CurrentRow.DataBoundItem;
                ISession session = sessionFactory.OpenSession();
                dataGridViewPFIIS.DataSource = session.CreateQuery(@"select e from InterlocuteurStructure e where e.interlocuteur.porteFeuille.idPorteFeuille =:idPorteFeuille
                ").SetInt32("idPorteFeuille", lePortefeuilleSelected.idPorteFeuille).List<InterlocuteurStructure>();
            }
        }

        private void buttonCrPF_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewPF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewPF.DefaultCellStyle.SelectionBackColor = Color.Blue;
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            ChargerDataGridViewPFII();
            ChargerDataGridViewPFIIS();
            buttonValidAsso.Visible = false;
            buttonAnnuler.Visible = false;
            buttonModAssoInter.Visible = true;
        }

        private void buttonLoadAll_Click(object sender, EventArgs e)
        {
            dataGridViewPFIP.ClearSelection();
            if (radioButtonIndividu.Checked == true) ChargerDataGridViewPFII();
            else ChargerDataGridViewPFIIS();
        }

        private void buttonAssoPortefeuille_Click(object sender, EventArgs e)
        {
            if (dataGridViewPortefeuilles.SelectedRows.Count == 1)
            {
                MessageBox.Show("Merci de séléctionner le nouveau commercial pour le portefeuille.");
                dataGridViewPortefeuilles.Visible = false;
                buttonAssoPortefeuille.Visible = false;
                buttonAssoCom.Visible = false;
                buttonValidAssoPortefeuille.Visible = true;
                buttonCancelAssoPortefeuille.Visible = true;
            }
            else MessageBox.Show("Vous devez sélectionner un portefeuille.");
        }

        private void buttonValidAssoPortefeuille_Click(object sender, EventArgs e)
        {
            if (dataGridViewCommerciaux.SelectedRows.Count == 1)
            {
                Utilisateur lutilisateur = (Utilisateur)dataGridViewCommerciaux.CurrentRow.DataBoundItem;

                if (lutilisateur.porteFeuille == null)
                {
                    PorteFeuille lePortefeuille = (PorteFeuille)dataGridViewPortefeuilles.CurrentRow.DataBoundItem;

                    MessageBox.Show("Vous allez associer le comercial: " + lutilisateur + " au portefeuille " + lePortefeuille);

                    ISession session = sessionFactory.OpenSession();
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        lutilisateur.porteFeuille = null;
                        lePortefeuille.utilisateur = lutilisateur;
                        session.Update(lutilisateur);
                        session.Update(lePortefeuille);
                        transaction.Commit();
                    }
                    MessageBox.Show("Nouveau commercial associé au portefeuille");
                }
                else if (lutilisateur.porteFeuille != null) MessageBox.Show("Le commercial possède déjà un portefeuille: " + lutilisateur.porteFeuille);

            }
            else MessageBox.Show("Merci de séléctionner un nouveau commercial à associer");
        }

        private void buttonCancelAssoPortefeuille_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewCom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //On charge le commercial selectionné dans 'leCommercialSelected'
            Utilisateur leCommercialSelected = (Utilisateur)dataGridViewCom.CurrentRow.DataBoundItem;
            dataGridViewMail.DataSource = leCommercialSelected.lesMails.ToList<Mail>();
            dataGridViewRDV.DataSource = leCommercialSelected.planning.lesRendezVous.ToList<RendezVous>();
            
        }
    }
}

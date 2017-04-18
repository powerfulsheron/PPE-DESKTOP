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

namespace Maquette_Belle_Table_Final
{
    public partial class InterGes : Form
    {
        private static ISessionFactory sessionFactory = new Configuration().Configure().BuildSessionFactory();
        ISession session = sessionFactory.OpenSession();
        PorteFeuille lesPorteFeuilles = new PorteFeuille();
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
            //Bouton Voir Mails Commercial
            new Popup_VoirMails().Show();
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
            //Bouton Modifier Association Interlocuteur
            new Popup_NewInter().Show();
        }

        private void buttonModAssCom_Click(object sender, EventArgs e)
        {
            //Bouton Modifier Association Commercial
            new Popup_AssoCom().Show();
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
            ChargerDataGridViewPortefeuilles();
            ISession session = sessionFactory.OpenSession();


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

        private void ChargerDataGridViewPortefeuilles()
        {
            dataGridViewPortefeuilles.DataSource = lesPorteFeuilles.GetLesPortefeuilles();
            dataGridViewPortefeuilles.Columns[2].Visible = false;
            dataGridViewPortefeuilles.Columns[3].Visible = false;
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
            dataGridViewCommerciaux.ClearSelection();
            dataGridViewPortefeuilles.ClearSelection();
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
        }

        private void radioButtonIndividu_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewPFIIS.ClearSelection();
            dataGridViewPFIIS.Enabled = false;
            dataGridViewPFIIS.Visible = false;
            dataGridViewPFII.Enabled = true;
            dataGridViewPFII.Visible = true;
        }

        private void dataGridViewPFIP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPFII.Visible == true)
            {
                //la couleur de dataGridViewPortefeuilles devient bleu, la couleur de dataGridViewCommerciaux sera verte
                dataGridViewPFII.DefaultCellStyle.SelectionBackColor = Color.GreenYellow;
                dataGridViewPFIP.DefaultCellStyle.SelectionBackColor = Color.Blue;

                //On charge le portefeuille selectionné dans 'lePortefeuilleSelected'
                PorteFeuille lePortefeuilleSelected = (PorteFeuille)dataGridViewPFIP.CurrentRow.DataBoundItem;

                //On parcours le dataGridViewCommerciaux à la recherche du même 'lePortefeuilleSelected.idPortefeuille' que celui selectionné
                foreach (DataGridViewRow row in dataGridViewPFII.Rows)
                {
                    Individu unIndividu = (Individu)row.DataBoundItem;
                    //Si on trouve on selectionne le champ correspondant
                    if (lePortefeuilleSelected.idPorteFeuille == unIndividu.interlocuteur.porteFeuille.idPorteFeuille)
                    {
                        row.Selected = true;
                    }
                    else if (row.Selected == true) row.Selected = false; //sinon on le désélectionne
                }

            }
            else if (dataGridViewPFIIS.Visible == true)
            {
                //la couleur de dataGridViewPortefeuilles devient bleu, la couleur de dataGridViewCommerciaux sera verte
                dataGridViewPFIIS.DefaultCellStyle.SelectionBackColor = Color.GreenYellow;
                dataGridViewPFIP.DefaultCellStyle.SelectionBackColor = Color.Blue;

                //On charge le portefeuille selectionné dans 'lePortefeuilleSelected'
                PorteFeuille lePortefeuilleSelected = (PorteFeuille)dataGridViewPFIP.CurrentRow.DataBoundItem;

                //On parcours le dataGridViewCommerciaux à la recherche du même 'lePortefeuilleSelected.idPortefeuille' que celui selectionné
                foreach (DataGridViewRow row in dataGridViewPFIIS.Rows)
                {
                    InterlocuteurStructure uneStructure = (InterlocuteurStructure)row.DataBoundItem;
                    //Si on trouve on selectionne le champ correspondant
                    if (lePortefeuilleSelected.idPorteFeuille == uneStructure.interlocuteur.porteFeuille.idPorteFeuille)
                    {
                        row.Selected = true;
                    }
                    else if (row.Selected == true) row.Selected = false; //sinon on le désélectionne
                }

            }
        }
    }
}

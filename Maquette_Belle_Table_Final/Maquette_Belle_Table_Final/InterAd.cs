using Maquette_Belle_Table;
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
    public partial class InterAd : Form
    {

        private static ISessionFactory sessionFactory = null;
        public Utilisateur utilisateur { get; set; }
        public InterAd()
        {
            InitializeComponent();
            Load += new EventHandler(InterAd_Load);
        }

        private void InterUti_Load(object sender, System.EventArgs e)
        {
            ChargerDatagridUti();          
        }

        private void labelFermeture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //---------------------> * Rubrique Utilisateur * <---------------------

        private void buttonAddUti_Click(object sender, EventArgs e)
        {
            //Bouton Ajouter Utilisateur (Affiche le PopupAddModUser)
            Popup_AddModUser addUser = new Popup_AddModUser(this);
            addUser.Show();

        }

        private void buttonModUti_Click(object sender, EventArgs e)
        {
            //Bouton Modifier Utilisateur (Affiche le PopupAddModUser)
            Popup_AddModUser popup_AddModUser = new Popup_AddModUser(this);
            popup_AddModUser.utilisateur = (Utilisateur)dataGridViewUti.CurrentRow.DataBoundItem;
            popup_AddModUser.Show();
        }

        private void buttonSuppUti_Click(object sender, EventArgs e)
        {
            //Bouton Supprimer Utilisateur
            
            Utilisateur userToDelete = (Utilisateur)dataGridViewUti.CurrentRow.DataBoundItem;
            DialogResult dialogResult = MessageBox.Show("Êtes vous sûr de vouloir supprimer "+ userToDelete.nomUtilisateur + "?", "Supprimer", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                sessionFactory = new Configuration().Configure().BuildSessionFactory();
                using (ISession session = sessionFactory.OpenSession())
                {
                    // début transaction 
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        if(userToDelete.typeUtilisateur.codeTypeUtilisateur != 3)
                        {
                            userToDelete.planning = null;
                            userToDelete.porteFeuille = null;
                        }
                        session.Delete(userToDelete);
                        session.Flush();
                        transaction.Commit();
                    }
                }
                ChargerDatagridUti();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void dataGridViewUti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        

        private void dataGridViewHC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

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

        private void panelTitre_Paint(object sender, PaintEventArgs e)
        {
        }

        private void tabPageUti_Click(object sender, EventArgs e)
        {

        }
        
        private void panelUtilisateur_Paint(object sender, PaintEventArgs e)
        {
    
        }

        private void InterAd_Load(object sender, EventArgs e)
        {
            ChargerDatagridUti();
            ChargerDatagridHC();
        }
        
        public void ChargerDatagridUti()
        {
            Utilisateur lesUtilisateurs = new Utilisateur();
            dataGridViewUti.DataSource = lesUtilisateurs.GetLesUtilisateurs();

            dataGridViewUti.Columns[0].Visible = false;
            dataGridViewUti.Columns[2].Visible = false;
            dataGridViewUti.Columns[3].Visible = false;
            dataGridViewUti.Columns[4].Visible = false;
            dataGridViewUti.Columns[8].Visible = false;
            dataGridViewUti.Columns[9].Visible = false;
            dataGridViewUti.Columns[10].Visible = false;
            dataGridViewUti.Columns[11].Visible = false;
            dataGridViewUti.Columns[12].Visible = false;
            dataGridViewUti.Columns[16].Visible = false;
            dataGridViewUti.Columns[17].Visible = false;

        }

        public void ChargerDatagridHC()
        {
            Utilisateur lesUtilisateurs = new Utilisateur();
            dataGridViewHC.DataSource = lesUtilisateurs.GetLesUtilisateurs();

            dataGridViewHC.Columns[0].Visible = false;
            dataGridViewHC.Columns[2].Visible = false;
            dataGridViewHC.Columns[3].Visible = false;
            dataGridViewHC.Columns[4].Visible = false;
            dataGridViewHC.Columns[9].Visible = false;
            dataGridViewHC.Columns[11].Visible = false;
            dataGridViewHC.Columns[12].Visible = false;
            dataGridViewHC.Columns[16].Visible = false;
            dataGridViewHC.Columns[17].Visible = false;

            dataGridViewHC.Columns[10].DefaultCellStyle.BackColor = Color.GreenYellow;

        }
    }
}

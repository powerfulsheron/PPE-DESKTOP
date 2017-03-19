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
        private static ISessionFactory sessionFactory = null;
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

        bool ChangerMotDePasse(Utilisateur unUtilisateur, string ancienMotDePasse, string nouveauMotDePasse)
        {
            sessionFactory = new Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            
            using (ITransaction transaction = session.BeginTransaction())
            {

                Utilisateur e = session.Get<Utilisateur>(unUtilisateur.numUtilsateur);
                InterLogin pourMD5 = new InterLogin();
                if (e.passwordUtilisateur == pourMD5.MD5Hash(ancienMotDePasse))
                {
                    e.passwordUtilisateur = pourMD5.MD5Hash(nouveauMotDePasse);
                    utilisateur.passwordUtilisateur = pourMD5.MD5Hash(nouveauMotDePasse);
                    session.SaveOrUpdate(e);
                    transaction.Commit();
                    session.Close();
                    sessionFactory.Close();
                    return true;
                }
                else return false;
            }
        }

        private void textBoxLog_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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

namespace Maquette_Belle_Table_Final
{
    public partial class InterUti : Form
    {
        public Utilisateur utilisateur { get; set; }
        public InterUti()
        {
            InitializeComponent();
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
            //Partie code destiné à ajouter un nouveau congé
            new Maquette_Belle_Table.Popup_NewC().Show();
        }

        //---------------------> * Fin Rubrique Plannification Congés * <---------------------

        //---------------------> * Rubrique Portefeuille * <---------------------

        private void buttonAddCli_Click(object sender, EventArgs e)
        {
            new Maquette_Belle_Table.Popup_NewClient().Show();
        }

        private void buttonModCli_Click(object sender, EventArgs e)
        {
            new Maquette_Belle_Table.Popup_NewClient().Show();
        }

        private void buttonEnvoiMail_Click(object sender, EventArgs e)
        {
            new Maquette_Belle_Table.Popup_Mail().Show();
            
        }

        private void dataGridViewPortefeuille_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Partie code destiné au Database sur la rubrique Portefeuille
        }

        //---------------------> * Fin Rubrique Portefeuille * <---------------------

        //---------------------> * Rubrique Mails * <---------------------

        private void buttonEnvoiEmail_Click(object sender, EventArgs e)
        {
            new Maquette_Belle_Table.Popup_Mail().Show();
        }

        private void buttonOuvrirEmail_Click(object sender, EventArgs e)
        {
            new Maquette_Belle_Table.Popup_Mail().Show();
        }

        private void dataGridViewMail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Partie code destiné au Database sur la rubrique Mails
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

    }
}

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
            buttonValCDMDP.DialogResult = DialogResult.OK;
            if (buttonValCDMDP.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Votre nouveau mot de passe a été valider.");
            }
        }

        //---------------------> * Fin Rubrique Changer de mot de passe * <---------------------

    }
}

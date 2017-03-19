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
            //Bouton Changer de mot de passe

        }
    }
}

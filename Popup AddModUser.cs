using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maquette_Belle_Table
{
    public partial class Popup_AddModUser : Form
    {
        public Popup_AddModUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Popup_AddModUser.ActiveForm.Close();
        }

        private void radioButtonCom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCom.Checked)
            {
                panelCom.Visible = true;
                panelAdmin.Visible = false;
                panelGest.Visible = false;
            }
        }

        private void radioButtonAdm_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAdm.Checked)
            {
                panelAdmin.Visible = true;
                panelGest.Visible = false;
                panelCom.Visible = false;

            }
        }

        private void radioButtonUti_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUti.Checked)
            {
                panelGest.Visible = true;
                panelCom.Visible = false;
                panelAdmin.Visible = false;


            }
        }
        //Bouton Annuler sur Profil Admin
        private void buttonAnuAdm_Click(object sender, EventArgs e)
        {
            buttonAnuAdm.DialogResult = DialogResult.Cancel;
        }

        //Bouton Valider sur Profil Admin
        private void buttonValAdm_Click(object sender, EventArgs e)
        {
            buttonValAdm.DialogResult = DialogResult.OK;
        }

        //Bouton Annuler sur Profil Gestionnaire
        private void buttonAnuGes_Click(object sender, EventArgs e)
        {
            buttonAnuGes.DialogResult = DialogResult.Cancel;
        }

        //Bouton Valider sur Profil Gestionnaire
        private void buttonValGes_Click(object sender, EventArgs e)
        {
            buttonValGes.DialogResult = DialogResult.OK;
        }

        //Bouton Annuler sur Profil Commercial
        private void buttonAnuCom_Click(object sender, EventArgs e)
        {
            buttonAnuCom.DialogResult = DialogResult.Cancel;
        }

        //Bouton Valider sur Profil Commercial
        private void buttonValCom_Click(object sender, EventArgs e)
        {
            buttonValCom.DialogResult = DialogResult.OK;
        }
    }

}

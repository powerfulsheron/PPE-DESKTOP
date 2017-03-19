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
    public partial class Popup_Mail : Form
    {
        public Popup_Mail()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Popup_Mail.ActiveForm.Close();
        }

        private void buttonEnvoyer_Click(object sender, EventArgs e)
        {
            buttonEnvoyer.DialogResult = DialogResult.OK;
            if (buttonEnvoyer.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Votre message a été envoyer.");
            }
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            Popup_Mail.ActiveForm.Close();
            //if (new InterUti.buttonEnvoiMail.Checked())
            //{
                //buttonRetour.Visible = false;
            //}
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            buttonAnnuler.DialogResult = DialogResult.Cancel;
        }
    }
}

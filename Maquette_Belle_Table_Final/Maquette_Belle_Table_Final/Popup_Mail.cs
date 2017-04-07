using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maquette_Belle_Table_Final;

namespace Maquette_Belle_Table
{
    public partial class Popup_Mail : Form
    {
        public Mail mail { get; set; }

        public Popup_Mail()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Popup_Mail.ActiveForm.Close();
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
            buttonRetour.DialogResult = DialogResult.Cancel;
        }

        private void Popup_Mail_Load(object sender, EventArgs e)
        {
            textBoxA.Text = mail.interlocuteur.mailInterlocuteur.ToString();
            textBoxNomDestinataire.Text = mail.interlocuteur.nomInterlocuteur.ToString();
            textBoxPrenomDestinataire.Text = mail.interlocuteur.prenomInterlocuteur.ToString();
            textBoxTelDestinataire.Text = mail.interlocuteur.telInterlocuteur.ToString();
            textBoxObjet.Text = mail.objetMail.ToString();
            textBoxMail.Text = mail.contenuMail.ToString();
        }
    }
}

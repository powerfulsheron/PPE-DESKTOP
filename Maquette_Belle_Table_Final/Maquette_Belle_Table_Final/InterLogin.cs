using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Linq;
using System.Security.Cryptography;

namespace Maquette_Belle_Table_Final
{
    public partial class InterLogin : Form
    {
        private static ISessionFactory sessionFactory = null;
        public InterLogin()
        {
            InitializeComponent();
        }

        private void labelFermeture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelMDP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelMDPO.Visible = true;
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            sessionFactory = new Configuration().Configure().BuildSessionFactory();
            // ouverture session  
            ISession session = sessionFactory.OpenSession();
            Utilisateur utilisateur = session.Query<Utilisateur>().SingleOrDefault(w => w.loginUtilisateur == textBoxId.Text);
            Console.WriteLine(utilisateur);
            Console.WriteLine("les conges : "+utilisateur.lesConges);
            Console.WriteLine("Les mails"+utilisateur.lesMails);
            Console.WriteLine("Le planning : "+utilisateur.planning.lesRendezVous);
            Console.WriteLine(utilisateur.porteFeuille.lesInterlocuteurs);

            if (utilisateur == null)
            {
                MessageBox.Show("Utilisateur introuvable", "Erreur");
            }
            else if(MD5Hash(textBoxMDP.Text)==utilisateur.passwordUtilisateur)
            {
                if(utilisateur.typeUtilisateur.codeTypeUtilisateur == 1)
                {
                    new InterAd().Show();
                    InterAd interAd = new InterAd();
                    interAd.utilisateur = utilisateur;
                    interAd.Show();
                }

                else if (utilisateur.typeUtilisateur.codeTypeUtilisateur == 2)
                {
                    new InterGes().Show();
                    InterGes interGes = new InterGes();
                    interGes.utilisateur = utilisateur;
                    interGes.Show();
                }

                else if (utilisateur.typeUtilisateur.codeTypeUtilisateur == 3)
                {
                    InterUti interUti = new InterUti();
                    interUti.utilisateur = utilisateur;
                    interUti.Show();
                }

            }
            else
            {
                // reste à ajouter les 5 tentatives
                MessageBox.Show("Il semble que le mot de passe ne soit pas correct", "Erreur");

            }

            

        }

        private void buttonAnnu_Click(object sender, EventArgs e)
        {
            buttonAnnu.DialogResult = DialogResult.Cancel;
            panelMDPO.Visible = false;
        }

        private void buttonVal_Click(object sender, EventArgs e)
        {
            buttonVal.DialogResult = DialogResult.OK;
            if (buttonVal.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Votre nouveau mot de passe a été envoyer.");
            }
        }

        private void buttonT1_Click(object sender, EventArgs e)
        {
            new InterAd().Show();
        }

        private void buttonT2_Click(object sender, EventArgs e)
        {
            new InterGes().Show();
        }

        private void buttonT3_Click(object sender, EventArgs e)
        {
            new InterUti().Show();
        }

        public string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}


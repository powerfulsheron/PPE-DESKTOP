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
using System.Net.Mail;


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
            // connection à la bdd avec hibernate
            sessionFactory = new Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            using (ITransaction transaction = session.BeginTransaction())
            {
                // on charge l'utilisateur avec le login spécifié dans la textbox
                Utilisateur utilisateur = session.Query<Utilisateur>().SingleOrDefault(w => w.loginUtilisateur == textBoxId.Text);
                // si null, erreur
                if (utilisateur == null)
                {
                    MessageBox.Show("Utilisateur introuvable", "Erreur");
                }
                //sinon on verifie que le password match et si loggé on redirige l'utilisateur en fonction de son type.
                else if (MD5Hash(textBoxMDP.Text) == utilisateur.passwordUtilisateur)
                {
                    // on réinitialise le nombre de tentatives à 0
                    utilisateur.nbTentatives = 0;
                    session.Update(utilisateur);
                    transaction.Commit();
                    if (utilisateur.typeUtilisateur.codeTypeUtilisateur == 1)
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
                        new InterUti().Show();
                        InterUti interUti = new InterUti();
                        interUti.utilisateur = utilisateur;
                        interUti.Show();
                    }

                }
                else // erreur de mdp
                {
                    MessageBox.Show("Il semble que le mot de passe ne soit pas correct", "Erreur");
                    // on gère le nombre de tentatives >6
                    utilisateur.nbTentatives = utilisateur.nbTentatives + 1;
                    if (utilisateur.nbTentatives >= 6)
                    {
                        utilisateur.nbTentatives = 0;
                        try
                        {
                            MailMessage mail = new MailMessage();
                            mail.Subject = "[GEPEV] Tentatives de connection excessives";
                            mail.Body = "l'utilisateur : " + utilisateur.nomUtilisateur + " " + utilisateur.prenomUtilisateur + " à fait 6 échecs de connections à l'application GEPEV.";
                            mail.From = new MailAddress("bot@belletable.com");
                            mail.To.Add("admin@belletable.com");

                            SmtpClient client = new SmtpClient();
                            client.Host = "localhost";
                            client.Send(mail);

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        panelMDPO.Visible = true;
                    }

                    session.Update(utilisateur);
                    transaction.Commit();
                }


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

        public static string MD5Hash(string input)
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


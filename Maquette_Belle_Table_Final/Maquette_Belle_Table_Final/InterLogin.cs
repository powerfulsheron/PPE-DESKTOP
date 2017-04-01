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
        private static ISessionFactory sessionFactory = new Configuration().Configure().BuildSessionFactory();
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
            // ouverture session  
            ISession session = sessionFactory.OpenSession();
            using (ITransaction transaction = session.BeginTransaction())
            {
                Utilisateur utilisateur = session.Query<Utilisateur>().SingleOrDefault(w => w.loginUtilisateur == textBoxId.Text);
 
                if (utilisateur == null)
                {
                    MessageBox.Show("Utilisateur introuvable", "Erreur");
                }
                else if (MD5Hash(textBoxMDP.Text) == utilisateur.passwordUtilisateur && utilisateur.nbTentatives<6)
                {
                    if (utilisateur.typeUtilisateur.codeTypeUtilisateur == 1)
                    {
             
                        utilisateur.nbTentatives = 0;
                        session.Update(utilisateur);
                        transaction.Commit();
                        InterAd interAd = new InterAd();
                        interAd.utilisateur = utilisateur;
                        session.Close();
                        interAd.Show();
                    }

                    else if (utilisateur.typeUtilisateur.codeTypeUtilisateur == 2)
                    {
                 
                        utilisateur.nbTentatives = 0;
                        session.Update(utilisateur);
                        transaction.Commit();
                        InterGes interGes = new InterGes();
                        interGes.utilisateur = utilisateur;
                        session.Close();
                        interGes.Show();
                    }

                    else if (utilisateur.typeUtilisateur.codeTypeUtilisateur == 3)
                    {
                        utilisateur.nbTentatives = 0;
                        session.Update(utilisateur);
                        transaction.Commit();
                        InterUti interUti = new InterUti();
                        interUti.utilisateur = utilisateur;
                        session.Close();
                        interUti.Show();
                      
  
                    }
  
                }
                else if (utilisateur.nbTentatives < 6)// erreur de mdp et tentatives <6
                {
                    MessageBox.Show("Il semble que le mot de passe ne soit pas correct", "Erreur");
                    // on gère le nombre de tentatives >6
                    utilisateur.nbTentatives = utilisateur.nbTentatives + 1;
                    if (utilisateur.nbTentatives >= 6)
                    {
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
                    session.Close();
                }
                else
                {
                    panelMDPO.Visible = true;
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
            try
            {
                using (ISession session = sessionFactory.OpenSession())
                {
                    // début transaction 
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        // on cherche si l'employé existe dans la base, si trouvé on le charge dans un objet utilisateur.
                        Utilisateur utilisateur = session.Query<Utilisateur>().SingleOrDefault(w => w.loginUtilisateur == textBoxMDPNom.Text);

                        // on crée une phrase random
                        Random random = new Random();
                        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                        string laString = new string(Enumerable.Repeat(chars, 10).Select(s => s[random.Next(s.Length)]).ToArray());

                        // on converti la phrase random en md5
                        var bytes = new UTF8Encoding().GetBytes(laString);
                        var hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(bytes);
                        string newPassword = Convert.ToBase64String(hashBytes);

                        // on update le nouveau password
                        utilisateur.passwordUtilisateur = newPassword;
                        session.Save(utilisateur);

                        // validation de la transaction 
                        transaction.Commit();
                        session.Close();
                      

                        // on envoie le mail

                        MailMessage mail = new MailMessage();
                        mail.Subject = "Votre nouveau mot de passe";
                        mail.Body = "Votre nouveau mot de passe est : " + laString;
                        mail.From = new MailAddress("bot@belletable.com");
                        mail.To.Add(utilisateur.mailUtilisateur);

                        SmtpClient client = new SmtpClient();
                        client.Host = "localhost";
                        client.Send(mail);
                  
            
                        // message succès
                        MessageBox.Show("Votre nouveau mot de passe a été envoyé à votre adresse : "+utilisateur.mailUtilisateur);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
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

        private void textBoxMDPNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelMDPNom_Click(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


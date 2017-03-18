using System;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Linq;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Net.Mail;

namespace PamNHibernateDemos
{
    class Program
    {
        private static ISessionFactory sessionFactory = null;



        // programme principal 
        static void Main(string[] args)
        {
           Console.WriteLine("Saisissez votre login :");
            string leLoger = Console.ReadLine();
            Console.ReadKey();
            rdvOublie(leLoger);

        }



        static void rdvOublie(string stringloginUtilisateur)
        {
            // instanciation de nhibernate
            sessionFactory = new Configuration().Configure().BuildSessionFactory();

try{
            using (ISession session = sessionFactory.OpenSession()) 
      { 
        // début transaction 
        using (ITransaction transaction = session.BeginTransaction()) 
        {
            // on cherche si un employé existe dans la base, si trouvé on le charge dans un objet utilisateur.
            Utilisateur utilisateur = session.Query<Utilisateur>().SingleOrDefault(w => w.loginUtilisateur == stringloginUtilisateur);

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

            // on envoie le mail

            MailMessage mail = new MailMessage();
            mail.Subject = "Votre nouveau mot de passe";
            mail.Body = "Votre nouveau mot de passe est : " + laString;
            mail.From = new MailAddress("bot@belletable.com");
            mail.To.Add(utilisateur.mailUtilisateur);

            SmtpClient client = new SmtpClient();
            client.Host = "localhost";
            client.Send(mail);

            Console.WriteLine("Succès !");
            Console.ReadKey();


          // validation de la transaction 
          transaction.Commit(); 
        } 
      } 
}catch (Exception ex){
    Console.WriteLine(ex);               
} 


           
               
            }          
        
            

            







        }



        }

    

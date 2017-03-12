using System;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Linq;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PamNHibernateDemos
{
    class Program
    {
        private static ISessionFactory sessionFactory = null;



        // programme principal 
        static void Main(string[] args)
        {
            string passwordInput;
            Utilisateur leLoger = new Utilisateur();
            // initialisation factory NHibernate 
            sessionFactory = new Configuration().Configure().BuildSessionFactory();
            try
            {

                Console.WriteLine("Utilisateur:");
                try
                {
                    leLoger = ShowDataBase1(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                Console.WriteLine("Password:");
                passwordInput = Console.ReadLine();

                byte[] encodedPassword = new UTF8Encoding().GetBytes(passwordInput);

                // need MD5 to calculate the hash
                byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);

                // string representation (similar to UNIX format)
                string encoded = BitConverter.ToString(hash)
                    // without dashes
                   .Replace("-", string.Empty)
                    // make lowercase
                   .ToLower();

                if (encoded == leLoger.passwordUtilisateur) { Console.WriteLine("gg fdp"); }
                else { Console.WriteLine("Au GOULAG fdp!"); }

                Console.WriteLine(leLoger);
                Console.ReadKey();


            }
            catch (Exception ex)
            {
                // on affiche l'exception  
                Console.WriteLine(string.Format("L'erreur suivante s'est produite : [{0}]", ex.ToString()));
            }
            finally
            {
                if (sessionFactory != null)
                {
                    sessionFactory.Close();
                }
            }
            // attente clavier 
            Console.ReadLine();
        }

        // test1 
        static Utilisateur ShowDataBase1(string stringloginUtilisateur)
        {
            // ouverture session  
            ISession session = sessionFactory.OpenSession();


            // on récupère l'employé
            return session.Query<Utilisateur>().SingleOrDefault(w => w.loginUtilisateur == stringloginUtilisateur);





        }
    }
}
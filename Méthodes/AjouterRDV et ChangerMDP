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
           sessionFactory = new Configuration().Configure().BuildSessionFactory();
           
            ISession session = sessionFactory.OpenSession();

            /// Test pour la méthode changer mdp:
            /*
            Utilisateur utilisateurTest1 = session.Get<Utilisateur>(2);
            Console.WriteLine("Ancien Mot de passe: \n");
            string ancienmdp = Console.ReadLine();
            Console.WriteLine("Nouveau Mot de passe: \n");
            string newmdp= Console.ReadLine();

            if (ChangerMotDePasse(utilisateurTest1, ancienmdp, newmdp) == true) Console.WriteLine("Mdp Changé");
            else Console.WriteLine("Erreur");

           
            Console.ReadLine();
            Utilisateur utilisateurTest2 = session.Get<Utilisateur>(2);
            Console.WriteLine(utilisateurTest2);
            Console.ReadLine();
            */
            ///Fin de test

            Interlocuteur unInterlocuteurTest = session.Get<Interlocuteur>(1);
            TypeRdv unTypeRdvTest = session.Get<TypeRdv>(2);

            Console.WriteLine("Entrez une date pour le RDV: \n");
            DateTime dateRDVtest = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Entrez une heure bidon pour le RDV: \n");
            DateTime heureRDVtest = Convert.ToDateTime(Console.ReadLine());

            Utilisateur unUtilisateurTest = session.Get<Utilisateur>(1);

            session.Close();

            if (AjouterRendezVous(0, unInterlocuteurTest, dateRDVtest, heureRDVtest, heureRDVtest, null, null, unTypeRdvTest, unUtilisateurTest.planning) == true) Console.WriteLine("RDV ajouté");
            else Console.WriteLine("Error");
        }

        
        static bool AjouterRendezVous(int unCodeEntreeDerogatoire, Interlocuteur unInterlocuteur, DateTime uneDateRdv, DateTime uneHeureDebut, 
            DateTime uneHeureFin, string uneAdresseDerogatoire, string uneInfoDerogatoire, TypeRdv unTypeRdv, Planning unPlanning)
        {


            ISession session = sessionFactory.OpenSession();
            using (ITransaction transaction = session.BeginTransaction())

            {
                RendezVous unRendezVous = new RendezVous();

                if (unInterlocuteur == null) return false;
                else unRendezVous.interlocuteur = unInterlocuteur;

                if (unTypeRdv == null) return false;
                else unRendezVous.typeRdv = unTypeRdv;

                if (unPlanning == null) return false;
                else unRendezVous.planning = unPlanning;

                if (uneDateRdv == null) return false;
                if (uneHeureDebut != null) unRendezVous.heureDebut = uneHeureDebut;
                if (uneHeureDebut != null) unRendezVous.heureFin = uneHeureFin;
                if (unCodeEntreeDerogatoire != 0) unRendezVous.codeEntreeDerogatoire = unCodeEntreeDerogatoire;
                if (uneAdresseDerogatoire != null) unRendezVous.adresseDerogatoire = uneAdresseDerogatoire;
                if (uneInfoDerogatoire != null) unRendezVous.adresseDerogatoire = uneAdresseDerogatoire;
                session.Save(unRendezVous);
                transaction.Commit();

                return true;
            }
        }
            
        static bool ChangerMotDePasse(Utilisateur unUtilisateur, string ancienMotDePasse, string nouveauMotDePasse)
        {
            
            ISession session = sessionFactory.OpenSession();
            using (ITransaction transaction = session.BeginTransaction())
              {

                Utilisateur e = session.Get<Utilisateur>(unUtilisateur.numUtilsateur);
                
                if (e.passwordUtilisateur == MD5Hash(ancienMotDePasse))
                {
                    e.passwordUtilisateur = MD5Hash(nouveauMotDePasse);
                    session.Update(e);
                    transaction.Commit();
                    return true;
                }
                else return false;
             }
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

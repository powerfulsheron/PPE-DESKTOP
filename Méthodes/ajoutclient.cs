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
            
            Interlocuteur I = session.Get<Interlocuteur>(1);
            Individu Ind = session.Get<Individu>(2);
            Structure Stru = session.Get<Structure>(1);

            Console.WriteLine("nom client : ");
            string nomclient = Console.ReadLine();
            Console.WriteLine("prénom client : ");
            string prenomclient = Console.ReadLine();
            Console.WriteLine("téléphone client : ");
            string telclient = Console.ReadLine();
            Console.WriteLine("mail client : ");
            string mailclient = Console.ReadLine();
            if (AjouterClient(I,nomclient,prenomclient,telclient,mailclient,Ind,Stru) == true)
            {
                Console.WriteLine("client ajouté");
            }
            else
            {
                Console.WriteLine("raté");
            }
        }
        static Boolean AjouterClient (Interlocuteur unInterlocuteur, string unnomclient, string unprenomclient, string untelclient,
            string unmailclient, Individu unindividu, Structure unestructure )
        {
            sessionFactory = new Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();

            using (ITransaction transaction = session.BeginTransaction())

            {
                Interlocuteur I = new Interlocuteur();

                if (unInterlocuteur == null) { return false; }
                if (unnomclient.Length == 0) { return false; } else { I.nomInterlocuteur= unnomclient; }
                if (unprenomclient.Length == 0) { return false; } else { I.prenomInterlocuteur = unprenomclient; }
                if (untelclient.Length == 0) { return false; } else { I.telInterlocuteur= untelclient; }
                if (unmailclient.Length == 0) { return false; } else { I.mailInterlocuteur = unmailclient; }
                if (unindividu == null) { return false; }
                if (unestructure == null) { return false; }
                
                    session.Save(I);
                    transaction.Commit();
                return true;

            }
        }
    }
}
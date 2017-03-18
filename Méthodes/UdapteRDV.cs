using System;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Linq;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace UpdateRDV
{
    class Program
    {
        private static ISessionFactory sessionFactory = null;

        // programme principal 
        static void Main(string[] args)
        {

            sessionFactory = new Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();

            RendezVous R = session.Get<RendezVous>(1);
            Interlocuteur I = session.Get<Interlocuteur>(1);
            TypeRdv T = session.Get<TypeRdv>(1);

            Console.WriteLine("nouvelle date : ");
            string daterdv = Console.ReadLine();
            DateTime date = Convert.ToDateTime(daterdv);
            Console.WriteLine("nouvelle heure début : ");
            string heuredebutrdv = Console.ReadLine();
            DateTime heuredebut = Convert.ToDateTime(heuredebutrdv);
            Console.WriteLine("nouvelle heure fin : ");
            string heurefinrdv = Console.ReadLine();
            DateTime heurefin = Convert.ToDateTime(heurefinrdv);
            Console.WriteLine("nouvelle adresse : ");
            string adresse = Console.ReadLine();
            Console.WriteLine("nouvelle ville : ");
            string ville = Console.ReadLine();
            Console.WriteLine("nouveau code : ");
            string coderdv = Console.ReadLine();

            int code = Int32.Parse(coderdv);
            Console.WriteLine("nouvelle info :");
            string infordv = Console.ReadLine();

            if (ModiferRDV(R, date, heuredebut, heurefin, adresse, ville, code, infordv, I, T) == true)
            {
                Console.WriteLine("mise à jour");
            }
            else
            {
                Console.WriteLine("raté");
            }
        }
        static Boolean ModiferRDV(RendezVous unRDV, DateTime unedate, DateTime uneheuredebut, DateTime uneheurefin,
            string uneadresse, string uneville, int uncoderdv, string uneinfordv, Interlocuteur unInterlocuteur,
            TypeRdv unTypeRdv)
        {
            int a = 0;
            sessionFactory = new Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();

            using (ITransaction transaction = session.BeginTransaction())

            {
                RendezVous R = session.Get<RendezVous>(unRDV.idRdv);

                if (unedate != null) { R.dateRdv = unedate; }
                if (uneheuredebut != null) { R.heureDebut = uneheuredebut; }
                if (uneheurefin != null) { R.heureFin = uneheurefin; }
                if (uneadresse.Length != 0) { R.adresseDerogatoire = uneadresse; }
                if (uneville.Length != 0) { R.villeDerogatoire = uneville; }
                if (uncoderdv.ToString() != null) { R.codeEntreeDerogatoire = uncoderdv; }
                if (uneinfordv.Length != 0) { R.infoDerogatoire = uneinfordv; }
                if (unInterlocuteur != null) { }

                try
                {
                    session.Update(R);
                    transaction.Commit();
                    a = 1;
                }
                catch (Exception e)
                {
                    a = 0;
                    Console.WriteLine(e);
                }
                if (a == 1) { return true; }
                else { return false; }

            }
        }
    }
}

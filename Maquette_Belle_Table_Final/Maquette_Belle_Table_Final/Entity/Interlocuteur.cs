using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;

namespace Maquette_Belle_Table_Final
{
    public class Interlocuteur
    {
        public virtual int idInterlocuteur { get; set; }
        public virtual string nomInterlocuteur { get; set; }
        public virtual string prenomInterlocuteur { get; set; }
        public virtual string telInterlocuteur { get; set; }
        public virtual string mailInterlocuteur { get; set; }
        public virtual PorteFeuille porteFeuille { get; set; }
        public virtual ISet<Mail> lesMails { get; set; }
        public virtual ISet<RendezVous> lesRendezVous { get; set; }
        private static ISessionFactory sessionFactory = null;

        public Interlocuteur()
        {

        }

        // ToString 
        public override string ToString()
        {
            return string.Format("[{0}|{1}|{2}|{3}]", nomInterlocuteur, prenomInterlocuteur, telInterlocuteur, mailInterlocuteur);
        }

        public virtual IList<Interlocuteur> GetLesInterlocuteurs()
        {
            sessionFactory = new Configuration().Configure().BuildSessionFactory();
            using (ISession session = sessionFactory.OpenSession())
            {
                // début transaction 
                using (ITransaction transaction = session.BeginTransaction())
                {

                    // on Interlocuteur la liste des utilisateurs 
                    IList<Interlocuteur> lesInterlocuteurs = session.CreateQuery(@"select i FROM Interlocuteur i").List<Interlocuteur>();
                    session.Dispose();
                    return lesInterlocuteurs;
                }
            }

        }
    }
}
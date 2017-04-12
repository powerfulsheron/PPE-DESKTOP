using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;

namespace Maquette_Belle_Table_Final
{
    public class PorteFeuille
    {
        public virtual int idPorteFeuille { get; set; }
        public virtual string libellePortefeuille { get; set; }
        public virtual ISet<Interlocuteur> lesInterlocuteurs { get; set; }
        public virtual Utilisateur utilisateur { get; set; }

        private static ISessionFactory sessionFactory = null;
        public PorteFeuille()
        {

        }

        // ToString 
        public override string ToString()
        {
            return string.Format("[{0}]", libellePortefeuille);
        }

        public virtual IList<PorteFeuille> GetLesUtilisateurs()
        {
            sessionFactory = new Configuration().Configure().BuildSessionFactory();
            using (ISession session = sessionFactory.OpenSession())
            {
                // début transaction 
                using (ITransaction transaction = session.BeginTransaction())
                {

                    // on récupère la liste des utilisateurs 
                    IList<PorteFeuille> lesPortefeuilles = session.CreateQuery(@"select u from Utilisateur u ").List<PorteFeuille>();
                    session.Dispose();
                    return lesPortefeuilles;
                }
            }

        }
    }
}

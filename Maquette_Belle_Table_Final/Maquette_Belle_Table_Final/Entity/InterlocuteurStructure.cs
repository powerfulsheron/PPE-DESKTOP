using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;


namespace Maquette_Belle_Table_Final
{
    public class InterlocuteurStructure
    {
        public virtual int idInterlocuteurStructure { get; set; }
        public virtual Interlocuteur interlocuteur { get; set; }
        public virtual Structure structure { get; set; }
        private static ISessionFactory sessionFactory = null;

        // constructeurs 
        public InterlocuteurStructure()
        {
        }
        // ToString 
        public override string ToString()
        {
            return string.Format("[{0}]", interlocuteur, structure);
        }

        public virtual IList<InterlocuteurStructure> GetLesInterlocuteurStructures()
        {
            sessionFactory = new Configuration().Configure().BuildSessionFactory();
            using (ISession session = sessionFactory.OpenSession())
            {
                // début transaction 
                using (ITransaction transaction = session.BeginTransaction())
                { 
                    IList<InterlocuteurStructure> lesInterlocuteurStructure = session.CreateQuery(@"select i FROM InterlocuteurStructure i").List<InterlocuteurStructure>();
                    session.Dispose();
                    return lesInterlocuteurStructure;
                }
            }

        }
    }
}

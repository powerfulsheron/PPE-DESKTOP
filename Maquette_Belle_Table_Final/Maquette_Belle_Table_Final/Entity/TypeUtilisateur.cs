using System;
using NHibernate;
using NHibernate.Cfg;
using System.Collections.Generic;

namespace Maquette_Belle_Table_Final

{
    public class TypeUtilisateur
    {
        private static ISessionFactory sessionFactory = null;

        public virtual int codeTypeUtilisateur { get; set; }
        public virtual string libelleTypeUtilisateur { get; set; }

        public TypeUtilisateur()
        {

        }

        // ToString 
        public override string ToString()
        {
            return string.Format("[{0}]", libelleTypeUtilisateur);
        }

        public virtual IList<TypeUtilisateur> GetLesTypesUtilisateur()
        {
            sessionFactory = new Configuration().Configure().BuildSessionFactory();
            using (ISession session = sessionFactory.OpenSession())
            {
                // début transaction 
                using (ITransaction transaction = session.BeginTransaction())
                {
                    // on récupère la liste des typeUtilisateur 
                    IList<TypeUtilisateur> typeUtilisateur = session.CreateQuery(@"select e from TypeUtilisateur e ").List<TypeUtilisateur>();
                    session.Dispose();
                    return typeUtilisateur;

                }

            }

        }

    }

}

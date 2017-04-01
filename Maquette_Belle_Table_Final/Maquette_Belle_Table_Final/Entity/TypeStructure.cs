using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;

namespace Maquette_Belle_Table_Final

{

    public class TypeStructure
    {
        public virtual int codeTypeStructure { get; set; }
        public virtual string libelleTypeStructure { get; set; }

        private static ISessionFactory sessionFactory = null;
        public TypeStructure()
        {

        }

        // ToString 
        public override string ToString()
        {
            return string.Format("[{0}]", libelleTypeStructure);
        }

        public virtual IList<TypeStructure> GetLesTypesStructure()
        {
            sessionFactory = new Configuration().Configure().BuildSessionFactory();
            using (ISession session = sessionFactory.OpenSession())
            {
                // début transaction 
                using (ITransaction transaction = session.BeginTransaction())
                {

                    // on récupère la liste des typeStructure 
                    IList<TypeStructure> typeStructure = session.CreateQuery(@"select e from TypeStructure e ").List<TypeStructure>();
                    session.Close();
                    return typeStructure;
                }
            }

        }
    }
} 
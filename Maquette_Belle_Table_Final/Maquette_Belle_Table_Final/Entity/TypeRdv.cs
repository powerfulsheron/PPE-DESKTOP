using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Maquette_Belle_Table_Final
{
    public class TypeRdv
    {
        public virtual int idTypeRdv { get; set; }
        public virtual string libelleTypeRdv { get; set; }

        private static ISessionFactory sessionFactory = null;
        public TypeRdv()
        {

        }

        // ToString 
        public override string ToString()
        {
            return string.Format("[{0}]", libelleTypeRdv);
        }

        public virtual IList<TypeRdv> GetLesTypesRdv()
        {
            sessionFactory = new Configuration().Configure().BuildSessionFactory();
            using (ISession session = sessionFactory.OpenSession())
            {
                // début transaction 
                using (ITransaction transaction = session.BeginTransaction())
                {

                    // on récupère la liste des typerdv 
                    IList<TypeRdv> typerdv = session.CreateQuery(@"select e from TypeRdv e ").List<TypeRdv>();
                    return typerdv;
                }
            }

        }
    }
}
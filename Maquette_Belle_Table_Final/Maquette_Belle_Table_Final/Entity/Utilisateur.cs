using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;

namespace Maquette_Belle_Table_Final

{
    public class Utilisateur
    {
        public virtual int numUtilisateur { get; set; }
        public virtual String nomUtilisateur { get; set; }
        public virtual String prenomUtilisateur { get; set; }
        public virtual String adresseUtilisateur { get; set; }
        public virtual String cpUtilisateur { get; set; }
        public virtual String villeUtilisateur { get; set; }
        public virtual String telUtilisateur { get; set; }
        public virtual String mailUtilisateur { get; set; }
        public virtual float distanceParcourueSemaine { get; set; }
        public virtual String loginUtilisateur { get; set; }
        public virtual String passwordUtilisateur { get; set; }
        public virtual DateTime dateDernierLogin { get; set; }
        public virtual int nbTentatives { get; set; }

        public virtual TypeUtilisateur typeUtilisateur { get; set; }
        public virtual Planning planning { get; set; }
        public virtual PorteFeuille porteFeuille { get; set; }
        public virtual ISet<Conge> lesConges { get; set; }
        public virtual ISet<Mail> lesMails { get; set; }

        private static ISessionFactory sessionFactory = null;
        public Utilisateur()
        {

        }

        // ToString 
        public override string ToString()
        {
            return string.Format("[{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}]", nomUtilisateur, prenomUtilisateur, adresseUtilisateur, cpUtilisateur, villeUtilisateur, telUtilisateur, mailUtilisateur, loginUtilisateur, passwordUtilisateur, dateDernierLogin, nbTentatives, distanceParcourueSemaine, typeUtilisateur, planning, porteFeuille);
        }

        public virtual IList<Utilisateur> GetLesUtilisateurs()
        {
            sessionFactory = new Configuration().Configure().BuildSessionFactory();
            using (ISession session = sessionFactory.OpenSession())
            {
                // début transaction 
                using (ITransaction transaction = session.BeginTransaction())
                {

                    // on récupère la liste des utilisateurs 
                    IList<Utilisateur> lesUtilisateurs = session.CreateQuery(@"select u from Utilisateur u ").List<Utilisateur>();
                    session.Dispose();
                    return lesUtilisateurs;
                }
            }

        }

        public virtual IList<Utilisateur> GetLesUtilisateurs(int codeTypeUtilisateur)
        {
            sessionFactory = new Configuration().Configure().BuildSessionFactory();
            using (ISession session = sessionFactory.OpenSession())
            {
                // début transaction 
                using (ITransaction transaction = session.BeginTransaction())
                {

                    // on récupère la liste des utilisateurs 
                    IList<Utilisateur> lesUtilisateurs = session.CreateQuery(@"select u FROM Utilisateur u  WHERE u.typeUtilisateur = " 
                        + codeTypeUtilisateur.ToString()).List<Utilisateur>();
                    session.Dispose();
                    return lesUtilisateurs;
                }
            }

        }
    }
}

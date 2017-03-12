using System; 
using System.Collections; 
using System.Collections.Generic; 
using NHibernate; 
using NHibernate.Cfg; 
using log4net;

namespace PamNHibernateDemos 
{
    class Program
    {
        private static ISessionFactory sessionFactory = null; 
        
 
 
    // programme principal 
    static void Main(string[] args) 
    {

      // initialisation factory NHibernate 
      sessionFactory = new Configuration().Configure().BuildSessionFactory(); 
      try 
      { 
        // affichage contenu de la base 
        Console.WriteLine("Affichage base -------------------------------------"); 
        ShowDataBase1(); 
      } 
      catch (Exception ex) 
      { 
        // on affiche l'exception  
        Console.WriteLine(string.Format("L'erreur suivante s'est produite : [{0}]", ex.ToString())); 
      } 
      finally 
      { 
        if (sessionFactory != null) 
        { 
          sessionFactory.Close(); 
        } 
      } 
      // attente clavier 
      Console.ReadLine(); 
    } 
 
    // test1 
    static void ShowDataBase1() 
    { 
      // ouverture session  
      using (ISession session = sessionFactory.OpenSession()) 
      { 
        // début transaction 
        using (ITransaction transaction = session.BeginTransaction()) 
        { 
          // on récupère la liste des employés 
            IList<Utilisateur> utilisateurs = session.CreateQuery(@"select e from Utilisateur e order by e.nomUtilisateur asc").List<Utilisateur>(); 
          // on l'affiche 
          Console.WriteLine("--------------- liste des employés");
          foreach (Utilisateur e in utilisateurs) 
          { 
            Console.WriteLine(e); 
          } 
          // commit transaction 
          transaction.Commit(); 
        } 
      } 
    } 
        }
    }

using System;

namespace PamNHibernateDemos
{
    public class PorteFeuille
    {
        public virtual int idPortefeuille { get; set; }
        public virtual string libellePortefeuille { get; set; }
       public virtual Utilisateur utilisateur { get; set; }
       
        public PorteFeuille()
        {

        }

        // ToString 
        public override string ToString()
        {
            //return string.Format("[{0}|{1}]", libellePortefeuille, utilisateur);
            return string.Format("[{0}]", libellePortefeuille);
        }
      
    }
}

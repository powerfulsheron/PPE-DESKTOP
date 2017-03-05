using System;

namespace PamNHibernateDemos
{
    public class Conge
    {
        // propriétés automatiques 
        public virtual int numConge { get; set; }
        public virtual DateTime dateDebutConge { get; set; }
        public virtual DateTime dateFinConge { get; set; }

        // constructeurs 
        public Conge()
        {
        }
        // ToString 
        public override string ToString()
        {
            return string.Format("[{0}|{1}]", dateDebutConge, dateFinConge);
        }
    }

}
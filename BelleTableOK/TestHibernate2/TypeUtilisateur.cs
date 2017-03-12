using System;

namespace PamNHibernateDemos

{
    public class TypeUtilisateur
    {
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
     
    }

}

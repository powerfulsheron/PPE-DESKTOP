using System;

namespace Maquette_Belle_Table_Final

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

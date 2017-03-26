using System;
using System.Collections.Generic;

namespace Maquette_Belle_Table_Final
{
    public class Conge
    {
        // propriétés automatiques 
        public virtual int numConge { get; set; }
        public virtual DateTime dateDebutConge { get; set; }
        public virtual DateTime dateFinConge { get; set; }
        public virtual ISet<Utilisateur> lesUtilisateurs  { get; set; }

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
using System;
using System.Collections.Generic;


namespace Maquette_Belle_Table_Final
{
    public class CongesUtilisateur
    {
        public virtual int idCongesUtilisateur { get; set; }
        public virtual Utilisateur utilisateur { get; set; }
        public virtual Conge conge { get; set; }

        // constructeurs 
        public CongesUtilisateur()
        {
        }
        // ToString 
        public override string ToString()
        {
            return string.Format("[{0}]", conge);
        }

    }
}

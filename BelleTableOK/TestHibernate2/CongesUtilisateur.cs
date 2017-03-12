using System;
using System;
using System.Collections.Generic;


namespace PamNHibernateDemos
{
    public class CongesUtilisateur
    {
        public virtual int idCongesUtilisateur { get; set; }
        public virtual IList<Utilisateur> lesUtilisateurs { get; set; }
        public virtual IList<Conge> lesConges { get; set; }

        // constructeurs 
        public CongesUtilisateur()
        {
        }
        // ToString 
        public override string ToString()
        {
            return string.Format("[{0}|{1}]", lesUtilisateurs, lesConges);
        }

    }
}

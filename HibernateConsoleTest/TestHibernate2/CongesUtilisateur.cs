using System;

namespace PamNHibernateDemos
{
    class CongesUtilisateur
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
            return string.Format("[{0}|{1}]", utilisateur, conge);
        }

    }
}

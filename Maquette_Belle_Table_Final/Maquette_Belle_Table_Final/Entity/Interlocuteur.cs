using System;
using System.Collections.Generic;

namespace Maquette_Belle_Table_Final
{
    public class Interlocuteur
    {
        public virtual int idInterlocuteur { get; set; }
        public virtual string nomInterlocuteur { get; set; }
        public virtual string prenomInterlocuteur { get; set; }
        public virtual string telInterlocuteur { get; set; }
        public virtual string mailInterlocuteur { get; set; }
        public virtual Individu individu { get; set; } 
        public virtual Structure structure { get; set; }
        public virtual PorteFeuille portefeuille { get; set; }
        public virtual ISet<Utilisateur> lesMails { get; set; }
        public virtual IList<RendezVous> lesRendezVous { get; set; }

        public Interlocuteur()
        {

        }

        // ToString 
        public override string ToString()
        {
            return string.Format("[{0}|{1}|{2}|{3}|{4}|{5}]", nomInterlocuteur, prenomInterlocuteur, telInterlocuteur, mailInterlocuteur, individu, structure, portefeuille);
        }
    }
}
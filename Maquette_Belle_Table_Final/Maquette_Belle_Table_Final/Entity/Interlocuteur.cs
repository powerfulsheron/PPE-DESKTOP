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
        public virtual PorteFeuille portefeuille { get; set; }
        public virtual ISet<Mail> lesMails { get; set; }
        public virtual ISet<RendezVous> lesRendezVous { get; set; }

        public Interlocuteur()
        {

        }

        // ToString 
        public override string ToString()
        {
            return string.Format("[{0}|{1}|{2}|{3}]", nomInterlocuteur, prenomInterlocuteur, telInterlocuteur, mailInterlocuteur, portefeuille);
        }
    }
}
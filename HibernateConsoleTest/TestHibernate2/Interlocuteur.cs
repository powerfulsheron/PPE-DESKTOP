using System;

namespace PamNHibernateDemos
{
    public class Interlocuteur
    {
        public virtual int idInterlocuteur { get; set; }
        public virtual string nomInterlocuteur { get; set; }
        public virtual string prenomInterlocuteur { get; set; }
        public virtual string telInterlocuteur { get; set; }
        public virtual string mailInterlocuteur { get; set; }
        public virtual Individu individu { get; set; }
        public virtual PorteFeuille porteFeuille { get; set; }

        public Interlocuteur()
        {

        }

        // ToString 
        public override string ToString()
        {
            return string.Format("[{0}|{1}|{2}|{3}|{4}|{5}]", nomInterlocuteur, prenomInterlocuteur, telInterlocuteur, mailInterlocuteur, individu, porteFeuille);
        }
    }
}
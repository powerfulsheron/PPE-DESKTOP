using System;

namespace PamNHibernateDemos
{
    public class InterlocuteurStructure
    {


        public virtual int idInterlocuteurStructure { get; set; }
        public virtual Interlocuteur interlocuteur { get; set; }
        public virtual Structure structure { get; set; }

        // constructeurs 
        public InterlocuteurStructure()
        {
        }
        // ToString 
        public override string ToString()
        {
            return string.Format("[{0}|{1}]", interlocuteur, structure);
        }
    }



}

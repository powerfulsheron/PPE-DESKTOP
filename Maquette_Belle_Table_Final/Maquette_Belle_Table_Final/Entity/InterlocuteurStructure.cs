using System;
using System.Collections.Generic;


namespace Maquette_Belle_Table_Final
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
            return string.Format("[{0}]", interlocuteur, structure);
        }

    }
}

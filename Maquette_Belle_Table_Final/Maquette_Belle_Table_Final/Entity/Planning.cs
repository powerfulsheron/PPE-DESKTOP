using System;
using System.Collections.Generic;

namespace Maquette_Belle_Table_Final
{
    public class Planning
    {
        public virtual int idPlanning { get; set; }
        public virtual string libellePlanning { get; set; }
        public virtual Utilisateur utilisateur { get; set; }
        public virtual IList<RendezVous> lesRendezVous { get; set; }

        public Planning()
        {
            
        }

        // ToString 
        public override string ToString()
        {
            return string.Format("[{0}]", libellePlanning);
        }
      
    }
}

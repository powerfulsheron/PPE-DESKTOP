using System;
using System.Collections.Generic;

namespace Maquette_Belle_Table_Final
{

public class Structure
{
    public virtual int numStructure { get; set; }
    public virtual float distanceSiege { get; set; }
    public virtual string cpStructure { get; set; }
    public virtual string denominationSociale { get; set; }
    public virtual string adresseStructure { get; set; }
    public virtual string villeStructure { get; set; }
    public virtual string planAcces { get; set; }
    public virtual string infoSupplementaire { get; set; }

    public virtual TypeStructure typeStructure { get; set; }

    public virtual ISet<Interlocuteur> lesInterlocuteurs { get; set; }

    public Structure()
	{

	}

      // ToString 
        public override string ToString()
        {
            return string.Format("[{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}]", distanceSiege, cpStructure, denominationSociale, adresseStructure, villeStructure, planAcces, infoSupplementaire, typeStructure);
        }


}


}

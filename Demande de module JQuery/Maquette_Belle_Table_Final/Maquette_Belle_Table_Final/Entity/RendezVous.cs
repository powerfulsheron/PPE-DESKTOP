using System;

namespace Maquette_Belle_Table_Final
{

    public class RendezVous
    {
        public virtual int idRdv { get; set; }
        public virtual int codeEntreeDerogatoire { get; set; }
        public virtual DateTime dateRdv { get; set; }
        public virtual DateTime heureDebut { get; set; }
        public virtual DateTime heureFin { get; set; }
        public virtual string adresseDerogatoire { get; set; }
        public virtual string villeDerogatoire { get; set; }
        public virtual string infoDerogatoire { get; set; }
        public virtual Interlocuteur interlocuteur { get; set; }
        public virtual TypeRdv typeRdv { get; set; }
        public virtual Planning planning { get; set; }

        public RendezVous()
        {
           
        }

        // ToString 
        public override string ToString()
        {
            return string.Format("[{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}]", codeEntreeDerogatoire, dateRdv, heureDebut, heureFin, adresseDerogatoire, villeDerogatoire, infoDerogatoire, interlocuteur, typeRdv);
        }


    }
}    
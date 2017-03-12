using System;

namespace PamNHibernateDemos
{
    public class Individu
    {
        public virtual int numIndividu { get; set; }
        public virtual float distanceSiege { get; set; }
        public virtual string adresseIndividu { get; set; }
        public virtual string cpIndividu { get; set; }
        public virtual string villeIndividu { get; set; }
        public virtual string planAcces { get; set; }
        public virtual string infosSupplementaire { get; set; }

        public Individu()
        {

        }

        // ToString 
        public override string ToString()
        {
            return string.Format("[{0}|{1}|{2}|{3}|{4}|{5}]", distanceSiege, adresseIndividu, cpIndividu, villeIndividu, planAcces, infosSupplementaire);
        }
        
    }
}
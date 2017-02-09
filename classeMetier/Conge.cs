using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_Belle_Table_Classes_métier
{
    class Conge
    {
        private int numConge;
        private DateTime dateDebutConge;
        private DateTime dateFinConge;

        public Conge()
        {

        }
        //Setter
        public void SetnumConge(int unnumConge)
        {
            numConge = unnumConge;
        }


        public void SetdateDebutConge(DateTime unedateDebutConge)
        {
            dateDebutConge = unedateDebutConge;
        }

        public void SetdateFinConge(DateTime unedateFinConge)
        {
            dateFinConge = unedateFinConge;
        }

        //Getter
        public int GetLenumConge()
        {
            return numConge;
        }

        public string GetdateDebutConge()
        {
            return dateDebutConge;
        }

        public string GetdateFinConge()
        {
            return dateFinConge;
        }
    }
}

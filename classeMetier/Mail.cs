using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_Belle_Table_Classes_métier
{
    class Mail
    {
        private int numMail;
        private string contenuMail;
        private string objetMail;

        public Mail()
        {

        }

        //Setter
        public void SetnumMail(int unnumMail)
        {
            numMail = unnumMail;
        }


        public void SetcontenuMail(string uncontenuMail)
        {
            contenuMail = uncontenuMail;
        }

        public void SetobjetMail(string unobjetMail)
        {
            objetMail = unobjetMail;
        }

        //Getter
        public int GetnumMail()
        {
            return numMail;
        }

        public string GetcontenuMail()
        {
            return contenuMail;
        }

        public string GetobjetMail()
        {
            return objetMail;
        }
    }
}

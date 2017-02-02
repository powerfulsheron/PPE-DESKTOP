using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_Belle_Table_Classes_métier
{
    class Utilisateurs
    {
        private int numUtilsateur;
        private string nomUtilisateur;
        private string adresseUtilisateur;
        private string cpUtilisateur;
        private string villeUtilisateur;
        private string telUtilisateur;
        private string mailUtilisateur;
        private string prenomUtilisateur;
        private string loginUtilisateur;
        private string passwordUtilisateur;
        private string dateDernierLogin;
        private int nbTentatives;
        private int distanceParcourueSemaine;

        public Utilisateurs()
        {

        }

        //Setter
        public void SetnumUtilsateur(int unNumUtilsateur)
        {
            numUtilsateur = unNumUtilsateur;
        }
        public void SetnomUtilisateur(string UnNomUtilisateur)
        {
            nomUtilisateur = UnNomUtilisateur;
        }
        public void SetadresseUtilisateur(string UnadresseUtilisateur)
        {
            adresseUtilisateur = UnadresseUtilisateur;
        }
        public void SetpUtilisateur(string UncpUtilisateur)
        {
            cpUtilisateur = UncpUtilisateur;
        }
        public void SetvilleUtilisateur(string UnevilleUtilisateur)
        {
            villeUtilisateur = UnevilleUtilisateur;
        }
        public void SetTelUtilisateur(string UnTelUtilisateur)
        {
            telUtilisateur = UnTelUtilisateur;
        }
        public void SetmailUtilisateur(string UnmailUtilisateur)
        {
            mailUtilisateur = UnmailUtilisateur;
        }
        public void SetprenomUtilisateur(string UnprenomUtilisateur)
        {
            prenomUtilisateur = UnprenomUtilisateur;
        }
        public void SetoginUtilisateur(string UnloginUtilisateur)
        {
            loginUtilisateur = UnloginUtilisateur;
        }
        public void SetpasswordUtilisateur(string UnpasswordUtilisateur)
        {
            passwordUtilisateur = UnpasswordUtilisateur;
        }
        public void SetdateDernierLogin(string UnedateDernierLogin)
        {
            dateDernierLogin = UnedateDernierLogin;
        }
        public void SetnbTentatives(int UnNbTentatives)
        {
            nbTentatives = UnNbTentatives;
        }
        public void SetDistanceParcourueSemaine(int UneDdistanceParcourueSemaine)
        {
            distanceParcourueSemaine = UneDdistanceParcourueSemaine;
        }

        //Getter
        public int GetnumUtilsateur()
        {
           return numUtilsateur;
        }
        public string GetnomUtilisateur()
        {
            return nomUtilisateur;
        }
        public string GetadresseUtilisateur()
        {
            return adresseUtilisateur;
        }
        public string GetpUtilisateur()
        {
            return cpUtilisateur;
        }
        public string GetvilleUtilisateur()
        {
            return villeUtilisateur;
        }
        public string GetTelUtilisateur()
        {
            return telUtilisateur;
        }
        public string GetmailUtilisateur()
        {
            return mailUtilisateur;
        }
        public string GetprenomUtilisateur()
        {
            return prenomUtilisateur;
        }
        public string GetoginUtilisateur()
        {
            return loginUtilisateur;
        }
        public string GetpasswordUtilisateur()
        {
            return passwordUtilisateur;
        }
        public string GetdateDernierLogin()
        {
            return dateDernierLogin;
        }
        public int GetnbTentatives()
        {
            return nbTentatives;
        }
        public int GetDistanceParcourueSemaine()
        {
            return distanceParcourueSemaine;
        }
    }
}

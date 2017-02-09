using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_Belle_Table_Classes_métier
{
    class Utilisateur
    {
        private Integer numUtilsateur;
        private String nomUtilisateur;
        private String adresseUtilisateur;
        private String cpUtilisateur;
        private String villeUtilisateur;
        private String telUtilisateur;
        private String mailUtilisateur;
        private String prenomUtilisateur;
        private String loginUtilisateur;
        private String passwordUtilisateur;
        private DateTime dateDernierLogin;
        private Integer nbTentatives;
        private Float distanceParcourueSemaine;

        public Utilisateur()
        {

        }

        public Integer GetNumUtilsateur()
        {
           return this.numUtilsateur;
        }
                      
        public void SetNumUtilsateur(Integer unNumUtilsateur)
        {
            this.numUtilsateur = unNumUtilsateur;
        }
        
        public String GetNomUtilisateur()
        {
            return this.nomUtilisateur;
        }
        
        public void SetNomUtilisateur(String unNomUtilisateur)
        {
            this.nomUtilisateur = unNomUtilisateur;
        }
        
        public String GetPrenomUtilisateur()
        {
            return this.prenomUtilisateur;
        }
        
        public void SetPrenomUtilisateur(String unPrenomUtilisateur)
        {
            this.prenomUtilisateur = unPrenomUtilisateur;
        }
        
        public String GetAdresseUtilisateur()
        {
            return this.adresseUtilisateur;
        }
        
        public void SetAdresseUtilisateur(String uneAdresseUtilisateur)
        {
            this.adresseUtilisateur = uneAdresseUtilisateur;
        }
        
        public String GetCpUtilisateur()
        {
            return this.cpUtilisateur;
        }
        
        public void (String unCpUtilisateur)
        {
            this.cpUtilisateur = unCpUtilisateur;
        }
        
        public String GetVilleUtilisateur()
        {
            return this.villeUtilisateur;
        }
        
        public void SetVilleUtilisateur(String uneVilleUtilisateur)
        {
            this.villeUtilisateur = UnevilleUtilisateur;
        }
        
        public String GetTelUtilisateur()
        {
            return this.telUtilisateur;
        }
        
        public void SetTelUtilisateur(String UnTelUtilisateur)
        {
            this.telUtilisateur = unTelUtilisateur;
        }
                
        public String GetMailUtilisateur()
        {
            return this.mailUtilisateur;
        }
        
        public void SetMailUtilisateur(String unMailUtilisateur)
        {
            this.mailUtilisateur = unMailUtilisateur;
        }
               
        public String GetLoginUtilisateur()
        {
            return this.loginUtilisateur;
        }
        
        public void SetLoginUtilisateur(String unLoginUtilisateur)
        {
            this.loginUtilisateur = unloginUtilisateur;
        }
        
        public String GetPasswordUtilisateur()
        {
            return this.passwordUtilisateur;
        }
        
        public void SetPasswordUtilisateur(String unPasswordUtilisateur)
        {
            this.passwordUtilisateur = unPasswordUtilisateur;
        }
        
        public DateTime GetDateDernierLogin()
        {
            return this.dateDernierLogin;
        }
        
        public void SetdateDernierLogin(DateTime uneDateDernierLogin)
        {
            this.dateDernierLogin = uneDateDernierLogin;
        }
        
        public Integer GetNbTentatives()
        {
            return this.nbTentatives;
        }
        
        public void SetNbTentatives(Integer unNbTentatives)
        {
            this.nbTentatives = unNbTentatives;
        }
        
        public Float GetDistanceParcourueSemaine()
        {
            return this.distanceParcourueSemaine;
        }
        
        public void SetDistanceParcourueSemaine(Float uneDistanceParcourueSemaine)
        {
            this.distanceParcourueSemaine = uneDistanceParcourueSemaine;
        }
            
    }
}

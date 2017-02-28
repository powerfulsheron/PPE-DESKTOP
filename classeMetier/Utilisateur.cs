using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BelleTable.CongesClass;
using BelleTable.MailClass;
using BelleTable.PorteFeuilleClass;
using BelleTable.PlanningClass;
using BelleTable.TypeUtilisateurClass;

namespace BelleTable.UtilisateurClass
{
    class Utilisateur
    {
        private int numUtilsateur;
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
        private int nbTentatives;
        private float distanceParcourueSemaine;
        
        private List<Conges> conges;
        private PorteFeuille portefeuille;
        private List<Mail> mails;
        private Planning planning;
        private TypeUtilisateur typeUtilisateur;

        public Utilisateur()
        {

        }

        public int GetNumUtilsateur()
        {
           return this.numUtilsateur;
        }
                      
        public void SetNumUtilsateur(int unNumUtilsateur)
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
        
        public void SetCpUtilisateur(String unCpUtilisateur)
        {
            this.cpUtilisateur = unCpUtilisateur;
        }
        
        public String GetVilleUtilisateur()
        {
            return this.villeUtilisateur;
        }
        
        public void SetVilleUtilisateur(String uneVilleUtilisateur)
        {
            this.villeUtilisateur = uneVilleUtilisateur;
        }
        
        public String GetTelUtilisateur()
        {
            return this.telUtilisateur;
        }
        
        public void SetTelUtilisateur(String unTelUtilisateur)
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
            this.loginUtilisateur = unLoginUtilisateur;
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
        
        public int GetNbTentatives()
        {
            return this.nbTentatives;
        }
        
        public void SetNbTentatives(int unNbTentatives)
        {
            this.nbTentatives = unNbTentatives;
        }
        
        public float GetDistanceParcourueSemaine()
        {
            return this.distanceParcourueSemaine;
        }
        
        public void SetDistanceParcourueSemaine(float uneDistanceParcourueSemaine)
        {
            this.distanceParcourueSemaine = uneDistanceParcourueSemaine;
        }
        
        public List<Conges> GetConges()
        {
            return this.conges;
        }
        
        public void SetConges(List<Conges> uneListeConges)
        {
            this.conges=uneListeConges;
        }
        
        public Planning GetPlanning()
        {
            return this.planning;
        }
        
        public void SetPlanning(Planning unPlanning)
        {
            this.planning=unPlanning;
        }
                       
        public List<Mail> GetMails()
        {
            return this.mails;
        }
        
        public void SetMails(List<Mail> uneListeMails)
        {
            this.mails=uneListeMails;
        }
                        
        public TypeUtilisateur GetTypeUtilisateur()
        {
            return this.typeUtilisateur;
        }
        
        public void SetTypeUtilisateur(TypeUtilisateur unTypeUtilisateur)
        {
            this.typeUtilisateur=unTypeUtilisateur;
        }
      /*  public void ChargerUtilisateur(Connexion maConnexion, int id_utilisateur) 
        {
            DataTable dt = maConnexion.Select("SELECT * FROM MAIL WHERE id_utilisateur=",id_utilisateur);
            //ouéouéoué on sait plus a quoi ça sert
        }
        
        public DataTable chargerLePorteFeuille(int idUtilsateur)
        {
            DataTable LePortefeuille = DatabaseConnect.Select("SELECT * FROM portefeuille WHERE numUtilisateur=",idUtilsateur);

            return LePortefeuille;
        }
        */
    }
}

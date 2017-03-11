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
using System.Data;
using BelleTable.DatabaseConnectClass;

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

        private DatabaseConnect maDatabase;
        private List<Conges> conges;
        private PorteFeuille portefeuille;
        private List<Mail> mails;
        public Planning planning;
        private TypeUtilisateur typeUtilisateur;

        public Utilisateur()
        {

        }

        public int GetNumUtilsateur()
        {
           return numUtilsateur;
        }
                      
        public void SetNumUtilsateur(int unNumUtilsateur)
        {
            numUtilsateur = unNumUtilsateur;
        }
        
        public String GetNomUtilisateur()
        {
            return nomUtilisateur;
        }
        
        public void SetNomUtilisateur(String unNomUtilisateur)
        {
            nomUtilisateur = unNomUtilisateur;
        }
        
        public String GetPrenomUtilisateur()
        {
            return prenomUtilisateur;
        }
        
        public void SetPrenomUtilisateur(String unPrenomUtilisateur)
        {
            prenomUtilisateur = unPrenomUtilisateur;
        }
        
        public String GetAdresseUtilisateur()
        {
            return adresseUtilisateur;
        }
        
        public void SetAdresseUtilisateur(String uneAdresseUtilisateur)
        {
            adresseUtilisateur = uneAdresseUtilisateur;
        }
        
        public String GetCpUtilisateur()
        {
            return cpUtilisateur;
        }
        
        public void SetCpUtilisateur(String unCpUtilisateur)
        {
            cpUtilisateur = unCpUtilisateur;
        }
        
        public String GetVilleUtilisateur()
        {
            return villeUtilisateur;
        }
        
        public void SetVilleUtilisateur(String uneVilleUtilisateur)
        {
            villeUtilisateur = uneVilleUtilisateur;
        }
        
        public String GetTelUtilisateur()
        {
            return telUtilisateur;
        }
        
        public void SetTelUtilisateur(String unTelUtilisateur)
        {
            telUtilisateur = unTelUtilisateur;
        }
                
        public String GetMailUtilisateur()
        {
            return mailUtilisateur;
        }
        
        public void SetMailUtilisateur(String unMailUtilisateur)
        {
            mailUtilisateur = unMailUtilisateur;
        }
               
        public String GetLoginUtilisateur()
        {
            return loginUtilisateur;
        }
        
        public void SetLoginUtilisateur(String unLoginUtilisateur)
        {
            loginUtilisateur = unLoginUtilisateur;
        }
        
        public String GetPasswordUtilisateur()
        {
            return passwordUtilisateur;
        }
        
        public void SetPasswordUtilisateur(String unPasswordUtilisateur)
        {
            passwordUtilisateur = unPasswordUtilisateur;
        }
        
        public DateTime GetDateDernierLogin()
        {
            return dateDernierLogin;
        }
        
        public void SetdateDernierLogin(DateTime uneDateDernierLogin)
        {
            dateDernierLogin = uneDateDernierLogin;
        }
        
        public int GetNbTentatives()
        {
            return nbTentatives;
        }
        
        public void SetNbTentatives(int unNbTentatives)
        {
            nbTentatives = unNbTentatives;
        }
        
        public float GetDistanceParcourueSemaine()
        {
            return distanceParcourueSemaine;
        }
        
        public void SetDistanceParcourueSemaine(float uneDistanceParcourueSemaine)
        {
            distanceParcourueSemaine = uneDistanceParcourueSemaine;
        }
        
        public List<Conges> GetConges()
        {
            return conges;
        }
        
        public void SetConges(List<Conges> uneListeConges)
        {
            conges=uneListeConges;
        }
        
        public Planning GetPlanning()
        {
            return planning;
        }
        
        public void SetPlanning(Planning unPlanning)
        {
            planning=unPlanning;
        }
                       
        public List<Mail> GetMails()
        {
            return mails;
        }
        
        public void SetMails(List<Mail> uneListeMails)
        {
            mails=uneListeMails;
        }
                        
        public TypeUtilisateur GetTypeUtilisateur()
        {
            return typeUtilisateur;
        }
        
        public void SetTypeUtilisateur(TypeUtilisateur unTypeUtilisateur)
        {
            typeUtilisateur=unTypeUtilisateur;
        }
        public DataTable ChargerUtilisateur(int id_utilisateur) 
        {
            DataTable dt = maDatabase.Select("SELECT * FROM MAIL WHERE id_utilisateur=@" + id_utilisateur);
            return dt;
        }
        
        public DataTable chargerLePorteFeuille(int idUtilsateur)
        {
            DataTable LePortefeuille = maDatabase.Select("SELECT * FROM portefeuille WHERE numUtilisateur=@" + idUtilsateur);

            return LePortefeuille;
        }
        
    }
}

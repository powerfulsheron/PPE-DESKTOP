using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BelleTable.DatabaseConnectClass;
using BelleTable.UtilisateurClass;
using System.Data;

namespace BelleTable.MailClass
{
    class Mail
    {
        private int numMail;
        private string contenuMail;
        private string objetMail;
        private DatabaseConnect maDatabase;
        private Utilisateur unUtilisateur;

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
        
         public DataTable ChargerLesMails(int id_salarie) 
        {
            DataTable dt = maDatabase.Select("SELECT * FROM MAIL WHERE id_salarie=@"+unUtilisateur.GetNumUtilsateur());
            return dt;
        }

        public void AjouterUnMail()
        {
            maDatabase.Insert("INSERT INTO MAIL (contenuMail, objetMail, id_interlocuteur) VALUES (this.cotenuMail, this.objetMail, this.id_interlocuteur)");
        }
        
        }
}

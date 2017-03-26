
using System;
namespace Maquette_Belle_Table_Final
{
    public class Mail
    {
        // propriétés automatiques 
        public virtual int numMail { get; set; }
        public virtual string contenuMail { get; set; }
        public virtual string objetMail { get; set; }
        public virtual Utilisateur utilisateur { get; set; }
        public virtual Interlocuteur interlocuteur { get; set; }

        // constructeurs 
        public Mail()
        {
        }
        // ToString 
        public override string ToString()
        {
            return string.Format("[{0}|{1}|{2}|{3}]", contenuMail, objetMail, utilisateur, interlocuteur);
        }
    }

}
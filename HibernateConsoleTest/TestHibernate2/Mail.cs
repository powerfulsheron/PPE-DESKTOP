namespace PamNHibernateDemos
{
    public class Mail
    {
        // propriétés automatiques 
        public virtual int numMail { get; set; }
        public virtual string contenuMail { get; set; }
        public virtual string objetMail { get; set; }
        public virtual int numUtilisateur { get; set; }
        public virtual int id_interlocuteur { get; set; }
        public virtual Utilisateur utilisateur { get; set; }
        public virtual Interlocuteur interlocuteur { get; set; }            

        // constructeurs 
        public Mail()
        {
        }
        // ToString 
        public override string ToString()
        {
            return string.Format("[{0}|{1}|{2}|{3}|{4}|{5}]", contenuMail, objetMail, numUtilisateur, id_interlocuteur, utilisateur, interlocuteur);
        }
    }

}
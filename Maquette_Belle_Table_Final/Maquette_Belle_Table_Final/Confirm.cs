using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Linq;

namespace Maquette_Belle_Table_Final
{
    public partial class Confirm : Form
    {
        public Individu individu { get; set; }
        public Interlocuteur interlocuteur { get; set; }
        public InterlocuteurStructure interlocuteurStructure { get; set; }
        public Boolean isIndividu { get; set; }
        public InterUti interUti { get; set; }
        private static ISessionFactory sessionFactory = new Configuration().Configure().BuildSessionFactory();



        public Confirm()
        {
            InitializeComponent();
        }

        private void Confirm_Load(object sender, EventArgs e)
        {
        //    if(isIndividu)
        //    {
        //    interlocuteur = individu.interlocuteur;
        //    }
        //    else if (!isIndividu)
        //    {
        //    interlocuteur = interlocuteurStructure.interlocuteur;
         //   }

           labelConfirm.Text = "Voulez-vous vraiment supprimer l'interlocuteur : " + interlocuteur.nomInterlocuteur + " " + interlocuteur.prenomInterlocuteur+" ?";
        }

        private void buttonNon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOui_Click(object sender, EventArgs e)
        {  
            ISession session = sessionFactory.OpenSession();
            using (ITransaction transaction = session.BeginTransaction())
            {
                if (isIndividu)
                {
      
                    session.Delete(individu);
                }
                if (!isIndividu)
                {
                    session.Delete(interlocuteurStructure);
                    
                }
                transaction.Commit();
                session.Dispose();
            }
            interUti.chargerDatagridInterlocuteurs();
            this.Close();
        }
    }
}

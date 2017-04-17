using Maquette_Belle_Table_Final;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maquette_Belle_Table_Final
{
    public partial class Popup_NewPF : Form
    {
        private static ISessionFactory sessionFactory = new Configuration().Configure().BuildSessionFactory();

        public Utilisateur utilisateur = new Utilisateur();

        public Popup_NewPF()
        {
            InitializeComponent();
        }

        private void buttonVal_Click(object sender, EventArgs e)
        {

            buttonVal.DialogResult = DialogResult.OK;
            using (ISession session = sessionFactory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    if (checkBox1.Checked == true)
                    {
                        PorteFeuille portefeuille = new PorteFeuille();
                        portefeuille.libellePortefeuille = textBoxPF.Text;
                        portefeuille.utilisateur = (Utilisateur)comboBox1.SelectedItem;
                        session.Save(portefeuille);
                        transaction.Commit();
                    }
                    
                }

                session.Dispose();
            }
        }

        private void buttonAnul_Click(object sender, EventArgs e)
        {
            buttonAnul.DialogResult = DialogResult.Cancel;
        }

        private void Popup_NewPF_Load(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            labelComm.Visible = false;
            Utilisateur lesUtilisateurs = new Utilisateur();
            comboBox1.DataSource = lesUtilisateurs.GetLesUtilisateurs();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utilisateur forCombobox = (Utilisateur)comboBox1.SelectedItem;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                comboBox1.Visible = true;
                labelComm.Visible = true;
            }
            else
            {
                comboBox1.Visible = false;
                labelComm.Visible = false;
            }
        }
    }
}

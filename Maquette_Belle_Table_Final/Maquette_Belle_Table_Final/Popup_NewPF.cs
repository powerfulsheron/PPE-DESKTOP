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
                    if (checkBoxSelect.Checked == true)
                    {
                        PorteFeuille portefeuille = new PorteFeuille();
                        portefeuille.libellePortefeuille = textBoxPF.Text;
                        portefeuille.utilisateur = (Utilisateur)comboBoxCom.SelectedItem;
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

        private void comboBoxCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utilisateur forCombobox = (Utilisateur)comboBoxCom.SelectedItem;
        }

        private void checkBoxSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSelect.Checked == true)
            {
                comboBoxCom.Visible = true;
                labelComm.Visible = true;
            }
            else
            {
                comboBoxCom.Visible = false;
                labelComm.Visible = false;
            }
        }

        private void textBoxPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void Popup_NewPF_Load(object sender, EventArgs e)
        {
            comboBoxCom.Visible = false;
            labelComm.Visible = false;
            Utilisateur lesUtilisateurs = new Utilisateur();
            comboBoxCom.DataSource = lesUtilisateurs.GetLesUtilisateurs();
        }
    }
}

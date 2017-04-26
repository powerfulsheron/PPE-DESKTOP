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
        public PorteFeuille portefeuille = new PorteFeuille();
        private InterGes interges = null;
        public PorteFeuille Portefeuille { get; set; }


        public Popup_NewPF(InterGes intergesCall)
        {
            interges = intergesCall as InterGes;
            InitializeComponent();
        }
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
                    if (radioButtonAjout.Checked == true) 
                    {
                        PorteFeuille portefeuille = new PorteFeuille();
                        portefeuille.libellePortefeuille = textBoxPF.Text;
                        if (checkBoxselect.Checked == true)
                        {
                            portefeuille.utilisateur = (Utilisateur)comboBoxCom.SelectedItem;
                        }
                        else
                        {
                            portefeuille.utilisateur = null;
                        }
                        session.SaveOrUpdate(portefeuille);
                        transaction.Commit();
                    }
                    if (radioButtonModif.Checked == true)
                    {
                        portefeuille.libellePortefeuille = textBoxPF.Text;
                        portefeuille.utilisateur = (Utilisateur)comboBoxCom.SelectedItem;
                        session.SaveOrUpdate(portefeuille);
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
        private void textBoxPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void Popup_NewPF_Load(object sender, EventArgs e)
        {
            radioButtonAjout.Checked = true;
            comboBoxCom.Visible = false;
            labelComm.Visible = false;
            comboBoxC.Visible = false;
            labelcom.Visible = false;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonAjout_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAjout.Checked == true)
            {
                comboBoxCom.Visible = false;
                labelComm.Visible = false;
                checkBoxselect.Visible = true;
                textBoxPF.Clear();
                if (portefeuille.utilisateur == null)
                {
                    using (ISession session = sessionFactory.OpenSession())
                    { // permet de charger les utilisateur sans portefeuille
                        var l = session.CreateQuery("from Utilisateur u where u.porteFeuille is null").List<Utilisateur>();
                        comboBoxCom.DataSource = l;
                        session.Close();
                    }
                }
            }
        }

        private void radioButtonModif_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonModif.Checked == true)
            {
                textBoxPF.Text = portefeuille.libellePortefeuille;
                checkBoxselect.Visible = false;
                checkBoxselect.Checked = false;
                comboBoxC.Visible = true;
                labelcom.Visible = true;
                
                if (portefeuille.utilisateur != null)
                {
                    using (ISession session = sessionFactory.OpenSession())
                    { // permet de charger les utilisateur avec portefeuille
                        var l = session.CreateQuery("from Utilisateur u where u.porteFeuille is not null").List<Utilisateur>();
                        comboBoxC.DataSource = l;
                        session.Close();
                    }
                    /**
                    foreach(PorteFeuille n in comboBoxC.Items)
                    {
                        if (n.libellePortefeuille == utilisateur.porteFeuille.libellePortefeuille)
                        {
                            comboBoxC.SelectedItem = n;
                        }
                    }
    **/
                }

            }
            else
            {
                comboBoxC.Visible = false;
                labelcom.Visible = false;
                textBoxPF.Clear();
            }
        }

        private void checkBoxselect_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxselect.Checked == true)
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
    }
}

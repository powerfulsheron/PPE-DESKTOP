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

namespace Maquette_Belle_Table
{
    public partial class Popup_ModifierClient : Form
    {
        public Utilisateur utilisateur { get; set; }
        public Interlocuteur interlocuteur { get; set; }
        public Individu individu { get; set; }
        public InterlocuteurStructure interlocuteurStructure { get; set; }
        public Boolean particulier { get; set; }

        private static ISessionFactory sessionFactory = new Configuration().Configure().BuildSessionFactory();
        ISession session = sessionFactory.OpenSession();

        public Popup_ModifierClient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Popup_ModifierClient.ActiveForm.Close();
        }

        private void radioButtonOui_CheckedChanged(object sender, EventArgs e)
        {

            groupBoxParticulier.Visible = true;
            groupBoxAS.Visible = false;
            groupBoxStructureExistante.Visible = false;
        }

        private void radioButtonNon_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNon.Checked)
            {
                groupBoxStructureExistante.Visible = true;
                groupBoxAS.Visible = false;
                groupBoxParticulier.Visible = false;

            }
        }

        private void buttonVal_Click(object sender, EventArgs e)
        {

            using (ISession session = sessionFactory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    interlocuteur.nomInterlocuteur = textBoxNom.Text;
                    interlocuteur.prenomInterlocuteur = textBoxPrenom.Text;
                    interlocuteur.telInterlocuteur = textBoxTel.Text;
                    interlocuteur.mailInterlocuteur = textBoxMail.Text;
                    interlocuteur.porteFeuille = utilisateur.porteFeuille;
                    MessageBox.Show(interlocuteur.porteFeuille.ToString());
                    session.Save(interlocuteur);
                    transaction.Commit();
                }

                if (radioButtonOui.Checked == true)
                {

                    using (ITransaction transaction = session.BeginTransaction())
                    {

                        Individu individu = new Individu();
                        individu.adresseIndividu = textBoxAdresse.Text;
                        individu.cpIndividu = textBoxCp.Text;
                        individu.villeIndividu = textBoxVille.Text;
                        individu.distanceSiege = Int32.Parse(textBoxDistance.Text);
                        individu.infosSupplementaire = textBoxIC.Text;
                        MessageBox.Show(interlocuteur.idInterlocuteur.ToString());
                        individu.interlocuteur = interlocuteur;
                        session.Save(individu);
                        transaction.Commit();
                    }

                }
                else
                {
                    if (radioNouvelleStructureOui.Checked == true)
                    {
                        using (ITransaction transaction = session.BeginTransaction())
                        {

                            Structure structure = new Structure();
                            structure.typeStructure = (TypeStructure)comboBoxTS.SelectedItem;
                            structure.denominationSociale = textBoxDS.Text;
                            structure.adresseStructure = textBoxAdresse.Text;
                            structure.cpStructure = textBoxCp.Text;
                            structure.villeStructure = textBoxVille.Text;
                            structure.distanceSiege = float.Parse(textBoxDistanceKm.Text);
                            structure.infoSupplementaire = textBoxIC.Text;
                            session.Save(structure);
                            InterlocuteurStructure interlocuteurStructure = new InterlocuteurStructure();
                            interlocuteurStructure.interlocuteur = interlocuteur;
                            interlocuteurStructure.structure = structure;
                            session.Save(interlocuteurStructure);
                            transaction.Commit();
                        }


                    }
                    else
                    {
                        using (ITransaction transaction = session.BeginTransaction())
                        {

                            InterlocuteurStructure interlocuteurStructure = new InterlocuteurStructure();
                            interlocuteurStructure.interlocuteur = interlocuteur;
                            interlocuteurStructure.structure = (Structure)comboBoxChoixStructure.SelectedItem;
                            session.Save(interlocuteurStructure);
                            transaction.Commit();
                        }

                    }


                }
                session.Dispose();
            }

        }


        private void buttonAnul_Click(object sender, EventArgs e)
        {
            buttonAnul.DialogResult = DialogResult.Cancel;
        }

        private void labelFermeture_Click(object sender, EventArgs e)
        {

        }

        private void panelBorderRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBordeLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBorderBottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNom_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxAP_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxVille_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCp_TextChanged(object sender, EventArgs e)
        {

        }


        private void labelRue_Click(object sender, EventArgs e)
        {

        }

        private void labelCP_Click(object sender, EventArgs e)
        {

        }

        private void labelVille_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPrénom_Click(object sender, EventArgs e)
        {

        }


        private void labelTel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxAS_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxTS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelTS_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDS_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDS_Click(object sender, EventArgs e)
        {

        }

        private void textBoxICAS_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelICAS_Click(object sender, EventArgs e)
        {

        }

        private void textBoxVAS_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCPAS_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRAS_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelRAS_Click(object sender, EventArgs e)
        {

        }

        private void labelCPAS_Click(object sender, EventArgs e)
        {

        }

        private void labelVAS_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelIC_Click(object sender, EventArgs e)
        {

        }


        private void Popup_ModifierClient_Load(object sender, EventArgs e)
        {
            TypeStructure lesTypeStructure = new TypeStructure();
            comboBoxTS.DataSource = lesTypeStructure.GetLesTypesStructure();
            comboBoxChoixStructure.DataSource = session.CreateQuery(@"select e from Structure e order by e.denominationSociale asc").List<Structure>();
         
            if (interlocuteur != null)
            {
                if (interlocuteur.nomInterlocuteur != null)
                    textBoxNom.Text = interlocuteur.nomInterlocuteur;

                if (interlocuteur.prenomInterlocuteur != null)
                    textBoxPrenom.Text = interlocuteur.prenomInterlocuteur;

                if (interlocuteur.telInterlocuteur != null)
                    textBoxTel.Text = interlocuteur.telInterlocuteur;

                if (interlocuteur.telInterlocuteur != null)
                    textBoxTel.Text = interlocuteur.telInterlocuteur;

                if (interlocuteur.mailInterlocuteur != null)
                    textBoxMail.Text = interlocuteur.mailInterlocuteur;

               // Si l'interlocuteur est un particulier 
                if (particulier)
                {
   
                    Individu individu = session.CreateQuery("select e from Individu e where e.interlocuteur.idInterlocuteur=:num").SetParameter("num", interlocuteur.idInterlocuteur).UniqueResult<Individu>();
          
                    if (individu.adresseIndividu != null)
                        textBoxAdresse.Text = individu.adresseIndividu;

                    if (individu.cpIndividu != null)
                        textBoxCp.Text = individu.cpIndividu;

                    if (individu.villeIndividu != null)
                        textBoxVille.Text = individu.villeIndividu;

                    if (individu.distanceSiege != null)
                        textBoxDistance.Text = individu.distanceSiege.ToString();

                    if (individu.infosSupplementaire != null)
                        textBoxIC.Text = individu.infosSupplementaire;
                }

                // Si l'interlocuteur est un interlocuteur_structure
                if (!particulier)
                {
           
                    groupBoxParticulier.Visible = false;
                    InterlocuteurStructure interlocuteurStructure = session.CreateQuery("select e from InterlocuteurStructure e where e.interlocuteur.idInterlocuteur=:num").SetParameter("num", interlocuteur.idInterlocuteur).UniqueResult<InterlocuteurStructure>();

                    if (interlocuteurStructure.structure != null)
                    {
                        foreach (Structure s in comboBoxChoixStructure.Items)
                        {
                            if (s.numStructure == interlocuteurStructure.structure.numStructure)
                            {
                                comboBoxChoixStructure.SelectedItem = s;
                            }
                        }
                    }


                }


            }
        }
        static Boolean AjouterClient(Interlocuteur unInterlocuteur, string unnomclient, string unprenomclient, string untelclient,
            string unmailclient, Individu unindividu, Structure unestructure, PorteFeuille unPortefeuille)
        {
            sessionFactory = new Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();

            using (ITransaction transaction = session.BeginTransaction())

            {
                Interlocuteur I = new Interlocuteur();

                if (unInterlocuteur == null) { return false; }
                if (unnomclient.Length == 0) { return false; } else { I.nomInterlocuteur = unnomclient; }
                if (unprenomclient.Length == 0) { return false; } else { I.prenomInterlocuteur = unprenomclient; }
                if (untelclient.Length == 0) { return false; } else { I.telInterlocuteur = untelclient; }
                if (unmailclient.Length == 0) { return false; } else { I.mailInterlocuteur = unmailclient; }
                if (unindividu == null) { return false; }
                if (unestructure == null) { return false; }

                session.Save(I);
                transaction.Commit();
                session.Dispose();
                return true;

            }
        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAdresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDistance_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPlan_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            labelStructure.Visible = true;
            comboBoxChoixStructure.Visible = true;
            groupBoxAS.Visible = false;
        }

        private void radioNouvelleStructureOui_CheckedChanged(object sender, EventArgs e)
        {
            labelStructure.Visible = false;
            comboBoxChoixStructure.Visible = false;
            groupBoxAS.Visible = true;
        }
    }
}
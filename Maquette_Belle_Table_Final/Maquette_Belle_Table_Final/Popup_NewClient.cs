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
    public partial class Popup_NewClient : Form
    {
        public Utilisateur utilisateur { get; set; }
        Interlocuteur interlocuteur = new Interlocuteur();
        private static ISessionFactory sessionFactory = new Configuration().Configure().BuildSessionFactory();
        ISession session = sessionFactory.OpenSession();
        public Popup_NewClient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Popup_NewClient.ActiveForm.Close();
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
                            individu.planAcces = textBoxPlan.Text;
                            individu.infosSupplementaire = textBoxIC.Text;
                            MessageBox.Show(interlocuteur.idInterlocuteur.ToString());
                            individu.interlocuteur = interlocuteur;
                            MessageBox.Show(individu.adresseIndividu + individu.planAcces + individu.interlocuteur.idInterlocuteur.ToString());
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
                    else {
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


        private void Popup_NewClient_Load(object sender, EventArgs e)
        {
            TypeStructure lesTypeStructure = new TypeStructure();
            comboBoxTS.DataSource = lesTypeStructure.GetLesTypesStructure();
            groupBoxAS.Visible = false;
            comboBoxChoixStructure.DataSource = session.CreateQuery(@"select e from Structure e order by e.denominationSociale asc").List<Structure>();
            
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

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
    public partial class PopNouveauRDV : Form
    {
        private static ISessionFactory sessionFactory = null;

        public PopNouveauRDV()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            PopNouveauRDV.ActiveForm.Close();
        }

        private void buttonAnul_Click(object sender, EventArgs e)
        {
            buttonAnul.DialogResult = DialogResult.Cancel;
        }

        private void buttonVal_Click(object sender, EventArgs e)
        {
            buttonVal.DialogResult = DialogResult.OK;
        }

        private void buttonVal_Click_1(object sender, EventArgs e)
        {

        }

        private void PopNouveauRDV_Load(object sender, EventArgs e)
        {
            comboBoxTRDV.DataSource = GetLesTypesRdv();
        }

        public virtual IList<TypeRdv> GetLesTypesRdv()
        {
            sessionFactory = new Configuration().Configure().BuildSessionFactory();
            using (ISession session = sessionFactory.OpenSession())
            {
                // début transaction 
                using (ITransaction transaction = session.BeginTransaction())
                {

                    // on récupère la liste des typerdv 
                    IList<TypeRdv> typerdv = session.CreateQuery(@"select e from typerdv e order by e.id_type_rdv asc").List<TypeRdv>();

                    foreach (TypeRdv e in typerdv)
                    {
                        Console.WriteLine(e);
                    }
                    return typerdv;

                }
            }

        }
    }
}

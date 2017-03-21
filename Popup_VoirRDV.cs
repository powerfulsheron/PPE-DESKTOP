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
    public partial class Popup_VoirRDV : Form
    {
        public Popup_VoirRDV()
        {
            InitializeComponent();
        }

        private void labelFermeture_Click(object sender, EventArgs e)
        {
            Popup_VoirRDV.ActiveForm.Close();
        }

        private void buttonVRDV_Click(object sender, EventArgs e)
        {
            new Maquette_Belle_Table.PopNouveauRDV().Show();
        }

        private void listViewVRDV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

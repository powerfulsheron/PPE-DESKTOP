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

     }
}

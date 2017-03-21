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
    public partial class Popup_NewInter : Form
    {
        public Popup_NewInter()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Popup_NewInter.ActiveForm.Show();
        }

        private void comboBoxNomPF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonVal_Click(object sender, EventArgs e)
        {
            buttonVal.DialogResult = DialogResult.OK;
        }

        private void buttonAnul_Click(object sender, EventArgs e)
        {
            buttonAnul.DialogResult = DialogResult.Cancel;
        }
    }
}

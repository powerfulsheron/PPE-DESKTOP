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
    public partial class Popup_AssoCom : Form
    {
        public Popup_AssoCom()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Popup_AssoCom.ActiveForm.Show();
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void cmbScore_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (cmbScore.Text == "") 
            {
                MessageBox.Show("A score type has to be selected");
            }
            else if (cmbScore.Text == "Excellent")
            {
                Form7 frm = new Form7();
                frm.Show();
                frm.Activate();
            }
            else if (cmbScore.Text == "Good")
            {
                Form8 frm = new Form8();
                frm.Show();
                frm.Activate();
            }
            else if (cmbScore.Text == "Average")
            {
                Form9 frm = new Form9();
                frm.Show();
                frm.Activate();
            }
            else if (cmbScore.Text == "Dissatisfied")
            {
                Form10 frm = new Form10();
                frm.Show();
                frm.Activate();
            }
        }
    }
}

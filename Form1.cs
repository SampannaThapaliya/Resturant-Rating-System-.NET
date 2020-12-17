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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username=="admin" & password=="admin")
            {
                //var myNextForm = new Form2();
                //myNextForm.Show();
                //this.Close();
                Form2 frm = new Form2();
                frm.Show();

            }
            else
            {
                MessageBox.Show("Invalid username or password! Please try again", "Error");
            }
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

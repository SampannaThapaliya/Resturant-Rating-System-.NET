using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\acer\Downloads\criteria.txt";
            List<string> lines = new List<string>();

            lines = File.ReadAllLines(filePath).ToList();
            listBox1.DataSource = lines;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtEnterCriteria.Text == "")
            {
                MessageBox.Show("A criteria has to be entered", "Information");
            }
            else
            {
                string filePath = @"C:\Users\acer\Downloads\criteria.txt";
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(filePath).ToList();

                if (lines.Contains(txtEnterCriteria.Text)) 
                {
                    MessageBox.Show("The entered criteria already exists", "Information");
                    txtEnterCriteria.Text = "";
                }
                else
                {
                    lines.Add(txtEnterCriteria.Text);
                    File.WriteAllLines(filePath, lines);
                    MessageBox.Show("New criteria added successfully", "Success");
                    txtEnterCriteria.Text = "";
                }
            }
        }
    }
}

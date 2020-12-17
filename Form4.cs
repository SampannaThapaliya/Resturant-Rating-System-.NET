using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\acer\Downloads\criteria.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                class1BindingSource.Add(new Class1() { Criteria = line });
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //int[,] mat = new int[dataGridView1.Rows.Count-1, 4];
            //int[] vessel = new int[4];
            string filePath = @"C:\Users\acer\Downloads\criteria.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();

            bool check = true;
            string[] feedback = new string[dataGridView1.Rows.Count];
            List<string> score = new List<string>() {"Excellent", "Good", "Average", "Dissatisfied"};
            for(int row=0; row<dataGridView1.Rows.Count-1; row++) 
            {
                for (int col=1; col<dataGridView1.Columns.Count; col++) 
                {
                    if (dataGridView1.Rows[row].Cells[col].Value is true)
                    {
                        feedback[row] = score[col-1];
                        break;
                    }
                }
            }
            feedback[feedback.Length-1] = DateTime.Now.ToString();

            
            for (int i=0; i<feedback.Length; i++) 
            {
                if (feedback[i] == null) 
                {
                    check = false;
                    MessageBox.Show("Feedback was not given for the criteria: " + lines[i]);
                    break;
                }
            }
            

            
            if (check) 
            {
                string feedbackFilePath = @"C:\Users\acer\Downloads\feedback.txt";
                List<string> feedbackLines = new List<string>();
                feedbackLines = File.ReadAllLines(feedbackFilePath).ToList();
                string concat = string.Join(" ", feedback);
                feedbackLines.Add(concat);
                /*
                if (!File.Exists(FILE_NAME))
                {
                    Console.WriteLine("{0} does not exist.", FILE_NAME);
                    return;
                }
                */

               
                File.WriteAllLines(feedbackFilePath, feedbackLines);
                MessageBox.Show("Your feedback was received successfully", "Success");   
            }
        }
    }
}

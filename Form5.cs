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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\acer\Downloads\criteria.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            // no of rows a
            int[,] mat = new int[lines.Count, 4];
            string feedbackFilePath = @"C:\Users\acer\Downloads\feedback.txt";
            List<string> l = new List<string>();
            l = File.ReadAllLines(feedbackFilePath).ToList();
            
            // feedback.txt ko euta line aayera v ma basyo
            foreach (string v in l)
            {
                // Feedback lai array ma rakhcha -- Yo array ko last tinta element date sanga associated cha ju hamilai chaidiana 
                string[] dat = v.Split(' ');
                
                // This for loop excludes data and time which take 3 indices of the array in feedback.txt thats why we do dat.length-3
                for (int j=0; j<dat.Length-3; j++)
                {
                    int i = j;
                    if (dat[j] == "Excellent") 
                    {
                        mat[i, 0] = mat[i, 0]+1;
                    }
                    else if (dat[j] == "Good") 
                    {
                        mat[i, 1] = mat[i, 1]+1;
                    
                    }
                    else if (dat[j] == "Average")
                    {
                        mat[i, 2] = mat[i, 2]+1;
                    }
                    else if (dat[j] == "Dissatisfied")
                    {
                        mat[i, 3] = mat[i, 3]+1;
                    }
                }
            }

            
            for (int k=0; k<lines.Count; k++) 
            {
                class2BindingSource.Add(new Class2() { Criteria = lines[k], Excellent = mat[k, 0].ToString(), Good = mat[k, 1].ToString(), Average = mat[k, 2].ToString(), Dissatisfied = mat[k, 3].ToString() });  
            }
            
            txtCount.Text = (l.Count).ToString();  
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblscore3_Click(object sender, EventArgs e)
        {

        }

        private void txtscore2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblscore2_Click(object sender, EventArgs e)
        {

        }

        private void txtscore1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblscore1_Click(object sender, EventArgs e)
        {

        }

        private void txtscore3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalculateGrosspay_Click(object sender, EventArgs e)
        {
            double validate;
            

            if (double.TryParse(txttest1.Text, out validate) &&
                double.TryParse(txttest2.Text, out validate) &&
                double.TryParse(txttest3.Text, out validate))
            {

                // creating variables
                double score1 = double.Parse(txttest1.Text);
                double score2 = double.Parse(txttest2.Text);
                double score3 = double.Parse(txttest3.Text);
                double average;

                // all the results must be higgher than 0
                if (score1 < 0 || score2 < 0 || score3 < 0)
                {
                    MessageBox.Show("all scores must higher than 0");
                }
                else if (score1 > 100 || score2 > 100 || score3 > 100)
                {
                    MessageBox.Show("all scores must be lesthan 100");
                }
                else
                {
                    // calculating the Average
                    average = (score1 + score2 + score3) / 3;

                    // display
                    lblaverageoutput.Text = average.ToString();
                }
            }
            else
            {
                MessageBox.Show("Fadlan geli lambar sax ah");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // clearing
            txttest1.Clear();
            txttest2.Clear();
            txttest3.Clear();
            lblaverageoutput.Text = string.Empty;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            // closing
            this.Close();
        }
    }
}

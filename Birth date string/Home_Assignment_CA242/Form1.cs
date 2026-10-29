using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Assignment_CA242
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

        private void btnshow_Click(object sender, EventArgs e)
        {
            //stage 1 : of input
            // creating variables
            string day_of_week;
            string name_of_month;
            int numeric_date;
            int year;
            string fullDate;
            =
            //initial values to variables
            day_of_week = txtweek.Text;
            name_of_month = txtname.Text;
            numeric_date = int.Parse(txtmonth.Text);
            year = int.Parse(txtyear.Text);

            // stage 2 : process - concatination of full date
            fullDate = day_of_week + " / " + name_of_month + " / " + numeric_date + " / " + year;

            // stage 3 : The Output using label
            lbloutput.Text = fullDate;



        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing textbox and label

            //cleaning the textbox
            txtweek.Clear();
            txtname.Clear();
            txtmonth.Clear();
            txtyear.Clear();

            // cleaning the label
            lbloutput.Text = "";


        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            //form closing - using this keyword and close fucntion
            this.Close();
        }
    }
}

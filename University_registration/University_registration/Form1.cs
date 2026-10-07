using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblaverageoutput_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int validate;

            // validate the number of courses using TryParse
            if (int.TryParse(txtcourses.Text, out validate)){

                try
                {

                    // creating variables
                    string name = txtname.Text;
                    int id = int.Parse(txtid.Text);
                    int number_of_courses = int.Parse(txtcourses.Text);
                    int level_year = int.Parse(txtlevel.Text);
                    double transportation_fee = int.Parse(txttransport.Text);
                    double tution_fee = 0;
                    double final = 0;
                    double discount_Amount = 0;

                    // number of courses must be between 1 and 8
                    if (number_of_courses >= 1 && number_of_courses <= 8)
                    {

                        if (level_year == 1)
                        {
                            tution_fee = number_of_courses * 40;
                        }
                        else if (level_year == 2)
                        {
                            tution_fee = number_of_courses * 45;
                        }
                        else if (level_year == 3)
                        {
                            tution_fee = number_of_courses * 50;
                        }
                        else if (level_year == 4)
                        {
                            tution_fee = number_of_courses * 55;
                        }
                        else
                        {
                            MessageBox.Show("the number of year must between 1 upto 4");
                        }


                        // aply discount if the student courses more than 6 courses
                        if (number_of_courses >= 6)
                        {
                            discount_Amount = tution_fee * 0.10;
                        }

                        // final amount 
                        final = tution_fee + transportation_fee - discount_Amount;


                        // display
                        tblnameoutput.Text = "Name : " + name.ToString();
                        tblidoutput.Text = "Id : " + id.ToString();
                        tblcoursesoutput.Text = "Number Courses : " + number_of_courses.ToString();
                        lblstudyoutput.Text = "Study year : " + level_year.ToString();
                        lbltransportoutput.Text = "Transport Fee : " + transportation_fee.ToString();
                        lbldiscountoutput.Text = "Discount : " + discount_Amount.ToString();
                        lbltutionoutput.Text = "Tution fee : " + tution_fee.ToString();
                        lblfinaloutput.Text = "Final Amount : " + final.ToString();


                    }
                    else
                    {
                        MessageBox.Show("the number of courses enter only integer number");
                    }

                } catch (Exception)
                {
                    MessageBox.Show("Enter valid data");
                }


            }
            else
            {
                MessageBox.Show("Please enter valid data in Number of courses");
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing the textboxes
            txtname.Clear();
            txtid.Clear();
            txtcourses.Clear();
            txtlevel.Clear();
            txttransport.Clear();

            // clearing the labels
            tblnameoutput.Text = "";
            tblidoutput.Text = "";
            tblcoursesoutput.Text = "";
            lblstudyoutput.Text = "";
            lbltransportoutput.Text = "";
            lbldiscountoutput.Text = "";
            lbltutionoutput.Text = "";
            lblfinaloutput.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

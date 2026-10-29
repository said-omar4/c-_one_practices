using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_Course_Registration_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string courseName = txtcoursename.Text;
                decimal coursePrice;

                // Validate course name
                if (courseName == "")
                {
                    MessageBox.Show("Please enter course name.");
                    txtcoursename.Focus();
                }

                // Validate course price
                if (!decimal.TryParse(txtcourseprice.Text, out coursePrice))
                {
                    MessageBox.Show("Please enter a valid course price.");
                    txtcourseprice.Focus();
                }

                if (coursePrice <= 0)
                {
                    MessageBox.Show("Course price must be greater than zero.");
                }

                // Allow a maximum of 5 courses
                if ((lscourses.Items.Count /2) >= 5)
                {
                    MessageBox.Show("You can register a maximum of 5 courses.");
                }

                // Prevent duplicate course names using while loop
                int i = 0;

                while (i < lscourses.Items.Count)
                {
                    string existingCourse = lscourses.Items[i].ToString();
                    string existingName = existingCourse.Substring(0);

                    if (existingName.Equals(courseName,StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("This course is already registered.");
                    }

                    i++;
                }

                // Add course name and price to ListBox
                lscourses.Items.Add(courseName);
                lscourses.Items.Add(coursePrice.ToString());

                txtcoursename.Clear();
                txtcourseprice.Clear();
                txtcoursename.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btncourseremove_Click(object sender, EventArgs e)
        {
            try
            {
                // Check whether a course is selected
                if (lscourses.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a course to remove.");
                    return;
                } else
                {
                    // Remove the selected course
                    lscourses.Items.RemoveAt(lscourses.SelectedIndex);

                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string studentName = txtname.Text;
                string studentID = txtid.Text;
                int studentAge;

                // Validate student name and ID
                if (studentName == "" || studentID == "")
                {
                    MessageBox.Show("Please enter student name and ID.");
                }

                // Validate student age
                if (!int.TryParse(txtage.Text, out studentAge))
                {
                    MessageBox.Show("Please enter a valid student age.");
                }

                if (studentAge < 16 || studentAge > 60)
                {
                    MessageBox.Show("Student age must be between 16 and 60.");
                }

                // Check registered courses
                int courseCount = lscourses.Items.Count / 2;

                if (courseCount == 0)
                {
                    MessageBox.Show("Please register at least one course.");
                }

                // Calculate basic registration fee using while loop
                decimal basicFee = 0;
                int i = 1;

                while (i < lscourses.Items.Count)
                {
                    string course = lscourses.Items[i].ToString();

                    string priceText = course;

                    decimal price = decimal.Parse(priceText, System.Globalization.NumberStyles.Currency);

                    basicFee += price;
                    i += 2;
                }

                // Determine course discount
                decimal courseDiscountRate = 0;

                if (courseCount == 1)
                {
                    courseDiscountRate = 0;
                }
                else if (courseCount == 2)
                {
                    courseDiscountRate = 0.05m;
                }
                else if (courseCount == 3 || courseCount == 4)
                {
                    courseDiscountRate = 0.10m;
                }
                else if (courseCount == 5)
                {
                    courseDiscountRate = 0.15m;
                }

                // Calculate both discounts from basic registration fee
                decimal courseDiscount = basicFee * courseDiscountRate;

                decimal scholarshipDiscount = 0;
                if (chkScholarship.Checked)
                {
                    scholarshipDiscount = basicFee * 0.20m;
                }

                // Calculate final registration fee
                decimal finalFee = basicFee - courseDiscount- scholarshipDiscount;

                // Determine registration status
                string registrationStatus = "";

                if (courseCount > 0)
                {
                    registrationStatus = "Approved";
                    // Display results
                    lsresult.Items.Add("------Student Information------");
                    lsresult.Items.Add("Student Name: " + studentName);
                    lsresult.Items.Add("Student ID: " + studentID);
                    lsresult.Items.Add("Number of Courses: " + courseCount);
                    lsresult.Items.Add("");

                    lsresult.Items.Add("Basic Registration Fee:" + basicFee.ToString());
                    lsresult.Items.Add("Course Discount: " + courseDiscount.ToString());
                    lsresult.Items.Add("Scholarship Discount: " + scholarshipDiscount.ToString());
                    lsresult.Items.Add("");

                    lsresult.Items.Add("Final Registration Fee: " + finalFee.ToString());
                    lsresult.Items.Add("Registration Status: " + registrationStatus);
                } else
                {
                    registrationStatus = "Rejected";
                    lsresult.Items.Add("------Student Information------");
                    lsresult.Items.Add("Student Name: " + studentName);
                    lsresult.Items.Add("Student ID: " + studentID);
                    lsresult.Items.Add("Number of Courses: " + courseCount);
                    lsresult.Items.Add("");
                    lsresult.Items.Add("Registration Status: " + registrationStatus);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear all input fields
                txtname.Clear();
                txtage.Clear();
                txtcourseprice.Clear();
                txtcoursename.Clear();
                txtcourseprice.Clear();

                // Clear registered courses
                lscourses.Items.Clear();

                // Reset scholarship checkbox
                chkScholarship.Checked = false;

                // Clear displayed results if using a Label
                lsresult.Items.Clear();

                txtname.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}

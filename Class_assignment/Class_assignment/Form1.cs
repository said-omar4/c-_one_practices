using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_assignment
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

        

        private void btncalculate_Click(object sender, EventArgs e)
        {

            try
            {
                // declaring the varibales to store the data from textbox's
                string food1name = txtfoodonename.Text;
                string food2name = txtfoodtwoname.Text;
                double food1price = double.Parse(txtfoodoneprice.Text);
                double food2price = double.Parse(txtfoodtwoprice.Text);

                // creating the const tax variable
                const double Tax = 7;

                // calculate the sum food charge meal
                double sum = food1price + food2price;

                // calculate the tax of the food charge
                double calculatePercentage = (sum * Tax) / 100;

                // calculate total amount
                double total = sum + calculatePercentage;

                // displaying the outputs
                lbloutputofsum.Text = sum.ToString();
                lbloutputoftax.Text = calculatePercentage.ToString();
                lbloutputoftotal.Text = total.ToString();

            }
            catch (Exception)
            {
                // error message
                MessageBox.Show("Please Enter correct way");
            }




        }
    }
}

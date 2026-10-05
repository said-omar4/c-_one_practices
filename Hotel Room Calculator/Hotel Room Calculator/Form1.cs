using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Room_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {

            lblDiscount.BackColor = Color.Red;
            lblDiscount.ForeColor = Color.Green;
            this.BackColor = Color.Blue;

            try
            {
                // declaring the varibales to store the data from textbox's
                string name = txtGustName.Text;
                string room = txtRoomType.Text;
                double number = double.Parse(txtNights.Text);
                double price = double.Parse(txtPriceNight.Text);

                // creating the const tax variable's
                const double discount = 5;
                const double Tax = 10;


                // calculate the sum
                double sum = price * number;


                // calculate the tax of the food charge
                double taxpercentage = (sum * Tax) / 100;
                double discountpercentage = sum * (discount / 100);


                // calculate total amount
                double total = sum + taxpercentage - discountpercentage;

                // displaying the outputs
                lblServiceTax.Text = taxpercentage.ToString();
                lblDiscount.Text = discountpercentage.ToString();
                lblTotalAmount.Text = total.ToString();

            }
            catch (Exception)
            {
                // error message
                MessageBox.Show("Please Enter correct way");
            }

        }
    }
}

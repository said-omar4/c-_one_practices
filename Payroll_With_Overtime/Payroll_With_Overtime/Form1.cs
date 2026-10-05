using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_With_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculateGrosspay_Click(object sender, EventArgs e)
        {
            double validate;

            if (double.TryParse(txthoursworked.Text, out validate) && double.TryParse(txthourlypayrate.Text, out validate))
            {

                double hours_worked = double.Parse(txthoursworked.Text);
                double hourly_pay_rate = double.Parse(txthourlypayrate.Text);

                if (hours_worked >= 0)
                {
                    if (hourly_pay_rate >= 0)
                    {
                        double Total_Gross_Pay = hours_worked * hourly_pay_rate;
                        lblgrosspayoutput.Text = Total_Gross_Pay.ToString();
                    }
                    else
                    {
                        MessageBox.Show("payrate must greater than 0");
                    }
                }
                else
                {
                    MessageBox.Show("time worker must greater than 0");
                }

            }
            else
            {
                MessageBox.Show("fadlan gali xog sax ah integer ama double");

            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // clearing the textboxes and labels
            txthoursworked.Clear();
            txthourlypayrate.Clear();
            lblgrosspayoutput.Text = string.Empty;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            // closing the form
            this.Close();
        }
    }
}

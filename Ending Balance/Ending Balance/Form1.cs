using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double startingBalance = double.Parse(txtstarting.Text);
                int numberOfMonths = int.Parse(txtnumbermonth.Text);

                double balance = startingBalance;
                int month = 1;

                lstOutput.Items.Clear();

                while (month <= numberOfMonths)
                {
                    balance = balance + (balance * 0.005);

                    lstOutput.Items.Add($"The ending balance for month {month} is {balance:C}");

                    month++;
                }

                EndingBlanceOutput.Text = balance.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fadlan geli tirooyin sax ah!");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtstarting.Text = "";
            txtnumbermonth.Text = "";
            EndingBlanceOutput.Text = "";

            lstOutput.Items.Clear();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Range_Checker_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncheckqualification_Click(object sender, EventArgs e)
        {
            int rangeNumber;

            // check the value is only a Number
            if (int.TryParse(txtrangename.Text, out rangeNumber))
            {
                // Logical Operators
                if (rangeNumber >= 1 && rangeNumber <= 10)
                {
                    lblrangedecision.Text = "Waa saxday Lambarku wuxuu ku jiraa inta u dhaxaysa 1 iyo 10.";
                }
                else
                {
                    lblrangedecision.Text = "Waa qaladay!";
                }
            }
            else
            {
                MessageBox.Show("Fadlan geli qiima sax ah qiimaha wuxuu noqon karaa kaliya integer");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // clearing the textboxes and label
            txtrangename.Clear();
            lblrangedecision.Text = string.Empty;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            // closing the form
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Programm_Calculator
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
                double weight = 0;
                double height = 0;
                double BMI = 0;
                String category = "";

                if (double.TryParse(textweight.Text, out weight) && double.TryParse(textheight.Text, out height))
                {
                    if (weight > 0 && height > 0)
                    {
                        BMI = weight / (height * height);

                        if (BMI < 18.5)
                        {
                            category = "Under weight";
                        }
                        else if (BMI >= 18.5 && BMI <= 25)
                        {
                            category = "Optimal Weight";
                        }
                        else if (BMI > 25)
                        {
                            category = "Over Weight";
                        }

                        Output.Items.Add("Weight: " + weight);
                        Output.Items.Add("Height: " + height);
                        Output.Items.Add("Your BMI is: " + BMI.ToString("f2"));
                        Output.Items.Add("Category: " + category);

                    }
                    else
                    {
                        MessageBox.Show("Weight and height must be positive value");
                    }
                }

                else
                {
                    MessageBox.Show("Weight and height must be numeric values");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textheight.Clear();
            textweight.Clear();
            Output.Items.Clear();
        }

        private void BTNEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

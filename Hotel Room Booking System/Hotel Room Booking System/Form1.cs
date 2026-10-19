using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Room_Booking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            // creating variables
            string name;
            int age;
            int number_nights;
            int number_guests;

            // options and checkbox
            string Room_type = "";
            String BreakFast = "";

            int rate_per_night = 0;
            double discount;
            double BreakFast_Amount;
            double subcharge = 0;
            double senior_discount;



            if (int.TryParse(txtage.Text, out age) &&
            int.TryParse(txtnight.Text, out number_nights) &&
            int.TryParse(txtguest.Text, out number_guests))
            {
                // assignment
                name = txtname.Text;
                age = int.Parse(txtage.Text);
                number_nights = int.Parse(txtnight.Text);
                number_guests = int.Parse(txtguest.Text);


                // room rate
                if (rdstandard.Checked)
                {
                    Room_type = "Standard";
                    rate_per_night = 50;
                }
                else if (rdnormal.Checked)
                {
                    Room_type = "Normal";
                    rate_per_night = 80;
                }
                else if (rdhight.Checked)
                {
                    Room_type = "Hight";
                    rate_per_night = 130;
                }

                // calculate
                double sum = number_nights * rate_per_night;


                // discounts
                if (number_nights >= 5 && number_nights <= 9)
                {
                    discount = sum * 0.05;
                }
                else if (number_nights >= 10)
                {
                    discount = sum * 0.12;
                }
                else
                {
                    discount = 0;
                }


                // BreakFast selected add 10 per guest per night
                if (cbbreakfast.Checked)
                {
                    BreakFast = "Yes";
                    BreakFast_Amount = (number_guests * 10) * number_nights;
                }
                else
                {
                    BreakFast = "No";
                    BreakFast_Amount = 0;
                }



                // More than 4 guests ass a 5% service subcharge
                if (number_guests > 4)
                {
                    subcharge = sum * 0.05;
                } else
                {
                    subcharge = 0;
                }


                // guest age above 60 recieve an additional 5% senior discount
                if (age >= 60)
                {
                    senior_discount = sum * 0.05;
                }
                else
                {
                    senior_discount = 0;
                }

                // calculate total
                double total = (sum + subcharge + BreakFast_Amount) - discount - senior_discount;



                // Guest Name Cannot be empty
                if (name == "")
                {
                    MessageBox.Show("Guest Name Cannot be empty");
                }
                else
                {
                    // Age must be between 18 - 90
                    if (age >= 18 && age <= 90)
                    {
                        // number of nights must be between 1 - 30
                        if (number_nights >= 1 && number_nights <= 30)
                        {
                            // number of guests must be between 1 - 6
                            if (number_guests >= 1 && number_guests <= 6)
                            {
                                // booking ststus
                                string booking_status = "";

                                // number of guest and selected room type
                                if (rdhight.Checked && number_guests > 6)
                                {
                                    booking_status = "rejected";
                                    MessageBox.Show("The room type you choised is Hight so number of guest must be lessthan 6 guests.");

                                    // Guest display
                                    Booking_details.Items.Add("Guest Information : ");
                                    Booking_details.Items.Add("");
                                    Booking_details.Items.Add("Guest Name : " + name);
                                    Booking_details.Items.Add("Guest Age : " + age);
                                    Booking_details.Items.Add("Number Of Nights : " + number_nights);
                                    Booking_details.Items.Add("Number Of Guest : " + number_guests);
                                    Booking_details.Items.Add("Room Type selected : " + Room_type);
                                    Booking_details.Items.Add("BreakFast selected : " + BreakFast);
                                    Booking_details.Items.Add("");
                                    Booking_details.Items.Add("Booking decision : " + booking_status);
                                }
                                else if (rdnormal.Checked && number_guests > 4)
                                {
                                    booking_status = "rejected";
                                    MessageBox.Show("The room type you choised is Normal so number of guest must be lessthan 4 guests.");

                                    // Guest display
                                    Booking_details.Items.Add("Guest Information : ");
                                    Booking_details.Items.Add("");
                                    Booking_details.Items.Add("Guest Name : " + name);
                                    Booking_details.Items.Add("Guest Age : " + age);
                                    Booking_details.Items.Add("Number Of Nights : " + number_nights);
                                    Booking_details.Items.Add("Number Of Guest : " + number_guests);
                                    Booking_details.Items.Add("Room Type selected : " + Room_type);
                                    Booking_details.Items.Add("BreakFast selected : " + BreakFast);
                                    Booking_details.Items.Add("");
                                    Booking_details.Items.Add("Booking decision : " + booking_status);
                                }
                                else if (rdstandard.Checked && number_guests > 2)
                                {
                                    booking_status = "rejected";
                                    MessageBox.Show("The room type you choised is Standard so number of guest must be lessthan 2 guests.");

                                    // Guest display
                                    Booking_details.Items.Add("Guest Information : ");
                                    Booking_details.Items.Add("");
                                    Booking_details.Items.Add("Guest Name : " + name);
                                    Booking_details.Items.Add("Guest Age : " + age);
                                    Booking_details.Items.Add("Number Of Nights : " + number_nights);
                                    Booking_details.Items.Add("Number Of Guest : " + number_guests);
                                    Booking_details.Items.Add("Room Type selected : " + Room_type);
                                    Booking_details.Items.Add("BreakFast selected : " + BreakFast);
                                    Booking_details.Items.Add("");
                                    Booking_details.Items.Add("Booking decision : " + booking_status);
                                }
                                else
                                {
                                    booking_status = "Approved";

                                    // Guest display
                                    Booking_details.Items.Add("Guest Information : ");
                                    Booking_details.Items.Add("");
                                    Booking_details.Items.Add("Guest Name : " + name);
                                    Booking_details.Items.Add("Guest Age : " + age);
                                    Booking_details.Items.Add("Number Of Nights : " + number_nights);
                                    Booking_details.Items.Add("Number Of Guest : " + number_guests);
                                    Booking_details.Items.Add("Room Type selected : " + Room_type);
                                    Booking_details.Items.Add("BreakFast selected : " + BreakFast);

                                    Booking_details.Items.Add("");
                                    Booking_details.Items.Add("Booking Amount : " + sum);
                                    Booking_details.Items.Add("Discount : " + discount);
                                    Booking_details.Items.Add("Senior Discount : " + senior_discount);
                                    Booking_details.Items.Add("Subcharge Amount : " + subcharge);
                                    Booking_details.Items.Add("BreakFast Amount : " + BreakFast_Amount);
                                    Booking_details.Items.Add("Total Amount : " + total);

                                    Booking_details.Items.Add("");
                                    Booking_details.Items.Add("Booking decision : " + booking_status);
                                }

                            }
                            else
                            {
                                MessageBox.Show("number of Guests must be between 1 - 6");
                            }
                        }
                        else
                        {
                            MessageBox.Show("number of nights must be between 1 - 30");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Age must be between 18 - 90");
                    }
                }








                


                //// Normal = number of guest <= 4
                //if (rdnormal.Checked && number_nights <= 4)
                //{

                //}
                //else
                //{
                //    MessageBox.Show("The room type you choised is Normal so number of guest must be lessthan 4 guests.");

                //}


                //// standard = number of guest <=2
                //if (rdstandard.Checked && number_nights <= 2)
                //{

                //} else
                //{
                //    MessageBox.Show("The room type you choised is Standard so number of guest must be lessthan 2 guests.");

                //}




            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Booking_details.Items.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

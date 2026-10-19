using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticked_Booking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            // creating variables
            string name;
            int age;
            int number_of_tickets;
            double baggage;
            string travelclass = "";

            //calculations
            int travel_insurance = 25;
            double ticket_price = 0;
            double basic_ticket_cost = 0;
            double ticket_discount = 0;
            double age_discount = 0;
            double insurance_cost = 0;
            double excess_baggage = 0;
            double final_ticket_cost = 0;

            // goaan qaadasho
            string booking_status = "";

            // perticket value
            double per_ticket = 75;

            


            if (int.TryParse(txtage.Text, out age) 
                && int.TryParse(txttickets.Text, out number_of_tickets) 
                && double.TryParse(txtbaggage.Text, out baggage))
            {

                // age must be between 1 - 100
                if (age >= 1 && age <= 100)
                {
                    // assignment
                    name = txtname.Text;
                    age = int.Parse(txtage.Text);
                    number_of_tickets = int.Parse(txttickets.Text);
                    baggage = double.Parse(txtbaggage.Text);

                    // price per ticket and travel class names
                    if (rdfirst.Checked)
                    {
                        per_ticket = 150;
                        travelclass = "First Class";

                    }
                    else if (rdnormal.Checked)
                    {
                        per_ticket = 300;
                        travelclass = "Normal Class";
                    }
                    else if (rdbussiness.Checked)
                    {
                        travelclass = "Bussiness Class";
                        per_ticket = 500;
                    }

                    // status booking
                    if (age < 12 && rdfirst.Checked)
                    {
                        booking_status = "Rejected";
                    }
                    else
                    {
                        booking_status = "Approved";
                    }

                    // calculation for ticket price
                    ticket_price = number_of_tickets * per_ticket;

                    // insurance_cost excess_baggage final_ticket_cost
                    if (cbinsurance.Checked)
                    {
                        insurance_cost = number_of_tickets * 25;
                    }
                    else
                    {
                        insurance_cost = 0;
                    }



                    // excess_baggage 
                    excess_baggage = baggage * 1;

                    // number of tickets must be between 1 - 5
                    if (number_of_tickets >= 1 && number_of_tickets <= 5)
                    {
                        // baggage weight must be between 1 - 50 kg
                        if (baggage >= 1 && baggage <= 50)
                        {

                            // ticket discounts first from number
                            if (number_of_tickets >= 3 && number_of_tickets <= 4)
                            {
                                ticket_discount = ticket_price * 0.05;

                                // age below 12 get 20, age above 60 gets 10, bitween no discount
                                if (age <= 12 && rdnormal.Checked)
                                {
                                    age_discount = ticket_discount * 0.20;
                                    
                                }
                                else if (age <= 12 && rdbussiness.Checked)
                                {
                                    age_discount = ticket_discount * 0.20;
                                    
                                }
                                else if (age >= 60)
                                {
                                    age_discount = ticket_discount * 0.10;
                                    
                                }
                                else
                                {
                                    age_discount = 0;
                                    
                                }

                            }
                            else if (number_of_tickets >= 5)
                            {
                                ticket_discount += ticket_price * 0.10;
                                // age below 12 get 20, age above 60 gets 10, bitween no discount
                                if (age <= 12 && rdnormal.Checked)
                                {
                                    ticket_discount += ticket_price * 0.20;
                                }
                                else if (age <= 12 && rdbussiness.Checked)
                                {
                                    ticket_discount += ticket_price * 0.20;
                                }
                                else if (age >= 60)
                                {
                                    ticket_discount += ticket_price * 0.10;
                                }
                                else
                                {
                                    ticket_discount += 0;
                                }

                            }
                            else
                            {
                                ticket_discount = +0;
                            }

                            // display
                            if (age < 12 && rdfirst.Checked)
                            {
                                // airline booking details
                                listBox1.Items.Add("AIRLINE BOOKING DETAILS");
                                listBox1.Items.Add("Passenger name: " + name);
                                listBox1.Items.Add("Passenger age: " + age);
                                listBox1.Items.Add("Passenger Travel class: " + travelclass);
                                listBox1.Items.Add("Numbe Of Tricket: " + number_of_tickets);
                                listBox1.Items.Add("Baggage weight: " + baggage);
                                
                                listBox1.Items.Add("Booking Status: " + booking_status);

                                MessageBox.Show("Passenger age must be above 12 years old");

                            }
                            else
                            {
                                

                                // final_ticket_cost
                                final_ticket_cost = (ticket_price + insurance_cost + excess_baggage) -ticket_discount - age_discount;

                                // airline booking details
                                listBox1.Items.Add("AIRLINE BOOKING DETAILS");
                                listBox1.Items.Add("Passenger name: " + name);
                                listBox1.Items.Add("Passenger age: " + age);
                                listBox1.Items.Add("Passenger Travel class: " + travelclass);
                                listBox1.Items.Add("Numbe Of Tricket: " + number_of_tickets);
                                listBox1.Items.Add("Baggage weight: " + baggage);
                                listBox1.Items.Add("");
                                listBox1.Items.Add("tricket price: " + ticket_price);
                                //listBox1.Items.Add("Basic Tickte Cost: " + basic_ticket_cost);
                                listBox1.Items.Add("Ticket Discount: " + ticket_discount);
                                listBox1.Items.Add("Age Discout: " + age_discount);
                                listBox1.Items.Add("Insurance Cost: " + insurance_cost); 
                                listBox1.Items.Add("Excess Baggage: " + excess_baggage);
                                listBox1.Items.Add("");
                                listBox1.Items.Add("Final Ticket Cost: " + final_ticket_cost);
                                listBox1.Items.Add("");
                                listBox1.Items.Add("Booking Status: " + booking_status);

                            }
                  
                        }
                        else
                        {
                            MessageBox.Show("The baggage weight must between 1 - 50 kg");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Number of tickets must be between 1 - 5");
                    }

                }
                else
                {
                    MessageBox.Show("Age must be between 1 - 100");
                }

            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

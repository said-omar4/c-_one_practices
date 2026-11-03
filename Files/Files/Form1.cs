using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // reading the file

            // import class
            StreamReader reads;

            DialogResult Result;

            Result = openFileDialog1.ShowDialog();

            if (Result == DialogResult.OK)
            {
                // open the file - reading the file
                reads = File.OpenText(openFileDialog1.FileName);

                //reads = new StreamReader(openFileDialog11.FileName);

                String lines;
                while (reads.EndOfStream == false)
                {
                    lines = reads.ReadLine();
                    listBox1.Items.Add(lines);
                }

                reads.Close();


            } else
            {
                MessageBox.Show("File is not opened");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // import class
            StreamWriter writes;

            DialogResult results;

            results = saveFileDialog1.ShowDialog();

            if (results == DialogResult.OK)
            {

                // open the file - creating new file
                writes = File.AppendText(saveFileDialog1.FileName);
                //writes = File.CreateText("C:\\Users\\HP\\Desktop\\jaamac.txt");

                //Step 2. process the file - wrtting the file - using writline() or write() method

                //writes.WriteLine("fasalkaan hadaad wax baranaynin iska bax.");
                //writes.WriteLine("fasalkaan waxaa laga rabaa dad wax baranaayo.");
                writes.WriteLine(textBox1.Text);


                writes.Close();




            }
            else if (results == DialogResult.Cancel)
            {
                MessageBox.Show("Not saved the files");
            }
            
        }
    }
}

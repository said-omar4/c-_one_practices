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

namespace assignment_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_create_newfile_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outputFile;
                outputFile = File.CreateText("Index.txt");

                outputFile.WriteLine("Welcome Jamhuuriya");
                outputFile.WriteLine("Welcome CA242");
                outputFile.WriteLine("Kani waa safka sadexaad ee feylka");

                outputFile.Close();
                MessageBox.Show("1. Feylka si guul leh ayaa loo abuuray oo xog loogu qoray!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "Index.txt";

                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);

                    listBox1.Items.Clear();
                    foreach (string line in lines)
                    {
                        listBox1.Items.Add(line);
                    }
                    MessageBox.Show("Feylka waxaa lagu akhriyay habka cusub ee File.ReadAllLines()!");
                }
                else
                {
                    MessageBox.Show("Feylka lama helin! Fadlan marka hore riix badhanka 'Creating New file' si aad u abuurto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void deletethefile_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "Index.txt";

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    MessageBox.Show("Feylka 'Index.txt' si buuxda ayaa loo tirtiray!");
                    listBox1.Items.Clear(); // Safreenna ListBox-ka
                }
                else
                {
                    MessageBox.Show("Feylkan ma jiro ama mar hore ayaa la tirtiray.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void deleteitemfile_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "Index.txt";

                if (listBox1.SelectedIndex != -1)
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                    StreamWriter writer = File.CreateText(filePath);
                    foreach (var item in listBox1.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                    writer.Close();

                    MessageBox.Show("Item-kii aad dooratay waa la tirtiray, feylkiina waa la cusboonaysiiyay!");
                }
                else
                {
                    MessageBox.Show("Fadlan marka hore ListBox-ka ka dooro item-ka aad rabto inaad tirtirto!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

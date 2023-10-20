// I, Jay Patel, 000881881 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            decimal baseRate = 0;
            decimal serviceRate = 0;
            decimal discountRate = 0;
            decimal additionalDiscountRate = 0;
            int numberOfVisits;
            decimal total;

            // Determine the base rate based on the selected stylist
            if (radioJane.Checked)
            {
                baseRate = 30;
            }
            else if (radioPat.Checked)
            {
                baseRate = 45;
            }
            else if (radioRon.Checked)
            {
                baseRate = 40;
            }
            else if (radioSue.Checked)
            {
                baseRate = 50;
            }
            else if (radioLaura.Checked)
            {
                baseRate = 55;
            }

            // Check if at least one service is selected
            if (!checkCut.Checked && !checkColor.Checked && !checkHighlights.Checked && !checkExtensions.Checked)
            {
                MessageBox.Show("Please select service.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkCut.Focus();
                return;
            }
            else
            {
                // Calculate the cost of selected hair services
                if (checkCut.Checked)
                {
                    serviceRate += 30;
                }
                if (checkColor.Checked)
                {
                    serviceRate += 40;
                }
                if (checkHighlights.Checked)
                {
                    serviceRate += 50;
                }
                if (checkExtensions.Checked)
                {
                    serviceRate += 200;
                }
            }

            // Determine the discount rate based on the selected customer type
            if (radioAdult.Checked)
            {
                discountRate = 1; // No discount for adults
            }
            else if (radioChild.Checked)
            {
                discountRate = 0.90m; // 10% discount for Child
            }
            else if (radioStudent.Checked)
            {
                discountRate = 0.95m; // 5% discount for Student
            }
            else if (radioSenior.Checked)
            {
                discountRate = 0.85m; // 15% discount for Senior
            }


            if (!int.TryParse(textBox1.Text, out numberOfVisits) || numberOfVisits < 1)
            {
                MessageBox.Show("Please enter valid number.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            else
            {
                // Determine the additional discount based on the number of visits
                if (numberOfVisits >= 1 && numberOfVisits <= 3)
                {
                    additionalDiscountRate = 1; // No additional discount for 1-3 visits
                }
                else if (numberOfVisits >= 4 && numberOfVisits <= 8)
                {
                    additionalDiscountRate = 0.95m;
                }
                else if (numberOfVisits >= 9 && numberOfVisits <= 13)
                {
                    additionalDiscountRate = 0.90m;
                }
                else if (numberOfVisits >= 14)
                {
                    additionalDiscountRate = 0.85m;
                }
            }
           
           // Console.WriteLine("br" + baseRate);
           // Console.WriteLine("sr" + serviceRate);
           // Console.WriteLine("dr" +discountRate);
           // Console.WriteLine("ad" +additionalDiscountRate);
            total = Math.Round((baseRate + serviceRate) * discountRate * additionalDiscountRate, 2); // Calculate the total cost 


            label1.Text = "$" + total; // Display the total cost in the label
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            // Reset radio buttons and checkboxes to their default values
            radioJane.Checked = true;
            checkCut.Checked = false;
            checkColor.Checked = false;
            checkExtensions.Checked = false;
            checkHighlights.Checked = false;

            // Reset the radio button for customer type to the default value
            radioAdult.Checked = true;

            // Reset the text box to a default number of visits
            textBox1.Text = "1";

            // Reset the label displaying the total cost
            label1.Text = "0.00";

            // Set focus to the Jane radio button
            radioJane.Focus();
        }
    }
}

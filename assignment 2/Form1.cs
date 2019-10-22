﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Button1_Click_1(object sender, EventArgs e)
        {
            double r1;

            try
            {
                r1 = double.Parse(textBox1.Text);
                //This converts the numbers in the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                r1 = 0.0;
            }
            //the try catch checks if the input is an integer and is not a string
            double r2;

            try
            {
                r2 = double.Parse(textBox2.Text);
                //this converts the number in the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                r2 = 0.0;
            }
            //this try catch checks if the input is an integer and not a string

            double tot1 = r1 + r2;
            //this carries out the calculation to find out the total resistance of 2 resistors in a series circuit
            label1.Text = "Total Resistance = " + tot1.ToString("N3") + " Ω";
            //this prints the total resistance and it gives the answer to 3 decimal places

         
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double r3;

            try
            {
                r3 = double.Parse(textBox3.Text);
                //this converts the number in the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                r3 = 0.0;
            }
            double r4;

            try
            {
                r4 = double.Parse(textBox4.Text);
                //this converts the number in the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                r4 = 0.0;
            }
            double tot2 = (1 / ((1.0 / r3) + (1.0 / r4)));
            //this carries out the calculation to find out the total resistance of 2 resistors in a series circuit
            label2.Text = "Total Resistance = " + tot2.ToString("N3") + " Ω";
            //this prints the total resistance and it gives the answer to 3 decimal place
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double r5;

            try
            {
                r5 = double.Parse(textBox5.Text);
                //this converts the number in the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                r5 = 0.0;
            }
            double r6;

            try
            {
                r6 = double.Parse(textBox6.Text);
                //this converts the number in the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                r6 = 0.0;
            }
            double r7;

            try
            {
                r7 = double.Parse(textBox6.Text);
                //this converts the number in the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                r7 = 0.0;
            }
            double tot3 = r5 + r6 + r7;
            //this carries out the calculation to find out the total resistance of 2 resistors in a series circuit
            label3.Text = "Total Resistance = " + tot3.ToString("N3") + " Ω";
            //this prints the total resistance and it gives the answer to 3 decimal place
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double r8;

            try
            {
                r8 = double.Parse(textBox3.Text);
                //this converts the number in the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                r8 = 0.0;
            }
            double r9;

            try
            {
                r9 = double.Parse(textBox4.Text);
                //this converts the number in the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                r9 = 0.0;
            }
            double r10;

            try
            {
                r10 = double.Parse(textBox6.Text);
                //this converts the number in the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                r10 = 0.0;
            }
            double tot2 = (1 / ((1.0 / r8) + (1.0 / r9) + (1.0/r10)));
            //this carries out the calculation to find out the total resistance of 2 resistors in a series circuit
            label4.Text = "Total Resistance = " + tot2.ToString("N3") + " Ω";
            //this will print the code and give the total resistance up to 3 decimal places
        }
    }
}

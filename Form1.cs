using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConcreteSuite
{
    public partial class Form1 : Form
    {

        public void ClearText(Control control)
        {
            /*
            * thanks to 
            * http://stackoverflow.com/posts/4811246/revisions
            * Must recurse through Child controls
            */

            foreach (var c in control.Controls)
            {
                if (c is TextBox) ((TextBox)c).Text = String.Empty;
                ClearText((Control) c);
            }
        }

        //use regex to validate
        // if it contains a-zAz " " or dashes,special characters
        //then pop a message box

        //else proceed 
        /*
        public bool ValidateInput(Control control)
        {

            foreach (var c in control.Controls)
            {
                if (c is TextBox) ((TextBox)c).Text = String.Empty
                
            }

        } 
        */

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Slab")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
            }
            else if (comboBox1.Text == "Circle")
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // The bottom area is to calculate Slab yardage
            // A functional method keeps the square feet in memory
            // which may then be passed onto the materials section
            //
            //float length = float.Parse(textBox1.Text);
            //float width = float.Parse(textBox2.Text);
            //float squareFeet = Calculations.SlabSquareFeet((length), (width));
            //// completely removed -- string squareFeetstring = Convert.ToString(squareFeet);
            //// completely removed -- textBox6.Text = squareFeetstring;
            //float thickness = float.Parse(textBox3.Text);
            //double cubicFeet = (squareFeet * thickness) / 12;
            //double yardage = cubicFeet / 27;
            //textBox7.Text = Convert.ToString(yardage);

            //Use .Calculations.SlabSquareFeet to pass the value to
            //the materials section


            if (TextControls.Validate(Convert.ToString(textBox1.Text)) 
                && TextControls.Validate(Convert.ToString(textBox2.Text))
                && TextControls.Validate(Convert.ToString(textBox3.Text))
                && TextControls.Validate(Convert.ToString(comboBox2.Text))
                )
            {

                MessageBox.Show("Valid");
                float length = float.Parse(textBox1.Text);
                float width = float.Parse(textBox2.Text);
                float thick = float.Parse(textBox3.Text);
                float cubicYardage = Calculations.SlabYardage(length, width, thick);

                if (checkBox1.Checked)
                {
                    double spillage =
                        Calculations.Spillage(int.Parse(comboBox2.Text));
                    double cubicYardagePlusSpillage =
                        (cubicYardage * spillage) + cubicYardage;
                    textBox7.Text = Convert.ToString(cubicYardagePlusSpillage);
                }
                else
                {
                    textBox7.Text = Convert.ToString(cubicYardage);
                }

                //Calculate square feet
                textBox9.Text = Convert.ToString(Calculations.SlabSquareFeet(length, width)); 
            
            }
            else
            {
                MessageBox.Show("Textboxes must have number values.\n"
                    + "No letters or special characters are permitted.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
   

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (TextControls.Validate(Convert.ToString(textBox4.Text))
                && TextControls.Validate(Convert.ToString(textBox5.Text))
                && TextControls.Validate(Convert.ToString(comboBox3.Text))
                )
            {

                float radius = float.Parse(textBox4.Text);
                float thick = float.Parse(textBox5.Text);
                double cubicYardage = Calculations.CircularYardage(radius, thick);

                if (checkBox2.Checked)
                {
                    double spillage =
                        Calculations.Spillage(int.Parse(comboBox3.Text));
                    double cubicYardagePlusSpillage =
                        (cubicYardage * spillage) + cubicYardage;
                    textBox6.Text = Convert.ToString(cubicYardagePlusSpillage);
                }
                else
                {
                    textBox6.Text = Convert.ToString(cubicYardage);
                }

                //calculate circular square feet
                textBox8.Text = Convert.ToString(Calculations.CircleArea(radius));

            }
            else {
                MessageBox.Show("Textboxes must have number values.\n"
                    + "No letters or special characters are permitted.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearText(groupBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearText(groupBox2);
        }

   

    }
}

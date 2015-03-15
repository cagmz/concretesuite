using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ConcreteSuite
{
	public partial class Form1 : Form
	{

		JobSite site = new JobSite();
		Concrete concrete;
		private readonly int DECIMALS_TO_ROUND_TO = 2;

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
				ClearText((Control)c);
			}
		}


		// use regex to validate
		// if it contains a-zAz " " or dashes,special characters
		// then pop a message box
		public bool Validate(string text)
		{
			// sanitize input of textboxes
			// hopefully in a way that
			// will accomodate any future textboxes
			// check for empty and null strings

			string pattern = "^[+]?([.]\\d+|\\d+[.]?\\d*)$";

			if (Regex.IsMatch(text, pattern))
				return true;
			else return false;
		}

		public bool validateTextBoxes(TextBox[] textBoxArray)
		{
			bool isValidInput = true;

			// Assume that the content of the textBoxes is valid. 
			// If a textBox contains an invalid input, then break out of the loop and return false.
			for (int textBoxIndex = 0; (textBoxIndex < textBoxArray.Length) && isValidInput; textBoxIndex++)
			{
				// Remove spaces from any textBoxes
				textBoxArray[textBoxIndex].Text.Replace(" ", "");
				isValidInput = Validate(textBoxArray[textBoxIndex].Text);
			}

			return isValidInput;
		}

		public void validationWarning()
		{
			MessageBox.Show("Textboxes must have number values.\n"
								+ "No letters or special characters are permitted.",
								"Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public void populateCubicYardage(TextBox textBox, Concrete concrete)
		{
			// truncate cubicYardage to 2 decimals
			double cubicYardage = Math.Round(concrete.getCubicYardage(), DECIMALS_TO_ROUND_TO);
			textBox.Text = Convert.ToString(cubicYardage);
		}

		public void populateCubicYardage(TextBox textBox, Concrete concrete, bool includeSpillage)
		{
			// truncate cubicYardage to 2 decimals
			double cubicYardage = Math.Round(concrete.getCubicYardage(), DECIMALS_TO_ROUND_TO);
			textBox.Text = Convert.ToString(cubicYardage);
		}

		public void populateSquareFeet(TextBox textBox, Concrete concrete)
		{
			double squareFeet = Math.Round(concrete.getSquareFeet(), DECIMALS_TO_ROUND_TO);
			textBox.Text = Convert.ToString(squareFeet);
		}

		public void updateConcreteListView()
		{
			concreteListView.Items.Clear();
			int listViewColumns = concreteListView.Columns.Count;
			// listView columns indices
			int concreteId = 0;
			int formFactor = 1;
			int dimensions = 2;
			int squareFeet = 3;
			int cubicYardage = 4;

			foreach(Concrete concrete in site.getList())
			{
				ListViewItem concreteItem;
				string[] concreteAttributes = new string[listViewColumns];
				for(int i = 0; i < concreteAttributes.Length; i++)
				{
					switch(i)
					{
						case 0:
							// Concrete ID is not accurate. Could be due to the base classes constructor
							concreteAttributes[concreteId] = Convert.ToString(concrete.getConcreteId());
							break;
						case 1:
							concreteAttributes[formFactor] = concrete.getFormFactor();
							break;
						case 2:
							concreteAttributes[dimensions] = concrete.getDimensions();
							break;
						case 3:
							concreteAttributes[squareFeet] = Convert.ToString(Math.Round(concrete.getSquareFeet(), DECIMALS_TO_ROUND_TO));
							break;
						case 4:
							concreteAttributes[cubicYardage] = Convert.ToString(Math.Round(concrete.getSquareFeet(), DECIMALS_TO_ROUND_TO));
							break;
						default:
							break;
					}
				}
				concreteItem = new ListViewItem(concreteAttributes);
				concreteListView.Items.Add(concreteItem);
			}
		}


		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			/*
			groupBox1.Visible = false;
			groupBox2.Visible = false;
			*/
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			/*
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
			*/
		}


		private void btnSlabCalculate_Click(object sender, EventArgs e)
		{
			// The bottom area is to calculate Slab yardage
			// A functional method keeps the square feet in memory
			// which may then be passed onto the materials section
			//
			//float length = float.Parse(tbFeet.Text);
			//float width = float.Parse(tbWidth.Text);
			//float squareFeet = Calculations.SlabSquareFeet((length), (width));
			//// completely removed -- string squareFeetstring = Convert.ToString(squareFeet);
			//// completely removed -- textBox6.Text = squareFeetstring;
			//float thickness = float.Parse(tbSlabThickness.Text);
			//double cubicFeet = (squareFeet * thickness) / 12;
			//double yardage = cubicFeet / 27;
			//tbSlabCubicYardage.Text = Convert.ToString(yardage);

			//Use .Calculations.SlabSquareFeet to pass the value to
			//the materials section


			//if (TextControls.Validate(Convert.ToString(tbFeet.Text)) 
			//    && TextControls.Validate(Convert.ToString(tbWidth.Text))
			//    && TextControls.Validate(Convert.ToString(tbSlabThickness.Text))
			//    && TextControls.Validate(Convert.ToString(comboBox2.Text))
			//    )
			//{
			//    /* diagnostic
			//    MessageBox.Show("Valid");
			//     */

			//    float length = float.Parse(tbFeet.Text);
			//    float width = float.Parse(tbWidth.Text);
			//    float thick = float.Parse(tbSlabThickness.Text);
			//    float cubicYardage = Calculations.SlabYardage(length, width, thick);

			//    if (chkSlabSpillage.Checked)
			//    {
			//        double spillage =
			//            Calculations.Spillage(int.Parse(comboBox2.Text));
			//        double cubicYardagePlusSpillage =
			//            (cubicYardage * spillage) + cubicYardage;
			//        tbSlabCubicYardage.Text = Convert.ToString(cubicYardagePlusSpillage);
			//    }
			//    else
			//    {
			//        tbSlabCubicYardage.Text = Convert.ToString(cubicYardage);
			//    }

			//    //Calculate square feet
			//    tbSlabSqFt.Text = Convert.ToString(Calculations.SlabSquareFeet(length, width));

			//    if (chkSlabSqFt.Checked)
			//    {
			//        listBoxSqFt.Items.Add(Convert.ToString(Calculations.SlabSquareFeet(length, width)));
			//    }

			//}
			//else
			//{
			//    MessageBox.Show("Textboxes must have number values.\n"
			//        + "No letters or special characters are permitted.",
			//        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}



			// Create TextBox array, assume that all inputs are valid, then try to find an invalid input.
			TextBox[] textBoxArray = new TextBox[] { tbSlabLength, tbSlabWidth, tbSlabThickness };
			bool valid = validateTextBoxes(textBoxArray);

			if (valid)
			{
				double thick = double.Parse(tbSlabThickness.Text);
				double length = double.Parse(tbSlabLength.Text);
				double width = double.Parse(tbSlabWidth.Text);

				// Instantiate concreteObj and add it to site obj
				concrete = new Slab(thick, length, width);
				site.addConcrete(concrete);

				// create 2 cubic yardage, one for spillage, one without
				populateCubicYardage(tbSlabCubicYardage, concrete);
				populateSquareFeet(tbSlabSqFt, concrete);
				updateConcreteListView();

				// populateCubicYardage(tbSlabCubicYardage, concreteObj, spillagePercent);
			}
			// either one or all textboxes contain an invalid character
			else validationWarning();
				


			/*
						   if (validated == false)   // either one or all textboxes contain an invalid character
						   {
								MessageBox.Show("Textboxes must have number values.\n"
									+ "No letters or special characters are permitted.",
									"Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
						   }
						   else //continue calculating
						   {
								concreteId += 1;
								double length = Convert.ToDouble(Convert.ToString(tbSlabLength));
								double width = Convert.ToDouble(Convert.ToString(tbSlabWidth));
								double thick = Convert.ToDouble(Convert.ToString(tbSlabThickness));
                    
						   }
			*/


		}

		private void btnCircleCalculate_Click(object sender, EventArgs e)
		{

			TextBox[] textBoxArray = new TextBox[] { tbCircleRadius, tbCircleThickness };
			bool validated = false;

			foreach (var t in textBoxArray)
			{
				if (t is TextBox)
				{
					validated = Validate(Convert.ToString(t.Text));
				}
			}

			if (validated)
			{
				double thickness = double.Parse(tbCircleThickness.Text);
				double radius = double.Parse(tbCircleRadius.Text);

				concrete = new Circle(thickness, radius);
				site.addConcrete(concrete);
			}
			else
			{
				validationWarning();
			}

			/*
						   if (TextControls.Validate(Convert.ToString(tbCircleRadius.Text))
							   && TextControls.Validate(Convert.ToString(tbCircleThickness.Text))
							   && TextControls.Validate(Convert.ToString(comboBox3.Text))
							   )
						   {

								float radius = float.Parse(tbCircleRadius.Text);
								float thick = float.Parse(tbCircleThickness.Text);
								double cubicYardage = Calculations.CircularYardage(radius, thick);

								double cubicYardagePlusSpillage = 0;

								if (chkCircleSpillage.Checked)
								{
									 double spillage =
										 Calculations.Spillage(int.Parse(comboBox3.Text));
									 cubicYardagePlusSpillage =
										 (cubicYardage * spillage) + cubicYardage;
									 tbCircleCubicYardage.Text = Convert.ToString(cubicYardagePlusSpillage);

								}
								else
								{
									 tbCircleCubicYardage.Text = Convert.ToString(cubicYardage);
								}

								//calculate circular square feet
								tbCircleSqFt.Text = Convert.ToString(Calculations.CircleArea(radius));

								//Send Square feet results to Squarefeet listbox
								if (chkCircleSqFt.Checked)
								{
									 listBoxSqFt.Items.Add(Convert.ToString(Calculations.CircleArea(radius)));
								}

								//Send Yardage results to Yardage listbox
								if ((chkCircleYardage.Checked)
									&& chkCircleSpillage.Checked)
								{
									 listBoxCubicYards.Items.Add(Convert.ToString(cubicYardagePlusSpillage));
								}
								else if (chkCircleYardage.Checked)
								{
									 listBoxCubicYards.Items.Add(Convert.ToString(cubicYardage));
								}

						   }
						   else
						   {
								MessageBox.Show("Textboxes must have number values.\n"
									+ "No letters or special characters are permitted.",
									"Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
						   }
			 * */

		}

		private void btnClearSlabTextbox_Click(object sender, EventArgs e)
		{
			ClearText(groupBox1);
		}

		private void btnClearCircleTextbox_Click(object sender, EventArgs e)
		{
			ClearText(groupBox2);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (TextControls.Validate(Convert.ToString(tbRebarSqFeet.Text))
				&& TextControls.Validate(Convert.ToString(tbRebarCenters.Text))
			   )
			{
				float selectedSquareFeet = float.Parse(Convert.ToString(tbRebarSqFeet.Text));

				//rebar
				float rebarCenter = float.Parse(Convert.ToString(tbRebarCenters.Text));
				float linearRebarFeet = (float)Calculations.rebarNeeded(selectedSquareFeet, rebarCenter);
				tbRebarNeeded.Text = Convert.ToString(linearRebarFeet);

			}
			else
			{
				MessageBox.Show("Textboxes must have number values.\n"
					+ "No letters or special characters are permitted.",
					"Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void button6_Click(object sender, EventArgs e)
		{
			ClearText(groupBox3);
		}

		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox4.Checked == true)
			{
				int squareFeet = 0;
				foreach (string item in this.listBoxSqFt.SelectedItems)
				{

					squareFeet += (Convert.ToInt32(item));
				}

				tbRebarSqFeet.Text = Convert.ToString(squareFeet);

			}
			else if (checkBox4.Checked == false)
			{
				tbRebarSqFeet.Text = "";
			}

		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (TextControls.Validate(Convert.ToString(tbConcreteStand.Text)))
			{
				float selectedSquareFeet = float.Parse(Convert.ToString(tbRebarSqFeet.Text));

				//stands
				float standCenter = float.Parse(Convert.ToString(tbConcreteStand.Text));
				float standsTotal = (float)Calculations.standsNeeded(selectedSquareFeet, standCenter);
				tbConcreteStandsNeeded.Text = (Convert.ToString(standsTotal));

			}
			else
			{
				MessageBox.Show("Textboxes must have number values.\n"
					+ "No letters or special characters are permitted.",
					"Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			int yardage = 0;

			if (listBoxCubicYards.SelectedItems.Count > 0)
			{
				foreach (string y in this.listBoxCubicYards.SelectedItems)
				{
					yardage += (Convert.ToInt32(y));
				}

				tbSelectedYards.Text = Convert.ToString(yardage);
			}

		}



	}
}


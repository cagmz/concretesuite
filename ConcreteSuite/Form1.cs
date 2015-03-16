using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;


/* Todo: On textChanged for rebar stands, update stands needed in listView
 * Move updateListView to jobSite and return ListViewItems
 * Create running total of all rebar and stands needed based on selected items in listview
 * Allow deletion of listView items using Del key, or maybe use a checkmark
 */


namespace ConcreteSuite
{
	public partial class Form1 : Form
	{

		JobSite site;
		Concrete concrete;

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
		public bool validate(string text)
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
				// Remove spaces from any textBoxes to be a little friendlier
				textBoxArray[textBoxIndex].Text.Replace(" ", "");
				isValidInput = validate(textBoxArray[textBoxIndex].Text);
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
			double cubicYardage = concrete.getCubicYardage();
			textBox.Text = Convert.ToString(cubicYardage);
		}

		public void populateSquareFeet(TextBox textBox, Concrete concrete)
		{
			double squareFeet = concrete.getSquareFeet();
			textBox.Text = Convert.ToString(squareFeet);
		}

		// move this into JobSite class, but return Items[] intead of a new listView
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
			int rebarNeeded = 5;
			int standsNeeded = 6;

			foreach(Concrete concrete in site.getList())
			{
				ListViewItem concreteItem;
				string[] concreteAttributes = new string[listViewColumns];
				for(int i = 0; i < concreteAttributes.Length; i++)
				{
					switch(i)
					{
						case 0:
							concreteAttributes[concreteId] = Convert.ToString(concrete.getConcreteId());
							break;
						case 1:
							concreteAttributes[formFactor] = concrete.getFormFactor();
							break;
						case 2:
							concreteAttributes[dimensions] = concrete.getDimensions();
							break;
						case 3:
							concreteAttributes[squareFeet] = Convert.ToString(concrete.getSquareFeet());
							break;
						case 4:
							concreteAttributes[cubicYardage] = Convert.ToString(concrete.getCubicYardage());
							break;
						case 5:
							concreteAttributes[rebarNeeded] = Convert.ToString(concrete.getRebarNeeded());
							break;
						case 6:
							concreteAttributes[standsNeeded] = Convert.ToString(concrete.getStandsNeeded());
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
			cBSlabSpillage.SelectedIndex = 0;
			cBCircleSpillage.SelectedIndex = 0;
			site = new JobSite();
			concreteListView.Columns.AddRange(site.getColumnHeaders());
		}

		private void Form1_Load(object sender, EventArgs e)
		{

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
			// Create TextBox array, assume that all inputs are valid, then try to find an invalid input.
			TextBox[] textBoxArray = new TextBox[] { tbSlabLength, tbSlabWidth, tbSlabThickness };
			bool valid = validateTextBoxes(textBoxArray);

			if (valid)
			{
				double thick = double.Parse(tbSlabThickness.Text);
				double length = double.Parse(tbSlabLength.Text);
				double width = double.Parse(tbSlabWidth.Text);
				double spillage = double.Parse(cBSlabSpillage.Text);

				// Instantiate concreteObj and add it to site obj
				concrete = new Slab(thick, length, width, spillage);
				site.addConcrete(concrete);

				populateCubicYardage(tbSlabCubicYardage, concrete);
				populateSquareFeet(tbSlabSqFt, concrete);
				updateConcreteListView();
			} 
			else validationWarning();
		}

		private void btnCircleCalculate_Click(object sender, EventArgs e)
		{

			TextBox[] textBoxArray = new TextBox[] { tbCircleRadius, tbCircleThickness };
			bool valid = validateTextBoxes(textBoxArray);

			if (valid)
			{
				double thickness = double.Parse(tbCircleThickness.Text);
				double radius = double.Parse(tbCircleRadius.Text);

				concrete = new Circle(thickness, radius);
				site.addConcrete(concrete);

				//populateCubicYardage(tbCircleCubicYardage, concrete);
				populateSquareFeet(tbCircleSqFt, concrete);
				updateConcreteListView();

			}
			else validationWarning();
		}

		private void btnClearSlabTextbox_Click(object sender, EventArgs e)
		{
			ClearText(gbSlab);
		}

		private void btnClearCircleTextbox_Click(object sender, EventArgs e)
		{
			ClearText(gbCircle);
		}

		/*
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
		*/

		private void button6_Click(object sender, EventArgs e)
		{
			ClearText(groupBox3);
		}

		private void cBSlabSpillage_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void tbRebarCenters_TextChanged(object sender, EventArgs e)
		{
			if(validate(tbRebarCenters.Text))
			{
				double spacing = double.Parse(tbRebarCenters.Text);
				site.updateRebarNeeded(spacing);
				updateConcreteListView();
			}
		}


		/*
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
		*/



	}
}


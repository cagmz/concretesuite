using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;


/* Todo:
 * Create running total of all rebar and stands needed based on all items in listview
 * // Maybe update to tallying rebar based on selected items?
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
			* thanks to http://stackoverflow.com/posts/4811246/revisions
			* Recurse through Child controls
			*/
			foreach (var c in control.Controls)
			{
				if (c is TextBox) ((TextBox)c).Text = String.Empty;
				ClearText((Control)c);
			}
		}

		// Check for empty and null strings
		// If it contains a-zAz, " ", dashes or special characters,
		// then pop a message box
		public bool validate(string text)
		{
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

		public void updateConcreteListView()
		{
			concreteListView.Items.Clear();
			site.updateConcreteItems();
			foreach(ListViewItem item in site.getConcreteItems())
				concreteListView.Items.Add(item);
		}

		public void updateTotalRebarNeeded()
		{
			tbTotalRebarNeeded.Text = Convert.ToString(site.getRebarNeeded());
		}

		public void updateTotalStandsNeeded()
		{
			tbTotalStandsNeeded.Text = Convert.ToString(site.getStandsNeeded());
		}

		public Form1()
		{
			InitializeComponent();
			cBSlabSpillage.SelectedIndex = 0;
			cBCircleSpillage.SelectedIndex = 0;
			site = new JobSite();
			concreteListView.Columns.AddRange(site.getColumnHeaders());
		}

		private void Form1_Load(object sender, EventArgs e) { }

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
				double spillage = double.Parse(cBCircleSpillage.Text);

				concrete = new Circle(thickness, radius, spillage);
				site.addConcrete(concrete);

				populateCubicYardage(tbCircleCubicYardage, concrete);
				populateSquareFeet(tbCircleSqFt, concrete);
				updateConcreteListView();
			}
			else validationWarning();
		}

		private void btnClearSlabTextbox_Click(object sender, EventArgs e) { ClearText(gbSlab); }

		private void btnClearCircleTextbox_Click(object sender, EventArgs e) { ClearText(gbCircle); }

		private void cBSlabSpillage_SelectedIndexChanged(object sender, EventArgs e){ }

		private void tbRebarCenters_TextChanged(object sender, EventArgs e)
		{
			if(validate(tbRebarCenters.Text))
			{
				double spacing = double.Parse(tbRebarCenters.Text);
				site.updateRebarNeeded(spacing);
				updateConcreteListView();
				updateTotalRebarNeeded();
			}
		}

		private void tbConcreteStand_TextChanged(object sender, EventArgs e)
		{
			if (validate(tbConcreteStand.Text))
			{
				double spacing = double.Parse(tbConcreteStand.Text);
				site.updateStandsNeeded(spacing);
				updateConcreteListView();
				updateTotalStandsNeeded();
			}
		}

		private void concreteListView_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

	}
}


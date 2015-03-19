using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcreteSuite
{
	class JobSite
	{
		private List<Concrete> site;

		private readonly string[] CONCRETE_ATTRIBUTES = new string[] {
			"ID", "Form Factor", "Dimensions", "Square Feet", "Yardage", "Rebar Needed", "Stands Needed" };
		// listView columns indices
		private int CONCRETE_ID = 0;
		private int FORM_FACTOR = 1;
		private int DIMENSIONS = 2;
		private int SQUARE_FEET = 3;
		private int CUBIC_YARDAGE = 4;
		private int REBAR_NEEDED = 5;
		private int STANDS_NEEDED = 6;

		private ColumnHeader[] columnHeaders;
		private List<ListViewItem> concreteItemsList;

		public JobSite()
		{
			site = new List<Concrete>();
			columnHeaders = new ColumnHeader[CONCRETE_ATTRIBUTES.Length];
			concreteItemsList = new List<ListViewItem>();
			setColumnHeaders(CONCRETE_ATTRIBUTES);
		}

		public JobSite(Concrete concreteObj)
		{
			site = new List<Concrete>();
			columnHeaders = new ColumnHeader[CONCRETE_ATTRIBUTES.Length];
			setColumnHeaders(CONCRETE_ATTRIBUTES);
			site.Add(concreteObj);
			updateConcreteItems();
		}

		public void updateConcreteItems()
		{
			concreteItemsList.Clear();
			int listViewColumns = CONCRETE_ATTRIBUTES.Length;
			foreach (Concrete concrete in site)
			{
				ListViewItem concreteItem;
				string[] concreteInfo = new string[listViewColumns];
				for (int i = 0; i < CONCRETE_ATTRIBUTES.Length; i++)
				{
					switch (i)
					{
						case 0:
							concreteInfo[CONCRETE_ID] = Convert.ToString(concrete.getConcreteId());
							break;
						case 1:
							concreteInfo[FORM_FACTOR] = concrete.getFormFactor();
							break;
						case 2:
							concreteInfo[DIMENSIONS] = concrete.getDimensions();
							break;
						case 3:
							concreteInfo[SQUARE_FEET] = Convert.ToString(concrete.getSquareFeet());
							break;
						case 4:
							concreteInfo[CUBIC_YARDAGE] = Convert.ToString(concrete.getCubicYardage());
							break;
						case 5:
							concreteInfo[REBAR_NEEDED] = Convert.ToString(concrete.getRebarNeeded());
							break;
						case 6:
							concreteInfo[STANDS_NEEDED] = Convert.ToString(concrete.getStandsNeeded());
							break;
						default:
							break;
					}
				}
				concreteItem = new ListViewItem(concreteInfo);
				concreteItemsList.Add(concreteItem);
			}
		}

		public void setColumnHeaders(string[] concreteAttributes)
		{
			for(int i = 0; i < concreteAttributes.Length; i++)
			{
				ColumnHeader ch = new ColumnHeader();
				ch.Text = concreteAttributes[i];
				ch.Width = -2;
				ch.TextAlign = HorizontalAlignment.Left;
				columnHeaders[i] = ch;
			}
		}

		public Boolean addConcrete(Concrete obj)
		{
			if (obj != null)
			{
				site.Add(obj);
				return true;
			}
			else return false;
		}

		public void removeConcrete(int index)
		{
			// Prevent out of bounds selection
			if (this.site.Count <= index && index >= 0)
			{
				this.site.RemoveAt(index);
			}
		}

		public void updateRebarNeeded(double spacing)
		{
			foreach (Concrete concrete in site)
				concrete.setRebarNeeded(concrete.getSquareFeet(), spacing);
		}

		public void updateStandsNeeded(double spacing)
		{
			foreach (Concrete concrete in site)
				concrete.setStandsNeeded(concrete.getSquareFeet(), spacing);
		}

		public List<Concrete> getList() { return this.site; }

		public ColumnHeader[] getColumnHeaders() { return columnHeaders; }

		public List<ListViewItem> getConcreteItems() { return concreteItemsList; }

		public void displayList()
		{
			//foreach (Concrete tempConcrete in this.site)
			//{

			//}
		}

	}
}
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
		private readonly string[] concreteAttributes = new string[] {
			"ID", "Form Factor", "Dimensions", "Square Feet", "Yardage", "Rebar Needed", "Stands Needed" };
		//private readonly Dictionary<int, string> listViewColumns = new Dictionary<int, string>();
		private ColumnHeader[] columnHeaders;


		public JobSite()
		{
			site = new List<Concrete>();
			columnHeaders = new ColumnHeader[concreteAttributes.Length];
			setColumnHeaders(concreteAttributes);
		}

		public JobSite(Concrete concreteObj)
		{
			site = new List<Concrete>();
			columnHeaders = new ColumnHeader[concreteAttributes.Length];
			setColumnHeaders(concreteAttributes);
			site.Add(concreteObj);
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

		public void displayList()
		{
			//foreach (Concrete tempConcrete in this.site)
			//{

			//}
		}

	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcreteSuite
{
	public abstract class Concrete
	{
		protected static int concreteIdCounter = 0;
		protected int concreteId;
		protected double thickness;
		protected double cubicYardage;
		protected double squareFeet;
		protected double spillagePercent;

		protected String formFactor;
		protected readonly String[] concreteTypes = { "Slab", "Circle" };
		protected readonly int INCHES_IN_FOOT = 12;
		protected readonly int CUBIC_YARD = 27;
		protected readonly int DECIMALS_TO_ROUND_TO = 2;
		protected readonly int PERCENT = 100;

		protected double linearRebarFeet;
		protected double standsNeeded;

		public Concrete()
		{
			thickness = 0.01;
			cubicYardage = 0.01;
			squareFeet = 0.01;
			linearRebarFeet = 0.01;
			standsNeeded = 0.01;
			concreteIdCounter++;
			setConcreteId(concreteIdCounter);
			this.formFactor = concreteTypes[0];
		}

		public Concrete(double thickness)
		{
			if (isPositive(thickness))
			{
				this.thickness = thickness;
				linearRebarFeet = 0.01;
				standsNeeded = 0.01;
				if (this is Slab)
				{
					this.formFactor = concreteTypes[0];
					concreteIdCounter++;
					setConcreteId(concreteIdCounter);
				}
				else if (this is Circle)
				{
					this.formFactor = concreteTypes[1];
					concreteIdCounter++;
					setConcreteId(concreteIdCounter);
				}
				else MessageBox.Show("Invalid formFactor in Concrete constructor");
			}
		}

		public void setRebarNeeded(double squareFeet, double rebarCenter)
		{
			double linearInches = squareFeet * INCHES_IN_FOOT;
			linearRebarFeet = Math.Round(((linearInches / rebarCenter) * 2), DECIMALS_TO_ROUND_TO);
		}

		public void setStandsNeeded(double squareFeet, double standCenter)
		{
			double linearInches = squareFeet * INCHES_IN_FOOT;
			standsNeeded = Math.Round(((linearInches / standCenter) / 2), DECIMALS_TO_ROUND_TO);
		}

		public double getRebarNeeded() { return linearRebarFeet; }

		public double getStandsNeeded() { return standsNeeded; }

		public double getThickness() { return this.thickness; }

		public double getSpillagePercent() { return this.spillagePercent; }

		public double getSquareFeet() { return this.squareFeet; }

		public double getCubicYardage() { return this.cubicYardage; }

		public void setConcreteId(int id) { concreteId = id; }

		public int getConcreteId() { return concreteId; }

		public string getFormFactor() { return formFactor; }

		public Boolean isPositive(double value)
		{
			if (value >= 0)
				return true;
			else return false;
		}

		/*
		The following methods are implemented in Slab or Circle objects since
		the results depend on their form factor.
		*/
		public abstract string getDimensions();

		public abstract void calculateYardage();

		public abstract void calculateSquareFeet();
	}
}

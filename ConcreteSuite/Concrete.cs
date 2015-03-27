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
		protected readonly int DECIMALS_TO_ROUND_TO = 2;
		protected int concreteId;
		protected double thickness;
		protected double cubicYardage;
		protected double spillagePercent;
		protected double squareFeet;
		protected double linearRebarFeet;
		protected double standsNeeded;
		protected String formFactor;

		protected readonly String[] concreteTypes = { "Slab", "Circle" };
		protected readonly int SLAB_INDEX = 0;
		protected readonly int CIRCLE_INDEX = 1;
		protected readonly int INCHES_IN_FOOT = 12;
		protected readonly int CUBIC_YARD = 27;
		protected readonly int PERCENT = 100;

		public Concrete()
		{
			thickness = 0.00;
			cubicYardage = 0.00;
			squareFeet = 0.00;
			linearRebarFeet = 0.00;
			standsNeeded = 0.00;
			concreteIdCounter++;
			setConcreteId(concreteIdCounter);
			this.formFactor = concreteTypes[SLAB_INDEX];
		}

		public Concrete(double thickness)
		{
			if (isPositive(thickness))
			{
				this.thickness = thickness;
				linearRebarFeet = 0.00;
				standsNeeded = 0.00;
				concreteIdCounter++;
				setConcreteId(concreteIdCounter);
				if (this is Slab)
					this.formFactor = concreteTypes[SLAB_INDEX];
				else if (this is Circle)
					this.formFactor = concreteTypes[CIRCLE_INDEX];
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

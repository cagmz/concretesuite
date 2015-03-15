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
		protected int concreteId = 0;
		protected double thickness;
		protected double cubicYardage;
		protected double squareFeet;

		protected String formFactor;
		protected readonly String[] concreteTypes = { "Slab", "Circle" };
		protected readonly int INCHES_IN_FOOT = 12;
		protected readonly int CUBIC_YARD = 27;

		protected double rebarNeeded;
		protected double standsNeeded;

		public Concrete()
		{
			this.thickness = 0.01;
			this.cubicYardage = 0.01;
			this.squareFeet = 0.01;
			concreteId++;
			setConcreteId(concreteId);
			this.formFactor = concreteTypes[0];
		}

		public Concrete(double thickness)
		{
			if (isPositive(thickness))
			{
				this.thickness = thickness;
				if (this is Slab)
				{
					this.formFactor = concreteTypes[0];
					concreteId++;
					setConcreteId(concreteId);
				}
				else if (this is Circle)
				{
					this.formFactor = concreteTypes[1];
					concreteId++;
					setConcreteId(concreteId);
				}
				else
				{
					MessageBox.Show("Invalid formFactor in Concrete constructor");
				}
			}
		}

		public double findRebarNeeded(double squareFeet, double rebarCenter)
		{
			double linearInches = squareFeet * INCHES_IN_FOOT;
			double linearRebarFeet = (linearInches / rebarCenter) * 2;
			return linearRebarFeet;
		}


		public double findStandsNeeded(double squareFeet, double standCenter)
		{
			double linearInches = squareFeet * INCHES_IN_FOOT;
			double standsNeeded = (linearInches / standCenter) / 2;
			return standsNeeded;
		}

		public double getThickness() { return this.thickness; }

		public double getSquareFeet() { return this.squareFeet; }

		public double getCubicYardage() { return this.cubicYardage; }

		public void setConcreteId(int id) { this.concreteId = id; }

		public int getConcreteId() { return this.concreteId; }

		/*
				  public void setCubicYardage(double cubicYardage)
				  {
					   if(cubicYardage > 0)
					   {
							this.cubicYardage = cubicYardage;
					   }
					   else
					   {
							MessageBox.Show("CubicYardage cannot be negative.")
					   }
				  }
		*/

		public Boolean isPositive(double value)
		{
			if (value > 0)
				return true;
			else
				return false;
		}

		public abstract void calculateYardage();

		public abstract void calculateSquareFeet();
	}
}

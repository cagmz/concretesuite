using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteSuite
{
	class Slab : Concrete
	{
		private double length;
		private double width;

		public Slab(double thickness, double length, double width, double spillagePercent) : base(thickness)
		{
			if (isPositive(length) && isPositive(width) && isPositive(spillagePercent))
			{
				this.length = length;
				this.width = width;
				this.spillagePercent = spillagePercent / PERCENT;
				calculateYardage();
				calculateSquareFeet();
			}
		}

		public override void calculateYardage()
		{
			double cubicFeet = (getThickness() * getLength() * getWidth()) / INCHES_IN_FOOT;
			double cubicYardage = (cubicFeet / CUBIC_YARD);
			if (spillagePercent > 0)
				cubicYardage = Math.Round((cubicYardage + (cubicYardage * spillagePercent)), DECIMALS_TO_ROUND_TO);
			else cubicYardage = Math.Round(cubicYardage, DECIMALS_TO_ROUND_TO);

			if (isPositive(cubicYardage))
				this.cubicYardage = cubicYardage;
		}

		public override void calculateSquareFeet()
		{
			double squareFeet = Math.Round((getLength() * getWidth()), DECIMALS_TO_ROUND_TO);
			if (isPositive(squareFeet))
				this.squareFeet = squareFeet;
		}

		public double getLength() { return this.length; }

		public double getWidth() { return this.width; }

		public override string getDimensions()
		{
			return Convert.ToString(getLength()) + " x " + Convert.ToString(getWidth()) + " x " + Convert.ToString(getThickness());
		}

	}
}

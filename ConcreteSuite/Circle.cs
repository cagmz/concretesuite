using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteSuite
{
	class Circle : Concrete
	{
		private double radius;

		public Circle(double thickness, double radius, double spillage) : base(thickness)
		{
			if (isPositive(radius))
			{
				this.radius = radius;
				spillagePercent = spillage / PERCENT;
				calculateYardage();
				calculateSquareFeet();
			}
		}

		public override void calculateYardage()
		{
			double cubicFeet = (this.radius * this.radius * this.thickness * Math.PI) / INCHES_IN_FOOT;
			double cubicYardage = cubicFeet / CUBIC_YARD;
			if (spillagePercent > 0)
				cubicYardage = Math.Round(((cubicYardage + (cubicYardage * spillagePercent) )), DECIMALS_TO_ROUND_TO);
			else cubicYardage = Math.Round(cubicYardage, DECIMALS_TO_ROUND_TO);
			if (isPositive(cubicYardage))
				this.cubicYardage = cubicYardage;
		}

		public override void calculateSquareFeet()
		{
			double squareFeet = Math.Round((this.radius * this.radius) * Math.PI);
			if (isPositive(squareFeet))
				this.squareFeet = squareFeet;
		}

		public double getRadius() { return this.radius; }

		public override string getDimensions()
		{
			return Convert.ToString(getRadius()) + " x " + Convert.ToString(getThickness());
		}


	}
}

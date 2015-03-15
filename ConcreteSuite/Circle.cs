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

		public Circle(double thickness, double radius) : base(thickness)
		{
			if (isPositive(radius))
			{
				this.radius = radius;
				calculateYardage();
			}
		}

		public override void calculateYardage()
		{
			double cubicFeet = (this.radius * this.radius * this.thickness * Math.PI) / INCHES_IN_FOOT;
			double cubicYardage = cubicFeet / CUBIC_YARD;
			if (isPositive(cubicYardage))
			{
				this.cubicYardage = cubicYardage;
			}

		}

		public override void calculateSquareFeet()
		{
			double squareFeet = Math.Round((this.radius * this.radius) * Math.PI);
			if (isPositive(squareFeet))
			{
				this.squareFeet = squareFeet;
			}
		}

		public double getRadius() { return this.radius; }

		public override string getDimensions()
		{
			return Convert.ToString(getRadius()) + " x " + Convert.ToString(getThickness());
		}


	}
}

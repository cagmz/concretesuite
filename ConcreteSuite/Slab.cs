﻿using System;
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

		public Slab(double thickness, double length, double width) : base(thickness)
		{
			if (isPositive(length) && isPositive(width))
			{
				this.length = length;
				this.width = width;
				calculateYardage();
				calculateSquareFeet();
			}
		}

		public override void calculateYardage()
		{
			double cubicFeet = (getThickness() * length * width) / INCHES_IN_FOOT;
			double cubicYardage = cubicFeet / CUBIC_YARD;
			this.cubicYardage = cubicYardage;
		}

		public override void calculateSquareFeet() { this.squareFeet = getLength() * getWidth(); }

		public double getLength() { return this.length; }

		public double getWidth() { return this.width; }

		public override string getDimensions()
		{
			return Convert.ToString(getLength()) + " x " + Convert.ToString(getWidth()) + " x " + Convert.ToString(getThickness());
		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConcreteSuite
{
	class Calculations
	{
		protected readonly int MAGIC = 27;

		//This is just in case you want to add the importation of 
		//square feet directly into the rebar/materials area
		public static double SlabSquareFeet(double len, double wid)
		{
			double squareFeet = len * wid;
			return squareFeet;
		}


		//this "Functional Method" calculates the Cubic Slab Yardage
		public static double SlabYardage(double len, double wid, double thi)
		{
			double cubicFeet = (len * wid * thi) / 12;
			double cubicYardage = cubicFeet / 27;
			return cubicYardage;
		}

		//calculate Square feet in a circlular slab
		public static double CircleArea(double radius)
		{
			double CircularSquarefeet = Math.Round((radius * radius) * Math.PI);
			return CircularSquarefeet;
		}

		//this "Functional Method" calculates the Cubic Circle Slab Yardage
		public static double CircularYardage(double radi, double thi)
		{
			double cubicFeet = (radi * radi * thi * Math.PI) / 12;
			double cubicYardage = cubicFeet / 27;
			return cubicYardage;
		}


		public static double Spillage(int amount)
		{

			double percentageSpill = amount * .01;
			return percentageSpill;
		}

		public static double rebarNeeded(double squareFeet, double rebarCenter)
		{
			double linearInches = squareFeet * 12;
			double linearRebarFeet = (linearInches / rebarCenter) * 2;
			return linearRebarFeet;
		}


		public static double standsNeeded(double squareFeet, double standCenter)
		{
			double linearInches = squareFeet * 12;
			double standsNeeded = (linearInches / standCenter) / 2;
			return standsNeeded;
		}

		//end class


	}



}

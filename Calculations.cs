using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConcreteSuite
{
    public class Calculations
    {

        //This is just in case you want to add the importation of 
        //square feet directly into the rebar/materials area
        public static float SlabSquareFeet(float len, float wid)
        {
            float squareFeet = len * wid;
            return squareFeet;
        }


        //this "Functional Method" calculates the Cubic Slab Yardage
        public static float SlabYardage(float len, float wid, float thi)
        {
            float cubicFeet = (len * wid * thi) / 12;
            float cubicYardage = cubicFeet / 27;
            return cubicYardage;
        }


        //calculate Square feet in a circlular slab
        public static double CircleArea(double radius)
        {
            double CircularSquarefeet = Math.Round((radius * radius) * Math.PI) ;
            return CircularSquarefeet;
        }

        //this "Functional Method" calculates the Cubic Circle Slab Yardage
        public static double CircularYardage(float radi, float thi)
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

        public static float rebarNeeded(float squareFeet, float rebarCenter)
        {
            float linearInches = squareFeet * 12 ;
            float linearRebarFeet = (linearInches / rebarCenter) * 2;
            return linearRebarFeet;
        }

        
        
        public static float standsNeeded(float squareFeet, float standCenter)
        {
            float linearInches = squareFeet * 12;
            float standsNeeded = (linearInches / standCenter) / 2;
            return standsNeeded;
        }
        

        //end class
    }
}

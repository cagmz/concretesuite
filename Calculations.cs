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
            double circularSquarefeet = (radius * radius) * Math.PI ;
            return circularSquarefeet;
        }

        //this "Functional Method" calculates the Cubic Circle Slab Yardage
        public static double CircularYardage(float radi, float thi)
        {
            double cubicFeet = (radi * radi * thi * Math.PI) / 12;
            double cubicYardage = cubicFeet / 27;
            return cubicYardage;
        }

        //prepend period to comboBox2 amount
        public static double Spillage(int amount)
        {

            double percentageSpill = amount * .01;
            return percentageSpill;

            /* <deleted>
            //string amountDecimal = Convert.ToString(amount);

            ////add If statement because if amount 1-9... add 0 before it
            //if (amountDecimal = "1" || "2" || "3" || "4" || "5" || "7" || "8" || "9")
            //{
            //    amountDecimal = amountDecimal.Insert(0, ".0");
            //}
            //else
            //{
            //    amountDecimal = amountDecimal.Insert(0, ".");
            //}
                    
            ////amountDecimal = amountDecimal.Insert(0, ".");
            //float percentageSpill = Convert.ToSingle(amountDecimal);
            //return percentageSpill;

            //add If statement because if amount 1-9... add 0 before it
            //if (amount > 0 || amount < 10)
            //{
            //    string amountDecimal = Convert.ToString(amount);
            //    amountDecimal = amountDecimal.Insert(0, ".0");
            //    float percentageSpill = Convert.ToSingle(amountDecimal);
            //    return percentageSpill;
            //}
            //else
            //{
            //    string amountDecimalStr = Convert.ToString(amount);
            //    amountDecimalStr = amountDecimalStr.Insert(0, ".");
            //    float percentageSpill = Convert.ToSingle(amountDecimalStr);
            //    return percentageSpill;
            //} </deleted> */
        }



        //end class
    }
}

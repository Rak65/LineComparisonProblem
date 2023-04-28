using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class CalculateLength
    {
        public static void CompareLine()
        {
            double x1, y1, x2, y2,x3,y3,x4,y4;
            
            //We take two co-ordinate points for finding the First length of line
            Console.WriteLine("Enter the (x , y) coordinates of the first point of first line:");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the (x,y) coordinates of the second point of first line:");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());

            double lengthLine1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));    //calculating first length of line
            Console.WriteLine("Length of the First line = "+lengthLine1 );

            ////We take two co-ordinate points for finding the Second length of line
            Console.WriteLine("Enter the (x , y) coordinates of the first point of Second Line:");
            x3 = double.Parse(Console.ReadLine());
            y3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the (x,y) coordinates of the second point of Second Line:");
            x4 = double.Parse(Console.ReadLine());
            y4 = double.Parse(Console.ReadLine());

            double lengthLine2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine("Length of the Second line = " + lengthLine2);                //Caculating second length of line

            int comparisonResult = lengthLine1.CompareTo(lengthLine2);                      //comparing line1 and line2
            if (comparisonResult == 0)
            {
                Console.WriteLine("Line 1 is equal to line 2.");
            }
            else if (comparisonResult < 0)
            {
                Console.WriteLine("Line 1 is less than line 2.");
            }
            else
            {
                Console.WriteLine("Line 1 is greater than line 2.");
            }
        }
    }
}

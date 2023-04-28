using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class CalculateLength
    {
        public static void EqualTwoLine()
        {
            double x1, y1, x2, y2;
            
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
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the (x,y) coordinates of the second point of Second Line:");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());

            double lengthLine2 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Length of the Second line = " + lengthLine2);                //Caculating second length of line

            if (lengthLine1 == lengthLine2)                     //to check both length of line are equal or not
            {
                Console.WriteLine("Both line of length is equal");
            }
            else
            {
                Console.WriteLine("Both line of Length is not equal");
            }
        }
    }
}

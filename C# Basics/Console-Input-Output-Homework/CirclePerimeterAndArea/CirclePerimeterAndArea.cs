//Write a program that reads the radius r of a circle and prints its perimeter 
//and area formatted with 2 digits after the decimal point. Examples:
//    r	 perimeter	 area
//    2	     12.57	12.57
//  3.5	     21.99	38.48

using System;
using System.Linq;
using System.Threading;
using System.Globalization;

namespace CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            while (true)
            {
                Console.Write("Enter radius: ");
                double r = double.Parse(Console.ReadLine());

                double pi = 3.1415926;
                double perimeter = 2 * pi * r;
                double area = pi * r * r;

                Console.WriteLine("The perimeter is: {0:0.00}", perimeter);
                Console.WriteLine("The area is: {0:0.00}", area);
                Console.WriteLine("====================================");
            }
        }
    }
}

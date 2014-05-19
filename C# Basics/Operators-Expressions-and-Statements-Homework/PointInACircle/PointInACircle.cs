//Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). Examples:
//     x	  y	 inside
//     0	  1	   true
//    -2	  0	   true
//    -1	  2	  false
//   1.5     -1	   true
//  -1.5   -1.5	  false
//   100    -30   false
//     0	  0	   true
//   0.2   -0.8	   true
//   0.9  -1.93	  false
//     1  1.655	   true

using System;
using System.Linq;
using System.Threading;
using System.Globalization;

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            while (true)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                double radius = 2;
                Console.Write("Enter value for \"x\": ");
                double coordinateX = double.Parse(Console.ReadLine());
                Console.Write("Enter value for \"y\": ");
                double coordinateY = double.Parse(Console.ReadLine());
                bool isInCircle = (((coordinateX * coordinateX) + (coordinateY * coordinateY)) <= radius * radius);
                string b = (isInCircle ? "is" : "isn't");
                Console.WriteLine("Point with this coordinates {2} within the circle K(0, 2).", coordinateX, coordinateY, b);
                Console.WriteLine("====================================================================");
            }
        }
    }
}

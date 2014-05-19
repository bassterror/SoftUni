//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
//and out of the rectangle R(top=1, left=-1, width=6, height=2). Examples:
//     x	   y	inside K & outside of R
//      1	   2	yes
//    2.5	   2	 no
//      0	   1	 no
//    2.5	   1	 no
//      2	   0	 no
//      4	   0	 no
//    2.5	 1.5	 no
//      2	 1.5	yes
//      1	 2.5	yes
//   -100	-100	 no

using System;
using System.Linq;
using System.Threading;
using System.Globalization;

namespace InsideACircleAndOutsideOfARectangle
{
    class InsideACircleAndOutsideOfARectangle
    {
        static void Main()
        {
            while (true)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                Console.Write("Enter value for \"x\": ");
                double coordinateX = double.Parse(Console.ReadLine());
                Console.Write("Enter value for \"y\": ");
                double coordinateY = double.Parse(Console.ReadLine());
                double radius = 1.5;
                bool isInCircle = ((coordinateX - 1) * (coordinateX - 1) + (coordinateY - 1) * (coordinateY - 1)) <= radius * radius;
                bool isInRectangle = ((-1 <= coordinateX) && (coordinateX <= 5)) && ((-1 <= coordinateY) && (coordinateY <= 1));
                string result = ((isInCircle && !isInRectangle) ? " " : " don't ");
                Console.WriteLine("The point{0}satisfy the condition!", result);
                Console.WriteLine("======================================");
            }
        }
    }
}

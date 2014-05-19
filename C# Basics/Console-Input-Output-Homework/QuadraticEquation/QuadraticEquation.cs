//Write a program that reads the coefficients a, b and c of a quadratic equation 
//ax2 + bx + c = 0 and solves it (prints its real roots). Examples:
//    a	 b	 c	        roots
//    2	 5	-3	x1=-3; x2=0.5
//   -1	 3	 0	   x1=3; x2=0
// -0.5	 4	-8	      x1=x2=4
//    5	 2	 8	no real roots

using System;
using System.Linq;
using System.Threading;
using System.Globalization;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            while(true)
            {
                Console.Write("Enter a: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter b: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Enter c: ");
                double c = double.Parse(Console.ReadLine());
                double d = (b * b) - (4 * a * c);

                if (d < 0)
                {
                    Console.WriteLine("The equation has no real roots!");
                }
                else if (d == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("The equation has only one root: {0}", x);
                }
                else
                {
                    double x1 = ((-b + Math.Sqrt(d)) / (2 * a));
                    double x2 = ((-b - Math.Sqrt(d)) / (2 * a));
                    Console.WriteLine("The equation has two real roots: {0} and {1}", x1, x2);
                }
                Console.WriteLine("=============================================");
            }
        }
    }
}

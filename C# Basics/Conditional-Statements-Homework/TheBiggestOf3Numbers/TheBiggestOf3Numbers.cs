//Write a program that finds the biggest of three numbers. Examples:
//    a	   b	   c	biggest
//    5	   2	   2	5
//   -2	  -2	   1	1
//   -2	   4	   3	4
//    0	-2.5	   5	5
// -0.1	-0.5	-1.1	-0.1

using System;
using System.Linq;
using System.Globalization;
using System.Threading;

namespace TheBiggestOf3Numbers
{
    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            while (true)
            {
                Console.Write("Enter a: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter b: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Enter c: ");
                double c = double.Parse(Console.ReadLine());

                if (a < b)
                {
                    a = b;
                }
                if (a < c)
                {
                    a = c;
                }
                Console.WriteLine("The biggest number is: {0}", a);
                Console.WriteLine("=============================");
            }
        }
    }
}

//Write a program that enters 3 real numbers and prints them sorted in descending order. 
//Use nested if statements. Don’t use arrays and the built-in sorting functionality. Examples:
//    a	    b	   c	result
//    5	    1	   2	5 2 1
//   -2	   -2	   1	1 -2 -2
//   -2	    4	   3	4 3 -2
//    0	 -2.5	   5	5 0 -2.5
// -1.1	 -0.5	-0.1	-0.1 -0.5 -1.1
//   10	   20	  30	30 20 10
//    1	    1	   1	1 1 1

using System;
using System.Linq;
using System.Globalization;
using System.Threading;

namespace Sort3NumbersWithNestedIfs
{
    class Sort3NumbersWithNestedIfs
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
                double min = 0;
                double mid = 0;
                double max = 0;
        
                if (a >= b && a >= c)
                {
                    max = a;
                }
                else
                {
                    if (b >= a && b >= c)
                    {
                        max = b;
                    }
                    else
                    {
                        max = c;
                    }
                }

                if (a >= b && a <= c)
                {
                    mid = a;
                }
                else
                {
                    if (b >= a && b <= c)
                    {
                        mid = b;
                    }
                    else
                    {
                        mid = c;
                    }
                }

                if (a <= b && a <= c)
                {
                    min = a;
                }
                else
                {
                    if (b <= a && b <= c)
                    {
                        min = b;
                    }
                    else
                    {
                        min = c;
                    }
                }
                Console.WriteLine("Result: {0} {1} {2}", max, mid, min);
                Console.WriteLine("==============================");
            }
        }
    }
}

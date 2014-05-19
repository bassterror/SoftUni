//Write a program that finds the biggest of five numbers by using
//only five if statements. Examples:
//  a	   b	   c	 d	   e	biggest
//  5	   2	   2	 4	   1	5
// -2	 -22	   1	 0	   0	1
// -2	   4	   3	 2	   0	4
//  0	-2.5	   0	 5	   5	5
// -3	-0.5	-1.1	-2	-0.1	-0.1

using System;
using System.Linq;
using System.Threading;
using System.Globalization;

namespace TheBiggestOfFiveNumbers
{
    class TheBiggestOfFiveNumbers
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
                Console.Write("Enter d: ");
                double d = double.Parse(Console.ReadLine());
                Console.Write("Enter e: ");
                double e = double.Parse(Console.ReadLine());
                if (a < b)
                {
                    a = b;
                }
                if (a < c)
                {
                    a = c;
                }
                if (a < d)
                {
                    a = d;
                }
                if (a < e)
                {
                    a = e;
                }
                Console.WriteLine("The biggest number is: {0}", a);
                Console.WriteLine("=============================");
            }
        }
    }
}

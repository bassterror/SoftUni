//Write a program that shows the sign (+, - or 0) of the product of three real 
//numbers, without calculating it. Use a sequence of if operators. Examples:
//  a	   b	   c	result
//  5	   2	   2	+
// -2	  -2	   1	+
// -2	   4	   3	-
//  0	-2.5	   4	0
// -1	-0.5	-5.1	-

using System;
using System.Linq;
using System.Globalization;
using System.Threading;

namespace MultiplicationSign
{
    class MultiplicationSign
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

                if (a == 0 || b == 0 || c == 0)
                {
                    Console.WriteLine("Result: 0");
                }
                else
                {
                    bool d = true;
                    if (a < 0)
                    {
                        d = !d;
                    }
                    if (b < 0)
                    {
                        d = !d;
                    }
                    if (c < 0)
                    {
                        d = !d;
                    }
                    Console.WriteLine("Result: {0}", d ? "+" : "-");
                }
                Console.WriteLine("============================");
            }
        }
    }
}

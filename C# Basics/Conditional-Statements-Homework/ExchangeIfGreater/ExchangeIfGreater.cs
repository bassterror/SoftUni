//Write an if-statement that takes two integer variables a and b and exchanges their 
//values if the first one is greater than the second one. As a result print the 
//values a and b, separated by a space. Examples:
//    a	   b	 result
//    5	   2	  2   5
//    3	   4	  3   4
//  5.5	 4.5	4.5 5.5

using System;
using System.Linq;
using System.Threading;
using System.Globalization;

namespace ExchangeIfGreater
{
    class ExchangeIfGreater
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
                double c;

                if (a > b)
                {
                    c = b;
                    b = a;
                    a = c;
                }
                Console.WriteLine("In order: {0} {1}", a, b);
                Console.WriteLine("=======================");
            }
        }
    }
}

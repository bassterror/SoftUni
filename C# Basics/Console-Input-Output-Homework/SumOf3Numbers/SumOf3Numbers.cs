//Write a program that reads 3 real numbers from the console and prints their sum. 
//Examples:
//    a	   b	 c	 sum
//    3	   4	11	  18
//   -2	   0	 3	   1
//  5.5	 4.5  20.1  30.1

using System;
using System.Linq;
using System.Threading;
using System.Globalization;

namespace SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main()
        {
            while (true)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                Console.Write("Enter a: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter b: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Enter c: ");
                double c = double.Parse(Console.ReadLine());

                double sum = a + b + c;
                Console.WriteLine("The sum is: {0}", sum);
                Console.WriteLine("======================================");
            }
        }
    }
}
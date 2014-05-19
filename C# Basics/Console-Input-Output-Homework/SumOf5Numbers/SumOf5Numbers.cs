//Write a program that enters 5 numbers (given in a single line, separated by a space), 
//calculates and prints their sum. Examples:
//           numbers	  sum
//         1 2 3 4 5	   15	
//    10 10 10 10 10	   50	
// 1.5 3.14 8.2 -1 0	11.84

using System;
using System.Linq;
using System.Threading;
using System.Globalization;

namespace SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            while (true)
            {
                Console.Write("Enter 5 numbers separated with space: ");
                string[] input = Console.ReadLine().Split(' ');
                double sum = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    sum += double.Parse(input[i]);
                }
                Console.WriteLine("Sum: {0}", sum);
                Console.WriteLine("===========================================================");
            }
        }
    }
}

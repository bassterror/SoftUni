//Write a program that reads an integer number n from the console and prints all the numbers 
//in the interval [1..n], each on a single line. Note that you may need to use a for-loop. Examples:
//  n  numbers
//  3	     1
//           2
//           3		
//  5	     1
//           2
//           3
//           4
//           5
//  1	     1

using System;
using System.Linq;
using System.Threading;

namespace NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Enter n: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Numbers: ");
                for (int i = 1; i <= n; i++)
                {
                    if (i == n)
                    {
                        Console.Write("{0}", i);
                    }
                    else
                    {
                        Console.Write("{0} ", i);
                    }                    
                    Thread.Sleep(200);
                }
                Console.WriteLine();
                if (n < 10)
                {
                    Console.WriteLine(new string('=', (n * 2) + 8));
                }
                else if (10 < n && n <= 27)
                {
                    Console.WriteLine(new string('=', (n * 3 - 9) + 8));
                }
                else
                {
                    Console.WriteLine(new string('=', 80));
                }
                
            }
        }
    }
}

//Write a program that reads a number n and prints on the console the first n members of 
//the Fibonacci sequence (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Note that you may need to learn how to use loops. Examples:
//  n	comments
//  1	0
//  3	0 1 1
// 10	0 1 1 2 3 5 8 13 21 34

using System;
using System.Linq;
using System.Threading;
using System.Numerics;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Enter n: ");
                int n = int.Parse(Console.ReadLine());
                BigInteger[] numbers = new BigInteger[n + 2];
                numbers[0] = 0;
                numbers[1] = 1;
                if (n < 3)
                {
                    for (int i = 0; i < n; i++)
			        {
                        if (i == n - 1)
                        {
                            Console.Write(numbers[i]);
                        }
                        else
                        {
                            Console.Write("{0} ", numbers[i]);
                        }
		                Thread.Sleep(200);
			        }
                }
                else
	            {
                    for (int i = 2; i < n; i++)
                    {
                        numbers[i] = numbers[i-2] + numbers[i-1];
                    }
                    for (int i = 0; i < n; i++)
			        {
                        if (i == n - 1)
                        {
                            Console.Write(numbers[i]);
                        }
                        else
                        {
                            Console.Write("{0} ", numbers[i]);
                        }
		                Thread.Sleep(200);
			        }
	            }
                Console.WriteLine();
                Console.WriteLine("====================================================");
            }
        }
    }
}

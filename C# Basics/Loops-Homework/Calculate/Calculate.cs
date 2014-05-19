//Write a program that, for a given two integer numbers n and x, calculates the sum 
//S = 1 + 1!/x + 2!/x2 + … + n!/xn. Use only one loop. 
//Print the result with 5 digits after the decimal point.
// n	 x	S
// 3	 2	2.75000
// 4	 3	2.07407
// 5	-4	0.75781

using System;
using System.Linq;

namespace Calculate
{
    class Calculate
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Enter n: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Enter x: ");
                int x = int.Parse(Console.ReadLine());
                double fN = 1;
                double qX = 1;
                double sum = 1;
                for (int i = 1; i <= n; i++)
                {
                    fN *= i;
                    qX *= x;
                    sum += fN / qX;
                }
                Console.WriteLine("S = {0:0.00000}", sum);
                Console.WriteLine("=========================");
            }
        }
    }
}

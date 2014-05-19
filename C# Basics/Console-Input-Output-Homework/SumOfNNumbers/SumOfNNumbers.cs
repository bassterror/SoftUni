//Write a program that enters a number n and after that enters more n numbers and 
//calculates and prints their sum. Note that you may need to use a for-loop. Examples:
// numbers	sum    numbers  sum    numbers  sum
//       3   90          5  6.5          1    1
//      20               2               1
//      60              -1
//      10            -0.5
//                       4
//                       2

using System;
using System.Linq;

namespace SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Enter n: ");
                int n = int.Parse(Console.ReadLine());
                double currentNumber = 0;
                double sum = 0;
        
                for (int i = 0; i < n; i++)           
                {
                    if (i == 0)
                    {
                        Console.Write("Enter first number: ");
                    }
                    else
                    {
                        Console.Write("Enter next number: ");
                    }
                    currentNumber = double.Parse(Console.ReadLine());
                    sum += currentNumber;              
                }
                Console.WriteLine("The sum is: {0}", sum);
                Console.WriteLine("=====================================");
            }
        }
    }
}

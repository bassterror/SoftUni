//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
//the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). 
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. 
//The output is like in the examples below. Examples:
// input	output		input	output
//     3    min = 1         2   min = -1
//     2    max = 5        -1   max = 4
//     5    sum = 8         4   sum = 3
//     1	avg = 2.67		    avg = 1.50

using System;
using System.Linq;

namespace MinMaxSumAndAverageOfNNumbers
{
    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Enter n: ");
                int n = int.Parse(Console.ReadLine());
                int[] numbers = new int[n];
                for (int i = 0; i < n; i++)
                {
                    if (i > 0)
                    {
                        Console.Write("Enter next: ");
                    }
                    else
                    {
                        Console.Write("Enter first number: ");
                    }                    
                    numbers[i] = int.Parse(Console.ReadLine());
                }
                int max = Math.Max(numbers[0],numbers[1]);
                int min = Math.Min(numbers[0],numbers[1]);
                int sum = numbers.Sum();
                double avg = numbers.Average();
                for (int i = 2; i < n; i++)
                {
                    max = Math.Max(max,numbers[i]);
                    min = Math.Min(min, numbers[i]);
                }
                Console.WriteLine("Min = {0}", min);
                Console.WriteLine("Max = {0}", max);
                Console.WriteLine("Sum = {0}", sum);
                Console.WriteLine("Avg = {0:0.00}", avg);
                Console.WriteLine("========================");
            }
        }
    }
}

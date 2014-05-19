//Write an expression that checks if given positive integer number n (n ≤ 100) 
//is prime (i.e. it is divisible without remainder only to itself and 1). Examples:
//  n	  Prime?
//  1	   false
//  2	    true
//  3	    true
//  4	   false
//  9	   false
// 97	    true
// 51	   false
// -3	   false
//  0	   false

using System;
using System.Linq;

namespace PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Enter positive integer in the range (n ≤ 100): ");
                int n = int.Parse(Console.ReadLine());
                if (n > 100 || n < 0)
                {
                    Console.WriteLine("Wrong input!");
                    Console.WriteLine("=============================================");
                }
                else
                {
                    int count = 0;
                    for (int i = 1; i <= n; i++)
                    {
                        if (n % i == 0)
                        {
                            count++;
                        }                        
                    }
                    string isPrime = ((count == 2) ? "IS" : "ISN'T");
                    Console.WriteLine("Your number {0} prime!", isPrime);
                    Console.WriteLine("=============================================");
                }                
            }            
        }
    }
}

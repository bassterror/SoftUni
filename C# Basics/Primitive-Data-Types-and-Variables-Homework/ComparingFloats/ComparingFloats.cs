//Write a program that safely compares floating-point numbers (double) with precision 
//eps = 0.000001. Note that we cannot directly compare two floating-point numbers a and b 
//by a==b because of the nature of the floating-point arithmetic. Therefore, we assume 
//two numbers are equal if they are more closely to each other than a fixed constant eps. 
//Examples:
//       5.3 =       6.01	false
//5.00000001 = 5.00000003	true
//5.00000005 = 5.00000001	true

using System;
using System.Linq;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            double a = 7.002;
            double b = 7.006;
            double c = 7.000000003;
            double d = 7.000000009;
            Console.WriteLine("Comparing the given numbers with precision 0.000001");
            Console.WriteLine(new string('=', 51));
            CompareNumbers((decimal)a, (decimal)b);
            CompareNumbers((decimal)c, (decimal)d);
        }
        private static void CompareNumbers(decimal firstNum, decimal secondNum)
        {
            if (Math.Abs(firstNum - secondNum) < 0.000001m)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}

//Write an expression that checks if given integer is odd or even. Examples:
//    n	    Odd?
//    3     true
//    2    false
//   -2    false
//   -1     true
//    0    false

using System;
using System.Linq;

namespace OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main()
        {
            while (true)
            {                
                Console.Write("Enter integer: ");
                int a = int.Parse(Console.ReadLine());
                int b = a % 2;
                string c = (b == 0 ? "Even" : "Odd");
                Console.WriteLine("Your integer is: {0}", c);
                Console.WriteLine("=======================================");
            }
        }
    }
}

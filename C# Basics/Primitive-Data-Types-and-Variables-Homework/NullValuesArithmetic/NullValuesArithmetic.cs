//Create a program that assigns null values to an integer and to a double variable. 
//Try to print these variables at the console. Try to add some number or the null 
//literal to these variables and print the result.

using System;
using System.Linq;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            Console.WriteLine("Examples with integer");
            int? a = null;
            Console.WriteLine("Integer with null value: " + a);
            a = 23;
            Console.WriteLine("Integer with value 23: " + a);

            Console.WriteLine("\nExamples with double");
            double? b = null;
            Console.WriteLine("Real number with null value: " + b);
            b = 6.78;
            Console.WriteLine("Real number with value 6.78: " + b);
        }
    }
}

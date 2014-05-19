//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one. If the variable is a string, 
//the program appends "*" at the end. Print the result at the console. Use switch statement.

using System;
using System.Linq;
using System.Globalization;
using System.Threading;

namespace PlayWithIntDoubleAndString
{
    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            while (true)
            {
                Console.Write("Enter 1 for int, 2 for double, 3 for string: ");
                byte choice = byte.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter int: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Result: {0}", a + 1);
                        break;
                    case 2:
                        Console.Write("Enter double: ");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Result: {0}", b + 1);
                        break;
                    case 3:
                        Console.Write("Enter string: ");
                        string c = Console.ReadLine();
                        Console.WriteLine("Result: {0}", c + "*");
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
                Console.WriteLine("================================");
            }
        }
    }
}

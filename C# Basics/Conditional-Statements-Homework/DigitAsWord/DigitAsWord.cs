//Write a program that asks for a digit (0-9), and depending on the input, shows the 
//digit as a word (in English). Print “not a digit” in case of invalid inut. 
//Use a switch statement. Examples:
//   d	result
//   2	two
//   1	one
//   0	zero
//   5	five
//-0.1	not a digit
//  hi	not a digit
//   9	nine
//  10	not a digit

using System;
using System.Linq;
using System.Threading;
using System.Globalization;

namespace DigitAsWord
{
    class DigitAsWord
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            while (true)
            {
                Console.Write("Enter digit in the range (0-9): ");
                byte a = byte.Parse(Console.ReadLine());
                string b = "";
                switch (a)
                {
                    case 0:
                        b = "Zero";
                        break;
                    case 1:
                        b = "One";
                        break;
                    case 2:
                        b = "Two";
                        break;
                    case 3:
                        b = "Three";
                        break;
                    case 4:
                        b = "Four";
                        break;
                    case 5:
                        b = "Five";
                        break;
                    case 6:
                        b = "Six";
                        break;
                    case 7:
                        b = "Seven";
                        break;
                    case 8:
                        b = "Eight";
                        break;
                    case 9:
                        b = "Nine";
                        break;
                    default: Console.WriteLine("Not a digit!");
                        break;
                }
                Console.WriteLine("Result: {0}", b);
                Console.WriteLine("=================");
            }
        }
    }
}

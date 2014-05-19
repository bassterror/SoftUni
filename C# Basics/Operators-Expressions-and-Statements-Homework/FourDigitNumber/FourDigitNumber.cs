//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
//•	Prints on the console the number in reversed order: dcba (in our example 1102).
//•	Puts the last digit in the first position: dabc (in our example 1201).
//•	Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0. Examples:
//    n	 sum of digits	  reversed	  last digit in front	  second and third digits exchanged
// 2011	             4	      1102	                 1201	                               2101
// 3333	            12	      3333	                 3333	                               3333
// 9876	            30	      6789	                 6987	                               9786

using System;
using System.Linq;
using System.Threading;
using System.Globalization;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            while (true)
            {
                Console.Write("Enter a four-digit integer: ");
                char[] input = Console.ReadLine().ToArray();
                int sumOfDigits = int.Parse(input[0].ToString()) + int.Parse(input[1].ToString()) + 
                                    int.Parse(input[2].ToString()) + int.Parse(input[3].ToString());
                string revered = input[3].ToString() + input[2].ToString() + input[1].ToString() + input[0].ToString();
                string lastInFront = input[3].ToString() + input[0].ToString() + input[1].ToString() + input[2].ToString();
                string exchanged = input[0].ToString() + input[2].ToString() + input[1].ToString() + input[3].ToString();
                Console.WriteLine("The sum of digits is: {0}", sumOfDigits);
                Console.WriteLine("Reversed digits are: {0}", revered);
                Console.WriteLine("Last digit in front: {0}", lastInFront);
                Console.WriteLine("Second and third digits exchaged: {0}", exchanged);
                Console.WriteLine("=====================================================");
            }
        }
    }
}

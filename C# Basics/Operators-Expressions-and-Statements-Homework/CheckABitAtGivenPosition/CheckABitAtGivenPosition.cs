//Write a Boolean expression that returns if the bit at position p 
//(counting from 0, starting from the right) in given integer number n 
//has value of 1. Examples:
//      n	binary representation of n	 p	 bit @ p == 1
//      5	         00000000 00000101	 2	         true
//      0	         00000000 00000000	 9	        false
//     15	         00000000 00001111	 1	         true
//   5343	         00010100 11011111	 7	         true
//  62241	         11110011 00100001	11	        false

using System;
using System.Linq;

namespace CheckABitAtGivenPosition
{
    class CheckABitAtGivenPosition
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Enter n: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Enter p: ");
                int p = int.Parse(Console.ReadLine());

                int mask = 1 << p;
                int c = mask & n;
                c = c >> p;
                string result = ((c == 1) ? "IS" : "ISN'T");
                Console.WriteLine("The bit value {0} 1", result);
                Console.WriteLine("===============================");
            }
        }
    }
}

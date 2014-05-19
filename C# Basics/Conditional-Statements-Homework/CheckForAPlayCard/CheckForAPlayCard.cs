//Classical play cards use the following signs to designate the card face: 
//2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a 
//string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:
// character	Valid card sign?
//         5	yes
//         1	no
//         Q	yes
//         q	no
//         P	no
//        10	yes
//       500	no

using System;
using System.Linq;
using System.Threading;
using System.Globalization;

namespace CheckForAPlayCard
{
    class CheckForAPlayCard
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            while (true)
            {
                Console.Write("Enter sign: ");
                string sign = Console.ReadLine();
                switch (sign)
                {
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "10":
                    case "J":
                    case "Q":
                    case "K":
                    case "A":
                        Console.WriteLine("Valid: yes");
                        break;
                    default:
                        Console.WriteLine("Valid: no");
                        break;
                }
                Console.WriteLine("======================");
            }

        }
    }
}

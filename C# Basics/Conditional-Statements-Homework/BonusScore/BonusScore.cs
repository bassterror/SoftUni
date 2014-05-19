//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//•	If the score is between 1 and 3, the program multiplies it by 10.
//•	If the score is between 4 and 6, the program multiplies it by 100.
//•	If the score is between 7 and 9, the program multiplies it by 1000.
//•	If the score is 0 or more than 9, the program prints “invalid score”.
//Examples:
// score	       result
//     2	           20
//     4	          400
//     9	         9000
//    -1	invalid score
//    10	invalid score


using System;
using System.Linq;
using System.Globalization;
using System.Threading;

namespace BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            while (true)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                Console.Write("Enter score in the range [1...9]: ");
                int a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1:
                    case 2:
                    case 3:
                        Console.WriteLine("Your final score is: {0}", a * 10);
                        break;
                    case 4:
                    case 5:
                    case 6:
                        Console.WriteLine("Your final score is: {0}", a * 100);
                        break;
                    case 7:
                    case 8:
                    case 9:
                        Console.WriteLine("Your final score is: {0}", a * 1000);
                        break;
                    default:
                        Console.WriteLine("Invalid score!");
                        break;
                }
                Console.WriteLine("==================================");
            }
        }
    }
}

//Write a Boolean expression that checks for given integer if it can be divided
//(without remainder) by 7 and 5 in the same time. Examples:
//   n	   Divided by 7 and 5?
//   3	                 false
//   0	                 false
//   5	                 false
//   7	                 false
//  35	                  true
// 140	                  true

using System;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            while (true)
            {
                Console.Write("Enter integer: ");
                int a = int.Parse(Console.ReadLine());
                bool b = a % 7 == 0;
                bool c = a % 5 == 0;
                bool d = b && c;
                string e = (d ? "is" : "isn't");
                Console.WriteLine("Your integer {0} dividable by 7 and 5", e);
                Console.WriteLine("=======================================");
            }            
        }
    }
}

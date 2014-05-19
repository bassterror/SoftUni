//Write an expression that checks for given integer if its 
//third digit from right-to-left is 7. Examples:
//       n	Third digit 7?
//       5	         false
//     701	          true
//    9703	          true
//     877	         false
//  777877	         false
// 9999799	          true


using System;
using System.Linq;

namespace ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Enter integer: ");
                int integer = int.Parse(Console.ReadLine());
                bool isTrue = (integer / 100) % 10 == 7;
                string result = (isTrue ? "is" : "isn't");
                Console.WriteLine("The third digit of your integer {0} 7", result);
                Console.WriteLine("===========================");
            }            
        }
    }
}

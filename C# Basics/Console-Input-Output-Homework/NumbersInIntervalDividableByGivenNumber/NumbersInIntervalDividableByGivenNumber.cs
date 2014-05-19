//Write a program that reads two positive integer numbers and prints how many numbers p 
//exist between them such that the reminder of the division by 5 is 0. Examples:
//start	 end	 p	comments
//   17	  25	 2	20, 25
//    5	  30	 6	5, 10, 15, 20, 25, 30
//    3	  33	 6	5, 10, 15, 20, 25, 30
//    3	   4	 0	-
//   99	 120	 5	100, 105, 110, 115, 120
//  107	 196	18	110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195

using System;
using System.Linq;
using System.Threading;

namespace NumbersInIntervalDividableByGivenNumber
{
    class NumbersInIntervalDividableByGivenNumber
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Enter first positive integer: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter second positive integer: ");
                int b = int.Parse(Console.ReadLine());
                int c;
                int p = 0;        
                if (a > b)
                {
                    c = a;
                    a = b;
                    b = c;
                }                
                decimal[] comments= new decimal[(b - a) + 1];

                for (int i = 0; i <= b - a; i++)
                {
                    if ((a + i) % 5 == 0)
                    {
                        p++;
                        comments[i] = a + i;
                    }
                }
                Console.WriteLine("p: {0}", p);
                Console.Write("Comments: ");
                for (int i = 0; i < comments.Length; i++)
                {
                    if (comments[i] != 0)
                    {                        
                        Console.Write("{0}, ", comments[i]);
                        Thread.Sleep(200);
                    }
                    if (i == comments.Length - 1)
                    {
                        Console.Write("\b");
                        Console.Write("\b");
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("================================================");
            }
        }
    }
}

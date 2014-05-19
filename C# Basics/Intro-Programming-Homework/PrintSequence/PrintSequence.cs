//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
using System;
using System.Linq;

namespace PrintSequence
{
    class PrintSequence
    {
        static void Main()
        {
            for (int i = 2; i < 12; i = i + 2)
            {
                if (i != 10)
                {
                    Console.Write(i + ", ");
                    Console.Write(-(i + 1) + ", ");
                }
                else
                {
                    Console.Write(i);
                }                
            }
            Console.WriteLine();
        }
    }
}

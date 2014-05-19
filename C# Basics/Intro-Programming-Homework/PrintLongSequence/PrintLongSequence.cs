//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, 
//… You might need to learn how to use loops in C# (search in Internet).
using System;
using System.Linq;

namespace PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main()
        {
            for (int i = 2; i < 1002; i = i + 2)
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

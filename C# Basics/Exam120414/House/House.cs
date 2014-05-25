using System;
using System.Linq;

namespace House
{
    class House
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int up = (input / 2) - 1;
            int sides = input / 2;
            int mid = 1;
            Console.Write(new string('.', sides));
            Console.Write("*");
            Console.Write(new string('.', sides));
            Console.WriteLine();
            sides--;
            for (int i = 0; i < up; i++)
            {
                Console.Write(new string('.', sides));
                Console.Write("*");
                Console.Write(new string('.', mid));
                Console.Write("*");
                Console.Write(new string('.', sides));
                Console.WriteLine();
                sides--;
                mid+=2;
            }
            Console.WriteLine(new string('*', input));
            int lowerSides = input / 4;
            int lowerMid = input - (lowerSides * 2) - 2;
            int down = input / 2;
            for (int i = 1; i <= down; i++)
            {
                if (i != down)
                {
                    Console.Write(new string('.', lowerSides));
                    Console.Write("*");
                    Console.Write(new string('.', lowerMid));
                    Console.Write("*");
                    Console.Write(new string('.', lowerSides));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(new string('.', lowerSides));
                    Console.Write(new string('*', lowerMid + 2));
                    Console.Write(new string('.', lowerSides));
                }
            }
        }
    }
}

using System;
using System.Linq;

namespace Triangle
{
    class Triangle
    {
        static void Main()
        {
            int[] coordinates = new int[6];
            for (int i = 0; i < 6; i++)
            {
                coordinates[i] = int.Parse(Console.ReadLine());
            }
            double sideA = Math.Sqrt(Math.Pow(coordinates[2] - coordinates[0], 2) + Math.Pow(coordinates[3] - coordinates[1], 2));
            double sideB = Math.Sqrt(Math.Pow(coordinates[4] - coordinates[2], 2) + Math.Pow(coordinates[5] - coordinates[3], 2));
            double sideC = Math.Sqrt(Math.Pow(coordinates[0] - coordinates[4], 2) + Math.Pow(coordinates[1] - coordinates[5], 2));
            double p = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));

            if ((sideA + sideB > sideC) && (sideB + sideC > sideA) && (sideA + sideC > sideB))
            {
                Console.WriteLine("Yes");
                Console.WriteLine("{0:0.00}",area);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("{0:0.00}", sideA);
            }

        }
    }
}

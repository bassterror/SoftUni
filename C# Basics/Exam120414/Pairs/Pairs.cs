using System;
using System.Linq;

namespace Pairs
{
    class Pairs
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] elements = input.Split();
            int[] numbers = new int[elements.Length];
            int[] sums = new int[numbers.Length];
            for (int i = 0; i < elements.Length; i++)
            {
                numbers[i] = int.Parse(elements[i]);
                
            }
            for (int i = 1; i < (numbers.Length); i+=2)
            {
                sums[i] = numbers[i - 1] + numbers[i];
            }
            if (numbers.Length == 2)
            {
                if (numbers[0] == numbers[1])
                {
                    Console.WriteLine("Yes, value={0}", sums[1]);
                }
                else
                {
                    Console.WriteLine("No, maxdiff={0}", (Math.Max(numbers[0],numbers[1]) - Math.Min(numbers[0], numbers[1])));
                }
            }
            else
            {
                bool equal = true;
                int max = Math.Max(sums[1],sums[3]);
                int min = Math.Min(sums[1],sums[3]);
                for (int i = 0; i < sums.Length / 2; i += 2)
                {
                    if (sums[i + 1] != sums[i + 3])
                    {
                        equal = false;
                        break;
                    }
                }
                if (equal)
                {
                    Console.WriteLine("Yes, value={0}", sums[1]);
                }
                else
                {
                    if (sums.Length != 4)
                    {
                        for (int i = 0; i <= sums.Length / 2; i += 2)
                        {
                            max = Math.Max(max, (Math.Max(sums[i + 1], sums[i + 3])));
                            min = Math.Min(min, (Math.Min(sums[i + 1], sums[i + 3])));
                        }
                    }                                     
                    Console.WriteLine("No, maxdiff={0}", max - min);
                }
            }            
        }
    }
}

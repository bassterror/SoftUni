//We are given 5 integer numbers. Write a program that finds all subsets of these numbers 
//whose sum is 0. Assume that repeating the same subset several times is not a problem. Examples:
//        numbers	result
//  3  -2  1  1 8	-2 + 1 + 1 = 0
//   3 1 -7 35 22	no zero subset
//   1 3 -4 -2 -1	1 + -1 = 0
//                  1 + 3 + -4 = 0
//                  3 + -2 + -1 = 0

using System;
using System.Linq;

namespace ZeroSubset
{
    class ZeroSubset
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Enter a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter b: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Enter c: ");
                int c = int.Parse(Console.ReadLine());
                Console.Write("Enter d: ");
                int d = int.Parse(Console.ReadLine());
                Console.Write("Enter e: ");
                int e = int.Parse(Console.ReadLine());
                #region Subsets
                int[,] subSets = {
                    { a, a , 0, 0, 0, 0 },
                    { b, b , 0, 0, 0, 0 },
                    { c, c , 0, 0, 0, 0 },
                    { d, d , 0, 0, 0, 0 },
                    { e, e , 0, 0, 0, 0 },
                    { a + b, a, b, 0, 0, 0 },
                    { a + c, a, c, 0, 0, 0 },
                    { a + d, a, d, 0, 0, 0 },
                    { a + e, a, e, 0, 0, 0 },
                    { b + c, b, c, 0, 0, 0 },
                    { b + d, b, d, 0, 0, 0 },
                    { b + e, b, e, 0, 0, 0 },
                    { c + d, c, d, 0, 0, 0 },
                    { c + e, c, e, 0, 0, 0 },
                    { d + e, d, e, 0, 0, 0 },
                    { a + b + c, a, b, c, 0, 0 },
                    { a + b + d, a, b, d, 0, 0 },
                    { a + b + e, a, b, e, 0, 0 },
                    { a + c + d, a, c, d, 0, 0 },
                    { a + c + e, a, c, e, 0, 0 },
                    { a + d + e, a, d, e, 0, 0 },
                    { b + c + d, b, c, d, 0, 0 },
                    { b + c + e, b, c, e, 0, 0 },
                    { b + d + e, b, d, e, 0, 0 },
                    { c + d + e, c, d, e, 0, 0 },
                    { a + b + c + d, a, b, c, d, 0 },
                    { a + b + c + e, a, b, c, e, 0 },
                    { a + b + d + e, a, b, d, e, 0 },
                    { a + c + d + e, a, c, d, e, 0 },
                    { b + c + d + e, b, c, d, e, 0 },
                    { a + b + c + d + e, a, b, c, d, e },
                };
                #endregion

                int counter = 0;
                for (int i = 0; i <= 31; i++)
                {
                    if (i < 5)
                    {
                        if (subSets[i, 0] == 0)
                        {
                            Console.WriteLine("Result: {0} = 0", subSets[i, 1]);
                            counter++;
                        }
                    }
                    if (i >=5 && i < 15)
                    {
                        if (subSets[i, 0] == 0)
                        {
                            Console.WriteLine("Result: {0} + {1} = 0", subSets[i, 1], subSets[i, 2]);
                            counter++;
                        }
                    }
                    if (i >= 15 && i < 25)
                    {
                        if (subSets[i, 0] == 0)
                        {
                            Console.WriteLine("Result: {0} + {1} + {2} = 0", subSets[i, 1], subSets[i, 2], subSets[i, 3]);
                            counter++;
                        }
                    }
                    if (i >= 25 && i < 30)
                    {
                        if (subSets[i, 0] == 0)
                        {
                            Console.WriteLine("Result: {0} + {1} + {2} + {3} = 0", subSets[i, 1], subSets[i, 2], subSets[i, 3], subSets[i, 4]);
                            counter++;
                        }
                    }
                    if (i == 30)
                    {
                        if (subSets[i, 0] == 0)
                        {
                            Console.WriteLine("Result: {0} + {1} + {2} + {3} + {4} = 0", subSets[i, 1], subSets[i, 2], subSets[i, 3], subSets[i, 4], subSets[i, 5]);
                            counter++;
                        }
                    }
                }
                if (counter == 0)
                {
                    Console.WriteLine("No zero subsets!");
                }
                Console.WriteLine("================================================================");
            }
        }
    }
}

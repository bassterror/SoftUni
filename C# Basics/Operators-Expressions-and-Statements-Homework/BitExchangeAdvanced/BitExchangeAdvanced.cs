//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} 
//of a given 32-bit unsigned integer. The first and the second sequence of bits may not 
//overlap. Examples:
//            n	 p	 q	 k	         binary representation of n	                       binary result	      result
//   1140867093	 3	24	 3	01000100 00000000 01000000 00010101	 01000010 00000000 01000000 00100101	  1107312677
//   4294901775	24	 3	 3	11111111 11111111 00000000 00001111	 11111001 11111111 00000000 00111111	  4194238527
//   2369124121	 2	22	10	10001101 00110101 11110111 00011001	 01110001 10110101 11111000 11010001	  1907751121
//    987654321	 2	 8	11	                                  -	                                   -	 overlapping
//    123456789	26	 0	 7	                                  -	                                   -	out of range
//  33333333333	-1	 0	33	                                  -	                                   -	out of range


using System;
using System.Linq;

namespace BitExchangeAdvanced
{
    class BitExchangeAdvanced
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter n = ");
                long n = long.Parse(Console.ReadLine());
                Console.Write("Enter p = ");
                int p = int.Parse(Console.ReadLine());
                Console.Write("Enter q = ");
                int q = int.Parse(Console.ReadLine());
                Console.Write("Enter k = ");
                int k = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------------------------------");

                Console.Write("Binary representation of n: ");
                Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
 
                if (p + k >= 32)
                {
                    Console.WriteLine("Out of range!");
                    Console.WriteLine("============================================================");
                }
                else if (p < q && ((p + q) < k))
                {
                    Console.WriteLine("Overlapping!");
                    Console.WriteLine("============================================================");
                }
                else
                {
                    for (int i = 0; i < k; i++)
                    {
                        int mask = 1 << p;
                        long firstBit = (n & mask) >> p;
                        mask = 1 << q;
                        long lastBit = (n & mask) >> q;

                        if (firstBit == 0)
                        {
                            mask = ~(1 << q);
                            n = n & mask;
                        }
                        else if (firstBit == 1)
                        {
                            mask = 1 << q;
                            n = n | mask;
                        }
                        if (lastBit == 0)
                        {
                            mask = ~(1 << p);
                            n = n & mask;
                        }
                        else if (lastBit == 1)
                        {
                            mask = 1 << p;
                            n = n | mask;
                        }
                        p++;
                        q++;
                    }
                    Console.Write("Binary result:              ");
                    Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
                    Console.WriteLine("Result: {0,52}", n);
                    Console.WriteLine("============================================================");
                }
            }
        }
    }
}

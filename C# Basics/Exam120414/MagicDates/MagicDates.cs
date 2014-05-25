using System;
using System.Linq;

namespace MagicDates
{
    class MagicDates
    {
        static void Main()
        {
            int firstYear = int.Parse(Console.ReadLine());
            int secondYear = int.Parse(Console.ReadLine());
            int magicWeight = int.Parse(Console.ReadLine());
            int diff = secondYear - firstYear;
            bool justOneYear = diff == 0;
            bool found = false;
            if (justOneYear)
            {                
                for (int i = 1; i <= 12; i++)
                {
                    bool leapYear = DateTime.IsLeapYear(firstYear);
                    if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
	                {
		                for (int j = 1; j <= 31; j++)
			            {
                            string date = j.ToString() + i.ToString() + firstYear.ToString();
                            int[] digits = date.ToCharArray().Select(d=>int.Parse(d.ToString())).ToArray();
                            int currentMagicWeght = 0;
                            if (digits.Length == 7)
                            {
                                currentMagicWeght =  digits[0] * digits[1] + digits[0] * digits[2] + digits[0] * digits[3] + digits[0] * digits[4] + digits[0] * digits[5] + 
                                    digits[0] * digits[6] + digits[1] * digits[2] + digits[1] * digits[3] + digits[1] * digits[4] + digits[1] * digits[5] + 
                                    digits[1] * digits[6] + digits[2] * digits[3] + digits[2] * digits[4] + digits[2] * digits[5] + digits[2] * digits[6] + 
                                    digits[3] * digits[4] + digits[3] * digits[5] + digits[3] * digits[6] + digits[4] * digits[5] + digits[4] * digits[6] + 
                                    digits[5] * digits[6];
                            }
                            if (digits.Length == 8)
                            {
                                currentMagicWeght = digits[0] * digits[1] + digits[0] * digits[2] + digits[0] * digits[3] + digits[0] * digits[4] +
                                    digits[0] * digits[5] + digits[0] * digits[6] + digits[0] * digits[7] + digits[1] * digits[2] + digits[1] * digits[3] +
                                    digits[1] * digits[4] + digits[1] * digits[5] + digits[1] * digits[6] + digits[1] * digits[7] + digits[2] * digits[3] +
                                    digits[2] * digits[4] + digits[2] * digits[5] + digits[2] * digits[6] + digits[2] * digits[7] + digits[3] * digits[4] +
                                    digits[3] * digits[5] + digits[3] * digits[6] + digits[3] * digits[7] + digits[4] * digits[5] + digits[4] * digits[6] +
                                    digits[4] * digits[7] + digits[5] * digits[6] + digits[5] * digits[7] + digits[6] * digits[7];
                            }
                            if (digits.Length == 6)
                            {
                                currentMagicWeght = digits[0] * digits[1] + digits[0] * digits[2] + digits[0] * digits[3] + digits[0] * digits[4] +
                                    digits[0] * digits[5] + digits[1] * digits[2] + digits[1] * digits[3] +
                                    digits[1] * digits[4] + digits[1] * digits[5] + digits[2] * digits[3] +
                                    digits[2] * digits[4] + digits[2] * digits[5] + digits[3] * digits[4] +
                                    digits[3] * digits[5] + digits[4] * digits[5];
                            }
                            if (currentMagicWeght == magicWeight)
                            {
                                found = true;
                                if (j <= 9 && i >= 10)
                                {
                                    Console.WriteLine("0{0}-{1}{2}-{3}{4}{5}{6}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                        digits[5].ToString(), digits[6].ToString());
                                }
                                if (j >= 10 && i <= 9)
                                {
                                    Console.WriteLine("{0}{1}-0{2}-{3}{4}{5}{6}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                        digits[5].ToString(), digits[6].ToString());
                                }
                                if (j <= 9 && i <= 9)
                                {
                                    Console.WriteLine("0{0}-0{1}-{2}{3}{4}{5}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                        digits[5].ToString());
                                }
                                else
                                {
                                    Console.WriteLine("{0}{1}-{2}{3}-{4}{5}{6}{7}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                        digits[5].ToString(), digits[6].ToString(), digits[7].ToString());
                                }
                            }
                            
			            }
	                }
                    if (i == 2)
	                {
                        if (leapYear)
                        {
                            for (int j = 1; j <= 29; j++)
                            {
                                string date = j.ToString() + i.ToString() + firstYear.ToString();
                                int[] digits = date.ToCharArray().Select(d => int.Parse(d.ToString())).ToArray();
                                int currentMagicWeght = 0;
                                if (digits.Length == 7)
                                {
                                    currentMagicWeght = digits[0] * digits[1] + digits[0] * digits[2] + digits[0] * digits[3] + digits[0] * digits[4] + digits[0] * digits[5] +
                                        digits[0] * digits[6] + digits[1] * digits[2] + digits[1] * digits[3] + digits[1] * digits[4] + digits[1] * digits[5] +
                                        digits[1] * digits[6] + digits[2] * digits[3] + digits[2] * digits[4] + digits[2] * digits[5] + digits[2] * digits[6] +
                                        digits[3] * digits[4] + digits[3] * digits[5] + digits[3] * digits[6] + digits[4] * digits[5] + digits[4] * digits[6] +
                                        digits[5] * digits[6];
                                }
                                if (digits.Length == 8)
                                {
                                    currentMagicWeght = digits[0] * digits[1] + digits[0] * digits[2] + digits[0] * digits[3] + digits[0] * digits[4] +
                                        digits[0] * digits[5] + digits[0] * digits[6] + digits[0] * digits[7] + digits[1] * digits[2] + digits[1] * digits[3] +
                                        digits[1] * digits[4] + digits[1] * digits[5] + digits[1] * digits[6] + digits[1] * digits[7] + digits[2] * digits[3] +
                                        digits[2] * digits[4] + digits[2] * digits[5] + digits[2] * digits[6] + digits[2] * digits[7] + digits[3] * digits[4] +
                                        digits[3] * digits[5] + digits[3] * digits[6] + digits[3] * digits[7] + digits[4] * digits[5] + digits[4] * digits[6] +
                                        digits[4] * digits[7] + digits[5] * digits[6] + digits[5] * digits[7] + digits[6] * digits[7];
                                }
                                if (digits.Length == 6)
                                {
                                    currentMagicWeght = digits[0] * digits[1] + digits[0] * digits[2] + digits[0] * digits[3] + digits[0] * digits[4] +
                                        digits[0] * digits[5] + digits[1] * digits[2] + digits[1] * digits[3] +
                                        digits[1] * digits[4] + digits[1] * digits[5] + digits[2] * digits[3] +
                                        digits[2] * digits[4] + digits[2] * digits[5] + digits[3] * digits[4] +
                                        digits[3] * digits[5] + digits[4] * digits[5];
                                }
                                if (currentMagicWeght == magicWeight)
                                {
                                    found = true;
                                    if (j <= 9 && i >= 10)
                                    {
                                        Console.WriteLine("0{0}-{1}{2}-{3}{4}{5}{6}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                            digits[5].ToString(), digits[6].ToString());
                                    }
                                    if (j >= 10 && i <= 9)
                                    {
                                        Console.WriteLine("{0}{1}-0{2}-{3}{4}{5}{6}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                            digits[5].ToString(), digits[6].ToString());
                                    }
                                    if (j <= 9 && i <= 9)
                                    {
                                        Console.WriteLine("0{0}-0{1}-{2}{3}{4}{5}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                            digits[5].ToString());
                                    }
                                    else
                                    {
                                        Console.WriteLine("{0}{1}-{2}{3}-{4}{5}{6}{7}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                            digits[5].ToString(), digits[6].ToString(), digits[7].ToString());
                                    }
                                }
                            }
                        }
                        else
                        {
                            for (int j = 1; j <= 28; j++)
                            {
                                string date = j.ToString() + i.ToString() + firstYear.ToString();
                                int[] digits = date.ToCharArray().Select(d => int.Parse(d.ToString())).ToArray();
                                int currentMagicWeght = 0;
                                if (digits.Length == 7)
                                {
                                    currentMagicWeght = digits[0] * digits[1] + digits[0] * digits[2] + digits[0] * digits[3] + digits[0] * digits[4] + digits[0] * digits[5] +
                                        digits[0] * digits[6] + digits[1] * digits[2] + digits[1] * digits[3] + digits[1] * digits[4] + digits[1] * digits[5] +
                                        digits[1] * digits[6] + digits[2] * digits[3] + digits[2] * digits[4] + digits[2] * digits[5] + digits[2] * digits[6] +
                                        digits[3] * digits[4] + digits[3] * digits[5] + digits[3] * digits[6] + digits[4] * digits[5] + digits[4] * digits[6] +
                                        digits[5] * digits[6];
                                }
                                if (digits.Length == 8)
                                {
                                    currentMagicWeght = digits[0] * digits[1] + digits[0] * digits[2] + digits[0] * digits[3] + digits[0] * digits[4] +
                                        digits[0] * digits[5] + digits[0] * digits[6] + digits[0] * digits[7] + digits[1] * digits[2] + digits[1] * digits[3] +
                                        digits[1] * digits[4] + digits[1] * digits[5] + digits[1] * digits[6] + digits[1] * digits[7] + digits[2] * digits[3] +
                                        digits[2] * digits[4] + digits[2] * digits[5] + digits[2] * digits[6] + digits[2] * digits[7] + digits[3] * digits[4] +
                                        digits[3] * digits[5] + digits[3] * digits[6] + digits[3] * digits[7] + digits[4] * digits[5] + digits[4] * digits[6] +
                                        digits[4] * digits[7] + digits[5] * digits[6] + digits[5] * digits[7] + digits[6] * digits[7];
                                }
                                if (digits.Length == 6)
                                {
                                    currentMagicWeght = digits[0] * digits[1] + digits[0] * digits[2] + digits[0] * digits[3] + digits[0] * digits[4] +
                                        digits[0] * digits[5] + digits[1] * digits[2] + digits[1] * digits[3] +
                                        digits[1] * digits[4] + digits[1] * digits[5] + digits[2] * digits[3] +
                                        digits[2] * digits[4] + digits[2] * digits[5] + digits[3] * digits[4] +
                                        digits[3] * digits[5] + digits[4] * digits[5];
                                }
                                if (currentMagicWeght == magicWeight)
                                {
                                    found = true;
                                    if (j <= 9 && i >= 10)
                                    {
                                        Console.WriteLine("0{0}-{1}{2}-{3}{4}{5}{6}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                            digits[5].ToString(), digits[6].ToString());
                                    }
                                    if (j >= 10 && i <= 9)
                                    {
                                        Console.WriteLine("{0}{1}-0{2}-{3}{4}{5}{6}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                            digits[5].ToString(), digits[6].ToString());
                                    }
                                    if (j <= 9 && i <= 9)
                                    {
                                        Console.WriteLine("0{0}-0{1}-{2}{3}{4}{5}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                            digits[5].ToString());
                                    }
                                    else
                                    {
                                        Console.WriteLine("{0}{1}-{2}{3}-{4}{5}{6}{7}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                            digits[5].ToString(), digits[6].ToString(), digits[7].ToString());
                                    }
                                }
                            }
                        }
	                }
                    else
                    {
                        for (int j = 1; j <= 30; j++)
                        {
                            string date = j.ToString() + i.ToString() + firstYear.ToString();
                            int[] digits = date.ToCharArray().Select(d => int.Parse(d.ToString())).ToArray();
                            int currentMagicWeght = 0;
                            if (digits.Length == 7)
                            {
                                currentMagicWeght = digits[0] * digits[1] + digits[0] * digits[2] + digits[0] * digits[3] + digits[0] * digits[4] + digits[0] * digits[5] +
                                    digits[0] * digits[6] + digits[1] * digits[2] + digits[1] * digits[3] + digits[1] * digits[4] + digits[1] * digits[5] +
                                    digits[1] * digits[6] + digits[2] * digits[3] + digits[2] * digits[4] + digits[2] * digits[5] + digits[2] * digits[6] +
                                    digits[3] * digits[4] + digits[3] * digits[5] + digits[3] * digits[6] + digits[4] * digits[5] + digits[4] * digits[6] +
                                    digits[5] * digits[6];
                            }
                            if (digits.Length == 8)
                            {
                                currentMagicWeght = digits[0] * digits[1] + digits[0] * digits[2] + digits[0] * digits[3] + digits[0] * digits[4] +
                                    digits[0] * digits[5] + digits[0] * digits[6] + digits[0] * digits[7] + digits[1] * digits[2] + digits[1] * digits[3] +
                                    digits[1] * digits[4] + digits[1] * digits[5] + digits[1] * digits[6] + digits[1] * digits[7] + digits[2] * digits[3] +
                                    digits[2] * digits[4] + digits[2] * digits[5] + digits[2] * digits[6] + digits[2] * digits[7] + digits[3] * digits[4] +
                                    digits[3] * digits[5] + digits[3] * digits[6] + digits[3] * digits[7] + digits[4] * digits[5] + digits[4] * digits[6] +
                                    digits[4] * digits[7] + digits[5] * digits[6] + digits[5] * digits[7] + digits[6] * digits[7];
                            }
                            if (digits.Length == 6)
                            {
                                currentMagicWeght = digits[0] * digits[1] + digits[0] * digits[2] + digits[0] * digits[3] + digits[0] * digits[4] +
                                    digits[0] * digits[5] + digits[1] * digits[2] + digits[1] * digits[3] +
                                    digits[1] * digits[4] + digits[1] * digits[5] + digits[2] * digits[3] +
                                    digits[2] * digits[4] + digits[2] * digits[5] + digits[3] * digits[4] +
                                    digits[3] * digits[5] + digits[4] * digits[5];
                            }
                            if (currentMagicWeght == magicWeight)
                            {
                                found = true;
                                if (j <= 9 && i >= 10)
                                {
                                    Console.WriteLine("0{0}-{1}{2}-{3}{4}{5}{6}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                        digits[5].ToString(), digits[6].ToString());
                                }
                                if (j >= 10 && i <= 9)
                                {
                                    Console.WriteLine("{0}{1}-0{2}-{3}{4}{5}{6}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                        digits[5].ToString(), digits[6].ToString());
                                }
                                if (j <= 9 && i <= 9)
                                {
                                    Console.WriteLine("0{0}-0{1}-{2}{3}{4}{5}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                        digits[5].ToString());
                                }
                                else
                                {
                                    Console.WriteLine("{0}{1}-{2}{3}-{4}{5}{6}{7}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                        digits[5].ToString(), digits[6].ToString(), digits[7].ToString());
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                for (int k = firstYear; k <= secondYear; k++)
                {
                    for (int i = 1; i <= 12; i++)
                    {
                        bool leapYear = DateTime.IsLeapYear(firstYear);
                        if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
                        {
                            for (int j = 1; j <= 31; j++)
                            {
                                string date = j.ToString() + i.ToString() + firstYear.ToString();
                                int[] digits = date.ToCharArray().Select(d => int.Parse(d.ToString())).ToArray();
                                int currentMagicWeght = 0;
                                if (digits.Length == 7)
                                {
                                    currentMagicWeght = digits[0] * digits[1] + digits[0] * digits[2] + digits[0] * digits[3] + digits[0] * digits[4] + digits[0] * digits[5] +
                                        digits[0] * digits[6] + digits[1] * digits[2] + digits[1] * digits[3] + digits[1] * digits[4] + digits[1] * digits[5] +
                                        digits[1] * digits[6] + digits[2] * digits[3] + digits[2] * digits[4] + digits[2] * digits[5] + digits[2] * digits[6] +
                                        digits[3] * digits[4] + digits[3] * digits[5] + digits[3] * digits[6] + digits[4] * digits[5] + digits[4] * digits[6] +
                                        digits[5] * digits[6];
                                }
                                if (digits.Length == 8)
                                {
                                    currentMagicWeght = digits[0] * digits[1] + digits[0] * digits[2] + digits[0] * digits[3] + digits[0] * digits[4] +
                                        digits[0] * digits[5] + digits[0] * digits[6] + digits[0] * digits[7] + digits[1] * digits[2] + digits[1] * digits[3] +
                                        digits[1] * digits[4] + digits[1] * digits[5] + digits[1] * digits[6] + digits[1] * digits[7] + digits[2] * digits[3] +
                                        digits[2] * digits[4] + digits[2] * digits[5] + digits[2] * digits[6] + digits[2] * digits[7] + digits[3] * digits[4] +
                                        digits[3] * digits[5] + digits[3] * digits[6] + digits[3] * digits[7] + digits[4] * digits[5] + digits[4] * digits[6] +
                                        digits[4] * digits[7] + digits[5] * digits[6] + digits[5] * digits[7] + digits[6] * digits[7];
                                }
                                if (digits.Length == 6)
                                {
                                    currentMagicWeght = digits[0] * digits[1] + digits[0] * digits[2] + digits[0] * digits[3] + digits[0] * digits[4] +
                                        digits[0] * digits[5] + digits[1] * digits[2] + digits[1] * digits[3] +
                                        digits[1] * digits[4] + digits[1] * digits[5] + digits[2] * digits[3] +
                                        digits[2] * digits[4] + digits[2] * digits[5] + digits[3] * digits[4] +
                                        digits[3] * digits[5] + digits[4] * digits[5];
                                }
                                if (currentMagicWeght == magicWeight)
                                {
                                    found = true;
                                    if (j <= 9 && i >= 10)
                                    {
                                        Console.WriteLine("0{0}-{1}{2}-{3}{4}{5}{6}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                            digits[5].ToString(), digits[6].ToString());
                                    }
                                    if (j >= 10 && i <= 9)
                                    {
                                        Console.WriteLine("{0}{1}-0{2}-{3}{4}{5}{6}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                            digits[5].ToString(), digits[6].ToString());
                                    }
                                    if (j <= 9 && i <= 9)
                                    {
                                        Console.WriteLine("0{0}-0{1}-{2}{3}{4}{5}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                            digits[5].ToString());
                                    }
                                    else
                                    {
                                        Console.WriteLine("{0}{1}-{2}{3}-{4}{5}{6}{7}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                            digits[5].ToString(), digits[6].ToString(), digits[7].ToString());
                                    }
                                }
                            }
                        }
                        if (i == 2)
                        {
                            if (leapYear)
                            {
                                for (int j = 1; j <= 29; j++)
                                {
                                    string date = j.ToString() + i.ToString() + firstYear.ToString();
                                    int[] digits = date.ToCharArray().Select(d => int.Parse(d.ToString())).ToArray();
                                    int currentMagicWeght = 0;
                                    if (digits.Length == 7)
                                    {
                                        currentMagicWeght = digits[0] * digits[1] + digits[0] * digits[2] + digits[0] * digits[3] + digits[0] * digits[4] + digits[0] * digits[5] +
                                            digits[0] * digits[6] + digits[1] * digits[2] + digits[1] * digits[3] + digits[1] * digits[4] + digits[1] * digits[5] +
                                            digits[1] * digits[6] + digits[2] * digits[3] + digits[2] * digits[4] + digits[2] * digits[5] + digits[2] * digits[6] +
                                            digits[3] * digits[4] + digits[3] * digits[5] + digits[3] * digits[6] + digits[4] * digits[5] + digits[4] * digits[6] +
                                            digits[5] * digits[6];
                                    }
                                    if (digits.Length == 8)
                                    {
                                        currentMagicWeght = digits[0] * digits[1] + digits[0] * digits[2] + digits[0] * digits[3] + digits[0] * digits[4] +
                                            digits[0] * digits[5] + digits[0] * digits[6] + digits[0] * digits[7] + digits[1] * digits[2] + digits[1] * digits[3] +
                                            digits[1] * digits[4] + digits[1] * digits[5] + digits[1] * digits[6] + digits[1] * digits[7] + digits[2] * digits[3] +
                                            digits[2] * digits[4] + digits[2] * digits[5] + digits[2] * digits[6] + digits[2] * digits[7] + digits[3] * digits[4] +
                                            digits[3] * digits[5] + digits[3] * digits[6] + digits[3] * digits[7] + digits[4] * digits[5] + digits[4] * digits[6] +
                                            digits[4] * digits[7] + digits[5] * digits[6] + digits[5] * digits[7] + digits[6] * digits[7];
                                    }
                                    if (digits.Length == 6)
                                    {
                                        currentMagicWeght = digits[0] * digits[1] + digits[0] * digits[2] + digits[0] * digits[3] + digits[0] * digits[4] +
                                            digits[0] * digits[5] + digits[1] * digits[2] + digits[1] * digits[3] +
                                            digits[1] * digits[4] + digits[1] * digits[5] + digits[2] * digits[3] +
                                            digits[2] * digits[4] + digits[2] * digits[5] + digits[3] * digits[4] +
                                            digits[3] * digits[5] + digits[4] * digits[5];
                                    }
                                    if (currentMagicWeght == magicWeight)
                                    {
                                        found = true;
                                        if (j <= 9 && i >= 10)
                                        {
                                            Console.WriteLine("0{0}-{1}{2}-{3}{4}{5}{6}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                                digits[5].ToString(), digits[6].ToString());
                                        }
                                        if (j >= 10 && i <= 9)
                                        {
                                            Console.WriteLine("{0}{1}-0{2}-{3}{4}{5}{6}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                                digits[5].ToString(), digits[6].ToString());
                                        }
                                        if (j <= 9 && i <= 9)
                                        {
                                            Console.WriteLine("0{0}-0{1}-{2}{3}{4}{5}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                                digits[5].ToString());
                                        }
                                        else
                                        {
                                            Console.WriteLine("{0}{1}-{2}{3}-{4}{5}{6}{7}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                                digits[5].ToString(), digits[6].ToString(), digits[7].ToString());
                                        }
                                    }
                                }
                            }
                            else
                            {
                                for (int j = 1; j <= 28; j++)
                                {
                                    string date = j.ToString() + i.ToString() + firstYear.ToString();
                                    int[] digits = date.ToCharArray().Select(d => int.Parse(d.ToString())).ToArray();
                                    int currentMagicWeght = 0;
                                    if (digits.Length == 7)
                                    {
                                        currentMagicWeght = digits[0] * digits[1] + digits[0] * digits[2] + digits[0] * digits[3] + digits[0] * digits[4] + digits[0] * digits[5] +
                                            digits[0] * digits[6] + digits[1] * digits[2] + digits[1] * digits[3] + digits[1] * digits[4] + digits[1] * digits[5] +
                                            digits[1] * digits[6] + digits[2] * digits[3] + digits[2] * digits[4] + digits[2] * digits[5] + digits[2] * digits[6] +
                                            digits[3] * digits[4] + digits[3] * digits[5] + digits[3] * digits[6] + digits[4] * digits[5] + digits[4] * digits[6] +
                                            digits[5] * digits[6];
                                    }
                                    if (digits.Length == 8)
                                    {
                                        currentMagicWeght = digits[0] * digits[1] + digits[0] * digits[2] + digits[0] * digits[3] + digits[0] * digits[4] +
                                            digits[0] * digits[5] + digits[0] * digits[6] + digits[0] * digits[7] + digits[1] * digits[2] + digits[1] * digits[3] +
                                            digits[1] * digits[4] + digits[1] * digits[5] + digits[1] * digits[6] + digits[1] * digits[7] + digits[2] * digits[3] +
                                            digits[2] * digits[4] + digits[2] * digits[5] + digits[2] * digits[6] + digits[2] * digits[7] + digits[3] * digits[4] +
                                            digits[3] * digits[5] + digits[3] * digits[6] + digits[3] * digits[7] + digits[4] * digits[5] + digits[4] * digits[6] +
                                            digits[4] * digits[7] + digits[5] * digits[6] + digits[5] * digits[7] + digits[6] * digits[7];
                                    }
                                    if (digits.Length == 6)
                                    {
                                        currentMagicWeght = digits[0] * digits[1] + digits[0] * digits[2] + digits[0] * digits[3] + digits[0] * digits[4] +
                                            digits[0] * digits[5] + digits[1] * digits[2] + digits[1] * digits[3] +
                                            digits[1] * digits[4] + digits[1] * digits[5] + digits[2] * digits[3] +
                                            digits[2] * digits[4] + digits[2] * digits[5] + digits[3] * digits[4] +
                                            digits[3] * digits[5] + digits[4] * digits[5];
                                    }
                                    if (currentMagicWeght == magicWeight)
                                    {
                                        found = true;
                                        if (j <= 9 && i >= 10)
                                        {
                                            Console.WriteLine("0{0}-{1}{2}-{3}{4}{5}{6}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                                digits[5].ToString(), digits[6].ToString());
                                        }
                                        if (j >= 10 && i <= 9)
                                        {
                                            Console.WriteLine("{0}{1}-0{2}-{3}{4}{5}{6}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                                digits[5].ToString(), digits[6].ToString());
                                        }
                                        if (j <= 9 && i <= 9)
                                        {
                                            Console.WriteLine("0{0}-0{1}-{2}{3}{4}{5}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                                digits[5].ToString());
                                        }
                                        else
                                        {
                                            Console.WriteLine("{0}{1}-{2}{3}-{4}{5}{6}{7}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                                digits[5].ToString(), digits[6].ToString(), digits[7].ToString());
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            for (int j = 1; j <= 30; j++)
                            {
                                string date = j.ToString() + i.ToString() + firstYear.ToString();
                                int[] digits = date.ToCharArray().Select(d => int.Parse(d.ToString())).ToArray();
                                int currentMagicWeght = 0;
                                if (digits.Length == 7)
                                {
                                    currentMagicWeght = digits[0] * digits[1] + digits[0] * digits[2] + digits[0] * digits[3] + digits[0] * digits[4] + digits[0] * digits[5] +
                                        digits[0] * digits[6] + digits[1] * digits[2] + digits[1] * digits[3] + digits[1] * digits[4] + digits[1] * digits[5] +
                                        digits[1] * digits[6] + digits[2] * digits[3] + digits[2] * digits[4] + digits[2] * digits[5] + digits[2] * digits[6] +
                                        digits[3] * digits[4] + digits[3] * digits[5] + digits[3] * digits[6] + digits[4] * digits[5] + digits[4] * digits[6] +
                                        digits[5] * digits[6];
                                }
                                if (digits.Length == 8)
                                {
                                    currentMagicWeght = digits[0] * digits[1] + digits[0] * digits[2] + digits[0] * digits[3] + digits[0] * digits[4] +
                                        digits[0] * digits[5] + digits[0] * digits[6] + digits[0] * digits[7] + digits[1] * digits[2] + digits[1] * digits[3] +
                                        digits[1] * digits[4] + digits[1] * digits[5] + digits[1] * digits[6] + digits[1] * digits[7] + digits[2] * digits[3] +
                                        digits[2] * digits[4] + digits[2] * digits[5] + digits[2] * digits[6] + digits[2] * digits[7] + digits[3] * digits[4] +
                                        digits[3] * digits[5] + digits[3] * digits[6] + digits[3] * digits[7] + digits[4] * digits[5] + digits[4] * digits[6] +
                                        digits[4] * digits[7] + digits[5] * digits[6] + digits[5] * digits[7] + digits[6] * digits[7];
                                }
                                if (digits.Length == 6)
                                {
                                    currentMagicWeght = digits[0] * digits[1] + digits[0] * digits[2] + digits[0] * digits[3] + digits[0] * digits[4] +
                                        digits[0] * digits[5] + digits[1] * digits[2] + digits[1] * digits[3] +
                                        digits[1] * digits[4] + digits[1] * digits[5] + digits[2] * digits[3] +
                                        digits[2] * digits[4] + digits[2] * digits[5] + digits[3] * digits[4] +
                                        digits[3] * digits[5] + digits[4] * digits[5];
                                }
                                if (currentMagicWeght == magicWeight)
                                {
                                    found = true;
                                    if (j <= 9 && i >= 10)
                                    {
                                        Console.WriteLine("0{0}-{1}{2}-{3}{4}{5}{6}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                            digits[5].ToString(), digits[6].ToString());
                                    }
                                    if (j >= 10 && i <= 9)
                                    {
                                        Console.WriteLine("{0}{1}-0{2}-{3}{4}{5}{6}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                            digits[5].ToString(), digits[6].ToString());
                                    }
                                    if (j <= 9 && i <= 9)
                                    {
                                        Console.WriteLine("0{0}-0{1}-{2}{3}{4}{5}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                            digits[5].ToString());
                                    }
                                    else
                                    {
                                        Console.WriteLine("{0}{1}-{2}{3}-{4}{5}{6}{7}", digits[0].ToString(), digits[1].ToString(), digits[2].ToString(), digits[3].ToString(), digits[4].ToString(),
                                            digits[5].ToString(), digits[6].ToString(), digits[7].ToString());
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("No");
            }
        }
    }
}

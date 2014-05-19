//Write a program that converts a number in the range [0…999] to words, corresponding
//to the English pronunciation. Examples:
// numbers	number as words
//       0	Zero
//       9	Nine
//      10	Ten
//      12	Twelve
//      19	Nineteen
//      25	Twenty five
//      98	Ninety eight
//     273	Two hundred and seventy three
//     400	Four hundred
//     501	Five hundred and one
//     617	Six hundred and seventeen
//     711	Seven hundred and eleven
//     999	Nine hundred and ninety nine

using System;
using System.Linq;

namespace NumberAsWords
{
    class NumberAsWords
    {
        static readonly string[] simple = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        static readonly string[] teens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeeen", "eighteen", "nineteen" };
        static readonly string[] round = { null, null, "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        static void Main()
        {
            while (true)
            {
                Console.Write("Enter number in range (0-999): ");
                int a;
                if (int.TryParse(Console.ReadLine(), out a))
                {
                    if (a > 999 || a < 0)
                    {
                        Console.WriteLine("The number is out of range!");
                        Console.WriteLine("==================================================");
                        continue;
                    }
                    int firstDigit = a / 100;
                    int secondDigit = (a / 10) % 10;
                    int thirdDigit = a % 10;
                    string word = "";

                    if (firstDigit == 0)
                    {
                        if (secondDigit == 0)
                        {
                            word = simple[thirdDigit].First().ToString().ToUpper() + String.Join("", simple[thirdDigit].Skip(1));
                        }
                        else
                        {
                            if (secondDigit == 1)
                            {
                                word = teens[thirdDigit].First().ToString().ToUpper() + String.Join("", teens[thirdDigit].Skip(1));
                            }
                            else
                            {
                                word = round[secondDigit].First().ToString().ToUpper() + String.Join("", round[secondDigit].Skip(1));
                                if (thirdDigit > 0)
                                {
                                    word += " " + simple[thirdDigit];
                                }
                            }
                        }
                    }
                    else
                    {
                        word = simple[firstDigit].First().ToString().ToUpper() + String.Join("", simple[firstDigit].Skip(1)) + " hundred";
                        if (secondDigit == 0)
                        {
                            if (thirdDigit != 0)
                            {
                                word += " and " + simple[thirdDigit];
                            }
                        }
                        else
                        {
                            if (secondDigit == 1)
                            {
                                word += " and " + teens[thirdDigit];
                            }
                            else
                            {
                                word += " and " + round[secondDigit];
                                if (thirdDigit > 0)
                                {
                                    word += " " + simple[thirdDigit];
                                }
                            }
                        }
                    }
                    Console.WriteLine("Result: {0}", word);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                Console.WriteLine("==================================================");
            }
        }
    }
}

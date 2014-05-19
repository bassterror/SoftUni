//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
using System;
using System.Linq;

namespace AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main()
        {
            DateTime afterTenYears = DateTime.Now.AddYears(10);
            Console.Write("Enter your birth year: ");
            int yearOfBirth = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age in ten years will be: {0}", afterTenYears.Year - yearOfBirth);
        }
    }
}

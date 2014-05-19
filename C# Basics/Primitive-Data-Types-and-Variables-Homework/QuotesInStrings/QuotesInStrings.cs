//Declare two string variables and assign them with following value:
//The "use" of quotations causes difficulties.
//Do the above in two different ways: with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.

using System;
using System.Linq;

namespace QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main()
        {
            string a = "The \"use\" of quotations causes difficulties.";
            string b = "The use of quotations causes difficulties.";
            Console.WriteLine("With: {0}\nWithout: {1}", a, b);
        }
    }
}

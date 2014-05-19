//Declare a Boolean variable called isFemale and assign an appropriate value 
//corresponding to your gender. Print it on the console.

using System;
using System.Linq;

namespace BooleanVariable
{
    class BooleanVariable
    {
        static void Main()
        {
            string myGender = "Male";
            string check = "Female";
            bool isFemale = (myGender == check);
            Console.WriteLine("Am I female?\n{0}", isFemale);
        }
    }
}

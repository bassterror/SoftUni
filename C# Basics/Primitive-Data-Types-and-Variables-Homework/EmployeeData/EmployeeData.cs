//A marketing company wants to keep record of its employees. 
//Each record would have the following characteristics:
//•	First name
//•	Last name
//•	Age (0...100)
//•	Gender (m or f)
//•	Personal ID number (e.g. 8306112507)
//•	Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single 
//employee using appropriate primitive data types. Use descriptive names. 
//Print the data at the console.


using System;
using System.Linq;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Miroslav";
            string familyName = "Petrov";
            byte age = 27;
            char gender = 'M';
            int idNumber = 124568974;
            int emplNumber = 27560048;
            Console.WriteLine("{0} {1} has the following company credentials:", firstName, familyName);
            Console.WriteLine(new string('=', 54));
            Console.WriteLine("Age: {0}\nGender: {1}\nPersonal ID Number: {2}\nUnique employee number: {3}", age, gender, idNumber, emplNumber);
            Console.WriteLine(new string('=', 54));
        }
    }
}

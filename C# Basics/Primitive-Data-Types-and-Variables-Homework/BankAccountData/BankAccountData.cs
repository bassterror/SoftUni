//A bank account has a holder name (first name, middle name and last name), 
//available amount of money (balance), bank name, IBAN, 3 credit card numbers 
//associated with the account. Declare the variables needed to keep the information 
//for a single bank account using the appropriate data types and descriptive names.
using System;
using System.Linq;

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main()
        {
            string firstName = "Mirolsav";
            string middleName = "Plamenov";
            string lastName = "Petrov";
            string bankName = "FIBank";
            string iban = "BG80 BNBG 9661 1020 3456 78";
            string bic = "FINVBGSF";
            string cc1 = "4111 1111 1111 1111";
            string cc2 = "4111 1111 1111 1112";
            string cc3 = "4111 1111 1111 1113";
            decimal balance = 759873045.56m;
            Console.WriteLine("An account in {0} with the following credentials:", bankName);
            Console.WriteLine(new string('=', 52));
            Console.WriteLine("First Name: {0}", firstName);
            Console.WriteLine("Middle Name: {0}", middleName);
            Console.WriteLine("Last Name: {0}", lastName);
            Console.WriteLine("IBAN: {0}", iban);
            Console.WriteLine("SWIFT or BIC Code: {0}", bic);
            Console.WriteLine("Three credit cards with numbers:\n{0},\n{1},\n{2};", cc1, cc2, cc3);
            Console.WriteLine("Balance: {0}lv.", balance);
            Console.WriteLine(new string('=', 52));
        }
    }
}

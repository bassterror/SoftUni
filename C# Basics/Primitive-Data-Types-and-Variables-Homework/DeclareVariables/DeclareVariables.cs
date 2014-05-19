//Declare five variables choosing for each of them the most appropriate of the types 
//byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values:
//52130, -115, 4825932, 97, -10000. Choose a large enough type for each number to ensure
//it will fit in it.
using System;
using System.Linq;

namespace DeclareVariables
{
    class DeclareVariables
    {
        static void Main()
        {
            ushort a = 52130;
            sbyte b = -115;
            int c = 4825932;
            byte d = 97;
            short e = -10000;
            Console.WriteLine("Appropriate type for \"52130\" is: {0}", a.GetType());
            Console.WriteLine("Appropriate type for \"-115\" is: {0}", b.GetType());
            Console.WriteLine("Appropriate type for \"4825932\" is: {0}", c.GetType());
            Console.WriteLine("Appropriate type for \"97\" is: {0}", d.GetType());
            Console.WriteLine("Appropriate type for \"-10000\" is: {0}", e.GetType());
        }
    }
}

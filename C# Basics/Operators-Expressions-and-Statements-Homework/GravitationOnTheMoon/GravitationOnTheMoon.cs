//The gravitational field of the Moon is approximately 17% of that on the Earth. 
//Write a program that calculates the weight of a man on the moon by a given 
//weight on the Earth. Examples:
//weight    weight on the Moon
//    86	             14.62
//  74.6	            12.682
//  53.7	             9.129

using System;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            while (true)
            {
                Console.Write("Enter weight on Earth: ");
                double weightOnEarth = double.Parse(Console.ReadLine());
                double weightOnMoon = weightOnEarth * 0.17;
                Console.WriteLine("Weight on Moon is approximately: {0}", weightOnMoon);
                Console.WriteLine("=======================================");
            }
        }
    }
}

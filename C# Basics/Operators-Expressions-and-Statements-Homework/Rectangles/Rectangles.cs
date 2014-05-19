//Write an expression that calculates rectangle’s perimeter and 
//area by given width and height. Examples:
//width	  height   perimeter   area
//    3	       4	      14	 12
//  2.5	       3	      11	7.5
//    5	       5	      20	 25

using System;
using System.Linq;
using System.Threading;
using System.Globalization;

namespace Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InstalledUICulture;
            while (true)
            {
                Console.Write("Enter hight: ");
                double hight = double.Parse(Console.ReadLine());
                Console.Write("Enter width: ");
                double width = double.Parse(Console.ReadLine());
                double perimeter = 2 * (hight + width);
                double area = (hight * width);
                Console.WriteLine("Rectangle's area is: {0}\nRectangle's perimeter is: {1}", area, perimeter);
                Console.WriteLine("=======================================");
            }            
        }
    }
}

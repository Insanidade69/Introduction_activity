using System;
using System.Globalization;

namespace Aulas
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-= Triangle Area Calculation =-=-=-=-=-=-=-=-=-=-");

            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Type three values of A: (One value per line)");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Type three values of A: (One value per line)");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            double p = (xA + xB + xC) / 2;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("The value of area X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("The value of area Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            if (areaX > areaY)
            {
                Console.WriteLine("The bigger area is X.");
            }else if(areaX < areaY)
            {
                Console.WriteLine("The bigger area is Y.");
            }
            else
            {
                Console.WriteLine("The areas is equals.");
            }
        }
    }
}

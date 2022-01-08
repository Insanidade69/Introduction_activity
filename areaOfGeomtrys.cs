using System;
using System.Globalization;

namespace Aulas
{
    class Program
    {
        static void Main()
        {
            Console.Write("What value of A: \n");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("What value of B: \n");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("What value of C: \n");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            double triangle = a * c / 2.0;
            double circle = c * c * Math.PI;
            double trapeze = (a + b) / 2.0 * c;
            double square = Math.Pow(b, b);
            double rectangle = a * b;

            Console.WriteLine("Triangle: {0}", triangle.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Circle: {0}", circle.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapeze: {0}", trapeze.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Square: {0}", square.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Rectangle: {0}", rectangle.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}

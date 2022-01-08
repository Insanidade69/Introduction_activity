using System;
using System.Globalization;

namespace Aulas
{
    class Program
    {
        static void Main()
        {
            double x, y;

            Console.WriteLine("What is values of X and Y? (Type in only line)");
            string[] vet = Console.ReadLine().Split(' ');
            x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y = double.Parse(vet[1], CultureInfo.InvariantCulture);
            


            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origin.");
            }
            else if(x == 0.0)
            {
                Console.WriteLine("Point is it: Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Point is it: X");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Point is it: Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Point is it: Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Point is it: Q3");
            }
            else
            {
                Console.WriteLine("Point is it: Q4");
            }
        }
    }
}

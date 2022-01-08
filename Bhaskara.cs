using System;
using System.Globalization;

namespace Aulas
{
    class Program
    {
        static void Main()
        {
            double a, b, c, delta, x1, x2;

            Console.WriteLine("What is values of A, B and C? (Type in only line)");
            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(b, b) - 4 * a * c;


            if (delta == 0.0 || delta < 0.0)
            {
                Console.WriteLine("Impossible to Calculate!");
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2.0 * a);

                Console.WriteLine("X1 is equal: {0}", x1.ToString("F4", CultureInfo.InvariantCulture));
                Console.WriteLine("X2 is equal: {0}", x2.ToString("F4", CultureInfo.InvariantCulture));
            }
        }
    }
}

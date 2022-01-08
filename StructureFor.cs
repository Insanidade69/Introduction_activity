using System;
using System.Globalization;

namespace Aulas
{
    class Program
    {
        static void Main()
        {
            Console.Write("What amount of u type? ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Value #{0}: ", i);
                int value = int.Parse(Console.ReadLine());
                sum += value;
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}

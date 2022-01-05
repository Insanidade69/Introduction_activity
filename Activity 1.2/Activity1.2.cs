using System;

namespace Activity1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double area;

            Console.WriteLine("What is radius?");
            double raio = double.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            area = Math.Round(Math.Pow(raio, 2) * 3.14159, 4);
            Console.WriteLine("The area value is: {0}.", area);

        }
    }
}

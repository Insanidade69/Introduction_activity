using System;

namespace ActivityIntro
{
    class Program
    {
        int cod1, cod2, qtd1, qtd2;
        float price1, price2;

        static void Main(string[] args)
        {
            Program program = new Program();

            //First entrance, first piece
            Console.WriteLine("What is the first code?");
            program.cod1 = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the first amount?");
            program.qtd1 = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the first price?");
            program.price1 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            //Second entrance, second piece
            Console.WriteLine("What is the second code?");
            program.cod2 = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the second amount?");
            program.qtd2 = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the second price?");
            program.price2 = float.Parse(Console.ReadLine());


            //result of total itens
            float total = program.price1 * program.qtd1 + program.price2 * program.qtd2;

            Console.WriteLine("Total to pay of pieces {0} and {1} is R$ {2}.",program.cod1, program.cod2, total);

        }
    }
}
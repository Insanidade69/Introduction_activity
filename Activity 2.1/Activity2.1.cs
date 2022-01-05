using System;

namespace Activity2_1
{
    class Program
    {
        static void List()
        {
            //List all itens disponibles in menu
            Console.WriteLine("Which item do u want?\n");

            Console.WriteLine("-=-=-=-=-=-= Table of Prices =-=-=-=-=-=-");
            Console.WriteLine("  CÓD          NAME                PRICE\n" +
                "------------------------------------------\n" +
                "   1         HotDog              US$ 4,00\n" +
                "   2         X-Salad             US$ 4,50\n" +
                "   3         X-Bacon             US$ 5,00\n" +
                "   4         Toast               US$ 2,00\n" +
                "   5         Refrigerant         US$ 1,50\n");
        }


        static void Main(string[] args)
        {

           bool func = true;//while true the program work

            while (func == true)
            {
                List();
                Console.Write("Cód Option: "); //capture code of item in menu
                double opt = double.Parse(Console.ReadLine());

                switch (opt) //logic of selection
                {
                    case 1:
                        double price1 = 4.00;

                        Console.Write("Amount: ");
                        int qtd1 = int.Parse(Console.ReadLine());//get amount of item

                        double total1 = Convert.ToDouble(price1 * qtd1);//resolve amount of itens in total value
                        Console.WriteLine("Total is: US$ {0}\n", total1.ToString("F"));

                        Console.WriteLine("Do you want continue? y or n");//ask if u want continue
                        string select1 = Console.ReadLine();
                        switch (select1)
                        {
                            case "y":
                                
                                break;

                            case "n":
                                func = false;
                                break;
                        }
                        break;

                    case 2:
                        double price2 = 4.50;

                        Console.Write("Amount: ");
                        int qtd2 = int.Parse(Console.ReadLine());//get amount of item

                        double total2 = Math.Round(price2 * qtd2, 2);//resolve amount of itens in total value
                        Console.WriteLine("Total is: US$ {0}\n", total2.ToString("F"));

                        Console.WriteLine("Do you want continue? y or n");//ask if u want continue
                        string select2 = Console.ReadLine();
                        switch (select2)
                        {
                            case "y":
                                
                                break;

                            case "n":
                                func = false;
                                break;
                        }
                        break;

                    case 3:
                        double price3 = 5.00;

                        Console.Write("Amount: ");
                        int qtd3 = int.Parse(Console.ReadLine());//get amount of item

                        double total3 = Math.Round(price3 * qtd3, 2);//resolve amount of itens in total value
                        Console.WriteLine("Total is: US$ {0}\n", total3.ToString("F"));

                        Console.WriteLine("Do you want continue? y or n");//ask if u want continue
                        string select3 = Console.ReadLine();
                        switch (select3)
                        {
                            case "y":
                                
                                break;

                            case "n":
                                func = false;
                                break;
                        }
                        break;

                    case 4:
                        double price4 = 2.00;

                        Console.Write("Amount: ");
                        int qtd4 = int.Parse(Console.ReadLine());//get amount of item

                        double total4 = Math.Round(price4 * qtd4, 2);//resolve amount of itens in total value
                        Console.WriteLine("Total is: US$ {0}\n", total4.ToString("F"));

                        Console.WriteLine("Do you want continue? y or n");//ask if u want continue
                        string select4 = Console.ReadLine();
                        switch (select4)
                        {
                            case "y":
                                List();
                                break;

                            case "n":
                                func = false;
                                break;
                        }
                        break;

                    case 5:
                        double price5 = 1.50;

                        Console.Write("Amount: ");
                        int qtd5 = int.Parse(Console.ReadLine());//get amount of item

                        double total5 = Math.Round(price5 * qtd5, 2);//resolve amount of itens in total value
                        Console.WriteLine("Total is: US$ {0}\n", total5.ToString("F"));

                        Console.WriteLine("Do you want continue? y or n");//ask if u want continue
                        string select5 = Console.ReadLine();
                        switch (select5)
                        {
                            case "y":
                                List();
                                break;

                            case "n":
                                func = false;
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid Option. Try Again!");
                        
                        break;
                }
            }
        }
    }
}

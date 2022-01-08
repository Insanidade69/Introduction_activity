using System;

namespace loginScreen
{
    class Program
    {

        static void Main(string[] args)
        {
            Option(); //first parameter
            Midpoint(); //Mid parameter
            Login(); //last parameter
        }
        static void Register() //Registration logic 
        {
            ConsoleKeyInfo key;

            Console.WriteLine("-=-=-=-=-=-= SIGN-UP =-=-=-=-=-=-");
            Console.Write("User: ");
            string userIn = Console.ReadLine();

            Console.WriteLine(" ");

            Console.Write("Password: ");
            string passIn = "";

            do //to change the string typed for *
            {
                key = Console.ReadKey(true);

                // Backspace Should Not Work
                if (key.Key != ConsoleKey.Backspace)
                {
                    passIn += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    Console.Write("\b");
                }
            }
            // Stops Receving Keys Once Enter is Pressed
            while (key.Key != ConsoleKey.Enter);

            //Console.WriteLine(userIn + " " + passIn); //debug information
        }
        static void Login() //Login logic
        {
            ConsoleKeyInfo key;
            string passOut = "";

            string boss = "Insanidade69";

            Console.WriteLine("-=-=-=-=-=-= LOGIN =-=-=-=-=-=-");
            Console.Write("User: ");
            string userOut = Console.ReadLine();
            if (userOut == boss)
            {
                Console.WriteLine("HI BOSS!\n");
            }
            else if (Console.ReadLine() != boss)
            {
                Console.WriteLine("Hi, welcome!\n");
            }
            Console.Write("Password: ");
            do
            {
                key = Console.ReadKey(true);

                // Backspace Should Not Work
                if (key.Key != ConsoleKey.Backspace)
                {
                    passOut += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    Console.Write("\b");
                }
            }
            // Stops Receving Keys Once Enter is Pressed
            while (key.Key != ConsoleKey.Enter);

            Console.WriteLine("\n\nOk, access granted to the system, press enter to continue!");
            Console.ReadLine();

            //put ur database here or ur system or any application logic

            //remove the next command to not close application
            Environment.Exit(0);

        }
        static void Option()
        {
            Console.WriteLine("Welcome to my program, this is a concept of Login in console. \nI know this is not correct login panel, but is this only test!");
            Console.WriteLine("NOTE: This program dont save infos after closing.\n");
            Console.WriteLine("You want do register? y or n, exit");
            string opt = Console.ReadLine();

            switch (opt)
            {
                case "y":
                    Register();
                    break;

                case "n":
                    Login();
                    break;

                case "exit":
                    Environment.Exit(0);
                    break;

                default:
                    Environment.Exit(0);
                    break;
            }
        }
        static void Midpoint()
        {
            Console.WriteLine("\n\nWhat u want do now? Exit, Login or Register.");
            string opt = Console.ReadLine();

            switch (opt)
            {
                case "Exit":
                    Environment.Exit(0);
                    break;

                case "Login":
                    Login();
                    break;

                case "Register":
                    Register();
                    break;

                default:
                    Console.Clear();
                    Option(); ;
                    break;
            }
        }
    }
}

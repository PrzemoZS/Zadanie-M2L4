//Zadanie 1

using System;

namespace ZadanieM2L4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("What is your age?");
            int age = int.Parse (Console.ReadLine());
            Console.WriteLine("What is your sex?");
            char sex = char.Parse(Console.ReadLine());
            Console.WriteLine("What is your pesel number?");
            string pesel = Console.ReadLine();
            Console.WriteLine("What is your ID?");
            string id = Console.ReadLine();

            //Zadanie 2

            char x = 'A', y = 'B', z = 'C';
            Console.WriteLine($"{z} {y} {x}");

            //Zadanie 3



        }
    }

}
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoja srednia:");
            double srednia = double.Parse(Console.ReadLine());

            if (srednia>=2 && srednia<=3.99)
            { 
                Console.WriteLine("Nie przysluguje Ci stypendium");
            }
            else if (srednia>=4 && srednia <= 4.79)
            {
                Console.WriteLine("Przysluguje Ci stypendium w wysokości 350 zł");
            }
            else if (srednia>4.79 && srednia <=5)
            {
                Console.WriteLine("Przysluguje Ci stypendium w wysokosci 550 zł");
            }
            Console.ReadKey();
        }
    }
}

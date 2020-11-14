using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj znak porzadanej operacji oraz liczby na ktorych operacja ma byc wykonana:");
            char operation = char.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double x = 0;
            if (operation == '+')
            {
                x = a + b;
                Console.WriteLine("Wynik dodawania to: {0}", x);
            }
            else if (operation == '-')
            {
                x = a - b;
                Console.WriteLine("Wynik odejmowania to: {0}", x);
            }
            else if (operation == '*')
            {
                x = a * b;
                Console.WriteLine("Wynik mnożenia to: {0}", x);
            }
            else if (operation == '/')
            {
                while (b == 0)
                {
                    Console.WriteLine("nie można dzielic przez 0");
                    b = double.Parse(Console.ReadLine());
                }
                x = a / b;
                Console.WriteLine("Wynik operacji dzielenia to: {0}", x);
            }
            
            Console.ReadKey();

        }
    }
}

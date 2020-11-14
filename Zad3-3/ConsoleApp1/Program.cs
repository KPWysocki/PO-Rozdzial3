using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj trzy liczby:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a < b)
                if (b < c)
                    Console.WriteLine("Najwieksza liczba jest {0}", c);
                else
                    Console.WriteLine("Najwieksza liczba jest {0}", b);
            else
                Console.WriteLine("Najwieksza liczba jest {0}", a);

            Console.ReadKey();

        }
    }
}

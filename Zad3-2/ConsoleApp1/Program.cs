using System;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź dwie liczby calkowiete");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a % b == 0)
                Console.WriteLine("{0} jest dzielnikiem {1}", b, a);
            else
                Console.WriteLine("{0} nie jest dzielnikiem {1}", b, a);

            Console.ReadKey();
        }
    }
}

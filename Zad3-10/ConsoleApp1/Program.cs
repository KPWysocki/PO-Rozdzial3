using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Silnie jakiej liczby chcesz obliczyc?");
            int n = int.Parse(Console.ReadLine());
            int silnia=1;
            for (int i = 1; i <= n; i++)
            {
                silnia = silnia * i;
            }
            Console.WriteLine("Silnia {0} wynosi {1}", n, silnia);
            Console.ReadKey();


        }
    }
}

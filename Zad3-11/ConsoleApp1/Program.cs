using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba1 = 0;
            int liczba2 = 0;
            int i;
            for (i=0; liczba2 < 100; i++)
            {
                liczba2 = liczba2 + liczba1;
                    liczba1++;
            }
            Console.WriteLine("Aby suma wyniosła 100, nalezy zsumowac {0} liczb calkowitych", i);
            Console.ReadKey();
        }
    }
}

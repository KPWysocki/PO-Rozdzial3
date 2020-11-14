using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz rok : ");
            int rok = int.Parse(Console.ReadLine());
            if (rok % 4 == 0)
                if (rok % 100 == 0)
                    if (rok % 400 == 0)
                        Console.WriteLine("{0} jest rokiem przestepnym", rok);
                    else
                        Console.WriteLine("{0} nie jest rokiem przestępnym", rok);

            Console.ReadKey();
        }
    }
}

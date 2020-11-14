using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczby calkowite, ktore maja byc zsumowane, zaby zakonczyc dzialanie wprowadz wartosc 0");
            int suma = 0; 
            int liczba = 1;
            while (liczba!=0)
            {
                liczba = int.Parse(Console.ReadLine());
                suma = suma + liczba;
            }
            Console.WriteLine("Suma podanych liczba to {0}", suma);
            Console.ReadKey();
        }
    }
}

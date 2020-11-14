using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoja mase w kg");
            int masa = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swoj wzrost w metrach:");
            double wzrost = double.Parse(Console.ReadLine());
            double BMI = masa / (wzrost * wzrost);
            if (BMI < 18.5)
            { Console.WriteLine("Masz niedowage - BMI {0}", BMI); }
            else if (BMI >= 18.5 && BMI <= 25)
            { Console.WriteLine("Masz BMI w normie - {0}", BMI); }
            else if (BMI > 25)
            { Console.WriteLine("Masz nadwage - BMI {0}", BMI); }

            Console.ReadKey();
        }
    }
}

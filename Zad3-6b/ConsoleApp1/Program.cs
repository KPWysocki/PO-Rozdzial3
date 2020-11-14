using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPP1
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
            if (BMI < 16)
            {
                Console.WriteLine("Jestes wyglodzony - BMI {0}", BMI);
            }
            else if (BMI >= 16 && BMI < 17)
            { 
                Console.WriteLine("Jestes wychudzony - BMI {0}", BMI); 
            
            }
            else if (BMI >= 17 && BMI < 18.5)
            {
                Console.WriteLine("Masz niedowage - BMI {0}", BMI);
            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                Console.WriteLine("Masz porzadana mase ciala - BMI {0}", BMI);
            }
            else if (BMI >= 25 && BMI < 30)
            {
                Console.WriteLine("Masz nadwage - BMI {0}", BMI);
            }
            else if (BMI >= 30 && BMI < 35)
            {
                Console.WriteLine("Masz otylosc I stopnia - BMI {0}", BMI);
            }
            else if (BMI >= 35 && BMI < 40)
            {
                Console.WriteLine("Masz otylosc II stopnia - BMI {0}", BMI);
            }
            else if (BMI >= 40)
            {
                Console.WriteLine("Masz otylosc III stopnia - BMI {0}", BMI);
            }
            Console.ReadKey();
        }
    }
}

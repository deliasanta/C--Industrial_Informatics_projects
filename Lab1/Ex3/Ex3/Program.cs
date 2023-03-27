using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double fah = 0, celsius = 0;
            Console.Write("Introduceti temperatura in grade fahrenheit: ");
            fah = double.Parse(Console.ReadLine());
            Console.WriteLine("Conversia in grade celsius este {0} ", Celsius(fah));

            Console.Write("Introduceti temperatura in grade celsius: ");
            celsius = double.Parse(Console.ReadLine());
            Console.WriteLine("Conversia in grade fahrenheit este {0} ", Fah(celsius));

            Console.ReadKey();

        }

        static double Fah(double celsius)
        {
            double fah = 0;
            fah = (celsius * 9 / 5) + 32;
            return fah;
        }

        static double Celsius(double fah)
        {
            double celsius = 0;
            celsius = (fah - 32) * 5 / 9;
            return celsius;
        }

    }
}

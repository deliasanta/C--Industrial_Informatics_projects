using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0; 
            Console.WriteLine("Introduceti numarul de numere ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i=0;i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Media geometrica este: ");
            Console.WriteLine(geometricMean(arr, n));

            Console.WriteLine("Media aritmetica este: ");
            Console.WriteLine(aritmeticMean(arr, n));

            Console.ReadKey();
        }

        static float geometricMean(int[] arr, int n)
        {
            float product = 1;
            for (int i = 0; i < n; i++)
                product = product * arr[i];
            float gm = (float)Math.Pow(product, (float)1 / n);
            return gm;
        }

        static float aritmeticMean(int[] arr, int n)
        {
            float sum = 0;
            for (int i = 0; i < n; i++)
                sum = sum + arr[i];
            float am = sum/n;
            return am;
        }
    }
}

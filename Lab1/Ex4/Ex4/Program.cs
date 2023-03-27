using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double inaltime = 0;
            int varsta = 0;
            char sex;
            Greutate g1 = new Greutate();
            
            Console.WriteLine("Introduceti inaltimea persoanei ");
            inaltime = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Introduceti varsta persoanei ");
            varsta = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti sexul persoanei ");
            sex = char.Parse(Console.ReadLine());

            switch(sex)
            {
                case 'f': g1.Afisare(inaltime, varsta, sex, g1.Femei(inaltime,varsta)); break;
                case 'm': g1.Afisare(inaltime, varsta, sex, g1.Barbati(inaltime, varsta)); break;
            }

            Console.ReadKey();
                




            


            



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Greutate
    {
        public double Femei(double inaltime, int varsta)
        {
            double greutate = 0;
            
            greutate = (inaltime - 100 - ((inaltime - 150) / 2.5)) + ((varsta - 20) / 6);
            return greutate;
        }

        public double Barbati(double inaltime,int varsta)
        {
            double greutate = 0;
            greutate = (inaltime - 100 - ((inaltime - 150) / 4)) + ((varsta - 20) / 4);
            return greutate;
        }

        public void Afisare(double inaltime, int varsta, char sex, double rezultat)
        {
            Console.WriteLine("{0} {1} {2} greutate ideala={3} kg",inaltime, varsta, sex, rezultat);
        }
    }
}

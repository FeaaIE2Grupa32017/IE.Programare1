using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Programare1.MedieNrPare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti n:");
            int n = Convert.ToInt32(Console.ReadLine());

            //ver. 1
            var suma = 0;
            double media = 0;
            int cateNumere = 0;
            for(int i = 0; i < n; i++)
            {
                if(i % 2 == 0)
                {
                    suma += i;
                    cateNumere++;
                }
            }
            media = suma / cateNumere;
            Console.WriteLine("v1:  Media este " + media);

            //ver.2
            for(int i = 0; i < n; i += 2)
            {

                suma += i;
                cateNumere++;

            }
            media = suma / cateNumere;
            Console.WriteLine($"v2: Media este {media}");

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Programare1.Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti n:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numere = new int[n];
            for(int i = 0; i < numere.Length; i++)
            {
                Console.WriteLine("Introduceti numarul:" + i);
                numere[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Introduceti a");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti b");
            int b = Convert.ToInt32(Console.ReadLine());
            
            //int temp = a;
            //if(a > b)
            //{
            //    a = b;
            //    b = temp;
            //}

            double suma = 0;
            int cateNr = 0;
            for(int i = 0; i < numere.Length; i++)
            {
                if(numere[i] > Math.Min(a,b) && numere[i] < Math.Max(a,b))
                {
                    suma += numere[i];
                    cateNr++;
                }
            }

            double media = suma / cateNr;
            Console.WriteLine($"Media este {media}");

            Console.ReadKey();
        }
    }
}

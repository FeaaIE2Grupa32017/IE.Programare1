using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Programare1.Problema14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int rest;
            int suma = 0;
            sbyte[] cifre = new sbyte[0];
            while(n > 0)
            {
                rest = n % 10;
                suma += rest;
                Array.Resize(ref cifre, cifre.Length + 1);
                cifre[cifre.Length - 1] = (sbyte)rest;
                n = n / 10;
            }

            string mesaj = "Cifrele lui n sunt: ";

            for(int i = 0; i < cifre.Length; i++)
            {
                mesaj += cifre[i] + " ";
            }

            Console.WriteLine(mesaj);
            Console.WriteLine("Suma este: " + suma);

            Console.ReadKey();
        }
    }
}

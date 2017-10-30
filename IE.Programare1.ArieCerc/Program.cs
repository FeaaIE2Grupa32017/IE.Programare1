using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Programare1.ArieCerc
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            Console.WriteLine("Raza:");
            double raza = Convert.ToDouble(Console.ReadLine());
            double aria = pi * raza * raza;
            Console.WriteLine($"Aria este:{aria}");

            Console.ReadLine();
        }
    }
}

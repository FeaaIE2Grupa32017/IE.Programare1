using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Programare1.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti operatia:");
            string operatia = Console.ReadLine();

            double rezultat = 0;
            bool operatieInvalida = false;
            switch(operatia)
            {
                case "+":
                    rezultat = a + b;
                    break;
                case "-":
                    rezultat = a - b;
                    break;
                case "*":
                    rezultat = a * b;
                    break;
                case ":":
                    rezultat = a / b;
                    break;
                default:
                    operatieInvalida = true;
                    break;
            }
            if(operatieInvalida)
            {
                Console.WriteLine("Operatia ceruta nu este suportata!");
            }
            else
            {
                Console.WriteLine($"Rezultat: {rezultat}");
            }

            Console.ReadKey();
        }
    }
}
